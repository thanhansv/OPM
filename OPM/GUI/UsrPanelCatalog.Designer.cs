
namespace OPM.GUI
{
    partial class UsrPanelCatalog
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

        #region Component Designer generated code

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
            System.Windows.Forms.TreeNode treeNode6 = new System.Windows.Forms.TreeNode("Node0", new System.Windows.Forms.TreeNode[] {
            treeNode1,
            treeNode2,
            treeNode3,
            treeNode4,
            treeNode5});
            this.ctxRightMouse = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsmRefresh = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmCreateNew = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmDelete = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmEdit = new System.Windows.Forms.ToolStripMenuItem();
            this.tvCatalog = new System.Windows.Forms.TreeView();
            this.ctxRightMouse.SuspendLayout();
            this.SuspendLayout();
            // 
            // ctxRightMouse
            // 
            this.ctxRightMouse.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmRefresh,
            this.tsmCreateNew,
            this.tsmDelete,
            this.tsmEdit});
            this.ctxRightMouse.Name = "ctxRightMouse";
            this.ctxRightMouse.Size = new System.Drawing.Size(136, 92);
            // 
            // tsmRefresh
            // 
            this.tsmRefresh.Name = "tsmRefresh";
            this.tsmRefresh.Size = new System.Drawing.Size(135, 22);
            this.tsmRefresh.Text = "Refresh";
            this.tsmRefresh.Click += new System.EventHandler(this.tsmRefresh_MouseClick);
            // 
            // tsmCreateNew
            // 
            this.tsmCreateNew.Name = "tsmCreateNew";
            this.tsmCreateNew.Size = new System.Drawing.Size(135, 22);
            this.tsmCreateNew.Text = "Create New";
            this.tsmCreateNew.Click += new System.EventHandler(this.tsmCreateNew_MouseClick);
            // 
            // tsmDelete
            // 
            this.tsmDelete.Name = "tsmDelete";
            this.tsmDelete.Size = new System.Drawing.Size(135, 22);
            this.tsmDelete.Text = "Delete";
            this.tsmDelete.Click += new System.EventHandler(this.tsmDelete_MouseClick);
            // 
            // tsmEdit
            // 
            this.tsmEdit.Name = "tsmEdit";
            this.tsmEdit.Size = new System.Drawing.Size(135, 22);
            this.tsmEdit.Text = "Edit";
            this.tsmEdit.Click += new System.EventHandler(this.tsmEdit_MouseClick);
            // 
            // tvCatalog
            // 
            this.tvCatalog.Location = new System.Drawing.Point(0, 0);
            this.tvCatalog.Name = "tvCatalog";
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
            treeNode6.Name = "Node0";
            treeNode6.Text = "Node0";
            this.tvCatalog.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode6});
            this.tvCatalog.Size = new System.Drawing.Size(155, 305);
            this.tvCatalog.TabIndex = 1;
            this.tvCatalog.MouseClick += new System.Windows.Forms.MouseEventHandler(this.lvCatalog_MouseClick);
            // 
            // UsrPanelCatalog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.Controls.Add(this.tvCatalog);
            this.Name = "UsrPanelCatalog";
            this.Size = new System.Drawing.Size(314, 379);
            this.ctxRightMouse.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ContextMenuStrip ctxRightMouse;
        private System.Windows.Forms.ToolStripMenuItem tsmRefresh;
        private System.Windows.Forms.ToolStripMenuItem tsmCreateNew;
        private System.Windows.Forms.ToolStripMenuItem tsmDelete;
        private System.Windows.Forms.ToolStripMenuItem tsmEdit;
        private System.Windows.Forms.TreeView tvCatalog;
    }
}
