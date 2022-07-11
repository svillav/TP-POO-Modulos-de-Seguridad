using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo.DTO
{
    public class UsuariosDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Dni { get; set; }
        public string Email { get; set; }
        public string Contraseña { get; set; }
        public int Perfil { get; set; }

        public UsuariosDto() { }

    }
    public class Usuarios
    {

    public Usuarios() { }
        public static List<UsuariosDto> GetUsuarios()
        {
            List<UsuariosDto> ListaDTO;
            try
            {
                using (var ctx = new ModulosDeSeguridad())
                {
                    ListaDTO = new List<UsuariosDto>();
                    var ListaUsuarios = ctx.User;
                    if (ListaUsuarios != null)
                    {
                        foreach (var usuario in ListaUsuarios)
                        {
                            UsuariosDto usertemp = new UsuariosDto();
                            usertemp.Id = usuario.Id;
                            usertemp.Name = usuario.Name;
                            usertemp.Dni = int.Parse(usuario.DNI);
                            usertemp.Email = usuario.Email;
                            usertemp.Contraseña = usuario.Contraseña;
                            usertemp.Perfil = usuario.Perfil;//usuario.Perfiles;
                            ListaDTO.Add(usertemp);
                        }
                    }
                }
                return ListaDTO;
            }
            catch
            {
                return new List<UsuariosDto>();
            }
        }
        public static void AgregarUsuario(Modelo.DTO.UsuariosDto user)
        {
            try
            {
                using (var ctx = new ModulosDeSeguridad())
                {
                    var perfi = ctx.Profile.Where(x => x.Id == 1).FirstOrDefault();
                    User userdb = new User();
                    //userdb.Id = ctx.User.Count() + 1;//user.Id;
                    userdb.Name = user.Name;
                    userdb.DNI = user.Dni.ToString();
                    userdb.Email = user.Email;
                    userdb.Contraseña = user.Contraseña;
                    userdb.Perfil = perfi.Id;
                    userdb.Profile = perfi;
                    ctx.User.Add(userdb);
                    ctx.SaveChanges();
                }//		User	La evaluación de la función requiere que se ejecuten todos los subprocesos.	System.Collections.Generic.ICollection<Modelo.User>

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }
        public static void EliminarUsuario(string id)
        {
            try
            {
                using (var ctx =new ModulosDeSeguridad())
                {
                    var user = ctx.User.Where(x => x.Id.ToString() == id).FirstOrDefault();
                    user.Profile = ctx.Profile.Where(t => t.Id.ToString() == user.Perfil.ToString()).FirstOrDefault();
                    ctx.User.Remove(user);
                    ctx.SaveChanges();

                }
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex);
            }

        }
        public static void EditarUsuario(UsuariosDto usu)
        {
            try
            {
                using (var ctx = new ModulosDeSeguridad())
                {
                    var user = ctx.User.Where(x => x.Id.ToString() == usu.Id.ToString()).FirstOrDefault();
                    ctx.User.Remove(user);
                    User usueditado = new User();
                    usueditado.Id = usu.Id;
                    usueditado.Name = usu.Name;
                    usueditado.DNI = usu.Dni.ToString(); 
                    usueditado.Email = usu.Email;
                    usueditado.Contraseña = usu.Contraseña;
                    usueditado.Perfil = usu.Perfil;
                    usueditado.Profile = ctx.Profile.Where(x => x.Id == usu.Perfil).FirstOrDefault();
                    ctx.User.Add(usueditado);
                    ctx.SaveChanges();

                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
            
        }

    }
}
