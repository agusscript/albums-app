using domain;
using MaterialSkin;
using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using WindowsFormApp.forms;

namespace WindowsFormApp
{
    public partial class MainForm : MaterialForm
    {
        private List<Album> albumsList;
        public MainForm()
        {
            InitializeComponent();

            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.ColorScheme = new ColorScheme(Primary.BlueGrey800, Primary.BlueGrey900, Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE);
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
                albumsList = service.BringList();
                dataGridViewAlbums.DataSource = albumsList;
                HideColumns();
                ShowAlbumsCount();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void ShowAlbumsCount()
        {
            totalAlbumsLabel.Text = $"Total Albums: {albumsList.Count}";
        }

        private void dataGridViewAlbums_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridViewAlbums.CurrentRow != null)
            {
                Album selectedAlbum = (Album)dataGridViewAlbums.CurrentRow.DataBoundItem;
            }
        }

        private void AddAlbumBtn_Click(object sender, EventArgs e)
        {
            NewAlbumForm addAlbumForm = new NewAlbumForm();
            addAlbumForm.ShowDialog();
            ShowAlbumList();
        }

        private void editAlbumBtn_Click(object sender, EventArgs e)
        {
            if (dataGridViewAlbums.CurrentRow != null)
            {
                Album selectedAlbum = (Album)dataGridViewAlbums.CurrentRow.DataBoundItem;
                NewAlbumForm editAlbumForm = new NewAlbumForm(selectedAlbum);
                editAlbumForm.ShowDialog();
                ShowAlbumList();
            }
        }

        private void deleteAlbumBtn_Click_1(object sender, EventArgs e)
        {
            AlbumService albumService = new AlbumService();
            Album selectedAlbum;

            try
            {
                DialogResult confirmDelete = MessageBox.Show("Are you sure to delete this food ?", "Confirm Delete !", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (confirmDelete == DialogResult.Yes)
                {
                    selectedAlbum = (Album)dataGridViewAlbums.CurrentRow.DataBoundItem;
                    albumService.Delete(selectedAlbum.Id);
                    MessageBox.Show("The album was deleted successfully", "Delete Album", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ShowAlbumList();
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }

        private void searchBtn_Click(object sender, EventArgs e)
        {
            List<Album> filteredList;
            string filter = searchTextBox.Text;

            if (filter.Length >= 2)
            {
                filteredList = albumsList.FindAll(album => album.Title.ToLower().Contains(filter.ToLower()) || album.Author.ToLower().Contains(filter.ToLower()));
            }
            else
            {
                filteredList = albumsList;
            }

            dataGridViewAlbums.DataSource = null;
            dataGridViewAlbums.DataSource = filteredList;
            HideColumns();
        }

        private void HideColumns()
        {
            dataGridViewAlbums.Columns["Id"].Visible = false;
            dataGridViewAlbums.Columns["CoverImage"].Visible = false;
            dataGridViewAlbums.Columns["ReleasedDate"].Visible = false;
        }
    }
}
