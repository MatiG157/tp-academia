using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Model
{
    public class Usuario { 
    

        public int IdUsuario { get; set; }
        public string NombreUsuario { get; set; }
        public string Clave { get; set; }
        public bool Habilitado { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Email { get; set; }
        public bool CambiaClave { get; set; }
        public int IdPersona { get; set; }
   

        public Usuario (int idUsuario, string nombreUsuario, string clave, bool habilitado, string nombre, string apellido, string email, bool cambiaClave, int idPersona)
        {

            IdUsuario = idUsuario;
            NombreUsuario = nombreUsuario;
            Clave = clave;
            Habilitado = habilitado;
            Nombre = nombre;
            Apellido = apellido;
            Email = email;
            CambiaClave = cambiaClave;
            IdPersona = idPersona;

        }

    }


}


