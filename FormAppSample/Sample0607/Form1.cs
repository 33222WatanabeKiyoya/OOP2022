using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sample0607 {
    public partial class 乱数アプリ : Form {

        Random rand = new Random();

        public 乱数アプリ() {
            InitializeComponent();
        }


        private void Form1_Load(object sender, EventArgs e) {


        }

        private void pb1_Click(object sender, EventArgs e) {

            Number.Value = rand.Next(minValue: (int)min.Value, maxValue: (int)max.Value);
        }

        private void min_TextChanged(object sender, EventArgs e) {

        }

        private void min_ValueChanged(object sender, EventArgs e) {

        }
    }
}