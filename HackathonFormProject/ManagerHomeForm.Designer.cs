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
            this.txtManagerFirmGUID = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtManagerFirmID = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtManagerFirmName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.boxManagerDataNeeded = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(288, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(296, 33);
            this.label1.TabIndex = 1;
            this.label1.Text = "Manager Information";
            // 
            // btnInvestorSubmit
            // 
            this.btnInvestorSubmit.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInvestorSubmit.Location = new System.Drawing.Point(464, 368);
            this.btnInvestorSubmit.Name = "btnInvestorSubmit";
            this.btnInvestorSubmit.Size = new System.Drawing.Size(129, 40);
            this.btnInvestorSubmit.TabIndex = 36;
            this.btnInvestorSubmit.Text = "Submit";
            this.btnInvestorSubmit.UseVisualStyleBackColor = true;
            this.btnInvestorSubmit.Click += new System.EventHandler(this.btnInvestorSubmit_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label7.Location = new System.Drawing.Point(88, 304);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(142, 29);
            this.label7.TabIndex = 35;
            this.label7.Text = "Firm GUID:";
            // 
            // txtManagerFirmGUID
            // 
            this.txtManagerFirmGUID.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtManagerFirmGUID.Location = new System.Drawing.Point(252, 299);
            this.txtManagerFirmGUID.Name = "txtManagerFirmGUID";
            this.txtManagerFirmGUID.Size = new System.Drawing.Size(360, 34);
            this.txtManagerFirmGUID.TabIndex = 34;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label6.Location = new System.Drawing.Point(125, 264);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(105, 29);
            this.label6.TabIndex = 33;
            this.label6.Text = "Firm ID:";
            // 
            // txtManagerFirmID
            // 
            this.txtManagerFirmID.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtManagerFirmID.Location = new System.Drawing.Point(252, 259);
            this.txtManagerFirmID.Name = "txtManagerFirmID";
            this.txtManagerFirmID.Size = new System.Drawing.Size(360, 34);
            this.txtManagerFirmID.TabIndex = 32;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label5.Location = new System.Drawing.Point(81, 224);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(149, 29);
            this.label5.TabIndex = 31;
            this.label5.Text = "Firm Name:";
            // 
            // txtManagerFirmName
            // 
            this.txtManagerFirmName.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtManagerFirmName.Location = new System.Drawing.Point(252, 219);
            this.txtManagerFirmName.Name = "txtManagerFirmName";
            this.txtManagerFirmName.Size = new System.Drawing.Size(360, 34);
            this.txtManagerFirmName.TabIndex = 30;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label4.Location = new System.Drawing.Point(256, 165);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(346, 29);
            this.label4.TabIndex = 29;
            this.label4.Text = "Known Values (choose one):";
            // 
            // boxManagerDataNeeded
            // 
            this.boxManagerDataNeeded.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.boxManagerDataNeeded.FormattingEnabled = true;
            this.boxManagerDataNeeded.Items.AddRange(new object[] {
            "Firm Name",
            "Firm ID",
            "Firm GUID",
            "Website"});
            this.boxManagerDataNeeded.Location = new System.Drawing.Point(252, 102);
            this.boxManagerDataNeeded.Name = "boxManagerDataNeeded";
            this.boxManagerDataNeeded.Size = new System.Drawing.Size(360, 37);
            this.boxManagerDataNeeded.TabIndex = 28;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label3.Location = new System.Drawing.Point(56, 110);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(174, 29);
            this.label3.TabIndex = 27;
            this.label3.Text = "Data Needed:";
            // 
            // btnBack
            // 
            this.btnBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.Location = new System.Drawing.Point(275, 368);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(129, 40);
            this.btnBack.TabIndex = 37;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.button1_Click);
            // 
            // ManagerHomeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MidnightBlue;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnInvestorSubmit);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtManagerFirmGUID);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtManagerFirmID);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtManagerFirmName);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.boxManagerDataNeeded);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Name = "ManagerHomeForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ManagerForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnInvestorSubmit;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtManagerFirmGUID;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtManagerFirmID;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtManagerFirmName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox boxManagerDataNeeded;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnBack;
    }
}