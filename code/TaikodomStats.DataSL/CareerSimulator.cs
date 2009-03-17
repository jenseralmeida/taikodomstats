using System;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;

namespace TaikodomStats.DataSL
{
    /// <summary>
    /// Simulation of careers and distribuition of points of skills
    /// </summary>
    public class CareerSimulator : INotifyPropertyChanged
    {
        public CareerSimulator(string name, Career career)
        {
            skillPointsBySkillSimulator = new ObservableCollection<SkillPointsBySkillSimulator>();
            Name = name;
            Career = career;
        }

        private Career career;
        private string name;
        private Rank currentRank;
        private readonly ObservableCollection<SkillPointsBySkillSimulator> skillPointsBySkillSimulator;

        public string Name
        {
            get { return name; }
            set
            {
                name = value;
                OnPropertyChanged("Name");
            }
        }

        public Career Career
        {
            get { return career; }
            set
            {
                career = value;
                skillPointsBySkillSimulator.Clear();
                SkillPointsBySkillSimulator[] newPointsBySkillSimulators =
                    SkillPointsBySkillSimulator.CreateSkillPointsBySkillSimulator(career);
                foreach (var newPointsBySkillSimulator in newPointsBySkillSimulators)
                {
                    skillPointsBySkillSimulator.Add(newPointsBySkillSimulator);
                }
                ConfigDefaultSkillPoints();
                CurrentRank = career.GetRank(1);
                OnPropertyChanged(null);
            }
        }

        private void ConfigDefaultSkillPoints()
        {
            var q = from c in SkillPointsBySkill
                    from i in c.AvaliableSkillPoints
                    where i.Point == 1 && i.IsDefault
                    select i;
            foreach (var sp in q)
            {
                GetSkillPointBySkillSimulator(sp.Skill).CheckSkillPoint(sp);
                GetSkillPointBySkillSimulator(sp.Skill).CheckDefaultSkillPoint(sp);
            }
        }

        public Rank CurrentRank
        {
            get { return currentRank; }
            set
            {
                currentRank = value;
                OnPropertyChanged("CurrentRank");
                UsedSkillPointsPropertyChangedNotify();
            }
        }

        public Rank[] Ranks
        {
            get
            {
                return career.Ranks;
            }
        }

        #region Used Skill Points

        public short NumberOfUsedSkillPoints
        {
            get { return (short)SkillPointsBySkillSimulator.GetUsedSkillPoints(skillPointsBySkillSimulator).Count(); }
        }

        public short NumberOfAvailableSkillPoints
        {
            get { return (short)(CurrentRank.TotalPoints - NumberOfUsedSkillPoints); }
        }

        public ObservableCollection<SkillPointsBySkillSimulator> SkillPointsBySkill
        {
            get { return skillPointsBySkillSimulator; }
        }

        #endregion Used Skill Points

        #region Increment / Decrement SkillPoint util

        public bool SetSkillPoint(SkillPoint skillPoint, byte rank)
        {
            Skill skill = skillPoint.Skill;
            short point = skillPoint.Point;
            SkillPoint lastUsedSkillPoint = GetSkillPointBySkillSimulator(skill).GetLastUsedSkillPointBySkill();
            short actualUsedPoint = (lastUsedSkillPoint == null) ? (short)0 : lastUsedSkillPoint.Point;
            int diferenceOfPoints = point - actualUsedPoint;
            bool doIncrementOfSkillPoints = diferenceOfPoints > 0;
            bool sucess = false;
            //Get Abs value to control in a uniform way the increment or decrement of skill points
            diferenceOfPoints = Math.Abs(diferenceOfPoints);
            while ((diferenceOfPoints--) != 0)
            {
                sucess = doIncrementOfSkillPoints ? IncrementSkillPoint(skill, rank) : DecrementSkillPoint(skill);
                if (!sucess)
                {
                    break;
                }
            }
            return sucess;
        }

        public bool IncrementSkillPoint(Skill skill, byte rank)
        {
            bool retorno = false;
            if (NumberOfUsedSkillPoints < CurrentRank.TotalPoints)
            {
                //throw new InvalidOperationException("There is mores skill points used that total point of the career");
                if (career.ContainsSkill(skill))
                {
                    //throw new ArgumentException("The informed skill must exist in selected career", "skill");
                    SkillPoint firstUnusedSkillPoint = GetSkillPointBySkillSimulator(skill).GetFirstUnsedSkillPoint();
                    if (firstUnusedSkillPoint != null && (firstUnusedSkillPoint.RequerimentLV <= rank || firstUnusedSkillPoint.RequerimentLV == null))
                    {
                        //throw new InvalidOperationException("There is no new unsed skill point in the selected skill");
                        GetSkillPointBySkillSimulator(skill).CheckSkillPoint(firstUnusedSkillPoint);
                        retorno = true;
                    }
                }
            }
            UsedSkillPointsPropertyChangedNotify();
            return retorno;
        }

        public bool DecrementSkillPoint(Skill skill)
        {
            bool retorno = false;
            if (career.ContainsSkill(skill))
            {
                //throw new ArgumentException("The informed skill must exist in selected career", "skill");
                SkillPoint lastUsedSkillPoint = GetSkillPointBySkillSimulator(skill).GetLastUsedSkillPointBySkill();
                if (lastUsedSkillPoint != null)
                {
                    if (!lastUsedSkillPoint.IsDefault)
                    {
                        //throw new InvalidOperationException("There is no used skill point to the skill informed");
                        GetSkillPointBySkillSimulator(skill).UncheckSkillPoint(lastUsedSkillPoint);
                        retorno = true;
                    }
                }
            }
            UsedSkillPointsPropertyChangedNotify();
            return retorno;
        }

        private SkillPointsBySkillSimulator GetSkillPointBySkillSimulator(Skill skill)
        {
            return (from pointsBySkillSimulator in skillPointsBySkillSimulator
                    where pointsBySkillSimulator.Skill == skill
                    select pointsBySkillSimulator).FirstOrDefault();
        }


        private void UsedSkillPointsPropertyChangedNotify()
        {
            OnPropertyChanged("NumberOfUsedSkillPoints");
            OnPropertyChanged("NumberOfAvailableSkillPoints");
        }

        #endregion

        /// <summary>
        /// Create a new instance of <see cref="CareerSimulator"/> with all the values copied
        /// </summary>
        /// <returns></returns>
        public CareerSimulator Clone()
        {
            //var clonedCS = new CareerSimulator(rankNumber, Career);
            //clonedCS.usedSkillPoints.AddRange(usedSkillPoints);
            //return clonedCS;
            throw new NotImplementedException();
        }

        public bool IsLastUsedSkillPoint(SkillPoint skillPoint)
        {
            if (skillPoint == null)
                return false;
            SkillPoint lastUsedSkillPoint = GetSkillPointBySkillSimulator(skillPoint.Skill).GetLastUsedSkillPointBySkill();
            return skillPoint.Equals(lastUsedSkillPoint);
        }

        #region INotifyPropertyChanged interface

        public event PropertyChangedEventHandler PropertyChanged;

        private void OnPropertyChanged(string propertyName)
        {
            var e = new PropertyChangedEventArgs(propertyName);
            if (PropertyChanged != null)
                PropertyChanged(this, e);
        }

        #endregion INotifyPropertyChanged
    }
}