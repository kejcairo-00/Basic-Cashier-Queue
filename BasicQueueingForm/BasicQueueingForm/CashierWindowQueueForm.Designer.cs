namespace BasicQueueingForm
{
    partial class WindowsQueueForm
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
            this.RefreshBtn = new System.Windows.Forms.Button();
            this.listQueue = new System.Windows.Forms.ListView();
            this.NextBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // RefreshBtn
            // 
            this.RefreshBtn.Font = new System.Drawing.Font("Arial Rounded MT Bold", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RefreshBtn.Location = new System.Drawing.Point(12, 12);
            this.RefreshBtn.Name = "RefreshBtn";
            this.RefreshBtn.Size = new System.Drawing.Size(92, 23);
            this.RefreshBtn.TabIndex = 0;
            this.RefreshBtn.Text = "Refresh";
            this.RefreshBtn.UseVisualStyleBackColor = true;
            this.RefreshBtn.Click += new System.EventHandler(this.RefreshBtn_Click);
            // 
            // listQueue
            // 
            this.listQueue.Font = new System.Drawing.Font("Arial Rounded MT Bold", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listQueue.HideSelection = false;
            this.listQueue.Location = new System.Drawing.Point(110, 15);
            this.listQueue.Name = "listQueue";
            this.listQueue.Size = new System.Drawing.Size(127, 212);
            this.listQueue.TabIndex = 1;
            this.listQueue.UseCompatibleStateImageBehavior = false;
            this.listQueue.View = System.Windows.Forms.View.List;
            // 
            // NextBtn
            // 
            this.NextBtn.Font = new System.Drawing.Font("Arial Rounded MT Bold", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NextBtn.Location = new System.Drawing.Point(12, 41);
            this.NextBtn.Name = "NextBtn";
            this.NextBtn.Size = new System.Drawing.Size(92, 23);
            this.NextBtn.TabIndex = 2;
            this.NextBtn.Text = "Next";
            this.NextBtn.UseVisualStyleBackColor = true;
            this.NextBtn.Click += new System.EventHandler(this.NextBtn_Click);
            // 
            // WindowsQueueForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(269, 239);
            this.Controls.Add(this.NextBtn);
            this.Controls.Add(this.listQueue);
            this.Controls.Add(this.RefreshBtn);
            this.Name = "WindowsQueueForm";
            this.Text = "Queue Window";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button RefreshBtn;
        private System.Windows.Forms.ListView listQueue;
        private System.Windows.Forms.Button NextBtn;
    }
}