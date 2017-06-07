namespace Application_Form
{
    partial class SettingInfo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SettingInfo));
            this.txtPath = new System.Windows.Forms.TextBox();
            this.lblPath = new System.Windows.Forms.Label();
            this.btnSaveSetting = new System.Windows.Forms.Button();
            this.styleManager1 = new DevComponents.DotNetBar.StyleManager(this.components);
            this.gbPath = new System.Windows.Forms.GroupBox();
            this.btnBrowsePath = new System.Windows.Forms.Button();
            this.gbPath.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtPath
            // 
            this.txtPath.Location = new System.Drawing.Point(68, 32);
            this.txtPath.Name = "txtPath";
            this.txtPath.Size = new System.Drawing.Size(455, 21);
            this.txtPath.TabIndex = 26;
            // 
            // lblPath
            // 
            this.lblPath.AutoSize = true;
            this.lblPath.Location = new System.Drawing.Point(7, 36);
            this.lblPath.Name = "lblPath";
            this.lblPath.Size = new System.Drawing.Size(35, 15);
            this.lblPath.TabIndex = 25;
            this.lblPath.Text = "Path ";
            // 
            // btnSaveSetting
            // 
            this.btnSaveSetting.Image = global::Application_Form.Properties.Resources.Save1;
            this.btnSaveSetting.Location = new System.Drawing.Point(633, 22);
            this.btnSaveSetting.Name = "btnSaveSetting";
            this.btnSaveSetting.Size = new System.Drawing.Size(91, 38);
            this.btnSaveSetting.TabIndex = 24;
            this.btnSaveSetting.Text = "  บันทึก";
            this.btnSaveSetting.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSaveSetting.UseVisualStyleBackColor = true;
            this.btnSaveSetting.Click += new System.EventHandler(this.btnSaveSetting_Click);
            // 
            // styleManager1
            // 
            this.styleManager1.ManagerStyle = DevComponents.DotNetBar.eStyle.Office2010Blue;
            this.styleManager1.MetroColorParameters = new DevComponents.DotNetBar.Metro.ColorTables.MetroColorGeneratorParameters(System.Drawing.Color.White, System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(87)))), ((int)(((byte)(154))))));
            // 
            // gbPath
            // 
            this.gbPath.Controls.Add(this.btnBrowsePath);
            this.gbPath.Controls.Add(this.btnSaveSetting);
            this.gbPath.Controls.Add(this.txtPath);
            this.gbPath.Controls.Add(this.lblPath);
            this.gbPath.Location = new System.Drawing.Point(14, 14);
            this.gbPath.Name = "gbPath";
            this.gbPath.Size = new System.Drawing.Size(731, 69);
            this.gbPath.TabIndex = 28;
            this.gbPath.TabStop = false;
            this.gbPath.Text = "กรุณาระบุ Path สำหรับบันทีกเอกสารแนบ";
            // 
            // btnBrowsePath
            // 
            this.btnBrowsePath.Image = global::Application_Form.Properties.Resources.browser;
            this.btnBrowsePath.Location = new System.Drawing.Point(531, 22);
            this.btnBrowsePath.Name = "btnBrowsePath";
            this.btnBrowsePath.Size = new System.Drawing.Size(96, 38);
            this.btnBrowsePath.TabIndex = 29;
            this.btnBrowsePath.Text = "เบราว์... ";
            this.btnBrowsePath.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnBrowsePath.UseVisualStyleBackColor = true;
            this.btnBrowsePath.Click += new System.EventHandler(this.btnBrowsePath_Click);
            // 
            // SettingInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(754, 92);
            this.Controls.Add(this.gbPath);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(787, 131);
            this.MinimumSize = new System.Drawing.Size(770, 131);
            this.Name = "SettingInfo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ตั้งค่า";
            this.Load += new System.EventHandler(this.SettingInfo_Load);
            this.gbPath.ResumeLayout(false);
            this.gbPath.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtPath;
        private System.Windows.Forms.Label lblPath;
        private System.Windows.Forms.Button btnSaveSetting;
        private DevComponents.DotNetBar.StyleManager styleManager1;
        private System.Windows.Forms.GroupBox gbPath;
        private System.Windows.Forms.Button btnBrowsePath;
    }
}