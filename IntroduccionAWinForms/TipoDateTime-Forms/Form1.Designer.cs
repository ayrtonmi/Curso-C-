namespace TipoDateTime_Forms
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
            this.dtpFecha = new System.Windows.Forms.DateTimePicker();
            this.calFecha = new System.Windows.Forms.MonthCalendar();
            this.btnFecha1 = new System.Windows.Forms.Button();
            this.btnFecha2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // dtpFecha
            // 
            this.dtpFecha.Location = new System.Drawing.Point(229, 101);
            this.dtpFecha.Name = "dtpFecha";
            this.dtpFecha.Size = new System.Drawing.Size(200, 20);
            this.dtpFecha.TabIndex = 0;
            // 
            // calFecha
            // 
            this.calFecha.Location = new System.Drawing.Point(229, 174);
            this.calFecha.Name = "calFecha";
            this.calFecha.TabIndex = 1;
            // 
            // btnFecha1
            // 
            this.btnFecha1.Location = new System.Drawing.Point(488, 97);
            this.btnFecha1.Name = "btnFecha1";
            this.btnFecha1.Size = new System.Drawing.Size(75, 23);
            this.btnFecha1.TabIndex = 2;
            this.btnFecha1.Text = "Prueba 1";
            this.btnFecha1.UseVisualStyleBackColor = true;
            this.btnFecha1.Click += new System.EventHandler(this.btnFecha1_Click);
            // 
            // btnFecha2
            // 
            this.btnFecha2.Location = new System.Drawing.Point(488, 174);
            this.btnFecha2.Name = "btnFecha2";
            this.btnFecha2.Size = new System.Drawing.Size(75, 23);
            this.btnFecha2.TabIndex = 3;
            this.btnFecha2.Text = "Prueba 2";
            this.btnFecha2.UseVisualStyleBackColor = true;
            this.btnFecha2.Click += new System.EventHandler(this.btnFecha2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnFecha2);
            this.Controls.Add(this.btnFecha1);
            this.Controls.Add(this.calFecha);
            this.Controls.Add(this.dtpFecha);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dtpFecha;
        private System.Windows.Forms.MonthCalendar calFecha;
        private System.Windows.Forms.Button btnFecha1;
        private System.Windows.Forms.Button btnFecha2;
    }
}

