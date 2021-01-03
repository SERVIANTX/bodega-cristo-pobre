
namespace bodega_cristo_pobre
{
    partial class Registro
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
            this.txtNombres = new PlaceholderTextBox.PlaceholderTextBox();
            this.txtApellidos = new PlaceholderTextBox.PlaceholderTextBox();
            this.txtTelefono = new PlaceholderTextBox.PlaceholderTextBox();
            this.txtNumDoc = new PlaceholderTextBox.PlaceholderTextBox();
            this.txtCarg = new PlaceholderTextBox.PlaceholderTextBox();
            this.txtemail = new PlaceholderTextBox.PlaceholderTextBox();
            this.txtusuario = new PlaceholderTextBox.PlaceholderTextBox();
            this.txtPassword = new PlaceholderTextBox.PlaceholderTextBox();
            this.txtIdPer = new PlaceholderTextBox.PlaceholderTextBox();
            this.txttipdoc = new PlaceholderTextBox.PlaceholderTextBox();
            this.btnNuevo = new FontAwesome.Sharp.IconButton();
            this.BtnAgregar = new FontAwesome.Sharp.IconButton();
            this.SuspendLayout();
            // 
            // txtNombres
            // 
            this.txtNombres.Font = new System.Drawing.Font("Century Schoolbook", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombres.ForeColor = System.Drawing.SystemColors.MenuText;
            this.txtNombres.Location = new System.Drawing.Point(23, 67);
            this.txtNombres.Name = "txtNombres";
            this.txtNombres.PlaceholderText = "Nombres";
            this.txtNombres.Size = new System.Drawing.Size(184, 30);
            this.txtNombres.TabIndex = 141;
            this.txtNombres.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtApellidos
            // 
            this.txtApellidos.Font = new System.Drawing.Font("Century Schoolbook", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtApellidos.ForeColor = System.Drawing.SystemColors.MenuText;
            this.txtApellidos.Location = new System.Drawing.Point(23, 103);
            this.txtApellidos.Name = "txtApellidos";
            this.txtApellidos.PlaceholderText = "Apellidos";
            this.txtApellidos.Size = new System.Drawing.Size(184, 30);
            this.txtApellidos.TabIndex = 142;
            this.txtApellidos.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtTelefono
            // 
            this.txtTelefono.Font = new System.Drawing.Font("Century Schoolbook", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTelefono.ForeColor = System.Drawing.SystemColors.MenuText;
            this.txtTelefono.Location = new System.Drawing.Point(23, 139);
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.PlaceholderText = "Teléfono";
            this.txtTelefono.Size = new System.Drawing.Size(184, 30);
            this.txtTelefono.TabIndex = 143;
            this.txtTelefono.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtTelefono.TextChanged += new System.EventHandler(this.txtTelefono_TextChanged);
            // 
            // txtNumDoc
            // 
            this.txtNumDoc.Font = new System.Drawing.Font("Century Schoolbook", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNumDoc.ForeColor = System.Drawing.SystemColors.MenuText;
            this.txtNumDoc.Location = new System.Drawing.Point(23, 283);
            this.txtNumDoc.Name = "txtNumDoc";
            this.txtNumDoc.PlaceholderText = "Nro. Documento";
            this.txtNumDoc.Size = new System.Drawing.Size(184, 30);
            this.txtNumDoc.TabIndex = 144;
            this.txtNumDoc.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtCarg
            // 
            this.txtCarg.Font = new System.Drawing.Font("Century Schoolbook", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCarg.ForeColor = System.Drawing.SystemColors.MenuText;
            this.txtCarg.Location = new System.Drawing.Point(23, 175);
            this.txtCarg.Name = "txtCarg";
            this.txtCarg.PlaceholderText = "Cargo";
            this.txtCarg.Size = new System.Drawing.Size(184, 30);
            this.txtCarg.TabIndex = 145;
            this.txtCarg.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtemail
            // 
            this.txtemail.Font = new System.Drawing.Font("Century Schoolbook", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtemail.ForeColor = System.Drawing.SystemColors.MenuText;
            this.txtemail.Location = new System.Drawing.Point(23, 211);
            this.txtemail.Name = "txtemail";
            this.txtemail.PlaceholderText = "Correo";
            this.txtemail.Size = new System.Drawing.Size(184, 30);
            this.txtemail.TabIndex = 146;
            this.txtemail.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtusuario
            // 
            this.txtusuario.Font = new System.Drawing.Font("Century Schoolbook", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtusuario.ForeColor = System.Drawing.SystemColors.MenuText;
            this.txtusuario.Location = new System.Drawing.Point(23, 319);
            this.txtusuario.Name = "txtusuario";
            this.txtusuario.PlaceholderText = "Usuario";
            this.txtusuario.Size = new System.Drawing.Size(184, 30);
            this.txtusuario.TabIndex = 147;
            this.txtusuario.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtPassword
            // 
            this.txtPassword.Font = new System.Drawing.Font("Century Schoolbook", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassword.ForeColor = System.Drawing.SystemColors.MenuText;
            this.txtPassword.Location = new System.Drawing.Point(23, 355);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.PlaceholderText = "Password";
            this.txtPassword.Size = new System.Drawing.Size(184, 30);
            this.txtPassword.TabIndex = 148;
            this.txtPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtIdPer
            // 
            this.txtIdPer.Font = new System.Drawing.Font("Century Schoolbook", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIdPer.Location = new System.Drawing.Point(23, 21);
            this.txtIdPer.Name = "txtIdPer";
            this.txtIdPer.PlaceholderText = "Id";
            this.txtIdPer.ReadOnly = true;
            this.txtIdPer.Size = new System.Drawing.Size(41, 30);
            this.txtIdPer.TabIndex = 149;
            // 
            // txttipdoc
            // 
            this.txttipdoc.Font = new System.Drawing.Font("Century Schoolbook", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txttipdoc.ForeColor = System.Drawing.SystemColors.MenuText;
            this.txttipdoc.Location = new System.Drawing.Point(23, 247);
            this.txttipdoc.Name = "txttipdoc";
            this.txttipdoc.PlaceholderText = "Tipo De Documento";
            this.txttipdoc.Size = new System.Drawing.Size(184, 30);
            this.txttipdoc.TabIndex = 150;
            this.txttipdoc.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnNuevo
            // 
            this.btnNuevo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnNuevo.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnNuevo.FlatAppearance.BorderSize = 2;
            this.btnNuevo.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray;
            this.btnNuevo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btnNuevo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNuevo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNuevo.ForeColor = System.Drawing.Color.DarkViolet;
            this.btnNuevo.IconChar = FontAwesome.Sharp.IconChar.Pen;
            this.btnNuevo.IconColor = System.Drawing.Color.DarkViolet;
            this.btnNuevo.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnNuevo.IconSize = 27;
            this.btnNuevo.Location = new System.Drawing.Point(255, 139);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(120, 49);
            this.btnNuevo.TabIndex = 152;
            this.btnNuevo.Text = "Nuevo";
            this.btnNuevo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnNuevo.UseVisualStyleBackColor = false;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // BtnAgregar
            // 
            this.BtnAgregar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.BtnAgregar.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.BtnAgregar.FlatAppearance.BorderSize = 2;
            this.BtnAgregar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray;
            this.BtnAgregar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.BtnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAgregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAgregar.ForeColor = System.Drawing.Color.DarkViolet;
            this.BtnAgregar.IconChar = FontAwesome.Sharp.IconChar.Save;
            this.BtnAgregar.IconColor = System.Drawing.Color.DarkViolet;
            this.BtnAgregar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnAgregar.IconSize = 27;
            this.BtnAgregar.Location = new System.Drawing.Point(255, 221);
            this.BtnAgregar.Name = "BtnAgregar";
            this.BtnAgregar.Size = new System.Drawing.Size(120, 49);
            this.BtnAgregar.TabIndex = 153;
            this.BtnAgregar.Text = "Agregar";
            this.BtnAgregar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnAgregar.UseVisualStyleBackColor = false;
            this.BtnAgregar.Click += new System.EventHandler(this.BtnAgregar_Click);
            // 
            // Registro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(228)))), ((int)(((byte)(244)))));
            this.ClientSize = new System.Drawing.Size(401, 424);
            this.Controls.Add(this.BtnAgregar);
            this.Controls.Add(this.btnNuevo);
            this.Controls.Add(this.txttipdoc);
            this.Controls.Add(this.txtIdPer);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtusuario);
            this.Controls.Add(this.txtemail);
            this.Controls.Add(this.txtCarg);
            this.Controls.Add(this.txtNumDoc);
            this.Controls.Add(this.txtTelefono);
            this.Controls.Add(this.txtApellidos);
            this.Controls.Add(this.txtNombres);
            this.Name = "Registro";
            this.Text = "Registro";
            this.Load += new System.EventHandler(this.Registro_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private PlaceholderTextBox.PlaceholderTextBox txtNombres;
        private PlaceholderTextBox.PlaceholderTextBox txtApellidos;
        private PlaceholderTextBox.PlaceholderTextBox txtTelefono;
        private PlaceholderTextBox.PlaceholderTextBox txtNumDoc;
        private PlaceholderTextBox.PlaceholderTextBox txtCarg;
        private PlaceholderTextBox.PlaceholderTextBox txtemail;
        private PlaceholderTextBox.PlaceholderTextBox txtusuario;
        private PlaceholderTextBox.PlaceholderTextBox txtPassword;
        private PlaceholderTextBox.PlaceholderTextBox txtIdPer;
        private PlaceholderTextBox.PlaceholderTextBox txttipdoc;
        private FontAwesome.Sharp.IconButton btnNuevo;
        private FontAwesome.Sharp.IconButton BtnAgregar;
    }
}

