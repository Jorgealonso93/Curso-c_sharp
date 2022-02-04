using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WCFHolaMundo
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de clase "WCFPrueba" en el código, en svc y en el archivo de configuración a la vez.
    // NOTA: para iniciar el Cliente de prueba WCF para probar este servicio, seleccione WCFPrueba.svc o WCFPrueba.svc.cs en el Explorador de soluciones e inicie la depuración.
    public class WCFPrueba : IWCFPrueba
    {
        public int Resta(int n1, int n2)
        {
            throw new NotImplementedException();
        }

        public int Suma(int n1, int n2)
        {
            throw new NotImplementedException();
        }
    }
}
