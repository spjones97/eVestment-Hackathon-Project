namespace HackathonFormProject
{
    partial class DeveloperForm
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
            this.label2 = new System.Windows.Forms.Label();
            this.txtFirmName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btmSubmit = new System.Windows.Forms.Button();
            this.boxFirmType = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(214, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(366, 33);
            this.label1.TabIndex = 1;
            this.label1.Text = "eVestment Developer Tool";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(62, 128);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(149, 29);
            this.label2.TabIndex = 2;
            this.label2.Text = "Firm Name:";
            // 
            // txtFirmName
            // 
            this.txtFirmName.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFirmName.Location = new System.Drawing.Point(220, 123);
            this.txtFirmName.Name = "txtFirmName";
            this.txtFirmName.Size = new System.Drawing.Size(360, 34);
            this.txtFirmName.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(62, 197);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(139, 29);
            this.label3.TabIndex = 4;
            this.label3.Text = "Firm Type:";
            // 
            // btmSubmit
            // 
            this.btmSubmit.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btmSubmit.Location = new System.Drawing.Point(342, 308);
            this.btmSubmit.Name = "btmSubmit";
            this.btmSubmit.Size = new System.Drawing.Size(105, 38);
            this.btmSubmit.TabIndex = 6;
            this.btmSubmit.Text = "Submit";
            this.btmSubmit.UseVisualStyleBackColor = true;
            this.btmSubmit.Click += new System.EventHandler(this.btmSubmit_Click);
            // 
            // boxFirmType
            // 
            this.boxFirmType.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.boxFirmType.FormattingEnabled = true;
            this.boxFirmType.Items.AddRange(new object[] {
            "Consultant",
            "Manager",
            "Investor"});
            this.boxFirmType.Location = new System.Drawing.Point(220, 189);
            this.boxFirmType.Name = "boxFirmType";
            this.boxFirmType.Size = new System.Drawing.Size(360, 37);
            this.boxFirmType.TabIndex = 7;
            // 
            // DeveloperForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.boxFirmType);
            this.Controls.Add(this.btmSubmit);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtFirmName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "DeveloperForm";
            this.Text = "DeveloperForm";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtFirmName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btmSubmit;
        private System.Windows.Forms.ComboBox boxFirmType;
    }
}

