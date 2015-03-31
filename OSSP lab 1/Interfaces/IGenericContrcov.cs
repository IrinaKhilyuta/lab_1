// --------------------------------------------------------------------------------------------------------------------
// <copyright file="IGenericContrcov.cs" company="">
//   
// </copyright>
// <summary>
//   Defines the IGenericContrcov type.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace OSSP_lab_1.Interfaces
{
    /// <summary>
    /// The GenericContrcov interface.
    /// </summary>
    /// <typeparam name="T">
    /// </typeparam>
    public interface IGenericContrcov<out T> where T : Car
    {
        /// <summary>
        /// The create car.
        /// </summary>
        /// <returns>
        /// The <see cref="T"/>.
        /// </returns>
        T CreateCar();
    }
}
