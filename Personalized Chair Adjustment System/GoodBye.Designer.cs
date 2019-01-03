namespace Personalized_Chair_Adjustment_System
{
    partial class GoodBye
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GoodBye));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_Okay = new System.Windows.Forms.Button();
            this.lb_Messsage = new System.Windows.Forms.Label();
            this.lb_Name = new System.Windows.Forms.Label();
            this.lb_Poli = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Sienna;
            this.groupBox1.Controls.Add(this.btn_Okay);
            this.groupBox1.Controls.Add(this.lb_Messsage);
            this.groupBox1.Controls.Add(this.lb_Name);
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(81, 47);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(653, 247);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Acknowledgement";
            // 
            // btn_Okay
            // 
            this.btn_Okay.BackColor = System.Drawing.Color.White;
            this.btn_Okay.FlatAppearance.BorderSize = 0;
            this.btn_Okay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Okay.ForeColor = System.Drawing.Color.Black;
            this.btn_Okay.Location = new System.Drawing.Point(522, 207);
            this.btn_Okay.Name = "btn_Okay";
            this.btn_Okay.Size = new System.Drawing.Size(129, 37);
            this.btn_Okay.TabIndex = 2;
            this.btn_Okay.Text = "Okay";
            this.btn_Okay.UseVisualStyleBackColor = false;
            this.btn_Okay.Click += new System.EventHandler(this.btn_Okay_Click);
            // 
            // lb_Messsage
            // 
            this.lb_Messsage.AutoSize = true;
            this.lb_Messsage.ForeColor = System.Drawing.Color.White;
            this.lb_Messsage.Location = new System.Drawing.Point(6, 86);
            this.lb_Messsage.Name = "lb_Messsage";
            this.lb_Messsage.Size = new System.Drawing.Size(484, 75);
            this.lb_Messsage.TabIndex = 1;
            this.lb_Messsage.Text = "Your exercise is completed and your record has been submitted!\r\n\r\nRemember, stayi" +
    "ng healthy is very important!\r\n\r\nDo have a wonderful time using your workstation" +
    "! Thank you and good bye!";
            // 
            // lb_Name
            // 
            this.lb_Name.AutoSize = true;
            this.lb_Name.ForeColor = System.Drawing.Color.White;
            this.lb_Name.Location = new System.Drawing.Point(6, 37);
            this.lb_Name.Name = "lb_Name";
            this.lb_Name.Size = new System.Drawing.Size(0, 15);
            this.lb_Name.TabIndex = 0;
            // 
            // lb_Poli
            // 
            this.lb_Poli.AutoSize = true;
            this.lb_Poli.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Poli.Location = new System.Drawing.Point(289, 336);
            this.lb_Poli.Name = "lb_Poli";
            this.lb_Poli.Size = new System.Drawing.Size(206, 24);
            this.lb_Poli.TabIndex = 18;
            this.lb_Poli.Text = "Polidane Softwares\r\n";
            // 
            // GoodBye
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(825, 369);
            this.Controls.Add(this.lb_Poli);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MaximizeBox = false;
            this.Name = "GoodBye";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PCAS";
            this.Load += new System.EventHandler(this.GoodBye_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_Okay;
        private System.Windows.Forms.Label lb_Messsage;
        private System.Windows.Forms.Label lb_Name;
        private System.Windows.Forms.Label lb_Poli;
    }
}