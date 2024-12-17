using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Saved successfully", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void Form1_Resize(object sender, EventArgs e)
        {
            // Reposition buttonSave on form resize
            this.buttonSave.Location = new System.Drawing.Point(
                this.ClientSize.Width - this.buttonSave.Width - 20,
                this.ClientSize.Height - this.buttonSave.Height - 20
            );
        }
        private void panelBottom_Resize(object sender, EventArgs e)
        {
            // Reposition buttonSave within panelBottom on resize
            this.buttonSave.Location = new System.Drawing.Point(
                this.panelBottom.Width - this.buttonSave.Width - 20,
                this.panelBottom.Height - this.buttonSave.Height - 10
            );
        }


    }
}
