using System;
using System.Linq;
using NUnit.Framework;
using Fortuna.Services;
using EntityAdapter;

namespace FortunaTest
{
    [TestFixture]
    public class FortunaServiceTest
    {
        [Test]
        public void TestMethod1()
        {
            var fortuna = new FortunaEntities();
            var lol = fortuna.LodSeddel.First();
            Console.WriteLine("WIN!");
            Console.ReadLine();

            using (var service = new LodseddelService())
            {
                service.GetById(1);
            }
        }
    }
}
