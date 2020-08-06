namespace HackathonFormProject
{
    partial class HomeForm
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
            this.label3 = new System.Windows.Forms.Label();
            this.btmNext = new System.Windows.Forms.Button();
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
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(62, 137);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(139, 29);
            this.label3.TabIndex = 4;
            this.label3.Text = "Firm Type:";
            // 
            // btmNext
            // 
            this.btmNext.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btmNext.Location = new System.Drawing.Point(318, 305);
            this.btmNext.Name = "btmNext";
            this.btmNext.Size = new System.Drawing.Size(116, 38);
            this.btmNext.TabIndex = 6;
            this.btmNext.Text = "Next";
            this.btmNext.UseVisualStyleBackColor = true;
            this.btmNext.Click += new System.EventHandler(this.btmSubmit_Click);
            // 
            // boxFirmType
            // 
            this.boxFirmType.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.boxFirmType.FormattingEnabled = true;
            this.boxFirmType.Items.AddRange(new object[] {
            "Consultant",
            "Manager",
            "Investor"});
            this.boxFirmType.Location = new System.Drawing.Point(220, 129);
            this.boxFirmType.Name = "boxFirmType";
            this.boxFirmType.Size = new System.Drawing.Size(360, 37);
            this.boxFirmType.TabIndex = 7;
            // 
            // HomeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.boxFirmType);
            this.Controls.Add(this.btmNext);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Name = "HomeForm";
            this.Text = "DeveloperForm";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btmNext;
        private System.Windows.Forms.ComboBox boxFirmType;
    }
}

