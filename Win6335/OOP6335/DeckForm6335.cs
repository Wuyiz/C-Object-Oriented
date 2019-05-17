using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Library6335;

namespace Win6335.OOP6335 {
    public partial class DeckForm6335 : Form {
        public DeckForm6335() {
            InitializeComponent();
        }

        private void btnShuffle_Click(object sender, EventArgs e) {
            Deck6335 deck = new Deck6335();
            deck.ShuffleDeck6335();
            textBox1.Text += deck.ToString() + "\r\n\r\n";
        }

        private void btnClear_Click(object sender, EventArgs e) {
            textBox1.Clear();
        }

        private void btnClose_Click(object sender, EventArgs e) {
            this.Close();
        }
    }
}
