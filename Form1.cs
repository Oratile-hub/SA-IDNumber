namespace SA_IDNumber
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnValidate_Click(object sender, EventArgs e)
        {

            string IDNumber = txtID.Text;

            if (IDNumber.Length == 13 && IsNumeric(IDNumber))
            {
                MessageBox.Show("The ID number is valid");
            }
            else
            {
                MessageBox.Show("The ID number is invalid. Please enter a valid ID number.");
            }
        }

        //Checks if a string contains only numeric digits (0-9)
        public static bool IsNumeric(string str)
        {
            foreach (char c in str)
            {
                if (c < '0' || c > '9')
                {
                    return false;
                }
            }

            return true;
        }



    }
}
