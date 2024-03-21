using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MLdemo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void buttonDection_Click(object sender, EventArgs e)
        {
            //Load sample data
            var sampleData = new MLModel1.ModelInput()
            {
                Message = richTextBoxInputEmail.Text,
            };

            //Load model and predict output
            var result = MLModel1.Predict(sampleData);
            textBoxresult.Text = result.PredictedLabel.ToString();
            labelspam.Text = (result.Score[1]*100).ToString("#0.00");
            labelnotspam.Text = (result.Score[0] * 100).ToString("#0.00");
        }

        private void richTextBoxInputEmail_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
