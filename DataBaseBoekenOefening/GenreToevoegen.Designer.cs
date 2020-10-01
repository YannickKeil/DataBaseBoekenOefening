namespace DataBaseBoekenOefening
{
    partial class GenreToevoegen
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
            this.tbGenre = new System.Windows.Forms.TextBox();
            this.lbGenres = new System.Windows.Forms.ListBox();
            this.btnGT = new System.Windows.Forms.Button();
            this.btnGV = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tbGenre
            // 
            this.tbGenre.Location = new System.Drawing.Point(50, 89);
            this.tbGenre.Name = "tbGenre";
            this.tbGenre.Size = new System.Drawing.Size(301, 26);
            this.tbGenre.TabIndex = 0;
            // 
            // lbGenres
            // 
            this.lbGenres.FormattingEnabled = true;
            this.lbGenres.ItemHeight = 20;
            this.lbGenres.Location = new System.Drawing.Point(395, 89);
            this.lbGenres.Name = "lbGenres";
            this.lbGenres.Size = new System.Drawing.Size(252, 304);
            this.lbGenres.TabIndex = 1;
            // 
            // btnGT
            // 
            this.btnGT.Location = new System.Drawing.Point(50, 141);
            this.btnGT.Name = "btnGT";
            this.btnGT.Size = new System.Drawing.Size(138, 68);
            this.btnGT.TabIndex = 2;
            this.btnGT.Text = "Genre toevoegen";
            this.btnGT.UseVisualStyleBackColor = true;
            this.btnGT.Click += new System.EventHandler(this.btnGT_Click);
            // 
            // btnGV
            // 
            this.btnGV.Location = new System.Drawing.Point(213, 141);
            this.btnGV.Name = "btnGV";
            this.btnGV.Size = new System.Drawing.Size(138, 68);
            this.btnGV.TabIndex = 3;
            this.btnGV.Text = "Genre Verwijderen";
            this.btnGV.UseVisualStyleBackColor = true;
            this.btnGV.Click += new System.EventHandler(this.btnGV_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(127, 343);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(138, 50);
            this.button4.TabIndex = 4;
            this.button4.Text = "Finish";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(50, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "toevoegen genre";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(391, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "alle genres";
            // 
            // GenreToevoegen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.btnGV);
            this.Controls.Add(this.btnGT);
            this.Controls.Add(this.lbGenres);
            this.Controls.Add(this.tbGenre);
            this.Name = "GenreToevoegen";
            this.Text = "GenreToevoegen";
            this.Load += new System.EventHandler(this.GenreToevoegen_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbGenre;
        private System.Windows.Forms.ListBox lbGenres;
        private System.Windows.Forms.Button btnGT;
        private System.Windows.Forms.Button btnGV;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}