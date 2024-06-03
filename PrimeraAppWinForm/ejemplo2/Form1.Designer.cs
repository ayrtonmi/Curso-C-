namespace ejemplo2
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
            this.btnAgregar = new System.Windows.Forms.Button();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.listViewElementos = new System.Windows.Forms.ListView();
            this.labelNombre = new System.Windows.Forms.Label();
            this.labelFecha = new System.Windows.Forms.Label();
            this.dateTimePickerNacimiento = new System.Windows.Forms.DateTimePicker();
            this.checkBoxChocolate = new System.Windows.Forms.CheckBox();
            this.labelTitulo = new System.Windows.Forms.Label();
            this.radioButtonNegro = new System.Windows.Forms.RadioButton();
            this.radioButtonBlanco = new System.Windows.Forms.RadioButton();
            this.radioButtonAmargo = new System.Windows.Forms.RadioButton();
            this.groupBoxTipo = new System.Windows.Forms.GroupBox();
            this.labelColor = new System.Windows.Forms.Label();
            this.comboBoxColorFav = new System.Windows.Forms.ComboBox();
            this.labelNumFav = new System.Windows.Forms.Label();
            this.numericUpDownFav = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonVerPerfil = new System.Windows.Forms.Button();
            this.groupBoxTipo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownFav)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(661, 385);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(75, 23);
            this.btnAgregar.TabIndex = 0;
            this.btnAgregar.Text = "Agragar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(128, 101);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(200, 20);
            this.txtNombre.TabIndex = 1;
            // 
            // listViewElementos
            // 
            this.listViewElementos.HideSelection = false;
            this.listViewElementos.Location = new System.Drawing.Point(621, 101);
            this.listViewElementos.Name = "listViewElementos";
            this.listViewElementos.Size = new System.Drawing.Size(115, 278);
            this.listViewElementos.TabIndex = 2;
            this.listViewElementos.UseCompatibleStateImageBehavior = false;
            this.listViewElementos.View = System.Windows.Forms.View.List;
            // 
            // labelNombre
            // 
            this.labelNombre.AutoSize = true;
            this.labelNombre.Location = new System.Drawing.Point(53, 104);
            this.labelNombre.Name = "labelNombre";
            this.labelNombre.Size = new System.Drawing.Size(47, 13);
            this.labelNombre.TabIndex = 3;
            this.labelNombre.Text = "Nombre:";
            // 
            // labelFecha
            // 
            this.labelFecha.AutoSize = true;
            this.labelFecha.Location = new System.Drawing.Point(12, 139);
            this.labelFecha.Name = "labelFecha";
            this.labelFecha.Size = new System.Drawing.Size(112, 13);
            this.labelFecha.TabIndex = 4;
            this.labelFecha.Text = "Fecha de nacimiento: ";
            // 
            // dateTimePickerNacimiento
            // 
            this.dateTimePickerNacimiento.Location = new System.Drawing.Point(128, 133);
            this.dateTimePickerNacimiento.Name = "dateTimePickerNacimiento";
            this.dateTimePickerNacimiento.Size = new System.Drawing.Size(200, 20);
            this.dateTimePickerNacimiento.TabIndex = 5;
            // 
            // checkBoxChocolate
            // 
            this.checkBoxChocolate.AutoSize = true;
            this.checkBoxChocolate.Location = new System.Drawing.Point(128, 172);
            this.checkBoxChocolate.Name = "checkBoxChocolate";
            this.checkBoxChocolate.Size = new System.Drawing.Size(141, 17);
            this.checkBoxChocolate.TabIndex = 6;
            this.checkBoxChocolate.Text = "¿Te gusta el chocolate?";
            this.checkBoxChocolate.UseVisualStyleBackColor = true;
            // 
            // labelTitulo
            // 
            this.labelTitulo.AutoSize = true;
            this.labelTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitulo.Location = new System.Drawing.Point(52, 35);
            this.labelTitulo.Name = "labelTitulo";
            this.labelTitulo.Size = new System.Drawing.Size(126, 24);
            this.labelTitulo.TabIndex = 7;
            this.labelTitulo.Text = "Perfil Persona";
            this.labelTitulo.Click += new System.EventHandler(this.label1_Click);
            // 
            // radioButtonNegro
            // 
            this.radioButtonNegro.AutoSize = true;
            this.radioButtonNegro.Checked = true;
            this.radioButtonNegro.Location = new System.Drawing.Point(29, 45);
            this.radioButtonNegro.Name = "radioButtonNegro";
            this.radioButtonNegro.Size = new System.Drawing.Size(105, 17);
            this.radioButtonNegro.TabIndex = 8;
            this.radioButtonNegro.TabStop = true;
            this.radioButtonNegro.Text = "Chocolate Negro";
            this.radioButtonNegro.UseVisualStyleBackColor = true;
            // 
            // radioButtonBlanco
            // 
            this.radioButtonBlanco.AutoSize = true;
            this.radioButtonBlanco.Location = new System.Drawing.Point(140, 45);
            this.radioButtonBlanco.Name = "radioButtonBlanco";
            this.radioButtonBlanco.Size = new System.Drawing.Size(109, 17);
            this.radioButtonBlanco.TabIndex = 9;
            this.radioButtonBlanco.Text = "Chocolate Blanco";
            this.radioButtonBlanco.UseVisualStyleBackColor = true;
            this.radioButtonBlanco.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // radioButtonAmargo
            // 
            this.radioButtonAmargo.AutoSize = true;
            this.radioButtonAmargo.Location = new System.Drawing.Point(255, 45);
            this.radioButtonAmargo.Name = "radioButtonAmargo";
            this.radioButtonAmargo.Size = new System.Drawing.Size(57, 17);
            this.radioButtonAmargo.TabIndex = 10;
            this.radioButtonAmargo.Text = "Ambos";
            this.radioButtonAmargo.UseVisualStyleBackColor = true;
            // 
            // groupBoxTipo
            // 
            this.groupBoxTipo.Controls.Add(this.radioButtonAmargo);
            this.groupBoxTipo.Controls.Add(this.radioButtonNegro);
            this.groupBoxTipo.Controls.Add(this.radioButtonBlanco);
            this.groupBoxTipo.Location = new System.Drawing.Point(27, 195);
            this.groupBoxTipo.Name = "groupBoxTipo";
            this.groupBoxTipo.Size = new System.Drawing.Size(380, 100);
            this.groupBoxTipo.TabIndex = 11;
            this.groupBoxTipo.TabStop = false;
            this.groupBoxTipo.Text = "Tipo";
            // 
            // labelColor
            // 
            this.labelColor.AutoSize = true;
            this.labelColor.Location = new System.Drawing.Point(53, 337);
            this.labelColor.Name = "labelColor";
            this.labelColor.Size = new System.Drawing.Size(72, 13);
            this.labelColor.TabIndex = 12;
            this.labelColor.Text = "Color favorito:";
            // 
            // comboBoxColorFav
            // 
            this.comboBoxColorFav.FormattingEnabled = true;
            this.comboBoxColorFav.Location = new System.Drawing.Point(128, 334);
            this.comboBoxColorFav.Name = "comboBoxColorFav";
            this.comboBoxColorFav.Size = new System.Drawing.Size(200, 21);
            this.comboBoxColorFav.TabIndex = 13;
            this.comboBoxColorFav.SelectedIndexChanged += new System.EventHandler(this.comboBoxColorFav_SelectedIndexChanged);
            // 
            // labelNumFav
            // 
            this.labelNumFav.AutoSize = true;
            this.labelNumFav.Location = new System.Drawing.Point(37, 366);
            this.labelNumFav.Name = "labelNumFav";
            this.labelNumFav.Size = new System.Drawing.Size(88, 13);
            this.labelNumFav.TabIndex = 14;
            this.labelNumFav.Text = "Numero Favorito:";
            this.labelNumFav.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // numericUpDownFav
            // 
            this.numericUpDownFav.Location = new System.Drawing.Point(128, 366);
            this.numericUpDownFav.Name = "numericUpDownFav";
            this.numericUpDownFav.Size = new System.Drawing.Size(200, 20);
            this.numericUpDownFav.TabIndex = 15;
            this.numericUpDownFav.ValueChanged += new System.EventHandler(this.numericUpDownFav_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 16;
            this.label1.Text = "label1";
            // 
            // buttonVerPerfil
            // 
            this.buttonVerPerfil.Location = new System.Drawing.Point(128, 412);
            this.buttonVerPerfil.Name = "buttonVerPerfil";
            this.buttonVerPerfil.Size = new System.Drawing.Size(75, 23);
            this.buttonVerPerfil.TabIndex = 17;
            this.buttonVerPerfil.Text = "Ver perfil";
            this.buttonVerPerfil.UseVisualStyleBackColor = true;
            this.buttonVerPerfil.Click += new System.EventHandler(this.buttonVerPerfil_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(835, 549);
            this.Controls.Add(this.buttonVerPerfil);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.numericUpDownFav);
            this.Controls.Add(this.labelNumFav);
            this.Controls.Add(this.comboBoxColorFav);
            this.Controls.Add(this.labelColor);
            this.Controls.Add(this.groupBoxTipo);
            this.Controls.Add(this.labelTitulo);
            this.Controls.Add(this.checkBoxChocolate);
            this.Controls.Add(this.dateTimePickerNacimiento);
            this.Controls.Add(this.labelFecha);
            this.Controls.Add(this.labelNombre);
            this.Controls.Add(this.listViewElementos);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.btnAgregar);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBoxTipo.ResumeLayout(false);
            this.groupBoxTipo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownFav)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.ListView listViewElementos;
        private System.Windows.Forms.Label labelNombre;
        private System.Windows.Forms.Label labelFecha;
        private System.Windows.Forms.DateTimePicker dateTimePickerNacimiento;
        private System.Windows.Forms.CheckBox checkBoxChocolate;
        private System.Windows.Forms.Label labelTitulo;
        private System.Windows.Forms.RadioButton radioButtonNegro;
        private System.Windows.Forms.RadioButton radioButtonBlanco;
        private System.Windows.Forms.RadioButton radioButtonAmargo;
        private System.Windows.Forms.GroupBox groupBoxTipo;
        private System.Windows.Forms.Label labelColor;
        private System.Windows.Forms.ComboBox comboBoxColorFav;
        private System.Windows.Forms.Label labelNumFav;
        private System.Windows.Forms.NumericUpDown numericUpDownFav;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonVerPerfil;
    }
}

