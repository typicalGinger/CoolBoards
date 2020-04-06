namespace CoolBoards
{
    partial class frmSummary
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
            this.label3 = new System.Windows.Forms.Label();
            this.lblNumOfOrders = new System.Windows.Forms.Label();
            this.lblNumOfShirts = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(57, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Number of Orders:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(57, 152);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Number of Shirts:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(57, 237);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Total:";
            // 
            // lblNumOfOrders
            // 
            this.lblNumOfOrders.Location = new System.Drawing.Point(226, 67);
            this.lblNumOfOrders.Name = "lblNumOfOrders";
            this.lblNumOfOrders.Size = new System.Drawing.Size(90, 13);
            this.lblNumOfOrders.TabIndex = 3;
            // 
            // lblNumOfShirts
            // 
            this.lblNumOfShirts.Location = new System.Drawing.Point(226, 152);
            this.lblNumOfShirts.Name = "lblNumOfShirts";
            this.lblNumOfShirts.Size = new System.Drawing.Size(90, 13);
            this.lblNumOfShirts.TabIndex = 4;
            // 
            // lblTotal
            // 
            this.lblTotal.Location = new System.Drawing.Point(226, 237);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(90, 13);
            this.lblTotal.TabIndex = 5;
            // 
            // frmSummary
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(437, 367);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.lblNumOfShirts);
            this.Controls.Add(this.lblNumOfOrders);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmSummary";
            this.Text = "Summary of Orders";
            this.Activated += new System.EventHandler(this.frmSummary_Activated);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblNumOfOrders;
        private System.Windows.Forms.Label lblNumOfShirts;
        private System.Windows.Forms.Label lblTotal;
    }
}