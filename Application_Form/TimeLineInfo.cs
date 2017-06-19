using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Diagnostics;
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
    public partial class TimeLineInfo : BaseInfo
    {
        public TimeLineInfo()
        {
            InitializeComponent();
        }

        public string LandID = string.Empty;
        public string TimeLineHDID = string.Empty;
        string sqlTmp = string.Empty;
        int SelectIndexDT = -1;
        ApplicationDS tdsTimeLine = new ApplicationDS();
        public static ApplicationDS.tbEvidenceRow drEvidenceTemp
        { get; set; }

        protected override void DoLoadForm()
        {
            btnDelDT.Enabled = false;

            switch (FormState.ToLower())
            {
                case "new":
                    if (string.IsNullOrEmpty(TimeLineHDID))
                        TimeLineHDID = Guid.NewGuid().ToString();
                    break;
                case "edit":
                    DoLoadData(TimeLineHDID);
                    break;
                default:
                    FormState = "new";
                    LandID = string.Empty;
                    break;
            }
        }
        protected override void DoSave()
        {
            Success = true;
            DoCheckData();

            if (MessageBox.Show("คุณต้องการบันทึกข้อมูล ใช่หรือไม่ ?", dbConString.xMessage, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.No)
            {
                return;
            }

            switch (FormState.ToLower())
            {
                case "new":
                    #region Save
                    if (Success)
                    {
                        try
                        {
                            #region
                            dbConString.Transaction = dbConString.mySQLConn.BeginTransaction();
                            StringBuilder StringBd = new StringBuilder();

                            

                            StringBd.Clear();
                            sqlTmp = string.Empty;
                            StringBd.Append("INSERT INTO tbTimeLineHD VALUES (@TimeLineHDID,@LandID,@TimeLineDate,@TitleEvent,@TimeLineEvent,@Remark,@CreatedBy,GETDATE())");
                            sqlTmp = "";
                            sqlTmp = StringBd.ToString();
                            dbConString.Com = new SqlCommand();
                            dbConString.Com.CommandText = sqlTmp;
                            dbConString.Com.CommandType = CommandType.Text;
                            dbConString.Com.Connection = dbConString.mySQLConn;
                            dbConString.Com.Transaction = dbConString.Transaction;
                            dbConString.Com.Parameters.Clear();
                            dbConString.Com.Parameters.Add("@TimeLineHDID", SqlDbType.VarChar).Value = TimeLineHDID;
                            dbConString.Com.Parameters.Add("@LandID", SqlDbType.VarChar).Value = LandID;
                            dbConString.Com.Parameters.Add("@TimeLineDate", SqlDbType.DateTime).Value = dtpTimeLineDate.Value;
                            dbConString.Com.Parameters.Add("@TitleEvent", SqlDbType.VarChar).Value = string.Empty;
                            dbConString.Com.Parameters.Add("@TimeLineEvent", SqlDbType.VarChar).Value = txtEvent.Text;
                            dbConString.Com.Parameters.Add("@Remark", SqlDbType.VarChar).Value = txtRemark.Text;
                            dbConString.Com.Parameters.Add("@CreatedBy", SqlDbType.VarChar).Value = dbConString.UserID;
                            dbConString.Com.ExecuteNonQuery();

                            #endregion

                            #region
                            foreach (ApplicationDS.tbTimeLineDTRow drDT in tdsTimeLine.tbTimeLineDT.Select(""))
                            {
                                StringBd.Clear();
                                sqlTmp = string.Empty;
                                StringBd.Append("INSERT INTO tbTimeLineDT VALUES (@TimeLineDTID,@TimeLineHDID,@EvidenceID,@CreatedBy,GETDATE())");
                                sqlTmp = "";
                                sqlTmp = StringBd.ToString();
                                dbConString.Com = new SqlCommand();
                                dbConString.Com.CommandText = sqlTmp;
                                dbConString.Com.CommandType = CommandType.Text;
                                dbConString.Com.Connection = dbConString.mySQLConn;
                                dbConString.Com.Transaction = dbConString.Transaction;
                                dbConString.Com.Parameters.Clear();
                                dbConString.Com.Parameters.Add("@TimeLineDTID", SqlDbType.VarChar).Value = drDT.TimeLineDTID;
                                dbConString.Com.Parameters.Add("@TimeLineHDID", SqlDbType.VarChar).Value = drDT.TimeLineHDID;
                                dbConString.Com.Parameters.Add("@EvidenceID", SqlDbType.VarChar).Value = drDT.EvidenceID;
                                dbConString.Com.Parameters.Add("@CreatedBy", SqlDbType.VarChar).Value = dbConString.UserID;
                                dbConString.Com.ExecuteNonQuery();
                            }
                            #endregion

                            dbConString.Transaction.Commit();
                            FormState = "edit";
                            MessageBox.Show("บันทึกค่าเรียบร้อย", "OK", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        catch
                        {
                            dbConString.Transaction.Rollback();
                        }
                    }
                    else
                    {
                        return;
                    }
                    #endregion
                    break;
                case "edit":
                    #region Edit
                    if (Success)
                    {
                        try
                        {
                            
                            dbConString.Transaction = dbConString.mySQLConn.BeginTransaction();
                            StringBuilder StringBd = new StringBuilder();

                            #region
                            StringBd.Clear();
                            sqlTmp = string.Empty;
                            StringBd.Append("UPDATE tbTimeLineHD SET TimeLineDate = @TimeLineDate, TimeLineEvent = @TimeLineEvent, Remark = @Remark,");
                            StringBd.Append(" TitleEvent = @TitleEvent, CreatedBy = @CreatedBy WHERE TimeLineHDID = @TimeLineHDID;");
                            StringBd.Append(" DELETE tbTimeLineDT WHERE TimeLineHDID = @TimeLineHDID;");
                            sqlTmp = "";
                            sqlTmp = StringBd.ToString();
                            dbConString.Com = new SqlCommand();
                            dbConString.Com.CommandText = sqlTmp;
                            dbConString.Com.CommandType = CommandType.Text;
                            dbConString.Com.Connection = dbConString.mySQLConn;
                            dbConString.Com.Transaction = dbConString.Transaction;
                            dbConString.Com.Parameters.Clear();
                            dbConString.Com.Parameters.Add("@TimeLineHDID", SqlDbType.VarChar).Value = TimeLineHDID;
                            dbConString.Com.Parameters.Add("@TimeLineDate", SqlDbType.DateTime).Value = dtpTimeLineDate.Value;
                            dbConString.Com.Parameters.Add("@TitleEvent", SqlDbType.VarChar).Value = string.Empty;
                            dbConString.Com.Parameters.Add("@TimeLineEvent", SqlDbType.VarChar).Value = txtEvent.Text;
                            dbConString.Com.Parameters.Add("@Remark", SqlDbType.VarChar).Value = txtRemark.Text;
                            dbConString.Com.Parameters.Add("@CreatedBy", SqlDbType.VarChar).Value = dbConString.UserID;
                            dbConString.Com.ExecuteNonQuery();
                            #endregion

                            #region
                            foreach (ApplicationDS.tbTimeLineDTRow drDT in tdsTimeLine.tbTimeLineDT.Select(""))
                            {
                                StringBd.Clear();
                                sqlTmp = string.Empty;
                                StringBd.Append("INSERT INTO tbTimeLineDT VALUES (@TimeLineDTID,@TimeLineHDID,@EvidenceID,@CreatedBy,GETDATE())");
                                sqlTmp = "";
                                sqlTmp = StringBd.ToString();
                                dbConString.Com = new SqlCommand();
                                dbConString.Com.CommandText = sqlTmp;
                                dbConString.Com.CommandType = CommandType.Text;
                                dbConString.Com.Connection = dbConString.mySQLConn;
                                dbConString.Com.Transaction = dbConString.Transaction;
                                dbConString.Com.Parameters.Clear();
                                dbConString.Com.Parameters.Add("@TimeLineDTID", SqlDbType.VarChar).Value = drDT.TimeLineDTID;
                                dbConString.Com.Parameters.Add("@TimeLineHDID", SqlDbType.VarChar).Value = drDT.TimeLineHDID;
                                dbConString.Com.Parameters.Add("@EvidenceID", SqlDbType.VarChar).Value = drDT.EvidenceID;
                                dbConString.Com.Parameters.Add("@CreatedBy", SqlDbType.VarChar).Value = dbConString.UserID;
                                dbConString.Com.ExecuteNonQuery();
                            }
                            #endregion

                            dbConString.Transaction.Commit();
                            #endregion
                            MessageBox.Show("บันทึกค่าเรียบร้อย", "OK", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            //this.Close();
                        }
                        catch (Exception ex)
                        {
                            dbConString.Transaction.Rollback();
                        }
                    }
                    else
                    {
                        return;
                    }
                    
                    break;
            }
        }
        protected override void DoReset()
        {
            tdsTimeLine.Clear();
            dgvTimeLandDT.DataSource = tdsTimeLine.tbTimeLineDT;

            txtTitleEvent.Clear();
            txtRemark.Clear();
            txtEvent.Clear();
            dtpTimeLineDate.Value = DateTime.Today;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            EvidenceListPicker frm = new EvidenceListPicker();
            frm.ShowDialog();
            drEvidenceTemp = frm.drEvidence;
            if (drEvidenceTemp != null)
            {
                ApplicationDS.tbTimeLineDTRow dr = tdsTimeLine.tbTimeLineDT.NewtbTimeLineDTRow();
                dr.TimeLineHDID = TimeLineHDID;
                dr.TimeLineDTID = Guid.NewGuid().ToString();
                dr.EvidenceID = drEvidenceTemp.EvidenceID;
                dr.EvidenceCode = drEvidenceTemp.EvidenceCode;
                dr.EvidenceName = drEvidenceTemp.EvidenceName;
                dr.Detail = drEvidenceTemp.Detail;
                tdsTimeLine.tbTimeLineDT.Rows.Add(dr);
            }

            dgvTimeLandDT.DataSource = tdsTimeLine.tbTimeLineDT;              
        }

        private void btnDelDT_Click(object sender, EventArgs e)
        {
            string TimeLineDTID = string.Empty;

            if (dgvTimeLandDT.Rows.Count > 0 && SelectIndexDT > -1)
            {
                if (dgvTimeLandDT.Rows[SelectIndexDT].Cells[colTimeLineDTID.Name].Value != null)
                {
                    TimeLineDTID = dgvTimeLandDT.Rows[SelectIndexDT].Cells[colTimeLineDTID.Name].Value.ToString();
                    ApplicationDS.tbTimeLineDTRow[] drDT_Del = (ApplicationDS.tbTimeLineDTRow[])tdsTimeLine.tbTimeLineDT.Select("TimeLineDTID = '" + TimeLineDTID + "'");

                    //Del DT
                    if (drDT_Del.Length > 0)
                    {
                        foreach (ApplicationDS.tbTimeLineDTRow dr in drDT_Del)
                        {
                            dr.Delete();
                        }
                        //tdsTempDTMain.tbTimeLineDT.AcceptChanges();
                    }

                    btnDelDT.Enabled = false;
                    btnAdd.Enabled = true;
                }
            }
        }

        private void dgvTimeLandDT_CellMouseUp(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                SelectIndexDT = e.RowIndex;
                btnDelDT.Enabled = true;
            }
        }

        private void DoLoadData(string TimeLineHDIDTemp)
        {
            #region ALL Data
            try
            {
                string sqlTmp = "";
                DataSet Ds = new DataSet();


                sqlTmp = "";
                sqlTmp = "SELECT * FROM tbTimeLineHD WHERE TimeLineHDID = '" + TimeLineHDIDTemp + "'";
                Ds = new DataSet();
                dbConString.Com = new SqlCommand();
                dbConString.Com.CommandType = CommandType.Text;
                dbConString.Com.CommandText = sqlTmp;
                dbConString.Com.Connection = dbConString.mySQLConn;
                dbConString.Com.Parameters.Clear();
                SqlCommand cmd = new SqlCommand(sqlTmp, dbConString.mySQLConn);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                tdsTimeLine.Clear();
                da.Fill(tdsTimeLine, "tbTimeLineHD");
                da.Dispose();

                sqlTmp = "";
                sqlTmp = "SELECT DT.*,EV.EvidenceCode,EV.EvidenceName,EV.EvidenceType,EV.Detail,EV.Path FROM tbTimeLineDT AS DT LEFT JOIN tbTimeLineHD AS HD ON DT.TimeLineHDID = HD.TimeLineHDID LEFT JOIN tbEvidence AS EV ON DT.EvidenceID = EV.EvidenceID WHERE HD.TimeLineHDID = '" + TimeLineHDIDTemp + "'";
                Ds = new DataSet();
                dbConString.Com = new SqlCommand();
                dbConString.Com.CommandType = CommandType.Text;
                dbConString.Com.CommandText = sqlTmp;
                dbConString.Com.Connection = dbConString.mySQLConn;
                dbConString.Com.Parameters.Clear();
                cmd = new SqlCommand(sqlTmp, dbConString.mySQLConn);
                da = new SqlDataAdapter(cmd);
                da.Fill(tdsTimeLine, "tbTimeLineDT");
                da.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            #endregion

            if (tdsTimeLine.tbTimeLineHD.Rows.Count > 0)
            {
                dtpTimeLineDate.Value = tdsTimeLine.tbTimeLineHD[0].TimeLineDate;
                //txtTitleEvent.Text = tdsTimeLine.tbTimeLineHD[0].TitleEvent;
                txtEvent.Text = tdsTimeLine.tbTimeLineHD[0].TimeLineEvent;
                txtRemark.Text = tdsTimeLine.tbTimeLineHD[0].Remark;
                //
                dgvTimeLandDT.DataSource = tdsTimeLine.tbTimeLineDT;
            }
        }

        private void DoCheckData()
        {
            if (string.IsNullOrEmpty(txtEvent.Text))
            {
                MessageBox.Show("เหตุการณ์ ไม่สามารถเป็นค่าว่างได้ กรุณาป้อนข้อมูล", "Warning", MessageBoxButtons.OK);
                Success = false;
                txtEvent.Focus();
                return;
            }           
        }

        private void dgvTimeLandDT_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (SelectIndexDT > -1)
            {
                string PathTemp = dgvTimeLandDT.Rows[SelectIndexDT].Cells[colPath.Name].Value.ToString();
                if (File.Exists(PathTemp))
                {
                    Process.Start(PathTemp);
                }
                else
                {
                    MessageBox.Show("ไม่พบ File ", dbConString.xMessage, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }
    }
}
