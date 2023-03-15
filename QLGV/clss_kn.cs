using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLGV
{
    class clss_kn
    {
        public SqlConnection conn = new SqlConnection();
        public string strconn = "";

        public Boolean kn()
        {
            strconn = "Data Source=LAPTOP-3NFIFOLQ;Initial Catalog=QLGV;Integrated Security=True";
            conn.ConnectionString = strconn;
            try
            {
                conn.Open();
                return true;
            }
            catch (Exception ex)
            {
                strconn = ex.ToString();
                return false;
            }
        }
    }
}
