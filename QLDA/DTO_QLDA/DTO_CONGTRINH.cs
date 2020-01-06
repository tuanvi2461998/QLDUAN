using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO_QLDA
{
	public class DTO_CONGTRINH
	{
		private int _MA_CONGTRINH;
		private string _TEN_CONGTRINH;
		private string _DIADIEM;
		private string _MOTA;
		private string _TRANGTHAI;
		private string _NGAY_BD;
		private string _NGAY_KT;
		private double _GIA_CONGTRINH;
		private string _CHU_THICH;
		private int _MA_DUAN;
		/*==============GETTER/SETTER================*/
		public int MA_CONGTRINH
		{
			get
			{
				return _MA_CONGTRINH;
			}
			set
			{
				_MA_CONGTRINH = value;
			}
		}
		public string TEN_CONGTRINH
		{
			get
			{
				return _TEN_CONGTRINH;
			}
			set
			{
				_TEN_CONGTRINH = value;
			}
		}
		public string DIADIEM
		{
			get
			{
				return _DIADIEM;
			}
			set
			{
				_DIADIEM = value;
			}
		}
		public string MOTA
		{
			get
			{
				return _MOTA;
			}
			set
			{
				_MOTA = value;
			}
		}
		public string TRANGTHAI
		{
			get
			{
				return _TRANGTHAI;
			}
			set
			{
				_TRANGTHAI = value;
			}
		}
		public string NGAY_BD
		{
			get
			{
				return _NGAY_BD;
			}
			set
			{
				_NGAY_BD = value;
			}
		}
		public string NGAY_KT
		{
			get
			{
				return _NGAY_KT;
			}
			set
			{
				_NGAY_KT = value;
			}
		}
		public double GIA_CONGTRINH
		{
			get
			{
				return _GIA_CONGTRINH;
			}
			set
			{
				_GIA_CONGTRINH = value;
			}
		}
		public string CHU_THICH
		{
			get
			{
				return _CHU_THICH;
			}
			set
			{
				_CHU_THICH = value;
			}
		}
		public int MA_DUAN
		{
			get
			{
				return _MA_DUAN;
			}
			set
			{
				_MA_DUAN = value;
			}
		}
		/*===============CONSTRUC===============*/
		public DTO_CONGTRINH()
		{
		}
		public DTO_CONGTRINH(int ma, string ten, string diadiem, string mota, string trangthai, string nbd, string nkt, double gia, string chuthich, int ma_da)
		{
			this.MA_CONGTRINH = ma;
			this.TEN_CONGTRINH = ten;
			this.DIADIEM = diadiem;
			this.MOTA = mota;
			this.TRANGTHAI = trangthai;
			this.NGAY_BD = nbd;
			this.NGAY_KT = nkt;
			this.GIA_CONGTRINH = gia;
			this.CHU_THICH = chuthich;
			this.MA_DUAN = ma_da;
		}
	}
}
