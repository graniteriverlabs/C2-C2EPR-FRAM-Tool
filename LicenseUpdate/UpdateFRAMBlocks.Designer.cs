namespace UpdateFRAMBlocks
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btnLic = new System.Windows.Forms.Button();
            this.strversionno = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblSerialNo = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnLic
            // 
            this.btnLic.Location = new System.Drawing.Point(63, 132);
            this.btnLic.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnLic.Name = "btnLic";
            this.btnLic.Size = new System.Drawing.Size(284, 41);
            this.btnLic.TabIndex = 0;
            this.btnLic.Text = "Update";
            this.btnLic.UseVisualStyleBackColor = true;
            this.btnLic.Click += new System.EventHandler(this.btnLic_Click);
            // 
            // strversionno
            // 
            this.strversionno.AutoSize = true;
            this.strversionno.Location = new System.Drawing.Point(235, 27);
            this.strversionno.Name = "strversionno";
            this.strversionno.Size = new System.Drawing.Size(102, 16);
            this.strversionno.TabIndex = 1;
            this.strversionno.Text = "No C2 Detected";
            this.strversionno.Click += new System.EventHandler(this.strversionno_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(135, 81);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Update for :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(33, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(179, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "SN of GRL-USB-PD-C2 EPR:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // lblSerialNo
            // 
            this.lblSerialNo.AutoSize = true;
            this.lblSerialNo.Location = new System.Drawing.Point(237, 81);
            this.lblSerialNo.Name = "lblSerialNo";
            this.lblSerialNo.Size = new System.Drawing.Size(102, 16);
            this.lblSerialNo.TabIndex = 4;
            this.lblSerialNo.Text = "No C2 Detected";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(424, 186);
            this.Controls.Add(this.lblSerialNo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.strversionno);
            this.Controls.Add(this.btnLic);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GRL USB PD FRAM BLock";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnLic;
        private System.Windows.Forms.Label strversionno;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblSerialNo;
    }
}

