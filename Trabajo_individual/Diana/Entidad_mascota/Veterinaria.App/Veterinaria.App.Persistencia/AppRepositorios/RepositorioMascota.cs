
using System;
using System.Collections.Generic;
using System.Linq;
using Veterinaria.App.Dominio;
using Microsoft.EntityFrameworkCore;

namespace Veterinaria.App.Persistencia{


    public class RepositorioMascota : IRepositorioMascota{

        private readonly AppContext appContext;  

        public RepositorioMascota(AppContext appContextParam){
            this.appContext = appContextParam;
        }

        // CRUD
        //Create
        EntidadMascota IRepositorioMascota.AgregarMascota(EntidadMascota mascota) {
            var mascotaAgregada = this.appContext.Mascotas.Add(mascota);
            this.appContext.SaveChanges();
            return mascotaAgregada.Entity;
        }

        //Read
        EntidadMascota IRepositorioMascota.EditarMascota(EntidadMascota mascotaNueva) {

            var mascotaEncontrada = this.appContext.Mascotas.FirstOrDefault( p => p.Id == mascotaNueva.Id); 
            if(mascotaEncontrada != null){
                mascotaEncontrada.Nombre = mascotaNueva.Nombre;
                mascotaEncontrada.Edad = mascotaNueva.Edad;
                mascotaEncontrada.Peso = mascotaNueva.Peso;
                mascotaEncontrada.Especie = mascotaNueva.Especie;
                this.appContext.SaveChanges();  
                return mascotaEncontrada;              
            } else {
                return null;
            }          
        }

        //Update
         EntidadMascota IRepositorioMascota.GetMascota(int idMascota) {
            return this.appContext.Mascotas.FirstOrDefault( p => p.Id == idMascota);           
        }

        //Delete

        void IRepositorioMascota.EliminarMascota(int idMascota) {
           var  mascotaEncontrada = this.appContext.Mascotas.FirstOrDefault( p => p.Id == idMascota); 

            if(mascotaEncontrada != null) {
                this.appContext.Mascotas.Remove(mascotaEncontrada);
                this.appContext.SaveChanges();
            }

        }


        IEnumerable <EntidadMascota> IRepositorioMascota.GetMascotas(){
            return null;
        }



    }
}