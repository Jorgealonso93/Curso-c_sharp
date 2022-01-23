using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MenuGeneral
{
    struct PolizaResultado
    {
            public PolizaResultado(DateTime fechaFin, decimal prim)
            {
                this.fechaTermino = fechaFin;
                this.prima = prim;
            }
            public DateTime fechaTermino;
            public decimal prima;
    }
}
