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
    public class CustomDockManager : DockManager
    {
        public CustomDockManager() : base() { }
        public CustomDockManager(ContainerControl form) : base(form) { }
        public CustomDockManager(IContainer container) : base(container) { }
        protected override DockPanel CreateDockPanel(DockingStyle dock, bool createControlContainer)
        {
            return new CustomDockPanel(createControlContainer, dock, this);
        }
    }
}
