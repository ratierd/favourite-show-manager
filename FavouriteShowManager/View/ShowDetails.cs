using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FavouriteShowManager.Model;

namespace FavouriteShowManager.View
{
    public partial class ShowDetails : UserControl
    {

        private bool _saveButtonState;
        private bool SaveButtonState
        {
            get { return _saveButtonState; }
            set
            {
                if (value)
                {
                    saveButton.Text = "Save";
                    saveButton.FlatAppearance.BorderColor = System.Drawing.ColorTranslator.FromHtml("#84c43c");
                    saveButton.BackColor = System.Drawing.ColorTranslator.FromHtml("#72b80a");
                    saveButton.FlatAppearance.MouseOverBackColor = System.Drawing.ColorTranslator.FromHtml("#7cb32b");
                    saveButton.FlatAppearance.MouseDownBackColor = System.Drawing.ColorTranslator.FromHtml("#8dc23f");

                    categoriesLabel.Visible = false;
                    categoriesLabel.Text = "";
                    buttonCategories.Visible = false;
                    stateComboBox.Visible = false;
                    commentHeaderLabel.Visible = false;
                    commentTextBox.Visible = false;
                    commentTextBox.Text = "";
                }
                else
                {
                    saveButton.Text = "Remove";
                    saveButton.FlatAppearance.BorderColor = System.Drawing.ColorTranslator.FromHtml("#ca744f");
                    saveButton.BackColor = System.Drawing.ColorTranslator.FromHtml("#d0390b");
                    saveButton.FlatAppearance.MouseOverBackColor = System.Drawing.ColorTranslator.FromHtml("#c75330");
                    saveButton.FlatAppearance.MouseDownBackColor = System.Drawing.ColorTranslator.FromHtml("#c86e52");

                    categoriesLabel.Visible = true;
                    buttonCategories.Visible = true;
                    stateComboBox.Visible = true;
                    commentHeaderLabel.Visible = true;
                    commentTextBox.Visible = true;
                }
                _saveButtonState = value;
            }
        }

        private Show _showItem;
        public Show ShowItem { get { return _showItem; } }

        public ShowDetails(Show show)
        {
            InitializeComponent();

            _showItem = show;

            Dock = DockStyle.Fill;

            BackColor = System.Drawing.ColorTranslator.FromHtml("#2c333e");

            showTitle.Text = _showItem.Title;
            showTitle.ForeColor = System.Drawing.ColorTranslator.FromHtml("#eeeeee");
            posterPictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            try
            {
                posterPictureBox.Load(_showItem.PosterUrl);
            }
            catch (Exception)
            {
                posterPictureBox.Load("http://suggestmovie.net/images/posternotfound.png");
            }
            showDescription.Text = _showItem.Synopsis;
            showDescription.ForeColor = System.Drawing.ColorTranslator.FromHtml("#eeeeee");

            actorsLabel.Text = _showItem.Actors;
            actorsLabel.ForeColor = System.Drawing.ColorTranslator.FromHtml("#cccccc");

            languageLabel.Text = _showItem.Language;
            languageLabel.ForeColor = System.Drawing.ColorTranslator.FromHtml("#cccccc");

            labelAdditionalInfo.Text = show.Year;
            if (show.GetType() == typeof(Serie))
            {
                labelAdditionalInfo.Text += ", Serie(" + ((Serie)show).SeasonNumber.ToString() + " seasons)";
            }
            else
            {
                labelAdditionalInfo.Text += ", Movie";
            }
            labelAdditionalInfo.ForeColor = System.Drawing.ColorTranslator.FromHtml("#cccccc");

            saveButton.FlatAppearance.BorderSize = 2;
            SaveButtonState = !Window.controller.showIsSaved(_showItem);

            commentHeaderLabel.Text = "Comment";
            commentHeaderLabel.ForeColor = System.Drawing.ColorTranslator.FromHtml("#eeeeee");

            commentTextBox.BackColor = System.Drawing.ColorTranslator.FromHtml("#505b6b");
            commentTextBox.Text = _showItem.UserComment;

            categoriesLabel.BackColor = System.Drawing.ColorTranslator.FromHtml("#505b6b");
            String categories = "";
            foreach(String s in _showItem.Categories)
            {
                categories += s;
                if(s != _showItem.Categories.Last())
                {
                    categories += ", ";
                }
            }
            categoriesLabel.Text = categories;

            stateComboBox.Items.Add("To see");
            stateComboBox.Items.Add("Seen");
            stateComboBox.Items.Add("Considered");
            switch (_showItem.State)
            {
                case Model.Show.ShowState.TO_SEE:
                    stateComboBox.SelectedItem = "To see";
                    break;
                case Model.Show.ShowState.SEEN:
                    stateComboBox.SelectedItem = "Seen";
                    break;
                case Model.Show.ShowState.CONSIDERED:
                    stateComboBox.SelectedItem = "Considered";
                    break;
            }
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            if (SaveButtonState)
            {
                Window.controller.saveShow(_showItem);
            }
            else
            {
                Window.controller.removeShow(_showItem);
            }
            SaveButtonState = !_saveButtonState;
        }

        private void commentTextBox_TextChanged(object sender, EventArgs e)
        {
            _showItem.UserComment = commentTextBox.Text;
        }

        private void buttonCategories_Click(object sender, EventArgs e)
        {
            buttonCategories.DialogResult = new CategoriesForm(_showItem).ShowDialog(Program.window);
            String categories = "";
            foreach (String s in _showItem.Categories)
            {
                categories += s;
                if (s != _showItem.Categories.Last())
                {
                    categories += ", ";
                }
            }
            categoriesLabel.Text = categories;
        }

        private void stateComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (stateComboBox.SelectedItem)
            {
                case "To see":
                    _showItem.State = Model.Show.ShowState.TO_SEE;
                    break;
                case "Seen":
                    _showItem.State = Model.Show.ShowState.SEEN;
                    break;
                case "Considered":
                    _showItem.State = Model.Show.ShowState.CONSIDERED;
                    break;
            }
        }
    }
}
