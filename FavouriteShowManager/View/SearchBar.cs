using System;
using System.Windows.Forms;

namespace FavouriteShowManager.View
{
    public partial class SearchBar : UserControl
    {
        public SearchBar()
        {
            InitializeComponent();

            Dock = DockStyle.Top;
            BackColor = System.Drawing.ColorTranslator.FromHtml("#3c3c3c");
            searchTextBox.BackColor = System.Drawing.ColorTranslator.FromHtml("#3c3c3c");
            searchTextBox.ForeColor = System.Drawing.ColorTranslator.FromHtml("#cccccc");
            searchTextBox.Text = "Search a show using a title...";
        }

        public class SearchSubmittedEventArgs : EventArgs
        {
            public SearchSubmittedEventArgs(String searchTerm)
            {
                _searchTerm = searchTerm;
            }
            private String _searchTerm;
            public String SearchTerm { get { return _searchTerm; } }
        }

        public event EventHandler<SearchSubmittedEventArgs> SearchSubmitted;

        protected virtual void OnRaiseSearchSubmittedEvent(SearchSubmittedEventArgs e)
        {
            SearchSubmitted?.Invoke(this, e);
        }

        private void searchTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == (char)Keys.Enter)
            {
                OnRaiseSearchSubmittedEvent(new SearchSubmittedEventArgs(searchTextBox.Text));
                e.Handled = true;
            }
        }

        private void searchTextBox_Enter(object sender, EventArgs e)
        {
            if (searchTextBox.Text == "Search a show using a title...")
            {
                searchTextBox.Text = "";
                searchTextBox.ForeColor = System.Drawing.ColorTranslator.FromHtml("#eeeeee");
            }
        }

        private void searchTextBox_Leave(object sender, EventArgs e)
        {
            if (searchTextBox.Text.Length == 0)
            {
                searchTextBox.Text = "Search a show using a title...";
                searchTextBox.ForeColor = System.Drawing.ColorTranslator.FromHtml("#cccccc");
            }
        }
    }
}
