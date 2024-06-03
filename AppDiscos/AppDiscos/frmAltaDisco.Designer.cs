namespace AppDiscos
{
    partial class frmAltaDisco
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtbTitulo = new System.Windows.Forms.TextBox();
            this.txtbCanciones = new System.Windows.Forms.TextBox();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.lblEdicion = new System.Windows.Forms.Label();
            this.lblEstilo = new System.Windows.Forms.Label();
            this.cboEstilo = new System.Windows.Forms.ComboBox();
            this.cboEdicion = new System.Windows.Forms.ComboBox();
            this.lblUrlImg = new System.Windows.Forms.Label();
            this.txtUrl = new System.Windows.Forms.TextBox();
            this.pbxDisco = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dateDisco = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.pbxDisco)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(62, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Titulo";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(62, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Canciones";
            // 
            // txtbTitulo
            // 
            this.txtbTitulo.Location = new System.Drawing.Point(132, 49);
            this.txtbTitulo.Name = "txtbTitulo";
            this.txtbTitulo.Size = new System.Drawing.Size(121, 20);
            this.txtbTitulo.TabIndex = 0;
            // 
            // txtbCanciones
            // 
            this.txtbCanciones.Location = new System.Drawing.Point(132, 80);
            this.txtbCanciones.Name = "txtbCanciones";
            this.txtbCanciones.Size = new System.Drawing.Size(121, 20);
            this.txtbCanciones.TabIndex = 1;
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(52, 256);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(85, 36);
            this.btnAceptar.TabIndex = 5;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(185, 256);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(88, 36);
            this.btnCancelar.TabIndex = 6;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // lblEdicion
            // 
            this.lblEdicion.AutoSize = true;
            this.lblEdicion.Location = new System.Drawing.Point(62, 154);
            this.lblEdicion.Name = "lblEdicion";
            this.lblEdicion.Size = new System.Drawing.Size(42, 13);
            this.lblEdicion.TabIndex = 9;
            this.lblEdicion.Text = "Edición";
            this.lblEdicion.Click += new System.EventHandler(this.label3_Click);
            // 
            // lblEstilo
            // 
            this.lblEstilo.AutoSize = true;
            this.lblEstilo.Location = new System.Drawing.Point(63, 120);
            this.lblEstilo.Name = "lblEstilo";
            this.lblEstilo.Size = new System.Drawing.Size(32, 13);
            this.lblEstilo.TabIndex = 8;
            this.lblEstilo.Text = "Estilo";
            this.lblEstilo.Click += new System.EventHandler(this.label4_Click);
            // 
            // cboEstilo
            // 
            this.cboEstilo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboEstilo.FormattingEnabled = true;
            this.cboEstilo.Location = new System.Drawing.Point(132, 117);
            this.cboEstilo.Name = "cboEstilo";
            this.cboEstilo.Size = new System.Drawing.Size(121, 21);
            this.cboEstilo.TabIndex = 2;
            // 
            // cboEdicion
            // 
            this.cboEdicion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboEdicion.FormattingEnabled = true;
            this.cboEdicion.Location = new System.Drawing.Point(132, 151);
            this.cboEdicion.Name = "cboEdicion";
            this.cboEdicion.Size = new System.Drawing.Size(121, 21);
            this.cboEdicion.TabIndex = 3;
            // 
            // lblUrlImg
            // 
            this.lblUrlImg.AutoSize = true;
            this.lblUrlImg.Location = new System.Drawing.Point(61, 188);
            this.lblUrlImg.Name = "lblUrlImg";
            this.lblUrlImg.Size = new System.Drawing.Size(58, 13);
            this.lblUrlImg.TabIndex = 12;
            this.lblUrlImg.Text = "Url Imagen";
            // 
            // txtUrl
            // 
            this.txtUrl.Location = new System.Drawing.Point(132, 185);
            this.txtUrl.Name = "txtUrl";
            this.txtUrl.Size = new System.Drawing.Size(121, 20);
            this.txtUrl.TabIndex = 4;
            this.txtUrl.TextChanged += new System.EventHandler(this.txtUrl_TextChanged);
            // 
            // pbxDisco
            // 
            this.pbxDisco.Location = new System.Drawing.Point(307, 49);
            this.pbxDisco.Name = "pbxDisco";
            this.pbxDisco.Size = new System.Drawing.Size(176, 152);
            this.pbxDisco.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxDisco.TabIndex = 14;
            this.pbxDisco.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(62, 216);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 15;
            this.label3.Text = "Fecha";
            // 
            // dateDisco
            // 
            this.dateDisco.Location = new System.Drawing.Point(132, 216);
            this.dateDisco.Name = "dateDisco";
            this.dateDisco.Size = new System.Drawing.Size(121, 20);
            this.dateDisco.TabIndex = 16;
            // 
            // frmAltaDisco
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(520, 304);
            this.Controls.Add(this.dateDisco);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pbxDisco);
            this.Controls.Add(this.txtUrl);
            this.Controls.Add(this.lblUrlImg);
            this.Controls.Add(this.cboEdicion);
            this.Controls.Add(this.cboEstilo);
            this.Controls.Add(this.lblEdicion);
            this.Controls.Add(this.lblEstilo);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.txtbCanciones);
            this.Controls.Add(this.txtbTitulo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmAltaDisco";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nuevo Disco";
            this.Load += new System.EventHandler(this.frmAltaDisco_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbxDisco)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtbTitulo;
        private System.Windows.Forms.TextBox txtbCanciones;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Label lblEdicion;
        private System.Windows.Forms.Label lblEstilo;
        private System.Windows.Forms.ComboBox cboEstilo;
        private System.Windows.Forms.ComboBox cboEdicion;
        private System.Windows.Forms.Label lblUrlImg;
        private System.Windows.Forms.TextBox txtUrl;
        private System.Windows.Forms.PictureBox pbxDisco;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dateDisco;
    }
}