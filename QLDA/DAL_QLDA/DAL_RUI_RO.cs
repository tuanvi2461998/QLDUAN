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
	public class DAL_RUI_RO : DAL_DBConnect
	{
		public DataTable getRuiRo()
		{
			SqlDataAdapter da = new SqlDataAdapter("select rr.id as N'Mã', da.ten_duan as N'Tên Dự Án', rr.tieu_de as N'Rủi Ro', rr.trang_thai as N'Trạng Thái', rr.chitiet as N'Chi Tiết' from RUI_RO rr, DU_AN da where rr.ma_duan = da.ma_duan", _conn);
			DataTable dtRuiRo = new DataTable();
			da.Fill(dtRuiRo);
			return dtRuiRo;
		}
		public bool themRuiRo(DTO_RUI_RO rr)
		{
			try
			{
				_conn.Open();
			 string SQL = string.Format("INSERT INTO RUI_RO(id,ma_duan,tieu_de,trang_thai,chitiet) VALUES('{0}', '{1}', '{2}','{3}','{4}')",rr.ID, rr.MA_DA, rr.TIEU_DE, rr.TRANG_THAI, rr.CHI_TIET);
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
		public bool suaRuiRo(DTO_RUI_RO rr)
		{
			try
			{
				_conn.Open();
				string SQL = string.Format("UPDATE RUI_RO SET ma_duan='{0}',tieu_de='{1}',trang_thai='{2}',chitiet='{3}' where id='{4}'", rr.MA_DA, rr.TIEU_DE, rr.TRANG_THAI, rr.CHI_TIET, rr.ID);
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
		public bool xoaRuiRo(int ID_RR)
		{
			try
			{
				_conn.Open();
				string SQL = string.Format("DELETE FROM RUI_RO where id ='{0}'", ID_RR);
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
