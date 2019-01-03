namespace Personalized_Chair_Adjustment_System
{
    partial class Step2C
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Step2C));
            this.lb_RachetInfo = new System.Windows.Forms.Label();
            this.lb_Rachet = new System.Windows.Forms.Label();
            this.btnPrevious = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.lb_Step2C = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lb_Info = new System.Windows.Forms.Label();
            this.lbName = new System.Windows.Forms.Label();
            this.lbChairType = new System.Windows.Forms.Label();
            this.lbTime = new System.Windows.Forms.Label();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // lb_RachetInfo
            // 
            this.lb_RachetInfo.AutoSize = true;
            this.lb_RachetInfo.Location = new System.Drawing.Point(9, 298);
            this.lb_RachetInfo.Name = "lb_RachetInfo";
            this.lb_RachetInfo.Size = new System.Drawing.Size(474, 112);
            this.lb_RachetInfo.TabIndex = 25;
            this.lb_RachetInfo.Text = "To raise: Lift backrest.\r\n\r\nTo lower:\r\n(1) Lift to top to release ratchet.\r\n\r\n(2)" +
    " Lower to bottom until you hear a click which means the ratchet is re- engaged.\r" +
    "\n\r\n(3) Lift to desired height.\r\n";
            // 
            // lb_Rachet
            // 
            this.lb_Rachet.AutoSize = true;
            this.lb_Rachet.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Rachet.Location = new System.Drawing.Point(8, 263);
            this.lb_Rachet.Name = "lb_Rachet";
            this.lb_Rachet.Size = new System.Drawing.Size(192, 18);
            this.lb_Rachet.TabIndex = 24;
            this.lb_Rachet.Text = "(3) Ratchet Mechanism";
            // 
            // btnPrevious
            // 
            this.btnPrevious.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnPrevious.FlatAppearance.BorderSize = 0;
            this.btnPrevious.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrevious.ForeColor = System.Drawing.Color.White;
            this.btnPrevious.Location = new System.Drawing.Point(1102, 493);
            this.btnPrevious.Name = "btnPrevious";
            this.btnPrevious.Size = new System.Drawing.Size(144, 48);
            this.btnPrevious.TabIndex = 23;
            this.btnPrevious.Text = "Previous";
            this.btnPrevious.UseVisualStyleBackColor = false;
            this.btnPrevious.Click += new System.EventHandler(this.btnPrevious_Click);
            // 
            // btnNext
            // 
            this.btnNext.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnNext.FlatAppearance.BorderSize = 0;
            this.btnNext.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNext.ForeColor = System.Drawing.Color.White;
            this.btnNext.Location = new System.Drawing.Point(952, 493);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(144, 48);
            this.btnNext.TabIndex = 22;
            this.btnNext.Text = "Next";
            this.btnNext.UseVisualStyleBackColor = false;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // lb_Step2C
            // 
            this.lb_Step2C.AutoSize = true;
            this.lb_Step2C.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Step2C.Location = new System.Drawing.Point(8, 11);
            this.lb_Step2C.Name = "lb_Step2C";
            this.lb_Step2C.Size = new System.Drawing.Size(349, 22);
            this.lb_Step2C.TabIndex = 21;
            this.lb_Step2C.Text = "STEP 2: LUMBAR SUPPORT HEIGHT";
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.panel1.Location = new System.Drawing.Point(559, 69);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(687, 418);
            this.panel1.TabIndex = 20;
            // 
            // lb_Info
            // 
            this.lb_Info.AutoSize = true;
            this.lb_Info.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Info.Location = new System.Drawing.Point(8, 69);
            this.lb_Info.Name = "lb_Info";
            this.lb_Info.Size = new System.Drawing.Size(377, 135);
            this.lb_Info.TabIndex = 19;
            this.lb_Info.Text = "Curve of chair should fit into the curve in your lower back.\r\n\r\n3 common mechanis" +
    "ms:\r\n\r\n(1) Tab under backrest.\r\n\r\n(2) Dial at Base of Backrest.\r\n\r\n(3) Ratchet M" +
    "echanism.\r\n";
            // 
            // lbName
            // 
            this.lbName.AutoSize = true;
            this.lbName.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbName.Location = new System.Drawing.Point(800, 9);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(0, 18);
            this.lbName.TabIndex = 28;
            // 
            // lbChairType
            // 
            this.lbChairType.AutoSize = true;
            this.lbChairType.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbChairType.Location = new System.Drawing.Point(800, 41);
            this.lbChairType.Name = "lbChairType";
            this.lbChairType.Size = new System.Drawing.Size(0, 18);
            this.lbChairType.TabIndex = 27;
            // 
            // lbTime
            // 
            this.lbTime.AutoSize = true;
            this.lbTime.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTime.Location = new System.Drawing.Point(7, 503);
            this.lbTime.Name = "lbTime";
            this.lbTime.Size = new System.Drawing.Size(0, 22);
            this.lbTime.TabIndex = 29;
            this.toolTip.SetToolTip(this.lbTime, "Time");
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 60;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Step2C
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1249, 546);
            this.Controls.Add(this.lbTime);
            this.Controls.Add(this.lbName);
            this.Controls.Add(this.lbChairType);
            this.Controls.Add(this.lb_RachetInfo);
            this.Controls.Add(this.lb_Rachet);
            this.Controls.Add(this.btnPrevious);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.lb_Step2C);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lb_Info);
            this.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MaximizeBox = false;
            this.Name = "Step2C";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PCAS";
            this.Load += new System.EventHandler(this.Step2C_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lb_RachetInfo;
        private System.Windows.Forms.Label lb_Rachet;
        private System.Windows.Forms.Button btnPrevious;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Label lb_Step2C;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lb_Info;
        private System.Windows.Forms.Label lbName;
        private System.Windows.Forms.Label lbChairType;
        private System.Windows.Forms.Label lbTime;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.Timer timer1;
    }
}