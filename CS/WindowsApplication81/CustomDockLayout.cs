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
    public class CustomDockLayout : DockLayout
    {
        public CustomDockLayout(DockingStyle dock, DockPanel panel) : base(dock, panel) { }
        public CustomDockLayout(DockingStyle dock, Size size, DockPanel panel) : base(dock, size, panel) { }
        protected override bool HasCaption
        {
            get
            {
                bool hasCaption = base.HasCaption;
                CustomDockPanel dockPanel = Panel as CustomDockPanel;
                return dockPanel.ShowCaption && hasCaption;
              // return base.HasCaption;
            }
        }

        public new CustomDockManager DockManager
        {
            get { return base.DockManager as CustomDockManager; }
        }

        internal void LayoutChanged()
        {
            base.LayoutChanged();
        }
    }
}
