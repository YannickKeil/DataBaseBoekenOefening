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
    public partial class GenreToevoegen : Form
    {
        public GenreToevoegen()
        {
            InitializeComponent();
        }

        private void GenreToevoegen_Load(object sender, EventArgs e)
        {
            LoadGenres();
        }
        private void LoadGenres()
        {
            using (Database_BoekenEntities ctx = new Database_BoekenEntities())
            {
                lbGenres.DataSource = null;
                var genres = ctx.Genres.Select(x => x).ToList();              
                lbGenres.DisplayMember = "Genre1";
                lbGenres.ValueMember = "Id";
                lbGenres.DataSource = genres;   
            }
        }

        private void btnGT_Click(object sender, EventArgs e)
        {
            using (Database_BoekenEntities ctx = new Database_BoekenEntities())
            {
                ctx.Genres.Add(new Genre { Genre1 = tbGenre.Text });
                ctx.SaveChanges();
            }
            LoadGenres();
        }

        private void btnGV_Click(object sender, EventArgs e)
        {
            using (Database_BoekenEntities ctx = new Database_BoekenEntities())
            {
                ctx.Genres.Remove(ctx.Genres.Where(g => g.Id == (int)lbGenres.SelectedValue).FirstOrDefault());
                ctx.SaveChanges();
            }
            LoadGenres();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }
    }
}
