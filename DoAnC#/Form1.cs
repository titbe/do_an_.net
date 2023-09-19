using System.Data;
using System.Data.SqlClient;

namespace DoAnC_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection("Data Source=LAPTOP-NPVV21L8\\SQLEXPRESS;Initial Catalog=QL_NMNuoc;Persist Security Info=True;User ID=sa;Password=hieudz01082003");

        private void btnThem_Click(object sender, EventArgs e)
        {
            //Insert
            int maNV = int.Parse(txtMaNV.Text);
            string tenNV = txtTenNV.Text;
            DateTime ngaysinh = DateTime.Parse(dtpNgaySinh.Text);
            string gioitinh = "";
            if (rdbNam.Checked = true) { gioitinh = "Nam"; } else { gioitinh = "Nữ"; }
            string dc = txtDiaChi.Text;
            string email = txtEmail.Text;
            string cccd = txtSoCCCD.Text;
            string sdt = txtSDT.Text;

            con.Open();
            SqlCommand c = new SqlCommand("exec InsertNV_SP '" + maNV + "', '\"+ tenNV + \"', '\"+ ngaysinh + \"', '\"+ gioitinh + \"', '\"+ dc + \"', '\"+ email + \"', '\"+ cccd + \"', '\"+ sdt + \"', con");
            c.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Thêm thành công nhân viên....");

            GetNVList();
        }
        void GetNVList()
        {
            SqlCommand c = new SqlCommand("exec ListNV_SP", con);
            SqlDataAdapter sd = new SqlDataAdapter(c);
            DataTable dt = new DataTable();
            sd.Fill(dt);
            dgvNhanVien.DataSource = dt;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            GetNVList();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            //Update
            int maNV = int.Parse(txtMaNV.Text);
            string tenNV = txtTenNV.Text;
            DateTime ngaysinh = DateTime.Parse(dtpNgaySinh.Text);
            string gioitinh = "";
            if (rdbNam.Checked = true) { gioitinh = "Nam"; } else { gioitinh = "Nữ"; }
            string dc = txtDiaChi.Text;
            string email = txtEmail.Text;
            string cccd = txtSoCCCD.Text;
            string sdt = txtSDT.Text;

            con.Open();
            SqlCommand c = new SqlCommand("exec UpdateNV_SP '" + maNV + "', '\"+ tenNV + \"', '\"+ ngaysinh + \"', '\"+ gioitinh + \"', '\"+ dc + \"', '\"+ email + \"', '\"+ cccd + \"', '\"+ sdt + \"', con");
            c.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Sửa thành công nhân viên....");

            GetNVList();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            //Delete
            if (MessageBox.Show("Bạn có chắc chắn muốn xóa nhân viên này?", "Delete Document", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                int maNV = int.Parse(txtMaNV.Text);

                con.Open();
                SqlCommand c = new SqlCommand("exec DeleteNV_SP '" + maNV + "', con");
                c.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Xóa thành công nhân viên....");

                GetNVList();
            }
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            //Search
            int maNV = int.Parse(txtMaNV.Text);
            SqlCommand c = new SqlCommand("exec DeleteNV_SP '" + maNV + "', con");
            SqlDataAdapter sd = new SqlDataAdapter(c);
            DataTable dt = new DataTable();
            sd.Fill(dt);
            dgvNhanVien.DataSource = dt;
        }
    }
}