using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo.Enum
{
    public class Enums
    {
        public enum ValidType
        {
            CheckDDBB = 0,              //Check in database if it's repeated
            CheckValid = 1              //Check if the string is valid to use
        }

        public enum PropertieType
        {
            Name = 0,
            LastName = 1,
            DNI = 2,
            Email = 3,
            User = 4,
            Password = 5,
            Birth = 6
        }
    }
}
