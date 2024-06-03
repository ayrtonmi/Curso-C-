namespace PracticaAppWindowsI
{
    partial class frmInicial
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmInicial));
            this.btnOK = new System.Windows.Forms.Button();
            this.lblButton1 = new System.Windows.Forms.Label();
            this.txbCaja = new System.Windows.Forms.TextBox();
            this.txbCaja2 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnOK
            // 
            this.btnOK.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOK.Image = ((System.Drawing.Image)(resources.GetObject("btnOK.Image")));
            this.btnOK.Location = new System.Drawing.Point(311, 649);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(447, 73);
            this.btnOK.TabIndex = 0;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // lblButton1
            // 
            this.lblButton1.AutoSize = true;
            this.lblButton1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblButton1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblButton1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lblButton1.Location = new System.Drawing.Point(513, 622);
            this.lblButton1.Name = "lblButton1";
            this.lblButton1.Size = new System.Drawing.Size(78, 18);
            this.lblButton1.TabIndex = 1;
            this.lblButton1.Text = "Presione OK";
            this.lblButton1.MouseLeave += new System.EventHandler(this.lblButton1_MouseLeave);
            // 
            // txbCaja
            // 
            this.txbCaja.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txbCaja.Location = new System.Drawing.Point(340, 167);
            this.txbCaja.MaxLength = 20;
            this.txbCaja.Name = "txbCaja";
            this.txbCaja.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txbCaja.Size = new System.Drawing.Size(381, 20);
            this.txbCaja.TabIndex = 2;
            this.txbCaja.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txbCaja_KeyPress);
            // 
            // txbCaja2
            // 
            this.txbCaja2.Location = new System.Drawing.Point(491, 230);
            this.txbCaja2.Multiline = true;
            this.txbCaja2.Name = "txbCaja2";
            this.txbCaja2.Size = new System.Drawing.Size(119, 128);
            this.txbCaja2.TabIndex = 3;
            this.txbCaja2.Leave += new System.EventHandler(this.txbCaja2_Leave);
            // 
            // frmInicial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1087, 751);
            this.Controls.Add(this.txbCaja2);
            this.Controls.Add(this.txbCaja);
            this.Controls.Add(this.lblButton1);
            this.Controls.Add(this.btnOK);
            this.Enabled = false;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmInicial";
            this.Opacity = 0.9D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mi primer App";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmInicial_FormClosed);
            this.Load += new System.EventHandler(this.frmInicial_Load);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.frmInicial_MouseMove);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Label lblButton1;
        private System.Windows.Forms.TextBox txbCaja;
        private System.Windows.Forms.TextBox txbCaja2;
    }
}

