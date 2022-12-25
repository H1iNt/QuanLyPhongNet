using QuanLyPhongNet.dao;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyPhongNet
{
    public partial class fAdmin : Form
    {
        public fAdmin()
        {
            InitializeComponent();

            load_account();
        }

        private void load_account()
        {
            string query = "EXEC dbo.USP_GetAccountByUserName @userName";
             
            provider pro = new provider();

            dtgvTaiKhoan.DataSource = pro.load_dl(query, new object[] {"abc", "xyz" });
        }

        private void btnThemTaiKhoan_Click(object sender, EventArgs e)
        {

        }

        private void dtgvHoaDon_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void btnThemThucAn_Click(object sender, EventArgs e)
        {

        }

        private void txbTaiKhoan_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel8_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txbTebTaiKhoan_TextChanged(object sender, EventArgs e)
        {

        }

    }
}
