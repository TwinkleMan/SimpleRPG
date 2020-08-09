using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI
{
    public partial class SuperAdventure : Form
    {
        public SuperAdventure()
        {
            InitializeComponent();
        }

        private void btnTest_Click(object sender, EventArgs e)
        {
            lblExperience.Text = "999";
            lblGold.Text = "-2222";
            lblHitPoints.Text = "24";
            lblLevel.Text = "9";
        }
    }
}
