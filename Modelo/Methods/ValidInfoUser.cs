using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo.Methods
{
    public class ValidInfoUser
    {
        
        public ValidInfoUser()
        {

        }
        public ValidInfoUser(int validtype, int propertie, string data) //validtype is an enum converted to int, same to propertie
        {

            switch (validtype)
            {
                case 0:                         //check in database
                    switch (propertie)
                    {
                        case 0:


                            break;

                        case 1:


                            break;

                        case 2:


                            break;

                        case 3:


                            break;

                        case 4:


                            break;

                        case 5:


                            break;

                        case 6:


                            break;

                        default:


                            break;

                    }

                    break;
                        
                case 1:                                     //check the string  

                    switch (propertie)
                    {
                        case 0:


                            break;

                        case 1:


                            break;

                        case 2:


                            break;

                        case 3:


                            break;

                        case 4:


                            break;

                        case 5:


                            break;

                        case 6:


                            break;

                        default:


                            break;

                    }

                    break;

                default:


                    break;
            }
        }
    }
}
