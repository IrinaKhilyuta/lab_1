using lab1.Base;
using lab1.Cov_and_Contr;

namespace lab1.Generic
{
   public class Generic12 : IGeneric1<ModelChild>
    {
        public int GetKey(ModelChild t)
        {
            return t.Code + t.Id;
        }
    }
}
