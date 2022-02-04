using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WCFHolaMundo
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de interfaz "IWCFPrueba" en el código y en el archivo de configuración a la vez.
    [ServiceContract]
    public interface IWCFPrueba
    {
        [OperationContract]
        int Suma(int n1, int n2);

        [OperationContract]
        int Resta(int n1, int n2);
    }
}
