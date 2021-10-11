using System;  

namespace Veterinaria.App.Dominio
{
    public class EntidadMascota{
        public int Id {get; set;}
        public string NombreMascota {get; set;}
        public DateTime FechaNacimiento {get; set;} //
        public int EdadMascota {get; set;}
        public int IdPropietario {get; set;}
        public string  Especie {get; set;} //
        public string raza {get; set;}
        public string peso {get; set;}
    }
}