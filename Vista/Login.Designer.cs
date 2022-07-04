namespace Vista
{
    partial class Login
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.btnSignIn = new System.Windows.Forms.Button();
            this.txtUser = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SingUp = new System.Windows.Forms.Label();
            this.chckPW = new System.Windows.Forms.CheckBox();
            this.picboxShowPW = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picboxShowPW)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSignIn
            // 
            this.btnSignIn.Location = new System.Drawing.Point(332, 234);
            this.btnSignIn.Name = "btnSignIn";
            this.btnSignIn.Size = new System.Drawing.Size(113, 23);
            this.btnSignIn.TabIndex = 0;
            this.btnSignIn.Text = "Sign In";
            this.btnSignIn.UseVisualStyleBackColor = true;
            this.btnSignIn.Click += new System.EventHandler(this.btnSignIn_Click);
            // 
            // txtUser
            // 
            this.txtUser.Location = new System.Drawing.Point(285, 116);
            this.txtUser.Name = "txtUser";
            this.txtUser.Size = new System.Drawing.Size(217, 20);
            this.txtUser.TabIndex = 1;
            this.txtUser.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(285, 194);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(217, 20);
            this.txtPassword.TabIndex = 2;
            this.txtPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(372, 100);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "User";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(361, 178);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Password";
            // 
            // SingUp
            // 
            this.SingUp.AutoSize = true;
            this.SingUp.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SingUp.ForeColor = System.Drawing.SystemColors.Highlight;
            this.SingUp.Location = new System.Drawing.Point(369, 286);
            this.SingUp.Name = "SingUp";
            this.SingUp.Size = new System.Drawing.Size(45, 13);
            this.SingUp.TabIndex = 5;
            this.SingUp.Text = "Sign Up";
            this.SingUp.Click += new System.EventHandler(this.SignUp_Click);
            // 
            // chckPW
            // 
            this.chckPW.AutoSize = true;
            this.chckPW.Location = new System.Drawing.Point(508, 197);
            this.chckPW.Name = "chckPW";
            this.chckPW.Size = new System.Drawing.Size(15, 14);
            this.chckPW.TabIndex = 8;
            this.chckPW.UseVisualStyleBackColor = true;
            this.chckPW.CheckedChanged += new System.EventHandler(this.chckPW_CheckedChanged);
            // 
            // picboxShowPW
            // 
            this.picboxShowPW.ImageLocation = "Img/ShowPW.png";
            this.picboxShowPW.InitialImage = ((System.Drawing.Image)(resources.GetObject("picboxShowPW.InitialImage")));
            this.picboxShowPW.Location = new System.Drawing.Point(529, 181);
            this.picboxShowPW.Name = "picboxShowPW";
            this.picboxShowPW.Size = new System.Drawing.Size(51, 45);
            this.picboxShowPW.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picboxShowPW.TabIndex = 9;
            this.picboxShowPW.TabStop = false;
            this.picboxShowPW.Click += new System.EventHandler(this.picboxShowPW_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.picboxShowPW);
            this.Controls.Add(this.chckPW);
            this.Controls.Add(this.SingUp);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtUser);
            this.Controls.Add(this.btnSignIn);
            this.Name = "Login";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.picboxShowPW)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSignIn;
        private System.Windows.Forms.TextBox txtUser;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label SingUp;
        private System.Windows.Forms.CheckBox chckPW;
        private System.Windows.Forms.PictureBox picboxShowPW;
    }
}

