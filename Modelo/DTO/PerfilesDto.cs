using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo.DTO
{
    public class PerfilesDto
    {
        public int Id { get; private set; }
        public string Nombre { get; private set; }
        public PerfilesDto() { }

        public static List<Profile> GetPerfiles()
        {
            List<Profile> Lista = new List<Profile>();
            try
            {
                using (var ctx = new ModulosDeSeguridad())
                {
                    var ListaPerfiles = ctx.Profile;
                    if (ListaPerfiles != null)
                    {
                        foreach (var profile in ListaPerfiles)
                        {
                            Profile perfil = new Profile();
                            perfil.Id = profile.Id;
                            perfil.ProfileN = profile.ProfileN;
                            Lista.Add(perfil);
                        }
                    }
                }
                return Lista;
            }
            catch
            {
                return new List<Profile>();
            }
        }

    }
}
