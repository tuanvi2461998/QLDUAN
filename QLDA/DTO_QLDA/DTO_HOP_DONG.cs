using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO_QLDA
{
	public class DTO_HOP_DONG
	{
		private int _MA_HD;
		private string _TEN_HD;
		private string _NGAY_KY;
		private string _ND_CHINH;
		private int _MA_NV;
		private int _MA_NHA_THAU;
		private int _MA_DUA_AN;


		/*+======================GETTER/SETTER========================+*/
		public int MA_HD { get => _MA_HD; set => _MA_HD = value; }
		public string TEN_HD { get => _TEN_HD; set => _TEN_HD = value; }
		public string NGAY_KY { get => _NGAY_KY; set => _NGAY_KY = value; }
		public int MA_NV { get => _MA_NV; set => _MA_NV = value; }
		public int MA_NHA_THAU { get => _MA_NHA_THAU; set => _MA_NHA_THAU = value; }
		public int MA_DUA_AN { get => _MA_DUA_AN; set => _MA_DUA_AN = value; }
		public string ND_CHINH { get => _ND_CHINH; set => _ND_CHINH = value; }

		/*===================CONSTRUC===================================*/
		public DTO_HOP_DONG()
		{
		}
		public DTO_HOP_DONG(int ma, string ten, string ngayky,string nd, int manv, int mant, int mada)
		{
			this.MA_HD = ma;
			this.TEN_HD = ten;
			this.NGAY_KY = ngayky;
			this.ND_CHINH = nd;
			this.MA_NV = manv;
			this.MA_NHA_THAU = mant;
			this.MA_DUA_AN = mada;
		}
	}
}
