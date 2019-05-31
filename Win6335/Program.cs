using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Win6335 {
    static class Program {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main() {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            //Application.Run(new Win6335.BaseForm6335());
            //Application.Run(new Win6335.ListForm6335());
            //Application.Run(new Win6335.DateTimeForm());
            //Application.Run(new Win6335.EditorForm6335());
            //Application.Run(new Win6335.MessageBoxForm6335());
            //Application.Run(new Win6335.ArrayForm());
            //Application.Run(new Win6335.CloseForm6335());
            //Application.Run(new Win6335.ControlsForm6335());
            //Application.Run(new Win6335.FileIO6335.EncodingForm6335());
            //Application.Run(new Win6335.FileIO6335.FileSystemWatcherForm6335());

            //Application.Run(new GDI6335.LineForm6335());
            //Application.Run(new GDI6335.PieForm6335());
            //Application.Run(new GDI6335.StarForm6335());
            //Application.Run(new GDI6335.CheckCodeForm6335());
            //Application.Run(new GDI6335.SinxForm6335());

            //Application.Run(new OOP6335.BigNumForm6335());
            //Application.Run(new OOP6335.ComplexForm6335());
            //Application.Run(new OOP6335.TypeForm6335());
            //Application.Run(new OOP6335.LINQForm6335());
            //Application.Run(new OOP6335.DeckForm6335());
            //Application.Run(new OOP6335.DelegateForm6335());
            //Application.Run(new OOP6335.WaterBoiledForm6335());

            Application.Run(new MainForm6335());
        }
    }
}
