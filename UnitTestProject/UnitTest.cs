// --------------------------------------------------------------------------------------------------------------------
// <copyright file="UnitTest.cs" company="g">
//   ggg
// </copyright>
// <summary>
//   The unit test.
// </summary>
// --------------------------------------------------------------------------------------------------------------------
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject
{
    using OSSP_lab_1;
    using OSSP_lab_1.Interfaces;

    /// <summary>
    /// The unit test.
    /// </summary>
    [TestClass]
    public class UnitTest
    {
        /// <summary>
        /// The test cov.
        /// </summary>
        [TestMethod]
        public void TestCov()
        {
            IGenericCov<Car> gen1 = new GenericCovCar();
            IGenericCov<Reno> gen2 = new GenericCovReno();

            gen2 = gen1;
        }

        /// <summary>
        /// The test contrcov.
        /// </summary>
        [TestMethod]
        public void TestContrcov()
        {
            IGenericContrcov<Car> gen1 = new GenericContrcovCar();
            IGenericContrcov<Reno> gen2 = new GenericContrcovReno();

            gen1 = gen2;
        }
    }
}
