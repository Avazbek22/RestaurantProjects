
namespace Restaraunt_2.Core
{
    public partial class Form1 : Form
    {
        Server server = new Server();
        public Form1()
        {
            InitializeComponent();
            comboBoxDrinks.SelectedIndex = 0;
        }

        private void ReceiveRequest_Click(object sender, EventArgs e)
        {
            int amountChicken, amountEgg;

            if (int.TryParse(txtboxAmountChicken.Text, out amountChicken) == false || amountChicken < 0)
            {
                MessageBox.Show("Please enter a correct quantity for chickens!");
                return;
            }

            if (int.TryParse(txtboxAmountEgg.Text, out amountEgg) == false || amountEgg < 0)
            {
                MessageBox.Show("Please enter a correct quantity for eggs!");
                return;
            }

            try
            {
                server.Receive(amountChicken, amountEgg, (MenuItem)comboBoxDrinks.SelectedIndex);
                labelEggQuality.Text = "Egg quality: ";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void SendToCook_Click(object sender, EventArgs e)
        {
            try
            {
                labelEggQuality.Text += server.Send();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void ServeFood_Click(object sender, EventArgs e)
        {
            try
            {
                string[] preparedOrders = server.Serve();
                for (int i = 0; i < preparedOrders.Length; i++)
                    listBoxResults.Items.Add(preparedOrders[i]);

                listBoxResults.Items.Add("Please enjoy your food!");
                listBoxResults.Items.Add("\n");
                labelEggQualValue.Text = string.Empty;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}