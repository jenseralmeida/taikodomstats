using System;
using System.Collections.Generic;
using System.Linq;

namespace TaikodomStats.Data
{
    /// <summary>
    /// Simulation of careers and distribuition of points of skills
    /// </summary>
    public class CareerSimulator : ICloneable
    {
        private readonly List<SkillPoint> usedSkillPoints;
        private Career career;

        public CareerSimulator(string name, Career career)
        {
            Name = name;
            Career = career;
            usedSkillPoints = new List<SkillPoint>();
        }

        public string Name { get; set; }

        public Career Career
        {
            get { return career; }
            // TODO: Permit public change of career. Do tests before
            private set { career = value; }
        }

        public short NumberOfUsedSkillPoints
        {
            get { return (short) usedSkillPoints.Count(); }
        }

        public SkillPoint[] UsedSkillPoints
        {
            get { return usedSkillPoints.ToArray(); }
        }

        // TODO: Test first, reenable after write Unit tests e enable public Career change
        //public SkillPoint[] ValidUsedSkillPointsToCareer
        //{
        //    get
        //    {
        //        var query = from SkillPoint sp in usedSkillPoints where career.ContainsSkill(sp.Skill) select sp;
        //        return query.ToArray();
        //    }
        //}


        // TODO: Test first, reenable after write Unit tests e enable public Career change
        //public SkillPoint[] InvalidUsedSkillPointsToCareer
        //{
        //    get
        //    {
        //        var query = from SkillPoint sp in usedSkillPoints where !career.ContainsSkill(sp.Skill) select sp;
        //        return query.ToArray();
        //    }
        //}

        #region ICloneable Members

        object ICloneable.Clone()
        {
            return Clone();
        }

        #endregion


        public void IncrementSkillPoint(Skill skill)
        {
            if (usedSkillPoints.Count >= career.TotalPoints)
            {
                throw new InvalidOperationException("There is mores skill points used that total point of the career");
            }
            if (!career.ContainsSkill(skill))
            {
                throw new ArgumentException("The informed skill must exist in selected career", "skill");
            }
            SkillPoint firstUnusedSkillPoint = GetFirstUnsedSkillPoint(skill);
            if (firstUnusedSkillPoint == null)
            {
                throw new InvalidOperationException("There is no new unsed skill point in the selected skill");
            }
            usedSkillPoints.Add(firstUnusedSkillPoint);
        }

        /// <summary>
        /// Create a new instance of <see cref="CareerSimulator"/> with all the values copied
        /// </summary>
        /// <returns></returns>
        public CareerSimulator Clone()
        {
            var clonedCS = new CareerSimulator(Name, Career);
            clonedCS.usedSkillPoints.AddRange(usedSkillPoints);
            return clonedCS;
        }

        #region IncrementSkillPoint

        private SkillPoint GetFirstUnsedSkillPoint(Skill skill)
        {
            SkillPoint lastUsedSkillPoint = GetLastUsedSkillPointBySkill(skill);
            IOrderedEnumerable<SkillPoint> q = from SkillPoint sp in career.SkillPoints
                                               where
                                                   (lastUsedSkillPoint == null) || (sp.Point > lastUsedSkillPoint.Point)
                                               orderby sp.Point
                                               select sp;
            return q.FirstOrDefault();
        }


        private SkillPoint GetLastUsedSkillPointBySkill(Skill skill)
        {
            IOrderedEnumerable<SkillPoint> query = from SkillPoint sp in usedSkillPoints
                                                   where sp.Skill == skill
                                                   orderby sp.Point descending
                                                   select sp;
            return query.FirstOrDefault();
        }

        #endregion

        public void DecrementSkillPoint(Skill skill)
        {
            if (!career.ContainsSkill(skill))
            {
                throw new ArgumentException("The informed skill must exist in selected career", "skill");
            }
            SkillPoint lastUsedSkillPoint = GetLastUsedSkillPointBySkill(skill);
            if (lastUsedSkillPoint == null)
            {
                throw new InvalidOperationException("There is no used skill point to the skill informed");
            }
            usedSkillPoints.Remove(lastUsedSkillPoint);
        }
    }
}