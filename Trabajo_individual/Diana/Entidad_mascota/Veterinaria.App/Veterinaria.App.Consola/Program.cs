using System;
using Veterinaria.App.Dominio;
using Veterinaria.App.Persistencia;

namespace Veterinaria.App.Consola
{
    class Program
    {
        
        private static IRepositorioMascota repoMascota = new RepositorioMascota(new Persistencia.AppContext());

        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            // AgregarMascota();
            // EditarMascota();
            //EliminarMascota();
            // BuscarMascota();

        }

        private static void AgregarMascota(){

            EntidadMascota mascota = new EntidadMascota {
                Id = 0,
                Nombre = "Fiona",
                Edad = 3,
                Peso = 4.3F,
                Especie = "Felino",
            };

            repoMascota.AgregarMascota(mascota);

        }


        private static void EditarMascota(int idMascota){

            EntidadMascota mascota = new EntidadMascota {
                Id = idMascota,
                Nombre = "Firulais",
                Edad = 1,
                Peso = 2.5F,
                Especie = "Canino",
                
            };

            repoMascota.EditarMascota(mascota);

        }

        private static void BuscarMascota(int idMascota) {

           var mascotaEncontrada = repoMascota.GetMascota(idMascota);
           Console.WriteLine("El nombre de la macota es: " + mascotaEncontrada.Nombre);
        }

        private static void EliminarMascota(int idMascota) {
            repoMascota.EliminarMascota(idMascota);
        }



    }
}
