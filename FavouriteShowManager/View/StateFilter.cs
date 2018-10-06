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
    public partial class StateFilter : UserControl
    {
        private List<Model.Show.ShowState> stateFilters;

        public StateFilter()
        {
            InitializeComponent();

            stateFilters = new List<Model.Show.ShowState>();

            filterLabel.ForeColor = System.Drawing.ColorTranslator.FromHtml("#eeeeee");
        }

        private void toSeeCheckBox_CheckStateChanged(object sender, EventArgs e)
        {
            if (toSeeCheckBox.Checked)
            {
                stateFilters.Add(Model.Show.ShowState.TO_SEE);
            }
            else
            {
                stateFilters.Remove(Model.Show.ShowState.TO_SEE);
            }
            OnRaiseFiltersChangedEvent(new FiltersChangedEventArgs(stateFilters));
        }

        private void seenCheckBox_CheckStateChanged(object sender, EventArgs e)
        {
            if (seenCheckBox.Checked)
            {
                stateFilters.Add(Model.Show.ShowState.SEEN);
            }
            else
            {
                stateFilters.Remove(Model.Show.ShowState.SEEN);
            }
            OnRaiseFiltersChangedEvent(new FiltersChangedEventArgs(stateFilters));
        }

        private void consideredCheckBox_CheckStateChanged(object sender, EventArgs e)
        {
            if (consideredCheckBox.Checked)
            {
                stateFilters.Add(Model.Show.ShowState.CONSIDERED);
            }
            else
            {
                stateFilters.Remove(Model.Show.ShowState.CONSIDERED);
            }
            OnRaiseFiltersChangedEvent(new FiltersChangedEventArgs(stateFilters));
        }

        public class FiltersChangedEventArgs : EventArgs
        {
            public FiltersChangedEventArgs(List<Model.Show.ShowState> l)
            {
                _filters = l;
            }
            private List<Model.Show.ShowState> _filters;
            public List<Model.Show.ShowState> Filters { get { return _filters; } }
        }

        public event EventHandler<FiltersChangedEventArgs> FiltersChanged;

        protected virtual void OnRaiseFiltersChangedEvent(FiltersChangedEventArgs e)
        {
            FiltersChanged?.Invoke(this, e);
        }
    }
}
