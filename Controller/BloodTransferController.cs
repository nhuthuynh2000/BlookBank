using BloodBankManagement.Model;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Reflection.Metadata.BlobBuilder;

namespace BloodBankManagement.Controller
{
    internal class BloodTransferController : IController
    {
        readonly string connectionString = "Data Source=BAONGOC\\DULICH;Initial Catalog=BloodBankManagement;User ID=sa;Password=123456";
        List<IModel> bloodtransfers = new List<IModel>();

        public List<IModel> Items => bloodtransfers;

        public bool Create(IModel model)
        {
            if (model is BloodTransferModel bloodtransfer)
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string query = "INSERT INTO ChuyenGiaoMauTbl (MaChuyenGiao, HoVaTenNguoiNhan, NhomMau) VALUES (@MaChuyenGiao, @HoVaTenNguoiNhan, @NhomMau)";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@MaChuyenGiao", bloodtransfer.MaChuyenGiao);
                        command.Parameters.AddWithValue("@HoVaTenNguoiNhan", bloodtransfer.HoVaTenNguoiNhan);
                        command.Parameters.AddWithValue("@NhomMau", bloodtransfer.NhomMau);
                       




                        int rowsAffected = command.ExecuteNonQuery();
                        return rowsAffected > 0;
                    }
                }
            }
            return false;
        }

        public bool Delete(IModel id)
        {
            if (id is BloodTransferModel bloodtransfer)
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string query = "DELETE FROM ChuyenGiaoMauTbl WHERE MaChuyenGiao = @MaChuyenGiao";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@MaChuyenGiao", bloodtransfer.MaChuyenGiao);

                        int rowsAffected = command.ExecuteNonQuery();
                        return rowsAffected > 0;
                    }
                }
            }
            return false;
        }

        public bool IsExist(object model)
        {
            if (model is BloodTransferModel bloodtransfer)
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string query = "SELECT COUNT(*) FROM ChuyenGiaoMauTbl WHERE MaChuyenGiao = @MaChuyenGiao";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@MaChuyenGiao", bloodtransfer.MaChuyenGiao);
                        int count = (int)command.ExecuteScalar();
                        return count > 0;
                    }
                }
            }
            return false;
        }

        public bool Load()
        {
            bloodtransfers.Clear();
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = "SELECT * FROM ChuyenGiaoMauTbl ORDER BY MaChuyenGiao ASC";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            BloodTransferModel bloodtransfer = new BloodTransferModel
                            {
                                MaChuyenGiao = reader.GetInt32(0),
                                HoVaTenNguoiNhan = reader.GetString(1),
                                NhomMau = reader.GetString(2)

                            };
                            bloodtransfers.Add(bloodtransfer);
                        }
                    }
                }
            }
            return bloodtransfers.Count > 0;
        }

        public bool Load(object id)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string query = "SELECT * FROM ChuyenGiaoMauTbl WHERE MaChuyenGiao = @MaChuyenGiao";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@MaChuyenGiao", id);
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            BloodTransferModel bloodtransfer = new BloodTransferModel
                            {
                                MaChuyenGiao = reader.GetInt32(0),
                                HoVaTenNguoiNhan = reader.GetString(1),
                                NhomMau = reader.GetString(2)
                            };
                            bloodtransfers.Clear();
                            bloodtransfers.Add(bloodtransfer);
                            return true;
                        }
                    }
                }
            }
            return false;
        }

        public IModel Read(IModel id)
        {
            if (id is BloodTransferModel bloodtransfer)
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string query = "SELECT * FROM ChuyenGiaoMauTbl WHERE MaChuyenGiao = @MaChuyenGiao";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@MaChuyenGiao", bloodtransfer.MaChuyenGiao);
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                return new BloodTransferModel
                                {

                                    MaChuyenGiao = reader.GetInt32(0),
                                    HoVaTenNguoiNhan = reader.GetString(1),
                                    NhomMau = reader.GetString(2)
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
            if (model is not BloodTransferModel bloodtransfer)
            {

                Console.WriteLine("Model không hợp lệ.");
                return false;
            }

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string query = "UPDATE ChuyenGiaoMauTbl SET HoVaTenNguoiNhan = @HoVaTenNguoiNhan, NhomMau = @NhomMau WHERE MaChuyenGiao = @MaChuyenGiao";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {

                        command.Parameters.AddWithValue("@MaChuyenGiao", bloodtransfer.MaChuyenGiao);
                        command.Parameters.AddWithValue("@HoVaTenNguoiNhan", bloodtransfer.HoVaTenNguoiNhan);
                        command.Parameters.AddWithValue("@NhomMau", bloodtransfer.NhomMau);

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
