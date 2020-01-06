using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO_QLDA
{
	public class DTO_DUAN
	{
		private int _MA_DA;
		private string _TEN_DA;
		private string _NGAY_BD;
		private string _NGAY_KT;
		private double _TONG_DAUTU;
		private string _NGUON_VON;
		private string _CHUTHICH;
		private int _MA_HD;
		/*=============GETTER/SETTER==============*/
		public int MA_DA
		{
			get
			{
				return _MA_DA;
			}
			set
			{
				_MA_DA = value;
			}
		}
		public string TEN_DA
		{
			get
			{
				return _TEN_DA;
			}
			set
			{
				_TEN_DA = value;
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
		public double TONG_DAUTU
		{
			get
			{
				return _TONG_DAUTU;
			}
			set
			{
				_TONG_DAUTU = value;
			}
		}
		public string NGUON_VON
		{ 
			get
			{
				return _NGUON_VON ;
			}
			set
			{
				_NGUON_VON = value;
			}
		}
		public string CHUTHICH
		{
			get
			{
				return _CHUTHICH;
			}
			set
			{
				_CHUTHICH = value;
			}
		}

		public int MA_HD { get => _MA_HD; set => _MA_HD = value; }

		/*============CONSTRUC============*/
		public DTO_DUAN()
		{
		}
		public DTO_DUAN(int ma, string ten, string nbd, string nkt,double tongdt,string von ,string chuthich)
		{
			this.MA_DA = ma;
			this.TEN_DA = ten;
			this.NGAY_BD = nbd;
			this.NGAY_KT = nkt;
			this.TONG_DAUTU = tongdt;
			this.NGUON_VON = von;
			this.CHUTHICH = chuthich;
		}
	}
}
