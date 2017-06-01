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
using DevComponents.DotNetBar;
using DevComponents.DotNetBar.SuperGrid;
using Application_Service;
using Application_Form.ApplicationData;
using Application_Service.ClassService;
using Application_Report;
using Application_Report.Data;


namespace Application_Form
{
    public partial class LandInfo : BaseInfo
    {
        public LandInfo()
        {
            InitializeComponent();
            //InitializeGrid();
        }

        public string LandID = string.Empty;
        ApplicationDS tdsLand = new ApplicationDS();
        ApplicationDS tdsAddress = new ApplicationDS();
        ApplicationDS tdsTimeLineHD = new ApplicationDS();

        string sqlTmp = string.Empty;
        string TempTimeLineHDID = string.Empty;
        ReportDS dsReport = new ReportDS();
        int SelectRowIndex = -1;

        public static ApplicationDS.tbEvidenceRow drEvidenceTemp
        { get; set; }

        private void btnAreaPrint_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(LandID))
            {
                string Whereclause = string.Empty;
                if (!string.IsNullOrEmpty(txtSearch.Text))
                {
                    Whereclause = txtSearch.Text;
                }
                else
                {
                    Whereclause = string.Empty;
                }

                try
                {
                    string sqlTmp = "";
                    sqlTmp = "SELECT * FROM uv_TimelineALL ";
                    if (!string.IsNullOrEmpty(Whereclause))
                    {
                        sqlTmp += " WHERE LandID = '" + LandID + "' TimeLineDate LIKE '%" + Whereclause + "%' OR TitleEvent LIKE '%" + Whereclause + "%' ";
                    }
                    else
                    {
                        sqlTmp += " WHERE LandID = '" + LandID + "'";
                    }
                    sqlTmp += " ORDER BY TimeLineDate";
                    DataSet Ds = new DataSet();
                    dbConString.Com = new SqlCommand();
                    dbConString.Com.CommandType = CommandType.Text;
                    dbConString.Com.CommandText = sqlTmp;
                    dbConString.Com.Connection = dbConString.mySQLConn;
                    SqlCommand cmd = new SqlCommand(sqlTmp, dbConString.mySQLConn);
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    dsReport.Clear();
                    da.Fill(dsReport, "uv_TimelineALL");
                    da.Dispose();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }

            dsReport.Merge(tdsLand);

            // Create a new instance of EvidenceInfoForm
            ReportPreview ReportPreviewForm = new ReportPreview();
            // Pass Dataset to PreviewReport From
            ReportPreviewForm.GetDataSet = dsReport;
            // Display the form as top most form.
            ReportPreviewForm.TopMost = true;

            // Show the settings form
            ReportPreviewForm.Show();
        }

        protected override void DoLoadForm()
        {
            LoadProvince();
            switch (FormState.ToLower())
            {
                case "new":
                    LandID = string.Empty;
                    break;
                case "edit":
                    DoLoadData(LandID);
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

            if (!Success)
                return;

            //Check Duplicate
            if (Success == true && tdsLand.tbLand.Rows.Count > 0)
            {
                Success = Utilities.CheckDuplicateNotInOldValues(tdsLand.tbLand.TableName,
                                                                tdsLand.tbLand.LandCodeColumn.ColumnName,
                                                                txtLandCode.Text,
                                                                tdsLand.tbLand[0].LandCode);
                if (!Success)
                {
                    MessageBox.Show("รหัสพื้นที่ไม่สามารถซ้ำได้ กรุณาป้อนข้อมูลใหม่", "คำเตือน", MessageBoxButtons.OK);
                    Success = false;
                    return;
                }
            }
            else
            {
                Success = Utilities.CheckDuplicate(tdsLand.tbLand.TableName,
                                                  tdsLand.tbLand.LandCodeColumn.ColumnName,
                                                  txtLandCode.Text);
                if (!Success)
                {
                    MessageBox.Show("ชื่อพยาน/หลักฐานไม่สามารถซ้ำได้ กรุณาป้อนข้อมูลใหม่", "คำเตือน", MessageBoxButtons.OK);
                    Success = false;
                    return;
                }
            }

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
                            #region tbTimeLand
                            LandID = Guid.NewGuid().ToString();
                            dbConString.Transaction = dbConString.mySQLConn.BeginTransaction();
                            StringBuilder StringBd = new StringBuilder();
                            StringBd.Clear();
                            sqlTmp = string.Empty;
                            StringBd.Append("INSERT INTO tbLand VALUES (@LandID,@LandCode,@VillageName,@VillageNo,@SubDistrict,@District,@Province,@History,@Distress,@CreatedBy,GETDATE())");
                            sqlTmp = "";
                            sqlTmp = StringBd.ToString();

                            dbConString.Com = new SqlCommand();
                            dbConString.Com.CommandText = sqlTmp;
                            dbConString.Com.CommandType = CommandType.Text;
                            dbConString.Com.Connection = dbConString.mySQLConn;
                            dbConString.Com.Transaction = dbConString.Transaction;
                            dbConString.Com.Parameters.Clear();
                            dbConString.Com.Parameters.Add("@LandID", SqlDbType.VarChar).Value = LandID;
                            dbConString.Com.Parameters.Add("@LandCode", SqlDbType.VarChar).Value = txtLandCode.Text;
                            dbConString.Com.Parameters.Add("@VillageName", SqlDbType.VarChar).Value = txtVillageName.Text;
                            dbConString.Com.Parameters.Add("@VillageNo", SqlDbType.VarChar).Value = txtVillageNo.Text;
                            dbConString.Com.Parameters.Add("@SubDistrict", SqlDbType.VarChar).Value = txtSubDistrict.Text;
                            dbConString.Com.Parameters.Add("@District", SqlDbType.VarChar).Value = txtDistrict.Text;
                            dbConString.Com.Parameters.Add("@Province", SqlDbType.VarChar).Value = txtProvince.Text;
                            dbConString.Com.Parameters.Add("@History", SqlDbType.VarChar).Value = txtHistory.Text;
                            dbConString.Com.Parameters.Add("@Distress", SqlDbType.VarChar).Value = txtDistress.Text;
                            dbConString.Com.Parameters.Add("@CreatedBy", SqlDbType.VarChar).Value = dbConString.UserID;
                            dbConString.Com.ExecuteNonQuery();
                            
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
                            StringBd.Clear();
                            sqlTmp = string.Empty;
                            StringBd.Append("UPDATE tbLand SET LandCode = @LandCode, VillageName = @VillageName,VillageNo = @VillageNo,SubDistrict = @SubDistrict,District = @District,");
                            StringBd.Append(" Province = @Province,History = @History,Distress = @Distress,CreatedBy = @CreatedBy WHERE LandID = @LandID; ");
                            sqlTmp = "";
                            sqlTmp = StringBd.ToString();

                            dbConString.Com = new SqlCommand();
                            dbConString.Com.CommandText = sqlTmp;
                            dbConString.Com.CommandType = CommandType.Text;
                            dbConString.Com.Connection = dbConString.mySQLConn;
                            dbConString.Com.Transaction = dbConString.Transaction;
                            dbConString.Com.Parameters.Clear();
                            dbConString.Com.Parameters.Add("@LandID", SqlDbType.VarChar).Value = LandID;
                            dbConString.Com.Parameters.Add("@LandCode", SqlDbType.VarChar).Value = txtLandCode.Text;
                            dbConString.Com.Parameters.Add("@VillageName", SqlDbType.VarChar).Value = txtVillageName.Text;
                            dbConString.Com.Parameters.Add("@VillageNo", SqlDbType.VarChar).Value = txtVillageNo.Text;
                            dbConString.Com.Parameters.Add("@SubDistrict", SqlDbType.VarChar).Value = txtSubDistrict.Text;
                            dbConString.Com.Parameters.Add("@District", SqlDbType.VarChar).Value = txtDistrict.Text;
                            dbConString.Com.Parameters.Add("@Province", SqlDbType.VarChar).Value = txtProvince.Text;
                            dbConString.Com.Parameters.Add("@History", SqlDbType.VarChar).Value = txtHistory.Text;
                            dbConString.Com.Parameters.Add("@Distress", SqlDbType.VarChar).Value = txtDistress.Text;
                            dbConString.Com.Parameters.Add("@CreatedBy", SqlDbType.VarChar).Value = dbConString.UserID;
                            dbConString.Com.ExecuteNonQuery();
                            dbConString.Transaction.Commit();

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
                    #endregion
                    break;
            }
        }

        protected override void DoReset()
        {
            txtLandCode.Clear();
            txtVillageName.Clear();
            txtVillageNo.Clear();
            txtSubDistrict.Clear();
            txtDistrict.Clear();
            txtProvince.Clear();
            txtDistress.Clear();
            txtHistory.Clear();

            tdsTimeLineHD.Clear();
            dgvTimeLandHD.DataSource = tdsTimeLineHD.tbTimeLineHD;
        }

        private void DoLoadData(string LandID)
        {
            #region ALL Data
            try
            {
                string sqlTmp = "";
                sqlTmp = "SELECT * FROM tbLand WHERE LandID = '" + LandID + "'";
                DataSet Ds = new DataSet();
                dbConString.Com = new SqlCommand();
                dbConString.Com.CommandType = CommandType.Text;
                dbConString.Com.CommandText = sqlTmp;
                dbConString.Com.Connection = dbConString.mySQLConn;
                dbConString.Com.Parameters.Clear();
                SqlCommand cmd = new SqlCommand(sqlTmp, dbConString.mySQLConn);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                tdsLand.Clear();
                da.Fill(tdsLand, "tbLand");
                da.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            #endregion

            if (tdsLand.tbLand.Rows.Count > 0)
            {
                LandID = tdsLand.tbLand[0].LandID;
                txtLandCode.Text = tdsLand.tbLand[0].LandCode;
                txtVillageName.Text = tdsLand.tbLand[0].VillageName;
                txtVillageNo.Text = tdsLand.tbLand[0].VillageNo;
                txtSubDistrict.Text = tdsLand.tbLand[0].SubDistrict;
                txtDistrict.Text = tdsLand.tbLand[0].District;
                txtProvince.Text = tdsLand.tbLand[0].Province;
                txtHistory.Text = tdsLand.tbLand[0].History;
                txtDistress.Text = tdsLand.tbLand[0].Distress;
                SearchTimeLineHD(LandID);
            }
        }

        private void DoCheckData()
        {
            if (string.IsNullOrEmpty(txtLandCode.Text))
            {
                MessageBox.Show("รหัสพื้นที่ไม่สามารถเป็นค่าว่างได้ กรุณาป้อนข้อมูล", "Warning", MessageBoxButtons.OK);
                Success = false;
                txtLandCode.Focus();
                return;
            }

            if (string.IsNullOrEmpty(txtVillageName.Text))
            {
                MessageBox.Show("ชื่อหมู่บ้านไม่สามารถเป็นค่าว่างได้ กรุณาป้อนข้อมูล", "Warning", MessageBoxButtons.OK);
                Success = false;
                txtVillageName.Focus();
                return;
            }

            if (string.IsNullOrEmpty(txtVillageNo.Text))
            {
                MessageBox.Show("หมู่ไม่สามารถเป็นค่าว่างได้ กรุณาป้อนข้อมูล", "Warning", MessageBoxButtons.OK);
                Success = false;
                txtVillageNo.Focus();
                return;
            }

            if (string.IsNullOrEmpty(txtSubDistrict.Text))
            {
                MessageBox.Show("ตำบลไม่สามารถเป็นค่าว่างได้ กรุณาป้อนข้อมูล", "Warning", MessageBoxButtons.OK);
                Success = false;
                txtSubDistrict.Focus();
                return;
            }

            if (string.IsNullOrEmpty(txtDistrict.Text))
            {
                MessageBox.Show("อำเภอไม่สามารถเป็นค่าว่างได้ กรุณาป้อนข้อมูล", "Warning", MessageBoxButtons.OK);
                Success = false;
                txtDistrict.Focus();
                return;
            }

            if (string.IsNullOrEmpty(txtProvince.Text))
            {
                MessageBox.Show("จังหวัดไม่สามารถเป็นค่าว่างได้ กรุณาป้อนข้อมูล", "Warning", MessageBoxButtons.OK);
                Success = false;
                txtProvince.Focus();
                return;
            }
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(LandID))
            {
                string Whereclause = string.Empty;
                if (!string.IsNullOrEmpty(txtSearch.Text))
                {
                    Whereclause = txtSearch.Text;
                }
                else
                {
                    Whereclause = string.Empty;
                }

                try
                {
                    string sqlTmp = "";
                    sqlTmp = "SELECT * FROM uv_TimelineALL ";
                    if (!string.IsNullOrEmpty(Whereclause))
                    {
                        sqlTmp += " WHERE LandID = '" + LandID + "' TimeLineDate LIKE '%" + Whereclause + "%' OR TitleEvent LIKE '%" + Whereclause + "%' ";
                    }
                    else
                    {
                        sqlTmp += " WHERE LandID = '" + LandID + "'";
                    }
                    sqlTmp += " ORDER BY TimeLineDate";
                    DataSet Ds = new DataSet();
                    dbConString.Com = new SqlCommand();
                    dbConString.Com.CommandType = CommandType.Text;
                    dbConString.Com.CommandText = sqlTmp;
                    dbConString.Com.Connection = dbConString.mySQLConn;
                    SqlCommand cmd = new SqlCommand(sqlTmp, dbConString.mySQLConn);
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    dsReport.Clear();
                    da.Fill(dsReport, "uv_TimelineALL");
                    da.Dispose();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }

            dsReport.Merge(tdsLand);

            // Create a new instance of EvidenceInfoForm
            ReportPreview ReportPreviewForm = new ReportPreview();
            // Pass Dataset to PreviewReport From
            ReportPreviewForm.GetDataSet = dsReport;
            // Display the form as top most form.
            ReportPreviewForm.TopMost = true;

            // Show the settings form
            ReportPreviewForm.Show();
        }

        private void LoadProvince()
        {
            #region ALL Data
            try
            {
                string sqlTmp = "";
                sqlTmp = "SELECT * FROM uv_Address ";
                DataSet Ds = new DataSet();
                dbConString.Com = new SqlCommand();
                dbConString.Com.CommandType = CommandType.Text;
                dbConString.Com.CommandText = sqlTmp;
                dbConString.Com.Connection = dbConString.mySQLConn;
                dbConString.Com.Parameters.Clear();
                SqlCommand cmd = new SqlCommand(sqlTmp, dbConString.mySQLConn);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                tdsLand.Clear();
                da.Fill(tdsAddress, "uv_Address");
                da.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            #endregion

            AutoCompleteStringCollection namesCollection = new AutoCompleteStringCollection();
            if (tdsAddress.uv_Address.Rows.Count > 0)
            {
                foreach (ApplicationDS.uv_AddressRow dr in tdsAddress.uv_Address.Select())
                {
                    namesCollection.Add(dr.PROVINCE_NAME.ToString().Trim());
                }
            }

            txtProvince.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            txtProvince.AutoCompleteSource = AutoCompleteSource.CustomSource;
            txtProvince.AutoCompleteCustomSource = namesCollection;

            LoadDistrict();
            LoadSubDistrict();
        }

        private void LoadDistrict()
        {
            AutoCompleteStringCollection namesCollection = new AutoCompleteStringCollection();
            if (tdsAddress.uv_Address.Rows.Count > 0)
            {
                foreach (ApplicationDS.uv_AddressRow dr in tdsAddress.uv_Address.Select())
                {
                    namesCollection.Add(dr.AMPHUR_NAME.ToString().Trim());
                }
            }

            txtDistrict.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            txtDistrict.AutoCompleteSource = AutoCompleteSource.CustomSource;
            txtDistrict.AutoCompleteCustomSource = namesCollection;
        }

        private void LoadSubDistrict()
        {
            AutoCompleteStringCollection namesCollection = new AutoCompleteStringCollection();
            if (tdsAddress.uv_Address.Rows.Count > 0)
            {
                foreach (ApplicationDS.uv_AddressRow dr in tdsAddress.uv_Address.Select())
                {
                    namesCollection.Add(dr.DISTRICT_NAME.ToString().Trim());
                }
            }

            txtSubDistrict.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            txtSubDistrict.AutoCompleteSource = AutoCompleteSource.CustomSource;
            txtSubDistrict.AutoCompleteCustomSource = namesCollection;
        }

        private void btnStatus(bool xStatus)//สถานะปุ่ม
        {
            if (xStatus == true)
            {
                //tsSave.Enabled = true;
                btnEdit.Enabled = false;
                btnDel.Enabled = false;
            }
            else if (xStatus == false)
            {
                //tsSave.Enabled = false;
                btnEdit.Enabled = true;
                btnDel.Enabled = true;
            }
        }

        private void SearchTimeLineHD(string LandIDTemp)
        {
            if (!string.IsNullOrEmpty(LandIDTemp))
            {
                string Whereclause = string.Empty;
                if (!string.IsNullOrEmpty(txtSearch.Text))
                {
                    Whereclause = txtSearch.Text;
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
                        sqlTmp += " WHERE LandID = '" + LandIDTemp + "' TimeLineDate LIKE '%" + Whereclause + "%' OR TitleEvent LIKE '%" + Whereclause + "%' ";
                    }
                    else
                    {
                        sqlTmp += " WHERE LandID = '" + LandIDTemp + "'";
                    }
                    sqlTmp += " ORDER BY TimeLineDate";
                    DataSet Ds = new DataSet();
                    dbConString.Com = new SqlCommand();
                    dbConString.Com.CommandType = CommandType.Text;
                    dbConString.Com.CommandText = sqlTmp;
                    dbConString.Com.Connection = dbConString.mySQLConn;
                    SqlCommand cmd = new SqlCommand(sqlTmp, dbConString.mySQLConn);
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    tdsTimeLineHD.Clear();
                    da.Fill(tdsTimeLineHD, "tbTimeLineHD");
                    da.Dispose();
                    dgvTimeLandHD.DataSource = tdsTimeLineHD.tbTimeLineHD;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
                SelectRowIndex = -1;
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            CallSave();
            if (!string.IsNullOrEmpty(LandID))
            {
                TimeLineInfo frmForm = new TimeLineInfo();
                frmForm.LandID = LandID;
                frmForm.FormState = "new";
                frmForm.ShowDialog();
                btnStatus(true);
                SearchTimeLineHD(LandID);
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (dgvTimeLandHD.RowCount > 0)
            {
                CallSave();
                TimeLineInfo frmForm = new TimeLineInfo();
                frmForm.FormState = "edit";
                frmForm.LandID = LandID;
                frmForm.TimeLineHDID = dgvTimeLandHD.Rows[SelectRowIndex].Cells[colTimeLineHDID.Name].Value.ToString();
                frmForm.ShowDialog();
                btnStatus(true);
            }
            SearchTimeLineHD(LandID);
        }

        private void dgvTimeLandHD_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (dgvTimeLandHD.RowCount > 0)
            {
                CallSave();
                TimeLineInfo frmForm = new TimeLineInfo();
                frmForm.FormState = "edit";
                frmForm.LandID = LandID;
                frmForm.TimeLineHDID = dgvTimeLandHD.Rows[SelectRowIndex].Cells[colTimeLineHDID.Name].Value.ToString();
                frmForm.ShowDialog();
                btnStatus(true);
            }
            SearchTimeLineHD(LandID);
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            if (SelectRowIndex > -1)
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
                    SearchTimeLineHD(LandID);
                }
                catch
                {
                    dbConString.Transaction.Rollback();
                }
            }
        }

        private void BtnSearch_Click(object sender, EventArgs e)
        {
            SearchTimeLineHD(LandID);
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            SearchTimeLineHD(LandID);
        }

        private void dgvTimeLandHD_CellMouseUp(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex > -1)
                SelectRowIndex = e.RowIndex;
        }

    }

}
