using Calculator.Service;

namespace Calculator
{
    public partial class Form1 : Form
    {
        private bool Number1use = false;
        private bool Number2use = false;
        private CalculatorService service = new CalculatorService();

        private double Number1;
        private double Number2;

        private string Operation = "";


        public Form1()
        {
            InitializeComponent();
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            lblResult.Text = lblResult.Text + "1";
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            lblResult.Text = lblResult.Text + "2";
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            lblResult.Text = lblResult.Text + "3";
        }

        private void bnt4_Click(object sender, EventArgs e)
        {
            lblResult.Text = lblResult.Text + "4";
        }

        private void bnt5_Click(object sender, EventArgs e)
        {
            lblResult.Text = lblResult.Text + "5";
        }

        private void bnt6_Click(object sender, EventArgs e)
        {
            lblResult.Text = lblResult.Text + "6";
        }

        private void bnt7_Click(object sender, EventArgs e)
        {
            lblResult.Text = lblResult.Text + "7";
        }

        private void bnt8_Click(object sender, EventArgs e)
        {
            lblResult.Text = lblResult.Text + "8";
        }

        private void bnt9_Click(object sender, EventArgs e)
        {
            lblResult.Text = lblResult.Text + "9";
        }

        private void bnt0_Click(object sender, EventArgs e)
        {
            lblResult.Text = lblResult.Text + "0";
        }

        private void bntPont_Click(object sender, EventArgs e)
        {
            lblResult.Text = lblResult.Text + ",";
        }

        private void bntDelete_Click(object sender, EventArgs e)
        {
            // delete last character
            if (lblResult.Text.Length > 0)
            {
                lblResult.Text = lblResult.Text.Substring(0, lblResult.Text.Length - 1);
            }

        }

        private void bntClear_Click(object sender, EventArgs e)
        {
            // delete all characters
            if (lblResult.Text.Length > 0)
            {
                lblResult.Text = "";
                lblNumber.Text = "";
                lblNumber.Visible = false;
                Number1 = 0;
                Number2 = 0;
                Number1use = false;
                Number2use = false;
                Operation = "";
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (lblResult.Text.Length > 0 && Number1use == false)
            {
                Number1 = double.Parse(lblResult.Text);
                Number1use = true;
                Operation = "+";
                lblResult.Text = "";
                lblNumber.Text = Number1.ToString() + " " + Operation;
                lblNumber.Visible = true;
            }
        }

        private void bntmultiply_Click(object sender, EventArgs e)
        {
            if (lblResult.Text.Length > 0 && Number1use == false)
            {
                Number1 = double.Parse(lblResult.Text);
                Number1use = true;
                Operation = "x";
                lblResult.Text = "";
                lblNumber.Text = Number1.ToString() + " " + Operation;
                lblNumber.Visible = true;
            }
        }

        private void bntdiv_Click(object sender, EventArgs e)
        {
            if (lblResult.Text.Length > 0 && Number1use == false)
            {
                Number1 = double.Parse(lblResult.Text);
                Number1use = true;
                Operation = "/";
                lblResult.Text = "";
                lblNumber.Text = Number1.ToString() + " " + Operation;
                lblNumber.Visible = true;
            }
        }

        private void bntsubtract_Click(object sender, EventArgs e)
        {
            if (lblResult.Text.Length == 0)
            {
                lblResult.Text = lblResult.Text + "-";
            }

            if (lblResult.Text.Length > 0 && (lblResult.Text != "-") && Number1use == false)
            {
                Number1 = double.Parse(lblResult.Text);
                Number1use = true;
                Operation = "-";
                lblResult.Text = "";
                lblNumber.Text = Number1.ToString() + " " + Operation;
                lblNumber.Visible = true;
            }

            
        }

        private async void bntIgual_Click(object sender, EventArgs e)
        {
            if (Number1use == true)
            {
                if (lblResult.Text.Length > 0)
                {
                    Number2 = double.Parse(lblResult.Text);
                    Number2use = true;
                }
                if (Number2use == true)
                {
                    double result = 0;
                    switch (Operation)
                    {
                        case "+":
                            result = await service.AddAsync(Number1, Number2);
                            break;
                        case "-":
                            result = await service.SubtractAsync(Number1, Number2);
                            break;
                        case "x":
                            result = await service.MultiplyAsync(Number1, Number2);
                            break;
                        case "/":
                            try
                            {
                                result = await service.DivideAsync(Number1, Number2);
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                lblResult.Text = "";
                                lblNumber.Text = "";
                                lblNumber.Visible = false;
                                // reset variables
                                Number1use = false;
                                Number2use = false;
                                Operation = "";
                                return;
                            }
                            
                            break;
                            
                    }
                    lblResult.Text = result.ToString();
                    lblNumber.Text = "";
                    lblNumber.Visible = false;
                    // reset variables
                    Number1use = false;
                    Number2use = false;
                    Operation = "";
                }
            }
        }
    }
}
