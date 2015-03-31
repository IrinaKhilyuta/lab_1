// --------------------------------------------------------------------------------------------------------------------
// <copyright file="GenericCovReno.cs" company="">
//   
// </copyright>
// <summary>
//   Defines the GenericCovReno type.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace OSSP_lab_1
{
    using OSSP_lab_1.Interfaces;

    /// <summary>
    /// The generic cov reno.
    /// </summary>
    public class GenericCovReno : IGenericCov<Reno>
    {
        /// <summary>
        /// The get info.
        /// </summary>
        /// <param name="reno">
        /// The reno.
        /// </param>
        /// <returns>
        /// The <see cref="string"/>.
        /// </returns>
        public string GetInfo(Reno reno)
        {
            return reno.Id + " " + reno.Model;
        }

        /// <summary>
        /// The set info.
        /// </summary>
        /// <param name="t">
        /// The t.
        /// </param>
        public void SetInfo(Reno t)
        {
        }
    }
}
