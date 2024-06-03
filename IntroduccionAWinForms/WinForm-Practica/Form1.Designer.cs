namespace WinForm_Practica
{
    partial class Form1
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
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblApellido = new System.Windows.Forms.Label();
            this.lblTituloFormulario = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.txtbNombre = new System.Windows.Forms.TextBox();
            this.txtbApellido = new System.Windows.Forms.TextBox();
            this.txtbEmail = new System.Windows.Forms.TextBox();
            this.btnRegistrarse = new System.Windows.Forms.Button();
            this.gbEstadoCivil = new System.Windows.Forms.GroupBox();
            this.rbNC = new System.Windows.Forms.RadioButton();
            this.rbSoltero = new System.Windows.Forms.RadioButton();
            this.rbCasado = new System.Windows.Forms.RadioButton();
            this.dtpFecha = new System.Windows.Forms.DateTimePicker();
            this.lblFecha = new System.Windows.Forms.Label();
            this.cmbNacionalidad = new System.Windows.Forms.ComboBox();
            this.lblNacionalidad = new System.Windows.Forms.Label();
            this.gbMascota = new System.Windows.Forms.GroupBox();
            this.ckbNinguna = new System.Windows.Forms.CheckBox();
            this.ckbOtro = new System.Windows.Forms.CheckBox();
            this.ckbLoro = new System.Windows.Forms.CheckBox();
            this.ckbHuron = new System.Windows.Forms.CheckBox();
            this.ckbGato = new System.Windows.Forms.CheckBox();
            this.ckbPerro = new System.Windows.Forms.CheckBox();
            this.lblMascota = new System.Windows.Forms.Label();
            this.lblHelados = new System.Windows.Forms.Label();
            this.btnOkHelado = new System.Windows.Forms.Button();
            this.txtbHelado = new System.Windows.Forms.TextBox();
            this.listViewHelados = new System.Windows.Forms.ListView();
            this.gbEstadoCivil.SuspendLayout();
            this.gbMascota.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblNombre
            // 
            this.lblNombre.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(168, 84);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(47, 13);
            this.lblNombre.TabIndex = 0;
            this.lblNombre.Text = "Nombre:";
            // 
            // lblApellido
            // 
            this.lblApellido.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblApellido.AutoSize = true;
            this.lblApellido.Location = new System.Drawing.Point(168, 124);
            this.lblApellido.Name = "lblApellido";
            this.lblApellido.Size = new System.Drawing.Size(47, 13);
            this.lblApellido.TabIndex = 1;
            this.lblApellido.Text = "Apellido:";
            // 
            // lblTituloFormulario
            // 
            this.lblTituloFormulario.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTituloFormulario.AutoSize = true;
            this.lblTituloFormulario.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituloFormulario.Location = new System.Drawing.Point(202, 9);
            this.lblTituloFormulario.Name = "lblTituloFormulario";
            this.lblTituloFormulario.Size = new System.Drawing.Size(304, 25);
            this.lblTituloFormulario.TabIndex = 2;
            this.lblTituloFormulario.Text = "FORMULARIO DE REGISTRO";
            // 
            // lblEmail
            // 
            this.lblEmail.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(180, 166);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(35, 13);
            this.lblEmail.TabIndex = 3;
            this.lblEmail.Text = "Email:";
            // 
            // txtbNombre
            // 
            this.txtbNombre.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtbNombre.Location = new System.Drawing.Point(242, 84);
            this.txtbNombre.Name = "txtbNombre";
            this.txtbNombre.Size = new System.Drawing.Size(270, 20);
            this.txtbNombre.TabIndex = 0;
            // 
            // txtbApellido
            // 
            this.txtbApellido.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtbApellido.Location = new System.Drawing.Point(242, 121);
            this.txtbApellido.Name = "txtbApellido";
            this.txtbApellido.Size = new System.Drawing.Size(270, 20);
            this.txtbApellido.TabIndex = 1;
            // 
            // txtbEmail
            // 
            this.txtbEmail.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtbEmail.Location = new System.Drawing.Point(242, 163);
            this.txtbEmail.Name = "txtbEmail";
            this.txtbEmail.Size = new System.Drawing.Size(270, 20);
            this.txtbEmail.TabIndex = 2;
            // 
            // btnRegistrarse
            // 
            this.btnRegistrarse.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnRegistrarse.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnRegistrarse.FlatAppearance.BorderColor = System.Drawing.Color.MediumSeaGreen;
            this.btnRegistrarse.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SeaGreen;
            this.btnRegistrarse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegistrarse.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegistrarse.Location = new System.Drawing.Point(174, 649);
            this.btnRegistrarse.Name = "btnRegistrarse";
            this.btnRegistrarse.Size = new System.Drawing.Size(389, 55);
            this.btnRegistrarse.TabIndex = 10;
            this.btnRegistrarse.Text = "REGISTRARSE";
            this.btnRegistrarse.UseVisualStyleBackColor = false;
            this.btnRegistrarse.Click += new System.EventHandler(this.btnRegistrarse_Click);
            // 
            // gbEstadoCivil
            // 
            this.gbEstadoCivil.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.gbEstadoCivil.Controls.Add(this.rbNC);
            this.gbEstadoCivil.Controls.Add(this.rbSoltero);
            this.gbEstadoCivil.Controls.Add(this.rbCasado);
            this.gbEstadoCivil.Location = new System.Drawing.Point(169, 217);
            this.gbEstadoCivil.Name = "gbEstadoCivil";
            this.gbEstadoCivil.Size = new System.Drawing.Size(380, 50);
            this.gbEstadoCivil.TabIndex = 3;
            this.gbEstadoCivil.TabStop = false;
            this.gbEstadoCivil.Text = "Estado Civil:";
            // 
            // rbNC
            // 
            this.rbNC.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.rbNC.AutoSize = true;
            this.rbNC.Location = new System.Drawing.Point(239, 19);
            this.rbNC.Name = "rbNC";
            this.rbNC.Size = new System.Drawing.Size(45, 17);
            this.rbNC.TabIndex = 0;
            this.rbNC.TabStop = true;
            this.rbNC.Text = "N/C";
            this.rbNC.UseVisualStyleBackColor = true;
            // 
            // rbSoltero
            // 
            this.rbSoltero.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.rbSoltero.AutoSize = true;
            this.rbSoltero.Location = new System.Drawing.Point(147, 19);
            this.rbSoltero.Name = "rbSoltero";
            this.rbSoltero.Size = new System.Drawing.Size(58, 17);
            this.rbSoltero.TabIndex = 2;
            this.rbSoltero.TabStop = true;
            this.rbSoltero.Text = "Soltero";
            this.rbSoltero.UseVisualStyleBackColor = true;
            // 
            // rbCasado
            // 
            this.rbCasado.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.rbCasado.AutoSize = true;
            this.rbCasado.BackColor = System.Drawing.SystemColors.Control;
            this.rbCasado.Location = new System.Drawing.Point(60, 19);
            this.rbCasado.Name = "rbCasado";
            this.rbCasado.Size = new System.Drawing.Size(61, 17);
            this.rbCasado.TabIndex = 1;
            this.rbCasado.TabStop = true;
            this.rbCasado.Text = "Casado";
            this.rbCasado.UseVisualStyleBackColor = false;
            // 
            // dtpFecha
            // 
            this.dtpFecha.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.dtpFecha.Location = new System.Drawing.Point(242, 300);
            this.dtpFecha.Name = "dtpFecha";
            this.dtpFecha.Size = new System.Drawing.Size(270, 20);
            this.dtpFecha.TabIndex = 4;
            // 
            // lblFecha
            // 
            this.lblFecha.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblFecha.AutoSize = true;
            this.lblFecha.Location = new System.Drawing.Point(180, 300);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(40, 13);
            this.lblFecha.TabIndex = 14;
            this.lblFecha.Text = "Fecha:";
            // 
            // cmbNacionalidad
            // 
            this.cmbNacionalidad.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbNacionalidad.FormattingEnabled = true;
            this.cmbNacionalidad.Location = new System.Drawing.Point(242, 349);
            this.cmbNacionalidad.Name = "cmbNacionalidad";
            this.cmbNacionalidad.Size = new System.Drawing.Size(269, 21);
            this.cmbNacionalidad.TabIndex = 5;
            // 
            // lblNacionalidad
            // 
            this.lblNacionalidad.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblNacionalidad.AutoSize = true;
            this.lblNacionalidad.Location = new System.Drawing.Point(148, 352);
            this.lblNacionalidad.Name = "lblNacionalidad";
            this.lblNacionalidad.Size = new System.Drawing.Size(72, 13);
            this.lblNacionalidad.TabIndex = 16;
            this.lblNacionalidad.Text = "Nacionalidad:";
            // 
            // gbMascota
            // 
            this.gbMascota.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.gbMascota.Controls.Add(this.ckbNinguna);
            this.gbMascota.Controls.Add(this.ckbOtro);
            this.gbMascota.Controls.Add(this.ckbLoro);
            this.gbMascota.Controls.Add(this.ckbHuron);
            this.gbMascota.Controls.Add(this.ckbGato);
            this.gbMascota.Controls.Add(this.ckbPerro);
            this.gbMascota.Location = new System.Drawing.Point(242, 399);
            this.gbMascota.Name = "gbMascota";
            this.gbMascota.Size = new System.Drawing.Size(102, 207);
            this.gbMascota.TabIndex = 7;
            this.gbMascota.TabStop = false;
            // 
            // ckbNinguna
            // 
            this.ckbNinguna.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.ckbNinguna.AutoSize = true;
            this.ckbNinguna.Location = new System.Drawing.Point(6, 184);
            this.ckbNinguna.Name = "ckbNinguna";
            this.ckbNinguna.Size = new System.Drawing.Size(66, 17);
            this.ckbNinguna.TabIndex = 5;
            this.ckbNinguna.Text = "Ninguna";
            this.ckbNinguna.UseVisualStyleBackColor = true;
            // 
            // ckbOtro
            // 
            this.ckbOtro.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.ckbOtro.AutoSize = true;
            this.ckbOtro.Location = new System.Drawing.Point(6, 148);
            this.ckbOtro.Name = "ckbOtro";
            this.ckbOtro.Size = new System.Drawing.Size(51, 17);
            this.ckbOtro.TabIndex = 4;
            this.ckbOtro.Text = "Otros";
            this.ckbOtro.UseVisualStyleBackColor = true;
            // 
            // ckbLoro
            // 
            this.ckbLoro.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.ckbLoro.AutoSize = true;
            this.ckbLoro.Location = new System.Drawing.Point(6, 117);
            this.ckbLoro.Name = "ckbLoro";
            this.ckbLoro.Size = new System.Drawing.Size(57, 17);
            this.ckbLoro.TabIndex = 3;
            this.ckbLoro.Text = "Loro/s";
            this.ckbLoro.UseVisualStyleBackColor = true;
            // 
            // ckbHuron
            // 
            this.ckbHuron.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.ckbHuron.AutoSize = true;
            this.ckbHuron.Location = new System.Drawing.Point(6, 85);
            this.ckbHuron.Name = "ckbHuron";
            this.ckbHuron.Size = new System.Drawing.Size(71, 17);
            this.ckbHuron.TabIndex = 2;
            this.ckbHuron.Text = "Hurón/es";
            this.ckbHuron.UseVisualStyleBackColor = true;
            // 
            // ckbGato
            // 
            this.ckbGato.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.ckbGato.AutoSize = true;
            this.ckbGato.Location = new System.Drawing.Point(6, 52);
            this.ckbGato.Name = "ckbGato";
            this.ckbGato.Size = new System.Drawing.Size(59, 17);
            this.ckbGato.TabIndex = 1;
            this.ckbGato.Text = "Gato/s";
            this.ckbGato.UseVisualStyleBackColor = true;
            // 
            // ckbPerro
            // 
            this.ckbPerro.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.ckbPerro.AutoSize = true;
            this.ckbPerro.Location = new System.Drawing.Point(6, 19);
            this.ckbPerro.Name = "ckbPerro";
            this.ckbPerro.Size = new System.Drawing.Size(61, 17);
            this.ckbPerro.TabIndex = 0;
            this.ckbPerro.Text = "Perro/s";
            this.ckbPerro.UseVisualStyleBackColor = true;
            // 
            // lblMascota
            // 
            this.lblMascota.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblMascota.AutoSize = true;
            this.lblMascota.Location = new System.Drawing.Point(180, 399);
            this.lblMascota.Name = "lblMascota";
            this.lblMascota.Size = new System.Drawing.Size(51, 13);
            this.lblMascota.TabIndex = 6;
            this.lblMascota.Text = "Mascota:";
            // 
            // lblHelados
            // 
            this.lblHelados.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblHelados.AutoSize = true;
            this.lblHelados.Location = new System.Drawing.Point(364, 399);
            this.lblHelados.Name = "lblHelados";
            this.lblHelados.Size = new System.Drawing.Size(92, 13);
            this.lblHelados.TabIndex = 20;
            this.lblHelados.Text = "Helados favoritos:";
            // 
            // btnOkHelado
            // 
            this.btnOkHelado.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnOkHelado.AutoSize = true;
            this.btnOkHelado.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.btnOkHelado.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btnOkHelado.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOkHelado.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOkHelado.Location = new System.Drawing.Point(492, 422);
            this.btnOkHelado.Name = "btnOkHelado";
            this.btnOkHelado.Size = new System.Drawing.Size(45, 25);
            this.btnOkHelado.TabIndex = 9;
            this.btnOkHelado.Text = "OK";
            this.btnOkHelado.UseVisualStyleBackColor = false;
            this.btnOkHelado.Click += new System.EventHandler(this.btnOkHelado_Click);
            // 
            // txtbHelado
            // 
            this.txtbHelado.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtbHelado.Location = new System.Drawing.Point(463, 396);
            this.txtbHelado.Name = "txtbHelado";
            this.txtbHelado.Size = new System.Drawing.Size(100, 20);
            this.txtbHelado.TabIndex = 8;
            // 
            // listViewHelados
            // 
            this.listViewHelados.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.listViewHelados.HideSelection = false;
            this.listViewHelados.Location = new System.Drawing.Point(463, 467);
            this.listViewHelados.Name = "listViewHelados";
            this.listViewHelados.Size = new System.Drawing.Size(100, 139);
            this.listViewHelados.TabIndex = 23;
            this.listViewHelados.UseCompatibleStateImageBehavior = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MintCream;
            this.ClientSize = new System.Drawing.Size(753, 722);
            this.Controls.Add(this.listViewHelados);
            this.Controls.Add(this.txtbHelado);
            this.Controls.Add(this.btnOkHelado);
            this.Controls.Add(this.lblHelados);
            this.Controls.Add(this.lblMascota);
            this.Controls.Add(this.gbMascota);
            this.Controls.Add(this.lblNacionalidad);
            this.Controls.Add(this.cmbNacionalidad);
            this.Controls.Add(this.lblFecha);
            this.Controls.Add(this.dtpFecha);
            this.Controls.Add(this.gbEstadoCivil);
            this.Controls.Add(this.btnRegistrarse);
            this.Controls.Add(this.txtbEmail);
            this.Controls.Add(this.txtbApellido);
            this.Controls.Add(this.txtbNombre);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.lblTituloFormulario);
            this.Controls.Add(this.lblApellido);
            this.Controls.Add(this.lblNombre);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MinimumSize = new System.Drawing.Size(769, 761);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.gbEstadoCivil.ResumeLayout(false);
            this.gbEstadoCivil.PerformLayout();
            this.gbMascota.ResumeLayout(false);
            this.gbMascota.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblApellido;
        private System.Windows.Forms.Label lblTituloFormulario;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox txtbNombre;
        private System.Windows.Forms.TextBox txtbApellido;
        private System.Windows.Forms.TextBox txtbEmail;
        private System.Windows.Forms.Button btnRegistrarse;
        private System.Windows.Forms.GroupBox gbEstadoCivil;
        private System.Windows.Forms.RadioButton rbNC;
        private System.Windows.Forms.RadioButton rbSoltero;
        private System.Windows.Forms.RadioButton rbCasado;
        private System.Windows.Forms.DateTimePicker dtpFecha;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.ComboBox cmbNacionalidad;
        private System.Windows.Forms.Label lblNacionalidad;
        private System.Windows.Forms.GroupBox gbMascota;
        private System.Windows.Forms.Label lblMascota;
        private System.Windows.Forms.CheckBox ckbLoro;
        private System.Windows.Forms.CheckBox ckbHuron;
        private System.Windows.Forms.CheckBox ckbGato;
        private System.Windows.Forms.CheckBox ckbPerro;
        private System.Windows.Forms.CheckBox ckbNinguna;
        private System.Windows.Forms.CheckBox ckbOtro;
        private System.Windows.Forms.Label lblHelados;
        private System.Windows.Forms.Button btnOkHelado;
        private System.Windows.Forms.TextBox txtbHelado;
        private System.Windows.Forms.ListView listViewHelados;
    }
}

