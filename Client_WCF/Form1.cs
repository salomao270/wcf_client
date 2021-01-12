using System;
using System.Windows.Forms;

namespace Client_WCF
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnValidateEmail_Click(object sender, EventArgs e)
        {
            //creating an instance of my WCF service
            var wcf_service = new Wcf_ExampleReference.EmailServiceClient();

            //using the method from my WCF service to validate an email
            if (wcf_service.ValidateEmail(txtEmail.Text))
                MessageBox.Show("Remote service response: it is a valid email format");
            else
                MessageBox.Show("Remote service response: it is an invalid email format");
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
