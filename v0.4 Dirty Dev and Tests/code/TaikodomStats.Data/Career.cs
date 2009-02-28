/*
 * Criado por SharpDevelop.
 * Usuário: Jenser
 * Data: 28/12/2008
 * Hora: 23:27
 * 
 * Para alterar este modelo use Ferramentas | Opções | Codificação | Editar Cabeçalhos Padrão.
 */
using System.Collections.Generic;
using System.Linq;

namespace TaikodomStats.Data
{
    /// <summary>
    /// Careers of Taikodom
    /// </summary>
    public class Career
    {
        public Career(string name, short totalPoints)
        {
            Name = name;
            TotalPoints = totalPoints;
            skillPoints = new List<SkillPoint>();
        }

        private readonly List<SkillPoint> skillPoints;

        public short TotalPoints { get; set; }

        public Skill[] Skills
        {
            get { return (from skillPoint in skillPoints select skillPoint.Skill).Distinct().ToArray(); }
        }

        public SkillPoint[] SkillPoints
        {
            get { return skillPoints.ToArray(); }
        }

        public string Name { get; set; }

        public void AddSkillPoint(Skill skill, short point, string benefits)
        {
            var skillPoint = GetSkillPoint(skill, point);
            if (skillPoint == null)
            {
                skillPoint = new SkillPoint(this, skill, point, benefits);
                skillPoints.Add(skillPoint);
            }
            skillPoint.Benefits = benefits;
            if (!skill.ContainedInCareer(this))
            {
                skill.AddToCareer(this);
            }
        }

        private SkillPoint GetSkillPoint(Skill skill, short point)
        {
            var q = from skillPoint in skillPoints
                    where skillPoint.Skill == skill && skillPoint.Point == point
                    select skillPoint;
            return q.FirstOrDefault();

        }

        public bool ContainsSkill(Skill skill)
        {
            IEnumerable<Skill> q = from s in Skills where s == skill select s;
            bool contains = q.Count() > 0;
            return contains;
        }

        public SkillPoint[] GetSkillPoints(Skill skill)
        {
            return skillPoints.FindAll(sp => sp.Skill == skill).ToArray();
        }

        public override string ToString()
        {
            return Name;
        }
    }
}