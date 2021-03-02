
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
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("NTKT1");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("NTKT2");
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("PL1");
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("PL2");
            System.Windows.Forms.TreeNode treeNode5 = new System.Windows.Forms.TreeNode("DP1", new System.Windows.Forms.TreeNode[] {
            treeNode3,
            treeNode4});
            System.Windows.Forms.TreeNode treeNode6 = new System.Windows.Forms.TreeNode("PO1", new System.Windows.Forms.TreeNode[] {
            treeNode1,
            treeNode2,
            treeNode5});
            System.Windows.Forms.TreeNode treeNode7 = new System.Windows.Forms.TreeNode("PO2");
            System.Windows.Forms.TreeNode treeNode8 = new System.Windows.Forms.TreeNode("PO3");
            System.Windows.Forms.TreeNode treeNode9 = new System.Windows.Forms.TreeNode("PO4");
            System.Windows.Forms.TreeNode treeNode10 = new System.Windows.Forms.TreeNode("PO5");
            System.Windows.Forms.TreeNode treeNode11 = new System.Windows.Forms.TreeNode("PO6");
            System.Windows.Forms.TreeNode treeNode12 = new System.Windows.Forms.TreeNode("113-2020/CUVT-ANSV/DTRR-KHMS", new System.Windows.Forms.TreeNode[] {
            treeNode6,
            treeNode7,
            treeNode8,
            treeNode9,
            treeNode10,
            treeNode11});
            System.Windows.Forms.TreeNode treeNode13 = new System.Windows.Forms.TreeNode("PO1");
            System.Windows.Forms.TreeNode treeNode14 = new System.Windows.Forms.TreeNode("PO2");
            System.Windows.Forms.TreeNode treeNode15 = new System.Windows.Forms.TreeNode("PO3");
            System.Windows.Forms.TreeNode treeNode16 = new System.Windows.Forms.TreeNode("PO4");
            System.Windows.Forms.TreeNode treeNode17 = new System.Windows.Forms.TreeNode("112-2020/CUVT-ANSV/DTRR-KHMS", new System.Windows.Forms.TreeNode[] {
            treeNode13,
            treeNode14,
            treeNode15,
            treeNode16});
            System.Windows.Forms.TreeNode treeNode18 = new System.Windows.Forms.TreeNode("PO1");
            System.Windows.Forms.TreeNode treeNode19 = new System.Windows.Forms.TreeNode("PO2");
            System.Windows.Forms.TreeNode treeNode20 = new System.Windows.Forms.TreeNode("PO3");
            System.Windows.Forms.TreeNode treeNode21 = new System.Windows.Forms.TreeNode("PO4");
            System.Windows.Forms.TreeNode treeNode22 = new System.Windows.Forms.TreeNode("111-2020/CUVT-ANSV/DTRR-KHMS", new System.Windows.Forms.TreeNode[] {
            treeNode18,
            treeNode19,
            treeNode20,
            treeNode21});
            System.Windows.Forms.TreeNode treeNode23 = new System.Windows.Forms.TreeNode("110-2020/CUVT-ANSV/DTRR-KHMS");
            this.panHeader = new System.Windows.Forms.Panel();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabContent = new System.Windows.Forms.TabPage();
            this.tabSearch = new System.Windows.Forms.TabPage();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnEnter = new System.Windows.Forms.Button();
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
            this.panHeader.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabSearch.SuspendLayout();
            this.panCatalog.SuspendLayout();
            this.contextMenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // panHeader
            // 
            this.panHeader.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panHeader.Controls.Add(this.tabControl1);
            this.panHeader.Location = new System.Drawing.Point(5, 5);
            this.panHeader.Name = "panHeader";
            this.panHeader.Size = new System.Drawing.Size(250, 100);
            this.panHeader.TabIndex = 0;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabContent);
            this.tabControl1.Controls.Add(this.tabSearch);
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(259, 100);
            this.tabControl1.TabIndex = 0;
            // 
            // tabContent
            // 
            this.tabContent.Location = new System.Drawing.Point(4, 24);
            this.tabContent.Name = "tabContent";
            this.tabContent.Padding = new System.Windows.Forms.Padding(3);
            this.tabContent.Size = new System.Drawing.Size(251, 72);
            this.tabContent.TabIndex = 0;
            this.tabContent.Text = "Content";
            this.tabContent.UseVisualStyleBackColor = true;
            // 
            // tabSearch
            // 
            this.tabSearch.Controls.Add(this.textBox1);
            this.tabSearch.Controls.Add(this.label1);
            this.tabSearch.Controls.Add(this.btnEnter);
            this.tabSearch.Location = new System.Drawing.Point(4, 24);
            this.tabSearch.Name = "tabSearch";
            this.tabSearch.Padding = new System.Windows.Forms.Padding(3);
            this.tabSearch.Size = new System.Drawing.Size(251, 72);
            this.tabSearch.TabIndex = 1;
            this.tabSearch.Text = "Search";
            this.tabSearch.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(4, 24);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(175, 23);
            this.textBox1.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Type the word ";
            // 
            // btnEnter
            // 
            this.btnEnter.Location = new System.Drawing.Point(185, 25);
            this.btnEnter.Name = "btnEnter";
            this.btnEnter.Size = new System.Drawing.Size(54, 23);
            this.btnEnter.TabIndex = 0;
            this.btnEnter.Text = "Enter";
            this.btnEnter.UseVisualStyleBackColor = true;
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
            this.treeView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.treeView1.ContextMenuStrip = this.contextMenuStrip;
            this.treeView1.LabelEdit = true;
            this.treeView1.Location = new System.Drawing.Point(0, 0);
            this.treeView1.Name = "treeView1";
            treeNode1.Name = "NTKT_PO1_2020";
            treeNode1.Text = "NTKT1";
            treeNode2.Name = "NTKT2";
            treeNode2.Text = "NTKT2";
            treeNode3.Name = "PL1";
            treeNode3.Text = "PL1";
            treeNode4.Name = "PL2";
            treeNode4.Text = "PL2";
            treeNode5.Name = "DP1";
            treeNode5.Text = "DP1";
            treeNode6.Name = "PO_2020_1";
            treeNode6.Text = "PO1";
            treeNode7.Name = "PO_2020_2";
            treeNode7.Text = "PO2";
            treeNode8.Name = "PO_2020_3";
            treeNode8.Text = "PO3";
            treeNode9.Name = "PO_2020_4";
            treeNode9.Text = "PO4";
            treeNode10.Name = "PO_2020_5";
            treeNode10.Text = "PO5";
            treeNode11.Name = "PO_2020_6";
            treeNode11.Text = "PO6";
            treeNode12.Name = "Contract-113-2020/CUVT-ANSV/DTRR-KHMS";
            treeNode12.Text = "113-2020/CUVT-ANSV/DTRR-KHMS";
            treeNode13.Name = "PO_2019_1";
            treeNode13.Text = "PO1";
            treeNode14.Name = "PO_2019_2";
            treeNode14.Text = "PO2";
            treeNode15.Name = "PO_2019_3";
            treeNode15.Text = "PO3";
            treeNode16.Name = "PO_2019_4";
            treeNode16.Text = "PO4";
            treeNode17.Name = "Contract-112-2020/CUVT-ANSV/DTRR-KHMS";
            treeNode17.Text = "112-2020/CUVT-ANSV/DTRR-KHMS";
            treeNode18.Name = "PO_2018_1";
            treeNode18.Text = "PO1";
            treeNode19.Name = "PO_2018_2";
            treeNode19.Text = "PO2";
            treeNode20.Name = "PO_2018_3";
            treeNode20.Text = "PO3";
            treeNode21.Name = "PO_2018_4";
            treeNode21.Text = "PO4";
            treeNode22.Name = "Contract-111-2020/CUVT-ANSV/DTRR-KHMS";
            treeNode22.Text = "111-2020/CUVT-ANSV/DTRR-KHMS";
            treeNode23.Name = "Contract-110-2020/CUVT-ANSV/DTRR-KHMS";
            treeNode23.Text = "110-2020/CUVT-ANSV/DTRR-KHMS";
            this.treeView1.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode12,
            treeNode17,
            treeNode22,
            treeNode23});
            this.treeView1.Size = new System.Drawing.Size(250, 442);
            this.treeView1.TabIndex = 0;
            this.treeView1.AfterLabelEdit += new System.Windows.Forms.NodeLabelEditEventHandler(this.treeView1_AfterLabelEdit);
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
            this.panContent.Size = new System.Drawing.Size(471, 550);
            this.panContent.TabIndex = 2;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Location = new System.Drawing.Point(738, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(234, 550);
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
            this.Load += new System.EventHandler(this.OPMDASHBOARDA_Load);
            this.panHeader.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabSearch.ResumeLayout(false);
            this.tabSearch.PerformLayout();
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
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabContent;
        private System.Windows.Forms.TabPage tabSearch;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnEnter;
    }
}