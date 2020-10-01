namespace DataBaseBoekenOefening
{
    partial class Toevoegen
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.tbTitel = new System.Windows.Forms.TextBox();
            this.nudAPaginas = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.nudScore = new System.Windows.Forms.NumericUpDown();
            this.dtPublicatie = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.cbUitgever = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.lbAllGenres = new System.Windows.Forms.ListBox();
            this.lbGenresToevoegen = new System.Windows.Forms.ListBox();
            this.btnNaarRechts = new System.Windows.Forms.Button();
            this.btnNaarLinks = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.cbAuteursVoornamen = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cbAuteursAchternamen = new System.Windows.Forms.ComboBox();
            this.lbAutVNBoek = new System.Windows.Forms.ListBox();
            this.btnVerwijderAuteur = new System.Windows.Forms.Button();
            this.btnToevoegenAuteur = new System.Windows.Forms.Button();
            this.lbAutANBoek = new System.Windows.Forms.ListBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.btnToevoegenDB = new System.Windows.Forms.Button();
            this.epErrors = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.nudAPaginas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudScore)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.epErrors)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(99, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Titel";
            // 
            // tbTitel
            // 
            this.tbTitel.Location = new System.Drawing.Point(103, 86);
            this.tbTitel.Name = "tbTitel";
            this.tbTitel.Size = new System.Drawing.Size(331, 26);
            this.tbTitel.TabIndex = 1;
            // 
            // nudAPaginas
            // 
            this.nudAPaginas.Location = new System.Drawing.Point(103, 165);
            this.nudAPaginas.Name = "nudAPaginas";
            this.nudAPaginas.Size = new System.Drawing.Size(120, 26);
            this.nudAPaginas.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(99, 126);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Aantal Paginas";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(99, 221);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Score";
            // 
            // nudScore
            // 
            this.nudScore.Location = new System.Drawing.Point(103, 260);
            this.nudScore.Name = "nudScore";
            this.nudScore.Size = new System.Drawing.Size(120, 26);
            this.nudScore.TabIndex = 4;
            // 
            // dtPublicatie
            // 
            this.dtPublicatie.Location = new System.Drawing.Point(103, 361);
            this.dtPublicatie.Name = "dtPublicatie";
            this.dtPublicatie.Size = new System.Drawing.Size(200, 26);
            this.dtPublicatie.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(99, 327);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 20);
            this.label4.TabIndex = 7;
            this.label4.Text = "Publicatie";
            // 
            // cbUitgever
            // 
            this.cbUitgever.FormattingEnabled = true;
            this.cbUitgever.Location = new System.Drawing.Point(102, 460);
            this.cbUitgever.Name = "cbUitgever";
            this.cbUitgever.Size = new System.Drawing.Size(253, 28);
            this.cbUitgever.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(99, 424);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 20);
            this.label5.TabIndex = 9;
            this.label5.Text = "uitgever";
            // 
            // lbAllGenres
            // 
            this.lbAllGenres.FormattingEnabled = true;
            this.lbAllGenres.ItemHeight = 20;
            this.lbAllGenres.Location = new System.Drawing.Point(558, 86);
            this.lbAllGenres.Name = "lbAllGenres";
            this.lbAllGenres.Size = new System.Drawing.Size(254, 384);
            this.lbAllGenres.TabIndex = 10;
            // 
            // lbGenresToevoegen
            // 
            this.lbGenresToevoegen.FormattingEnabled = true;
            this.lbGenresToevoegen.ItemHeight = 20;
            this.lbGenresToevoegen.Location = new System.Drawing.Point(935, 86);
            this.lbGenresToevoegen.Name = "lbGenresToevoegen";
            this.lbGenresToevoegen.Size = new System.Drawing.Size(254, 384);
            this.lbGenresToevoegen.TabIndex = 11;
            // 
            // btnNaarRechts
            // 
            this.btnNaarRechts.Location = new System.Drawing.Point(841, 193);
            this.btnNaarRechts.Name = "btnNaarRechts";
            this.btnNaarRechts.Size = new System.Drawing.Size(61, 48);
            this.btnNaarRechts.TabIndex = 12;
            this.btnNaarRechts.Text = "=>";
            this.btnNaarRechts.UseVisualStyleBackColor = true;
            this.btnNaarRechts.Click += new System.EventHandler(this.btnNaarRechts_Click);
            // 
            // btnNaarLinks
            // 
            this.btnNaarLinks.Location = new System.Drawing.Point(841, 299);
            this.btnNaarLinks.Name = "btnNaarLinks";
            this.btnNaarLinks.Size = new System.Drawing.Size(61, 48);
            this.btnNaarLinks.TabIndex = 13;
            this.btnNaarLinks.Text = "<=";
            this.btnNaarLinks.UseVisualStyleBackColor = true;
            this.btnNaarLinks.Click += new System.EventHandler(this.btnNaarLinks_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(100, 514);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(143, 20);
            this.label6.TabIndex = 15;
            this.label6.Text = "Auteurs Voornaam";
            // 
            // cbAuteursVoornamen
            // 
            this.cbAuteursVoornamen.FormattingEnabled = true;
            this.cbAuteursVoornamen.Location = new System.Drawing.Point(103, 550);
            this.cbAuteursVoornamen.Name = "cbAuteursVoornamen";
            this.cbAuteursVoornamen.Size = new System.Drawing.Size(252, 28);
            this.cbAuteursVoornamen.TabIndex = 14;
            this.cbAuteursVoornamen.SelectedIndexChanged += new System.EventHandler(this.cbAuteursVoornamen_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(100, 597);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(156, 20);
            this.label7.TabIndex = 17;
            this.label7.Text = "Auteurs Achternaam";
            // 
            // cbAuteursAchternamen
            // 
            this.cbAuteursAchternamen.FormattingEnabled = true;
            this.cbAuteursAchternamen.Location = new System.Drawing.Point(101, 633);
            this.cbAuteursAchternamen.Name = "cbAuteursAchternamen";
            this.cbAuteursAchternamen.Size = new System.Drawing.Size(254, 28);
            this.cbAuteursAchternamen.TabIndex = 16;
            this.cbAuteursAchternamen.SelectedIndexChanged += new System.EventHandler(this.cbAuteursAchternamen_SelectedIndexChanged);
            // 
            // lbAutVNBoek
            // 
            this.lbAutVNBoek.FormattingEnabled = true;
            this.lbAutVNBoek.ItemHeight = 20;
            this.lbAutVNBoek.Location = new System.Drawing.Point(558, 557);
            this.lbAutVNBoek.Name = "lbAutVNBoek";
            this.lbAutVNBoek.Size = new System.Drawing.Size(254, 104);
            this.lbAutVNBoek.TabIndex = 18;
            this.lbAutVNBoek.SelectedIndexChanged += new System.EventHandler(this.lbAutVNBoek_SelectedIndexChanged);
            // 
            // btnVerwijderAuteur
            // 
            this.btnVerwijderAuteur.Location = new System.Drawing.Point(423, 613);
            this.btnVerwijderAuteur.Name = "btnVerwijderAuteur";
            this.btnVerwijderAuteur.Size = new System.Drawing.Size(61, 48);
            this.btnVerwijderAuteur.TabIndex = 20;
            this.btnVerwijderAuteur.Text = "<=";
            this.btnVerwijderAuteur.UseVisualStyleBackColor = true;
            this.btnVerwijderAuteur.Click += new System.EventHandler(this.btnVerwijderAuteur_Click);
            // 
            // btnToevoegenAuteur
            // 
            this.btnToevoegenAuteur.Location = new System.Drawing.Point(423, 557);
            this.btnToevoegenAuteur.Name = "btnToevoegenAuteur";
            this.btnToevoegenAuteur.Size = new System.Drawing.Size(61, 48);
            this.btnToevoegenAuteur.TabIndex = 19;
            this.btnToevoegenAuteur.Text = "=>";
            this.btnToevoegenAuteur.UseVisualStyleBackColor = true;
            this.btnToevoegenAuteur.Click += new System.EventHandler(this.btnToevoegenAuteur_Click);
            // 
            // lbAutANBoek
            // 
            this.lbAutANBoek.FormattingEnabled = true;
            this.lbAutANBoek.ItemHeight = 20;
            this.lbAutANBoek.Location = new System.Drawing.Point(935, 557);
            this.lbAutANBoek.Name = "lbAutANBoek";
            this.lbAutANBoek.Size = new System.Drawing.Size(254, 104);
            this.lbAutANBoek.TabIndex = 21;
            this.lbAutANBoek.SelectedIndexChanged += new System.EventHandler(this.lbAutANBoek_SelectedIndexChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(554, 514);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(192, 20);
            this.label8.TabIndex = 22;
            this.label8.Text = "Auteur(s) Voornaam boek";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(931, 514);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(205, 20);
            this.label9.TabIndex = 23;
            this.label9.Text = "Auteur(s) Achternaam boek";
            // 
            // btnToevoegenDB
            // 
            this.btnToevoegenDB.Location = new System.Drawing.Point(1339, 273);
            this.btnToevoegenDB.Name = "btnToevoegenDB";
            this.btnToevoegenDB.Size = new System.Drawing.Size(129, 74);
            this.btnToevoegenDB.TabIndex = 24;
            this.btnToevoegenDB.Text = "boek toevoegen database";
            this.btnToevoegenDB.UseVisualStyleBackColor = true;
            this.btnToevoegenDB.Click += new System.EventHandler(this.btnToevoegenDB_Click);
            // 
            // epErrors
            // 
            this.epErrors.ContainerControl = this;
            // 
            // Toevoegen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1536, 692);
            this.Controls.Add(this.btnToevoegenDB);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.lbAutANBoek);
            this.Controls.Add(this.btnVerwijderAuteur);
            this.Controls.Add(this.btnToevoegenAuteur);
            this.Controls.Add(this.lbAutVNBoek);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.cbAuteursAchternamen);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cbAuteursVoornamen);
            this.Controls.Add(this.btnNaarLinks);
            this.Controls.Add(this.btnNaarRechts);
            this.Controls.Add(this.lbGenresToevoegen);
            this.Controls.Add(this.lbAllGenres);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cbUitgever);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dtPublicatie);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.nudScore);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.nudAPaginas);
            this.Controls.Add(this.tbTitel);
            this.Controls.Add(this.label1);
            this.Name = "Toevoegen";
            this.Text = "Toevoegen";
            this.Load += new System.EventHandler(this.Toevoegen_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudAPaginas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudScore)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.epErrors)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbTitel;
        private System.Windows.Forms.NumericUpDown nudAPaginas;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown nudScore;
        private System.Windows.Forms.DateTimePicker dtPublicatie;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbUitgever;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ListBox lbAllGenres;
        private System.Windows.Forms.ListBox lbGenresToevoegen;
        private System.Windows.Forms.Button btnNaarRechts;
        private System.Windows.Forms.Button btnNaarLinks;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cbAuteursVoornamen;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cbAuteursAchternamen;
        private System.Windows.Forms.ListBox lbAutVNBoek;
        private System.Windows.Forms.Button btnVerwijderAuteur;
        private System.Windows.Forms.Button btnToevoegenAuteur;
        private System.Windows.Forms.ListBox lbAutANBoek;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnToevoegenDB;
        private System.Windows.Forms.ErrorProvider epErrors;
    }
}