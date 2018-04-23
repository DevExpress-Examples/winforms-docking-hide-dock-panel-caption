// Developer Express Code Central Example:
// How to completely hide the dock panel's caption?
// 
// By setting the DockManager.DockingOptions.ShowCaptionOnMouseHover property it's
// possible to set whether the dock panel's caption is shown only when the mouse
// pointer hovers over the panel's top or all the time. This example demonstrates
// how to prevent the dock panel's caption from being shown for an individual dock
// panel all the time.
// 
// You can find sample updates and versions for different programming languages here:
// http://www.devexpress.com/example=E1940

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraBars.Docking;
using DevExpress.XtraBars.Docking.Helpers;

namespace WindowsApplication81
{
    public class CustomDockPanel : DockPanel
    {
        public CustomDockPanel()
            : this(false, DockingStyle.Float, null)
        {
        }
        public CustomDockPanel(bool createControlContainer, DockingStyle dock, DockManager dockManager)
            : base(createControlContainer, dock, dockManager)
        {
            DockLayout = new CustomDockLayout(dock, this);
        }

        //// Fields...

        private bool _ShowCaption = true;

        public bool ShowCaption
        {
            get { return _ShowCaption; }
            set
            {
                if (_ShowCaption != value)
                {
                    _ShowCaption = value;
                    DockLayout.LayoutChanged();
                }
            }
        }

        CustomDockLayout DockLayout
        {
            get { return base.DockLayout as CustomDockLayout; }
            set { base.DockLayout = value; }
        }
    }
}
