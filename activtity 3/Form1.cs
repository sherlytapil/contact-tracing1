using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace activtity_3
{
    public partial class Form1 : Form
    {
        private object textBox;

        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void File_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Title = "Select File";
            openFileDialog.InitialDirectory = @"C:\";//- -"C:\\";
            openFileDialog.Filter = "All files (*.*)|*.*|Text File(*.txt)|*.txt";
            openFileDialog.FilterIndex = 1;
            openFileDialog.ShowDialog();
            if (openFileDialog.FileName !="")
            { textBox = openFileDialog.FileName; }
            else
            { textBox = "You didn't select the file"; }
        }
    }
}
