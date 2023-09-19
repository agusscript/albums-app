using domain;
using MaterialSkin;
using MaterialSkin.Controls;
using System;

namespace WindowsFormApp.forms
{
    public partial class DetailsForm : MaterialForm
    {
        public DetailsForm(Album album)
        {
            InitializeComponent();

            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);

            detailsTitleLabel.Text = album.Title;
            detailsAuthorLabel.Text = album.Author;
            detailsAmountTracksLabel.Text = $"{album.AmountTracks} songs";
            detailsReleasedDateLabel.Text = $"Released Date: {DateTime.Parse(album.ReleasedDate).ToString("dd/MM/yyyy")}";
            detailsGenreLabel.Text = album.Genre.Name;
            ImageHelper.LoadImage(detailsCoverImagePictureBox, album.CoverImage);
        }
    }
}
