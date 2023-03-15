using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using System.Data.SqlClient;

namespace QLGV
{
    public partial class TongHop : DevExpress.XtraEditors.XtraForm
    {
        public TongHop()
        {
            InitializeComponent();
        }

        private void TongHop_Load(object sender, EventArgs e)
        {
            {
                Clsdatabase connect = new Clsdatabase();
                SqlConnection conn = connect.ketnoicrystal();
                if (connect.getloi() == "")
                {
                    SqlDataAdapter dap = new SqlDataAdapter("Select * from tb_GV1", conn);
                    DataSet ds = new DataSet();
                    dap.Fill(ds);
                    CrystalReport4 rpt = new CrystalReport4();
                    rpt.SetDataSource(ds.Tables[0]);
                    crystalReportViewer1.ReportSource = rpt;
                }
            }
        }
    }
}