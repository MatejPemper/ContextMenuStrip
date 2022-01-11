using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ContextMenuStrip
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

       

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }
        private void leftToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            if(txtLeft.Text == string.Empty)
            { 
                MessageBox.Show("PRAZNO!","UPIS", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                txtLeft.Text = txtRight.Text;
                txtRight.Clear();
            }
        }

        private void txtRight_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void rightToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
            if (txtLeft.Text ==string.Empty)
            {
                MessageBox.Show("PRAZNO!","UPISI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                txtRight.Text = txtLeft.Text;
                txtLeft.Clear();
            }
        }
    }
}
