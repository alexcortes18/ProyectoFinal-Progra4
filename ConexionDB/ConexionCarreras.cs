using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConexionDB
{
    public class ConexionCarreras
    {
        ProyectoEntities db = new ProyectoEntities();

        /*
        public bool Validar(string code, string password)
        {
            var result = db.Usuarios.Where(x => x.Código == code && x.Contraseña == password);
            if (result.ToList().Count > 0)
            {
                return true;
            }
            return false;
        }*/

        public void GuardarCarrera(string code, string nombreCarrera, int clases, int maestros)
        {
            Carrera carrera = new Carrera()
            {
                Código_de_carrera = code,
                Nombre_de_carrera = nombreCarrera,
                Cantidad_de_clases = clases,
                Cantidad_de_Maestros = maestros
            };
            db.Carreras.Add(carrera);
            db.SaveChanges();
        }

        public void ModificarCarrera(string code, string nombreCarrera, int clases, int maestros)
        {
            Carrera carrera = (from e in db.Carreras
                            where e.Código_de_carrera == code
                            select e).FirstOrDefault();
            carrera.Nombre_de_carrera = nombreCarrera;
            carrera.Cantidad_de_clases = clases;
            carrera.Cantidad_de_Maestros = maestros;
            //Guardar cambios
            db.SaveChanges();
        }

        public Carrera Encontrar(string code)
        {
            /*
            var Query = from user in db.Usuarios
                        select user;
            return Query.Where(e => e.Código == code).ToList();
            */
            Carrera carrera = (from e in db.Carreras
                            where e.Código_de_carrera == code
                            select e).FirstOrDefault();
            return carrera;
        }

        public void EliminarCarrera(string code)
        {
            try
            {
                Carrera carrera = (from e in db.Carreras
                                   where e.Código_de_carrera == code
                                   select e).FirstOrDefault();
                db.Carreras.Remove(carrera);
                db.SaveChanges();
            }
            catch (Exception)
            {
                ;
            }
        }
    }
}
