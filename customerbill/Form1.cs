using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

// app to calculate the Power consumption bill
// Author: Layth Al-shareefi
// date: April- 2020

namespace customerbill
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            // set the Residential radio button to true when the Application start
            radResidential.Checked = true;

        }



        const string path = "CustomerData.txt"; // on the debug folder
        List<CustomerData> datas = new List<CustomerData>();


        // assign the application constants

        const double RES_FLAT_RATE = 6.00;
        const double COMM_FLAT_RATE = 60.00;
        const double IND_FLAT_OFF_RATE = 40.00;
        const double IND_FLAT_RATE = 76.00;
        const double RES_CHA_RATE = 0.052;
        const double COMM_CHA_RATE = 0.045;
        const double IND_CHA_OFF_RATE = 0.028;
        const double IND_CHA_RATE = 0.065;

        // methode to show the residential plan information
        private void radResidential_CheckedChanged(object sender, EventArgs e)
        {
            type = "R";
            pnlOffPeak.Visible = false;


            lblw1.Text = "KWH Used";
            lbl1.Text = "Please Enter How Many KWH was Used";

        }

        string type = "";
        // methode to show the commercial plan information
        private void radCommercial_CheckedChanged(object sender, EventArgs e)
        {
            type = "C";
            pnlOffPeak.Visible = false;
            pnlCalculated.Visible = false;
            txtKWH.Text = "";


            lbl1.Text = "Please Enter How Many KWH was Used";
        }

        // methode to show the industerial  plan information
        private void radIndustrial_CheckedChanged(object sender, EventArgs e)
        {
            type = "I";
            pnlOffPeak.Visible = true;
            txtKWH.Text = "";


            lblw1.Text = "KWH Used in Peak Hours";
            lbl1.Text = "Type here Only KWH Used in peak hours";

        }

        // Calculate button methode
        private void btnCalculate_Click(object sender, EventArgs e)
        {

            if (Validator.IsNonNegativeInteger(txtCNumber, lblNumber.Text) &&
                Validator.IsPresent(txtName, lblName.Text) &&
                Validator.IsPresent(txtKWH, lblw1.Text) &&
                Validator.IsNonNegativeInteger(txtKWH, lblw1.Text)
               )
            {
                double KWH = Convert.ToDouble(txtKWH.Text);
                if (radResidential.Checked == true)
                {
                    residental(KWH, out double rate);
                    outPut(rate);

                }

                else if (radCommercial.Checked == true)
                {
                    Commercial(KWH, out double rate);
                    outPut(rate);

                }


                if (radIndustrial.Checked == true)
                {
                    if (Validator.IsNonNegativeInteger(txtCNumber, lblNumber.Text) &&
                        Validator.IsPresent(txtName, lblName.Text) &&
                        Validator.IsPresent(txtKWH2, lblw2.Text) &&
                        Validator.IsNonNegativeInteger(txtKWH2, lblw2.Text)
                        )
                    {

                        double KWHOffPeak = Convert.ToDouble(txtKWH2.Text);
                        IndusterialPeak(KWH, out double rate);
                        IndusterialOffPeak(KWHOffPeak, out double rateOff);
                        double totalRate = rate + rateOff;
                        txtCalculated.Text = totalRate.ToString("c");
                        pnlCalculated.Visible = true;

                    }
                }

                void outPut(double rate)
                {
                    txtCalculated.Text = rate.ToString("c");
                    pnlCalculated.Visible = true;
                }
            }

        }

        // methode to calculate the Residental  bill
        private void residental(double KWH, out double rate)
        {
            rate = KWH * RES_CHA_RATE + RES_FLAT_RATE;
        }

        // methode to caculate the Commercial bill
        private void Commercial(double KWH, out double rate)
        {
            if (KWH < 1000)
            {
                rate = COMM_FLAT_RATE;
            }
            else
            {
                rate = COMM_FLAT_RATE + ((KWH - 1000) * COMM_CHA_RATE);
            }
        }
        //methode to Calculate the Industerial Peak-hours bill
        private void IndusterialPeak(double KWH, out double rate)
        {
            if (KWH < 1000)
            {
                rate = IND_FLAT_RATE;
            }
            else
            {
                rate = IND_FLAT_RATE + ((KWH - 1000) * IND_CHA_RATE);
            }
        }

        // methode to Calcute the Indestrial Off-peak hours
        private void IndusterialOffPeak(double KWHOffPeak, out double rateOff)
        {
            if (KWHOffPeak < 1000)
            {
                rateOff = IND_FLAT_OFF_RATE;
            }
            else
            {
                rateOff = IND_FLAT_OFF_RATE + ((KWHOffPeak - 1000) * IND_CHA_OFF_RATE);
            }
        }

        // Reset key Methode
        private void btnReset_Click(object sender, EventArgs e)
        {
            pnlCalculated.Visible = false;
            txtCalculated.Text = "";
            radResidential.Checked = true;
            txtKWH.Text = "";
            txtCNumber.Text = "";
            txtName.Text = "";
        }

        // Exit Button Methode

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            FileStream fs;
            StreamReader sr = null;
            string line;   // for reading
            string[] fields;   // line broken to field
            CustomerData data;
            int number;
            string name;
            string type;
            double charge;


            try
            {
                fs = new FileStream(path, FileMode.OpenOrCreate, FileAccess.Read);
                sr = new StreamReader(fs);
                // read the file 
                while (!sr.EndOfStream)
                {
                    line = sr.ReadLine();   // read next line
                    fields = line.Split(',');   // cvs file

                    name = fields[0];
                    type = fields[1];
                    charge = Convert.ToDouble(fields[2]);
                    number = Convert.ToInt32(fields[3]);
                    data = new CustomerData(number, name, type, charge);
                    datas.Add(data);

                }
                DisplayProduct();
            }
            catch (Exception ex)
            {
                MessageBox.Show("error Reading the File:" + ex.Message, ex.GetType().ToString());
            }
            finally
            {
                if (sr != null) sr.Close();
            }
        }


        private double CalculateTotalCharge()
        {
            double total = 0;
            foreach (CustomerData d in datas)
            {
                total += d.chargeAmount();
            }
            return total;
        }

        // Calculate the total Residential amount
        private double CalculateTotalResidential()
        {
            double total = 0;
            foreach (CustomerData d in datas)
            {
                if (d.Type == "R")
                {
                    total += d.chargeAmount();
                }

            }
            return total;
        }


        // calculate the total Commercial amount

        private double CalculateTotalCommercial()
        {
            double total = 0;
            foreach (CustomerData d in datas)
            {
                if (d.Type == "C")
                {
                    total += d.chargeAmount();
                }

            }
            return total;
        }


        // calculate total Industrial

        private double CalculateTotalIndustrial()
        {
            double total = 0;
            foreach (CustomerData d in datas)
            {
                if (d.Type == "I")
                {
                    total += d.chargeAmount();
                }

            }
            return total;
        }


        // Display methode
        private void DisplayProduct()
        {

            // list box

            lstCustomer.Items.Clear();
            foreach (CustomerData d in datas)
            {
                lstCustomer.Items.Add(d);
            }

            // labels
            lblCustomer.Text = datas.Count.ToString();

            double totalCharge = CalculateTotalCharge();
            lblCamount.Text = totalCharge.ToString("c");

            double totalResidentail = CalculateTotalResidential();
            lblRamount.Text = totalResidentail.ToString("c");

            double totalCommercial = CalculateTotalCommercial();
            lblCOamount.Text = totalCommercial.ToString("c");

            double totalIndustrial = CalculateTotalIndustrial();
            lblIamount.Text = totalIndustrial.ToString("c");

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (txtCalculated.Text != "")
            {
                int number;
                string name;
                double charge;
                CustomerData newCustomer;
                // collect new product data and create an object

                number = Convert.ToInt32(txtCNumber.Text);
                name = txtName.Text;
                charge = Convert.ToDouble(txtCalculated.Text.Trim('$'));

                newCustomer = new CustomerData(number, name, type, charge);

                //add new product to the list 

                datas.Add(newCustomer);

            }
            else
            {
                MessageBox.Show("Bill should be calculated First, Press Calculate", "Error to Add");
            }
            txtCalculated.Text = "";
            DisplayProduct();


        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            // open the file for writting 
            FileStream fs;
            StreamWriter sw = null;

            try
            {
                fs = new FileStream(path, FileMode.Create, FileAccess.Write);
                sw = new StreamWriter(fs);
                string line;


                foreach (CustomerData d in datas)
                {
                    line = d.Name + ',' + d.Type + ',' + d.Charge + ',' + d.Number;
                    sw.WriteLine(line);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("error While saving" + ex.Message, ex.GetType().ToString());
            }
            finally
            {
                if (sw != null)
                {
                    sw.Close();
                }
            }


        }
    }
}

