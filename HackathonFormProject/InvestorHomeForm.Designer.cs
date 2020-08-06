namespace HackathonFormProject
{
    partial class InvestorHomeForm
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
            this.boxInvestorDataNeeded = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtInvestorFirmName = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtInvestorFirmID = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtInvestorFirmGUID = new System.Windows.Forms.TextBox();
            this.btnInvestorSubmit = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(267, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(286, 33);
            this.label1.TabIndex = 1;
            this.label1.Text = "Investor Information";
            // 
            // boxInvestorDataNeeded
            // 
            this.boxInvestorDataNeeded.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.boxInvestorDataNeeded.FormattingEnabled = true;
            this.boxInvestorDataNeeded.Items.AddRange(new object[] {
            "Firm ID",
            "Firm GUID",
            "Firm Name",
            "Is DOL",
            "Firm Type ID"});
            this.boxInvestorDataNeeded.Location = new System.Drawing.Point(233, 120);
            this.boxInvestorDataNeeded.Name = "boxInvestorDataNeeded";
            this.boxInvestorDataNeeded.Size = new System.Drawing.Size(360, 37);
            this.boxInvestorDataNeeded.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label3.Location = new System.Drawing.Point(36, 128);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(174, 29);
            this.label3.TabIndex = 8;
            this.label3.Text = "Data Needed:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label4.Location = new System.Drawing.Point(228, 184);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(346, 29);
            this.label4.TabIndex = 11;
            this.label4.Text = "Known Values (choose one):";
            // 
            // txtInvestorFirmName
            // 
            this.txtInvestorFirmName.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtInvestorFirmName.Location = new System.Drawing.Point(233, 240);
            this.txtInvestorFirmName.Name = "txtInvestorFirmName";
            this.txtInvestorFirmName.Size = new System.Drawing.Size(360, 34);
            this.txtInvestorFirmName.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label5.Location = new System.Drawing.Point(61, 245);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(149, 29);
            this.label5.TabIndex = 13;
            this.label5.Text = "Firm Name:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label6.Location = new System.Drawing.Point(105, 285);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(105, 29);
            this.label6.TabIndex = 15;
            this.label6.Text = "Firm ID:";
            // 
            // txtInvestorFirmID
            // 
            this.txtInvestorFirmID.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtInvestorFirmID.Location = new System.Drawing.Point(233, 280);
            this.txtInvestorFirmID.Name = "txtInvestorFirmID";
            this.txtInvestorFirmID.Size = new System.Drawing.Size(360, 34);
            this.txtInvestorFirmID.TabIndex = 14;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label7.Location = new System.Drawing.Point(68, 325);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(142, 29);
            this.label7.TabIndex = 17;
            this.label7.Text = "Firm GUID:";
            // 
            // txtInvestorFirmGUID
            // 
            this.txtInvestorFirmGUID.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtInvestorFirmGUID.Location = new System.Drawing.Point(233, 320);
            this.txtInvestorFirmGUID.Name = "txtInvestorFirmGUID";
            this.txtInvestorFirmGUID.Size = new System.Drawing.Size(360, 34);
            this.txtInvestorFirmGUID.TabIndex = 16;
            // 
            // btnInvestorSubmit
            // 
            this.btnInvestorSubmit.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInvestorSubmit.Location = new System.Drawing.Point(445, 384);
            this.btnInvestorSubmit.Name = "btnInvestorSubmit";
            this.btnInvestorSubmit.Size = new System.Drawing.Size(108, 40);
            this.btnInvestorSubmit.TabIndex = 18;
            this.btnInvestorSubmit.Text = "Submit";
            this.btnInvestorSubmit.UseVisualStyleBackColor = true;
            this.btnInvestorSubmit.Click += new System.EventHandler(this.btnInvestorSubmit_Click);
            // 
            // btnBack
            // 
            this.btnBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.Location = new System.Drawing.Point(285, 384);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(108, 40);
            this.btnBack.TabIndex = 38;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // InvestorHomeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MidnightBlue;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnInvestorSubmit);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtInvestorFirmGUID);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtInvestorFirmID);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtInvestorFirmName);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.boxInvestorDataNeeded);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Name = "InvestorHomeForm";
            this.Text = "InvestorForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox boxInvestorDataNeeded;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtInvestorFirmName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtInvestorFirmID;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtInvestorFirmGUID;
        private System.Windows.Forms.Button btnInvestorSubmit;
        private System.Windows.Forms.Button btnBack;
    }
}