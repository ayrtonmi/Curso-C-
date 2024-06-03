namespace WinFormApp_C
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
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.listElementos = new System.Windows.Forms.ListView();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblFecha = new System.Windows.Forms.Label();
            this.dateTimePickerFechaNac = new System.Windows.Forms.DateTimePicker();
            this.checkBoxChocolate = new System.Windows.Forms.CheckBox();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.radioButtonWizard = new System.Windows.Forms.RadioButton();
            this.radioButtonMuggle = new System.Windows.Forms.RadioButton();
            this.radioButtonSquibs = new System.Windows.Forms.RadioButton();
            this.groupBoxTipo = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxColorFav = new System.Windows.Forms.ComboBox();
            this.NumFav = new System.Windows.Forms.NumericUpDown();
            this.lblNumFav = new System.Windows.Forms.Label();
            this.btnVerPerfil = new System.Windows.Forms.Button();
            this.groupBoxTipo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NumFav)).BeginInit();
            this.SuspendLayout();
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(137, 57);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(201, 20);
            this.txtNombre.TabIndex = 0;
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(403, 493);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(75, 23);
            this.btnAgregar.TabIndex = 1;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // listElementos
            // 
            this.listElementos.HideSelection = false;
            this.listElementos.Location = new System.Drawing.Point(59, 419);
            this.listElementos.Name = "listElementos";
            this.listElementos.Size = new System.Drawing.Size(338, 97);
            this.listElementos.TabIndex = 2;
            this.listElementos.UseCompatibleStateImageBehavior = false;
            this.listElementos.View = System.Windows.Forms.View.List;
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(84, 60);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(47, 13);
            this.lblNombre.TabIndex = 3;
            this.lblNombre.Text = "Nombre:";
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Location = new System.Drawing.Point(35, 89);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(96, 13);
            this.lblFecha.TabIndex = 4;
            this.lblFecha.Text = "Fecha Nacimiento:";
            // 
            // dateTimePickerFechaNac
            // 
            this.dateTimePickerFechaNac.Location = new System.Drawing.Point(138, 89);
            this.dateTimePickerFechaNac.Name = "dateTimePickerFechaNac";
            this.dateTimePickerFechaNac.Size = new System.Drawing.Size(200, 20);
            this.dateTimePickerFechaNac.TabIndex = 5;
            // 
            // checkBoxChocolate
            // 
            this.checkBoxChocolate.AutoSize = true;
            this.checkBoxChocolate.Location = new System.Drawing.Point(137, 132);
            this.checkBoxChocolate.Name = "checkBoxChocolate";
            this.checkBoxChocolate.Size = new System.Drawing.Size(88, 17);
            this.checkBoxChocolate.TabIndex = 6;
            this.checkBoxChocolate.Text = "Chocolate Sí";
            this.checkBoxChocolate.UseVisualStyleBackColor = true;
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(41, 9);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(184, 31);
            this.lblTitulo.TabIndex = 7;
            this.lblTitulo.Text = "Perfil Persona";
            // 
            // radioButtonWizard
            // 
            this.radioButtonWizard.AutoSize = true;
            this.radioButtonWizard.Checked = true;
            this.radioButtonWizard.Location = new System.Drawing.Point(8, 19);
            this.radioButtonWizard.Name = "radioButtonWizard";
            this.radioButtonWizard.Size = new System.Drawing.Size(58, 17);
            this.radioButtonWizard.TabIndex = 8;
            this.radioButtonWizard.TabStop = true;
            this.radioButtonWizard.Text = "Wizard";
            this.radioButtonWizard.UseVisualStyleBackColor = true;
            // 
            // radioButtonMuggle
            // 
            this.radioButtonMuggle.AutoSize = true;
            this.radioButtonMuggle.Location = new System.Drawing.Point(108, 19);
            this.radioButtonMuggle.Name = "radioButtonMuggle";
            this.radioButtonMuggle.Size = new System.Drawing.Size(60, 17);
            this.radioButtonMuggle.TabIndex = 9;
            this.radioButtonMuggle.Text = "Muggle";
            this.radioButtonMuggle.UseVisualStyleBackColor = true;
            // 
            // radioButtonSquibs
            // 
            this.radioButtonSquibs.AutoSize = true;
            this.radioButtonSquibs.Location = new System.Drawing.Point(204, 19);
            this.radioButtonSquibs.Name = "radioButtonSquibs";
            this.radioButtonSquibs.Size = new System.Drawing.Size(57, 17);
            this.radioButtonSquibs.TabIndex = 10;
            this.radioButtonSquibs.Text = "Squibs";
            this.radioButtonSquibs.UseVisualStyleBackColor = true;
            // 
            // groupBoxTipo
            // 
            this.groupBoxTipo.Controls.Add(this.radioButtonSquibs);
            this.groupBoxTipo.Controls.Add(this.radioButtonMuggle);
            this.groupBoxTipo.Controls.Add(this.radioButtonWizard);
            this.groupBoxTipo.Location = new System.Drawing.Point(130, 155);
            this.groupBoxTipo.Name = "groupBoxTipo";
            this.groupBoxTipo.Size = new System.Drawing.Size(280, 62);
            this.groupBoxTipo.TabIndex = 11;
            this.groupBoxTipo.TabStop = false;
            this.groupBoxTipo.Text = "Tipo";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(56, 241);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "Color Favorito:";
            // 
            // comboBoxColorFav
            // 
            this.comboBoxColorFav.FormattingEnabled = true;
            this.comboBoxColorFav.Location = new System.Drawing.Point(137, 238);
            this.comboBoxColorFav.Name = "comboBoxColorFav";
            this.comboBoxColorFav.Size = new System.Drawing.Size(201, 21);
            this.comboBoxColorFav.TabIndex = 13;
            // 
            // NumFav
            // 
            this.NumFav.Location = new System.Drawing.Point(137, 285);
            this.NumFav.Name = "NumFav";
            this.NumFav.Size = new System.Drawing.Size(201, 20);
            this.NumFav.TabIndex = 14;
            // 
            // lblNumFav
            // 
            this.lblNumFav.AutoSize = true;
            this.lblNumFav.Location = new System.Drawing.Point(44, 287);
            this.lblNumFav.Name = "lblNumFav";
            this.lblNumFav.Size = new System.Drawing.Size(88, 13);
            this.lblNumFav.TabIndex = 15;
            this.lblNumFav.Text = "Número Favorito:";
            // 
            // btnVerPerfil
            // 
            this.btnVerPerfil.Location = new System.Drawing.Point(186, 337);
            this.btnVerPerfil.Name = "btnVerPerfil";
            this.btnVerPerfil.Size = new System.Drawing.Size(75, 23);
            this.btnVerPerfil.TabIndex = 16;
            this.btnVerPerfil.Text = "Ver Perfil";
            this.btnVerPerfil.UseVisualStyleBackColor = true;
            this.btnVerPerfil.Click += new System.EventHandler(this.btnVerPerfil_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 550);
            this.Controls.Add(this.btnVerPerfil);
            this.Controls.Add(this.lblNumFav);
            this.Controls.Add(this.NumFav);
            this.Controls.Add(this.comboBoxColorFav);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBoxTipo);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.checkBoxChocolate);
            this.Controls.Add(this.dateTimePickerFechaNac);
            this.Controls.Add(this.lblFecha);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.listElementos);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.txtNombre);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBoxTipo.ResumeLayout(false);
            this.groupBoxTipo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NumFav)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.ListView listElementos;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.DateTimePicker dateTimePickerFechaNac;
        private System.Windows.Forms.CheckBox checkBoxChocolate;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.RadioButton radioButtonWizard;
        private System.Windows.Forms.RadioButton radioButtonMuggle;
        private System.Windows.Forms.RadioButton radioButtonSquibs;
        private System.Windows.Forms.GroupBox groupBoxTipo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxColorFav;
        private System.Windows.Forms.NumericUpDown NumFav;
        private System.Windows.Forms.Label lblNumFav;
        private System.Windows.Forms.Button btnVerPerfil;
    }
}

