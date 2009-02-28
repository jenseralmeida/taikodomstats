using System.Collections.Generic;
using System.Linq;

namespace TaikodomStats.DataSL
{
    public class SkillPointsBySkill
    {
        public SkillPointsBySkill(Skill skill, IEnumerable<SkillPoint> skillPoints)
        {
            Skill = skill;
            SkillPoints = skillPoints.ToArray();
        }

        internal static SkillPointsBySkill[] GetSkillPointsBySkill(Skill[] skills, SkillPoint[] skillPoints)
        {
            var q = from Skill s in skills
                    let skillPointsBySkill = GetSkillPointsBySkill(s, skillPoints)
                    select new SkillPointsBySkill(s, skillPointsBySkill);
            return q.ToArray();
        }

        internal static IEnumerable<SkillPoint> GetSkillPointsBySkill(Skill skill, IEnumerable<SkillPoint> skillPoints)
        {
            return from skillPoint in skillPoints
                   where skillPoint.Skill == skill
                   select skillPoint;
        }

        public Skill Skill { get; private set; }

        public SkillPoint[] SkillPoints { get; private set; }
    }

}
