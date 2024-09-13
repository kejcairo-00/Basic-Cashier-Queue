namespace BasicQueueingForm
{
    partial class cashierView
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
            this.NowServingLbl = new System.Windows.Forms.Label();
            this.lblServing = new System.Windows.Forms.Label();
            this.lblServe = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // NowServingLbl
            // 
            this.NowServingLbl.AutoSize = true;
            this.NowServingLbl.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NowServingLbl.Location = new System.Drawing.Point(63, 17);
            this.NowServingLbl.Name = "NowServingLbl";
            this.NowServingLbl.Size = new System.Drawing.Size(144, 23);
            this.NowServingLbl.TabIndex = 0;
            this.NowServingLbl.Text = "Now Serving :";
            // 
            // lblServing
            // 
            this.lblServing.AutoSize = true;
            this.lblServing.Font = new System.Drawing.Font("Arial Rounded MT Bold", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblServing.Location = new System.Drawing.Point(41, 51);
            this.lblServing.Name = "lblServing";
            this.lblServing.Size = new System.Drawing.Size(0, 38);
            this.lblServing.TabIndex = 1;
            this.lblServing.Click += new System.EventHandler(this.lblServing_Click);
            // 
            // lblServe
            // 
            this.lblServe.AutoSize = true;
            this.lblServe.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblServe.Location = new System.Drawing.Point(79, 63);
            this.lblServe.Name = "lblServe";
            this.lblServe.Size = new System.Drawing.Size(100, 23);
            this.lblServe.TabIndex = 2;
            this.lblServe.Text = "P - 10000";
            this.lblServe.Click += new System.EventHandler(this.lblServe_Click);
            // 
            // cashierView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(262, 111);
            this.Controls.Add(this.lblServe);
            this.Controls.Add(this.lblServing);
            this.Controls.Add(this.NowServingLbl);
            this.Name = "cashierView";
            this.Text = "Now Serving...";
            this.Load += new System.EventHandler(this.NowServingForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label NowServingLbl;
        private System.Windows.Forms.Label lblServing;
        public System.Windows.Forms.Label lblServe;
    }
}