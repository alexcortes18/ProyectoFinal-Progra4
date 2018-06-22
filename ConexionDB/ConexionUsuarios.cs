using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConexionDB
{
    public class ConexionUsuarios
    {
        ProyectoEntities db = new ProyectoEntities();

        public bool Validar(string code, string password)
        {
            var result = db.Usuarios.Where(x => x.Código == code && x.Contraseña == password);
            if (result.ToList().Count > 0)
            {
                return true;
            }
            return false;
        }

        public string RoldeUsuario(string code, string password)
        {
            if (Validar(code, password))
            {
                Usuario user = (from e in db.Usuarios
                                where e.Código == code
                                select e).FirstOrDefault();
                
                string rol = user.Rol;
                switch (rol)
                {
                    case "Administrador":
                        return rol;
                    case "Maestro":
                        return rol;
                    case "Oficial Academico":
                        return rol;
                    default:
                        return "";
                }
            }
            else return "";
        }

        public void GuardarUsuario(string code, string pass, string identidad, string nom,
                                    string genero, string correo, string telefono, string rol)
        {
            Usuario user = new Usuario()
            {
                Código = code,
                Contraseña = pass,
                Identidad = identidad,
                Nombre_Completo = nom,
                Género = genero,
                Correo = correo,
                Teléfono = telefono,
                Rol = rol
            };
            db.Usuarios.Add(user);
            db.SaveChanges();
        }

        public void ModificarUsuario(string code, string pass, string identidad, string nom,
                                    string genero, string correo, string telefono, string rol)
        {
            Usuario user = (from e in db.Usuarios
                            where e.Código == code
                            select e).FirstOrDefault();
            user.Contraseña = pass;
            user.Identidad = identidad;
            user.Nombre_Completo = nom;
            user.Género = genero;
            user.Correo = correo;
            user.Teléfono = telefono;
            user.Rol = rol;
            //Guardar cambios
            db.SaveChanges();
        }

        public Usuario Encontrar(string code)
        {
            /*
            var Query = from user in db.Usuarios
                        select user;
            return Query.Where(e => e.Código == code).ToList();
            */
            Usuario user = (from e in db.Usuarios
                            where e.Código == code
                            select e).FirstOrDefault();
            return user;
        }

        public void EliminarUsuario(string code)
        {
            try
            {
                Usuario usuario = (from e in db.Usuarios
                                 where e.Código == code
                                 select e).FirstOrDefault();
                db.Usuarios.Remove(usuario);
                db.SaveChanges();
            }
            catch (Exception)
            {
                ;
            }
        }
    }
}
