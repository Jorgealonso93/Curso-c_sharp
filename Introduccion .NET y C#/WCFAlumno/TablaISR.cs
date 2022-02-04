using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace WCFAlumno
{
    [DataContract]
    public class TablaISR
    {
        [DataMember]
        public decimal limInf { get; set; }
        
        [DataMember]
        public decimal LimSup { get; set; }

        [DataMember]
        public decimal cuotaFija { get; set; }

        [DataMember]
        public decimal excedente { get; set; }

        [DataMember]
        public decimal subsidio { get; set; }

        [DataMember]
        public decimal impuesto { get; set; }

    }
}