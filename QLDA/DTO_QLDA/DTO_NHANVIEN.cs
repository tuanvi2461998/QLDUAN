using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO_QLDA
{
	public class DTO_NHANVIEN
	{
		private int _ID_NV;
		private string _HOTEN;
		private string _GIOITINH;
		private string _NGAYSINH;
		private string _DIACHI;
		private string _SDT;
		private string _TAIKHOAN;
		private string _MATKHAU;
		private string _CHUCVU;
		/*============GETTER/SETTER===================*/
		public int ID_NV
		{
			get
			{
				return _ID_NV;
			}
			set
			{
				_ID_NV = value;
			}
		}
		public string HOTEN
		{
			get
			{
				return _HOTEN;
			}
			set
			{
				_HOTEN = value;
			}
		}
		public string GIOITINH
		{
			get
			{
				return _GIOITINH;
			}
			set
			{
				_GIOITINH = value;
			}
		}
		public string NGAYSINH
		{
			get
			{
				return _NGAYSINH;
			}
			set
			{
				_NGAYSINH = value;
			}
		}
		public string DIACHI
		{
			get
			{
				return _DIACHI;
			}
			set
			{
				_DIACHI = value;
			}
		}
		public string SDT
		{
			get
			{
				return _SDT;
			}
			set
			{
				_SDT = value;
			}
		}
		public string TAIKHOAN
		{
			get
			{
				return _TAIKHOAN;
			}
			set
			{
				_TAIKHOAN = value;
			}
		}
		public string MATKHAU
		{
			get
			{
				return _MATKHAU;
			}
			set
			{
				_MATKHAU = value;
			}
		}
		public string CHUCVU
		{
			get
			{
				return _CHUCVU;
			}
			set
			{
				_CHUCVU = value;
			}
		}
		/*==============CONSTRUC==================*/
		public DTO_NHANVIEN()
		{

		}
		public DTO_NHANVIEN(int id_nv, string hoten,string gt ,string ngaysinh, string diachi, string sdt, string taikhoan, string matkhau, string chucvu)
		{
			this.ID_NV = id_nv;
			this.HOTEN = hoten;
			this.GIOITINH = gt;
			this.NGAYSINH = ngaysinh;
			this.DIACHI = diachi;
			this.SDT = sdt;
			this.TAIKHOAN = taikhoan;
			this.MATKHAU = matkhau;
			this.CHUCVU = chucvu;
		}
	}
}
