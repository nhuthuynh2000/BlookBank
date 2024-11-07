using BloodBankManagement.Model;
using BloodBankManagement.View;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BloodBankManagement.Controller
{
    internal class EmployeeController : IController
    {
        readonly string connectionString = "Data Source=BAONGOC\\DULICH;Initial Catalog=BloodBankManagement;User ID=sa;Password=123456";
        List<IModel> employees = new List<IModel>();

        public List<IModel> Items => employees;

        public bool Create(IModel model)
        {
            if (model is EmployeeModel employee)
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string query = "INSERT INTO NhanVienTbl (MaNhanVien, TenDangNhap, MatKhau, Role) VALUES (@MaNhanVien, @TenDangNhap, @MatKhau, @Role)";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@MaNhanVien", employee.MaNhanVien);
                        command.Parameters.AddWithValue("@TenDangNhap", employee.TenDangNhap);
                        command.Parameters.AddWithValue("@MatKhau", employee.MatKhau);
                        command.Parameters.AddWithValue("@Role", employee.Role);
                    


                        int rowsAffected = command.ExecuteNonQuery();
                        return rowsAffected > 0;
                    }
                }
            }
            return false;
        }

        public bool Delete(IModel id)
        {
            if (id is EmployeeModel employee)
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string query = "DELETE FROM NhanVienTbl WHERE MaNhanVien = @MaNhanVien";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@MaNhanVien", employee.MaNhanVien);
                        int rowsAffected = command.ExecuteNonQuery();
                        return rowsAffected > 0;
                    }
                }
            }
            return false;
        }

        public bool IsExist(object model)
        {
            if (model is EmployeeModel employee)
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string query = "SELECT COUNT(*) FROM NhanVienTbl WHERE MaNhanVien = @MaNhanVien";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@MaNhanVien", employee.MaNhanVien);
                        int count = (int)command.ExecuteScalar();
                        return count > 0;
                    }
                }
            }
            return false;
        }

        public bool Load()
        {
            employees.Clear();
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = "SELECT * FROM NhanVienTbl ORDER BY MaNhanVien ASC";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            EmployeeModel employee = new EmployeeModel
                            {
                                MaNhanVien = reader.GetInt32(0),
                                TenDangNhap = reader.GetString(1),
                                MatKhau = reader.GetString(2),
                                Role = reader.GetString(3)
                            };
                            employees.Add(employee);
                        }
                    }
                }
            }
            return employees.Count > 0;
        }

        public bool Load(object id)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = "SELECT * FROM NhanVienTbl WHERE MaNhanVien = @MaNhanVien";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@MaNhanVien", id);
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            EmployeeModel employee = new  EmployeeModel
                            {
                                MaNhanVien = reader.GetInt32(0),
                                TenDangNhap = reader.GetString(1),
                                MatKhau = reader.GetString(2),
                                Role = reader.GetString(3)
                            };
                            employees.Clear();
                            employees.Add(employee);
                            return true;
                        }
                    }
                }
            }
            return false;
        }

        public IModel Read(IModel id)
        {
            if (id is EmployeeModel employee)
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string query = "SELECT * FROM NhanVienTbl WHERE MaNhanVien = @MaNhanVien";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@MaNhanVien", employee.MaNhanVien);
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                return new EmployeeModel
                                {
                                    MaNhanVien = reader.GetInt32(0),
                                    TenDangNhap = reader.GetString(1),
                                    MatKhau = reader.GetString(2),
                                    Role = reader.GetString(3)
                                };
                            }
                        }
                    }
                }
            }
            return null;
        }

        public bool Update(IModel model)
        {
            if (model is EmployeeModel employee)
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string query = "UPDATE NhanVienTbl SET TenDangNhap = @TenDangNhap, MatKhau = @MatKhau, Role = @Role WHERE MaNhanVien = @MaNhanVien";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@MaNhanVien", employee.MaNhanVien);
                        command.Parameters.AddWithValue("@TenDangNhap", employee.TenDangNhap);
                        command.Parameters.AddWithValue("@MatKhau", employee.MatKhau);
                        command.Parameters.AddWithValue("@Role", employee.Role);

                        int rowsAffected = command.ExecuteNonQuery();
                        return rowsAffected > 0;
                    }
                }
            }
            return false;
        }
    }
}
