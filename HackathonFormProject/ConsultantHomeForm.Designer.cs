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
            this.boxDataNeeded = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnInvestorSubmit = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.txtInvestorFirmGUID = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtInvestorFirmID = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtInvestorFirmName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
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
            // boxDataNeeded
            // 
            this.boxDataNeeded.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.boxDataNeeded.FormattingEnabled = true;
            this.boxDataNeeded.Items.AddRange(new object[] {
            "Firm ID",
            "Firm GUID",
            "Investor Name",
            "Is DOL",
            "Firm Type ID"});
            this.boxDataNeeded.Location = new System.Drawing.Point(241, 108);
            this.boxDataNeeded.Name = "boxDataNeeded";
            this.boxDataNeeded.Size = new System.Drawing.Size(360, 37);
            this.boxDataNeeded.TabIndex = 11;
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
            this.btnInvestorSubmit.Location = new System.Drawing.Point(329, 369);
            this.btnInvestorSubmit.Name = "btnInvestorSubmit";
            this.btnInvestorSubmit.Size = new System.Drawing.Size(100, 40);
            this.btnInvestorSubmit.TabIndex = 26;
            this.btnInvestorSubmit.Text = "Submit";
            this.btnInvestorSubmit.UseVisualStyleBackColor = true;
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
            // txtInvestorFirmGUID
            // 
            this.txtInvestorFirmGUID.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtInvestorFirmGUID.Location = new System.Drawing.Point(241, 305);
            this.txtInvestorFirmGUID.Name = "txtInvestorFirmGUID";
            this.txtInvestorFirmGUID.Size = new System.Drawing.Size(360, 34);
            this.txtInvestorFirmGUID.TabIndex = 24;
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
            // txtInvestorFirmID
            // 
            this.txtInvestorFirmID.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtInvestorFirmID.Location = new System.Drawing.Point(241, 265);
            this.txtInvestorFirmID.Name = "txtInvestorFirmID";
            this.txtInvestorFirmID.Size = new System.Drawing.Size(360, 34);
            this.txtInvestorFirmID.TabIndex = 22;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(86, 230);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(149, 29);
            this.label5.TabIndex = 21;
            this.label5.Text = "Firm Name:";
            // 
            // txtInvestorFirmName
            // 
            this.txtInvestorFirmName.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtInvestorFirmName.Location = new System.Drawing.Point(241, 225);
            this.txtInvestorFirmName.Name = "txtInvestorFirmName";
            this.txtInvestorFirmName.Size = new System.Drawing.Size(360, 34);
            this.txtInvestorFirmName.TabIndex = 20;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(292, 178);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(185, 29);
            this.label4.TabIndex = 19;
            this.label4.Text = "Known Values:";
            // 
            // ConsultantHomeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnInvestorSubmit);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtInvestorFirmGUID);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtInvestorFirmID);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtInvestorFirmName);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.boxDataNeeded);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Name = "ConsultantHomeForm";
            this.Text = "ConsultantForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox boxDataNeeded;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnInvestorSubmit;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtInvestorFirmGUID;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtInvestorFirmID;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtInvestorFirmName;
        private System.Windows.Forms.Label label4;
    }
}