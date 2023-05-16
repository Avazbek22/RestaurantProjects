namespace Restaraunt_1.Core
{
    public partial class Form1 : Form
    {
        Employee emp = new Employee();
        private object _food;
        public Form1()
        {
            InitializeComponent();
        }
        /// <summary>
        /// ������������� ������ ������
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnNewReq_Click(object sender, EventArgs e) //
        {
            int quantity;
            try {
                if(int.TryParse(TxtBox_GetQuantity.Text,out quantity) == false || quantity < 1) 

                if (quantity < 1) throw new ArgumentException("������� ���������� ����������!");

                _food = emp.NewRequest(quantity, (radBtn_Chicken.Checked) ? "Chicken" : "Egg"); // ��������� ��������
                labelEggQualValue.Text = emp.Inspect(_food);
            }
            catch(FormatException) {
                MessageBox.Show("������� ���������� ����������! (�����, �������������)");
            }
            catch (Exception ex) {
                MessageBox.Show(ex.Message);
            }
        }


        /// <summary>
        /// ������������� ���������� ���
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnPrepareFood_Click(object sender, EventArgs e)
        {
            try {
                listBoxResults.Items.Insert(0, emp.PrepareFood(_food)); // ������� ���������
            }
            catch (Exception ex) {
                MessageBox.Show(ex.Message);
            }
        }


        /// <summary>
        /// ����������� ����������� ������
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCopyReq_Click(object sender, EventArgs e)
        {
            try {
                _food = emp.CopyRequest();
                labelEggQualValue.Text = emp.Inspect(_food);
            }
            catch (Exception) {
                MessageBox.Show("������� �������� �����!");
            }
        }

    }
}