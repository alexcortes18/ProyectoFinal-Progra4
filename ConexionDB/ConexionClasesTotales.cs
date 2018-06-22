using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConexionDB
{
    public class ConexionClasesTotales
    {
        ProyectoEntities db = new ProyectoEntities();

        public Clase Encontrar(string codeClase)
        {
            Clase query = db.Clases.Where(x => x.Código_de_clase == codeClase).FirstOrDefault();
            return query;
        }
       
        public bool validarClase(string codeClase)
        {
            var query = db.Clases.Where(x => x.Código_de_clase == codeClase);

            if (query.ToList().Count > 0) return true;
            return false;
        }

        public void GuardarClases(string CodeClase, string Descripcion, string Tipo)
        {
            Clase clases = new Clase()
            {
                Código_de_clase = CodeClase,
                Descripción_de_clase = Descripcion,
                Tipo = Tipo,
            };
            db.Clases.Add(clases);
            db.SaveChanges();
        }

        public void ModificarClases(string CodeClase, string Descripcion, string Tipo)
        {
            Clase clases = Encontrar(CodeClase);
            clases.Descripción_de_clase = Descripcion;
            clases.Tipo = Tipo;
            //Guardar cambios
            db.SaveChanges();
        }

        public void EliminarClases(string CodeClase)
        {
            try
            {
                Clase clases = (from e in db.Clases
                                         where e.Código_de_clase == CodeClase
                                         select e).FirstOrDefault();
                db.Clases.Remove(clases);
                db.SaveChanges();
            }
            catch (Exception)
            {
                ;
            }
        }
    }
}
