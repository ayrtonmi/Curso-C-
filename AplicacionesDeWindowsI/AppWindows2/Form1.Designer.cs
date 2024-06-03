namespace AppWindows2
{
    partial class frmDatosPersonales
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
            this.lblApellido = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblEdad = new System.Windows.Forms.Label();
            this.lblDireccion = new System.Windows.Forms.Label();
            this.lblResultado = new System.Windows.Forms.Label();
            this.tbApellido = new System.Windows.Forms.TextBox();
            this.tbNombre = new System.Windows.Forms.TextBox();
            this.tbEdad = new System.Windows.Forms.TextBox();
            this.tbDireccion = new System.Windows.Forms.TextBox();
            this.tbResultado = new System.Windows.Forms.TextBox();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblApellido
            // 
            this.lblApellido.AutoSize = true;
            this.lblApellido.Location = new System.Drawing.Point(31, 50);
            this.lblApellido.Name = "lblApellido";
            this.lblApellido.Size = new System.Drawing.Size(59, 13);
            this.lblApellido.TabIndex = 0;
            this.lblApellido.Text = "APELLIDO";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(31, 81);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(54, 13);
            this.lblNombre.TabIndex = 1;
            this.lblNombre.Text = "NOMBRE";
            // 
            // lblEdad
            // 
            this.lblEdad.AutoSize = true;
            this.lblEdad.Location = new System.Drawing.Point(31, 112);
            this.lblEdad.Name = "lblEdad";
            this.lblEdad.Size = new System.Drawing.Size(37, 13);
            this.lblEdad.TabIndex = 2;
            this.lblEdad.Text = "EDAD";
            // 
            // lblDireccion
            // 
            this.lblDireccion.AutoSize = true;
            this.lblDireccion.Location = new System.Drawing.Point(31, 142);
            this.lblDireccion.Name = "lblDireccion";
            this.lblDireccion.Size = new System.Drawing.Size(66, 13);
            this.lblDireccion.TabIndex = 3;
            this.lblDireccion.Text = "DIRECCIÓN";
            // 
            // lblResultado
            // 
            this.lblResultado.AutoSize = true;
            this.lblResultado.Location = new System.Drawing.Point(31, 207);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(73, 13);
            this.lblResultado.TabIndex = 4;
            this.lblResultado.Text = "RESULTADO";
            // 
            // tbApellido
            // 
            this.tbApellido.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tbApellido.Location = new System.Drawing.Point(110, 47);
            this.tbApellido.MaxLength = 25;
            this.tbApellido.Name = "tbApellido";
            this.tbApellido.Size = new System.Drawing.Size(437, 20);
            this.tbApellido.TabIndex = 5;
            // 
            // tbNombre
            // 
            this.tbNombre.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tbNombre.Location = new System.Drawing.Point(110, 78);
            this.tbNombre.MaxLength = 25;
            this.tbNombre.Name = "tbNombre";
            this.tbNombre.Size = new System.Drawing.Size(437, 20);
            this.tbNombre.TabIndex = 6;
            // 
            // tbEdad
            // 
            this.tbEdad.Location = new System.Drawing.Point(110, 109);
            this.tbEdad.MaxLength = 3;
            this.tbEdad.Name = "tbEdad";
            this.tbEdad.Size = new System.Drawing.Size(46, 20);
            this.tbEdad.TabIndex = 7;
            this.tbEdad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbEdad_KeyPress);
            // 
            // tbDireccion
            // 
            this.tbDireccion.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tbDireccion.Location = new System.Drawing.Point(110, 139);
            this.tbDireccion.MaxLength = 60;
            this.tbDireccion.Name = "tbDireccion";
            this.tbDireccion.Size = new System.Drawing.Size(437, 20);
            this.tbDireccion.TabIndex = 8;
            // 
            // tbResultado
            // 
            this.tbResultado.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tbResultado.Location = new System.Drawing.Point(34, 223);
            this.tbResultado.Multiline = true;
            this.tbResultado.Name = "tbResultado";
            this.tbResultado.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbResultado.Size = new System.Drawing.Size(513, 111);
            this.tbResultado.TabIndex = 9;
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(152, 340);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(97, 23);
            this.btnAceptar.TabIndex = 10;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(334, 340);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(94, 23);
            this.btnCancelar.TabIndex = 11;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // frmDatosPersonales
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(578, 412);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.tbResultado);
            this.Controls.Add(this.tbDireccion);
            this.Controls.Add(this.tbEdad);
            this.Controls.Add(this.tbNombre);
            this.Controls.Add(this.tbApellido);
            this.Controls.Add(this.lblResultado);
            this.Controls.Add(this.lblDireccion);
            this.Controls.Add(this.lblEdad);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.lblApellido);
            this.MaximumSize = new System.Drawing.Size(594, 451);
            this.MinimumSize = new System.Drawing.Size(594, 451);
            this.Name = "frmDatosPersonales";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Datos Personales";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblApellido;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblEdad;
        private System.Windows.Forms.Label lblDireccion;
        private System.Windows.Forms.Label lblResultado;
        private System.Windows.Forms.TextBox tbApellido;
        private System.Windows.Forms.TextBox tbNombre;
        private System.Windows.Forms.TextBox tbEdad;
        private System.Windows.Forms.TextBox tbDireccion;
        private System.Windows.Forms.TextBox tbResultado;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Button btnCancelar;
    }
}

