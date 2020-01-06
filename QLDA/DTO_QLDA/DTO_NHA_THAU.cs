using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO_QLDA
{
	public class DTO_NHA_THAU
	{
		private int _MA_NHATHAU;
		private string _TEN_NHATHAU;
		private string _HOTEN_DAIDIEN;
		private string _DIACHI;
		private string _SO_FAX;
		private string _EMAIL;
		private string _SDT;
		private string _SO_DKKD;
		/*===========GETTER/SETTER============*/
		public int MA_NHATHAU
		{
			get
			{
				return _MA_NHATHAU;
			}
			set
			{
				_MA_NHATHAU = value;
			}
		}
		public string TEN_NHATHAU
		{
			get
			{
				return _TEN_NHATHAU;
			}
			set
			{
				_TEN_NHATHAU = value;
			}
		}
		public string HOTEN_DAIDIEN
		{
			get
			{
				return _HOTEN_DAIDIEN;
			}
			set
			{
				_HOTEN_DAIDIEN = value;
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
		public string SO_FAX
		{
			get
			{
				return _SO_FAX;
			}
			set
			{
				_SO_FAX = value;
			}
		}
		public string EMAIL
		{
			get
			{
				return _EMAIL;
			}
			set
			{
				_EMAIL = value;
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
		public string SO_DKKD
		{
			get
			{
				return _SO_DKKD;
			}
			set
			{
				_SO_DKKD = value;
			}
		}
		/*=========CONSTRUC=========*/
		public DTO_NHA_THAU()
		{

		}
		public DTO_NHA_THAU(int ma, string ten, string ten_daidien, string diachi, string sofax, string email, string sdt,string sdkkd)
		{
			this.MA_NHATHAU = ma;
			this.TEN_NHATHAU = ten;
			this.HOTEN_DAIDIEN = ten_daidien;
			this.DIACHI = diachi;
			this.SO_FAX = sofax;
			this.EMAIL = email;
			this.SDT = sdt;
			this.SO_DKKD = sdkkd;
		}

	}
}
