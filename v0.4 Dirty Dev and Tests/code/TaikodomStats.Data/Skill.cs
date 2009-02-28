/*
 * Criado por SharpDevelop.
 * Usuário: Jenser
 * Data: 28/12/2008
 * Hora: 23:34
 * 
 * Para alterar este modelo use Ferramentas | Opções | Codificação | Editar Cabeçalhos Padrão.
 */
using System.Collections.Generic;
using System.Linq;

namespace TaikodomStats.Data
{
    /// <summary>
    /// Description of Skill.
    /// </summary>
    public class Skill
    {
        private readonly List<Career> careers;
        private readonly IDictionary<short, SkillPoint> skillPoints;

        public Skill(string name)
        {
            Name = name;
            careers = new List<Career>();
            skillPoints = new SortedList<short, SkillPoint>();
        }

        public string Name { get; set; }

        public Career[] Careers
        {
            get { return careers.ToArray(); }
        }

        /// <summary>
        /// Add Career to the list of contained careers of the skill
        /// </summary>
        /// <param name="career"></param>
        internal void AddToCareer(Career career)
        {
            if (!ContainedInCareer(career))
            {
                careers.Add(career);
            }
        }

        public bool ContainedInCareer(Career career)
        {
            IEnumerable<Career> q = from c in careers where c == career select c;
            bool contains = q.Count() > 0;
            return contains;
        }

        public override string ToString()
        {
            return Name;
        }
    }
}