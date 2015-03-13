using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OSSP_lab_1
{
    public class GenericContrcovReno : IGenericContrcov<Reno>
    {
        public Reno Create()
        {
            return new Reno();
        }
    }
}
