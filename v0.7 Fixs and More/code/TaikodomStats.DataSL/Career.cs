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

namespace TaikodomStats.DataSL
{
    /// <summary>
    /// Careers of Taikodom
    /// </summary>
    public class Career
    {
        public static Career[] GetAll()
        {
            return RepositoryOfData.GetCareers();
        }
        
        public Career(string name)
        {
            Name = name;
            skillPoints = new List<SkillPoint>();
            ranks = new List<Rank>(50);
            CreateDefaultRankList();
        }

        private void CreateDefaultRankList()
        {
            ranks.Add(new Rank(1, 3));
            byte countToDoubleIncrement = 1;
            for (byte rankNumber = 2, totalPoints = 3; rankNumber <= 50; rankNumber++)
            {
                ++totalPoints;
                if (--countToDoubleIncrement == 0)
                {
                    ++totalPoints;
                    countToDoubleIncrement = 3;
                }
                ranks.Add(new Rank(rankNumber, totalPoints));
            }
        }

        private readonly List<Rank> ranks;
        private readonly List<SkillPoint> skillPoints;


        public Rank GetRank(byte rankNumber)
        {
            return (from r in Ranks where r.RankNumber == rankNumber select r).FirstOrDefault();
        }
        
        public Skill[] Skills
        {
            get { return (from skillPoint in skillPoints select skillPoint.Skill).Distinct().ToArray(); }
        }

        public SkillPoint[] SkillPoints
        {
            get { return skillPoints.ToArray(); }
        }

        public string Name { get; set; }

        public Rank[] Ranks
        {
            get { return ranks.ToArray(); }
        }

        public void AddSkillPoint(Skill skill, short point, string benefits, bool isDefault, int? requerimentLV)
        {
            var skillPoint = GetSkillPoint(skill, point);
            if (skillPoint == null)
            {
                skillPoint = new SkillPoint(this, skill, point, benefits, isDefault, requerimentLV);
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
            var q = from s in Skills where s == skill select s;
            var contains = q.Count() > 0;
            return contains;
        }

        public SkillPoint[] GetSkillPoints(Skill skill)
        {
            return (from sp in skillPoints where sp.Skill == skill select sp).ToArray();
        }

        public override string ToString()
        {
            return Name;
        }
    }
}