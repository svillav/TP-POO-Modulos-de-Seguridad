namespace Vista
{
    partial class Users
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dgvUsersList = new System.Windows.Forms.DataGridView();
            this.deleteUser = new System.Windows.Forms.Button();
            this.ModifyUser = new System.Windows.Forms.Button();
            this.RefreshList = new System.Windows.Forms.Button();
            this.LBCurrentUser = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsersList)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvUsersList
            // 
            this.dgvUsersList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUsersList.Location = new System.Drawing.Point(25, 24);
            this.dgvUsersList.Name = "dgvUsersList";
            this.dgvUsersList.Size = new System.Drawing.Size(903, 396);
            this.dgvUsersList.TabIndex = 0;
            this.dgvUsersList.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvUsersList_CellContentClick);
            // 
            // deleteUser
            // 
            this.deleteUser.Location = new System.Drawing.Point(25, 439);
            this.deleteUser.Name = "deleteUser";
            this.deleteUser.Size = new System.Drawing.Size(129, 33);
            this.deleteUser.TabIndex = 1;
            this.deleteUser.Text = "Eliminar usuario";
            this.deleteUser.UseVisualStyleBackColor = true;
            this.deleteUser.Click += new System.EventHandler(this.deleteUser_Click);
            // 
            // ModifyUser
            // 
            this.ModifyUser.Location = new System.Drawing.Point(177, 439);
            this.ModifyUser.Name = "ModifyUser";
            this.ModifyUser.Size = new System.Drawing.Size(129, 33);
            this.ModifyUser.TabIndex = 2;
            this.ModifyUser.Text = "Modificar usuario";
            this.ModifyUser.UseVisualStyleBackColor = true;
            this.ModifyUser.Click += new System.EventHandler(this.ModifyUser_Click);
            // 
            // RefreshList
            // 
            this.RefreshList.Location = new System.Drawing.Point(331, 439);
            this.RefreshList.Name = "RefreshList";
            this.RefreshList.Size = new System.Drawing.Size(129, 33);
            this.RefreshList.TabIndex = 3;
            this.RefreshList.Text = "Actualizar lista";
            this.RefreshList.UseVisualStyleBackColor = true;
            this.RefreshList.Click += new System.EventHandler(this.RefreshList_Click);
            // 
            // LBCurrentUser
            // 
            this.LBCurrentUser.AutoSize = true;
            this.LBCurrentUser.Location = new System.Drawing.Point(544, 449);
            this.LBCurrentUser.Name = "LBCurrentUser";
            this.LBCurrentUser.Size = new System.Drawing.Size(107, 13);
            this.LBCurrentUser.TabIndex = 4;
            this.LBCurrentUser.Text = "USUARIO ACTUAL: ";
            // 
            // Users
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(950, 497);
            this.Controls.Add(this.LBCurrentUser);
            this.Controls.Add(this.RefreshList);
            this.Controls.Add(this.ModifyUser);
            this.Controls.Add(this.deleteUser);
            this.Controls.Add(this.dgvUsersList);
            this.Name = "Users";
            this.Text = "Users";
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsersList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvUsersList;
        private System.Windows.Forms.Button deleteUser;
        private System.Windows.Forms.Button ModifyUser;
        private System.Windows.Forms.Button RefreshList;
        private System.Windows.Forms.Label LBCurrentUser;
    }
}