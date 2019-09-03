using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace taller_3._3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnenviar_Click(object sender, EventArgs e)
        {
            int num1, num2;
            num1 = int.Parse(txtnumero1.Text);
            num2 = int.Parse(txtnumero2.Text);

            if (num1 > num2)
            {

                lblmayor.Text = num1.ToString();
                lblmenor.Text = num2.ToString();

                lblmayor.Visible = true;
                lblmenor.Visible = true;
            }
            else
             if(num2>num1)
            {

                lblmayor.Text = num2.ToString();
                lblmenor.Text = num1.ToString();

                lblmayor.Visible = true;
                lblmenor.Visible = true;
            }
             else
                  if (num1 == num2)
            {

                MessageBox.Show("Ambos numeros son iguales.");

                lblmayor.Visible = false;
                lblmenor.Visible = false;

            }




        }

        
    }

}