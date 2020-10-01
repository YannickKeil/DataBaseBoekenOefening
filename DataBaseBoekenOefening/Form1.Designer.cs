namespace DataBaseBoekenOefening
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
            this.lbBoeken = new System.Windows.Forms.ListBox();
            this.lbGenres = new System.Windows.Forms.ListBox();
            this.Titel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lUitgever = new System.Windows.Forms.Label();
            this.lPublicatie = new System.Windows.Forms.Label();
            this.lScore = new System.Windows.Forms.Label();
            this.lAPaginas = new System.Windows.Forms.Label();
            this.lTitel = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.lbAuteurs = new System.Windows.Forms.ListBox();
            this.btnToevoegen = new System.Windows.Forms.Button();
            this.btnGenreToevoegen = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbBoeken
            // 
            this.lbBoeken.FormattingEnabled = true;
            this.lbBoeken.ItemHeight = 20;
            this.lbBoeken.Location = new System.Drawing.Point(24, 56);
            this.lbBoeken.Name = "lbBoeken";
            this.lbBoeken.Size = new System.Drawing.Size(982, 224);
            this.lbBoeken.TabIndex = 1;
            this.lbBoeken.SelectedIndexChanged += new System.EventHandler(this.lbBoeken_SelectedIndexChanged);
            // 
            // lbGenres
            // 
            this.lbGenres.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.lbGenres.Enabled = false;
            this.lbGenres.ForeColor = System.Drawing.SystemColors.WindowText;
            this.lbGenres.FormattingEnabled = true;
            this.lbGenres.ItemHeight = 20;
            this.lbGenres.Location = new System.Drawing.Point(761, 313);
            this.lbGenres.Name = "lbGenres";
            this.lbGenres.Size = new System.Drawing.Size(245, 324);
            this.lbGenres.TabIndex = 2;
            // 
            // Titel
            // 
            this.Titel.AutoSize = true;
            this.Titel.Location = new System.Drawing.Point(20, 313);
            this.Titel.Name = "Titel";
            this.Titel.Size = new System.Drawing.Size(38, 20);
            this.Titel.TabIndex = 3;
            this.Titel.Text = "Titel";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 360);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Aantal Pagina\'s";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 407);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Score";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(20, 451);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "Publicatie";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(20, 495);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 20);
            this.label5.TabIndex = 7;
            this.label5.Text = "Uitgever";
            // 
            // lUitgever
            // 
            this.lUitgever.AutoSize = true;
            this.lUitgever.Location = new System.Drawing.Point(167, 495);
            this.lUitgever.Name = "lUitgever";
            this.lUitgever.Size = new System.Drawing.Size(51, 20);
            this.lUitgever.TabIndex = 12;
            this.lUitgever.Text = "label6";
            // 
            // lPublicatie
            // 
            this.lPublicatie.AutoSize = true;
            this.lPublicatie.Location = new System.Drawing.Point(167, 451);
            this.lPublicatie.Name = "lPublicatie";
            this.lPublicatie.Size = new System.Drawing.Size(51, 20);
            this.lPublicatie.TabIndex = 11;
            this.lPublicatie.Text = "label7";
            // 
            // lScore
            // 
            this.lScore.AutoSize = true;
            this.lScore.Location = new System.Drawing.Point(167, 407);
            this.lScore.Name = "lScore";
            this.lScore.Size = new System.Drawing.Size(51, 20);
            this.lScore.TabIndex = 10;
            this.lScore.Text = "label8";
            // 
            // lAPaginas
            // 
            this.lAPaginas.AutoSize = true;
            this.lAPaginas.Location = new System.Drawing.Point(167, 361);
            this.lAPaginas.Name = "lAPaginas";
            this.lAPaginas.Size = new System.Drawing.Size(51, 20);
            this.lAPaginas.TabIndex = 9;
            this.lAPaginas.Text = "label9";
            // 
            // lTitel
            // 
            this.lTitel.AutoSize = true;
            this.lTitel.Location = new System.Drawing.Point(167, 313);
            this.lTitel.Name = "lTitel";
            this.lTitel.Size = new System.Drawing.Size(60, 20);
            this.lTitel.TabIndex = 8;
            this.lTitel.Text = "label10";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(695, 313);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(62, 20);
            this.label11.TabIndex = 13;
            this.label11.Text = "Genres";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(21, 21);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(62, 20);
            this.label12.TabIndex = 14;
            this.label12.Text = "boeken";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(20, 541);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(75, 20);
            this.label13.TabIndex = 15;
            this.label13.Text = "Auteur(s)";
            // 
            // lbAuteurs
            // 
            this.lbAuteurs.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.lbAuteurs.Enabled = false;
            this.lbAuteurs.FormattingEnabled = true;
            this.lbAuteurs.ItemHeight = 20;
            this.lbAuteurs.Location = new System.Drawing.Point(171, 541);
            this.lbAuteurs.Name = "lbAuteurs";
            this.lbAuteurs.Size = new System.Drawing.Size(202, 104);
            this.lbAuteurs.TabIndex = 17;
            this.lbAuteurs.SelectedIndexChanged += new System.EventHandler(this.lbAuteurs_SelectedIndexChanged);
            // 
            // btnToevoegen
            // 
            this.btnToevoegen.Location = new System.Drawing.Point(171, 709);
            this.btnToevoegen.Name = "btnToevoegen";
            this.btnToevoegen.Size = new System.Drawing.Size(195, 76);
            this.btnToevoegen.TabIndex = 18;
            this.btnToevoegen.Text = "Boek Toevoegen";
            this.btnToevoegen.UseVisualStyleBackColor = true;
            this.btnToevoegen.Click += new System.EventHandler(this.btnToevoegen_Click);
            // 
            // btnGenreToevoegen
            // 
            this.btnGenreToevoegen.Location = new System.Drawing.Point(761, 709);
            this.btnGenreToevoegen.Name = "btnGenreToevoegen";
            this.btnGenreToevoegen.Size = new System.Drawing.Size(195, 76);
            this.btnGenreToevoegen.TabIndex = 19;
            this.btnGenreToevoegen.Text = "Genre Toevoegen";
            this.btnGenreToevoegen.UseVisualStyleBackColor = true;
            this.btnGenreToevoegen.Click += new System.EventHandler(this.btnGenreToevoegen_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(400, 709);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(195, 76);
            this.button1.TabIndex = 20;
            this.button1.Text = "selected Boek Verwijderen";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1094, 892);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnGenreToevoegen);
            this.Controls.Add(this.btnToevoegen);
            this.Controls.Add(this.lbAuteurs);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.lUitgever);
            this.Controls.Add(this.lPublicatie);
            this.Controls.Add(this.lScore);
            this.Controls.Add(this.lAPaginas);
            this.Controls.Add(this.lTitel);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Titel);
            this.Controls.Add(this.lbGenres);
            this.Controls.Add(this.lbBoeken);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbBoeken;
        private System.Windows.Forms.ListBox lbGenres;
        private System.Windows.Forms.Label Titel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lUitgever;
        private System.Windows.Forms.Label lPublicatie;
        private System.Windows.Forms.Label lScore;
        private System.Windows.Forms.Label lAPaginas;
        private System.Windows.Forms.Label lTitel;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ListBox lbAuteurs;
        private System.Windows.Forms.Button btnToevoegen;
        private System.Windows.Forms.Button btnGenreToevoegen;
        private System.Windows.Forms.Button button1;
    }
}

