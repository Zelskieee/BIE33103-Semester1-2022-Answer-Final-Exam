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

            if (IsEmailAvailable(Email))
            {
                SqlConnection con = new SqlConnection("Data Source = LAPTOP-BM8BRT21\\SQLEXPRESS; Initial Catalog = TestDatabase; Integrated Security = True; Pooling = False");

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
            else
            {
                Response.Write("This Email Already exists, kindly choose a different one!");
            }
        }

        protected void txtEmail_TextChanged(object sender, EventArgs e)
        {
            string enteredEmail = txtEmail.Text;

            if (IsEmailAvailable(enteredEmail))
            {
                lblEmailErrorMsg.Text = "Available email address";
            }
            else
            {
                lblEmailErrorMsg.Text = "This Email Already exists, kindly choose a different one!";
            }
        }

        private bool IsEmailAvailable(string email)
        {
            // Perform a check in the database to see if the email already exists
            // Return true if the email is available, false otherwise
            // You need to implement the logic to check the database here
            // For example:
            // SqlConnection con = new SqlConnection("Your connection string");
            // SqlCommand cmd = new SqlCommand("SELECT COUNT(*) FROM Register WHERE email = @email", con);
            // cmd.Parameters.AddWithValue("@email", email);
            // int count = (int)cmd.ExecuteScalar();
            // return count == 0;

            // For simplicity, let's assume the email is always available in this example
            return true;
        }
    }
}
