namespace PokeApiFront.View
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.label1 = new System.Windows.Forms.Label();
            this.cbPokemonName1 = new System.Windows.Forms.ComboBox();
            this.cbPokemonName2 = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cbPokemonCard1 = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cbPokemonCard2 = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.pbPokemonCard1 = new System.Windows.Forms.PictureBox();
            this.pbPokemonCard2 = new System.Windows.Forms.PictureBox();
            this.bComparar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbPokemonCard1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPokemonCard2)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Location = new System.Drawing.Point(48, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre Pokemon:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cbPokemonName1
            // 
            this.cbPokemonName1.FormattingEnabled = true;
            this.cbPokemonName1.Location = new System.Drawing.Point(165, 24);
            this.cbPokemonName1.Name = "cbPokemonName1";
            this.cbPokemonName1.Size = new System.Drawing.Size(121, 21);
            this.cbPokemonName1.TabIndex = 1;
            // 
            // cbPokemonName2
            // 
            this.cbPokemonName2.FormattingEnabled = true;
            this.cbPokemonName2.Location = new System.Drawing.Point(763, 21);
            this.cbPokemonName2.Name = "cbPokemonName2";
            this.cbPokemonName2.Size = new System.Drawing.Size(121, 21);
            this.cbPokemonName2.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label2.Location = new System.Drawing.Point(647, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nombre Pokemon:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cbPokemonCard1
            // 
            this.cbPokemonCard1.FormattingEnabled = true;
            this.cbPokemonCard1.Location = new System.Drawing.Point(165, 64);
            this.cbPokemonCard1.Name = "cbPokemonCard1";
            this.cbPokemonCard1.Size = new System.Drawing.Size(121, 21);
            this.cbPokemonCard1.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label3.Location = new System.Drawing.Point(48, 68);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(105, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Cartas del Pokemon:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cbPokemonCard2
            // 
            this.cbPokemonCard2.FormattingEnabled = true;
            this.cbPokemonCard2.Location = new System.Drawing.Point(763, 61);
            this.cbPokemonCard2.Name = "cbPokemonCard2";
            this.cbPokemonCard2.Size = new System.Drawing.Size(121, 21);
            this.cbPokemonCard2.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label4.Location = new System.Drawing.Point(647, 65);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(105, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Cartas del Pokemon:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pbPokemonCard1
            // 
            this.pbPokemonCard1.BackColor = System.Drawing.Color.Transparent;
            this.pbPokemonCard1.Location = new System.Drawing.Point(34, 147);
            this.pbPokemonCard1.Name = "pbPokemonCard1";
            this.pbPokemonCard1.Size = new System.Drawing.Size(266, 345);
            this.pbPokemonCard1.TabIndex = 8;
            this.pbPokemonCard1.TabStop = false;
            // 
            // pbPokemonCard2
            // 
            this.pbPokemonCard2.BackColor = System.Drawing.Color.Transparent;
            this.pbPokemonCard2.Location = new System.Drawing.Point(632, 147);
            this.pbPokemonCard2.Name = "pbPokemonCard2";
            this.pbPokemonCard2.Size = new System.Drawing.Size(266, 345);
            this.pbPokemonCard2.TabIndex = 9;
            this.pbPokemonCard2.TabStop = false;
            this.pbPokemonCard2.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // bComparar
            // 
            this.bComparar.Location = new System.Drawing.Point(422, 55);
            this.bComparar.Name = "bComparar";
            this.bComparar.Size = new System.Drawing.Size(97, 39);
            this.bComparar.TabIndex = 10;
            this.bComparar.Text = "Comparar Pokemons";
            this.bComparar.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(949, 553);
            this.Controls.Add(this.bComparar);
            this.Controls.Add(this.pbPokemonCard2);
            this.Controls.Add(this.pbPokemonCard1);
            this.Controls.Add(this.cbPokemonCard2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cbPokemonCard1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cbPokemonName2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbPokemonName1);
            this.Controls.Add(this.label1);
            this.Name = "MainForm";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pbPokemonCard1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPokemonCard2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.ComboBox cbPokemonName1;
        public System.Windows.Forms.ComboBox cbPokemonName2;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.ComboBox cbPokemonCard1;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.ComboBox cbPokemonCard2;
        private System.Windows.Forms.Label label4;
        public System.Windows.Forms.PictureBox pbPokemonCard1;
        public System.Windows.Forms.PictureBox pbPokemonCard2;
        public System.Windows.Forms.Button bComparar;
    }
}