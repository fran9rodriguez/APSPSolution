using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewShore.APSP.DA
{
    public static class FactoryDA
    {
        public static IDataAccess Get(int id)
        {
            switch (id)
            {
                case 1:
                    return new FileDAT();
                default:
                    return new FileDAT();
            }
        }
    }
}
