using MaterialSkin;
using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using domain;
using WindowsFormApp.forms;

namespace WindowsFormApp
{
    public partial class MainForm : MaterialForm
    {
        private List<Album> listAlbums;
        public MainForm()
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
            dataGridViewAlbums.Columns[2].Visible = false;
            loadImage(listAlbums[0].CoverImage);
        }

        private void dataGridViewAlbums_SelectionChanged(object sender, EventArgs e)
        {
            Album selectedAlbum = (Album)dataGridViewAlbums.CurrentRow.DataBoundItem;
            loadImage(selectedAlbum.CoverImage);
        }

        private void loadImage(string image)
        {
            try
            {
                pictureBoxAlbumCoverImg.Load(image);

            }
            catch (Exception ex)
            {
                pictureBoxAlbumCoverImg.Load("https://demofree.sirv.com/nope-not-here.jpg");
            }
        }

        private void AddAlbumBtn_Click(object sender, EventArgs e)
        {
            AddAlbumForm addAlbumForm = new AddAlbumForm();
            addAlbumForm.ShowDialog();
        }
    }
}
