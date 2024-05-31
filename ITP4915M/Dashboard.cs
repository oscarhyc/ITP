using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ITP4915M
{
    
    public partial class Dashboard : Form
    {
        List<Panel> listPanel = new List<Panel>();
        public Dashboard()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            panel4.BringToFront();
        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
