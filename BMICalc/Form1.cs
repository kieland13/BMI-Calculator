using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BMICalc
{
   public partial class Form1 : Form
   {
      double height;
      double weight;
      double results;

      public Form1()
      {
         InitializeComponent();
      }

      private void btncalc_Click(object sender, EventArgs e)
      {
        
         height = Double.Parse(txtHeight.Text);
         weight = Double.Parse(txtWeight.Text);

         results = (weight * 703) / (height * height);

         txtResults.Text = String.Format("{0:F}", results);
      }

      private void btnclear_Click(object sender, EventArgs e)
      {
         txtHeight.Text = "";
         txtWeight.Text = "";
         txtResults.Text = "";
      }

      private void btnexit_Click(object sender, EventArgs e)
      {
         Close();
      }
   }
}
