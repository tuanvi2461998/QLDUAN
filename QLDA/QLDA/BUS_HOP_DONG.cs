using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL_QLDA;
using DTO_QLDA;
namespace QLDA
{
	public class BUS_HOP_DONG
	{
		DAL_HOP_DONG dalHopDong = new DAL_HOP_DONG();
		public DataTable getHopDong()
		{
			return dalHopDong.getHopDong();
		}
		public bool themHopDong(DTO_HOP_DONG hd)
		{
			return dalHopDong.themHopDong(hd);
		}
		public bool suaHopDong(DTO_HOP_DONG hd)
		{
			return dalHopDong.suaHopDong(hd);
		}
		public bool xoaHopDong(int ID_HD)
		{
			return dalHopDong.xoaHopDong(ID_HD);
		}
	}
}
