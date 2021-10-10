using System;  

namespace Veterinaria.App.Dominio
{
    public class EntidadPersona{
        public int Id {get; set;}
        public String Nombre {get; set;}
        public String Telefono {get; set;}
        public int Edad {get; set;}
        public String Correo {get; set;}
        public string Contraseña {get; set;}
        public DateTime FechaRegistro {get; set;}
    }
}