using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL_QLDA
{
	public class DAL_DBConnect
	{
		protected SqlConnection _conn = new SqlConnection(@"Data Source=HP\SQLEXPRESS;Initial Catalog=QLDUAN;Integrated Security=True");
	}
}
