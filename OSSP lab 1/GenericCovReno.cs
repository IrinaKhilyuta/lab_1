using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OSSP_lab_1
{
    public class GenericCovReno : IGenericCov<Reno>
    {
        public string GetInfo(Reno reno)
        {
            return reno.Id + " " + reno.Model;
        }
    }
}
