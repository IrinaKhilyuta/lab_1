﻿using lab1.Base;
using lab1.Cov_and_Contr;

namespace lab1.Generic
{
   public class Generic11 : IGeneric1<ModeBasel>
    {
        public int GetKey(ModeBasel baseModel)
        {
            return baseModel.Id;
        }
    }
}
