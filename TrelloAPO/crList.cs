using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TrelloAPO
{
    public partial class crList : Form
    {
        public crList()
        {
            InitializeComponent();
        }
        public string name
        {
            get { return textBox1.Text; }
            set { textBox1.Text = value; }
        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
