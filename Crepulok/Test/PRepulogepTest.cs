using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Crepulok.Test
{
    [TestFixture]
    class PRepulogepTest
    {
        Jaratkezelo jk;

        [SetUp]
        public void Setup()
        {
            jk = new Jaratkezelo();
        }

        [Test]
        public void UjJaratUticel()
        {
            jk.UjJarat("44", "Hungary", "United Emirates", DateTime.Parse("18:09"));

            Assert.AreEqual("United Emirates", jk.Uticel("44"));
        }

        [Test]
        public void UjJaratKesesNulla()
        {
            jk.UjJarat("44", "Hungary", "United Emirates", DateTime.Parse("18:09"));
            Assert.AreEqual(0, jk.getKeses("44"));
        }
        
        [Test]
        public void UjJaratIndulas()
        {
            jk.UjJarat("44", "Hungary", "United Emirates", DateTime.Parse("18:09"));

            Assert.AreEqual(DateTime.Parse("09:18"), jk.getIndulas("76"));
        }

        [Test]
        public void NegativKeses()
        {

            jk.UjJarat("44", "Hungary", "United Emirates", DateTime.Parse("18:09"));
            jk.UjJarat("176", "Hungary", "United Emirates", DateTime.Parse("18:09"));
            jk.setKeses("176", -10);

            Assert.Throws<Roszjaratszam>(
                () => {
                    var jarat = jk.getKeses("44");
                }
            );
        }

        [Test]
        public void NemLetezoUticel()
        {
            jk.UjJarat("001", "Hungary", "United Emirates", DateTime.Parse("18:09"));
            jk.UjJarat("128", "Hungary", "United Emirates", DateTime.Parse("18:09"));

            Assert.Throws<ArgumentException>(
                () => {
                    var jarat = jk.getJaratSzam("176");
                }
            );
        }

        [Test]
        public void NemLetezoJaratSzam()
        {
            jk.UjJarat("001", "Hungary", "United Emirates", DateTime.Parse("18:09"));
            jk.UjJarat("128", "Hungary", "United Emirates", DateTime.Parse("18:09"));
            Assert.Throws<Roszjaratszam>(
                () => {
                    var jarat = jk.getJaratSzam("44");
                }
            );
        }
    }
}
