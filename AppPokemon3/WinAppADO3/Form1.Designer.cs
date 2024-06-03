namespace WinAppADO3
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
            this.dgvPokemons = new System.Windows.Forms.DataGridView();
            this.pictureBoxPoke = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPokemons)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPoke)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvPokemons
            // 
            this.dgvPokemons.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPokemons.Location = new System.Drawing.Point(39, 70);
            this.dgvPokemons.Name = "dgvPokemons";
            this.dgvPokemons.Size = new System.Drawing.Size(492, 150);
            this.dgvPokemons.TabIndex = 0;
            this.dgvPokemons.SelectionChanged += new System.EventHandler(this.dgvPokemons_SelectionChanged);
            // 
            // pictureBoxPoke
            // 
            this.pictureBoxPoke.Location = new System.Drawing.Point(167, 236);
            this.pictureBoxPoke.Name = "pictureBoxPoke";
            this.pictureBoxPoke.Size = new System.Drawing.Size(245, 197);
            this.pictureBoxPoke.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxPoke.TabIndex = 1;
            this.pictureBoxPoke.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(572, 457);
            this.Controls.Add(this.pictureBoxPoke);
            this.Controls.Add(this.dgvPokemons);
            this.Name = "Form1";
            this.Text = "Pokemons";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPokemons)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPoke)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvPokemons;
        private System.Windows.Forms.PictureBox pictureBoxPoke;
    }
}

