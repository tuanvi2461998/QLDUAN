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
	public class DAL_DUAN : DAL_DBConnect
	{
		public DataTable getDuAn()
		{
			SqlDataAdapter da = new SqlDataAdapter("select da.ma_duan as N'Mã Dự Án', da.ten_duan as N'Tên Dự Án', da.ngay_batdau as N'Ngày Bất Đầu', da.ngay_ketthuc as N'Ngày Kết Thúc', da.tongmuc_dautu as N'Tổng Giá Trị', da.nguonvon as N'Nguồn Vốn', da.chuthich as N'Chú Thích', hd.ma_hopdong as N'Hợp Đồng' from DU_AN da, HOP_DONG hd where hd.ma_duan = da.ma_duan", _conn);
			DataTable dtDuAn = new DataTable();
			da.Fill(dtDuAn);
			return dtDuAn;
		}
		public bool themDuAn(DTO_DUAN da)
		{
			try
			{
				_conn.Open();
				string SQL = string.Format("INSERT INTO DU_AN (ma_duan ,ten_duan ,ngay_batdau ,ngay_ketthuc ,tongmuc_dautu ,nguonvon ,chuthich ,ma_hopdong) VALUES('{0}','{1}', '{2}','{3}','{4}','{5}','{6}','{7}')", da.MA_DA, da.TEN_DA, da.NGAY_BD, da.NGAY_KT,da.TONG_DAUTU, da.NGUON_VON, da.CHUTHICH, da.MA_HD);
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
		public bool suaDuAn(DTO_DUAN da)
		{
			try
			{
				_conn.Open();
				string SQL = string.Format("UPDATE DU_AN SET ten_duan= '{0}',ngay_batdau= '{1}',ngay_ketthuc= '{2}',tongmuc_dautu= '{3}',nguonvon= '{4}',chuthich= '{5}',ma_hopdong = '{6} where ma_duan= '{7}'", da.TEN_DA, da.NGAY_BD, da.NGAY_KT, da.TONG_DAUTU, da.NGUON_VON, da.CHUTHICH, da.MA_HD, da.MA_DA);
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
		public bool xoaDuAn(int ID_DA)
		{
			try
			{
				_conn.Open();
				string SQL = string.Format("DELETE FROM DU_AN where ma_duan	='{0}'", ID_DA);
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
