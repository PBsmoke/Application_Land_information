namespace Application_Form
{
    partial class TimeLineList
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
            this.dgvTimeLandHD = new System.Windows.Forms.DataGridView();
            this.applicationDS = new Application_Form.ApplicationData.ApplicationDS();
            this.tbTimeLineHDBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.colTimeLineDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSubject = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTimeLineEvent = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTimeLineHDID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colLandID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colRemark = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCreatedBy = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCreatedDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTimeLandHD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.applicationDS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbTimeLineHDBindingSource)).BeginInit();
            this.SuspendLayout();
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
            this.colSubject,
            this.colTimeLineEvent,
            this.colTimeLineHDID,
            this.colLandID,
            this.colRemark,
            this.colCreatedBy,
            this.colCreatedDate});
            this.dgvTimeLandHD.DataSource = this.tbTimeLineHDBindingSource;
            this.dgvTimeLandHD.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvTimeLandHD.Location = new System.Drawing.Point(0, 39);
            this.dgvTimeLandHD.Name = "dgvTimeLandHD";
            this.dgvTimeLandHD.ReadOnly = true;
            this.dgvTimeLandHD.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTimeLandHD.Size = new System.Drawing.Size(864, 457);
            this.dgvTimeLandHD.TabIndex = 124;
            this.dgvTimeLandHD.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvTimeLandHD_CellMouseDoubleClick);
            this.dgvTimeLandHD.CellMouseUp += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvTimeLandHD_CellMouseUp);
            // 
            // applicationDS
            // 
            this.applicationDS.DataSetName = "ApplicationDS";
            this.applicationDS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tbTimeLineHDBindingSource
            // 
            this.tbTimeLineHDBindingSource.DataMember = "tbTimeLineHD";
            this.tbTimeLineHDBindingSource.DataSource = this.applicationDS;
            // 
            // colTimeLineDate
            // 
            this.colTimeLineDate.DataPropertyName = "TimeLineDate";
            this.colTimeLineDate.FillWeight = 35F;
            this.colTimeLineDate.HeaderText = "TimeLineDate";
            this.colTimeLineDate.Name = "colTimeLineDate";
            this.colTimeLineDate.ReadOnly = true;
            // 
            // colSubject
            // 
            this.colSubject.DataPropertyName = "Subject";
            this.colSubject.HeaderText = "Subject";
            this.colSubject.Name = "colSubject";
            this.colSubject.ReadOnly = true;
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
            // TimeLineList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dgvTimeLandHD);
            this.Name = "TimeLineList";
            this.Controls.SetChildIndex(this.dgvTimeLandHD, 0);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTimeLandHD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.applicationDS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbTimeLineHDBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvTimeLandHD;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTimeLineDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSubject;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTimeLineEvent;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTimeLineHDID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colLandID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colRemark;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCreatedBy;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCreatedDate;
        private System.Windows.Forms.BindingSource tbTimeLineHDBindingSource;
        private ApplicationData.ApplicationDS applicationDS;
    }
}