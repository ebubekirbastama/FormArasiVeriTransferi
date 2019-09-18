using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormArasiVeriTransferi
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        public static string veri = "";
        private void Form2_Load(object sender, EventArgs e)
        {
            for (int i = 0; i <50; i++)
            {
                listBox1.Items.Add(i+"!'+&/&)(&/sfdv Sdfds"+i);
            }
        }

        private void listBox1_MouseDown(object sender, MouseEventArgs e)
        {
            veri = listBox1.Items[listBox1.SelectedIndex].ToString();
            Close();
        }
    }
}
