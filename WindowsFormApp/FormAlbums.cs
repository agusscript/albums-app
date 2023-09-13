using MaterialSkin;
using MaterialSkin.Controls;
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
    public partial class FormAlbums : MaterialForm
    {
        private List<Album> listAlbums;
        public FormAlbums()
        {
            InitializeComponent();

            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.Brown700, Primary.Brown700, Primary.Brown400, Accent.LightBlue200, TextShade.WHITE);
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
