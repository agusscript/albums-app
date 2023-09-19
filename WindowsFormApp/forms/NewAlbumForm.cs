using business;
using domain;
using MaterialSkin;
using MaterialSkin.Controls;
using System;
using System.Windows.Forms;

namespace WindowsFormApp.forms
{
    public partial class NewAlbumForm : MaterialForm
    {
        private Album album = null;

        public NewAlbumForm()
        {
            InitializeComponent();

            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
        }

        public NewAlbumForm(Album albumToEdit)
        {
            InitializeComponent();

            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);

            this.album = albumToEdit;
            Text = "Edit Album";
        }

        private void AddAlbumForm_Load(object sender, EventArgs e)
        {
            GenreService genreService = new GenreService();

            try
            {
                genreComboBox.DataSource = genreService.BringList();

                if (album != null)
                {
                    titleTextBox.Text = album.Title;
                    authorTextBox.Text = album.Author;
                    amountTracksTextBox.Text = album.AmountTracks.ToString();
                    coverImageUrlTextBox.Text = album.CoverImage;
                    ImageHelper.LoadImage(previewImgPictureBox, album.CoverImage);
                    genreComboBox.Text = album.Genre.ToString();
                    releasedDateTimePicker.Text = album.ReleasedDate;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void coverImageUrlTextBox_Leave(object sender, EventArgs e)
        {
            ImageHelper.LoadImage(previewImgPictureBox, coverImageUrlTextBox.Text);
        }

        private void confirmAddAlbumBtn_Click(object sender, System.EventArgs e)
        {
            try
            {
                if (album == null)
                {
                    album = new Album();
                }

                bool validatedInt = ValidateInt(out string errorMessageType);
                bool validatedEmpty = ValidateEmpty(out string errorMessageEmpty);

                if (validatedEmpty)
                {
                    if (validatedInt)
                    {
                        album.Title = titleTextBox.Text;
                        album.Author = authorTextBox.Text;
                        album.AmountTracks = int.Parse(amountTracksTextBox.Text);
                        album.ReleasedDate = releasedDateTimePicker.Value.ToString("MM/dd/yyyy");
                        album.CoverImage = coverImageUrlTextBox.Text;
                        album.Genre = (Genre)genreComboBox.SelectedItem;

                        SaveAlbum(album);
                    }
                    else
                    {
                        MessageBox.Show(errorMessageType, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show(errorMessageEmpty, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void SaveAlbum(Album album)
        {
            AlbumService albumService = new AlbumService();

            if (album.Id == 0)
            {
                albumService.Add(album);
                MessageBox.Show("The new album was successfully added", "Add Album", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            else
            {
                albumService.Edit(album);
                MessageBox.Show("The album was edited successfully", "Edit Album", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
        }

        private bool ValidateEmpty(out string errorMessageEmpty)
        {
            errorMessageEmpty = string.Empty;

            if (string.IsNullOrEmpty(titleTextBox.Text))
                errorMessageEmpty += "The title field cannot be empty." + Environment.NewLine;

            if (string.IsNullOrEmpty(authorTextBox.Text))
                errorMessageEmpty += "The author field cannot be empty." + Environment.NewLine;

            if (string.IsNullOrEmpty(amountTracksTextBox.Text))
                errorMessageEmpty += "The amount tracks field cannot be empty." + Environment.NewLine;

            return errorMessageEmpty == string.Empty;
        }

        private bool ValidateInt(out string errorMessageType)
        {
            errorMessageType = string.Empty;

            if (!int.TryParse(amountTracksTextBox.Text, out int amountTracks))
                errorMessageType += "The Amount Tracks field can only be an integer type." + Environment.NewLine;

            return errorMessageType == string.Empty;
        }

        private void cancelAddAlbumBtn_Click(object sender, System.EventArgs e)
        {
            this.Close();
        }
    }
}
