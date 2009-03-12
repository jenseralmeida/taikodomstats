using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;

namespace TaikodomStats.DataSL
{
    public class SkillPointsBySkillSimulator
    {
        private readonly ObservableCollection<SkillPoint> usedSkillPoints;
        private readonly ObservableCollection<SkillPoint> defaultSkillPoints;

        public SkillPointsBySkillSimulator(Skill skill, IEnumerable<SkillPoint> avaliableSkillPoints)
        {
            Skill = skill;
            AvaliableSkillPoints = avaliableSkillPoints.ToArray();
            usedSkillPoints = new ObservableCollection<SkillPoint>();
            defaultSkillPoints = new ObservableCollection<SkillPoint>();
        }

        public Skill Skill { get; private set; }

        public SkillPoint[] AvaliableSkillPoints { get; private set; }

        public ObservableCollection<SkillPoint> UsedSkillPoints
        {
            get { return usedSkillPoints; }
        }

        public ObservableCollection<SkillPoint> DefaultSkillPoints
        {
            get { return defaultSkillPoints; }
        }

        internal SkillPoint GetLastUsedSkillPointBySkill()
        {
            IOrderedEnumerable<SkillPoint> query = from SkillPoint sp in usedSkillPoints
                                                   where sp.Skill == Skill
                                                   orderby sp.Point descending
                                                   select sp;
            return query.FirstOrDefault();
        }


        internal SkillPoint GetFirstUnsedSkillPoint()
        {
            SkillPoint lastUsedSkillPoint = GetLastUsedSkillPointBySkill();
            IOrderedEnumerable<SkillPoint> q = from SkillPoint sp in AvaliableSkillPoints
                                               where
                                                   ((lastUsedSkillPoint == null) ||
                                                    (sp.Point > lastUsedSkillPoint.Point)) &&
                                                   Skill.Name == sp.Skill.Name
                                               orderby sp.Point
                                               select sp;
            return q.FirstOrDefault();
        }

        internal static SkillPointsBySkillSimulator[] GetSkillPointsBySkill(Skill[] skills, SkillPoint[] skillPoints)
        {
            IEnumerable<SkillPointsBySkillSimulator> q = from Skill s in skills
                                                         let skillPointsBySkill = GetSkillPointsBySkill(s, skillPoints)
                                                         select new SkillPointsBySkillSimulator(s, skillPointsBySkill);
            return q.ToArray();
        }

        internal static SkillPoint[] GetUsedSkillPoints(
            IEnumerable<SkillPointsBySkillSimulator> skillPointsBySkillSimulators)
        {
            return (from skillPointSimulator in skillPointsBySkillSimulators
                    from usedSkillPoint in skillPointSimulator.UsedSkillPoints
                    select usedSkillPoint).ToArray();
        }

        internal static SkillPoint[] GetDefaultSkillPoints(
            IEnumerable<SkillPointsBySkillSimulator> skillPointsBySkillSimulators)
        {
            return (from skillPointSimulator in skillPointsBySkillSimulators
                    from defaultSkillPoint in skillPointSimulator.DefaultSkillPoints
                    select defaultSkillPoint).ToArray();
        }

        internal static IEnumerable<SkillPoint> GetSkillPointsBySkill(Skill skill, IEnumerable<SkillPoint> skillPoints)
        {
            return from skillPoint in skillPoints
                   where skillPoint.Skill == skill
                   select skillPoint;
        }

        internal void CheckSkillPoint(SkillPoint skillPoint)
        {
            usedSkillPoints.Add(skillPoint);
        }

        internal void UncheckSkillPoint(SkillPoint skillPoint)
        {
            usedSkillPoints.Remove(skillPoint);
        }

        internal void CheckDefaultSkillPoint(SkillPoint skillPoint)
        {
            defaultSkillPoints.Add(skillPoint);
        }

        internal static SkillPointsBySkillSimulator[] CreateSkillPointsBySkillSimulator(SkillPointsBySkill[] skill)
        {
            var list = new List<SkillPointsBySkillSimulator>(skill.Length);
            foreach (SkillPointsBySkill bySkill in skill)
            {
                var simulator = new SkillPointsBySkillSimulator(bySkill.Skill,
                                                                bySkill.SkillPoints);
                list.Add(simulator);
            }
            return list.ToArray();
        }
    }
}