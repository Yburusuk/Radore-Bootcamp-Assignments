using DbFirstOdemeForm.Classes;
using DbFirstOdemeForm.Interfaces;
using System.Data.SqlClient;

namespace DbFirstOdemeForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            GenerateMissingPaymentClasses();
            GetPaymentTypes();
        }

        public void GetPaymentTypes()
        {
            string connectionString = @"Data Source=YAVUZ;Initial Catalog=RadoreDB;Integrated Security=SSPI;";
            List<PaymentType> paymentTypes = null;
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();

                    string query = "SELECT * FROM OdemeTipleri";
                    
                    SqlCommand sqlCommand = new SqlCommand(query, conn);
                     
                    SqlDataReader reader = sqlCommand.ExecuteReader();
                    
                    paymentTypes = new List<PaymentType>();

                    paymentTypes.Add(new PaymentType
                    {
                        id = -1,
                        displayName = "Ödeme Tipi Seçiniz",
                        className = "Ödeme Tipi Seçiniz"
                    });

                    while (reader.Read())
                    {
                        paymentTypes.Add(new PaymentType
                        {
                            id = Convert.ToInt32(reader["Id"]),
                            className = reader["CLASS_NAME"].ToString(),
                            displayName = reader["DISPLAY_NAME"].ToString()
                        });
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Hata: " + ex.ToString());
                }
                finally
                {
                    conn.Close();
                }

                cmb_paymentType.DataSource = paymentTypes;
                cmb_paymentType.DisplayMember = "displayName";
                cmb_paymentType.ValueMember = "className";
            }

        }

        private void button_pay_Click(object sender, EventArgs e)
        {
            if (cmb_paymentType.SelectedValue == null || cmb_paymentType.SelectedValue.ToString() == "Ödeme Tipi Seçiniz")
            {
                MessageBox.Show("Hata: Lütfen bir ödeme yöntemi seçiniz.");
                label_result.Text = "Sonuç: Hata: Lütfen bir ödeme yöntemi seçiniz.";
            }
            else if (textBox_amount.Text.Trim().Length == 0)
            {
                MessageBox.Show("Hata: Lütfen bir tutar yazınız.");
                label_result.Text = "Sonuç: Hata: Lütfen bir tutar yazınız.";
            }
            else
            {
                string selectedPaymentType = Convert.ToString(cmb_paymentType.SelectedValue);
                decimal amount = Convert.ToDecimal(textBox_amount.Text.Trim());
                
                string message = "";

                IPayment iPayment;
                PaymentProcessFactory factory = new PaymentProcessFactory();
                iPayment = factory.Create(selectedPaymentType);

                PaymentProcess paymentProcess = new PaymentProcess(iPayment);

                message = paymentProcess.DoPay(amount);

                label_result.Text = "Sonuç: " + message;
            }
        }

        private void GenerateMissingPaymentClasses()
        {
            string connectionString = @"Data Source=YAVUZ;Initial Catalog=RadoreDB;Integrated Security=SSPI;";
            string query = "SELECT CLASS_NAME, DISPLAY_NAME FROM OdemeTipleri";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                SqlCommand sqlCommand = new SqlCommand(query, conn);
                SqlDataReader reader = sqlCommand.ExecuteReader();

                while (reader.Read())
                {
                    string className = reader["CLASS_NAME"].ToString();
                    string displayName = reader["DISPLAY_NAME"].ToString();
                    string projectDirectory = Directory.GetParent(Application.StartupPath).Parent.Parent.Parent.FullName;
                    string targetDirectory = Path.Combine(projectDirectory, "Classes");
                    string filePath = Path.Combine(targetDirectory, $"{className}.cs");

                    if (!File.Exists(filePath))
                    {
                        GenerateClassFile(className, displayName, filePath);
                    }
                }
            }
        }

        private void GenerateClassFile(string className, string displayName, string filePath)
        {
            string classTemplate = $@"using DbFirstOdemeForm.Interfaces;

namespace DbFirstOdemeForm.Classes
{{
    public class {className} : IPayment
    {{
        public string Pay(decimal amount)
        {{
            string response = ""{displayName} ile "" + amount + ""₺ ödeme yapıldı."";

            return response;
        }}
    }}
}}";

            File.WriteAllText(filePath, classTemplate);
        }
    }
}