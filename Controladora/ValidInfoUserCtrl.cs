using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controladora
{
    public class ValidInfoUserCtrl
    {
        public ValidInfoUserCtrl()
        {

        }
        public static bool Validate(/*Modelo.Enum.Enums.ValidType*/ int ValidType, /*Modelo.Enum.Enums.PropertieType*/int ValidParameter, string data)
        {
            return Modelo.Metodos.ValidInfoUser.Validating(ValidType, ValidParameter, data);
        }
        public static bool ValidateUserPassword(string email, string password) // login validation
        {
            Modelo.Metodos.ValidInfoUser valid =  new Modelo.Metodos.ValidInfoUser(email, password);
            return valid.ValidateLogin;
        }
    }
}
