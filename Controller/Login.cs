using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BloodBankManagement.Controller
{
    internal class Login
    {
        private string connectionString = "Data Source=BAONGOC\\DULICH;Initial Catalog=BloodBankManagement;User ID=sa;Password=123456";
        public bool LoginController(string username, string password)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = "SELECT COUNT(*) FROM NhanVienTbl WHERE TenDangNhap = @username AND MatKhau = @password";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@username", username);
                    command.Parameters.AddWithValue("@password", password); 

                    int result = (int)command.ExecuteScalar();
                    return result > 0; // Trả về true nếu có ít nhất 1 bản ghi khớp
                }
            }
        }
        public string GetRole(string TenDangNhap, string MatKhau)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = "SELECT Role FROM NhanVienTbl WHERE TenDangNhap = @TenDangNhap AND MatKhau = @MatKhau";
                using (SqlCommand cmd = new SqlCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@TenDangNhap", TenDangNhap);
                    cmd.Parameters.AddWithValue("@MatKhau", MatKhau);

                    string result = (string)cmd.ExecuteScalar();
                    return result;
                }
            }
        }
    }
}
