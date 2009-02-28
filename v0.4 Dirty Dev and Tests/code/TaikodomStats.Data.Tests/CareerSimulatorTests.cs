using System;
using NUnit.Framework;
using TaikodomStats.Data;

namespace TaikodomStats.DataSL.Tests
{
    [TestFixture]
    public class CareerSimulatorTests
    {
        [Test]
        [Ignore]
        public void ChangeCareerTest()
        {
            // Enable change of career, with the same distribution of points
            // The entire validation will be burled with this new rule, and some new code to see the erros must be enabled
            // Example, if the old career accept 4 points of skill, and the new one accept only 3, some warning/errors must be showed
            // for the end user
            throw new NotImplementedException();
        }


        [Test]
        public void CloneTest()
        {
            var career = new Career("Test", 3);
            var skill1 = new Skill("skill1");
            career.AddSkillPoint(skill1, 1, "");
            career.AddSkillPoint(skill1, 2, "");
            // Creating original CareerSimulator
            var originalCS = new CareerSimulator("OriginalName", career);
            originalCS.IncrementSkillPoint(skill1);
            // Cloning CareerSimulator
            CareerSimulator clonedCS = originalCS.Clone();
            // Verify if the state of the 2 objects, are equals, but not the same
            Assert.AreNotSame(originalCS, clonedCS);
            Assert.AreEqual(originalCS.Name, clonedCS.Name);
            Assert.AreSame(originalCS.Career, clonedCS.Career);
            Assert.AreEqual(originalCS.NumberOfUsedSkillPoints, clonedCS.NumberOfUsedSkillPoints);
            for (int i = 0; i < originalCS.NumberOfUsedSkillPoints; i++)
            {
                Assert.AreSame(originalCS.UsedSkillPoints[i], clonedCS.UsedSkillPoints[i]);
            }
            // Change the original CareerSimulator and verify if the cloned CareerSimulator remain the same
            originalCS.IncrementSkillPoint(skill1);
            originalCS.Name = "ChangedName";
            // Verify state of the original CareerSimulator
            Assert.AreNotSame(originalCS, clonedCS);
            Assert.AreEqual("ChangedName", originalCS.Name);
            Assert.AreEqual(2, originalCS.NumberOfUsedSkillPoints);
            Assert.AreSame(career.GetSkillPoints(skill1)[0], originalCS.UsedSkillPoints[0]);
            Assert.AreSame(career.GetSkillPoints(skill1)[1], originalCS.UsedSkillPoints[1]);
            // Verify state of the cloned CareerSimulator
            Assert.AreEqual("OriginalName", clonedCS.Name);
            Assert.AreEqual(1, clonedCS.NumberOfUsedSkillPoints);
            Assert.AreSame(career.GetSkillPoints(skill1)[0], clonedCS.UsedSkillPoints[0]);
        }

        [Test]
        [Ignore]
        public void DecrementSkillPointTest()
        {
            //throw new NotImplementedException();
            var career = new Career("Ás", 3);
            var skill1 = new Skill("Pilotagem");
            var skill2 = new Skill("Afterburn");
            var skill3 = new Skill("Balistico");
            // skill 1

            career.AddSkillPoint(skill1, 1, "+ 2% Velocidade");
            career.AddSkillPoint(skill1, 2, "+ 2% Velocidade");
            career.AddSkillPoint(skill1, 3, "+ 2% Velocidade");

            // skill 2
            career.AddSkillPoint(skill2, 1, "+ 2% Aceleração");
            career.AddSkillPoint(skill2, 2, "+ 2% Aceleração");
            career.AddSkillPoint(skill2, 3, "+ 2% Aceleração");

            // skill 3
            career.AddSkillPoint(skill3, 1, "+ 2% Cadência, + 2 % Dano");
            career.AddSkillPoint(skill3, 2, "+ 2% Cadência, + 2 % Dano");
            career.AddSkillPoint(skill3, 3, "+ 2% Cadência, + 2 % Dano");

            // Career simulation
            var cs = new CareerSimulator("Test", career);
            cs.IncrementSkillPoint(skill1);
            cs.IncrementSkillPoint(skill1);
            cs.IncrementSkillPoint(skill2);
            cs.IncrementSkillPoint(skill2);
            cs.IncrementSkillPoint(skill2);

            cs.DecrementSkillPoint(skill1);
            // Assert skill1
            Assert.AreEqual(4, cs.NumberOfUsedSkillPoints);
            bool existSkillPoint1OfSkill1 =
                Array.Exists(cs.UsedSkillPoints, sp => sp == career.SkillPoints[1]);
            bool existSkillPoint2OfSkill1 =
                Array.Exists(cs.UsedSkillPoints, sp => sp == career.SkillPoints[2]);
            Assert.IsTrue(existSkillPoint1OfSkill1);
            Assert.IsFalse(existSkillPoint2OfSkill1);
            //// Assert skill2
            //cs.DecrementSkillPoint(skill2);
            //cs.DecrementSkillPoint(skill2);
            //cs.DecrementSkillPoint(skill2);
            //Assert.AreEqual(1, cs.NumberOfUsedSkillPoints);
            //bool existSkillPoint1OfSkill2 =
            //    Array.Exists(cs.UsedSkillPoints, sp => sp == career.SkillPoints[3]);
            //bool existSkillPoint2OfSkill2 =
            //    Array.Exists(cs.UsedSkillPoints, sp => sp == career.SkillPoints[4]);
            //bool existSkillPoint3OfSkill2 =
            //    Array.Exists(cs.UsedSkillPoints, sp => sp == career.SkillPoints[5]);
            //Assert.IsFalse(existSkillPoint1OfSkill2);
            //Assert.IsFalse(existSkillPoint2OfSkill2);
            //Assert.IsFalse(existSkillPoint3OfSkill2);
            bool invalidOperationException = false;
            try
            {
                cs.DecrementSkillPoint(skill2);
            }
            catch (Exception e)
            {
                invalidOperationException = true;
                Assert.AreEqual("There is no used skill point to the skill informed", e.Message);
            }
            Assert.IsTrue(invalidOperationException);

            invalidOperationException = false;
            try
            {
                cs.DecrementSkillPoint(skill3);
            }
            catch (Exception e)
            {
                invalidOperationException = true;
                Assert.IsTrue(e.Message.StartsWith("The informed skill must exist in selected career"));
            }
            Assert.IsTrue(invalidOperationException);
        }

        [Test]
        [Ignore]
        public void IncrementSkillPointTest()
        {
            //throw new NotImplementedException();
            var career = new Career("Ás", 3);
            var skill1 = new Skill("Pilotagem");
            var skill2 = new Skill("Afterburn");
            var skill3 = new Skill("Balistico");
            // skill 1

            career.AddSkillPoint(skill1, 1, "+ 2% Velocidade");
            career.AddSkillPoint(skill1, 2, "+ 2% Velocidade");
            career.AddSkillPoint(skill1, 3, "+ 2% Velocidade");
            
            // skill 2
            career.AddSkillPoint(skill2, 1, "+ 2% Aceleração");
            career.AddSkillPoint(skill2, 2, "+ 2% Aceleração");
            career.AddSkillPoint(skill2, 3, "+ 2% Aceleração");

            // skill 3
            career.AddSkillPoint(skill3, 1, "+ 2% Cadência, + 2 % Dano");
            career.AddSkillPoint(skill3, 2, "+ 2% Cadência, + 2 % Dano");
            career.AddSkillPoint(skill3, 3, "+ 2% Cadência, + 2 % Dano");

            // Career simulation
            var cs = new CareerSimulator("", career);
            cs.IncrementSkillPoint(skill1);
            cs.IncrementSkillPoint(skill1);
            bool invalidOperationException = false;
            try
            {
                cs.IncrementSkillPoint(skill1);
            }
            catch (InvalidOperationException e)
            {
                invalidOperationException = true;
                Assert.AreEqual("There is no new unsed skill point in the selected skill", e.Message);
            }
            Assert.IsTrue(invalidOperationException, "A invalid operation exception must occur");
            // Increment inexistent skill in Career
            bool argumentException = false;
            try
            {
                cs.IncrementSkillPoint(skill3);
            }
            catch (ArgumentException e)
            {
                argumentException = true;
                Assert.IsTrue(e.Message.StartsWith("The informed skill must exist in selected career"));
            }
            Assert.IsTrue(argumentException, "A argument exception must occur");
            cs.IncrementSkillPoint(skill2);
            // Total skill points alread used
            invalidOperationException = false;
            try
            {
                cs.IncrementSkillPoint(skill2);
            }
            catch (InvalidOperationException e)
            {
                invalidOperationException = true;
                Assert.AreEqual("There is mores skill points used that total point of the career", e.Message);
            }
            Assert.IsTrue(invalidOperationException, "A invalid operation exception must occur");
        }
    }
}