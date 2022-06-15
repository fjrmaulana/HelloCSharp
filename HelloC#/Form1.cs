using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;



namespace csharp_hello_world_example
{
    public partial class Form1 : Form
    {
        CancellationTokenSource tokenSource = new CancellationTokenSource();

        public Form1()
        {
            InitializeComponent();
        }

             
        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hello c#");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
