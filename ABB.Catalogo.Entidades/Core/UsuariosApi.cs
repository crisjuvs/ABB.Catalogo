using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace ABB.Catalogo.Entidades.Core
{
    [DataContract]
    [Serializable]

    public class UsuariosApi
    {
        [DataMember]
        public int Codigo { get; set; }
        [DataMember]
        public string UserName { get; set; }
        [DataMember]
        public string Clave { get; set; }
        [DataMember]
        public string Nombre { get; set; }
        [DataMember]
        public string Rol { get; set; }

    }
}
