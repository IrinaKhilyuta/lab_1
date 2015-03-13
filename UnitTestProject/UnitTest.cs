using System;
using OSSP_lab_1;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject
{
    [TestClass]
    public class UnitTest
    {
        [TestMethod]
        public void TestCov()
        {
            IGenericCov<Car> gen1 = new GenericCovCar();
            IGenericCov<Reno> gen2 = new GenericCovReno();

            gen2 = gen1;
            //gen1 = gen2;
        }

        [TestMethod]
        public void TestContrcov()
        {
            IGenericContrcov<Car> gen1 = new GenericContrcovCar();
            IGenericContrcov<Reno> gen2 = new GenericContrcovReno();

            gen1 = gen2;
            //gen2 = gen1;
        }
    }
}
