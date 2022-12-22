using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyPhongNet.dao
{
    internal class provider
    {
        private string duong_dan = "Data Source=msi;Initial Catalog=QuanLyPhongNet;Integrated Security=True";

        public DataTable load_dl(string query, object[] parameter = null)
        {
            DataTable data = new DataTable();

            using (SqlConnection ket_noi = new SqlConnection(duong_dan))
            {
                ket_noi.Open();
                
                SqlCommand load_tk = new SqlCommand(query, ket_noi); // câu lệnh truy xuất query trong ket_noi
                
                if (parameter != null)
                {
                    string[] listPara = query.Split(' ');
                    int i = 0;
                    foreach (string item in listPara)
                    {
                        if (item.Contains('@'))
                        {
                            load_tk.Parameters.AddWithValue(item, parameter[i]);
                            i++;
                        }
                    }

                }
                
                SqlDataAdapter apater = new SqlDataAdapter(load_tk); // chạy câu lệnh trên
                
                apater.Fill(data); 
                
                ket_noi.Close();
            }
            return data;
        }
        public int load_no_dl(string query, object[] parameter = null)
        {
            int data = 0;

            using (SqlConnection ket_noi = new SqlConnection(duong_dan))
            {
                ket_noi.Open();

                SqlCommand load_tk = new SqlCommand(query, ket_noi); // câu lệnh truy xuất query trong ket_noi

                if (parameter != null)
                {
                    string[] listPara = query.Split(' ');
                    int i = 0;
                    foreach (string item in listPara)
                    {
                        if (item.Contains('@'))
                        {
                            load_tk.Parameters.AddWithValue(item, parameter[i]);
                            i++;
                        }
                    }

                }

                data= load_tk.ExecuteNonQuery();

                ket_noi.Close();
            }
            return data;
        }
        public object load_db_dl(string query, object[] parameter = null)
        {
            object data = 0;

            using (SqlConnection ket_noi = new SqlConnection(duong_dan))
            {
                ket_noi.Open();

                SqlCommand load_tk = new SqlCommand(query, ket_noi); // câu lệnh truy xuất query trong ket_noi

                if (parameter != null)
                {
                    string[] listPara = query.Split(' ');
                    int i = 0;
                    foreach (string item in listPara)
                    {
                        if (item.Contains('@'))
                        {
                            load_tk.Parameters.AddWithValue(item, parameter[i]);
                            i++;
                        }
                    }

                }

                data = load_tk.ExecuteScalar();

                ket_noi.Close();
            }
            return data;
        }
    }
}
