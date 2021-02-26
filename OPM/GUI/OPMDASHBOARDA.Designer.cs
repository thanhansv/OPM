
namespace OPM.GUI
{
    partial class OPMDASHBOARDA
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
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("Node1");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("Node2");
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("Node3");
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("Node4");
            System.Windows.Forms.TreeNode treeNode5 = new System.Windows.Forms.TreeNode("Node5");
            System.Windows.Forms.TreeNode treeNode6 = new System.Windows.Forms.TreeNode("Node6");
            System.Windows.Forms.TreeNode treeNode7 = new System.Windows.Forms.TreeNode("Node0", new System.Windows.Forms.TreeNode[] {
            treeNode1,
            treeNode2,
            treeNode3,
            treeNode4,
            treeNode5,
            treeNode6});
            System.Windows.Forms.TreeNode treeNode8 = new System.Windows.Forms.TreeNode("Node8");
            System.Windows.Forms.TreeNode treeNode9 = new System.Windows.Forms.TreeNode("Node9");
            System.Windows.Forms.TreeNode treeNode10 = new System.Windows.Forms.TreeNode("Node10");
            System.Windows.Forms.TreeNode treeNode11 = new System.Windows.Forms.TreeNode("Node11");
            System.Windows.Forms.TreeNode treeNode12 = new System.Windows.Forms.TreeNode("Node7", new System.Windows.Forms.TreeNode[] {
            treeNode8,
            treeNode9,
            treeNode10,
            treeNode11});
            System.Windows.Forms.TreeNode treeNode13 = new System.Windows.Forms.TreeNode("Node13");
            System.Windows.Forms.TreeNode treeNode14 = new System.Windows.Forms.TreeNode("Node14");
            System.Windows.Forms.TreeNode treeNode15 = new System.Windows.Forms.TreeNode("Node15");
            System.Windows.Forms.TreeNode treeNode16 = new System.Windows.Forms.TreeNode("Node16");
            System.Windows.Forms.TreeNode treeNode17 = new System.Windows.Forms.TreeNode("Node12", new System.Windows.Forms.TreeNode[] {
            treeNode13,
            treeNode14,
            treeNode15,
            treeNode16});
            this.panHeader = new System.Windows.Forms.Panel();
            this.panCatalog = new System.Windows.Forms.Panel();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.contextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuRefresh = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuNew = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuEdit = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuDelete = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuExport = new System.Windows.Forms.ToolStripMenuItem();
            this.panContent = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panCatalog.SuspendLayout();
            this.contextMenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // panHeader
            // 
            this.panHeader.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panHeader.Location = new System.Drawing.Point(5, 5);
            this.panHeader.Name = "panHeader";
            this.panHeader.Size = new System.Drawing.Size(250, 100);
            this.panHeader.TabIndex = 0;
            // 
            // panCatalog
            // 
            this.panCatalog.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panCatalog.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panCatalog.Controls.Add(this.treeView1);
            this.panCatalog.Location = new System.Drawing.Point(5, 100);
            this.panCatalog.Name = "panCatalog";
            this.panCatalog.Size = new System.Drawing.Size(250, 455);
            this.panCatalog.TabIndex = 1;
            // 
            // treeView1
            // 
            this.treeView1.ContextMenuStrip = this.contextMenuStrip;
            this.treeView1.Location = new System.Drawing.Point(8, 12);
            this.treeView1.Name = "treeView1";
            treeNode1.Name = "Node1";
            treeNode1.Text = "Node1";
            treeNode2.Name = "Node2";
            treeNode2.Text = "Node2";
            treeNode3.Name = "Node3";
            treeNode3.Text = "Node3";
            treeNode4.Name = "Node4";
            treeNode4.Text = "Node4";
            treeNode5.Name = "Node5";
            treeNode5.Text = "Node5";
            treeNode6.Name = "Node6";
            treeNode6.Text = "Node6";
            treeNode7.Name = "Node0";
            treeNode7.Text = "Node0";
            treeNode8.Name = "Node8";
            treeNode8.Text = "Node8";
            treeNode9.Name = "Node9";
            treeNode9.Text = "Node9";
            treeNode10.Name = "Node10";
            treeNode10.Text = "Node10";
            treeNode11.Name = "Node11";
            treeNode11.Text = "Node11";
            treeNode12.Name = "Node7";
            treeNode12.Text = "Node7";
            treeNode13.Name = "Node13";
            treeNode13.Text = "Node13";
            treeNode14.Name = "Node14";
            treeNode14.Text = "Node14";
            treeNode15.Name = "Node15";
            treeNode15.Text = "Node15";
            treeNode16.Name = "Node16";
            treeNode16.Text = "Node16";
            treeNode17.Name = "Node12";
            treeNode17.Text = "Node12";
            this.treeView1.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode7,
            treeNode12,
            treeNode17});
            this.treeView1.Size = new System.Drawing.Size(200, 430);
            this.treeView1.TabIndex = 0;
            this.treeView1.DoubleClick += new System.EventHandler(this.treeView1_DoubleClick);
            this.treeView1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.treeView1_MouseClick);
            // 
            // contextMenuStrip
            // 
            this.contextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuRefresh,
            this.toolStripMenuNew,
            this.toolStripMenuEdit,
            this.toolStripMenuDelete,
            this.toolStripMenuExport});
            this.contextMenuStrip.Name = "contextMenuStrip";
            this.contextMenuStrip.Size = new System.Drawing.Size(168, 114);
            this.contextMenuStrip.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.contextMenuStrip_ItemClicked);
            // 
            // toolStripMenuRefresh
            // 
            this.toolStripMenuRefresh.Name = "toolStripMenuRefresh";
            this.toolStripMenuRefresh.Size = new System.Drawing.Size(167, 22);
            this.toolStripMenuRefresh.Text = "Refresh";
            // 
            // toolStripMenuNew
            // 
            this.toolStripMenuNew.Name = "toolStripMenuNew";
            this.toolStripMenuNew.Size = new System.Drawing.Size(167, 22);
            this.toolStripMenuNew.Text = "New";
            // 
            // toolStripMenuEdit
            // 
            this.toolStripMenuEdit.CheckOnClick = true;
            this.toolStripMenuEdit.Name = "toolStripMenuEdit";
            this.toolStripMenuEdit.Size = new System.Drawing.Size(167, 22);
            this.toolStripMenuEdit.Text = "Edit";
            // 
            // toolStripMenuDelete
            // 
            this.toolStripMenuDelete.Name = "toolStripMenuDelete";
            this.toolStripMenuDelete.Size = new System.Drawing.Size(167, 22);
            this.toolStripMenuDelete.Text = "Delete";
            // 
            // toolStripMenuExport
            // 
            this.toolStripMenuExport.Name = "toolStripMenuExport";
            this.toolStripMenuExport.Size = new System.Drawing.Size(167, 22);
            this.toolStripMenuExport.Text = "Export Document";
            // 
            // panContent
            // 
            this.panContent.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panContent.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panContent.Location = new System.Drawing.Point(261, 5);
            this.panContent.Name = "panContent";
            this.panContent.Size = new System.Drawing.Size(446, 550);
            this.panContent.TabIndex = 2;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Location = new System.Drawing.Point(697, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(275, 550);
            this.panel1.TabIndex = 3;
            // 
            // OPMDASHBOARDA
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 561);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panContent);
            this.Controls.Add(this.panCatalog);
            this.Controls.Add(this.panHeader);
            this.Name = "OPMDASHBOARDA";
            this.Text = "OPMDASHBOARDA";
            this.panCatalog.ResumeLayout(false);
            this.contextMenuStrip.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panHeader;
        private System.Windows.Forms.Panel panCatalog;
        private System.Windows.Forms.Panel panContent;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuRefresh;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuNew;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuEdit;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuDelete;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuExport;
    }
}