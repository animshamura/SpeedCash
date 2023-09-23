using System.Security.Principal;

namespace SpeedCash
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }


        private Customer customer;
        
        private void Save_Button_Click(object sender, EventArgs e)
        {
            customer = new Customer(tb1.Text, tb2.Text);
            customer.Account = new BankAccount(tb3.Text, tb4.Text);
            MessageBox.Show("Account Created!");
            ClearForm();
        }

        private void WithDraw_Click(object sender, EventArgs e)
        {
            double amount = Convert.ToDouble(tb5.Text);
            bool withdraw = customer.Account.WithDraw(amount);

            if (withdraw) tb5.Clear();
            else MessageBox.Show("Invalid Amount");
        }
        void ClearForm()
        {
            tb1.Clear();
            tb2.Clear();
            tb3.Clear();
            tb4.Clear();
        }


        private void Deposit_Click(object sender, EventArgs e)
        {
            
                double amount = Convert.ToDouble(tb5.Text);
                bool depos = customer.Account.Deposit(amount);
                if (depos) tb5.Clear();
                else MessageBox.Show("Invalid Amount");
        }

        private void ShowDetails_Click(object sender, EventArgs e)
        {
            tb6.Text = customer.Name;
            tb7.Text = customer.Email;
            tb8.Text = customer.Account.AccountNo;
            tb9.Text = customer.Account.OpeningDate;
            tb10.Text = customer.Account.Balance.ToString();

        }
    }
}