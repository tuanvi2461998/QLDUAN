using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO_QLDA;
using DAL_QLDA;
using System.Data;

namespace QLDA
{
	public class BUS_DUAN
	{
		DAL_DUAN dalDuAn = new DAL_DUAN();
		public DataTable getDuAn()
		{
			return dalDuAn.getDuAn();
		}
		public bool themDuAn(DTO_DUAN da)
		{
			return dalDuAn.themDuAn(da);
		}
		public bool suaDuAn(DTO_DUAN da)
		{
			return dalDuAn.suaDuAn(da);
		}
		public bool xoaDuAn(int ID_DA)
		{
			return dalDuAn.xoaDuAn(ID_DA);
		}
	}
}
