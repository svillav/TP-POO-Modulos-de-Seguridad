using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Modelo.Metodos
{
    public class ValidInfoUser
    {
        public bool ValidateLogin { get;private set; }
        public ValidInfoUser()
        {
            //YA VENGO ME FUI A COMPRAR UNA PIZZA
        }
        public ValidInfoUser(string user, string password)
        {
            bool validemail = Validating(0, 3, user);
            
            if (validemail)
            {
                try
                {
                    using (var ctx = new Modelo.ModulosDeSeguridad())
                    {
                        var pass = ctx.User.Where(x => x.Email == user).FirstOrDefault();
                        if (pass != null)
                        {
                            if (pass.Contraseña.ToString() == password.ToString())
                            {
                                ValidateLogin = true;
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex);
                }
            }
        }
        public static bool Validating(int validtype, int propertie, string data) //validtype is an enum converted to int, same to propertie
        { //CHANGE METHOD TO BOOL 

            switch (validtype)
            {
                case 0:                     //check in database
                    bool isinDB = false;
                    switch (propertie)
                    {
                        case 0: //checkeo nombre
                            
                            try
                            {
                                using (var ctx = new Modelo.ModulosDeSeguridad())
                                {
                                    var valor = ctx.User.Where(x => x.Name.ToString() == data.ToString()).FirstOrDefault();
                                    
                                    if (valor != null)
                                    {
                                        isinDB = true;
                                    }
                                }
                            }
                            catch (Exception ex)
                            {
                                Console.WriteLine(ex);
                            }
                            return isinDB;

                        case 1: //este es para apellido
                            try 
                            {
                                using (var ctx = new Modelo.ModulosDeSeguridad())
                                {
                                    var valor = ctx.User.Where(x => x.Name.ToString() == data.ToString()).FirstOrDefault();

                                    if (valor != null)
                                    {
                                        isinDB = true;
                                    }
                                }
                            }
                            catch (Exception ex)
                            {
                                Console.WriteLine(ex);
                            }
                            return isinDB;

                        case 2: //check dni
                            try
                            {
                                using (var ctx = new Modelo.ModulosDeSeguridad())
                                {
                                    var valor = ctx.User.Where(x => x.DNI.ToString() == data.ToString()).FirstOrDefault();

                                    if (valor != null)
                                    {
                                        isinDB = true;
                                    }
                                }
                            }
                            catch (Exception ex)
                            {
                                Console.WriteLine(ex);
                            }
                            return isinDB;
                        case 3: //check email
                            try
                            {
                                using (var ctx = new Modelo.ModulosDeSeguridad())
                                {
                                    var valor = ctx.User.Where(x => x.Email.ToString() == data.ToString()).FirstOrDefault();

                                    if (valor != null)
                                    {
                                        isinDB = true;
                                    }
                                }
                            }
                            catch (Exception ex)
                            {
                                Console.WriteLine(ex);
                            }
                            return isinDB;
                        case 4: //este es para usuarios, en caso de agregar usuario ademas de email
                            try
                            {
                                using (var ctx = new Modelo.ModulosDeSeguridad())
                                {
                                    var valor = ctx.User.Where(x => x.Email.ToString() == data.ToString()).FirstOrDefault();

                                    if (valor != null)
                                    {
                                        isinDB = true;
                                    }
                                }
                            }
                            catch (Exception ex)
                            {
                                Console.WriteLine(ex);
                            }
                            return isinDB;
                        case 5:
                            try
                            {
                                using (var ctx = new Modelo.ModulosDeSeguridad())
                                {
                                    var valor = ctx.User.Where(x => x.Contraseña.ToString() == data.ToString()).FirstOrDefault();

                                    if (valor != null)
                                    {
                                        isinDB = true;
                                    }
                                }
                            }
                            catch (Exception ex)
                            {
                                Console.WriteLine(ex);
                            }
                            return isinDB;

                        case 6: //fecha de nacimiento para el caso futuro que se agregue
                            try
                            {
                                using (var ctx = new Modelo.ModulosDeSeguridad())
                                {
                                    var valor = ctx.User.Where(x => x.Name.ToString() == data.ToString()).FirstOrDefault();

                                    if (valor != null)
                                    {
                                        isinDB = true;
                                    }
                                }
                            }
                            catch (Exception ex)
                            {
                                Console.WriteLine(ex);
                            }
                            return isinDB;

                        default:
                            Console.WriteLine("CASE INCORRECTO");
                            return false;
                    }
                case 1:                                     //check the string  
                    bool sheet = false;
                    switch (propertie)
                    {
                        case 0:
                            return sheet = ValidateNames(data);
                        case 1:
                            return sheet = ValidateNames(data);

                        case 2:
                            return sheet = ValidateDNI(data);

                        case 3:
                            return sheet = ValidateEmail(data);
                        case 4:
                            return sheet = ValidateUser(data);
                        case 5:
                            return sheet = ValidatePassword(data);

                        case 6:
                            return false;//sheet = ValidateBirth(data);
                        default:
                            return false;
                    }

                default:
                    return false;
            }



        }
        public static bool ValidateNames(string name)
        {
            bool IsIntString = name.Any(char.IsDigit);
            /*bool OnlyLetters = Regex.IsMatch(name, @"^[a-zA-Z]+$");*/
            if (name == null)
            {
                return false;

            }
            if (IsIntString == false && /*OnlyLetters == true &&*/ name.Length > 2)
            {

                return true;

            }
            else
            {
                return false;
            }
        }
        public static bool ValidateDNI(string DNI)
        {
            bool IsInt = int.TryParse(DNI, out int value);
            if (IsInt == true)
            {

                if (value > 1000000 && value < 99999999)
                {
                    return true;
                }

            }
            return false;

        }
        public static bool ValidateUser(string user)
        {
            bool OnlyLettersNumersANDUnderscore = Regex.IsMatch(user, @"^[a-zA-Z0-9_]+$");
            if (user == null)
            {
                return false;

            }
            if (OnlyLettersNumersANDUnderscore == true && user.Length > 2)
            {

                return true;

            }
            else
            {
                return false;
            }
        }
        public static bool ValidatePassword(string user)
        {
            //bool OnlyLettersNumersANDUnderscore = Regex.IsMatch(user, @"^[a-zA-Z0-9_]+$");
            if (user == null)
            {
                return false;

            }
            if (/*OnlyLettersNumersANDUnderscore == true &&*/ user.Length > 2)
            {

                return true;

            }
            else
            {
                return false;
            }
        }
        public static bool ValidateEmail(string Email)
        {
            //bool OnlyLettersNumersANDUnderscore = Regex.IsMatch(user, @"^[a-zA-Z0-9_]+$");
            char AtSign = '@';        // cofre.le      @       gmail          .            com
            string[] EmailSplit = Email.Split(AtSign);
            //bool OnlyLettersNumersANDUnderscoreLeft = Regex.IsMatch(EmailSplit[0], @"^[a-zA-Z0-9_]+$");
            bool OnlyLettersNumersANDUnderscoreRight = false;
            /*try
            {
                OnlyLettersNumersANDUnderscoreRight = Regex.IsMatch(EmailSplit[1], @"^[a-zA-Z0-9_]+$");
            }*/
            //catch (Exception) { return false; }
            if (EmailSplit.Length != 2)
            {
                return false;
            }
            if (EmailSplit.Length == 2)
            {
              //  if (OnlyLettersNumersANDUnderscoreLeft == true && OnlyLettersNumersANDUnderscoreRight == true)
               // {
                    string[] EmailRightSplit = EmailSplit[1].Split('.');
                    if (EmailRightSplit.Length > 1)
                    {
                        return true;
                    }
                    return false;
              //  }
              //  return false;
            }
            return false;

        }

    }
}
