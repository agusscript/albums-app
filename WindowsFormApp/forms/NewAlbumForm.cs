using business;
using domain;
using MaterialSkin;
using MaterialSkin.Controls;
using System;

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
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.Brown800, Primary.Brown800, Primary.Brown500, Accent.LightBlue200, TextShade.WHITE);
        }

        public NewAlbumForm(Album albumToEdit)
        {
            InitializeComponent();

            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.Brown800, Primary.Brown800, Primary.Brown500, Accent.LightBlue200, TextShade.WHITE);

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
                MaterialMessageBox.Show(ex.ToString());
            }
        }

        private void coverImageUrlTextBox_Leave(object sender, EventArgs e)
        {
            ImageHelper.LoadImage(previewImgPictureBox, coverImageUrlTextBox.Text);
        }

        private void confirmAddAlbumBtn_Click(object sender, System.EventArgs e)
        {
            AlbumService albumService = new AlbumService();

            try
            {
                if (album == null)
                {
                    album = new Album();
                }

                album.Title = titleTextBox.Text;
                album.Author = authorTextBox.Text;
                album.AmountTracks = int.Parse(amountTracksTextBox.Text);
                album.ReleasedDate = releasedDateTimePicker.Value.ToString("MM/dd/yyyy");
                album.CoverImage = coverImageUrlTextBox.Text;
                album.Genre = (Genre)genreComboBox.SelectedItem;

                if (album.Id == 0)
                {
                    albumService.Add(album);
                    MaterialMessageBox.Show("The new album was successfully added");
                }
                else
                {
                    albumService.Edit(album);
                    MaterialMessageBox.Show("The album was edited successfully");
                }
                this.Close();
            }
            catch (Exception ex)
            {
                MaterialMessageBox.Show(ex.ToString());
            }
        }

        private void cancelAddAlbumBtn_Click(object sender, System.EventArgs e)
        {
            this.Close();
        }
    }
}
