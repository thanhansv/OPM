
namespace OPM.GUI
{
    partial class OPM2
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
            this.flowLayoutPanelHeader = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutPanelCatalog = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutPanelContent = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutPanelDetail = new System.Windows.Forms.FlowLayoutPanel();
            this.SuspendLayout();
            // 
            // flowLayoutPanelHeader
            // 
            this.flowLayoutPanelHeader.Location = new System.Drawing.Point(12, 12);
            this.flowLayoutPanelHeader.Name = "flowLayoutPanelHeader";
            this.flowLayoutPanelHeader.Size = new System.Drawing.Size(315, 112);
            this.flowLayoutPanelHeader.TabIndex = 0;
            // 
            // flowLayoutPanelCatalog
            // 
            this.flowLayoutPanelCatalog.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.flowLayoutPanelCatalog.Location = new System.Drawing.Point(12, 123);
            this.flowLayoutPanelCatalog.Name = "flowLayoutPanelCatalog";
            this.flowLayoutPanelCatalog.Size = new System.Drawing.Size(315, 405);
            this.flowLayoutPanelCatalog.TabIndex = 0;
            // 
            // flowLayoutPanelContent
            // 
            this.flowLayoutPanelContent.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flowLayoutPanelContent.Location = new System.Drawing.Point(333, 12);
            this.flowLayoutPanelContent.Name = "flowLayoutPanelContent";
            this.flowLayoutPanelContent.Size = new System.Drawing.Size(498, 516);
            this.flowLayoutPanelContent.TabIndex = 0;
            // 
            // flowLayoutPanelDetail
            // 
            this.flowLayoutPanelDetail.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flowLayoutPanelDetail.Location = new System.Drawing.Point(837, 12);
            this.flowLayoutPanelDetail.Name = "flowLayoutPanelDetail";
            this.flowLayoutPanelDetail.Size = new System.Drawing.Size(184, 516);
            this.flowLayoutPanelDetail.TabIndex = 0;
            // 
            // OPM2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1027, 540);
            this.Controls.Add(this.flowLayoutPanelContent);
            this.Controls.Add(this.flowLayoutPanelDetail);
            this.Controls.Add(this.flowLayoutPanelCatalog);
            this.Controls.Add(this.flowLayoutPanelHeader);
            this.Name = "OPM2";
            this.Text = "OPM2";
            this.Load += new System.EventHandler(this.OPM2_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelHeader;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelCatalog;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelContent;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelDetail;
    }
}