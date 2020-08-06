namespace HackathonFormProject
{
    partial class ConsultantHomeForm
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
            this.boxConsultantDataNeeded = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnInvestorSubmit = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.txtConsultantFirmGUID = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtConsultantFirmID = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtConsultantName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(235, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(323, 33);
            this.label1.TabIndex = 0;
            this.label1.Text = "Consultant Information";
            // 
            // boxConsultantDataNeeded
            // 
            this.boxConsultantDataNeeded.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.boxConsultantDataNeeded.FormattingEnabled = true;
            this.boxConsultantDataNeeded.Items.AddRange(new object[] {
            "Consultant Name",
            "Firm ID",
            "Firm GUID",
            "Client Count",
            "Asset Count"});
            this.boxConsultantDataNeeded.Location = new System.Drawing.Point(241, 108);
            this.boxConsultantDataNeeded.Name = "boxConsultantDataNeeded";
            this.boxConsultantDataNeeded.Size = new System.Drawing.Size(360, 37);
            this.boxConsultantDataNeeded.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(61, 116);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(174, 29);
            this.label3.TabIndex = 10;
            this.label3.Text = "Data Needed:";
            // 
            // btnInvestorSubmit
            // 
            this.btnInvestorSubmit.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInvestorSubmit.Location = new System.Drawing.Point(468, 368);
            this.btnInvestorSubmit.Name = "btnInvestorSubmit";
            this.btnInvestorSubmit.Size = new System.Drawing.Size(100, 40);
            this.btnInvestorSubmit.TabIndex = 26;
            this.btnInvestorSubmit.Text = "Submit";
            this.btnInvestorSubmit.UseVisualStyleBackColor = true;
            this.btnInvestorSubmit.Click += new System.EventHandler(this.btnInvestorSubmit_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(93, 310);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(142, 29);
            this.label7.TabIndex = 25;
            this.label7.Text = "Firm GUID:";
            // 
            // txtConsultantFirmGUID
            // 
            this.txtConsultantFirmGUID.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtConsultantFirmGUID.Location = new System.Drawing.Point(241, 305);
            this.txtConsultantFirmGUID.Name = "txtConsultantFirmGUID";
            this.txtConsultantFirmGUID.Size = new System.Drawing.Size(360, 34);
            this.txtConsultantFirmGUID.TabIndex = 24;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(130, 270);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(105, 29);
            this.label6.TabIndex = 23;
            this.label6.Text = "Firm ID:";
            // 
            // txtConsultantFirmID
            // 
            this.txtConsultantFirmID.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtConsultantFirmID.Location = new System.Drawing.Point(241, 265);
            this.txtConsultantFirmID.Name = "txtConsultantFirmID";
            this.txtConsultantFirmID.Size = new System.Drawing.Size(360, 34);
            this.txtConsultantFirmID.TabIndex = 22;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(16, 230);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(219, 29);
            this.label5.TabIndex = 21;
            this.label5.Text = "Consultant Name:";
            // 
            // txtConsultantName
            // 
            this.txtConsultantName.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtConsultantName.Location = new System.Drawing.Point(241, 225);
            this.txtConsultantName.Name = "txtConsultantName";
            this.txtConsultantName.Size = new System.Drawing.Size(360, 34);
            this.txtConsultantName.TabIndex = 20;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(236, 172);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(346, 29);
            this.label4.TabIndex = 19;
            this.label4.Text = "Known Values (choose one):";
            // 
            // btnBack
            // 
            this.btnBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.Location = new System.Drawing.Point(277, 368);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(99, 40);
            this.btnBack.TabIndex = 27;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // ConsultantHomeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnInvestorSubmit);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtConsultantFirmGUID);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtConsultantFirmID);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtConsultantName);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.boxConsultantDataNeeded);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Name = "ConsultantHomeForm";
            this.Text = "ConsultantForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox boxConsultantDataNeeded;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnInvestorSubmit;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtConsultantFirmGUID;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtConsultantFirmID;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtConsultantName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnBack;
    }
}