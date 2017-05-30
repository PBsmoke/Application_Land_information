using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Application_Service;
using Application_Service.ClassService;
using Application_Form.ApplicationData;

namespace Application_Form
{
    public partial class TimeLineList : BaseListUserControl
    {
        public TimeLineList()
        {
            InitializeComponent();
        }

        public string LandID 
        {
            get;
            protected set;
        }

        int SelectRowIndex = -1;
        ApplicationDS tdsTimeLandHD = new ApplicationDS();

        protected override void DoLoadForm()
        {
            dbConString.Chk_ConnectionState();
            ShowData();
        }

        protected override void DoNew()
        {
            TimeLineInfo frmForm = new TimeLineInfo();
            frmForm.LandID = LandID;
            frmForm.FormState = "new";
            frmForm.ShowDialog();
            btnStatus(true);
            ShowData();
        }

        protected override void DoEdit()
        {
            if (dgvTimeLandHD.RowCount > 0)
            {
                TimeLineInfo frmForm = new TimeLineInfo();
                frmForm.FormState = "edit";
                frmForm.LandID = LandID;
                frmForm.TimeLineHDID = dgvTimeLandHD.Rows[SelectRowIndex].Cells[colTimeLineHDID.Name].Value.ToString();
                frmForm.ShowDialog();
                btnStatus(true);
            }
            ShowData();
        }

        protected override void DoDelete()
        {
            if (MessageBox.Show("คุณต้องการลบข้อมูล ใช่หรือไม่ ?", dbConString.xMessage, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.No)
            {
                return;
            }

            string TimeLineHDID = dgvTimeLandHD.Rows[SelectRowIndex].Cells[colTimeLineHDID.Name].Value.ToString();

            try
            {
                dbConString.Transaction = dbConString.mySQLConn.BeginTransaction();
                StringBuilder StringBd = new StringBuilder();
                //dbConString.Transaction = new SqlTransaction();
                string sqlTmp = string.Empty;
                StringBd.Append(" DELETE tbTimeLineDT WHERE TimeLineHDID = @TimeLineHDID;");
                StringBd.Append(" DELETE tbTimeLineHD WHERE TimeLineHDID = @LandID;");
                sqlTmp = "";
                sqlTmp = StringBd.ToString();
                dbConString.Com = new SqlCommand();
                dbConString.Com.CommandText = sqlTmp;
                dbConString.Com.CommandType = CommandType.Text;
                dbConString.Com.Connection = dbConString.mySQLConn;
                dbConString.Com.Transaction = dbConString.Transaction;
                dbConString.Com.Parameters.Clear();
                dbConString.Com.Parameters.Add("@TimeLineHDID", SqlDbType.VarChar).Value = TimeLineHDID;
                dbConString.Com.ExecuteNonQuery();
                dbConString.Transaction.Commit();
                MessageBox.Show("บันทึกค่าเรียบร้อย", "OK", MessageBoxButtons.OK, MessageBoxIcon.Information);
                btnStatus(true);
                ShowData();
                Utilities.ResetAllControls(this);
            }
            catch
            {
                dbConString.Transaction.Rollback();
            }
        }

        protected override void DoSearch()
        {
            string Whereclause = string.Empty;
            if (!string.IsNullOrEmpty(tsBtuSearch.Text))
            {
                Whereclause = tsBtuSearch.Text;
            }
            else
            {
                Whereclause = string.Empty;
            }

            try
            {
                string sqlTmp = "";
                sqlTmp = "SELECT * FROM tbTimeLineHD ";
                if (!string.IsNullOrEmpty(Whereclause))
                {
                    sqlTmp += " WHERE TimeLineDate LIKE '%" + Whereclause + "%' OR Subject LIKE '%" + Whereclause + "%' ";
                }
                sqlTmp += " ORDER BY Province";
                DataSet Ds = new DataSet();
                dbConString.Com = new SqlCommand();
                dbConString.Com.CommandType = CommandType.Text;
                dbConString.Com.CommandText = sqlTmp;
                dbConString.Com.Connection = dbConString.mySQLConn;
                SqlCommand cmd = new SqlCommand(sqlTmp, dbConString.mySQLConn);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                tdsTimeLandHD.Clear();
                da.Fill(tdsTimeLandHD, "tbTimeLineHD");
                da.Dispose();
                dgvTimeLandHD.DataSource = tdsTimeLandHD.tbTimeLineHD;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            SelectRowIndex = -1;
        }

        private void ShowData()
        {
            try
            {
                string sqlTmp = "";
                sqlTmp = "SELECT * FROM tbTimeLineHD ORDER BY TimeLineDate";
                DataSet Ds = new DataSet();
                dbConString.Com = new SqlCommand();
                dbConString.Com.CommandType = CommandType.Text;
                dbConString.Com.CommandText = sqlTmp;
                dbConString.Com.Connection = dbConString.mySQLConn;
                SqlCommand cmd = new SqlCommand(sqlTmp, dbConString.mySQLConn);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                tdsTimeLandHD.Clear();
                da.Fill(tdsTimeLandHD, "tbTimeLineHD");
                da.Dispose();
                dgvTimeLandHD.DataSource = tdsTimeLandHD.tbTimeLineHD;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            SelectRowIndex = -1;


        }

        private void dgvTimeLandHD_CellMouseUp(object sender, DataGridViewCellMouseEventArgs e)
        {
            SelectRowIndex = e.RowIndex;
            btnStatus(false);
        }

        private void dgvTimeLandHD_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (dgvTimeLandHD.RowCount > 0)
            {
                TimeLineInfo frmForm = new TimeLineInfo();
                frmForm.FormState = "edit";
                frmForm.LandID = LandID;
                frmForm.TimeLineHDID = dgvTimeLandHD.Rows[SelectRowIndex].Cells[colTimeLineHDID.Name].Value.ToString();
                frmForm.ShowDialog();
                btnStatus(true);
            }
            ShowData();
        }
    }
}
