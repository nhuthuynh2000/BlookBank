using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using BloodBankManagement.Model;

namespace BloodBankManagement.Controller
{
    internal class DonorController : IController
    {
        private readonly string connectionString = "server=localhost\\MSSQLSERVER;Initial Catalog=BloodBank;User ID=sa;Password=123456";
        private List<IModel> donors = new List<IModel>();

        public List<IModel> Items => donors;

        public bool Create(IModel model)
        {
            if (model is not DonorModel donor) return false;

            SqlConnection connection = new SqlConnection(connectionString);
            try
            {
                connection.Open();
                string query = "INSERT INTO NguoiHienTbl (MaNguoiHien, HoVaTen, Tuoi, GioiTinh, SoDienThoai, DiaChi, NhomMau) VALUES (@MaNguoiHien, @HoVaTen, @Tuoi, @GioiTinh, @SoDienThoai, @DiaChi, @NhomMau)";
                SqlCommand command = new SqlCommand(query, connection);

                command.Parameters.AddWithValue("@MaNguoiHien", donor.MaNguoiHien);
                command.Parameters.AddWithValue("@HoVaTen", donor.HoVaTen);
                command.Parameters.AddWithValue("@Tuoi", donor.Tuoi);
                command.Parameters.AddWithValue("@GioiTinh", donor.GioiTinh);
                command.Parameters.AddWithValue("@SoDienThoai", donor.SoDienThoai);
                command.Parameters.AddWithValue("@DiaChi", donor.DiaChi);
                command.Parameters.AddWithValue("@NhomMau", donor.NhomMau);

                int rowsAffected = command.ExecuteNonQuery();
                return rowsAffected > 0;
            }
            catch (SqlException ex)
            {
                Console.WriteLine("SQL Error: " + ex.Message);
                return false;
            }
            finally
            {
                connection.Close();
            }
        }

        public bool Delete(IModel model)
        {
            if (model is not DonorModel donor) return false;

            SqlConnection connection = new SqlConnection(connectionString);
            try
            {
                connection.Open();
                string query = "DELETE FROM NguoiHienTbl WHERE MaNguoiHien = @MaNguoiHien";
                SqlCommand command = new SqlCommand(query, connection);

                command.Parameters.AddWithValue("@MaNguoiHien", donor.MaNguoiHien);

                int rowsAffected = command.ExecuteNonQuery();
                return rowsAffected > 0;
            }
            catch (SqlException ex)
            {
                Console.WriteLine("SQL Error: " + ex.Message);
                return false;
            }
            finally
            {
                connection.Close();
            }
        }

        public bool IsExist(object model)
        {
            if (model is not DonorModel donor) return false;

            SqlConnection connection = new SqlConnection(connectionString);
            try
            {
                connection.Open();
                string query = "SELECT COUNT(*) FROM NguoiHienTbl WHERE MaNguoiHien = @MaNguoiHien";
                SqlCommand command = new SqlCommand(query, connection);

                command.Parameters.AddWithValue("@MaNguoiHien", donor.MaNguoiHien);

                int count = (int)command.ExecuteScalar();
                return count > 0;
            }
            catch (SqlException ex)
            {
                Console.WriteLine("SQL Error: " + ex.Message);
                return false;
            }
            finally
            {
                connection.Close();
            }
        }

        public bool Load(object id)
        {
            SqlConnection connection = new SqlConnection(connectionString);
            try
            {
                connection.Open();
                string query = "SELECT * FROM NguoiHienTbl WHERE MaNguoiHien = @MaNguoiHien";
                SqlCommand command = new SqlCommand(query, connection);

                command.Parameters.AddWithValue("@MaNguoiHien", id);

                using (SqlDataReader reader = command.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        DonorModel donor = new DonorModel
                        {
                            MaNguoiHien = reader.GetInt32(0),
                            HoVaTen = reader.GetString(1),
                            Tuoi = reader.GetInt32(2),
                            GioiTinh = reader.GetString(3),
                            SoDienThoai = reader.GetString(4),
                            DiaChi = reader.GetString(5),
                            NhomMau = reader.GetString(6)
                        };
                        donors.Clear();
                        donors.Add(donor);
                        return true;
                    }
                }
            }
            catch (SqlException ex)
            {
                Console.WriteLine("SQL Error: " + ex.Message);
                return false;
            }
            finally
            {
                connection.Close();
            }

            return false;
        }

        public bool Load()
        {
            SqlConnection connection = new SqlConnection(connectionString);
            donors.Clear();

            try
            {
                connection.Open();
                string query = "SELECT * FROM NguoiHienTbl ORDER BY MaNguoiHien ASC";
                SqlCommand command = new SqlCommand(query, connection);

                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        DonorModel donor = new DonorModel
                        {
                            MaNguoiHien = reader.GetInt32(0),
                            HoVaTen = reader.GetString(1),
                            Tuoi = reader.GetInt32(2),
                            GioiTinh = reader.GetString(3),
                            SoDienThoai = reader.GetString(4),
                            DiaChi = reader.GetString(5),
                            NhomMau = reader.GetString(6)
                        };
                        donors.Add(donor);
                    }
                }
                return donors.Count > 0;
            }
            catch (SqlException ex)
            {
                Console.WriteLine("SQL Error: " + ex.Message);
                return false;
            }
            finally
            {
                connection.Close();
            }
        }

        public IModel Read(IModel model)
        {
            if (model is not DonorModel donor) return null;

            SqlConnection connection = new SqlConnection(connectionString);
            try
            {
                connection.Open();
                string query = "SELECT * FROM NguoiHienTbl WHERE MaNguoiHien = @MaNguoiHien";
                SqlCommand command = new SqlCommand(query, connection);

                command.Parameters.AddWithValue("@MaNguoiHien", donor.MaNguoiHien);

                using (SqlDataReader reader = command.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        return new DonorModel
                        {
                            MaNguoiHien = reader.GetInt32(0),
                            HoVaTen = reader.GetString(1),
                            Tuoi = reader.GetInt32(2),
                            GioiTinh = reader.GetString(3),
                            SoDienThoai = reader.GetString(4),
                            DiaChi = reader.GetString(5),
                            NhomMau = reader.GetString(6)
                        };
                    }
                }
            }
            catch (SqlException ex)
            {
                Console.WriteLine("SQL Error: " + ex.Message);
            }
            finally
            {
                connection.Close();
            }
            return null;
        }

        public bool Update(IModel model)
        {
            if (model is not DonorModel donor) return false;

            SqlConnection connection = new SqlConnection(connectionString);
            try
            {
                connection.Open();
                string query = @"UPDATE NguoiHienTbl SET HoVaTen = @HoVaTen, Tuoi = @Tuoi, GioiTinh = @GioiTinh, 
                                 SoDienThoai = @SoDienThoai, DiaChi = @DiaChi, NhomMau = @NhomMau 
                                 WHERE MaNguoiHien = @MaNguoiHien";
                SqlCommand command = new SqlCommand(query, connection);

                command.Parameters.AddWithValue("@MaNguoiHien", donor.MaNguoiHien);
                command.Parameters.AddWithValue("@HoVaTen", donor.HoVaTen);
                command.Parameters.AddWithValue("@Tuoi", donor.Tuoi);
                command.Parameters.AddWithValue("@GioiTinh", donor.GioiTinh);
                command.Parameters.AddWithValue("@SoDienThoai", donor.SoDienThoai);
                command.Parameters.AddWithValue("@DiaChi", donor.DiaChi);
                command.Parameters.AddWithValue("@NhomMau", donor.NhomMau);

                return command.ExecuteNonQuery() > 0;
            }
            catch (SqlException ex)
            {
                Console.WriteLine("SQL Error: " + ex.Message);
                return false;
            }
            finally
            {
                connection.Close();
            }
        }
    }
}
