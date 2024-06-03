namespace AppPokemon2
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
            this.dgvPokemon = new System.Windows.Forms.DataGridView();
            this.pbPokemon = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPokemon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPokemon)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvPokemon
            // 
            this.dgvPokemon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPokemon.Location = new System.Drawing.Point(36, 60);
            this.dgvPokemon.Name = "dgvPokemon";
            this.dgvPokemon.Size = new System.Drawing.Size(472, 177);
            this.dgvPokemon.TabIndex = 0;
            this.dgvPokemon.SelectionChanged += new System.EventHandler(this.dgvPokemon_SelectionChanged);
            // 
            // pbPokemon
            // 
            this.pbPokemon.Location = new System.Drawing.Point(567, 60);
            this.pbPokemon.Name = "pbPokemon";
            this.pbPokemon.Size = new System.Drawing.Size(204, 177);
            this.pbPokemon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbPokemon.TabIndex = 1;
            this.pbPokemon.TabStop = false;
            this.pbPokemon.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pbPokemon);
            this.Controls.Add(this.dgvPokemon);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPokemon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPokemon)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvPokemon;
        private System.Windows.Forms.PictureBox pbPokemon;
    }
}

