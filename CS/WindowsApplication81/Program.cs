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
using System.Windows.Forms;

namespace WindowsApplication81 {
    static class Program {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main() {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}