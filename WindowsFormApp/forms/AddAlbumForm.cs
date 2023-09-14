﻿using domain;
using MaterialSkin;
using MaterialSkin.Controls;
using System;
using business;

namespace WindowsFormApp.forms
{
    public partial class AddAlbumForm : MaterialForm
    {
        public AddAlbumForm()
        {
            InitializeComponent();

            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.Brown800, Primary.Brown800, Primary.Brown500, Accent.LightBlue200, TextShade.WHITE);
        }

        private void confirmAddAlbumBtn_Click(object sender, System.EventArgs e)
        {
            Album newAlbum = new Album();
            AlbumService albumService = new AlbumService();

            try
            {
                newAlbum.Title = titleTextBox.Text;
                newAlbum.Author = authorTextBox.Text;
                newAlbum.CoverImage = coverImageUrlTextBox.Text;

                albumService.Add(newAlbum);
                MaterialMessageBox.Show("New album was successfully added");
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