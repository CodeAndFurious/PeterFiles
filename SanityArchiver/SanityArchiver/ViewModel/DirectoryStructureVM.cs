using SanityArchiver.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace SanityArchiver.ViewModel
{
    class DirectoryStructureVM
    {
        private ObservableCollection<TreeViewItem> directoryTreeViewItems = new ObservableCollection<TreeViewItem>();

        public ObservableCollection<TreeViewItem> DirectoryTreeViewItems { get => directoryTreeViewItems; set => directoryTreeViewItems = value; }

        private DirectoryItemModel drives = new DirectoryItemModel();

        

    }
}
