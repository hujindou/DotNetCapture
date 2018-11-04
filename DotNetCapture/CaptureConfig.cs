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

namespace DotNetCapture
{
    public partial class CaptureConfig : Form
    {
        public CaptureConfig()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (var fbd = new FolderBrowserDialog())
            {
                DialogResult result = fbd.ShowDialog();

                if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(fbd.SelectedPath))
                {
                    textBox1.Text = fbd.SelectedPath;
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            panel1.Enabled = true;
            button3.Enabled = true;
            button2.Enabled = false;

            Program.isSetOk = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(textBox1.Text))
                return;

            if (comboBox1.SelectedItem == null || comboBox2.SelectedItem == null || comboBox1.SelectedItem.ToString() == comboBox2.SelectedItem.ToString())
            {
                return;
            }


            panel1.Enabled = false;
            button3.Enabled = false;
            button2.Enabled = true;

            Program.isSetOk = true;
            Program.SavePath = textBox1.Text;
            Program.KeyFullScreen = c(comboBox1.SelectedItem.ToString());
            Program.KeyActiveWindow = c(comboBox2.SelectedItem.ToString());

        }

        private Keys c(string p)
        {
            if (p == "F1")
            {
                return Keys.F1;
            }
            else if (p == "F2")
            {
                return Keys.F2;
            }
            else if (p == "F3")
            {
                return Keys.F3;
            }
            else if (p == "F4")
            {
                return Keys.F4;
            }
            else if (p == "F5")
            {
                return Keys.F5;
            }
            else if (p == "F6")
            {
                return Keys.F6;
            }
            else if (p == "F7")
            {
                return Keys.F7;
            }
            else if (p == "F8")
            {
                return Keys.F8;
            }
            else if (p == "F9")
            {
                return Keys.F9;
            }
            else if (p == "F10")
            {
                return Keys.F10;
            }
            else if (p == "F11")
            {
                return Keys.F11;
            }

            return Keys.F12;
        }

        private void CaptureConfig_Load(object sender, EventArgs e)
        {
            button2_Click(null, null);
        }

        //private void CaptureConfig_FormClosing(object sender, FormClosingEventArgs e)
        //{
        //    e.Cancel = true;
        //    this.WindowState = FormWindowState.Minimized;
        //}

        

        //protected override CreateParams CreateParams
        //{
        //    get
        //    {
        //        var Params = base.CreateParams;
        //        Params.ExStyle |= 0x80;
        //        return Params;
        //    }
        //}
    }
}
