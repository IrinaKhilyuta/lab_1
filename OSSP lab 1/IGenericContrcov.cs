﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OSSP_lab_1
{
    public interface IGenericContrcov<out T> where T : Car
    {
        T CreateCar();
    }
}
