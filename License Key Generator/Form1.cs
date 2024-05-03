namespace License_Key_Generator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            SKGL.Generate generate = new SKGL.Generate();
            generate.secretPhase = txtPassword.Text;
            txtSerial.Text = generate.doKey(Convert.ToInt32(txtDay.Text));
        }

        private void btnValid_Click(object sender, EventArgs e)
        {
            SKGL.Validate validate = new SKGL.Validate();
            validate.secretPhase = txtPassword.Text;
            validate.Key = txtSerial.Text;
            txtStatus.Text = "Creation date : " + validate.CreationDate + "\r\n" + "Expire date : " + validate.ExpireDate + "\r\n" + "Day left : " + validate.DaysLeft;
        }

        private void txtPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                btnGenerate.PerformClick();
                btnValid.PerformClick();
                e.Handled = true;
            }
        }
    }
}
