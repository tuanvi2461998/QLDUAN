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
	public class BUS_RUI_RO
	{
		DAL_RUI_RO dalRuiRo = new DAL_RUI_RO();
		public DataTable getRuiRo()
		{
			return dalRuiRo.getRuiRo();
		}
		public bool themRuiRo(DTO_RUI_RO rr)
		{
			return dalRuiRo.themRuiRo(rr);
		}
		public bool suaRuiRo(DTO_RUI_RO rr)
		{
			return dalRuiRo.suaRuiRo(rr);
		}
		public bool xoaRuiRo(int ID_RR)
		{
			return dalRuiRo.xoaRuiRo(ID_RR);
		}
	}
}
