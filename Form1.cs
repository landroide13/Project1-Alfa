namespace Project1_Alfa
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load_1(object sender, EventArgs e)
        {
            lstCountry.Items.Add("New Zealand");
            lstCountry.Items.Add("Australia");
        }
       
        private void txtName_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e) { }

        private void lstCountry_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selItem = lstCountry.SelectedItem.ToString();

            if (selItem == "Australia")
            {
                cbCities.Items.Clear();
                String[] AUCity = { "Camberra", "Sydney", "Perth" };
                cbCities.Items.AddRange(AUCity);
            }
            else
            {
                cbCities.Items.Clear();
                String[] NZCity = { "Wellington", "Hamilton", "Taupo" };
                cbCities.Items.AddRange(NZCity);
            }
        }

        private void btn1_Click(object sender, EventArgs e)
        {
           MessageBox.Show(txtName.Text + " lives in " + cbCities.SelectedItem.ToString() + " , " + lstCountry.SelectedItem.ToString());
        }
    }
}