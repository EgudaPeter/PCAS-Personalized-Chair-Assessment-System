namespace Personalized_Chair_Adjustment_System
{
    partial class supervisorHome
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(supervisorHome));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnEnable = new System.Windows.Forms.Button();
            this.btnDisabled = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnClearStatus = new System.Windows.Forms.Button();
            this.btnQuery = new System.Windows.Forms.Button();
            this.btnComplied = new System.Windows.Forms.Button();
            this.btnSlow = new System.Windows.Forms.Button();
            this.btnGetRecords = new System.Windows.Forms.Button();
            this.btnLogout = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.dgvAllRecords = new System.Windows.Forms.DataGridView();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.dgvActive = new System.Windows.Forms.DataGridView();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.dgvDisabled = new System.Windows.Forms.DataGridView();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.dgvQuery = new System.Windows.Forms.DataGridView();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.dgvComplied = new System.Windows.Forms.DataGridView();
            this.tabPage6 = new System.Windows.Forms.TabPage();
            this.dgvSlow = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.lbAllRecords = new System.Windows.Forms.Label();
            this.lbActive = new System.Windows.Forms.Label();
            this.lbDisabled = new System.Windows.Forms.Label();
            this.txtDate = new System.Windows.Forms.TextBox();
            this.bwGetRecords = new System.ComponentModel.BackgroundWorker();
            this.lbProcessing = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lb_NoteInfo = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.lbQuery = new System.Windows.Forms.Label();
            this.lbComplied = new System.Windows.Forms.Label();
            this.lbSlow = new System.Windows.Forms.Label();
            this.lbName = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btn_Help = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAllRecords)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvActive)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDisabled)).BeginInit();
            this.tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvQuery)).BeginInit();
            this.tabPage5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvComplied)).BeginInit();
            this.tabPage6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSlow)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Sienna;
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.btnGetRecords);
            this.groupBox1.Controls.Add(this.btnLogout);
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(1073, 100);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(142, 500);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Control Panel";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnEnable);
            this.groupBox3.Controls.Add(this.btnDisabled);
            this.groupBox3.ForeColor = System.Drawing.Color.White;
            this.groupBox3.Location = new System.Drawing.Point(6, 312);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(130, 121);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Update Record Condition";
            // 
            // btnEnable
            // 
            this.btnEnable.BackColor = System.Drawing.Color.Sienna;
            this.btnEnable.FlatAppearance.BorderSize = 3;
            this.btnEnable.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEnable.ForeColor = System.Drawing.Color.White;
            this.btnEnable.Location = new System.Drawing.Point(6, 39);
            this.btnEnable.Name = "btnEnable";
            this.btnEnable.Size = new System.Drawing.Size(118, 35);
            this.btnEnable.TabIndex = 3;
            this.btnEnable.Text = "Enable";
            this.btnEnable.UseVisualStyleBackColor = false;
            this.btnEnable.Click += new System.EventHandler(this.btnEnable_Click);
            // 
            // btnDisabled
            // 
            this.btnDisabled.BackColor = System.Drawing.Color.Sienna;
            this.btnDisabled.FlatAppearance.BorderSize = 3;
            this.btnDisabled.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDisabled.ForeColor = System.Drawing.Color.White;
            this.btnDisabled.Location = new System.Drawing.Point(6, 80);
            this.btnDisabled.Name = "btnDisabled";
            this.btnDisabled.Size = new System.Drawing.Size(118, 35);
            this.btnDisabled.TabIndex = 4;
            this.btnDisabled.Text = "Disabled";
            this.btnDisabled.UseVisualStyleBackColor = false;
            this.btnDisabled.Click += new System.EventHandler(this.btnDisabled_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnClearStatus);
            this.groupBox2.Controls.Add(this.btnQuery);
            this.groupBox2.Controls.Add(this.btnComplied);
            this.groupBox2.Controls.Add(this.btnSlow);
            this.groupBox2.ForeColor = System.Drawing.Color.White;
            this.groupBox2.Location = new System.Drawing.Point(6, 81);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(130, 211);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Update Record Status";
            // 
            // btnClearStatus
            // 
            this.btnClearStatus.BackColor = System.Drawing.Color.Sienna;
            this.btnClearStatus.FlatAppearance.BorderSize = 3;
            this.btnClearStatus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClearStatus.ForeColor = System.Drawing.Color.White;
            this.btnClearStatus.Location = new System.Drawing.Point(6, 165);
            this.btnClearStatus.Name = "btnClearStatus";
            this.btnClearStatus.Size = new System.Drawing.Size(118, 35);
            this.btnClearStatus.TabIndex = 7;
            this.btnClearStatus.Text = "Clear Status";
            this.btnClearStatus.UseVisualStyleBackColor = false;
            this.btnClearStatus.Click += new System.EventHandler(this.btnClearStatus_Click);
            // 
            // btnQuery
            // 
            this.btnQuery.BackColor = System.Drawing.Color.Sienna;
            this.btnQuery.FlatAppearance.BorderSize = 3;
            this.btnQuery.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnQuery.ForeColor = System.Drawing.Color.White;
            this.btnQuery.Location = new System.Drawing.Point(6, 33);
            this.btnQuery.Name = "btnQuery";
            this.btnQuery.Size = new System.Drawing.Size(118, 35);
            this.btnQuery.TabIndex = 0;
            this.btnQuery.Text = "Query";
            this.btnQuery.UseVisualStyleBackColor = false;
            this.btnQuery.Click += new System.EventHandler(this.btnQuery_Click);
            // 
            // btnComplied
            // 
            this.btnComplied.BackColor = System.Drawing.Color.Sienna;
            this.btnComplied.FlatAppearance.BorderSize = 3;
            this.btnComplied.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnComplied.ForeColor = System.Drawing.Color.White;
            this.btnComplied.Location = new System.Drawing.Point(6, 120);
            this.btnComplied.Name = "btnComplied";
            this.btnComplied.Size = new System.Drawing.Size(118, 35);
            this.btnComplied.TabIndex = 1;
            this.btnComplied.Text = "Complied";
            this.btnComplied.UseVisualStyleBackColor = false;
            this.btnComplied.Click += new System.EventHandler(this.btnComplied_Click);
            // 
            // btnSlow
            // 
            this.btnSlow.BackColor = System.Drawing.Color.Sienna;
            this.btnSlow.FlatAppearance.BorderSize = 3;
            this.btnSlow.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSlow.ForeColor = System.Drawing.Color.White;
            this.btnSlow.Location = new System.Drawing.Point(6, 76);
            this.btnSlow.Name = "btnSlow";
            this.btnSlow.Size = new System.Drawing.Size(118, 35);
            this.btnSlow.TabIndex = 2;
            this.btnSlow.Text = "Slow";
            this.btnSlow.UseVisualStyleBackColor = false;
            this.btnSlow.Click += new System.EventHandler(this.btnSlow_Click);
            // 
            // btnGetRecords
            // 
            this.btnGetRecords.BackColor = System.Drawing.Color.Sienna;
            this.btnGetRecords.FlatAppearance.BorderSize = 3;
            this.btnGetRecords.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGetRecords.ForeColor = System.Drawing.Color.White;
            this.btnGetRecords.Location = new System.Drawing.Point(6, 20);
            this.btnGetRecords.Name = "btnGetRecords";
            this.btnGetRecords.Size = new System.Drawing.Size(130, 35);
            this.btnGetRecords.TabIndex = 6;
            this.btnGetRecords.Text = "Get Records";
            this.btnGetRecords.UseVisualStyleBackColor = false;
            this.btnGetRecords.Click += new System.EventHandler(this.btnGetRecords_Click);
            // 
            // btnLogout
            // 
            this.btnLogout.BackColor = System.Drawing.Color.Sienna;
            this.btnLogout.FlatAppearance.BorderSize = 3;
            this.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogout.ForeColor = System.Drawing.Color.White;
            this.btnLogout.Location = new System.Drawing.Point(6, 459);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(130, 35);
            this.btnLogout.TabIndex = 5;
            this.btnLogout.Text = "Logout";
            this.btnLogout.UseVisualStyleBackColor = false;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Controls.Add(this.tabPage5);
            this.tabControl1.Controls.Add(this.tabPage6);
            this.tabControl1.Location = new System.Drawing.Point(12, 81);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1030, 539);
            this.tabControl1.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.Transparent;
            this.tabPage1.Controls.Add(this.dgvAllRecords);
            this.tabPage1.Location = new System.Drawing.Point(4, 23);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1022, 512);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "All Records";
            // 
            // dgvAllRecords
            // 
            this.dgvAllRecords.AllowUserToAddRows = false;
            this.dgvAllRecords.AllowUserToDeleteRows = false;
            this.dgvAllRecords.BackgroundColor = System.Drawing.Color.White;
            this.dgvAllRecords.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAllRecords.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvAllRecords.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvAllRecords.Location = new System.Drawing.Point(3, 3);
            this.dgvAllRecords.Name = "dgvAllRecords";
            this.dgvAllRecords.ReadOnly = true;
            this.dgvAllRecords.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAllRecords.Size = new System.Drawing.Size(1016, 506);
            this.dgvAllRecords.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.dgvActive);
            this.tabPage2.Location = new System.Drawing.Point(4, 23);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1022, 512);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Active Records";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // dgvActive
            // 
            this.dgvActive.AllowUserToAddRows = false;
            this.dgvActive.AllowUserToDeleteRows = false;
            this.dgvActive.BackgroundColor = System.Drawing.Color.White;
            this.dgvActive.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvActive.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvActive.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvActive.Location = new System.Drawing.Point(3, 3);
            this.dgvActive.Name = "dgvActive";
            this.dgvActive.ReadOnly = true;
            this.dgvActive.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvActive.Size = new System.Drawing.Size(1016, 506);
            this.dgvActive.TabIndex = 1;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.dgvDisabled);
            this.tabPage3.Location = new System.Drawing.Point(4, 23);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(1022, 512);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Disabled Records";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // dgvDisabled
            // 
            this.dgvDisabled.AllowUserToAddRows = false;
            this.dgvDisabled.AllowUserToDeleteRows = false;
            this.dgvDisabled.BackgroundColor = System.Drawing.Color.White;
            this.dgvDisabled.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDisabled.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvDisabled.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvDisabled.Location = new System.Drawing.Point(3, 3);
            this.dgvDisabled.Name = "dgvDisabled";
            this.dgvDisabled.ReadOnly = true;
            this.dgvDisabled.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDisabled.Size = new System.Drawing.Size(1016, 506);
            this.dgvDisabled.TabIndex = 1;
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.dgvQuery);
            this.tabPage4.Location = new System.Drawing.Point(4, 23);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(1022, 512);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Query";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // dgvQuery
            // 
            this.dgvQuery.AllowUserToAddRows = false;
            this.dgvQuery.AllowUserToDeleteRows = false;
            this.dgvQuery.BackgroundColor = System.Drawing.Color.White;
            this.dgvQuery.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvQuery.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvQuery.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvQuery.Location = new System.Drawing.Point(3, 3);
            this.dgvQuery.Name = "dgvQuery";
            this.dgvQuery.ReadOnly = true;
            this.dgvQuery.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvQuery.Size = new System.Drawing.Size(1016, 506);
            this.dgvQuery.TabIndex = 1;
            // 
            // tabPage5
            // 
            this.tabPage5.Controls.Add(this.dgvComplied);
            this.tabPage5.Location = new System.Drawing.Point(4, 23);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage5.Size = new System.Drawing.Size(1022, 512);
            this.tabPage5.TabIndex = 4;
            this.tabPage5.Text = "Complied";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // dgvComplied
            // 
            this.dgvComplied.AllowUserToAddRows = false;
            this.dgvComplied.AllowUserToDeleteRows = false;
            this.dgvComplied.BackgroundColor = System.Drawing.Color.White;
            this.dgvComplied.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvComplied.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvComplied.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvComplied.Location = new System.Drawing.Point(3, 3);
            this.dgvComplied.Name = "dgvComplied";
            this.dgvComplied.ReadOnly = true;
            this.dgvComplied.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvComplied.Size = new System.Drawing.Size(1016, 506);
            this.dgvComplied.TabIndex = 1;
            // 
            // tabPage6
            // 
            this.tabPage6.Controls.Add(this.dgvSlow);
            this.tabPage6.Location = new System.Drawing.Point(4, 23);
            this.tabPage6.Name = "tabPage6";
            this.tabPage6.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage6.Size = new System.Drawing.Size(1022, 512);
            this.tabPage6.TabIndex = 5;
            this.tabPage6.Text = "Slow";
            this.tabPage6.UseVisualStyleBackColor = true;
            // 
            // dgvSlow
            // 
            this.dgvSlow.AllowUserToAddRows = false;
            this.dgvSlow.AllowUserToDeleteRows = false;
            this.dgvSlow.BackgroundColor = System.Drawing.Color.White;
            this.dgvSlow.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSlow.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvSlow.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvSlow.Location = new System.Drawing.Point(3, 3);
            this.dgvSlow.Name = "dgvSlow";
            this.dgvSlow.ReadOnly = true;
            this.dgvSlow.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSlow.Size = new System.Drawing.Size(1016, 506);
            this.dgvSlow.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 626);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 14);
            this.label1.TabIndex = 2;
            this.label1.Text = "You have here:";
            // 
            // lbAllRecords
            // 
            this.lbAllRecords.AutoSize = true;
            this.lbAllRecords.Location = new System.Drawing.Point(19, 646);
            this.lbAllRecords.Name = "lbAllRecords";
            this.lbAllRecords.Size = new System.Drawing.Size(0, 14);
            this.lbAllRecords.TabIndex = 3;
            // 
            // lbActive
            // 
            this.lbActive.AutoSize = true;
            this.lbActive.Location = new System.Drawing.Point(19, 674);
            this.lbActive.Name = "lbActive";
            this.lbActive.Size = new System.Drawing.Size(0, 14);
            this.lbActive.TabIndex = 4;
            // 
            // lbDisabled
            // 
            this.lbDisabled.AutoSize = true;
            this.lbDisabled.Location = new System.Drawing.Point(19, 704);
            this.lbDisabled.Name = "lbDisabled";
            this.lbDisabled.Size = new System.Drawing.Size(0, 14);
            this.lbDisabled.TabIndex = 5;
            // 
            // txtDate
            // 
            this.txtDate.Enabled = false;
            this.txtDate.Location = new System.Drawing.Point(940, 54);
            this.txtDate.Name = "txtDate";
            this.txtDate.Size = new System.Drawing.Size(275, 21);
            this.txtDate.TabIndex = 6;
            // 
            // bwGetRecords
            // 
            this.bwGetRecords.WorkerSupportsCancellation = true;
            this.bwGetRecords.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bwGetRecords_DoWork);
            this.bwGetRecords.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.bwGetRecords_RunWorkerCompleted);
            // 
            // lbProcessing
            // 
            this.lbProcessing.AutoSize = true;
            this.lbProcessing.Location = new System.Drawing.Point(1045, 606);
            this.lbProcessing.Name = "lbProcessing";
            this.lbProcessing.Size = new System.Drawing.Size(0, 14);
            this.lbProcessing.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(519, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 14);
            this.label2.TabIndex = 8;
            this.label2.Text = "Search:";
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(577, 54);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(239, 21);
            this.txtSearch.TabIndex = 9;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(896, 54);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 14);
            this.label3.TabIndex = 10;
            this.label3.Text = "Date:";
            // 
            // lb_NoteInfo
            // 
            this.lb_NoteInfo.AutoSize = true;
            this.lb_NoteInfo.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_NoteInfo.ForeColor = System.Drawing.Color.Red;
            this.lb_NoteInfo.Location = new System.Drawing.Point(6, 17);
            this.lb_NoteInfo.Name = "lb_NoteInfo";
            this.lb_NoteInfo.Size = new System.Drawing.Size(417, 30);
            this.lb_NoteInfo.TabIndex = 11;
            this.lb_NoteInfo.Text = "All Updating of records, whether Status or Condition, should be,\r\ndone via the Al" +
    "l Records Tab!";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.lb_NoteInfo);
            this.groupBox4.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.ForeColor = System.Drawing.Color.Red;
            this.groupBox4.Location = new System.Drawing.Point(12, 13);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(430, 55);
            this.groupBox4.TabIndex = 12;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "NOTE!!!";
            // 
            // lbQuery
            // 
            this.lbQuery.AutoSize = true;
            this.lbQuery.Location = new System.Drawing.Point(150, 646);
            this.lbQuery.Name = "lbQuery";
            this.lbQuery.Size = new System.Drawing.Size(0, 14);
            this.lbQuery.TabIndex = 13;
            // 
            // lbComplied
            // 
            this.lbComplied.AutoSize = true;
            this.lbComplied.Location = new System.Drawing.Point(150, 674);
            this.lbComplied.Name = "lbComplied";
            this.lbComplied.Size = new System.Drawing.Size(0, 14);
            this.lbComplied.TabIndex = 14;
            // 
            // lbSlow
            // 
            this.lbSlow.AutoSize = true;
            this.lbSlow.Location = new System.Drawing.Point(150, 704);
            this.lbSlow.Name = "lbSlow";
            this.lbSlow.Size = new System.Drawing.Size(0, 14);
            this.lbSlow.TabIndex = 15;
            // 
            // lbName
            // 
            this.lbName.AutoSize = true;
            this.lbName.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbName.Location = new System.Drawing.Point(896, 9);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(0, 18);
            this.lbName.TabIndex = 16;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(463, 696);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(275, 24);
            this.label5.TabIndex = 17;
            this.label5.Text = "Polidane Softwares 2017©\r\n";
            // 
            // btn_Help
            // 
            this.btn_Help.BackColor = System.Drawing.Color.Sienna;
            this.btn_Help.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn_Help.FlatAppearance.BorderSize = 3;
            this.btn_Help.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Help.ForeColor = System.Drawing.Color.White;
            this.btn_Help.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_Help.Location = new System.Drawing.Point(1073, 667);
            this.btn_Help.Name = "btn_Help";
            this.btn_Help.Size = new System.Drawing.Size(142, 51);
            this.btn_Help.TabIndex = 5;
            this.btn_Help.Text = "Need help? CLICK ME!";
            this.btn_Help.UseVisualStyleBackColor = false;
            this.btn_Help.Click += new System.EventHandler(this.btn_Help_Click);
            // 
            // supervisorHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1227, 721);
            this.Controls.Add(this.btn_Help);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lbName);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.lbSlow);
            this.Controls.Add(this.lbComplied);
            this.Controls.Add(this.lbQuery);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbProcessing);
            this.Controls.Add(this.txtDate);
            this.Controls.Add(this.lbDisabled);
            this.Controls.Add(this.lbActive);
            this.Controls.Add(this.lbAllRecords);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "supervisorHome";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PCAS";
            this.Load += new System.EventHandler(this.supervisorHome_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAllRecords)).EndInit();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvActive)).EndInit();
            this.tabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDisabled)).EndInit();
            this.tabPage4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvQuery)).EndInit();
            this.tabPage5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvComplied)).EndInit();
            this.tabPage6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSlow)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Button btnDisabled;
        private System.Windows.Forms.Button btnEnable;
        private System.Windows.Forms.Button btnSlow;
        private System.Windows.Forms.Button btnComplied;
        private System.Windows.Forms.Button btnQuery;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.DataGridView dgvAllRecords;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView dgvActive;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.DataGridView dgvDisabled;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbAllRecords;
        private System.Windows.Forms.Label lbActive;
        private System.Windows.Forms.Label lbDisabled;
        private System.Windows.Forms.TextBox txtDate;
        private System.Windows.Forms.Button btnGetRecords;
        private System.ComponentModel.BackgroundWorker bwGetRecords;
        private System.Windows.Forms.Label lbProcessing;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnClearStatus;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.DataGridView dgvQuery;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.DataGridView dgvComplied;
        private System.Windows.Forms.TabPage tabPage6;
        private System.Windows.Forms.DataGridView dgvSlow;
        private System.Windows.Forms.Label lb_NoteInfo;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label lbQuery;
        private System.Windows.Forms.Label lbComplied;
        private System.Windows.Forms.Label lbSlow;
        private System.Windows.Forms.Label lbName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btn_Help;
    }
}