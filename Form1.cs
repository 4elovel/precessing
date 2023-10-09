using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace precessing
{
    public partial class Form1 : Form
    {
        private Process process;
        public Form1()
        {
            InitializeComponent();

            

        }

        private void button1_Click(object sender, EventArgs e)
        {
            process = new Process();
            process.StartInfo.FileName = "notepad.exe";
            process.Start();
            button2.Enabled = true;
            button1.Enabled = false;



        }


        private void button2_Click_1(object sender, EventArgs e)
        {
            
            process.Kill();
            button1.Enabled = true;
            button2.Enabled = false;

        }
    }
}
