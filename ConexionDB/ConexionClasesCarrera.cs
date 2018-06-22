using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConexionDB
{
    public class ConexionClasesCarrera
    {
        ProyectoEntities db = new ProyectoEntities();

        public Clases_Carrera EncontrarCarrera(string codeCarrera, string codeClase)
        {
            Clases_Carrera query = db.Clases_Carreras.Where(x => x.Código_de_Carrera == codeCarrera
                                                    & x.Código_de_Clase == codeClase).FirstOrDefault();
            return query;
        }

        public List<Clases_Carrera> EncontrarCarrera(string codeCarrera)
        {
            var query = db.Clases_Carreras.Where(x => x.Código_de_Carrera == codeCarrera).ToList();
            return query;
        }

        /*public bool validarMaestro(string codeUsuario)
        {
            var query = db.Clases_Maestros.Where(x => x.Código_Usuario == codeUsuario);

            if (query.ToList().Count > 0) return true;
            return false;
        }*/

        public void GuardarClasesCarrera(string codeCarrera, string codeClase)
        {
            Clases_Carrera clases = new Clases_Carrera()
            {
                Código_de_Carrera = codeCarrera,
                Código_de_Clase = codeClase,
            };
            db.Clases_Carreras.Add(clases);
            db.SaveChanges();
        }

        public void ModificarClasesMaestro(string codeCarrera, string newCodeClase, string CodeClase)
        {
            Clases_Carrera clases = EncontrarCarrera(codeCarrera, CodeClase);
            clases.Código_de_Carrera = codeCarrera;
            clases.Código_de_Clase = newCodeClase;
            //Guardar cambios
            db.SaveChanges();
        }

        public void EliminarClasesCarrera(string codeCarrera, string codeClase)
        {
            try
            {
                Clases_Carrera clases = (from e in db.Clases_Carreras
                                         where e.Código_de_Carrera == codeCarrera & e.Código_de_Clase == codeClase
                                         select e).FirstOrDefault();
                db.Clases_Carreras.Remove(clases);
                db.SaveChanges();
            }
            catch (Exception)
            {
                ;
            }
        }
    }
}
