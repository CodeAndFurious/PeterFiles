using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace SanityArchiver.Model
{
    class DirectoryItemModel
    {
       

        private ObservableCollection<DriveInfo> drivesInfos = new ObservableCollection<DriveInfo>
            (Environment.GetLogicalDrives().Select(drive => new DriveInfo(drive)));
    


        public ObservableCollection<DriveInfo> DrivesInfos
        {
            get { return drivesInfos; }
        }

        public DirectoryItemModel(DriveInfo driveInfo)
        {
        }

    }
}
