using lab1.Base;
using lab1.Cov_and_Contr;

namespace lab1.Generic
{
    public class Generic22 : IGeneric2<ModelChild>
    {
        public ModelChild Create()
        {
            return new ModelChild();
        }
    }
}
