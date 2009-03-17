using System;
using System.Globalization;
using System.Threading;
using System.Windows.Data;
using System.Text;
using TaikodomStats.DataSL;

namespace TaikodomStats
{
    /// <summary>  
    /// A type converter for visibility and boolean values.  
    /// </summary>  
    public class CareerSimulatorBenefictsConverter : IValueConverter
    {
        private enum LabelType
        {
            Skill,
            Requeriment
        }

        private static string GetByCulture(LabelType labelType)
        {
            var cultureName = Thread.CurrentThread.CurrentCulture.Name;
            switch (labelType)
            {
                case LabelType.Skill:
                    if (cultureName == "pt-BR")
                        return "HABILIDADES";
                    return "SKILLS";
                case LabelType.Requeriment:
                    if (cultureName == "pt-BR")
                        return "REQUERIMENTOS";
                    return "REQUERIMENTS";
                default:
                    throw new ArgumentException("invalid label type", "labelType");
            }
        }

        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            var beneficts = new StringBuilder();
            
            beneficts.Append(GetByCulture(LabelType.Skill));
            beneficts.AppendLine();
            var ben = ((SkillPoint) value).Benefits;
            var bens = ben.Split(',');
            var cont = 0;
            foreach (var b in bens)
            {
                beneficts.Append(b);
                if (cont != bens.Length - 1)
                    beneficts.AppendLine();
                cont++;
            }
            var requeriments = ((SkillPoint) value).RequerimentLV;
            if (requeriments == null)
            {
                return beneficts;
            }
            beneficts.AppendLine();
            beneficts.Append(GetByCulture(LabelType.Requeriment));
            beneficts.AppendLine();
            beneficts.Append("Rank: " +  ((SkillPoint) value).RequerimentLV);
            return beneficts;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return null;
        }
    }
}