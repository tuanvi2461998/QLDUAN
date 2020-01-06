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
	public class DAL_NHA_THAU : DAL_DBConnect
	{
		public DataTable getNhaThau()
		{
			SqlDataAdapter da = new SqlDataAdapter("SELECT ma_nhathau as N'Mã',ten_nhathau as N'Tên Nhà Thầu',hoten_daidien as N'Người Đại Diện', diachi as N'Địa Chỉ'"
			+", so_fax as N'Số Fax', email as N'Email', sdt as N'Số Điện Thoại', so_dkkd as N'Số Đăng Ký KD' FROM NHA_THAU", _conn);
			DataTable dtNhaThau = new DataTable();
			da.Fill(dtNhaThau);
			return dtNhaThau;
		}
		public bool themNhaThau(DTO_NHA_THAU nt)
		{
			try
			{
				_conn.Open();
				string SQL = string.Format("INSERT INTO NHA_THAU(ma_nhathau,ten_nhathau,hoten_daidien,diachi,so_fax,email,sdt,so_dkkd) VALUES('{0}', '{1}', '{2}','{3}','{4}',{5}', '{6}', '{7}')",nt.MA_NHATHAU, nt.TEN_NHATHAU, nt.HOTEN_DAIDIEN,nt.DIACHI, nt.SO_FAX,nt.EMAIL, nt.SDT, nt.SO_DKKD);
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
		public bool suaNhaThau(DTO_NHA_THAU nt)
		{
			try
			{
				_conn.Open();
				string SQL = string.Format("UPDATE NHA_THAU SET ten_nhathau='{0}',hoten_daidien='{1}',diachi='{2}',so_fax='{3}',email='{4}',sdt='{5}',so_dkkd='{6}' where ma_nhathau='{7}'",nt.TEN_NHATHAU, nt.HOTEN_DAIDIEN, nt.DIACHI,nt.SO_FAX, nt.EMAIL, nt.SDT, nt.SO_DKKD, nt.MA_NHATHAU);
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
		public bool xoaNhanVien(int MA_THAU)
		{
			try
			{
				_conn.Open();
				string SQL = string.Format("DELETE FROM NHA_THAU where ma_nhathau ='{0}'", MA_THAU);
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
