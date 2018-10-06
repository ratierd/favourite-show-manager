using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FavouriteShowManager.View
{
    public partial class ListShowsButtonGroup : UserControl
    {
        public String Title { get { return Title; } set { this.titleLabel.Text = value; } }
        private List<ListShowsButton> buttons;
        private System.Drawing.Imaging.Metafile svgIcon;

        public ListShowsButtonGroup(String title, List<ListShowsButton> buttons, bool canAddButtons)
        {
            InitializeComponent();

            titlePanel.BackColor = System.Drawing.ColorTranslator.FromHtml("#242931");
            titleLabel.ForeColor = System.Drawing.ColorTranslator.FromHtml("#ffffff");

            this.Title = title;
            this.buttons = buttons;
            svgIcon = new System.Drawing.Imaging.Metafile(new System.IO.MemoryStream(Properties.Resources.ic_filter_list_black_24px));

            if (buttons.Count > 0)
            {
                int buttonHeight = buttons.First().ClientSize.Height;
                foreach (ListShowsButton b in buttons)
                {
                    this.filtersPanel.Controls.Add(b);
                    b.Dock = DockStyle.Bottom;
                }
            }

            if (canAddButtons)
            {
                TextBox addButtonTextBox = new TextBox();
                addButtonTextBox.Dock = DockStyle.Bottom;
                addButtonTextBox.BackColor = System.Drawing.ColorTranslator.FromHtml("#242931");
                addButtonTextBox.ForeColor = System.Drawing.ColorTranslator.FromHtml("#cccccc");
                addButtonTextBox.Text = "Add category...";
                addButtonTextBox.Enter += delegate
                {
                    if (addButtonTextBox.Text == "Add category...")
                    {
                        addButtonTextBox.Text = "";
                        addButtonTextBox.ForeColor = System.Drawing.ColorTranslator.FromHtml("#ffffff");
                    }
                };
                addButtonTextBox.Leave += delegate 
                {
                    if (addButtonTextBox.Text.Length == 0)
                    {
                        addButtonTextBox.Text = "Add category...";
                        addButtonTextBox.ForeColor = System.Drawing.ColorTranslator.FromHtml("#cccccc");
                    }
                };
                addButtonTextBox.KeyPress += addButtonTextBox_KeyPress;
                Controls.Add(addButtonTextBox);
            }
        }

        private void addButtonTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == (char)Keys.Enter)
            {
                ListShowsButton b = new ListShowsButton(((TextBox)sender).Text);
                buttons.Add(b);
                filtersPanel.Controls.Add(b);
                b.Dock = DockStyle.Bottom;
                ((TextBox)sender).Text = "";
                Invalidate();
                OnRaiseButtonAddedEvent(new ButtonAddedEventArgs(b));
                e.Handled = true;
            }
        }

        public class ButtonAddedEventArgs : EventArgs
        {
            public ButtonAddedEventArgs(ListShowsButton b)
            {
                _button = b;
            }
            private ListShowsButton _button;
            public ListShowsButton Button { get { return _button; } }
        }

        public event EventHandler<ButtonAddedEventArgs> ButtonAdded;

        protected virtual void OnRaiseButtonAddedEvent(ButtonAddedEventArgs e)
        {
            ButtonAdded?.Invoke(this, e);
        }

        private void icon_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.DrawImage(svgIcon, new Rectangle(Point.Empty, icon.ClientSize));
        }

        private void icon_Resize(object sender, EventArgs e)
        {
            icon.Invalidate();
        }

        public void removeItem(ListShowsButton b)
        {
            filtersPanel.Controls.Remove(b);
            Window.controller.Shows.ForEach(delegate (Model.Show s)
            {
                s.Categories.Remove(b.Title);
            });
        }

    }
}
