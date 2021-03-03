using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FootSquare
{
    public partial class FootSquare : Form
    {
        public FootSquare()
        {
            InitializeComponent();
        }
        
        private void btnConvert_Click(object sender, EventArgs e)
        {
            int A = Convert.ToInt32(tbFoot.Text);

            string B = Convert.ToString(Math.Sqrt(A) * 30.48 / 100 * (Math.Sqrt(A) * 30.48 / 100));
            
            lbAnswer.Text = B;
        }
    }
}
