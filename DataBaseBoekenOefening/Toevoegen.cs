using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
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
        public List<string> AuteursVoornamen = new List<string>();
        public List<string> AuteursAchternamen = new List<string>();
        public List<string> GekozenGenres = new List<string>();
        public List<int> GekozenGenresId = new List<int>();

        private void Toevoegen_Load(object sender, EventArgs e)
        {
            using (Database_BoekenEntities ctx = new Database_BoekenEntities())
            {
                var genres = ctx.Genres.Select(x => x).ToList();
                var autVoornamen = ctx.Auteurs.Select(x => x.Voornaam).ToList();
                var autAchternamen = ctx.Auteurs.Select(x => x.Achternaam).ToList();
                var uitgevers = ctx.Uitgeverijens.Select(x => x.Naam).ToList();
                lbAllGenres.DisplayMember = "Genre1";
                lbAllGenres.ValueMember = "Id";
                lbAllGenres.DataSource = genres;              
                cbUitgever.DataSource = uitgevers;
                cbAuteursVoornamen.DataSource = autVoornamen;
                cbAuteursAchternamen.DataSource = autAchternamen;
                lbAllGenres.SelectedIndex = 0;
                cbUitgever.SelectedIndex = 0;
                cbAuteursVoornamen.SelectedIndex = -1;
                cbAuteursAchternamen.SelectedIndex = -1;

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
            lbAutVNBoek.SelectedIndex = lbAutANBoek.SelectedIndex;
        }

        private void btnToevoegenAuteur_Click(object sender, EventArgs e)
        {
            AuteursVoornamen.Add(cbAuteursVoornamen.Text);
            AuteursAchternamen.Add(cbAuteursAchternamen.Text);
            LoadListBoxAuteurs();
        }
        private void btnVerwijderAuteur_Click(object sender, EventArgs e)
        {
            int selectedIndex = lbAutVNBoek.SelectedIndex;
            AuteursVoornamen.RemoveAt(selectedIndex);
            AuteursAchternamen.RemoveAt(selectedIndex);
            LoadListBoxAuteurs();
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
            if (GekozenGenres.Contains(lbAllGenres.SelectedItem))
            { }
            else
            { 
                GekozenGenres.Add(lbAllGenres.SelectedItem.ToString());
                GekozenGenresId.Add((int)lbAllGenres.SelectedValue);
                LoadListBoxGenres();
            }
            
            
        }
        private void btnNaarLinks_Click(object sender, EventArgs e)
        {
            if (GekozenGenres.Count>0)
            {
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
            List<int> gekozenAuteursIds = new List<int>();
            using (Database_BoekenEntities ctx = new Database_BoekenEntities())
            {
                if (ctx.Uitgeverijens.Select(u => u.Naam.ToLower()).Contains(cbUitgever.Text.ToLower()))
                {
                    MessageBox.Show("1");
                }
                else
                {
                    MessageBox.Show("2");
                    ctx.Uitgeverijens.Add(new Uitgeverijen { Naam = cbUitgever.Text });
                    ctx.SaveChanges();
                }
                var gekozenUitgever = ctx.Uitgeverijens.Where(u => u.Naam.ToLower() == cbUitgever.Text.ToLower()).FirstOrDefault();
                MessageBox.Show($"naam {gekozenUitgever.Naam} id {gekozenUitgever.Id}");
                ctx.Boekens.Add(new Boeken
                {
                    Titel = tbTitel.Text,
                    AantalPaginas = (int)nudAPaginas.Value,
                    Score = (int)nudScore.Value,
                    Publicatie = dtPublicatie.Value,
                    UitgeverId = gekozenUitgever.Id
                });
                ctx.SaveChanges();
                var newBoek = ctx.Boekens.Where(b => b.Titel == tbTitel.Text && b.AantalPaginas == (int)nudAPaginas.Value && b.Score == (int)nudScore.Value && b.Publicatie == dtPublicatie.Value && b.UitgeverId == gekozenUitgever.Id).FirstOrDefault();
                for (int i = 0; i < AuteursVoornamen.Count; i++)
                {
                    if (ctx.Auteurs.Select(a => a.Voornaam.ToLower()).Contains(AuteursVoornamen[i].ToLower()) && ctx.Auteurs.Select(a => a.Achternaam.ToLower()).Contains(AuteursAchternamen[i].ToLower()))
                    {
                        MessageBox.Show("1");
                    }
                    else
                    {
                        MessageBox.Show("2");
                        ctx.Auteurs.Add(new Auteur { Voornaam = AuteursVoornamen[i], Achternaam = AuteursAchternamen[i] });
                        ctx.SaveChanges();
                    }
                    var gekozenAuteur = ctx.Auteurs.Where(a => a.Voornaam.ToLower() == AuteursVoornamen[i].ToLower() && a.Achternaam.ToLower() == AuteursAchternamen[i].ToLower()).FirstOrDefault();
                    ctx.BoekenAuteurs.Add(new BoekenAuteur { BoekId = newBoek.Id, AuteurId = gekozenAuteur.Id });
                    ctx.SaveChanges();
                }
                foreach (var GenreId in GekozenGenresId)
                {
                    ctx.BoekenGenres.Add(new BoekenGenre { BoekId = newBoek.Id, GenreId = GenreId });
                    ctx.SaveChanges();
                }
                MessageBox.Show($"naam {lbAllGenres.SelectedItem.ToString()} id {(int)lbAllGenres.SelectedValue}");
            }
        }
    }
}
