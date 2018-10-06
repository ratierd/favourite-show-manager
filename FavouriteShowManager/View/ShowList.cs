using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace FavouriteShowManager.View
{
    public partial class ShowList : UserControl
    {

        private List<ShowListItem> items;

        public ShowList(List<ShowListItem> itemList)
        {
            InitializeComponent();

            Dock = DockStyle.Fill;
            items = itemList;

            Controls.AddRange(items.ToArray());
        }

        public void filterList(List<Model.Show.ShowState> stateFilters)
        {
            if(stateFilters.Count == 0)
            {
                Controls.Clear();
                Controls.AddRange(items.ToArray());
            }
            else
            {
                List<ShowListItem> filteredItemList = new List<ShowListItem>();
                foreach(Model.Show.ShowState filter in stateFilters)
                {
                    filteredItemList.AddRange(items.FindAll(delegate (ShowListItem i)
                    {
                        return i.ShowItem.State == filter;
                    }));
                }
                Controls.Clear();
                Controls.AddRange(filteredItemList.ToArray());
            }
            Invalidate();
        }
        
    }
}
