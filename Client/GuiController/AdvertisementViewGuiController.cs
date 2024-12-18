﻿using Client.UserControls;
using Common.Communication;
using Common.Domain;
using Common.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Client.GuiController
{
    public class AdvertisementViewGuiController
    {
        private const string INSERT_COMMENT_TEXT = "Insert your comment";
        private UCAdvertisement viewAdvertisement;
        private string[] imagePaths;
        int selectedImageIndex;
        private Advertisement currentAdvertisement;
        public Control CreateViewAdvertisement(Advertisement advertisement)
        {
            viewAdvertisement = new UCAdvertisement();
            this.currentAdvertisement = advertisement;
            viewAdvertisement.lblPricePlaceholder.Text = advertisement.Price.ToString() + " €";
            viewAdvertisement.descriptionPlaceholder.Text = advertisement.Description;
            viewAdvertisement.labelMakePlaceholder.Text = advertisement.Vehicle.Make;
            viewAdvertisement.labelModelPlaceholder.Text = advertisement.Vehicle.Model;
            viewAdvertisement.labelBodyPlaceholder.Text = advertisement.Vehicle.BodyType.ToString();
            viewAdvertisement.labelYearPlaceholder.Text = advertisement.Year.ToString();
            viewAdvertisement.labelMileagePlaceholder.Text = advertisement.Mileage.ToString();
            viewAdvertisement.labelFuelPlaceholder.Text = advertisement.FuelType.ToString();
            selectedImageIndex = 0;
            imagePaths = advertisement.Images
            .OrderByDescending(x => x.Thumbnail) // Thumbnail image will come first if it exists
            .Select(x => x.Path)
            .ToArray();
            if (advertisement.Images.Count > 0)
            {
                viewAdvertisement.pictureBox.Image = System.Drawing.Image.FromFile(imagePaths[selectedImageIndex]);

            }
            else
            {

                viewAdvertisement.pictureBox.Image = System.Drawing.Image.FromFile(PlaceHolderImage.GetPlaceHolderImage().Path);
                viewAdvertisement.btnPrevImage.Visible = false;
                viewAdvertisement.btnNextImage.Visible = false;
            }
            viewAdvertisement.pictureBox.SizeMode = PictureBoxSizeMode.Zoom;
            viewAdvertisement.btnPrevImage.Click += PrevImage;
            viewAdvertisement.btnNextImage.Click += NextImage;
            viewAdvertisement.btnEditAdvertisement.Click += (s, a) => MainCoordinator.Instance.ShowEditAdvertisementPanel(advertisement);
            viewAdvertisement.btnAddComment.Click += AddComment;
            viewAdvertisement.txtBoxComment.Click += TxtBoxComment_Click;
            viewAdvertisement.txtBoxComment.Text = INSERT_COMMENT_TEXT;
            viewAdvertisement.lblAcceptsExchange.Text = advertisement.AcceptsExchange ? "Yes" : "No";

            LoadComments();

            if (advertisement.User.Equals(LoginGuiController.Instance.LoggedInUser))
            {
                viewAdvertisement.btnEditAdvertisement.Visible = true;
            }

            return viewAdvertisement;
        }

        private void TxtBoxComment_Click(object sender, EventArgs e)
        {
            if (viewAdvertisement.txtBoxComment.Text.Equals(INSERT_COMMENT_TEXT))
            {
                viewAdvertisement.txtBoxComment.Text = "";
            }
        }

        private void AddComment(object sender, EventArgs e)
        {
            Comment comment = new Comment();
            comment.Text = viewAdvertisement.txtBoxComment.Text;
            comment.AdvertisementId = currentAdvertisement.Id;
            comment.UserId = LoginGuiController.Instance.LoggedInUser.Id;

            Response response = Communication.Instance.AddComment(comment);
            if (response.Exception != null)
            {
                MessageBox.Show("Error when adding new comment");
            } 
            
            LoadComments();

        }

        private void LoadComments()
        {
            Response response = Communication.Instance.GetAllComments(currentAdvertisement);
            if (response.Exception != null)
            {

                MessageBox.Show("Error while fetching comments!");
                return;
            }

            List<CommentView> commentViews = (List<CommentView>)response.Result;

            List<string> comments = commentViews.Select(cv => $"{cv.Username}: {cv.Text}").ToList();

            viewAdvertisement.listBoxComment.DataSource = comments;
        }

        private void PrevImage(object sender, EventArgs e)
        {
            if (selectedImageIndex == 0)
            {
                selectedImageIndex = imagePaths.Length - 1;
                ShowImage(selectedImageIndex);
            }
            else
            {
                selectedImageIndex = selectedImageIndex - 1;
                ShowImage(selectedImageIndex);
            }
        }

        private void NextImage(object sender, EventArgs e)
        {
            if (selectedImageIndex == imagePaths.Length - 1)
            {
                selectedImageIndex = 0;
                ShowImage(selectedImageIndex);
            }
            else
            {
                selectedImageIndex++;
                ShowImage(selectedImageIndex);
            }
        }

        private void ShowImage(int imageIndex)
        {
            viewAdvertisement.pictureBox.Image = System.Drawing.Image.FromFile(imagePaths[imageIndex]);

        }
    }
}
