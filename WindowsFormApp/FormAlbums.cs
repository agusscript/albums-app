using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormApp
{
    public partial class FormAlbums : Form
    {
        private List<Album> listAlbums;
        public FormAlbums()
        {
            InitializeComponent();
        }

        private void FormAlbums_Load(object sender, EventArgs e)
        {
            AlbumService service = new AlbumService();
            listAlbums = service.BringList();
            dataGridViewAlbums.DataSource = listAlbums;
            loadImage(listAlbums[0].Image);
        }

        private void dataGridViewAlbums_SelectionChanged(object sender, EventArgs e)
        {
            Album selectedAlbum = (Album)dataGridViewAlbums.CurrentRow.DataBoundItem;
            loadImage(selectedAlbum.Image);
        }

        private void loadImage(string image)
        {
            try
            {
                pictureBoxAlbumCoverImg.Load(image);

            }catch(Exception ex)
            {
                pictureBoxAlbumCoverImg.Load("https://demofree.sirv.com/nope-not-here.jpg");
            }
        }
    }
}
