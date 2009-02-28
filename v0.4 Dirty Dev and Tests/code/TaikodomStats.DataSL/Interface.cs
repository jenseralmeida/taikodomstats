using System;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Shapes;

namespace TaikodomStats.DataSL
{
    public class Interface
    {
        public Interface(Skill skill, SkillPoint skillPoint1, SkillPoint skillPoint2
            , SkillPoint skillPoint3, SkillPoint skillPoint4, SkillPoint skillPoint5, SkillPoint skillPoint6
            , SkillPoint skillPoint7, SkillPoint skillPoint8, SkillPoint skillPoint9, SkillPoint skillPoint10
            , SkillPoint skillPoint11, SkillPoint skillPoint12, SkillPoint skillPoint13, SkillPoint skillPoint14
            , SkillPoint skillPoint15)
        {
            Skill = skill;
            SkillPoint15 = skillPoint15;
            SkillPoint14 = skillPoint14;
            SkillPoint13 = skillPoint13;
            SkillPoint12 = skillPoint12;
            SkillPoint11 = skillPoint11;
            SkillPoint10 = skillPoint10;
            SkillPoint9 = skillPoint9;
            SkillPoint8 = skillPoint8;
            SkillPoint7 = skillPoint7;
            SkillPoint6 = skillPoint6;
            SkillPoint5 = skillPoint5;
            SkillPoint4 = skillPoint4;
            SkillPoint3 = skillPoint3;
            SkillPoint2 = skillPoint2;
            SkillPoint1 = skillPoint1;
        }

        public Skill Skill { get; private set; }

        public SkillPoint SkillPoint1 { get; private set; }
        public SkillPoint SkillPoint2 { get; private set; }
        public SkillPoint SkillPoint3 { get; private set; }
        public SkillPoint SkillPoint4 { get; private set; }
        public SkillPoint SkillPoint5 { get; private set; }
        public SkillPoint SkillPoint6 { get; private set; }
        public SkillPoint SkillPoint7 { get; private set; }
        public SkillPoint SkillPoint8 { get; private set; }
        public SkillPoint SkillPoint9 { get; private set; }
        public SkillPoint SkillPoint10 { get; private set; }
        public SkillPoint SkillPoint11 { get; private set; }
        public SkillPoint SkillPoint12 { get; private set; }
        public SkillPoint SkillPoint13 { get; private set; }
        public SkillPoint SkillPoint14 { get; private set; }
        public SkillPoint SkillPoint15 { get; private set; }
    }
}

 
