using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BMICalculator.View;
using BMICalculator.Presenter;
namespace BMICalculator
{
    public partial class BMICalculator : Form, IPersonView
    {
        public BMICalculator()
        {
            InitializeComponent();
        }

        public string Height
        {
            get
            {
                return txtHeight.Text;
            }
            set
            {
                Height = txtHeight.Text;
            }
        }

        public string Weight
        {
            get
            {
                return txtWeight.Text;
            }
            set
            {
                txtWeight.Text = value;
            }
        }

        public int Gender
        {
            get
            {
                return rbGenderMale.Checked ? 1 : 2;
            }
            set
            {
                 var val = rbGenderMale.Checked ? 1 : 2;
                 val = value;
            }
        }

        public string BMIIndex
        {
            get
            {
                
                return lblBMI.Text;
            }
            set
            {
                lblResult.Text = "Your BMI is";
                lblBMI.Text = value;
            }
        }

        public string Comment
        {
            get
            {
                return lblResultComment.Text;
            }
            set
            {
                lblResultComment.Text = value;
            }
        }
        private void btnCalculate_Click(object sender, EventArgs e)
        {
            PersonPresenter pp = new PersonPresenter(this);
            pp.IzracunajBMI();
        }

        private void lblResult_Click(object sender, EventArgs e)
        {

        }

        private void gbResult_Enter(object sender, EventArgs e)
        {

        }

        private void BMICalculator_Load(object sender, EventArgs e)
        {

        }
    }
}
