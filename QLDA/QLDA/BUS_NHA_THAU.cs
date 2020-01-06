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
	public class BUS_NHA_THAU
	{
		DAL_NHA_THAU dalNhaThau = new DAL_NHA_THAU();
		public DataTable getNhaThau()
		{
			return dalNhaThau.getNhaThau();
		}
		public bool themNhaThau( DTO_NHA_THAU nt)
		{
			return dalNhaThau.themNhaThau(nt);
		}
		public bool suaNhanVien(DTO_NHA_THAU nt)
		{
			return dalNhaThau.suaNhaThau(nt);
		}
		public bool xoaNhaThau(int ID_NT)
		{
			return dalNhaThau.xoaNhanVien(ID_NT);
		}
	}
}
