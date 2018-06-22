using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConexionDB
{
    public class ConexionClasesMaestro
    {
        ProyectoEntities db = new ProyectoEntities();

        public Clases_Maestro Encontrar(string codeUsuario,string  codeClase)
        {
            Clases_Maestro query = db.Clases_Maestros.Where(x => x.Código_Usuario == codeUsuario
                                                    & x.Código_de_Clase == codeClase).FirstOrDefault();
            return query;
        }

        public List<Clases_Maestro> Encontrar(string codeUsuario)
        {
            var query = db.Clases_Maestros.Where(x => x.Código_Usuario == codeUsuario).ToList();
            return query;
        }

        public bool validarMaestro(string codeUsuario)
        {
            var query = db.Clases_Maestros.Where(x => x.Código_Usuario == codeUsuario);

            if (query.ToList().Count > 0) return true;
            return false;
        }

        public void GuardarClasesMaestro(string CodeUsuario,string CodeClase)
        {
            Clases_Maestro clases = new Clases_Maestro()
            {
                Código_de_Clase = CodeClase,
                Código_Usuario = CodeUsuario,
            };
            db.Clases_Maestros.Add(clases);
            db.SaveChanges();
        }

        public void ModificarClasesMaestro(string CodeUsuario, string newCodeClase, string CodeClase)
        {
            Clases_Maestro clases = Encontrar(CodeUsuario, CodeClase);
            clases.Código_Usuario = CodeUsuario;
            clases.Código_de_Clase = newCodeClase;
            //Guardar cambios
            db.SaveChanges();
        }

        public void EliminarClasesMaestro(string CodeUsuario, string CodeClase)
        {
            try
            {
                Clases_Maestro clases = (from e in db.Clases_Maestros
                                   where e.Código_Usuario == CodeUsuario & e.Código_de_Clase== CodeClase
                                   select e).FirstOrDefault();
                db.Clases_Maestros.Remove(clases);
                db.SaveChanges();
            }
            catch (Exception)
            {
                ;
            }
        }
    }
}
