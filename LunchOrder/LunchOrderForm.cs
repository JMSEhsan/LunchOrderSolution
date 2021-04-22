
//Ehsan Jalali  CPRG-006-001 RAD Concepts   Lab Asgmt-1: Lunch Order App    Team#1     Apr. 21, 2021

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LunchOrder
{
    public partial class LunchOrderForm : Form
    {
        const double Tax = 0.05;             //Tax, constant variable
        const double HamPrc = 6.95;          //Hamburger price, constant variable
        const double PizzaPrc = 5.95;        //Pizza price, constant variable
        const double SaladPrc = 4.95;        //Salad price, constant variable
        const double HamAddonPrc = 0.75;        //Hamburger add-on item price/each, constant variable
        const double PizzaAddonPrc = 0.5;       //Pizza add-on item price/each, constant variable
        const double SaladAddonPrc = 0.25;      //Salad add-on item price/each, constant variable
        double MainCoursePrc;                   //Main course price, variable
        double AddonPrc;                        //Add-on items price, variable
        int AddonCnt;                        //Number of add-on items, variable

        public LunchOrderForm()
        {
            InitializeComponent();

            HamPrice.Text = HamPrc.ToString("c");        //Display dynamic hamberger price
            PizzaPrice.Text = PizzaPrc.ToString("c");      //Display dynamic pizza price
            SaladPrice.Text = SaladPrc.ToString("c");      //Display dynamic salad price
            TaxPercent.Text = $"({Tax.ToString("p")}):";     //Display dynamic Tax %

            int indx = 0;
            if (indx == 0)
            {
                HamRBtn.Checked = true;                //Condition to select hamberger as main course at start
                indx = 1;
            }
        }

        private void HamRBtn_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton s = (RadioButton)sender;
            switch (s.Name)                                     //Switch-case used to assign the add-on items corresponding to the related main courses to click-boxes 
            {
                case "PizzaRBtn":
                    AddonGB.Text = $"Add-on items ({PizzaAddonPrc}/each)";
                    AddonBx1.Text = "Pepperoni";
                    AddonBx2.Text = "Sausage";
                    AddonBx3.Text = "Olives";

                    AddonPrc = PizzaAddonPrc;
                    MainCoursePrc = PizzaPrc;

                    break;

                case "SaladRBtn":
                    AddonGB.Text = $"Add-on items ({SaladAddonPrc}/each)";
                    AddonBx1.Text = "Croutons";
                    AddonBx2.Text = "Bacon bits";
                    AddonBx3.Text = "Bread sticks";

                    AddonPrc = SaladAddonPrc;
                    MainCoursePrc = SaladPrc;

                    break;

                default:
                    AddonGB.Text = $"Add-on items ({HamAddonPrc}/each)";
                    AddonBx1.Text = "Lettuce, tomato, and onions";
                    AddonBx2.Text = "Ketchup, mustard, and mayo";
                    AddonBx3.Text = "French fries";

                    AddonPrc = HamAddonPrc;
                    MainCoursePrc = HamPrc;

                    break;
            }
        }

        private void PlaceOrderBtn_Click(object sender, EventArgs e)                    //Button click handler to place order
        {
            switch (true)                                                               //Switch-case used to count selected add-on items 
            {
                case true when ((AddonBx1.Checked & !AddonBx2.Checked & !AddonBx3.Checked) ||
                (!AddonBx1.Checked & AddonBx2.Checked & !AddonBx3.Checked) ||
                (!AddonBx1.Checked & !AddonBx2.Checked & AddonBx3.Checked)):
                    AddonCnt = 1;
                    break;


                case true when ((AddonBx1.Checked & AddonBx2.Checked & !AddonBx3.Checked) ||
                (AddonBx1.Checked & !AddonBx2.Checked & AddonBx3.Checked) ||
                (!AddonBx1.Checked & AddonBx2.Checked & AddonBx3.Checked)):
                    AddonCnt = 2;
                    break;

                case true when (AddonBx1.Checked & AddonBx2.Checked & AddonBx3.Checked):
                    AddonCnt = 3;
                    break;

                default:
                    AddonCnt = 0;
                    break;
            }

            double SubTotal = MainCoursePrc + AddonCnt * AddonPrc;
            SubTTLLb.Text = $"     {SubTotal.ToString("c")}";                          //Calculate subtotal

            TaxLb.Text = $"     {  CalculateTax(SubTotal).ToString("c")}";               //Calculate tax
            OrderTTLLb.Text = $"     {CalculateOrderTTL(SubTotal).ToString("c")}";     //Calculate total price
        }
        private static double CalculateTax(double x)                    //Method to calculate tax
        {
            double xTax = 0.05 * x;
            return (xTax);
        }

        private static double CalculateOrderTTL(double x)               //Method to calculate order total price
        {
            double OrderTTL = 1.05 * x;
            return (OrderTTL);
        }

        private void ExitBtn_Click(object sender, EventArgs e)         //Button click handler to close the app
        {
            this.Close();
        }

        private void ResetBtn_Click(object sender, EventArgs e)             //Button click handler to reset the order form according to defined requirements
        {
            HamRBtn.Checked = true;
            PizzaRBtn.Checked = false;
            SaladRBtn.Checked = false;

            AddonBx1.Checked = false;
            AddonBx2.Checked = false;
            AddonBx3.Checked = false;

            SubTTLLb.Text = "";
            TaxLb.Text = "";
            OrderTTLLb.Text = "";
        }

        private void button3_KeyDown(object sender, KeyEventArgs e)    //KeyDown handler to exit by pressing Alt + x
        {

            if (e.Alt && e.KeyCode == Keys.X)
            {
                Application.Exit();
            }
        }

        private void button1_KeyDown(object sender, KeyEventArgs e)    //KeyDown handler to place order by pressing Alt + p
        {

            if (e.Alt && e.KeyCode == Keys.X)
            {
                Application.Run();
            }
        }

        private void button2_KeyDown(object sender, KeyEventArgs e)   //KeyDown handler to reset the form by pressing Alt + r
        {

            if (e.Alt && e.KeyCode == Keys.X)
            {
                HamRBtn.Checked = true;
                PizzaRBtn.Checked = false;
                SaladRBtn.Checked = false;

                AddonBx1.Checked = false;
                AddonBx2.Checked = false;
                AddonBx3.Checked = false;

                SubTTLLb.Text = "";
                TaxLb.Text = "";
                OrderTTLLb.Text = "";
            }
        }
    }
}