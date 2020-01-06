using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO_QLDA
{
	public class DTO_RUI_RO
	{
		private int _ID;
		private int _MA_DA;
		private string _TIEU_DE;
		private string _TRANG_THAI;
		private string _CHI_TIET;

		/*===============GETTER/SETTER==================*/
		public int ID { get => _ID; set => _ID = value; }
		public int MA_DA { get => _MA_DA; set => _MA_DA = value; }
		public string TIEU_DE { get => _TIEU_DE; set => _TIEU_DE = value; }
		public string TRANG_THAI { get => _TRANG_THAI; set => _TRANG_THAI = value; }
		public string CHI_TIET { get => _CHI_TIET; set => _CHI_TIET = value; }
		/*=====================CONSTRUC========================*/
		public DTO_RUI_RO()
		{
		}
		public DTO_RUI_RO(int id, int ma_da, string tieude, string trangthai, string chitiet)
		{
			this.ID = id;
			this.MA_DA = ma_da;
			this.TIEU_DE = tieude;
			this.TRANG_THAI = trangthai;
			this.CHI_TIET = chitiet;
		}
	}
}
