using System;
using System.Drawing;
using System.Windows.Forms;
using FavouriteShowManager.Controller;
using System.Collections.Generic;

namespace FavouriteShowManager.View
{
    public partial class ListShowsButton : UserControl
    {
        public static Color UnselectedBackgroundColor = System.Drawing.ColorTranslator.FromHtml("#242931");
        public static Color SelectedBackgroundColor = System.Drawing.ColorTranslator.FromHtml("#3d4755");
        public static Color UnselectedTextColor = System.Drawing.ColorTranslator.FromHtml("#acb0b7");
        public static Color SelectedTextColor = System.Drawing.ColorTranslator.FromHtml("#ffffff");

        private String _title;
        public String Title {
            get { return _title; }
            set {
                _title = value;
                titleLabel.Text = _title;
            }
        }
        private bool _isSelected;
        public bool IsSelected {
            get { return _isSelected; }
            set {
                _isSelected = value;
                if (_isSelected) {
                    BackColor = SelectedBackgroundColor;
                    titleLabel.ForeColor = SelectedTextColor;
                }
                else {
                    BackColor = UnselectedBackgroundColor;
                    titleLabel.ForeColor = UnselectedTextColor;
                }
            }
        }
        private IAction _actionController;
        public IAction Filterer { get { return _actionController; } }

        public ListShowsButton(String title)
        {
            InitializeComponent();
            Title = title;
            IsSelected = false;
            _actionController = new CategoryAction(title);
        }

        public ListShowsButton(BasicActions filterType)
        {
            InitializeComponent();
            switch (filterType)
            {
                case BasicActions.SEARCH:
                    Title = "Search";
                    IsSelected = false;
                    _actionController = new SearchAction();
                    break;
                case BasicActions.ALL:
                    Title = "All";
                    IsSelected = false;
                    _actionController = new AllAction();
                    break;
            }
        }

        public class SelectedEventArgs : EventArgs
        {
            public SelectedEventArgs(List<Control> l)
            {
                _controls = l;
            }
            private List<Control> _controls;
            public List<Control> Controls { get { return _controls; } }
        }
        
        public event EventHandler<SelectedEventArgs> Selected;
        
        protected virtual void OnRaiseSelectedEvent(SelectedEventArgs e)
        {
            Selected?.Invoke(this, e);
        }

        private void ListShowsButton_Click(object sender, EventArgs e)
        {
            if (!IsSelected)
            {
                IsSelected = true;
                OnRaiseSelectedEvent(new SelectedEventArgs(_actionController.action()));
            }
        }
    }
}
