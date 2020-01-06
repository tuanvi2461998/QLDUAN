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
	public class DAL_CONG_TRINH : DAL_DBConnect
	{
		public DataTable getCongTrinh()
		{
			SqlDataAdapter da = new SqlDataAdapter("SELECT ma_congtrinh as N'Mã', ten_congtrinh as N'Tên Công Trình', diadiem as N'Địa Điểm', mota_congtrinh as N'Mô Tả'"
			+",trangthai as N'Trạng Thái', ct.ngay_batdau as N'Ngày Bất Đầu', ct.ngay_ketthuc as N'Ngày Kết Thúc', giatri_congtrinh as N'Giá Trị', ct.chuthich as N'Chú Thích', da.ten_duan as N'Tên Dự Án'"
			+ "FROM CONG_TRINH ct, DU_AN da WHERE ct.ma_duan = da.ma_duan", _conn);
			DataTable dtCongTrinh = new DataTable();
			da.Fill(dtCongTrinh);
			return dtCongTrinh;
		}
		public bool themCongTrinh(DTO_CONGTRINH ctr)
		{
			try
			{
				_conn.Open();
				string SQL = string.Format("INSERT INTO CONG_TRINH (ma_congtrinh ,ten_congtrinh ,diadiem ,mota_congtrinh ,trangthai ,ngay_batdau ,ngay_ketthuc ,giatri_congtrinh ,chuthich ,ma_duan) VALUES('{0}', '{1}', '{2}','{3}','{4}',{5}', '{6}', '{7}', '{8}', '{9}')",ctr.MA_CONGTRINH, ctr.TEN_CONGTRINH,ctr.DIADIEM, ctr.MOTA, ctr.TRANGTHAI,ctr.NGAY_BD, ctr.NGAY_KT, ctr.GIA_CONGTRINH, ctr.CHU_THICH, ctr.MA_DUAN);
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
		public bool suaCongTrinh(DTO_CONGTRINH ctr)
		{
			try
			{
				_conn.Open();
				string SQL = string.Format("UPDATE CONG_TRINH SET ten_congtrinh='{0}',diadiem='{1}',mota_congtrinh='{2}',trangthai='{3}',ngay_batdau='{4}',ngay_ketthuc='{5}',giatri_congtrinh='{6}',chuthich='{7}',ma_duan ='{8}' where ma_congtrinh='{9}'",ctr.TEN_CONGTRINH,  ctr.DIADIEM, ctr.MOTA,ctr.NGAY_BD, ctr.NGAY_KT, ctr.GIA_CONGTRINH, ctr.CHU_THICH, ctr.MA_DUAN, ctr.MA_CONGTRINH);
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
		public bool xoaCongTrinh(int ID_CT)
		{
			try
			{
				_conn.Open();
				string SQL = string.Format("DELETE FROM CONG_TRINH where ma_congtrinh ='{0}'", ID_CT);
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
