using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConvertFileToBase64
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string userPath;
            userPath = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile) + "\\Desktop";
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.InitialDirectory = userPath;
            ofd.Filter = "html files (*.html)|*.txt|All files (*.*)|*.*";
            ofd.FilterIndex = 2;
            ofd.RestoreDirectory = true;
            ofd.ShowDialog();
            string fName = ofd.FileName;
            textBox1.Text = fName;
            //MessageBox.Show(fName);
            //ofd.OpenFile();
            var doc = File.ReadAllBytes(textBox1.Text);
            textBox2.Text = Convert.ToBase64String(doc);
            Clipboard.SetText(textBox2.Text);
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
