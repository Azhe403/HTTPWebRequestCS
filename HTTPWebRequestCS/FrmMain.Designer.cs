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
            this.TxtUrl.Location = new System.Drawing.Point(9, 43);
            this.TxtUrl.Name = "TxtUrl";
            this.TxtUrl.Size = new System.Drawing.Size(563, 20);
            this.TxtUrl.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "url";
            // 
            // BtnKirim
            // 
            this.BtnKirim.Location = new System.Drawing.Point(497, 14);
            this.BtnKirim.Name = "BtnKirim";
            this.BtnKirim.Size = new System.Drawing.Size(75, 23);
            this.BtnKirim.TabIndex = 2;
            this.BtnKirim.Text = "kirim";
            this.BtnKirim.UseVisualStyleBackColor = true;
            this.BtnKirim.Click += new System.EventHandler(this.BtnKirim_Click);
            // 
            // TxtResponse
            // 
            this.TxtResponse.Location = new System.Drawing.Point(6, 19);
            this.TxtResponse.Multiline = true;
            this.TxtResponse.Name = "TxtResponse";
            this.TxtResponse.Size = new System.Drawing.Size(566, 211);
            this.TxtResponse.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 66);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "method";
            // 
            // CmbMethod
            // 
            this.CmbMethod.DisplayMember = "1";
            this.CmbMethod.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbMethod.FormattingEnabled = true;
            this.CmbMethod.Items.AddRange(new object[] {
            "GET",
            "POST"});
            this.CmbMethod.Location = new System.Drawing.Point(9, 82);
            this.CmbMethod.Name = "CmbMethod";
            this.CmbMethod.Size = new System.Drawing.Size(121, 21);
            this.CmbMethod.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(133, 67);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(28, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "data";
            // 
            // TxtData
            // 
            this.TxtData.Location = new System.Drawing.Point(136, 83);
            this.TxtData.Name = "TxtData";
            this.TxtData.Size = new System.Drawing.Size(436, 20);
            this.TxtData.TabIndex = 7;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.TxtResponse);
            this.groupBox1.Location = new System.Drawing.Point(12, 139);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(578, 258);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "respon";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.TxtUrl);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.BtnKirim);
            this.groupBox2.Controls.Add(this.TxtData);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.CmbMethod);
            this.groupBox2.Location = new System.Drawing.Point(12, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(578, 121);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "reques";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(604, 411);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Contoh HTTP WebRequest";
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

