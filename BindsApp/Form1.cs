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
    public partial class Form1 : Form
    {
        string fileName = "Binds.txt";
        public Form1()
        {
            InitializeComponent();
            Initialize();
        }

        public void Initialize()
        {
            string path = Directory.GetCurrentDirectory();
            string fullPath = Path.Combine(path, fileName);
            using (StreamReader fileStream = new StreamReader(fullPath))
            {
                sc_BindsList.Panel2.Controls.Clear();
                int top = 5;
                int left = 5;
                int controls = 0;
                while (!fileStream.EndOfStream)
                {
                    Button tmpButton = new Button();
                    string tmpText = fileStream.ReadLine();
                    tmpButton.Text = tmpText;
                    tmpButton.Click += (o, e) => { PutTextIntoClipboard(tmpText); };
                    tmpButton.Top = top + ((controls / 3) * tmpButton.Height);
                    tmpButton.Left = left + ((controls % 3) * 100);
                    controls++;
                    sc_BindsList.Panel2.Controls.Add(tmpButton);
                }
            }

        }
        public void PutTextIntoClipboard(string s)
        {
            Clipboard.SetDataObject(s);
        }
        private void btn_Refresh_Click(object sender, EventArgs e)
        {
            Initialize();
        }

        private void btn_Binds_Click(object sender, EventArgs e)
        {
            Binds binds = new Binds();
            binds.ShowDialog();
            Initialize();
        }
    }
}
