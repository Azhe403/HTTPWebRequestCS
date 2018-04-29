namespace HTTPWebRequestCS
{
    partial class FrmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            this.TxtUrl = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.BtnKirim = new System.Windows.Forms.Button();
            this.TxtResponse = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.CmbMethod = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.TxtData = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // TxtUrl
            // 
            resources.ApplyResources(this.TxtUrl, "TxtUrl");
            this.TxtUrl.Name = "TxtUrl";
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // BtnKirim
            // 
            resources.ApplyResources(this.BtnKirim, "BtnKirim");
            this.BtnKirim.Name = "BtnKirim";
            this.BtnKirim.UseVisualStyleBackColor = true;
            this.BtnKirim.Click += new System.EventHandler(this.BtnKirim_Click);
            // 
            // TxtResponse
            // 
            resources.ApplyResources(this.TxtResponse, "TxtResponse");
            this.TxtResponse.Name = "TxtResponse";
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.Name = "label3";
            // 
            // CmbMethod
            // 
            resources.ApplyResources(this.CmbMethod, "CmbMethod");
            this.CmbMethod.DisplayMember = "1";
            this.CmbMethod.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbMethod.FormattingEnabled = true;
            this.CmbMethod.Items.AddRange(new object[] {
            resources.GetString("CmbMethod.Items"),
            resources.GetString("CmbMethod.Items1")});
            this.CmbMethod.Name = "CmbMethod";
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.label4.Name = "label4";
            // 
            // TxtData
            // 
            resources.ApplyResources(this.TxtData, "TxtData");
            this.TxtData.Name = "TxtData";
            // 
            // groupBox1
            // 
            resources.ApplyResources(this.groupBox1, "groupBox1");
            this.groupBox1.Controls.Add(this.TxtResponse);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.TabStop = false;
            // 
            // groupBox2
            // 
            resources.ApplyResources(this.groupBox2, "groupBox2");
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.TxtUrl);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.BtnKirim);
            this.groupBox2.Controls.Add(this.TxtData);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.CmbMethod);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.TabStop = false;
            // 
            // FrmMain
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FrmMain";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox TxtUrl;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BtnKirim;
        private System.Windows.Forms.TextBox TxtResponse;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox CmbMethod;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TxtData;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}

