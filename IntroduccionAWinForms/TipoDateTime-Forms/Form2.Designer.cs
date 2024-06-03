namespace TipoDateTime_Forms
{
    partial class Form2
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
            this.dtpFecha = new System.Windows.Forms.DateTimePicker();
            this.calFecha = new System.Windows.Forms.MonthCalendar();
            this.btnFechadtp = new System.Windows.Forms.Button();
            this.btnCalFecha = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // dtpFecha
            // 
            this.dtpFecha.Location = new System.Drawing.Point(225, 121);
            this.dtpFecha.Name = "dtpFecha";
            this.dtpFecha.Size = new System.Drawing.Size(192, 20);
            this.dtpFecha.TabIndex = 0;
            // 
            // calFecha
            // 
            this.calFecha.Location = new System.Drawing.Point(225, 226);
            this.calFecha.Name = "calFecha";
            this.calFecha.TabIndex = 1;
            // 
            // btnFechadtp
            // 
            this.btnFechadtp.Location = new System.Drawing.Point(528, 121);
            this.btnFechadtp.Name = "btnFechadtp";
            this.btnFechadtp.Size = new System.Drawing.Size(75, 23);
            this.btnFechadtp.TabIndex = 2;
            this.btnFechadtp.Text = "Prueba 1";
            this.btnFechadtp.UseVisualStyleBackColor = true;
            this.btnFechadtp.Click += new System.EventHandler(this.btnFechadtp_Click);
            // 
            // btnCalFecha
            // 
            this.btnCalFecha.Location = new System.Drawing.Point(528, 226);
            this.btnCalFecha.Name = "btnCalFecha";
            this.btnCalFecha.Size = new System.Drawing.Size(75, 23);
            this.btnCalFecha.TabIndex = 3;
            this.btnCalFecha.Text = "Prueba 2";
            this.btnCalFecha.UseVisualStyleBackColor = true;
            this.btnCalFecha.Click += new System.EventHandler(this.btnCalFecha_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnCalFecha);
            this.Controls.Add(this.btnFechadtp);
            this.Controls.Add(this.calFecha);
            this.Controls.Add(this.dtpFecha);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dtpFecha;
        private System.Windows.Forms.MonthCalendar calFecha;
        private System.Windows.Forms.Button btnFechadtp;
        private System.Windows.Forms.Button btnCalFecha;
    }
}