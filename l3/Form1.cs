namespace l3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnConvert_Click(object sender, EventArgs e)
        {
            double amount;

            if (double.TryParse(txtAmount.Text, out amount))
            {
                Currency currency = null;

                if (dollarsRadioButton.Checked)
                {
                    currency = new Dollar(74.33);
                }
                else if (eurosRadioButton.Checked)
                {
                    currency = new Euro(89.43);
                }

                if (currency != null)
                {
                    currency.PrintAmount(amount);
                }
            }
            else
            {
                MessageBox.Show("Invalid input");
            }
        }
    }
}