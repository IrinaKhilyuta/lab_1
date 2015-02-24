using lab1.Base;
using lab1.Cov_and_Contr;

namespace lab1.Generic
{
   public class Generic21 : IGeneric2<ModeBasel>
    {
        public ModeBasel Create()
        {
            return new ModeBasel();
        }
    }
}
