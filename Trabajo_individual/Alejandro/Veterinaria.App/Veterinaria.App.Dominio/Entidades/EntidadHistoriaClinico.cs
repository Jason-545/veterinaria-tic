using System;  

namespace Veterinaria.App.Dominio
{
    public class EntidadHistoriaClinico{
        public int Id {get; set;}
        public DateTime FechaRegistroCitaH {get; set;}
        public DateTime FechaAtencionCitaH {get; set;}
        public String Diagnostico {get; set;}
        public int idVeterinario {get; set;}
        public int idCliente {get; set;}
        public int idMascota {get; set;}
        
        
    }
}