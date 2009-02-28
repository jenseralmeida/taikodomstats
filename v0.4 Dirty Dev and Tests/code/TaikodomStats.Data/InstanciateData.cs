namespace TaikodomStats.Data
{
    public static class InstanciateData
    {
        public static Career[] GetCareers()
        {
            #region Skills

            Skill skill1 = new Skill("Skill 1");
            Skill skill2 = new Skill("Skill 2");
            Skill skill3 = new Skill("Skill 3");
            Skill skill4 = new Skill("Skill 4");
            Skill skill5 = new Skill("Skill 5");

            #endregion

            #region Career

            Career c1 = new Career("CAREER1", 25);
            Career c2 = new Career("CAREER2", 15);
            Career c3 = new Career("CAREER3", 10);

            #endregion

            #region Career 1/SkillPoint

            c1.AddSkillPoint(skill1, 1, "");
            c1.AddSkillPoint(skill1, 2, "");
            c1.AddSkillPoint(skill1, 3, "");
            c1.AddSkillPoint(skill1, 4, "");

            c1.AddSkillPoint(skill2, 1, "");
            c1.AddSkillPoint(skill2, 2, "");
            c1.AddSkillPoint(skill2, 3, "");
            c1.AddSkillPoint(skill2, 4, "");

            c1.AddSkillPoint(skill3, 1, "");
            c1.AddSkillPoint(skill3, 2, "");

            c1.AddSkillPoint(skill4, 1, "");
            c1.AddSkillPoint(skill4, 2, "");

            c1.AddSkillPoint(skill5, 1, "");
            c1.AddSkillPoint(skill5, 2, "");

            #endregion Career 1/SkillPoint

            #region Career 2/SkillPoint

            c2.AddSkillPoint(skill1, 1, "");
            c2.AddSkillPoint(skill1, 2, "");
            c2.AddSkillPoint(skill1, 3, "");
            c2.AddSkillPoint(skill1, 4, "");

            c2.AddSkillPoint(skill2, 1, "");
            c2.AddSkillPoint(skill2, 2, "");
            c2.AddSkillPoint(skill2, 3, "");
            c2.AddSkillPoint(skill2, 4, "");

            c2.AddSkillPoint(skill3, 1, "");
            c2.AddSkillPoint(skill3, 2, "");

            #endregion Career 2/SkillPoint

            #region Career 3/SkillPoint

            c3.AddSkillPoint(skill3, 1, "");
            c3.AddSkillPoint(skill3, 2, "");

            c3.AddSkillPoint(skill4, 1, "");
            c3.AddSkillPoint(skill4, 2, "");

            c3.AddSkillPoint(skill5, 1, "");
            c3.AddSkillPoint(skill5, 2, "");

            #endregion Career 3/SkillPoint

            return new[] { c1, c2, c3 };
        }
    }
}