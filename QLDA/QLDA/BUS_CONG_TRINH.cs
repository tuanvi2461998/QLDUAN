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
	public class BUS_CONG_TRINH
	{
		DAL_CONG_TRINH dalCongTrinh = new DAL_CONG_TRINH();
		public DataTable getCongTrinh()
		{
			return dalCongTrinh.getCongTrinh();
		}
		public bool themCongTrinh(DTO_CONGTRINH ct)
		{
			return dalCongTrinh.themCongTrinh(ct);
		}
		public bool suaCongTrinh(DTO_CONGTRINH ct)
		{
			return dalCongTrinh.suaCongTrinh(ct);
		}
		public bool xoaCongTrinh(int ID_CT)
		{
			return dalCongTrinh.xoaCongTrinh(ID_CT);
		}
	}
}
