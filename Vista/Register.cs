using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace Vista
{
    public partial class Register : Form
    {
        public Register()
        {
            InitializeComponent();
        }

        private void Register_Load(object sender, EventArgs e)
        {

        }

        //POR ESO ODIO WFORMS 

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            //txtRePassword
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            //txtPassword

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            //txtREmail
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            //txtEmail

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {
            //txtDNI


        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {
            //txtLastName
        }



        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            //txtName
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {

            // dentro de una clase en modelo controlada por el Controler

            /*

            bool DNIExists = ReturnToFUSER("DNI", txtDNI.Text);
            bool EmailExists = ReturnToFUSER("EMAIL",txtEmail.Text);
            bool UserExists = ReturnToFUSER("USER", txtUser.Text);



            if (!DNIExists || !EmailExists || !UserExists)
            {
                try
                {
                    using (var ctx = ContextoEntities )
                    {
                        Person person = new Person();
                        person.Name = txtName.Text;
                        person.LastName = txtLastName.Text;
                        person.Email = txtEmail.Text;
                        person.User = txtUser.Text;
                        person.Password = txtPassword.Text;
                        person.ProfileID = 99;
                        person.BirthDate = DateTime.Parse(txtDateOfBirth);
                        ctx.Person.Add(person);
                        ctx.SaveChanges();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Cant Sign the user up because:{0}",ex.Message);
                }
                
            }*/
            


        }
            
    }
}
