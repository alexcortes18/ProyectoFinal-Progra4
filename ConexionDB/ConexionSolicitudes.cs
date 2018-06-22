using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConexionDB
{
    public class ConexionSolicitudes
    {
        ProyectoEntities db = new ProyectoEntities();

        public Solicitude Encontrar(string codeSolicitud)
        {
            Solicitude query = db.Solicitudes.Where(x => x.Código_de_solicitud == codeSolicitud).FirstOrDefault();
            return query;
        }

        public void GuardarSolicitud(string codeSolicitud, string codeUsuario, string Fecha, string color,
                                    string blackwhite, string tipo, string codeClase, string CodeMaestro, 
                                    string estado, string observaciones)
        {
            Solicitude solicitud = new Solicitude()
            {
                Código_de_solicitud = codeSolicitud,
                Código_usuario = codeUsuario,
                Fecha = Fecha,
                Cantidad_a_color = color,
                Cantidad_blanco_y_negro = blackwhite,
                Tipo = tipo,
                Código_de_clase = codeClase,
                Código_de_maestro = CodeMaestro,
                Estado = estado,
                Observaciones = observaciones
            };
            db.Solicitudes.Add(solicitud);
            db.SaveChanges();
        }

        public void ModificarSolicitud(string codeSolicitud, string codeUsuario, string Fecha, string color,
                                    string blackwhite, string tipo, string codeClase, string CodeMaestro,
                                    string estado, string observaciones)
        {
            Solicitude solicitud = (from e in db.Solicitudes
                               where e.Código_de_solicitud == codeSolicitud
                                    select e).FirstOrDefault();
            solicitud.Código_usuario = codeUsuario;
            solicitud.Fecha = Fecha;
            solicitud.Cantidad_a_color = color;
            solicitud.Cantidad_blanco_y_negro = blackwhite;
            solicitud.Tipo = tipo;
            solicitud.Código_de_clase = codeClase;
            solicitud.Código_de_maestro = CodeMaestro;
            solicitud.Estado = estado;
            solicitud.Observaciones = observaciones;
            //Guardar cambios
            db.SaveChanges();
        }

        public void EliminarSolcitud(string codeSolicitud)
        {
            try
            {
                Solicitude solicitud = (from e in db.Solicitudes
                                        where e.Código_de_solicitud == codeSolicitud
                                        select e).FirstOrDefault();
                db.Solicitudes.Remove(solicitud);
                db.SaveChanges();
            }
            catch (Exception)
            {
                ;
            }
        }
    }
}
