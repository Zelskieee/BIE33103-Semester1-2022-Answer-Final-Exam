using System.Data.SqlClient;
using System.Data;
using System.Security.Policy;
using System.Xml.Linq;
using System;

namespace Spot_Question_DotNet
{
    public partial class WebForm2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
        }

        protected void submitForm_Click(object sender, EventArgs e)
        {
            string Name = name.Text;
            string Email = email.Text;
            string Password = password.Text;
            string PhoneNumber = phone.Text;

            SqlConnection con = new SqlConnection
                ("Data Source = LAPTOP-BM8BRT21\\SQLEXPRESS; Initial Catalog = TestDatabase; Integrated Security = True; Pooling = False");

            try
            {
                con.Open();

                // Use parameterized query to prevent SQL injection
                SqlCommand cmd = new SqlCommand("INSERT INTO Register (name, email, [password], phone) VALUES (@name, @email, @password, @phone)", con);

                // Add parameters
                cmd.Parameters.Add("@name", SqlDbType.VarChar, 50).Value = Name;
                cmd.Parameters.Add("@email", SqlDbType.VarChar, 50).Value = Email;
                cmd.Parameters.Add("@password", SqlDbType.VarChar, 50).Value = Password;
                cmd.Parameters.Add("@phone", SqlDbType.VarChar, 50).Value = PhoneNumber;

                // Execute the SQL command
                cmd.ExecuteNonQuery();

                Response.Write("User data inserted successfully");
            }
            catch (Exception ex)
            {
                Response.Write("Error: " + ex.ToString());
            }
            finally
            {
                con.Close();

                // Clear input fields
                name.Text = string.Empty;
                email.Text = string.Empty;
                password.Text = string.Empty;
                phone.Text = string.Empty;
            }
        }
    }
}
