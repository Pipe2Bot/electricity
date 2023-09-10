namespace electricity
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            lblname.Text = "";
            lblcost.Text = "";
            lbshowname.Visible = false;
            lbelec.Visible = false;
            lblvoltage.Visible = false;
            tbvoltage.Visible = false;
            lbldemand.Visible = false;
            tbdemand.Visible = false;
            bgsub.Visible = false;

        }


        private void bttcal_Click(object sender, EventArgs e)
        {
            if (tbname.Text != "" && tbunit.Text != "" && ddlmain.Text != "")
            {
                lbshowname.Visible = false;
                lbelec.Visible = false;
                bgsub.Visible = false;
                double unit, cost, costv;

                unit = 0;
                unit = Convert.ToDouble(tbunit.Text);
                if (ddlmain.SelectedIndex == 0)
                {
                    if (unit > 150)
                    {
                        double x1, x2, plus = 38.22;

                        x1 = 150 * 3.2484;
                        x2 = 250 * 4.2218;
                        if (unit >= 400)
                        {
                            cost = (((unit - 400) * 4.4217) + x1 + x2) + plus;
                            costv = cost * 1.07;
                            lbshowname.Visible = true;
                            lbelec.Visible = true;
                            lblcost.Text = Convert.ToString(costv) + " THB";
                            lblname.Text = tbname.Text;
                            bgsub.Visible = true;
                        }
                        else if (unit >= 151)
                        {
                            cost = (((unit - 150) * 4.2218) + x1) + plus;
                            costv = cost * 1.07;
                            lbshowname.Visible = true;
                            lbelec.Visible = true;
                            lblcost.Text = Convert.ToString(costv) + " THB";
                            lblname.Text = tbname.Text;
                            bgsub.Visible = true;
                        }

                    }
                    else
                    {
                        double x1, x2, x3, x4, plus = 8.19;
                        x1 = 15 * 2.3488;
                        x2 = 10 * 2.9882;
                        x3 = 10 * 3.2405;
                        x4 = 65 * 3.6237;
                        if (unit >= 101)
                        {
                            cost = (((unit - 100) * 3.7171) + x1 + x2 + x3 + x4 + plus);
                            costv = cost * 1.07;
                            lbshowname.Visible = true;
                            lbelec.Visible = true;
                            lblcost.Text = Convert.ToString(costv) + " THB";
                            lblname.Text = tbname.Text;
                            bgsub.Visible = true;
                        }
                        else if (unit >= 36)
                        {
                            cost = (((unit - 35) * 3.6237) + x1 + x2 + x3 + plus);
                            costv = cost * 1.07;
                            lbshowname.Visible = true;
                            lbelec.Visible = true;
                            lblcost.Text = Convert.ToString(costv) + " THB";
                            lblname.Text = tbname.Text;
                            bgsub.Visible = true;
                        }
                        else if (unit >= 26)
                        {
                            cost = (((unit - 25) * 3.2405) + x1 + x2 + plus);
                            costv = cost * 1.07;
                            lbshowname.Visible = true;
                            lbelec.Visible = true;
                            lblcost.Text = Convert.ToString(costv) + " THB";
                            lblname.Text = tbname.Text;
                            bgsub.Visible = true;
                        }
                        else if (unit >= 16)
                        {
                            cost = (((unit - 15) * 2.9882) + x1 + plus);
                            costv = cost * 1.07;
                            lbshowname.Visible = true;
                            lbelec.Visible = true;
                            lblcost.Text = Convert.ToString(costv) + " THB";
                            lblname.Text = tbname.Text;
                            bgsub.Visible = true;
                        }
                        else
                        {
                            cost = ((unit * 2.3488) + plus);
                            costv = cost * 1.07;
                            lbshowname.Visible = true;
                            lbelec.Visible = true;
                            lblcost.Text = Convert.ToString(costv) + " THB";
                            lblname.Text = tbname.Text;
                            bgsub.Visible = true;
                        }
                    }
                }
                else if (ddlmain.SelectedIndex == 1)
                {
                    double volt, plus = 312.24, x1 = 3.1751, x2 = 3.1471, x3 = 3.1097, demand;
                    double y1 = 221.50, y2 = 196.26, y3 = 175.70;


                    if (tbname.Text != "" && tbunit.Text != "" && ddlmain.Text != "" && tbdemand.Text != "" && tbvoltage.Text != "")
                    {
                        volt = Convert.ToDouble(tbvoltage.Text);
                        demand = Convert.ToDouble(tbdemand.Text);


                        if (volt >= 69)
                        {
                            cost = (demand * y3) + (unit * x3) + plus;
                            costv = cost * 1.07;
                            lbshowname.Visible = true;
                            lbelec.Visible = true;
                            lblcost.Text = Convert.ToString(costv) + " THB";
                            lblname.Text = tbname.Text;
                            bgsub.Visible = true;
                        }
                        else if (volt >= 22 && volt <= 33)
                        {
                            cost = (demand * y2) + (unit * x2) + plus;
                            costv = cost * 1.07;
                            lbshowname.Visible = true;
                            lbelec.Visible = true;
                            lblcost.Text = Convert.ToString(costv) + " THB";
                            lblname.Text = tbname.Text;
                            bgsub.Visible = true;
                        }
                        else if (volt < 22)
                        {
                            cost = (demand * y1) + (unit * x1) + plus;
                            costv = cost * 1.07;
                            lbshowname.Visible = true;
                            lbelec.Visible = true;
                            lblcost.Text = Convert.ToString(costv) + " THB";
                            lblname.Text = tbname.Text;
                            bgsub.Visible = true;
                        }
                        else
                        {
                            lblname.Text = "";
                            lblcost.Text = "";
                            lbshowname.Visible = false;
                            lbelec.Visible = false;
                            MessageBox.Show("Invalid voltage input");
                            bgsub.Visible = false;

                        }
                    }
                    else
                    {
                        MessageBox.Show("Incomplete input" + "\n" + "plese check your input" + "\n" + "and try again");
                    }

                }
                else if (ddlmain.SelectedIndex == 2)
                {
                    double plus = 312.24, plus22 = 20.00, volt;
                    if (tbname.Text != "" && tbunit.Text != "" && ddlmain.Text != "" && tbvoltage.Text != "")
                    {
                        volt = Convert.ToDouble(tbvoltage.Text);
                        if (volt >= 69)
                        {
                            cost = ((unit * 3.4149) + plus);
                            costv = cost * 1.07;
                            lbshowname.Visible = true;
                            lbelec.Visible = true;
                            lblcost.Text = Convert.ToString(costv) + " THB";
                            lblname.Text = tbname.Text;
                            bgsub.Visible = true;
                        }
                        else if (volt >= 22 && volt <= 33)
                        {
                            cost = ((unit * 3.5849) + plus);
                            costv = cost * 1.07;
                            lbshowname.Visible = true;
                            lbelec.Visible = true;
                            lblcost.Text = Convert.ToString(costv) + " THB";
                            lblname.Text = tbname.Text;
                            bgsub.Visible = true;
                        }
                        else if (volt < 22)
                        {
                            if (unit > 10)
                            {
                                double x1 = 10 * 2.8013;
                                cost = (((unit - 10) * 3.8919) + x1 + plus22);
                                costv = cost * 1.07;
                                lbshowname.Visible = true;
                                lbelec.Visible = true;
                                lblcost.Text = Convert.ToString(costv) + " THB";
                                lblname.Text = tbname.Text;
                                bgsub.Visible = true;
                            }
                            else
                            {
                                cost = (unit * 2.8013) + plus22;
                                costv = cost * 1.07;
                                lbshowname.Visible = true;
                                lbelec.Visible = true;
                                lblcost.Text = Convert.ToString(costv) + " THB";
                                lblname.Text = tbname.Text;
                                bgsub.Visible = true;
                            }
                        }
                        else
                        {
                            lblname.Text = "";
                            lblcost.Text = "";
                            lbshowname.Visible = false;
                            lbelec.Visible = false;
                            MessageBox.Show("Invalid voltage input");
                            bgsub.Visible = false;

                        }
                    }
                    else
                    {
                        MessageBox.Show("Incomplete input" + "\n" + "plese check your input" + "\n" + "and try again");
                    }
                }
            }
            else
            {
                MessageBox.Show("Incomplete input" + "\n" + "plese check your input" + "\n" + "and try again");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void ddlmain_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ddlmain.SelectedIndex == 0)
            {
                lblvoltage.Visible = false;
                tbvoltage.Visible = false;
                lbldemand.Visible = false;
                tbdemand.Visible = false;

            }
            else if (ddlmain.SelectedIndex == 1)
            {
                lblvoltage.Visible = true;
                tbvoltage.Visible = true;
                lbldemand.Visible = true;
                tbdemand.Visible = true;

            }
            else
            {
                lblvoltage.Visible = true;
                tbvoltage.Visible = true;
                lbldemand.Visible = false;
                tbdemand.Visible = false;

            }
        }

        private void tbunit_KeyPress(object sender, KeyPressEventArgs e)
        {
            int cInt = Convert.ToInt32(e.KeyChar);
            if ((int)e.KeyChar >= 48 && (int)e.KeyChar <= 57 || (int)e.KeyChar == 8 || (int)e.KeyChar == 46)
            {
                e.Handled = false;

            }
            else
            {
                e.Handled = true;
            }
        }

        private void tbvoltage_KeyPress(object sender, KeyPressEventArgs e)
        {
            int cInt = Convert.ToInt32(e.KeyChar);
            if ((int)e.KeyChar >= 48 && (int)e.KeyChar <= 57 || (int)e.KeyChar == 8 || (int)e.KeyChar == 46)
            {
                e.Handled = false;

            }
            else
            {
                e.Handled = true;
            }
        }

        private void tbdemand_KeyPress(object sender, KeyPressEventArgs e)
        {
            int cInt = Convert.ToInt32(e.KeyChar);
            if ((int)e.KeyChar >= 48 && (int)e.KeyChar <= 57 || (int)e.KeyChar == 8 || (int)e.KeyChar == 46)
            {
                e.Handled = false;

            }
            else
            {
                e.Handled = true;
            }
        }
    }
}