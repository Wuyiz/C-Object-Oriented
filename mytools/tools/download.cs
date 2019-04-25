using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace mytools.tools {
    public partial class download : Form {
        public download() {
            InitializeComponent();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnTrans_Click(object sender, EventArgs e) {

            string thunder = $@"{tbLink1.Text}".Replace("thunder://","");

            string realAddress = DecodeBase64(thunder);

            realAddress = Regex.Replace(realAddress, @"^AA|ZZ$", string.Empty);

            tbLink2.Text = realAddress;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="link"></param>
        /// <returns></returns>
        public static string DecodeBase64 (string link) {
            string realAddress = "";

            try {
                byte[] bytes = Convert.FromBase64String(link);
                realAddress = Encoding.Default.GetString(bytes);

            } catch (Exception) {
                realAddress = link;
            }
            return realAddress;
        }
    }
}
