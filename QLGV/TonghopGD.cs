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
    public partial class TonghopGD : DevExpress.XtraEditors.XtraForm
    {
        public TonghopGD()
        {
            InitializeComponent();
        }

        private void TonghopGD_Load(object sender, EventArgs e)
        {
            {
                Clsdatabase connect = new Clsdatabase();
                SqlConnection conn = connect.ketnoicrystal();
                if (connect.getloi() == "")
                {
                    SqlDataAdapter dap = new SqlDataAdapter("Select * from tb_GV1", conn);
                    DataSet ds = new DataSet();
                    dap.Fill(ds);
                    CrystalReport5 rpt = new CrystalReport5();
                    rpt.SetDataSource(ds.Tables[0]);
                    crystalReportViewer1.ReportSource = rpt;
                }
               
            }
        }
    }
}