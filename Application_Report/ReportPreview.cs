using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Application_Service.ClassService;
using Application_Report.Data;
using System.Data.SqlClient;

namespace Application_Report
{
    public partial class ReportPreview : Form
    {
        public ReportPreview()
        {
            InitializeComponent();
        }

        #region Member
        ReportDS tblReport = new ReportDS();
        #endregion Member

        #region Properties
        public ReportDS GetDataSet
        {
            get { return tblReport; }
            set { tblReport = value; }
        }
        #endregion Properties

        private void ReportPreview_Load(object sender, EventArgs e)
        {
            TimelineReport fReport = new TimelineReport();
            fReport.SetDataSource(GetDataSet);
            crvTimeline.ReportSource = fReport;
        }
    }
}
