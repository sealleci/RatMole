using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RatMole
{
    public partial class helpform : Form
    {
        public helpform()
        {
            InitializeComponent();
        }

        private void helpform_Load(object sender, EventArgs e)
        {
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.MinimumSize = this.MaximumSize = this.Size;
        }
    }
}
