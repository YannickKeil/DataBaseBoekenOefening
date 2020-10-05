using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataBaseBoekenOefening
{
    public partial class Toevoegen : Form
    {
        public Toevoegen()
        {
            InitializeComponent();
        }
        public Boeken Selected;
        public Toevoegen(Boeken selected)
        {
            InitializeComponent();
            Selected = selected;
        }
        public List<string> AuteursVoornamen = new List<string>();
        public List<string> AuteursAchternamen = new List<string>();
        public List<int> GekozenAuteursIds = new List<int>();
        public List<string> GekozenGenres = new List<string>();
        public List<int> GekozenGenresId = new List<int>();
        public List<int> VerwijderGenreIds = new List<int>();
        public List<int> VerwijderAuteurIds = new List<int>();

        private void Toevoegen_Load(object sender, EventArgs e)
        {
            using (Database_BoekenEntities ctx = new Database_BoekenEntities())
            {
                var genres = ctx.Genres.Select(x => x).ToList();
                var autVoornamen = ctx.Auteurs.Select(x => x).ToList();
                var autAchternamen = ctx.Auteurs.Select(x => x.Achternaam).ToList();
                var uitgevers = ctx.Uitgeverijens.Select(x => x.Naam).ToList();
                lbAllGenres.DisplayMember = "Genre1";
                lbAllGenres.ValueMember = "Id";
                lbAllGenres.DataSource = genres;              
                cbUitgever.DataSource = uitgevers;
                cbAuteursVoornamen.DisplayMember = "Voornaam";
                cbAuteursVoornamen.ValueMember = "Id";
                cbAuteursVoornamen.DataSource = autVoornamen;
                cbAuteursAchternamen.DataSource = autAchternamen;
                lbAllGenres.SelectedIndex = 0;
                cbUitgever.SelectedIndex = 0;
                cbAuteursVoornamen.SelectedIndex = -1;
                cbAuteursAchternamen.SelectedIndex = -1;
                if(Selected == null)
                {
                    btnToevoegenDB.Text = "boek toevoegen database";
                }
                else
                {
                    btnToevoegenDB.Text = "boek Bijwerken in database";
                    tbTitel.Text = Selected.Titel;
                    nudAPaginas.Value = (decimal)Selected.AantalPaginas;
                    nudScore.Value = (decimal)Selected.Score;
                    dtPublicatie.Value = (DateTime)Selected.Publicatie;              
                    cbUitgever.SelectedItem = ctx.Uitgeverijens.Where(x => x.Id == Selected.UitgeverId).Select(x => x.Naam).FirstOrDefault();
                    var AuteursIds = ctx.BoekenAuteurs.Where(x => x.BoekId == Selected.Id).Select(x => x.AuteurId);
                    foreach (var auteurId in AuteursIds)
                    {
                        var auteurNaam = ctx.Auteurs.Where(a => a.Id == auteurId).FirstOrDefault();
                        AuteursVoornamen.Add(auteurNaam.Voornaam);
                        AuteursAchternamen.Add(auteurNaam.Achternaam);
                        GekozenAuteursIds.Add(auteurNaam.Id);
                    }
                    LoadListBoxAuteurs();
                    var genreIds = ctx.BoekenGenres.Where(bg => bg.BoekId == Selected.Id).Select(bg => bg.GenreId);
                    foreach (var genreId in genreIds)
                    {
                        GekozenGenres.Add(ctx.Genres.Where(g => g.Id == genreId).Select(g => g.Genre1).FirstOrDefault());
                        GekozenGenresId.Add((int)genreId);
                    }
                    LoadListBoxGenres();
                }

            }
        }

        private void cbAuteursVoornamen_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbAuteursVoornamen.DataSource != null && cbAuteursAchternamen.DataSource != null)
                cbAuteursAchternamen.SelectedIndex = cbAuteursVoornamen.SelectedIndex;
            
        }

        private void cbAuteursAchternamen_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbAuteursVoornamen.DataSource != null && cbAuteursAchternamen.DataSource != null)
                cbAuteursVoornamen.SelectedIndex = cbAuteursAchternamen.SelectedIndex;
        }

        private void lbAutVNBoek_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lbAutVNBoek.DataSource != null && lbAutANBoek.DataSource != null)
                lbAutANBoek.SelectedIndex = lbAutVNBoek.SelectedIndex;
        }

        private void lbAutANBoek_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lbAutVNBoek.DataSource != null && lbAutANBoek.DataSource != null)
                lbAutVNBoek.SelectedIndex = lbAutANBoek.SelectedIndex;
        }

        private void btnToevoegenAuteur_Click(object sender, EventArgs e)
        {
            if(cbAuteursVoornamen.Text == "")
            {
                epErrors.SetError(cbAuteursVoornamen, "Geen tekst ingevuld!");
            }
            else if (cbAuteursAchternamen.Text == "")
            {
                epErrors.SetError(cbAuteursAchternamen, "Geen tekst ingevuld!");
            }
            else
            {
                using (Database_BoekenEntities ctx = new Database_BoekenEntities())
                {
                    //kijken of de auteur bestaat anders voegtoe aan database
                    if (ctx.Auteurs.Select(a => a.Voornaam.ToLower()).Contains(cbAuteursVoornamen.Text.ToLower()) && ctx.Auteurs.Select(a => a.Achternaam.ToLower()).Contains(cbAuteursAchternamen.Text.ToLower()))
                    {
                    if (Selected != null)
                    {
                        if (VerwijderAuteurIds.Contains(ctx.Auteurs.Where(a => a.Voornaam == cbAuteursVoornamen.Text && a.Achternaam == cbAuteursAchternamen.Text).FirstOrDefault().Id))
                            VerwijderAuteurIds.Remove((int)cbAuteursVoornamen.SelectedValue);
                    }
                       
                    }
                    else
                    {              
                        ctx.Auteurs.Add(new Auteur { Voornaam = cbAuteursVoornamen.Text, Achternaam = cbAuteursAchternamen.Text });
                        ctx.SaveChanges();
                    }
                        AuteursVoornamen.Add(ctx.Auteurs.Where(a => a.Voornaam == cbAuteursVoornamen.Text && a.Achternaam == cbAuteursAchternamen.Text).FirstOrDefault().Voornaam);
                        AuteursAchternamen.Add(cbAuteursAchternamen.Text);
                        GekozenAuteursIds.Add(ctx.Auteurs.Where(a => a.Voornaam == cbAuteursVoornamen.Text && a.Achternaam == cbAuteursAchternamen.Text).FirstOrDefault().Id);
                    LoadListBoxAuteurs();
                }
               
                
            }
        }
        private void btnVerwijderAuteur_Click(object sender, EventArgs e)
        {
            int selectedIndex = lbAutVNBoek.SelectedIndex;
            if (GekozenAuteursIds.Count > 0)
            {
                VerwijderAuteurIds.Add(GekozenAuteursIds[selectedIndex]);
            }
            AuteursVoornamen.RemoveAt(selectedIndex);
            AuteursAchternamen.RemoveAt(selectedIndex);
            GekozenAuteursIds.RemoveAt(selectedIndex);
            LoadListBoxAuteurs();
            foreach (var item in VerwijderGenreIds)
            {
                MessageBox.Show(item.ToString());
            }
        }
        private void LoadListBoxAuteurs()
        {
            lbAutVNBoek.DataSource = null;
            lbAutANBoek.DataSource = null;
            lbAutVNBoek.DataSource = AuteursVoornamen;
            lbAutANBoek.DataSource = AuteursAchternamen;
        }

        private void btnNaarRechts_Click(object sender, EventArgs e)
        {
            using (Database_BoekenEntities ctx = new Database_BoekenEntities())
            {
                if (!GekozenGenresId.Contains((int)lbAllGenres.SelectedValue))
                {
                    if (Selected != null)
                    {
                        VerwijderGenreIds.Remove((int)lbAllGenres.SelectedValue);
                    }
                    GekozenGenres.Add(ctx.Genres.Where(g=>g.Id == (int)lbAllGenres.SelectedValue).FirstOrDefault().Genre1);
                    GekozenGenresId.Add((int)lbAllGenres.SelectedValue);
                    LoadListBoxGenres();
                    //MessageBox.Show($"{ctx.Genres.Where(g => g.Id == (int)lbAllGenres.SelectedValue).FirstOrDefault().Genre1}{(int)lbAllGenres.SelectedValue}");
                }

            }
            
        }
        private void btnNaarLinks_Click(object sender, EventArgs e)
        {
            if (GekozenGenres.Count>0)
            {
                
                VerwijderGenreIds.Add(GekozenGenresId[lbGenresToevoegen.SelectedIndex]);
                
                GekozenGenres.RemoveAt(lbGenresToevoegen.SelectedIndex);
                GekozenGenresId.RemoveAt(lbGenresToevoegen.SelectedIndex);
                LoadListBoxGenres();
            }
           
        }
        private void LoadListBoxGenres()
        {
            lbGenresToevoegen.DataSource = null;
            lbGenresToevoegen.DataSource = GekozenGenres;
        }

        private void btnToevoegenDB_Click(object sender, EventArgs e)
        {
            if (tbTitel.Text == "")
            {
                epErrors.SetError(tbTitel, "Geen tekst ingevuld!");
            }
            else if (nudAPaginas.Value == 0)
            {
                epErrors.SetError(nudAPaginas, "paginas kunnen nul");
            }
            else if (cbUitgever.Text == "")
            {
                epErrors.SetError(cbUitgever, "paginas kunnen nul");
            }
            else if (lbAutVNBoek.Items.Count == 0)
            {
                epErrors.SetError(lbAutVNBoek, "geen Auteur(s)");
                epErrors.SetError(lbAutANBoek, "geen Auteur(s)");
            }
            else if(lbGenresToevoegen.Items.Count == 0)
            {
                epErrors.SetError(lbGenresToevoegen, "geen Genre(s)");
            }
            else
            {
                List<int> gekozenAuteursIds = new List<int>();
                using (Database_BoekenEntities ctx = new Database_BoekenEntities())
                {
                    if (Selected == null)
                    {
                        //kijkt of uitgever bestaat anders voegt hij hem toe
                        if (!ctx.Uitgeverijens.Select(u => u.Naam.ToLower()).Contains(cbUitgever.Text.ToLower()))
                        {
                            ctx.Uitgeverijens.Add(new Uitgeverijen { Naam = cbUitgever.Text });
                            ctx.SaveChanges();
                        }
                        //zoekt gekozen uitgever
                        var gekozenUitgever = ctx.Uitgeverijens.Where(u => u.Naam.ToLower() == cbUitgever.Text.ToLower()).FirstOrDefault();
                        //MessageBox.Show($"naam {gekozenUitgever.Naam} id {gekozenUitgever.Id}"); voor tests
                        //voegt een boek toe met alle data
                        ctx.Boekens.Add(new Boeken
                        {
                            Titel = tbTitel.Text,
                            AantalPaginas = (int)nudAPaginas.Value,
                            Score = (int)nudScore.Value,
                            Publicatie = dtPublicatie.Value,
                            UitgeverId = gekozenUitgever.Id
                        });
                        ctx.SaveChanges();
                        // zoekt de net toegevoegde boek 
                        var newBoek = ctx.Boekens.Where(b => b.Titel == tbTitel.Text && b.AantalPaginas == (int)nudAPaginas.Value && b.Score == (int)nudScore.Value && b.UitgeverId == gekozenUitgever.Id).FirstOrDefault();
                        foreach (var gekAutId in GekozenAuteursIds)
                        {
                            ctx.BoekenAuteurs.Add(new BoekenAuteur { BoekId = newBoek.Id, AuteurId = gekAutId });
                            ctx.SaveChanges();
                            
                        }
                        //// loop voor alle auteurs te linken met de nieuwe boek <- oude code
                        //for (int i = 0; i < AuteursVoornamen.Count; i++)
                        //{
                        //    string voornaamAut = AuteursVoornamen[i];
                        //    string achternaamAut = AuteursAchternamen[i];
                        //    //kijken of de auteur bestaat anders voegtoe aan database
                        //    if (ctx.Auteurs.Select(a => a.Voornaam.ToLower()).Contains(voornaamAut.ToLower()) && ctx.Auteurs.Select(a => a.Achternaam.ToLower()).Contains(achternaamAut.ToLower()))
                        //    {
                        //    }
                        //    else
                        //    {
                        //        MessageBox.Show($"{voornaamAut} {achternaamAut}");
                        //        ctx.Auteurs.Add(new Auteur { Voornaam = voornaamAut, Achternaam = achternaamAut });
                        //        ctx.SaveChanges();

                        //    }
                        //    //id zoeken van de auteur daarna een link tussen deze auteur en boek leggen
                        //    var gekozenAuteur = ctx.Auteurs.Where(a => a.Voornaam.ToLower() == voornaamAut.ToLower() && a.Achternaam.ToLower() == achternaamAut.ToLower()).FirstOrDefault();
                        //    ctx.BoekenAuteurs.Add(new BoekenAuteur { BoekId = newBoek.Id, AuteurId = gekozenAuteur.Id });
                        //    ctx.SaveChanges();
                        //}
                        //genres linken aan boek
                        foreach (var GenreId in GekozenGenresId)
                        {
                            ctx.BoekenGenres.Add(new BoekenGenre { BoekId = newBoek.Id, GenreId = GenreId });
                            ctx.SaveChanges();
                        }
                    }
                    else
                    {
                        //kijkt of uitgever bestaat anders voegt hij hem toe
                        if (!ctx.Uitgeverijens.Select(u => u.Naam.ToLower()).Contains(cbUitgever.Text.ToLower()))
                        {
                            ctx.Uitgeverijens.Add(new Uitgeverijen { Naam = cbUitgever.Text });
                            ctx.SaveChanges();
                        }
                        //zoekt gekozen uitgever
                        var gekozenUitgever = ctx.Uitgeverijens.Where(u => u.Naam.ToLower() == cbUitgever.Text.ToLower()).FirstOrDefault();
     
                        //edit alle data van een boek                    
                        var selectedboek = ctx.Boekens.Where(b => b.Id == Selected.Id).FirstOrDefault();
                        selectedboek.Titel = tbTitel.Text;
                        selectedboek.AantalPaginas = (int)nudAPaginas.Value;
                        selectedboek.Score = (int)nudScore.Value;
                        selectedboek.Publicatie = dtPublicatie.Value;
                        selectedboek.UitgeverId = gekozenUitgever.Id;
                        ctx.SaveChanges();
                        foreach (var gekAutId in GekozenAuteursIds)
                        {
                            if (ctx.BoekenAuteurs.Where(ba => ba.BoekId == Selected.Id && ba.AuteurId == gekAutId).Any())
                            {
                            }
                            else
                            {
                                ctx.BoekenAuteurs.Add(new BoekenAuteur { BoekId = Selected.Id, AuteurId = gekAutId });
                                ctx.SaveChanges();
                            }
                        }
                        
                        foreach (var verAutId in VerwijderAuteurIds)
                        {
                            ctx.BoekenAuteurs.Remove(ctx.BoekenAuteurs.Where(ba => ba.BoekId == Selected.Id && ba.AuteurId == verAutId).FirstOrDefault());
                            ctx.SaveChanges();
                        }
                        foreach (var GenreId in GekozenGenresId)
                        {
                            if (ctx.BoekenGenres.Where(bg => bg.BoekId == Selected.Id && bg.GenreId == GenreId).Any())
                            {
                            }
                            else
                            {
                                ctx.BoekenGenres.Add(new BoekenGenre { BoekId = Selected.Id, GenreId = GenreId });
                                ctx.SaveChanges();
                            }
                        }
                        foreach (var VerGenId in VerwijderGenreIds)
                        {
                            ctx.BoekenGenres.RemoveRange(ctx.BoekenGenres.Where(bg => bg.BoekId == Selected.Id && bg.GenreId == VerGenId));
                            ctx.SaveChanges();
                        }
                    }
                }
                this.DialogResult = DialogResult.OK;
            }
        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }
    }
}
