namespace Application_Form
{
    partial class LandInfo
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.txtDistress = new System.Windows.Forms.RichTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtHistory = new System.Windows.Forms.RichTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtProvince = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtDistrict = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtSubDistrict = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtVillageNo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.dgvTimeLandHD = new System.Windows.Forms.DataGridView();
            this.colTimeLineDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTitleEvent = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTimeLineEvent = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTimeLineHDID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colLandID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colRemark = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCreatedBy = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCreatedDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tbTimeLineHDBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.applicationDS2 = new Application_Form.ApplicationData.ApplicationDS();
            this.panel1 = new System.Windows.Forms.Panel();
            this.BtnSearch = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnDel = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtVillageName = new System.Windows.Forms.TextBox();
            this.txtLandCode = new System.Windows.Forms.TextBox();
            this.lblLandCode = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTimeLandHD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbTimeLineHDBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.applicationDS2)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 39);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(866, 479);
            this.tabControl1.TabIndex = 26;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.txtLandCode);
            this.tabPage1.Controls.Add(this.lblLandCode);
            this.tabPage1.Controls.Add(this.txtDistress);
            this.tabPage1.Controls.Add(this.label7);
            this.tabPage1.Controls.Add(this.txtHistory);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.txtProvince);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.txtDistrict);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.txtSubDistrict);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.txtVillageNo);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.txtVillageName);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabPage1.Size = new System.Drawing.Size(858, 450);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "ข้อมูลพื้นที่";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // txtDistress
            // 
            this.txtDistress.Location = new System.Drawing.Point(443, 155);
            this.txtDistress.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtDistress.MaxLength = 500;
            this.txtDistress.Name = "txtDistress";
            this.txtDistress.Size = new System.Drawing.Size(407, 287);
            this.txtDistress.TabIndex = 41;
            this.txtDistress.Text = "";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(440, 133);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(192, 17);
            this.label7.TabIndex = 39;
            this.label7.Text = "ปัญหาด้านที่ดินป่าไม้ของชุมชน ";
            // 
            // txtHistory
            // 
            this.txtHistory.Location = new System.Drawing.Point(20, 154);
            this.txtHistory.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtHistory.MaxLength = 500;
            this.txtHistory.Name = "txtHistory";
            this.txtHistory.Size = new System.Drawing.Size(417, 287);
            this.txtHistory.TabIndex = 37;
            this.txtHistory.Text = "";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(17, 133);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(173, 17);
            this.label6.TabIndex = 36;
            this.label6.Text = "ประวัติความเป็นมาของชุมชน";
            // 
            // txtProvince
            // 
            this.txtProvince.Location = new System.Drawing.Point(401, 83);
            this.txtProvince.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtProvince.MaxLength = 100;
            this.txtProvince.Name = "txtProvince";
            this.txtProvince.Size = new System.Drawing.Size(233, 24);
            this.txtProvince.TabIndex = 35;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.DarkRed;
            this.label5.Location = new System.Drawing.Point(340, 86);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 17);
            this.label5.TabIndex = 34;
            this.label5.Text = "จังหวัด";
            // 
            // txtDistrict
            // 
            this.txtDistrict.Location = new System.Drawing.Point(93, 83);
            this.txtDistrict.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtDistrict.MaxLength = 100;
            this.txtDistrict.Name = "txtDistrict";
            this.txtDistrict.Size = new System.Drawing.Size(233, 24);
            this.txtDistrict.TabIndex = 33;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.DarkRed;
            this.label4.Location = new System.Drawing.Point(19, 86);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 17);
            this.label4.TabIndex = 32;
            this.label4.Text = "อำเภอ";
            // 
            // txtSubDistrict
            // 
            this.txtSubDistrict.Location = new System.Drawing.Point(493, 51);
            this.txtSubDistrict.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtSubDistrict.MaxLength = 100;
            this.txtSubDistrict.Name = "txtSubDistrict";
            this.txtSubDistrict.Size = new System.Drawing.Size(141, 24);
            this.txtSubDistrict.TabIndex = 31;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.DarkRed;
            this.label3.Location = new System.Drawing.Point(445, 54);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 17);
            this.label3.TabIndex = 30;
            this.label3.Text = "ตำบล";
            // 
            // txtVillageNo
            // 
            this.txtVillageNo.Location = new System.Drawing.Point(371, 51);
            this.txtVillageNo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtVillageNo.MaxLength = 5;
            this.txtVillageNo.Name = "txtVillageNo";
            this.txtVillageNo.Size = new System.Drawing.Size(68, 24);
            this.txtVillageNo.TabIndex = 29;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.DarkRed;
            this.label2.Location = new System.Drawing.Point(340, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(25, 17);
            this.label2.TabIndex = 28;
            this.label2.Text = "หมู่";
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.dgvTimeLandHD);
            this.tabPage3.Controls.Add(this.panel1);
            this.tabPage3.Location = new System.Drawing.Point(4, 25);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(858, 450);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "ลำดับเหตุการณ์";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // dgvTimeLandHD
            // 
            this.dgvTimeLandHD.AllowUserToAddRows = false;
            this.dgvTimeLandHD.AllowUserToDeleteRows = false;
            this.dgvTimeLandHD.AutoGenerateColumns = false;
            this.dgvTimeLandHD.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvTimeLandHD.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTimeLandHD.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colTimeLineDate,
            this.colTitleEvent,
            this.colTimeLineEvent,
            this.colTimeLineHDID,
            this.colLandID,
            this.colRemark,
            this.colCreatedBy,
            this.colCreatedDate});
            this.dgvTimeLandHD.DataSource = this.tbTimeLineHDBindingSource;
            this.dgvTimeLandHD.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvTimeLandHD.Location = new System.Drawing.Point(3, 45);
            this.dgvTimeLandHD.Name = "dgvTimeLandHD";
            this.dgvTimeLandHD.ReadOnly = true;
            this.dgvTimeLandHD.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTimeLandHD.Size = new System.Drawing.Size(852, 402);
            this.dgvTimeLandHD.TabIndex = 125;
            this.dgvTimeLandHD.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvTimeLandHD_CellMouseDoubleClick);
            this.dgvTimeLandHD.CellMouseUp += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvTimeLandHD_CellMouseUp);
            // 
            // colTimeLineDate
            // 
            this.colTimeLineDate.DataPropertyName = "TimeLineDate";
            this.colTimeLineDate.FillWeight = 30F;
            this.colTimeLineDate.HeaderText = "วันที่";
            this.colTimeLineDate.Name = "colTimeLineDate";
            this.colTimeLineDate.ReadOnly = true;
            // 
            // colTitleEvent
            // 
            this.colTitleEvent.DataPropertyName = "TitleEvent";
            this.colTitleEvent.HeaderText = "TitleEvent";
            this.colTitleEvent.Name = "colTitleEvent";
            this.colTitleEvent.ReadOnly = true;
            // 
            // colTimeLineEvent
            // 
            this.colTimeLineEvent.DataPropertyName = "TimeLineEvent";
            this.colTimeLineEvent.HeaderText = "TimeLineEvent";
            this.colTimeLineEvent.Name = "colTimeLineEvent";
            this.colTimeLineEvent.ReadOnly = true;
            this.colTimeLineEvent.Visible = false;
            // 
            // colTimeLineHDID
            // 
            this.colTimeLineHDID.DataPropertyName = "TimeLineHDID";
            this.colTimeLineHDID.HeaderText = "TimeLineHDID";
            this.colTimeLineHDID.Name = "colTimeLineHDID";
            this.colTimeLineHDID.ReadOnly = true;
            this.colTimeLineHDID.Visible = false;
            // 
            // colLandID
            // 
            this.colLandID.DataPropertyName = "LandID";
            this.colLandID.HeaderText = "LandID";
            this.colLandID.Name = "colLandID";
            this.colLandID.ReadOnly = true;
            this.colLandID.Visible = false;
            // 
            // colRemark
            // 
            this.colRemark.DataPropertyName = "Remark";
            this.colRemark.HeaderText = "Remark";
            this.colRemark.Name = "colRemark";
            this.colRemark.ReadOnly = true;
            this.colRemark.Visible = false;
            // 
            // colCreatedBy
            // 
            this.colCreatedBy.DataPropertyName = "CreatedBy";
            this.colCreatedBy.HeaderText = "CreatedBy";
            this.colCreatedBy.Name = "colCreatedBy";
            this.colCreatedBy.ReadOnly = true;
            this.colCreatedBy.Visible = false;
            // 
            // colCreatedDate
            // 
            this.colCreatedDate.DataPropertyName = "CreatedDate";
            this.colCreatedDate.HeaderText = "CreatedDate";
            this.colCreatedDate.Name = "colCreatedDate";
            this.colCreatedDate.ReadOnly = true;
            this.colCreatedDate.Visible = false;
            // 
            // tbTimeLineHDBindingSource
            // 
            this.tbTimeLineHDBindingSource.DataMember = "tbTimeLineHD";
            this.tbTimeLineHDBindingSource.DataSource = this.applicationDS2;
            // 
            // applicationDS2
            // 
            this.applicationDS2.DataSetName = "ApplicationDS";
            this.applicationDS2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.BtnSearch);
            this.panel1.Controls.Add(this.txtSearch);
            this.panel1.Controls.Add(this.btnDel);
            this.panel1.Controls.Add(this.btnEdit);
            this.panel1.Controls.Add(this.btnAdd);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(852, 42);
            this.panel1.TabIndex = 1;
            // 
            // BtnSearch
            // 
            this.BtnSearch.Image = global::Application_Form.Properties.Resources.Delete;
            this.BtnSearch.Location = new System.Drawing.Point(676, 3);
            this.BtnSearch.Name = "BtnSearch";
            this.BtnSearch.Size = new System.Drawing.Size(79, 35);
            this.BtnSearch.TabIndex = 29;
            this.BtnSearch.Text = "ค้นหา";
            this.BtnSearch.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnSearch.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.BtnSearch.UseVisualStyleBackColor = true;
            this.BtnSearch.Click += new System.EventHandler(this.BtnSearch_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(239, 9);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtSearch.MaxLength = 50;
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(431, 24);
            this.txtSearch.TabIndex = 28;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // btnDel
            // 
            this.btnDel.Image = global::Application_Form.Properties.Resources.Delete;
            this.btnDel.Location = new System.Drawing.Point(161, 3);
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(72, 35);
            this.btnDel.TabIndex = 2;
            this.btnDel.Text = "ลบ";
            this.btnDel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDel.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnDel.UseVisualStyleBackColor = true;
            this.btnDel.Click += new System.EventHandler(this.btnDel_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Image = global::Application_Form.Properties.Resources.Edit;
            this.btnEdit.Location = new System.Drawing.Point(83, 3);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(72, 35);
            this.btnEdit.TabIndex = 1;
            this.btnEdit.Text = "แก้ไข";
            this.btnEdit.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEdit.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Image = global::Application_Form.Properties.Resources.Add1;
            this.btnAdd.Location = new System.Drawing.Point(5, 3);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(72, 35);
            this.btnAdd.TabIndex = 0;
            this.btnAdd.Text = "เพิ่ม";
            this.btnAdd.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAdd.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.DarkRed;
            this.label1.Location = new System.Drawing.Point(19, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 17);
            this.label1.TabIndex = 26;
            this.label1.Text = "ชื่อหมู่บ้าน";
            // 
            // txtVillageName
            // 
            this.txtVillageName.Location = new System.Drawing.Point(93, 51);
            this.txtVillageName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtVillageName.MaxLength = 50;
            this.txtVillageName.Name = "txtVillageName";
            this.txtVillageName.Size = new System.Drawing.Size(233, 24);
            this.txtVillageName.TabIndex = 27;
            // 
            // txtLandCode
            // 
            this.txtLandCode.Location = new System.Drawing.Point(92, 19);
            this.txtLandCode.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtLandCode.MaxLength = 50;
            this.txtLandCode.Name = "txtLandCode";
            this.txtLandCode.Size = new System.Drawing.Size(233, 24);
            this.txtLandCode.TabIndex = 43;
            // 
            // lblLandCode
            // 
            this.lblLandCode.AutoSize = true;
            this.lblLandCode.ForeColor = System.Drawing.Color.DarkRed;
            this.lblLandCode.Location = new System.Drawing.Point(19, 22);
            this.lblLandCode.Name = "lblLandCode";
            this.lblLandCode.Size = new System.Drawing.Size(61, 17);
            this.lblLandCode.TabIndex = 42;
            this.lblLandCode.Text = "รหัสพื้นที่";
            // 
            // LandInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(866, 518);
            this.Controls.Add(this.tabControl1);
            this.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.MinimumSize = new System.Drawing.Size(532, 427);
            this.Name = "LandInfo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ข้อมูลพื้นที่";
            this.Controls.SetChildIndex(this.tabControl1, 0);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTimeLandHD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbTimeLineHDBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.applicationDS2)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TextBox txtProvince;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtDistrict;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtSubDistrict;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtVillageNo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.RichTextBox txtDistress;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.RichTextBox txtHistory;
        private ApplicationData.ApplicationDS applicationDS;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.Button button1;
        private ApplicationData.ApplicationDS applicationDS1;
        private ApplicationData.ApplicationDS applicationDS2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnDel;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.DataGridView dgvTimeLandHD;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSubject;
        private System.Windows.Forms.BindingSource tbTimeLineHDBindingSource;
        private System.Windows.Forms.Button BtnSearch;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTimeLineDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTitleEvent;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTimeLineEvent;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTimeLineHDID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colLandID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colRemark;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCreatedBy;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCreatedDate;
        private System.Windows.Forms.TextBox txtLandCode;
        private System.Windows.Forms.Label lblLandCode;
        private System.Windows.Forms.TextBox txtVillageName;
        private System.Windows.Forms.Label label1;
    }
}