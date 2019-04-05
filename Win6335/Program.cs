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
            Application.Run(new Win6335.DateTimeForm());
        }
    }
}
