/*
 * Criado por SharpDevelop.
 * Usuário: Jenser
 * Data: 29/12/2008
 * Hora: 0:46
 * 
 * Para alterar este modelo use Ferramentas | Opções | Codificação | Editar Cabeçalhos Padrão.
 */
using System;

namespace TaikodomStats.DataSL
{
    /// <summary>
    /// Description of UsedSkillPoints.
    /// </summary>
    public class SkillPoint: IComparable
    {
        internal SkillPoint(Career career, Skill skill, short point, string benefits)
        {
            Career = career;
            Skill = skill;
            Point = point;
            Benefits = benefits;
        }

        public Skill Skill { get; private set; }

        public short Point { get; private set; }

        public string Benefits { get; set; }

        public Career Career { get; private set; }

        public override bool Equals(object obj)
        {
            SkillPoint sp = obj as SkillPoint;
            if (sp == null)
            {
                return false;
            }
            return (sp.Career == Career) && (sp.Skill == Skill) && (sp.Point == Point);
        }

        public override int GetHashCode()
        {
            // TODO: Implementar GetHashCode
            return base.GetHashCode();
        }

        public int CompareTo(object obj)
        {
            if (obj == null)
            {
                throw new NullReferenceException();
            }
            if (!(obj is SkillPoint))
            {
                throw new InvalidOperationException("Cannot implicit convert from <obj> to SkillPoint");
            }

            var skillPoint = (SkillPoint)obj;
            return skillPoint.Point.CompareTo(Point);
        }
    }
}