// --------------------------------------------------------------------------------------------------------------------
// <copyright file="GenericContrcovReno.cs" company="">
//   
// </copyright>
// <summary>
//   Defines the GenericContrcovReno type.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace OSSP_lab_1
{
    using OSSP_lab_1.Interfaces;

    /// <summary>
    /// The generic contrcov reno.
    /// </summary>
    public class GenericContrcovReno : IGenericContrcov<Reno>
    {
        /// <summary>
        /// The create.
        /// </summary>
        /// <returns>
        /// The <see cref="Reno"/>.
        /// </returns>
        public Reno Create()
        {
            return new Reno();
        }

        /// <summary>
        /// The create car.
        /// </summary>
        /// <returns>
        /// The <see cref="Reno"/>.
        /// </returns>
        /// <exception cref="">
        /// </exception>
        public Reno CreateCar()
        {
            throw new System.NotImplementedException();
        }
    }
}
