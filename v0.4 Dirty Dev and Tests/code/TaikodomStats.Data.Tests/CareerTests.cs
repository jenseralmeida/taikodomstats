/*
 * Criado por SharpDevelop.
 * Usuário: Jenser
 * Data: 29/12/2008
 * Hora: 22:51
 * 
 * Para alterar este modelo use Ferramentas | Opções | Codificação | Editar Cabeçalhos Padrão.
 */
using System;
using System.Linq;
using NUnit.Framework;
using TaikodomStats.Data;

namespace TaikodomStats.DataSL.Tests
{
    /// <summary>
    /// Description of CareerTest.
    /// </summary>
    [TestFixture]
    public class CareerTests
    {

        [Test]
        public void MontandoProjecaoAnonimaSimulacaoCarreira()
        {
            var asCareer = new Career("As", 1);
            var afterburnSkill = new Skill("Afterburn");
            var gaussSkill = new Skill("Gauss");
            asCareer.AddSkillPoint(afterburnSkill, 1, "");
            asCareer.AddSkillPoint(afterburnSkill, 2, "");
            asCareer.AddSkillPoint(gaussSkill, 1, "");
            asCareer.AddSkillPoint(gaussSkill, 2, "");
            var q = from Skill skill in asCareer.Skills let SkillPoints = asCareer.GetSkillPoints(skill) select new {skill, SkillPoints};
            //var q = from Skill s in asCareer.Skills select new { s.Careers };
            foreach (var sk in q)
            {
                Console.Write(sk.skill);
            }
        }

        [Test]
        [Ignore]
        public void InstanciateTest()
        {
            throw new NotImplementedException();
            //var career = new Career("TestCareer", 25);
            //Assert.AreEqual("TestCareer", career.ResourceKey, "TestCareer");
            //Assert.AreEqual(25, career.TotalPoints, "total points");
        }
    }
}