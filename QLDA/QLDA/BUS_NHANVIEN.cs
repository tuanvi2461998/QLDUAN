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
	public class BUS_NHANVIEN
	{
		DAL_NHANVIEN dalNhanVien = new DAL_NHANVIEN();
		public DataTable getNhanVien()
		{
			return dalNhanVien.getNhanVien();
		}
		public bool themNhanVien(DTO_NHANVIEN nv)
		{
			return dalNhanVien.themNhanVien(nv);
		}
		public bool suaNhanVien(DTO_NHANVIEN nv)
		{
			return dalNhanVien.suaNhanVien(nv);
		}
		public bool xoaNhanVien(int ID_NV)
		{
			return dalNhanVien.xoaNhanVien(ID_NV);
		}
	}
}
