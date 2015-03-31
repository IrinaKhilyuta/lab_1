// --------------------------------------------------------------------------------------------------------------------
// <copyright file="GenericCovCar.cs" company="">
//   
// </copyright>
// <summary>
//   Defines the GenericCovCar type.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace OSSP_lab_1
{
    using OSSP_lab_1.Interfaces;

    /// <summary>
    /// The generic cov car.
    /// </summary>
    public class GenericCovCar : IGenericCov<Car>
    {
        /// <summary>
        /// The get info.
        /// </summary>
        /// <param name="car">
        /// The car.
        /// </param>
        /// <returns>
        /// The <see cref="string"/>.
        /// </returns>
        public string GetInfo(Car car)
        {
            return car.Id;
        }

        /// <summary>
        /// The set info.
        /// </summary>
        /// <param name="t">
        /// The t.
        /// </param>
        /// <exception cref="">
        /// </exception>
        public void SetInfo(Car t)
        {
        }
    }
}
