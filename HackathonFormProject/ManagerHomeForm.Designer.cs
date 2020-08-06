namespace HackathonFormProject
{
    partial class ManagerHomeForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.btnInvestorSubmit = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.txtConsultantFirmGUID = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtConsultantFirmID = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtConsultantFirmName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.boxConsultantDataNeeded = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(237, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(296, 33);
            this.label1.TabIndex = 1;
            this.label1.Text = "Manager Information";
            // 
            // btnInvestorSubmit
            // 
            this.btnInvestorSubmit.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInvestorSubmit.Location = new System.Drawing.Point(331, 363);
            this.btnInvestorSubmit.Name = "btnInvestorSubmit";
            this.btnInvestorSubmit.Size = new System.Drawing.Size(100, 40);
            this.btnInvestorSubmit.TabIndex = 36;
            this.btnInvestorSubmit.Text = "Submit";
            this.btnInvestorSubmit.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(95, 304);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(142, 29);
            this.label7.TabIndex = 35;
            this.label7.Text = "Firm GUID:";
            // 
            // txtConsultantFirmGUID
            // 
            this.txtConsultantFirmGUID.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtConsultantFirmGUID.Location = new System.Drawing.Point(243, 299);
            this.txtConsultantFirmGUID.Name = "txtConsultantFirmGUID";
            this.txtConsultantFirmGUID.Size = new System.Drawing.Size(360, 34);
            this.txtConsultantFirmGUID.TabIndex = 34;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(132, 264);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(105, 29);
            this.label6.TabIndex = 33;
            this.label6.Text = "Firm ID:";
            // 
            // txtConsultantFirmID
            // 
            this.txtConsultantFirmID.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtConsultantFirmID.Location = new System.Drawing.Point(243, 259);
            this.txtConsultantFirmID.Name = "txtConsultantFirmID";
            this.txtConsultantFirmID.Size = new System.Drawing.Size(360, 34);
            this.txtConsultantFirmID.TabIndex = 32;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(39, 224);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(198, 29);
            this.label5.TabIndex = 31;
            this.label5.Text = "Manager Name:";
            // 
            // txtConsultantFirmName
            // 
            this.txtConsultantFirmName.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtConsultantFirmName.Location = new System.Drawing.Point(243, 219);
            this.txtConsultantFirmName.Name = "txtConsultantFirmName";
            this.txtConsultantFirmName.Size = new System.Drawing.Size(360, 34);
            this.txtConsultantFirmName.TabIndex = 30;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(294, 172);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(185, 29);
            this.label4.TabIndex = 29;
            this.label4.Text = "Known Values:";
            // 
            // boxConsultantDataNeeded
            // 
            this.boxConsultantDataNeeded.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.boxConsultantDataNeeded.FormattingEnabled = true;
            this.boxConsultantDataNeeded.Items.AddRange(new object[] {
            "Firm Name",
            "Firm ID",
            "Firm GUID",
            "Website"});
            this.boxConsultantDataNeeded.Location = new System.Drawing.Point(243, 102);
            this.boxConsultantDataNeeded.Name = "boxConsultantDataNeeded";
            this.boxConsultantDataNeeded.Size = new System.Drawing.Size(360, 37);
            this.boxConsultantDataNeeded.TabIndex = 28;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(63, 110);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(174, 29);
            this.label3.TabIndex = 27;
            this.label3.Text = "Data Needed:";
            // 
            // ManagerHomeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnInvestorSubmit);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtConsultantFirmGUID);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtConsultantFirmID);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtConsultantFirmName);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.boxConsultantDataNeeded);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Name = "ManagerHomeForm";
            this.Text = "ManagerForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnInvestorSubmit;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtConsultantFirmGUID;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtConsultantFirmID;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtConsultantFirmName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox boxConsultantDataNeeded;
        private System.Windows.Forms.Label label3;
    }
}