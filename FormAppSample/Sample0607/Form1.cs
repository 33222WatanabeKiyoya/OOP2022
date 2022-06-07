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
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e) {
            
        }

        private void Form1_Load(object sender, EventArgs e) {

        }

        private void button1_Click(object sender, EventArgs e) {

            if (int.Parse(tbNum2.Text) != 0) {

                tbAns.Text = (int.Parse(tbNum1.Text) / int.Parse(tbNum2.Text)).ToString();
                tbMod.Text = (int.Parse(tbNum1.Text) % int.Parse(tbNum2.Text)).ToString();

            }

            else {

                MessageBox.Show("エラー", "エラー",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error);
                
            }
        }
    }
}