namespace Application_Form
{
    partial class TimeLineInfo
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabInfo = new System.Windows.Forms.TabPage();
            this.lblRemark = new System.Windows.Forms.Label();
            this.txtRemark = new System.Windows.Forms.TextBox();
            this.txtEvent = new System.Windows.Forms.TextBox();
            this.lblEvent = new System.Windows.Forms.Label();
            this.txtTitleEvent = new System.Windows.Forms.TextBox();
            this.lblSubject = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dtpTimeLineDate = new System.Windows.Forms.DateTimePicker();
            this.tabEvidence = new System.Windows.Forms.TabPage();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnDelDT = new System.Windows.Forms.Button();
            this.dgvTimeLandDT = new System.Windows.Forms.DataGridView();
            this.tbTimeLineDTBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.applicationDS = new Application_Form.ApplicationData.ApplicationDS();
            this.label9 = new System.Windows.Forms.Label();
            this.colEvidenceCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPath = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colEvidenceName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDetail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTimeLineDTID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTimeLineHDID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colEvidenceID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colEvidenceType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCreatedBy = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCreatedDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabControl1.SuspendLayout();
            this.tabInfo.SuspendLayout();
            this.tabEvidence.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTimeLandDT)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbTimeLineDTBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.applicationDS)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabInfo);
            this.tabControl1.Controls.Add(this.tabEvidence);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.ItemSize = new System.Drawing.Size(120, 21);
            this.tabControl1.Location = new System.Drawing.Point(0, 39);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(777, 402);
            this.tabControl1.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tabControl1.TabIndex = 122;
            // 
            // tabInfo
            // 
            this.tabInfo.Controls.Add(this.lblRemark);
            this.tabInfo.Controls.Add(this.txtRemark);
            this.tabInfo.Controls.Add(this.txtEvent);
            this.tabInfo.Controls.Add(this.lblEvent);
            this.tabInfo.Controls.Add(this.txtTitleEvent);
            this.tabInfo.Controls.Add(this.lblSubject);
            this.tabInfo.Controls.Add(this.label1);
            this.tabInfo.Controls.Add(this.dtpTimeLineDate);
            this.tabInfo.Location = new System.Drawing.Point(4, 25);
            this.tabInfo.Name = "tabInfo";
            this.tabInfo.Padding = new System.Windows.Forms.Padding(3);
            this.tabInfo.Size = new System.Drawing.Size(769, 373);
            this.tabInfo.TabIndex = 0;
            this.tabInfo.Text = "tabPage1";
            this.tabInfo.UseVisualStyleBackColor = true;
            // 
            // lblRemark
            // 
            this.lblRemark.AutoSize = true;
            this.lblRemark.ForeColor = System.Drawing.Color.Black;
            this.lblRemark.Location = new System.Drawing.Point(16, 283);
            this.lblRemark.Name = "lblRemark";
            this.lblRemark.Size = new System.Drawing.Size(63, 17);
            this.lblRemark.TabIndex = 36;
            this.lblRemark.Text = "หมายเหตุ";
            // 
            // txtRemark
            // 
            this.txtRemark.Location = new System.Drawing.Point(118, 280);
            this.txtRemark.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtRemark.MaxLength = 100;
            this.txtRemark.Multiline = true;
            this.txtRemark.Name = "txtRemark";
            this.txtRemark.Size = new System.Drawing.Size(640, 86);
            this.txtRemark.TabIndex = 35;
            // 
            // txtEvent
            // 
            this.txtEvent.Location = new System.Drawing.Point(118, 79);
            this.txtEvent.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtEvent.MaxLength = 100;
            this.txtEvent.Multiline = true;
            this.txtEvent.Name = "txtEvent";
            this.txtEvent.Size = new System.Drawing.Size(640, 193);
            this.txtEvent.TabIndex = 34;
            // 
            // lblEvent
            // 
            this.lblEvent.AutoSize = true;
            this.lblEvent.ForeColor = System.Drawing.Color.Black;
            this.lblEvent.Location = new System.Drawing.Point(16, 82);
            this.lblEvent.Name = "lblEvent";
            this.lblEvent.Size = new System.Drawing.Size(64, 17);
            this.lblEvent.TabIndex = 33;
            this.lblEvent.Text = "เหตุการณ์";
            // 
            // txtTitleEvent
            // 
            this.txtTitleEvent.Location = new System.Drawing.Point(118, 47);
            this.txtTitleEvent.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtTitleEvent.MaxLength = 100;
            this.txtTitleEvent.Name = "txtTitleEvent";
            this.txtTitleEvent.Size = new System.Drawing.Size(640, 24);
            this.txtTitleEvent.TabIndex = 32;
            // 
            // lblSubject
            // 
            this.lblSubject.AutoSize = true;
            this.lblSubject.ForeColor = System.Drawing.Color.DarkRed;
            this.lblSubject.Location = new System.Drawing.Point(16, 50);
            this.lblSubject.Name = "lblSubject";
            this.lblSubject.Size = new System.Drawing.Size(68, 17);
            this.lblSubject.TabIndex = 28;
            this.lblSubject.Text = "TitleEvent";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.DarkRed;
            this.label1.Location = new System.Drawing.Point(16, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 34);
            this.label1.TabIndex = 27;
            this.label1.Text = "วัน/เดือน/ปี \r\nที่เกิดเหตุการณ์";
            // 
            // dtpTimeLineDate
            // 
            this.dtpTimeLineDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpTimeLineDate.Location = new System.Drawing.Point(118, 16);
            this.dtpTimeLineDate.Name = "dtpTimeLineDate";
            this.dtpTimeLineDate.Size = new System.Drawing.Size(200, 24);
            this.dtpTimeLineDate.TabIndex = 0;
            // 
            // tabEvidence
            // 
            this.tabEvidence.Controls.Add(this.btnAdd);
            this.tabEvidence.Controls.Add(this.btnDelDT);
            this.tabEvidence.Controls.Add(this.dgvTimeLandDT);
            this.tabEvidence.Controls.Add(this.label9);
            this.tabEvidence.Location = new System.Drawing.Point(4, 25);
            this.tabEvidence.Name = "tabEvidence";
            this.tabEvidence.Padding = new System.Windows.Forms.Padding(3);
            this.tabEvidence.Size = new System.Drawing.Size(769, 373);
            this.tabEvidence.TabIndex = 1;
            this.tabEvidence.Text = "พยาน / หลักฐาน";
            this.tabEvidence.UseVisualStyleBackColor = true;
            // 
            // btnAdd
            // 
            this.btnAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAdd.Image = global::Application_Form.Properties.Resources.add;
            this.btnAdd.Location = new System.Drawing.Point(707, 13);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(24, 24);
            this.btnAdd.TabIndex = 46;
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnDelDT
            // 
            this.btnDelDT.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDelDT.Image = global::Application_Form.Properties.Resources.forbidden;
            this.btnDelDT.Location = new System.Drawing.Point(737, 13);
            this.btnDelDT.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnDelDT.Name = "btnDelDT";
            this.btnDelDT.Size = new System.Drawing.Size(24, 24);
            this.btnDelDT.TabIndex = 45;
            this.btnDelDT.UseVisualStyleBackColor = true;
            this.btnDelDT.Click += new System.EventHandler(this.btnDelDT_Click);
            // 
            // dgvTimeLandDT
            // 
            this.dgvTimeLandDT.AllowUserToAddRows = false;
            this.dgvTimeLandDT.AllowUserToDeleteRows = false;
            this.dgvTimeLandDT.AutoGenerateColumns = false;
            this.dgvTimeLandDT.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvTimeLandDT.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvTimeLandDT.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTimeLandDT.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colEvidenceCode,
            this.colPath,
            this.colEvidenceName,
            this.colDetail,
            this.colTimeLineDTID,
            this.colTimeLineHDID,
            this.colEvidenceID,
            this.colEvidenceType,
            this.colCreatedBy,
            this.colCreatedDate});
            this.dgvTimeLandDT.DataSource = this.tbTimeLineDTBindingSource;
            this.dgvTimeLandDT.Location = new System.Drawing.Point(11, 44);
            this.dgvTimeLandDT.Name = "dgvTimeLandDT";
            this.dgvTimeLandDT.ReadOnly = true;
            this.dgvTimeLandDT.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.dgvTimeLandDT.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.dgvTimeLandDT.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTimeLandDT.Size = new System.Drawing.Size(750, 321);
            this.dgvTimeLandDT.TabIndex = 43;
            this.dgvTimeLandDT.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvTimeLandDT_CellMouseDoubleClick);
            this.dgvTimeLandDT.CellMouseUp += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvTimeLandDT_CellMouseUp);
            // 
            // tbTimeLineDTBindingSource
            // 
            this.tbTimeLineDTBindingSource.DataMember = "tbTimeLineDT";
            this.tbTimeLineDTBindingSource.DataSource = this.applicationDS;
            // 
            // applicationDS
            // 
            this.applicationDS.DataSetName = "ApplicationDS";
            this.applicationDS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(8, 13);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(105, 17);
            this.label9.TabIndex = 42;
            this.label9.Text = "พยาน / หลักฐาน";
            // 
            // colEvidenceCode
            // 
            this.colEvidenceCode.DataPropertyName = "EvidenceCode";
            this.colEvidenceCode.FillWeight = 40F;
            this.colEvidenceCode.HeaderText = "รหัสพยาน/หลักฐาน";
            this.colEvidenceCode.Name = "colEvidenceCode";
            this.colEvidenceCode.ReadOnly = true;
            // 
            // colPath
            // 
            this.colPath.DataPropertyName = "Path";
            this.colPath.HeaderText = "Path";
            this.colPath.Name = "colPath";
            this.colPath.ReadOnly = true;
            this.colPath.Visible = false;
            // 
            // colEvidenceName
            // 
            this.colEvidenceName.DataPropertyName = "EvidenceName";
            this.colEvidenceName.FillWeight = 40F;
            this.colEvidenceName.HeaderText = "ชื่อพยาน/หลักฐาน";
            this.colEvidenceName.Name = "colEvidenceName";
            this.colEvidenceName.ReadOnly = true;
            // 
            // colDetail
            // 
            this.colDetail.DataPropertyName = "Detail";
            this.colDetail.HeaderText = "รายละเอียด";
            this.colDetail.Name = "colDetail";
            this.colDetail.ReadOnly = true;
            // 
            // colTimeLineDTID
            // 
            this.colTimeLineDTID.DataPropertyName = "TimeLineDTID";
            this.colTimeLineDTID.HeaderText = "TimeLineDTID";
            this.colTimeLineDTID.Name = "colTimeLineDTID";
            this.colTimeLineDTID.ReadOnly = true;
            this.colTimeLineDTID.Visible = false;
            // 
            // colTimeLineHDID
            // 
            this.colTimeLineHDID.DataPropertyName = "TimeLineHDID";
            this.colTimeLineHDID.HeaderText = "TimeLineHDID";
            this.colTimeLineHDID.Name = "colTimeLineHDID";
            this.colTimeLineHDID.ReadOnly = true;
            this.colTimeLineHDID.Visible = false;
            // 
            // colEvidenceID
            // 
            this.colEvidenceID.DataPropertyName = "EvidenceID";
            this.colEvidenceID.HeaderText = "EvidenceID";
            this.colEvidenceID.Name = "colEvidenceID";
            this.colEvidenceID.ReadOnly = true;
            this.colEvidenceID.Visible = false;
            // 
            // colEvidenceType
            // 
            this.colEvidenceType.DataPropertyName = "EvidenceType";
            this.colEvidenceType.HeaderText = "EvidenceType";
            this.colEvidenceType.Name = "colEvidenceType";
            this.colEvidenceType.ReadOnly = true;
            this.colEvidenceType.Visible = false;
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
            // TimeLineInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(777, 441);
            this.Controls.Add(this.tabControl1);
            this.Name = "TimeLineInfo";
            this.Text = "TimeLineInfo";
            this.Controls.SetChildIndex(this.tabControl1, 0);
            this.tabControl1.ResumeLayout(false);
            this.tabInfo.ResumeLayout(false);
            this.tabInfo.PerformLayout();
            this.tabEvidence.ResumeLayout(false);
            this.tabEvidence.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTimeLandDT)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbTimeLineDTBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.applicationDS)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabInfo;
        private System.Windows.Forms.TabPage tabEvidence;
        private System.Windows.Forms.DateTimePicker dtpTimeLineDate;
        private System.Windows.Forms.Label lblSubject;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtEvent;
        private System.Windows.Forms.Label lblEvent;
        private System.Windows.Forms.TextBox txtTitleEvent;
        private System.Windows.Forms.Label lblRemark;
        private System.Windows.Forms.TextBox txtRemark;
        private System.Windows.Forms.DataGridView dgvTimeLandDT;
        private System.Windows.Forms.BindingSource tbTimeLineDTBindingSource;
        private ApplicationData.ApplicationDS applicationDS;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnDelDT;
        private System.Windows.Forms.DataGridViewTextBoxColumn colEvidenceCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPath;
        private System.Windows.Forms.DataGridViewTextBoxColumn colEvidenceName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDetail;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTimeLineDTID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTimeLineHDID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colEvidenceID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colEvidenceType;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCreatedBy;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCreatedDate;
    }
}