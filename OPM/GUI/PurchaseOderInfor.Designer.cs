
namespace OPM.GUI
{
    partial class PurchaseOderInfor
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
            this.btnSave = new System.Windows.Forms.Button();
            this.txbPOCode = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnNewDP = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(249, 419);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 0;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // txbPOCode
            // 
            this.txbPOCode.Location = new System.Drawing.Point(108, 65);
            this.txbPOCode.Name = "txbPOCode";
            this.txbPOCode.Size = new System.Drawing.Size(164, 23);
            this.txbPOCode.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "Mã PO";
            // 
            // btnNewDP
            // 
            this.btnNewDP.Location = new System.Drawing.Point(341, 419);
            this.btnNewDP.Name = "btnNewDP";
            this.btnNewDP.Size = new System.Drawing.Size(75, 23);
            this.btnNewDP.TabIndex = 3;
            this.btnNewDP.Text = "New DP";
            this.btnNewDP.UseVisualStyleBackColor = true;
            // 
            // PurchaseOderInfor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Yellow;
            this.ClientSize = new System.Drawing.Size(456, 550);
            this.Controls.Add(this.btnNewDP);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txbPOCode);
            this.Controls.Add(this.btnSave);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "PurchaseOderInfor";
            this.Text = "Purchase Oder Infor";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TextBox txbPOCode;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnNewDP;
    }
}