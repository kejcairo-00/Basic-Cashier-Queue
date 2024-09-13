namespace BasicQueueingForm
{
    partial class QueueForm
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
            this.PositionLbl = new System.Windows.Forms.Label();
            this.QueueLbl = new System.Windows.Forms.Label();
            this.CashierBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // PositionLbl
            // 
            this.PositionLbl.AutoSize = true;
            this.PositionLbl.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PositionLbl.Location = new System.Drawing.Point(144, 23);
            this.PositionLbl.Name = "PositionLbl";
            this.PositionLbl.Size = new System.Drawing.Size(151, 20);
            this.PositionLbl.TabIndex = 0;
            this.PositionLbl.Text = "Position in Queue";
            // 
            // QueueLbl
            // 
            this.QueueLbl.AutoSize = true;
            this.QueueLbl.Font = new System.Drawing.Font("Arial Rounded MT Bold", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.QueueLbl.Location = new System.Drawing.Point(145, 51);
            this.QueueLbl.Name = "QueueLbl";
            this.QueueLbl.Size = new System.Drawing.Size(141, 32);
            this.QueueLbl.TabIndex = 1;
            this.QueueLbl.Text = "P - 10000";
            // 
            // CashierBtn
            // 
            this.CashierBtn.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CashierBtn.Location = new System.Drawing.Point(19, 15);
            this.CashierBtn.Name = "CashierBtn";
            this.CashierBtn.Size = new System.Drawing.Size(105, 72);
            this.CashierBtn.TabIndex = 2;
            this.CashierBtn.Text = "Cashier";
            this.CashierBtn.UseVisualStyleBackColor = true;
            this.CashierBtn.Click += new System.EventHandler(this.CashierBtn_Click);
            // 
            // QueueForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(330, 114);
            this.Controls.Add(this.CashierBtn);
            this.Controls.Add(this.QueueLbl);
            this.Controls.Add(this.PositionLbl);
            this.Name = "QueueForm";
            this.Text = "Position in Queue";
            this.Load += new System.EventHandler(this.QueueForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label PositionLbl;
        private System.Windows.Forms.Label QueueLbl;
        private System.Windows.Forms.Button CashierBtn;
    }
}

