using BloodBankManagement.Model;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BloodBankManagement.Controller
{
    internal class BloodStockController : IController
    {
        readonly string connectionString = "Data Source=BAONGOC\\DULICH;Initial Catalog=BloodBankManagement;User ID=sa;Password=123456";
        List<IModel> bloods = new List<IModel>();

        public List<IModel> Items => bloods;

        public bool Create(IModel model)
        {
            if (model is BloodModel blood)
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string query = "INSERT INTO MauTbl (NhomMau, SoLuongMau) VALUES (@NhomMau, @SoLuongMau)";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@NhomMau", blood.NhomMau);
                        command.Parameters.AddWithValue("@SoLuongMau", blood.SoLuongMau);




                        int rowsAffected = command.ExecuteNonQuery();
                        return rowsAffected > 0;
                    }
                }
            }
            return false;
        }

        public bool Delete(IModel id)
        {
            if (id is BloodModel blood)
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string query = "DELETE FROM MauTbl WHERE NhomMau = @NhomMau";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@NhomMau", blood.NhomMau);

                        int rowsAffected = command.ExecuteNonQuery();
                        return rowsAffected > 0;
                    }
                }
            }
            return false;
        }

        public bool IsExist(object model)
        {
            if (model is BloodModel blood)
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string query = "SELECT COUNT(*) FROM MauTbl WHERE NhomMau = @NhomMau";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@NhomMau", blood.NhomMau);
                        int count = (int)command.ExecuteScalar();
                        return count > 0;
                    }
                }
            }
            return false;
        }

        public bool Load()
        {
            bloods.Clear();
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = "SELECT * FROM MauTbl ORDER BY NhomMau ASC";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            BloodModel blood = new BloodModel
                            {
                                NhomMau = reader.GetString(0),
                                SoLuongMau = reader.GetInt32(1)

                            };
                            bloods.Add(blood);
                        }
                    }
                }
            }
            return bloods.Count > 0;
        }

        public bool Load(object id)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string query = "SELECT * FROM MauTbl WHERE NhomMau = @NhomMau";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@NhomMau", id);
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            BloodModel blood = new BloodModel
                            {
                                NhomMau = reader.GetString(0),
                                SoLuongMau = reader.GetInt32(1)
                            };
                            bloods.Clear();
                            bloods.Add(blood);
                            return true;
                        }
                    }
                }
            }
            return false;
        }

        public IModel Read(IModel id)
        {
            if (id is BloodModel blood)
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string query = "SELECT * FROM MauTbl WHERE NhomMau = @NhomMau";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@NhomMau", blood.NhomMau);
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                return new BloodModel
                                {

                                    NhomMau = reader.GetString(0),
                                    SoLuongMau = reader.GetInt32(1)
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
            if (model is not BloodModel blood)
            {

                Console.WriteLine("Model không hợp lệ.");
                return false;
            }

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string query = "UPDATE MauTbl SET SoLuongMau = @SoLuongMau WHERE NhomMau = @NhomMau";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {

                        command.Parameters.AddWithValue("@NhomMau", blood.NhomMau);
                        command.Parameters.AddWithValue("@SoLuongMau", blood.SoLuongMau);

                        int rowsAffected = command.ExecuteNonQuery();
                        return rowsAffected > 0; // Trả về true nếu có dòng được cập nhật
                    }
                }
            }
            catch (SqlException sqlEx)
            {
                // Xử lý lỗi SQL cụ thể
                Console.WriteLine($"SQL Error: {sqlEx.Message}");
                return false;
            }
            catch (Exception ex)
            {
                // Xử lý lỗi chung
                Console.WriteLine($"Error: {ex.Message}");
                return false;
            }
        }
    }
}
