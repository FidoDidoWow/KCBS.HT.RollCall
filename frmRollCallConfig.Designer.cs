namespace KCBS.HT.RollCall
{
    partial class frmRollCallConfig
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvSetLeaveCategory = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.btnSave = new DevComponents.DotNetBar.ButtonX();
            this.btnLeave = new DevComponents.DotNetBar.ButtonX();
            this.ckbxCrossDate = new DevComponents.DotNetBar.Controls.CheckBoxX();
            this.dgvSetSession = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DataGridViewComboBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.labelX2 = new DevComponents.DotNetBar.LabelX();
            this.labelX3 = new DevComponents.DotNetBar.LabelX();
            this.labelX4 = new DevComponents.DotNetBar.LabelX();
            this.labelX5 = new DevComponents.DotNetBar.LabelX();
            this.dgvCheckSetLeaveCategory = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewCheckBoxColumn1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.labelX6 = new DevComponents.DotNetBar.LabelX();
            this.CheckPeriodsSetting = new DevComponents.Editors.IntegerInput();
            this.labelX7 = new DevComponents.DotNetBar.LabelX();
            this.beforeDates = new DevComponents.Editors.IntegerInput();
            this.afterDates = new DevComponents.Editors.IntegerInput();
            this.labelX8 = new DevComponents.DotNetBar.LabelX();
            this.labelX9 = new DevComponents.DotNetBar.LabelX();
            this.labelX10 = new DevComponents.DotNetBar.LabelX();
            this.labelX11 = new DevComponents.DotNetBar.LabelX();
            this.labelX12 = new DevComponents.DotNetBar.LabelX();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSetLeaveCategory)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSetSession)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCheckSetLeaveCategory)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CheckPeriodsSetting)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.beforeDates)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.afterDates)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvSetLeaveCategory
            // 
            this.dgvSetLeaveCategory.AllowUserToAddRows = false;
            this.dgvSetLeaveCategory.AllowUserToDeleteRows = false;
            this.dgvSetLeaveCategory.AllowUserToResizeColumns = false;
            this.dgvSetLeaveCategory.AllowUserToResizeRows = false;
            this.dgvSetLeaveCategory.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.dgvSetLeaveCategory.BackgroundColor = System.Drawing.Color.White;
            this.dgvSetLeaveCategory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSetLeaveCategory.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvSetLeaveCategory.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvSetLeaveCategory.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.dgvSetLeaveCategory.Location = new System.Drawing.Point(289, 54);
            this.dgvSetLeaveCategory.Name = "dgvSetLeaveCategory";
            this.dgvSetLeaveCategory.RowHeadersVisible = false;
            this.dgvSetLeaveCategory.RowTemplate.Height = 24;
            this.dgvSetLeaveCategory.Size = new System.Drawing.Size(250, 269);
            this.dgvSetLeaveCategory.TabIndex = 0;
            // 
            // Column1
            // 
            this.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.Column1.DefaultCellStyle = dataGridViewCellStyle1;
            this.Column1.HeaderText = "假別";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "導師可點";
            this.Column2.Name = "Column2";
            // 
            // btnSave
            // 
            this.btnSave.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSave.BackColor = System.Drawing.Color.Transparent;
            this.btnSave.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnSave.Location = new System.Drawing.Point(913, 316);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnSave.TabIndex = 1;
            this.btnSave.Text = "儲存";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnLeave
            // 
            this.btnLeave.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnLeave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLeave.BackColor = System.Drawing.Color.Transparent;
            this.btnLeave.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnLeave.Location = new System.Drawing.Point(994, 316);
            this.btnLeave.Name = "btnLeave";
            this.btnLeave.Size = new System.Drawing.Size(75, 23);
            this.btnLeave.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnLeave.TabIndex = 2;
            this.btnLeave.Text = "離開";
            this.btnLeave.Click += new System.EventHandler(this.btnLeave_Click);
            // 
            // ckbxCrossDate
            // 
            this.ckbxCrossDate.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.ckbxCrossDate.BackgroundStyle.Class = "";
            this.ckbxCrossDate.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.ckbxCrossDate.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.ckbxCrossDate.Location = new System.Drawing.Point(12, 24);
            this.ckbxCrossDate.Name = "ckbxCrossDate";
            this.ckbxCrossDate.Size = new System.Drawing.Size(235, 23);
            this.ckbxCrossDate.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.ckbxCrossDate.TabIndex = 3;
            this.ckbxCrossDate.Text = "開放線上補點及預先請假";
            this.ckbxCrossDate.CheckedChanged += new System.EventHandler(this.ckbxCrossDate_CheckedChanged);
            // 
            // dgvSetSession
            // 
            this.dgvSetSession.AllowUserToAddRows = false;
            this.dgvSetSession.AllowUserToDeleteRows = false;
            this.dgvSetSession.AllowUserToResizeColumns = false;
            this.dgvSetSession.AllowUserToResizeRows = false;
            this.dgvSetSession.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.dgvSetSession.BackgroundColor = System.Drawing.Color.White;
            this.dgvSetSession.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSetSession.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.DataGridViewComboBoxColumn});
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvSetSession.DefaultCellStyle = dataGridViewCellStyle4;
            this.dgvSetSession.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.dgvSetSession.Location = new System.Drawing.Point(566, 54);
            this.dgvSetSession.Name = "dgvSetSession";
            this.dgvSetSession.RowHeadersVisible = false;
            this.dgvSetSession.RowTemplate.Height = 24;
            this.dgvSetSession.Size = new System.Drawing.Size(250, 269);
            this.dgvSetSession.TabIndex = 4;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dataGridViewTextBoxColumn1.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridViewTextBoxColumn1.HeaderText = "節次";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // DataGridViewComboBoxColumn
            // 
            this.DataGridViewComboBoxColumn.HeaderText = "導師可選";
            this.DataGridViewComboBoxColumn.Name = "DataGridViewComboBoxColumn";
            this.DataGridViewComboBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.DataGridViewComboBoxColumn.Width = 120;
            // 
            // labelX1
            // 
            this.labelX1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelX1.AutoSize = true;
            this.labelX1.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX1.BackgroundStyle.Class = "";
            this.labelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX1.Location = new System.Drawing.Point(841, 66);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(227, 21);
            this.labelX1.TabIndex = 6;
            this.labelX1.Text = "一般: 班導師點全天、點單節都會作用";
            // 
            // labelX2
            // 
            this.labelX2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelX2.AutoSize = true;
            this.labelX2.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX2.BackgroundStyle.Class = "";
            this.labelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX2.Location = new System.Drawing.Point(841, 94);
            this.labelX2.Name = "labelX2";
            this.labelX2.Size = new System.Drawing.Size(201, 21);
            this.labelX2.TabIndex = 7;
            this.labelX2.Text = "手動: 班導師只有點單節會作用。";
            // 
            // labelX3
            // 
            this.labelX3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelX3.AutoSize = true;
            this.labelX3.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX3.BackgroundStyle.Class = "";
            this.labelX3.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX3.Location = new System.Drawing.Point(841, 122);
            this.labelX3.Name = "labelX3";
            this.labelX3.Size = new System.Drawing.Size(227, 21);
            this.labelX3.TabIndex = 8;
            this.labelX3.Text = "唯讀: 班導師僅能檢視，無法修改新增";
            // 
            // labelX4
            // 
            this.labelX4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelX4.AutoSize = true;
            this.labelX4.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX4.BackgroundStyle.Class = "";
            this.labelX4.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX4.Location = new System.Drawing.Point(841, 150);
            this.labelX4.Name = "labelX4";
            this.labelX4.Size = new System.Drawing.Size(134, 21);
            this.labelX4.TabIndex = 9;
            this.labelX4.Text = "隱藏: 班導師無法檢視";
            // 
            // labelX5
            // 
            this.labelX5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelX5.AutoSize = true;
            this.labelX5.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX5.BackgroundStyle.Class = "";
            this.labelX5.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX5.Location = new System.Drawing.Point(829, 38);
            this.labelX5.Name = "labelX5";
            this.labelX5.Size = new System.Drawing.Size(47, 21);
            this.labelX5.TabIndex = 5;
            this.labelX5.Text = "說明：";
            // 
            // dgvCheckSetLeaveCategory
            // 
            this.dgvCheckSetLeaveCategory.AllowUserToAddRows = false;
            this.dgvCheckSetLeaveCategory.AllowUserToDeleteRows = false;
            this.dgvCheckSetLeaveCategory.AllowUserToResizeColumns = false;
            this.dgvCheckSetLeaveCategory.AllowUserToResizeRows = false;
            this.dgvCheckSetLeaveCategory.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.dgvCheckSetLeaveCategory.BackgroundColor = System.Drawing.Color.White;
            this.dgvCheckSetLeaveCategory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCheckSetLeaveCategory.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewCheckBoxColumn1});
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvCheckSetLeaveCategory.DefaultCellStyle = dataGridViewCellStyle6;
            this.dgvCheckSetLeaveCategory.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.dgvCheckSetLeaveCategory.Location = new System.Drawing.Point(12, 53);
            this.dgvCheckSetLeaveCategory.MultiSelect = false;
            this.dgvCheckSetLeaveCategory.Name = "dgvCheckSetLeaveCategory";
            this.dgvCheckSetLeaveCategory.RowHeadersVisible = false;
            this.dgvCheckSetLeaveCategory.RowTemplate.Height = 24;
            this.dgvCheckSetLeaveCategory.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCheckSetLeaveCategory.Size = new System.Drawing.Size(250, 269);
            this.dgvCheckSetLeaveCategory.TabIndex = 10;
            this.dgvCheckSetLeaveCategory.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCheckSetLeaveCategory_CellValueChanged);
            this.dgvCheckSetLeaveCategory.CurrentCellDirtyStateChanged += new System.EventHandler(this.dgvCheckSetLeaveCategory_CurrentCellDirtyStateChanged);
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dataGridViewTextBoxColumn2.DefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridViewTextBoxColumn2.FillWeight = 50F;
            this.dataGridViewTextBoxColumn2.HeaderText = "假別";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewCheckBoxColumn1
            // 
            this.dataGridViewCheckBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewCheckBoxColumn1.HeaderText = "導師點名重覆缺曠檢查";
            this.dataGridViewCheckBoxColumn1.Name = "dataGridViewCheckBoxColumn1";
            // 
            // labelX6
            // 
            this.labelX6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.labelX6.AutoSize = true;
            this.labelX6.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX6.BackgroundStyle.Class = "";
            this.labelX6.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX6.Location = new System.Drawing.Point(12, 328);
            this.labelX6.Name = "labelX6";
            this.labelX6.Size = new System.Drawing.Size(167, 21);
            this.labelX6.TabIndex = 11;
            this.labelX6.Text = "重覆缺曠檢查僅能選擇一項";
            // 
            // CheckPeriodsSetting
            // 
            this.CheckPeriodsSetting.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.CheckPeriodsSetting.BackgroundStyle.Class = "DateTimeInputBackground";
            this.CheckPeriodsSetting.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.CheckPeriodsSetting.ButtonFreeText.Shortcut = DevComponents.DotNetBar.eShortcut.F2;
            this.CheckPeriodsSetting.Location = new System.Drawing.Point(1004, 282);
            this.CheckPeriodsSetting.MaxValue = 5;
            this.CheckPeriodsSetting.MinValue = 0;
            this.CheckPeriodsSetting.Name = "CheckPeriodsSetting";
            this.CheckPeriodsSetting.ShowUpDown = true;
            this.CheckPeriodsSetting.Size = new System.Drawing.Size(45, 25);
            this.CheckPeriodsSetting.TabIndex = 18;
            this.CheckPeriodsSetting.Value = 2;
            this.CheckPeriodsSetting.Visible = false;
            // 
            // labelX7
            // 
            this.labelX7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.labelX7.AutoSize = true;
            this.labelX7.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX7.BackgroundStyle.Class = "";
            this.labelX7.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX7.Location = new System.Drawing.Point(841, 286);
            this.labelX7.Name = "labelX7";
            this.labelX7.Size = new System.Drawing.Size(157, 21);
            this.labelX7.TabIndex = 19;
            this.labelX7.Text = "重覆缺曠檢查連堂數設定:";
            this.labelX7.Visible = false;
            // 
            // beforeDates
            // 
            this.beforeDates.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.beforeDates.BackgroundStyle.Class = "DateTimeInputBackground";
            this.beforeDates.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.beforeDates.ButtonFreeText.Shortcut = DevComponents.DotNetBar.eShortcut.F2;
            this.beforeDates.Location = new System.Drawing.Point(354, 20);
            this.beforeDates.MaxValue = 5;
            this.beforeDates.MinValue = 0;
            this.beforeDates.Name = "beforeDates";
            this.beforeDates.ShowUpDown = true;
            this.beforeDates.Size = new System.Drawing.Size(45, 25);
            this.beforeDates.TabIndex = 20;
            this.beforeDates.Value = 2;
            // 
            // afterDates
            // 
            this.afterDates.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.afterDates.BackgroundStyle.Class = "DateTimeInputBackground";
            this.afterDates.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.afterDates.ButtonFreeText.Shortcut = DevComponents.DotNetBar.eShortcut.F2;
            this.afterDates.Location = new System.Drawing.Point(457, 20);
            this.afterDates.MaxValue = 5;
            this.afterDates.MinValue = 0;
            this.afterDates.Name = "afterDates";
            this.afterDates.ShowUpDown = true;
            this.afterDates.Size = new System.Drawing.Size(45, 25);
            this.afterDates.TabIndex = 21;
            this.afterDates.Value = 2;
            // 
            // labelX8
            // 
            this.labelX8.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelX8.AutoSize = true;
            this.labelX8.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX8.BackgroundStyle.Class = "";
            this.labelX8.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX8.Location = new System.Drawing.Point(188, 24);
            this.labelX8.Name = "labelX8";
            this.labelX8.Size = new System.Drawing.Size(134, 21);
            this.labelX8.TabIndex = 22;
            this.labelX8.Text = "班導師點名日期區間 :";
            // 
            // labelX9
            // 
            this.labelX9.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelX9.AutoSize = true;
            this.labelX9.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX9.BackgroundStyle.Class = "";
            this.labelX9.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX9.Location = new System.Drawing.Point(328, 24);
            this.labelX9.Name = "labelX9";
            this.labelX9.Size = new System.Drawing.Size(20, 21);
            this.labelX9.TabIndex = 23;
            this.labelX9.Text = "前";
            // 
            // labelX10
            // 
            this.labelX10.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelX10.AutoSize = true;
            this.labelX10.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX10.BackgroundStyle.Class = "";
            this.labelX10.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX10.Location = new System.Drawing.Point(431, 24);
            this.labelX10.Name = "labelX10";
            this.labelX10.Size = new System.Drawing.Size(20, 21);
            this.labelX10.TabIndex = 24;
            this.labelX10.Text = "後";
            // 
            // labelX11
            // 
            this.labelX11.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelX11.AutoSize = true;
            this.labelX11.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX11.BackgroundStyle.Class = "";
            this.labelX11.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX11.Location = new System.Drawing.Point(405, 24);
            this.labelX11.Name = "labelX11";
            this.labelX11.Size = new System.Drawing.Size(20, 21);
            this.labelX11.TabIndex = 25;
            this.labelX11.Text = "天";
            // 
            // labelX12
            // 
            this.labelX12.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelX12.AutoSize = true;
            this.labelX12.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX12.BackgroundStyle.Class = "";
            this.labelX12.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX12.Location = new System.Drawing.Point(508, 24);
            this.labelX12.Name = "labelX12";
            this.labelX12.Size = new System.Drawing.Size(20, 21);
            this.labelX12.TabIndex = 26;
            this.labelX12.Text = "天";
            // 
            // frmRollCallConfig
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1081, 351);
            this.Controls.Add(this.labelX12);
            this.Controls.Add(this.labelX11);
            this.Controls.Add(this.labelX10);
            this.Controls.Add(this.labelX9);
            this.Controls.Add(this.labelX8);
            this.Controls.Add(this.afterDates);
            this.Controls.Add(this.beforeDates);
            this.Controls.Add(this.labelX7);
            this.Controls.Add(this.CheckPeriodsSetting);
            this.Controls.Add(this.labelX6);
            this.Controls.Add(this.dgvCheckSetLeaveCategory);
            this.Controls.Add(this.labelX5);
            this.Controls.Add(this.labelX4);
            this.Controls.Add(this.labelX3);
            this.Controls.Add(this.labelX2);
            this.Controls.Add(this.labelX1);
            this.Controls.Add(this.dgvSetSession);
            this.Controls.Add(this.ckbxCrossDate);
            this.Controls.Add(this.btnLeave);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.dgvSetLeaveCategory);
            this.DoubleBuffered = true;
            this.Name = "frmRollCallConfig";
            this.Text = "導師點名設定";
            this.Load += new System.EventHandler(this.frmRollCallConfig_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSetLeaveCategory)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSetSession)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCheckSetLeaveCategory)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CheckPeriodsSetting)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.beforeDates)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.afterDates)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevComponents.DotNetBar.Controls.DataGridViewX dgvSetLeaveCategory;
        private DevComponents.DotNetBar.ButtonX btnSave;
        private DevComponents.DotNetBar.ButtonX btnLeave;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Column2;
        private DevComponents.DotNetBar.Controls.CheckBoxX ckbxCrossDate;
        private DevComponents.DotNetBar.Controls.DataGridViewX dgvSetSession;
        private DevComponents.DotNetBar.LabelX labelX1;
        private DevComponents.DotNetBar.LabelX labelX2;
        private DevComponents.DotNetBar.LabelX labelX3;
        private DevComponents.DotNetBar.LabelX labelX4;
        private DevComponents.DotNetBar.LabelX labelX5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewComboBoxColumn DataGridViewComboBoxColumn;
        private DevComponents.DotNetBar.Controls.DataGridViewX dgvCheckSetLeaveCategory;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn1;
        private DevComponents.DotNetBar.LabelX labelX6;
        private DevComponents.Editors.IntegerInput CheckPeriodsSetting;
        private DevComponents.DotNetBar.LabelX labelX7;
        private DevComponents.Editors.IntegerInput beforeDates;
        private DevComponents.Editors.IntegerInput afterDates;
        private DevComponents.DotNetBar.LabelX labelX8;
        private DevComponents.DotNetBar.LabelX labelX9;
        private DevComponents.DotNetBar.LabelX labelX10;
        private DevComponents.DotNetBar.LabelX labelX11;
        private DevComponents.DotNetBar.LabelX labelX12;
    }
}