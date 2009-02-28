using System;
using NUnit.Framework;
using TaikodomStats.Data;

namespace TaikodomStats.DataSL.Tests
{
    [TestFixture]
    public class AssociationCareerSkillTests
    {
        [Test]
        public void AddSkillByCareerTest()
        {
            //throw new NotImplementedException();
            //// Careers
            var asCareer = new Career("As", 1);
            var merchantCareer = new Career("Merchant", 1);
            // Skill
            var afterburnSkill = new Skill("Afterburn");
            var gaussSkill = new Skill("Gauss");
            var railSkill = new Skill("Rail");
            var noSkill = new Skill("NoSkill");
            // Associate skill's to careers
            asCareer.AddSkillPoint(afterburnSkill, 1, "");
            asCareer.AddSkillPoint(afterburnSkill, 2, "");
            asCareer.AddSkillPoint(gaussSkill, 1, "");
            asCareer.AddSkillPoint(gaussSkill, 2, "");
            asCareer.AddSkillPoint(railSkill, 1, "");
            asCareer.AddSkillPoint(railSkill, 2, "");
            asCareer.AddSkillPoint(railSkill, 3, "");
            merchantCareer.AddSkillPoint(gaussSkill, 1, "");
            merchantCareer.AddSkillPoint(gaussSkill, 2, "");
            merchantCareer.AddSkillPoint(gaussSkill, 3, "");
            merchantCareer.AddSkillPoint(railSkill, 1, "");
            merchantCareer.AddSkillPoint(railSkill, 2, "");
            // Verify Careers associations
            // As Career
            Assert.AreEqual(3, asCareer.Skills.Length, "3 skills in as career");
            Assert.AreSame(asCareer.Skills[0], afterburnSkill);
            Assert.AreSame(asCareer.Skills[1], gaussSkill);
            Assert.AreSame(asCareer.Skills[2], railSkill);
            Assert.IsTrue(asCareer.ContainsSkill(afterburnSkill), "As contains afterburn");
            Assert.IsTrue(asCareer.ContainsSkill(gaussSkill), "As contains gauss");
            Assert.IsTrue(asCareer.ContainsSkill(railSkill), "As contains rail");
            Assert.IsFalse(asCareer.ContainsSkill(noSkill), "As does not contains no skill");
            // Merchant Career
            Assert.AreEqual(2, merchantCareer.Skills.Length, "2 skills in merchant career");
            Assert.AreSame(merchantCareer.Skills[0], gaussSkill);
            Assert.AreSame(merchantCareer.Skills[1], railSkill);
            Assert.IsTrue(merchantCareer.ContainsSkill(gaussSkill), "Merchant contains gauss");
            Assert.IsTrue(merchantCareer.ContainsSkill(railSkill), "Merchant contains rail");
            Assert.IsFalse(merchantCareer.ContainsSkill(afterburnSkill), "Merchant does not contains afterburn");
            Assert.IsFalse(asCareer.ContainsSkill(noSkill), "Merchant does not contains no skill");
            // Verify skill associations
            // Afterburn
            Assert.AreEqual(1, afterburnSkill.Careers.Length, "1 career with afterburn skill");
            Assert.AreSame(afterburnSkill.Careers[0], asCareer);
            Assert.IsTrue(afterburnSkill.ContainedInCareer(asCareer), "afterburn contained in As career");
            Assert.IsFalse(afterburnSkill.ContainedInCareer(merchantCareer),
                           "afterburn does not is contained in merchant career");
            // Gauss
            Assert.AreEqual(2, gaussSkill.Careers.Length, "2 career with gauss skill");
            Assert.AreSame(gaussSkill.Careers[0], asCareer);
            Assert.AreSame(gaussSkill.Careers[1], merchantCareer);
            Assert.IsTrue(gaussSkill.ContainedInCareer(asCareer), "gauss contained in As career");
            Assert.IsTrue(gaussSkill.ContainedInCareer(merchantCareer), "gauss contained in Merchat career");
            // Rail
            Assert.AreEqual(2, railSkill.Careers.Length, "2 career with rail skill");
            Assert.AreSame(railSkill.Careers[0], asCareer);
            Assert.AreSame(railSkill.Careers[1], merchantCareer);
            Assert.IsTrue(railSkill.ContainedInCareer(asCareer), "rail contained in As career");
            Assert.IsTrue(railSkill.ContainedInCareer(merchantCareer), "rail contained in Merchat career");
            // NoSkill
            Assert.AreEqual(0, noSkill.Careers.Length, "0 career with NoSkill skill ");
            Assert.IsFalse(noSkill.ContainedInCareer(asCareer), "no skill does not contained contained in as");
            Assert.IsFalse(noSkill.ContainedInCareer(merchantCareer), "no skill does not contained in merchant");
        }
    }
}