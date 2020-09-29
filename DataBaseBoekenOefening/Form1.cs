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
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            LoadFormInfo();
            lbBoeken.SelectedIndex = 1;
        }
        private void LoadFormInfo()
        {
            using (Database_BoekenEntities ctx = new Database_BoekenEntities())
            {              
                var query = ctx.Boekens.Select(x => x).ToList();
                lbBoeken.DisplayMember = "Titel";
                lbBoeken.ValueMember = "Id";
                lbBoeken.DataSource = query;               
            }
        }

        private void lbBoeken_SelectedIndexChanged(object sender, EventArgs e)
        {
            using (Database_BoekenEntities ctx = new Database_BoekenEntities())
            {
                

                var BoekUitgever = ctx.Uitgeverijens
                    .Join(ctx.Boekens,
                    u => u.Id,
                    bu => bu.UitgeverId,
                    (u, bu) => new { u, bu }).ToList();

                var BoekenGenres = BoekUitgever
                    .Join(ctx.BoekenGenres,
                    bu => bu.bu.Id,
                    bg => bg.BoekId,
                    (bu, bg) => new { bu, bg })
                    .Join(ctx.Genres,
                    bg2 => bg2.bg.GenreId,
                    g => g.Id,
                    (bg2, g) => new { bg2, g });

                var BoekenAuteurs = BoekUitgever
                    .Join(ctx.BoekenAuteurs,
                    bu => bu.bu.Id,
                    ba => ba.BoekId,
                    (bu, ba) => new { bu, ba })
                    .Join(ctx.Auteurs,
                    ba2 => ba2.ba.AuteurId,
                    a => a.Id,
                    (ba2, a) => new { ba2, a });
                Boeken selected = (Boeken)lbBoeken.SelectedItem;
               
                lTitel.Text = selected.Titel;
                lScore.Text = selected.Score.ToString();
                lPublicatie.Text = selected.Publicatie.ToString();               
                lUitgever.Text = BoekUitgever.Where(x => x.bu.Id == selected.Id).Select(x => x.u.Naam).FirstOrDefault();
                var genres = BoekenGenres.Where(x => x.bg2.bu.bu.Id == selected.Id).Select(x => x.g.Genre1).ToList();
                lbGenres.DataSource = genres;
                lAPaginas.Text = selected.AantalPaginas.ToString();
                var auteurNaam = BoekenAuteurs.Where(x => x.ba2.bu.bu.Id == selected.Id).Select(x => new { Naam = x.a.Voornaam + " " + x.a.Achternaam });
                lAuteur.Text = auteurNaam.Select(x =>x.Naam).FirstOrDefault();
            }
        }
    }
        
}
