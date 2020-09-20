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
    public partial class auth : Form
    {
        public auth()
        {
            InitializeComponent();
        }
        public string key
        {
            get { return tbKey.Text; }
            set { tbKey.Text = value; }
        }
        public string token
        {
            get { return tbToken.Text; }
            set { tbToken.Text = value; }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
