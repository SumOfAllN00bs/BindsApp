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

namespace BindsApp
{
    public partial class Binds : Form
    {
        string fileName = "Binds.txt";
        public Binds()
        {
            InitializeComponent();
        }

        private void Binds_Load(object sender, EventArgs e)
        {
            string path = Directory.GetCurrentDirectory();
            string fullPath = Path.Combine(path, fileName);
            using (StreamReader fileStream = new StreamReader(fullPath))
            {
                txt_BindsDisplay.Text = fileStream.ReadToEnd();
            }
        }



        private void Binds_FormClosing(object sender, FormClosingEventArgs e)
        {
            string path = Directory.GetCurrentDirectory();
            string fullPath = Path.Combine(path, fileName);
            using (StreamWriter fileStream = new StreamWriter(fullPath))
            {
                fileStream.Write(txt_BindsDisplay.Text);
            }
        }
    }
}
