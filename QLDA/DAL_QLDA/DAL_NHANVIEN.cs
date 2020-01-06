using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO_QLDA;

namespace DAL_QLDA
{
	public class DAL_NHANVIEN : DAL_DBConnect
	{
		public DataTable getNhanVien()
		{
			SqlDataAdapter da = new SqlDataAdapter("select ma_nhanvien as N'Mã', hoten_nhanvien as N'Họ Tên', gioitinh as N'Giới Tính'"
			+", ngay_sinh as N'Ngày Sinh', dia_chi  as N'Địa Chỉ',sdt as N'Số Điện Thoại', taikhoan as N'Tài Khoản', chucvu as N'Chức Vụ' from NHAN_VIEN", _conn);
			DataTable dtNhanVien = new DataTable();
			da.Fill(dtNhanVien);
			return dtNhanVien;
		}
		public bool themNhanVien(DTO_NHANVIEN nv)
		{
			try
			{
				_conn.Open();
				string SQL = string.Format("INSERT INTO NHAN_VIEN(ma_nhanvien,hoten_nhanvien,gioitinh,ngay_sinh,dia_chi,sdt,taikhoan,matkhau,chucvu) VALUES('{0}', '{1}', '{2}','{3}','{4}',{5}', '{6}', '{7}','{8}')", nv.ID_NV, nv.HOTEN, nv.GIOITINH, nv.NGAYSINH,nv.DIACHI,nv.TAIKHOAN,nv.MATKHAU,nv.CHUCVU);
				SqlCommand cmd = new SqlCommand(SQL, _conn);
				if (cmd.ExecuteNonQuery() > 0)
				{
					return true;
				}
			}
			catch (Exception e)
			{
			}
			finally
			{
				_conn.Close();
			}
			return false;
		}
		public bool suaNhanVien(DTO_NHANVIEN nv)
		{
			try
			{
				_conn.Open();
				string SQL = string.Format("UPDATE NHAN_VIEN SET hoten_nhanvien='{0}',gioitinh='{1}',ngay_sinh='{2}',dia_chi='{3}',sdt='{4}',taikhoan='{5}',matkhau='{6}',chucvu='{7}' where ma_nhanvien='{8}'", nv.HOTEN, nv.GIOITINH,nv.NGAYSINH, nv.DIACHI, nv.SDT, nv.TAIKHOAN,nv.MATKHAU, nv.CHUCVU, nv.ID_NV);
				SqlCommand cmd = new SqlCommand(SQL, _conn);
				if (cmd.ExecuteNonQuery() > 0)
				{
					return true;
				}
			}
			catch (Exception e)
			{

			}
			finally
			{
				_conn.Close();
			}
			return false;
		}
		public bool xoaNhanVien(int ID_NV)
		{
			try
			{
				_conn.Open();
				string SQL = string.Format("DELETE FROM NHAN_VIEN where ma_nhanvien ='{0}'",ID_NV);
				SqlCommand cmd = new SqlCommand(SQL, _conn);
				if (cmd.ExecuteNonQuery() > 0)
				{
					return true;
				}
			}
			catch (Exception e)
			{

			}
			finally
			{
				_conn.Close();
			}
			return false;
		}
	}
}
