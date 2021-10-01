using System;
namespace Veterinaria.App.Dominio
{
    public class EntidadCitas{
        public int Id {get; set;}
        public DateTime FechaRegistroCita {get; set;}
        public DateTime FechaAtencionCita {get; set;}
        public String Triage {get; set;}
        public int idVeterinario {get; set;}
        public int idCliente {get; set;}
        public int idMascota {get; set;}
   
    }
    
}