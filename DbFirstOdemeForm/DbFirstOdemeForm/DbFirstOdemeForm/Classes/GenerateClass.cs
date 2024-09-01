using System.Data.SqlClient;

namespace DbFirstOdemeForm.Classes
{
    public static class GenerateClass
    {
        public static void GenerateMissingPaymentClasses()
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

        public static void GenerateClassFile(string className, string displayName, string filePath)
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
