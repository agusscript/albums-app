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
            ShowAlbumList();
        }

        private void ShowAlbumList()
        {
            AlbumService service = new AlbumService();
            try
            {
                listAlbums = service.BringList();
                dataGridViewAlbums.DataSource = listAlbums;
                dataGridViewAlbums.Columns["CoverImage"].Visible = false;
                ImageHelper.LoadImage(pictureBoxAlbumCoverImg, listAlbums[0].CoverImage);
            }
            catch (Exception ex)
            {
                MaterialMessageBox.Show(ex.ToString());
            }
        }

        private void dataGridViewAlbums_SelectionChanged(object sender, EventArgs e)
        {
            Album selectedAlbum = (Album)dataGridViewAlbums.CurrentRow.DataBoundItem;
            ImageHelper.LoadImage(pictureBoxAlbumCoverImg, selectedAlbum.CoverImage);
        }

        private void AddAlbumBtn_Click(object sender, EventArgs e)
        {
            AddAlbumForm addAlbumForm = new AddAlbumForm();
            addAlbumForm.ShowDialog();
            ShowAlbumList();
        }
    }
}
