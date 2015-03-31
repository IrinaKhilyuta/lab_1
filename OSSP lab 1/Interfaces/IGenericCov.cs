// --------------------------------------------------------------------------------------------------------------------
// <copyright file="IGenericCov.cs" company="">
//   
// </copyright>
// <summary>
//   Defines the IGenericCov type.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace OSSP_lab_1.Interfaces
{
    /// <summary>
    /// The GenericCov interface.
    /// </summary>
    /// <typeparam name="T">
    /// </typeparam>
    public interface IGenericCov<in T> where T : Car
    {
        /// <summary>
        /// The set info.
        /// </summary>
        /// <param name="t">
        /// The t.
        /// </param>
        void SetInfo(T t);
    }
}
