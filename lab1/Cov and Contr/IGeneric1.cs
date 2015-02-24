using lab1.Base;

namespace lab1.Cov_and_Contr
{
    public interface IGeneric1<in T> where T : ModeBasel
    {
        int GetKey(T t);
    }
}
