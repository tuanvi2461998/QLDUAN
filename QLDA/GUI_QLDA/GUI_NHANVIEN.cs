using System;
using System.Windows.Forms;
using DTO_QLDA;
using BUS_TEST;

namespace GUI_QLDA
{
	public partial class GUI_NHANVIEN : DevExpress.XtraEditors.XtraForm
	{
		public GUI_NHANVIEN()
		{
			InitializeComponent();
		}
		 BUS_NHANVIEN busNV = new BUS_NHANVIEN();
		private void btThemNV_Click(object sender, EventArgs e)
		{
			if ( txtMaNV.Text != "" && txtHoTen.Text !="" && cbGioiTinh.Text !="" && txtChucVu.Text !="" && dateNS.Text !="" && txtSdt.Text != "" && txtMatKhau.Text !="" && txtTaiKhoan.Text != "" && txtDiaChi.Text != "")
			{
				int ID = Convert.ToInt32(txtMaNV.Text);
				DTO_NHANVIEN NV = new DTO_NHANVIEN(ID,txtHoTen.Text,cbGioiTinh.Text,dateNS.Text,txtDiaChi.Text, txtSdt.Text, txtTaiKhoan.Text,txtMatKhau.Text, txtChucVu.Text);
				if (busNV.themNhanVien(NV))
				{
					MessageBox.Show("Thêm thành công!");
					dataGNV.DataSource = busNV.getNhanVien();	
				}
				else
				{
					MessageBox.Show("Thêm thất bại !");
				}
			}
			else
			{
				MessageBox.Show("Vui lòng điền đủ thông tin!");
			}
		}

		private void GUI_NHANVIEN_Load(object sender, EventArgs e)
		{
			dataGNV.DataSource = busNV.getNhanVien();
		}

		private void btSuaNV_Click(object sender, EventArgs e)
		{
			if (txtMaNV.Text != "" || txtHoTen.Text != "" || cbGioiTinh.Text !="" || txtChucVu.Text != "" || dateNS.Text != "" || txtSdt.Text != "" || txtMatKhau.Text != "" || txtTaiKhoan.Text != "" || txtDiaChi.Text != "" )
			{
				int ID = Convert.ToInt32(txtMaNV.Text);
				DTO_NHANVIEN NV = new DTO_NHANVIEN(ID, txtHoTen.Text, cbGioiTinh.Text, dateNS.Text, txtDiaChi.Text, txtSdt.Text, txtTaiKhoan.Text, txtMatKhau.Text, txtChucVu.Text);
				if (busNV.suaNhanVien(NV))
				{
					MessageBox.Show("Sửa thành công!");
					dataGNV.DataSource = busNV.getNhanVien();
				}
				else
				{
					MessageBox.Show("Sửa thất bại !");
				}
			}
			else
			{
				MessageBox.Show("Vui lòng điền đủ thông tin!");
			}
		}

		private void btXoaNV_Click(object sender, EventArgs e)
		{
			int ID = Convert.ToInt32(txtMaNV.Text);
			if (busNV.xoaNhanVien(ID))
			{
				MessageBox.Show("Xóa thành công!");
				dataGNV.DataSource = busNV.getNhanVien();
			}
			else
			{
				MessageBox.Show("Xóa thất bại!");
			}

		}
	}
}