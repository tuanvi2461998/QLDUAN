/*using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO_QLDA;

namespace DAL_QLDA
{
	public class DAL_HOP_DONG : DAL_DBConnect
	{
		public DataTable getHopDong()
		{
			SqlDataAdapter da = new SqlDataAdapter("select hd.ma_hopdong as N'Mã', hd.ten_hopdong as 'Tên Hợp Đồng', hd.ngayky as N'Ngày Ký', hd.noidung_chinh as N'Nội dung', nv.hoten_nhanvien as N'Nhân Viên Ký', nt.ten_nhathau as N'Tên Thầu',da.ten_duan as N'Tên Dự Án'"
								+"from HOP_DONG hd, DU_AN da, NHAN_VIEN nv, NHA_THAU nt "
								+"where hd.ma_duan = da.ma_duan and hd.ma_nhanvien = nv.ma_nhanvien and hd.ma_nhathau = nt.ma_nhathau", _conn);
			DataTable dtDuAn = new DataTable();
			da.Fill(dtDuAn);
			return dtDuAn;
		}
		public bool themHopDong(DTO_HOP_DONG hd)
		{
			try
			{
				_conn.Open();
				string SQL = string.Format("INSERT INTO HOP_DONG() VALUES('{0}','{1}', '{2}','{3}','{4}','{5}','{6}','{7}')");
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
		public bool suaHopDong(DTO_HOP_DONG hd)
		{
			try
			{
				_conn.Open();
				string SQL = string.Format("UPDATE HOP_DONG SET ten_duan= '{0}',ngay_batdau= '{1}',ngay_ketthuc= '{2}',tongmuc_dautu= '{3}',nguonvon= '{4}',chuthich= '{5}',ma_hopdong = '{6} where ma_duan= '{7}'", da.TEN_DA, da.NGAY_BD, da.NGAY_KT, da.TONG_DAUTU, da.NGUON_VON, da.CHUTHICH, da.MA_HD, da.MA_DA);
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
		public bool xoaHopDong(int ID_DA)
		{
			try
			{
				_conn.Open();
				string SQL = string.Format("DELETE FROM HOP_DONG where ma_duan	='{0}'", ID_DA);
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
*/