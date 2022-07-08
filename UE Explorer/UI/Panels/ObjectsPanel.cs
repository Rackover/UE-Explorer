using System.Linq;
using System.Windows.Forms;
using UELib;

namespace UEExplorer.UI.Panels
{
    public partial class ObjectsPanel : UserControl
    {
        public ObjectsPanel()
        {
            InitializeComponent();
        }

        public void InitializeTree(UnrealPackage package)
        {
            ObjectListView.CanExpandGetter = x => true;
            ObjectListView.ChildrenGetter = (x) =>
            {
                return package.Objects
                    .Where(obj => obj.Outer == x);
            };
            ObjectListView.SetObjects(package.Objects
                .Where(obj => obj.Outer == null));
        }
    }
}
