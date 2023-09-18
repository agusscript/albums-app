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
                ImageHelper.LoadImage(pictureBoxAlbumCoverImg, albumsList[0].CoverImage);
                HideColumns();
                ShowAlbumsCount();
            }
            catch (Exception ex)
            {
                MaterialMessageBox.Show(ex.ToString());
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
                ImageHelper.LoadImage(pictureBoxAlbumCoverImg, selectedAlbum.CoverImage);
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
            Album selectedAlbum = (Album)dataGridViewAlbums.CurrentRow.DataBoundItem;
            NewAlbumForm editAlbumForm = new NewAlbumForm(selectedAlbum);
            editAlbumForm.ShowDialog();
            ShowAlbumList();
        }

        private void deleteAlbumBtn_Click_1(object sender, EventArgs e)
        {
            AlbumService albumService = new AlbumService();
            Album selectedAlbum;

            try
            {
                DialogResult confirmDelete = MaterialMessageBox.Show("Are you sure to delete this food ?", "Confirm Delete !", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (confirmDelete == DialogResult.Yes)
                {
                    selectedAlbum = (Album)dataGridViewAlbums.CurrentRow.DataBoundItem;
                    albumService.Delete(selectedAlbum.Id);
                    ShowAlbumList();
                }
            }
            catch (Exception ex)
            {

                MaterialMessageBox.Show(ex.ToString());
            }
        }

        private void searchTextBox_TextChanged(object sender, EventArgs e)
        {
            List<Album> filteredList;
            string filter = searchTextBox.Text;

            if (filter.Length >= 3)
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
