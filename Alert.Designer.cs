namespace PUSL2019_Information_Management_and_Retrieval_
{
    partial class Alert
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
            this.components = new System.ComponentModel.Container();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnReorder = new System.Windows.Forms.Button();
            this.IblMsg = new System.Windows.Forms.Label();
            this.IblPcode = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // btnClose
            // 
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Image = global::PUSL2019_Information_Management_and_Retrieval_.Properties.Resources.icons8_close_30;
            this.btnClose.Location = new System.Drawing.Point(317, 22);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(31, 31);
            this.btnClose.TabIndex = 1;
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnReorder
            // 
            this.btnReorder.FlatAppearance.BorderSize = 0;
            this.btnReorder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReorder.ForeColor = System.Drawing.Color.White;
            this.btnReorder.Image = global::PUSL2019_Information_Management_and_Retrieval_.Properties.Resources.icons8_refresh_50;
            this.btnReorder.Location = new System.Drawing.Point(12, 12);
            this.btnReorder.Name = "btnReorder";
            this.btnReorder.Size = new System.Drawing.Size(50, 50);
            this.btnReorder.TabIndex = 0;
            this.btnReorder.UseVisualStyleBackColor = true;
            // 
            // IblMsg
            // 
            this.IblMsg.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IblMsg.ForeColor = System.Drawing.Color.White;
            this.IblMsg.Location = new System.Drawing.Point(68, 12);
            this.IblMsg.Name = "IblMsg";
            this.IblMsg.Size = new System.Drawing.Size(243, 54);
            this.IblMsg.TabIndex = 2;
            this.IblMsg.Text = "Message Text";
            this.IblMsg.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // IblPcode
            // 
            this.IblPcode.AutoSize = true;
            this.IblPcode.Location = new System.Drawing.Point(340, 56);
            this.IblPcode.Name = "IblPcode";
            this.IblPcode.Size = new System.Drawing.Size(27, 21);
            this.IblPcode.TabIndex = 3;
            this.IblPcode.Text = "Ib";
            this.IblPcode.Visible = false;
            this.IblPcode.Click += new System.EventHandler(this.IblPcode_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Alert
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Highlight;
            this.ClientSize = new System.Drawing.Size(370, 75);
            this.Controls.Add(this.IblPcode);
            this.Controls.Add(this.IblMsg);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnReorder);
            this.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Alert";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Alert";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnReorder;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label IblMsg;
        private System.Windows.Forms.Label IblPcode;
        private System.Windows.Forms.Timer timer1;
    }
}