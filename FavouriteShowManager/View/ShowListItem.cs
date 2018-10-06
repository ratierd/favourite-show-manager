using System;
using System.Windows.Forms;
using FavouriteShowManager.Model;

namespace FavouriteShowManager.View
{
    public partial class ShowListItem : UserControl
    {
        private bool _saveButtonState;
        private bool SaveButtonState {
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

                    stateLabel.Visible = false;
                }
                else
                {
                    saveButton.Text = "Remove";
                    saveButton.FlatAppearance.BorderColor = System.Drawing.ColorTranslator.FromHtml("#ca744f");
                    saveButton.BackColor = System.Drawing.ColorTranslator.FromHtml("#d0390b");
                    saveButton.FlatAppearance.MouseOverBackColor = System.Drawing.ColorTranslator.FromHtml("#c75330");
                    saveButton.FlatAppearance.MouseDownBackColor = System.Drawing.ColorTranslator.FromHtml("#c86e52");

                    stateLabel.Visible = true;
                }
                _saveButtonState = value;
            }
        }

        private Show _showItem;
        public Show ShowItem { get { return _showItem; } }

        public ShowListItem(Show show)
        {
            InitializeComponent();

            _showItem = show;

            Dock = DockStyle.Top;
            BackColor = System.Drawing.ColorTranslator.FromHtml("#2c333e");

            showTitle.Text = _showItem.Title;
            showTitle.ForeColor = System.Drawing.ColorTranslator.FromHtml("#eeeeee");
            posterPictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            try
            {
                posterPictureBox.Load(_showItem.PosterUrl);
            }
            catch(Exception){
                posterPictureBox.Load("http://suggestmovie.net/images/posternotfound.png");
            }
            showDescription.Text = _showItem.Synopsis;
            showDescription.ForeColor = System.Drawing.ColorTranslator.FromHtml("#cccccc");
            detailsButton.FlatAppearance.BorderColor = System.Drawing.ColorTranslator.FromHtml("#3f8bce");
            detailsButton.FlatAppearance.BorderSize = 2;
            detailsButton.BackColor = System.Drawing.ColorTranslator.FromHtml("#007acc");
            detailsButton.FlatAppearance.MouseOverBackColor = System.Drawing.ColorTranslator.FromHtml("#2584c4");
            detailsButton.FlatAppearance.MouseDownBackColor = System.Drawing.ColorTranslator.FromHtml("#4294cc");

            saveButton.FlatAppearance.BorderSize = 2;

            SaveButtonState = !Window.controller.showIsSaved(_showItem);

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

            switch (_showItem.State)
            {
                case Model.Show.ShowState.TO_SEE:
                    stateLabel.Text = "To see";
                    break;
                case Model.Show.ShowState.SEEN:
                    stateLabel.Text = "Seen";
                    break;
                case Model.Show.ShowState.CONSIDERED:
                    stateLabel.Text = "Considered";
                    break;
            }
            stateLabel.ForeColor = System.Drawing.ColorTranslator.FromHtml("#cccccc");
        }

        private void detailsButton_Click(object sender, EventArgs e)
        {
            Control panel = Program.window.ContentPanel;
            panel.Controls.Clear();
            panel.Controls.Add(Window.controller.showDetailsView(_showItem));
            Program.window.AllListShowsButtons.ForEach(delegate (ListShowsButton b)
            {
                b.IsSelected = false;
            });
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

    }
}
