using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MoveEstimator
{
    public partial class MoveEstimator : Form
    {
        public MoveEstimator()
        {
            InitializeComponent();
        }

        private void btnEstimate_Click(object sender, EventArgs e)
        {
            int numOfHours, numOfMiles;
            int movingCost;

            numOfHours = Convert.ToInt32(txtHours.Text);
            numOfMiles = Convert.ToInt32(txtMiles.Text);

            movingCost = 200 + 150 * numOfHours + 2 * numOfMiles;
            lblResult.Text = "The estimated cost is: "+ movingCost.ToString("C2");

        }
    }
}
