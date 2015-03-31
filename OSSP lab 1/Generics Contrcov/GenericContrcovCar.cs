// --------------------------------------------------------------------------------------------------------------------
// <copyright file="GenericContrcovCar.cs" company="">
//   
// </copyright>
// <summary>
//   Defines the GenericContrcovCar type.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace OSSP_lab_1
{
    using OSSP_lab_1.Interfaces;

    /// <summary>
    /// The generic contrcov car.
    /// </summary>
    public class GenericContrcovCar : IGenericContrcov<Car>
    {
        /// <summary>
        /// The create car.
        /// </summary>
        /// <returns>
        /// The <see cref="Car"/>.
        /// </returns>
        public Car CreateCar()
        {
            return new Car();
        }
    }
}
