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
//ToDo: Optimize scrolling and control recycling
//ToDo: Keyboard Shortcuts
//ToDo: Minimize to tray

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
                flp_Buttons.Controls.Clear();
                int controls = 0;
                while (!fileStream.EndOfStream)
                {
                    Button tmpButton = new Button();
                    tmpButton.AutoSize = true;
                    string tmpText = fileStream.ReadLine();
                    tmpButton.Text = tmpText;
                    controls++;
                    tmpButton.Click += (o, e) => { PutTextIntoClipboard(tmpText,tmpButton.Width); };
                    flp_Buttons.Controls.Add(tmpButton);
                }
            }
        }
        public void PutTextIntoClipboard(string s, int width)
        {
            Clipboard.SetDataObject(s);
            MessageBox.Show(width.ToString());
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
