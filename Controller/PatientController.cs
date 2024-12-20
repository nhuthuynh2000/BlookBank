﻿using BloodBankManagement.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace BloodBankManagement.Controller
{
    internal class PatientController : IController
    {
        readonly string connectionString = "server=localhost\\MSSQLSERVER;Initial Catalog=BloodBank;User ID=sa;Password=123456";
        List<IModel> patients = new List<IModel>();

        public List<IModel> Items => patients;

        public bool Create(IModel model)
        {
            if (model is PatientModel patient)
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string query = "INSERT INTO BenhNhanTbl (MaBenhNhan, HoVaTen, Tuoi, GioiTinh, SoDienThoai, NhomMau, DiaChi, BenhVien) VALUES (@MaBenhNhan, @HoVaTen, @Tuoi, @GioiTinh, @SoDienThoai, @NhomMau, @DiaChi, @BenhVien)";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@MaBenhNhan", patient.MaBenhNhan);
                        command.Parameters.AddWithValue("@HoVaTen", patient.HoVaTen);
                        command.Parameters.AddWithValue("@Tuoi", patient.Tuoi);
                        command.Parameters.AddWithValue("@GioiTinh", patient.GioiTinh);
                        command.Parameters.AddWithValue("@SoDienThoai", patient.SoDienThoai);
                        command.Parameters.AddWithValue("@NhomMau", patient.NhomMau);
                        command.Parameters.AddWithValue("@DiaChi", patient.DiaChi);
                        command.Parameters.AddWithValue("@BenhVien", patient.BenhVien);


                        int rowsAffected = command.ExecuteNonQuery();
                        return rowsAffected > 0;
                    }
                }
            }
            return false;
        }

        public bool Delete(IModel id)
        {
            if (id is PatientModel donor)
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string query = "DELETE FROM BenhNhanTbl WHERE MaBenhNhan = @MaBenhNhan";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@MaBenhNhan", donor.MaBenhNhan);

                        int rowsAffected = command.ExecuteNonQuery();
                        return rowsAffected > 0;
                    }
                }
            }
            return false;
        }

        public bool IsExist(object model)
        {
            if (model is PatientModel patient)
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string query = "SELECT COUNT(*) FROM BenhNhanTbl WHERE MaBenhNhan = @MaBenhNhan";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@MaBenhNhan", patient.MaBenhNhan);
                        int count = (int)command.ExecuteScalar();
                        return count > 0;
                    }
                }
            }
            return false;
        }

        public bool Load()
        {
            patients.Clear();
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = "SELECT * FROM BenhNhanTbl ORDER BY MaBenhNhan ASC";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            PatientModel patient = new PatientModel
                            {
                                MaBenhNhan = reader.GetInt32(0),
                                HoVaTen = reader.GetString(1),
                                Tuoi = reader.GetInt32(2),
                                GioiTinh = reader.GetString(3),
                                SoDienThoai = reader.GetString(4),
                                NhomMau = reader.GetString(5),
                                DiaChi = reader.GetString(6),
                                BenhVien = reader.GetString(7)
                            };
                            patients.Add(patient);
                        }
                    }
                }
            }
            return patients.Count > 0;
        }

        public bool Load(object id)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = "SELECT * FROM BenhNhanTbl WHERE MaBenhNhan = @MaBenhNhan";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@MaBenhNhan", id);
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            PatientModel patient = new PatientModel
                            {
                                MaBenhNhan = reader.GetInt32(0),
                                HoVaTen = reader.GetString(1),
                                Tuoi = reader.GetInt32(2),
                                GioiTinh = reader.GetString(3),
                                SoDienThoai = reader.GetString(4),
                                NhomMau = reader.GetString(5),
                                DiaChi = reader.GetString(6),
                                BenhVien = reader.GetString(7)
                            };
                            patients.Clear();
                            patients.Add(patient);
                            return true;
                        }
                    }
                }
            }
            return false;
        }

        public IModel Read(IModel id)
        {
            if (id is PatientModel patient)
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string query = "SELECT * FROM BenhNhanTbl WHERE MaBenhNhan = @MaBenhNhan";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@MaBenhNhan", patient.MaBenhNhan);
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                return new PatientModel
                                {
                                    MaBenhNhan = reader.GetInt32(0),
                                    HoVaTen = reader.GetString(1),
                                    Tuoi = reader.GetInt32(2),
                                    GioiTinh = reader.GetString(3),
                                    SoDienThoai = reader.GetString(4),
                                    NhomMau = reader.GetString(5),
                                    DiaChi = reader.GetString(6),
                                    BenhVien = reader.GetString(7)
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
            if (model is not PatientModel patient)
            {

                Console.WriteLine("Model không hợp lệ.");
                return false;
            }

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string query = "UPDATE BenhNhanTbl SET HoVaTen = @HoVaTen, Tuoi = @Tuoi, GioiTinh = @GioiTinh, SoDienThoai = @SoDienThoai, NhomMau = @NhomMau, DiaChi = @DiaChi, BenhVien = @BenhVien WHERE MaBenhNhan = @MaBenhNhan";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@MaBenhNhan", patient.MaBenhNhan);
                        command.Parameters.AddWithValue("@HoVaTen", patient.HoVaTen);
                        command.Parameters.AddWithValue("@Tuoi", patient.Tuoi);
                        command.Parameters.AddWithValue("@GioiTinh", patient.GioiTinh);
                        command.Parameters.AddWithValue("@SoDienThoai", patient.SoDienThoai);
                        command.Parameters.AddWithValue("@NhomMau", patient.NhomMau);
                        command.Parameters.AddWithValue("@DiaChi", patient.DiaChi);
                        command.Parameters.AddWithValue("@BenhVien", patient.BenhVien);

                        int rowsAffected = command.ExecuteNonQuery();
                        return rowsAffected > 0;
                    }
                }
            }
            catch (SqlException sqlEx)
            {
                Console.WriteLine($"SQL Error: {sqlEx.Message}");
                return false;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
                return false;
            }
        }
    }
}
