namespace Nimride
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.closeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closeAllToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.findToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.buildToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.syntaxCheckToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.debugCurrentFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.runCurrentFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.openDialog = new System.Windows.Forms.OpenFileDialog();
            this.saveDialog = new System.Windows.Forms.SaveFileDialog();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.tabControl2 = new System.Windows.Forms.TabControl();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.buildOutput = new System.Windows.Forms.ListBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.messageMask = new System.Windows.Forms.CheckBox();
            this.hintMask = new System.Windows.Forms.CheckBox();
            this.warningMask = new System.Windows.Forms.CheckBox();
            this.errorMask = new System.Windows.Forms.CheckBox();
            this.menuStrip1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.tabControl2.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem,
            this.buildToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1033, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem,
            this.openToolStripMenuItem,
            this.saveToolStripMenuItem,
            this.saveAsToolStripMenuItem,
            this.toolStripMenuItem1,
            this.closeToolStripMenuItem,
            this.closeAllToolStripMenuItem,
            this.toolStripMenuItem2,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.newToolStripMenuItem.Size = new System.Drawing.Size(184, 22);
            this.newToolStripMenuItem.Text = "New";
            this.newToolStripMenuItem.Click += new System.EventHandler(this.newToolStripMenuItem_Click);
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.openToolStripMenuItem.Size = new System.Drawing.Size(184, 22);
            this.openToolStripMenuItem.Text = "Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(184, 22);
            this.saveToolStripMenuItem.Text = "Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // saveAsToolStripMenuItem
            // 
            this.saveAsToolStripMenuItem.Name = "saveAsToolStripMenuItem";
            this.saveAsToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.S)));
            this.saveAsToolStripMenuItem.Size = new System.Drawing.Size(184, 22);
            this.saveAsToolStripMenuItem.Text = "Save as";
            this.saveAsToolStripMenuItem.Click += new System.EventHandler(this.saveAsToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(181, 6);
            // 
            // closeToolStripMenuItem
            // 
            this.closeToolStripMenuItem.Name = "closeToolStripMenuItem";
            this.closeToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.F4)));
            this.closeToolStripMenuItem.Size = new System.Drawing.Size(184, 22);
            this.closeToolStripMenuItem.Text = "Close";
            this.closeToolStripMenuItem.Click += new System.EventHandler(this.closeToolStripMenuItem_Click);
            // 
            // closeAllToolStripMenuItem
            // 
            this.closeAllToolStripMenuItem.Name = "closeAllToolStripMenuItem";
            this.closeAllToolStripMenuItem.Size = new System.Drawing.Size(184, 22);
            this.closeAllToolStripMenuItem.Text = "Close all";
            this.closeAllToolStripMenuItem.Click += new System.EventHandler(this.closeAllToolStripMenuItem_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(181, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4)));
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(184, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.findToolStripMenuItem});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            this.editToolStripMenuItem.Text = "Edit";
            // 
            // findToolStripMenuItem
            // 
            this.findToolStripMenuItem.Name = "findToolStripMenuItem";
            this.findToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.F5)));
            this.findToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.findToolStripMenuItem.Text = "Find...";
            this.findToolStripMenuItem.Click += new System.EventHandler(this.findToolStripMenuItem_Click);
            // 
            // buildToolStripMenuItem
            // 
            this.buildToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.syntaxCheckToolStripMenuItem,
            this.debugCurrentFileToolStripMenuItem,
            this.runCurrentFileToolStripMenuItem});
            this.buildToolStripMenuItem.Name = "buildToolStripMenuItem";
            this.buildToolStripMenuItem.Size = new System.Drawing.Size(46, 20);
            this.buildToolStripMenuItem.Text = "Build";
            // 
            // syntaxCheckToolStripMenuItem
            // 
            this.syntaxCheckToolStripMenuItem.Name = "syntaxCheckToolStripMenuItem";
            this.syntaxCheckToolStripMenuItem.Size = new System.Drawing.Size(201, 22);
            this.syntaxCheckToolStripMenuItem.Text = "Syntax check";
            this.syntaxCheckToolStripMenuItem.Click += new System.EventHandler(this.syntaxCheckToolStripMenuItem_Click);
            // 
            // debugCurrentFileToolStripMenuItem
            // 
            this.debugCurrentFileToolStripMenuItem.Name = "debugCurrentFileToolStripMenuItem";
            this.debugCurrentFileToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F5;
            this.debugCurrentFileToolStripMenuItem.Size = new System.Drawing.Size(201, 22);
            this.debugCurrentFileToolStripMenuItem.Text = "Debug current file";
            this.debugCurrentFileToolStripMenuItem.Click += new System.EventHandler(this.debugCurrentFileToolStripMenuItem_Click);
            // 
            // runCurrentFileToolStripMenuItem
            // 
            this.runCurrentFileToolStripMenuItem.Name = "runCurrentFileToolStripMenuItem";
            this.runCurrentFileToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.F5)));
            this.runCurrentFileToolStripMenuItem.Size = new System.Drawing.Size(201, 22);
            this.runCurrentFileToolStripMenuItem.Text = "Run current file";
            // 
            // treeView1
            // 
            this.treeView1.Dock = System.Windows.Forms.DockStyle.Left;
            this.treeView1.Location = new System.Drawing.Point(0, 24);
            this.treeView1.Name = "treeView1";
            this.treeView1.Size = new System.Drawing.Size(121, 169);
            this.treeView1.TabIndex = 1;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(121, 24);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(912, 165);
            this.tabControl1.TabIndex = 2;
            // 
            // tabPage1
            // 
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(904, 139);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // openDialog
            // 
            this.openDialog.DefaultExt = "nim";
            this.openDialog.FileName = "openDialog";
            this.openDialog.Filter = "Nim files (*.nim)|*.nim|All files (*.*)|(*.*)";
            this.openDialog.Multiselect = true;
            // 
            // saveDialog
            // 
            this.saveDialog.DefaultExt = "nim";
            this.saveDialog.Filter = "Nim files (*.nim)|*.nim|All files (*.*)|*.*";
            // 
            // splitter1
            // 
            this.splitter1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.splitter1.Location = new System.Drawing.Point(121, 189);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(912, 4);
            this.splitter1.TabIndex = 3;
            this.splitter1.TabStop = false;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 462);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1033, 22);
            this.statusStrip1.TabIndex = 4;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(62, 17);
            this.toolStripStatusLabel1.Text = "Ln 1  Col 8";
            // 
            // tabControl2
            // 
            this.tabControl2.Controls.Add(this.tabPage2);
            this.tabControl2.Controls.Add(this.tabPage3);
            this.tabControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl2.Location = new System.Drawing.Point(121, 0);
            this.tabControl2.Name = "tabControl2";
            this.tabControl2.SelectedIndex = 0;
            this.tabControl2.Size = new System.Drawing.Size(912, 269);
            this.tabControl2.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.buildOutput);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(904, 243);
            this.tabPage2.TabIndex = 0;
            this.tabPage2.Text = "Build output";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // buildOutput
            // 
            this.buildOutput.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buildOutput.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.buildOutput.FormattingEnabled = true;
            this.buildOutput.Location = new System.Drawing.Point(3, 3);
            this.buildOutput.Name = "buildOutput";
            this.buildOutput.Size = new System.Drawing.Size(898, 237);
            this.buildOutput.TabIndex = 0;
            this.buildOutput.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.buildOutput_DrawItem);
            // 
            // tabPage3
            // 
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(904, 243);
            this.tabPage3.TabIndex = 1;
            this.tabPage3.Text = "Console";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.tabControl2);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 193);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1033, 269);
            this.panel1.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.messageMask);
            this.panel2.Controls.Add(this.hintMask);
            this.panel2.Controls.Add(this.warningMask);
            this.panel2.Controls.Add(this.errorMask);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(121, 269);
            this.panel2.TabIndex = 1;
            // 
            // messageMask
            // 
            this.messageMask.Appearance = System.Windows.Forms.Appearance.Button;
            this.messageMask.Checked = true;
            this.messageMask.CheckState = System.Windows.Forms.CheckState.Checked;
            this.messageMask.Location = new System.Drawing.Point(4, 129);
            this.messageMask.Name = "messageMask";
            this.messageMask.Size = new System.Drawing.Size(112, 36);
            this.messageMask.TabIndex = 3;
            this.messageMask.Text = "0 Messages";
            this.messageMask.UseVisualStyleBackColor = true;
            this.messageMask.CheckStateChanged += new System.EventHandler(this.maskCheckedChanged);
            // 
            // hintMask
            // 
            this.hintMask.Appearance = System.Windows.Forms.Appearance.Button;
            this.hintMask.Image = global::Nimride.Icons.Hint;
            this.hintMask.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.hintMask.Location = new System.Drawing.Point(4, 87);
            this.hintMask.Name = "hintMask";
            this.hintMask.Size = new System.Drawing.Size(112, 36);
            this.hintMask.TabIndex = 2;
            this.hintMask.Text = "0 Hints";
            this.hintMask.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.hintMask.UseVisualStyleBackColor = true;
            this.hintMask.CheckedChanged += new System.EventHandler(this.maskCheckedChanged);
            // 
            // warningMask
            // 
            this.warningMask.Appearance = System.Windows.Forms.Appearance.Button;
            this.warningMask.Checked = true;
            this.warningMask.CheckState = System.Windows.Forms.CheckState.Checked;
            this.warningMask.Image = global::Nimride.Icons.Warning;
            this.warningMask.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.warningMask.Location = new System.Drawing.Point(4, 45);
            this.warningMask.Name = "warningMask";
            this.warningMask.Size = new System.Drawing.Size(112, 36);
            this.warningMask.TabIndex = 1;
            this.warningMask.Text = "0 Warnings";
            this.warningMask.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.warningMask.UseVisualStyleBackColor = true;
            this.warningMask.CheckedChanged += new System.EventHandler(this.maskCheckedChanged);
            // 
            // errorMask
            // 
            this.errorMask.Appearance = System.Windows.Forms.Appearance.Button;
            this.errorMask.Checked = true;
            this.errorMask.CheckState = System.Windows.Forms.CheckState.Checked;
            this.errorMask.Image = global::Nimride.Icons.Error;
            this.errorMask.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.errorMask.Location = new System.Drawing.Point(4, 3);
            this.errorMask.Name = "errorMask";
            this.errorMask.Size = new System.Drawing.Size(112, 36);
            this.errorMask.TabIndex = 0;
            this.errorMask.Text = "0 Errors";
            this.errorMask.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.errorMask.UseVisualStyleBackColor = true;
            this.errorMask.CheckedChanged += new System.EventHandler(this.maskCheckedChanged);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1033, 484);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.splitter1);
            this.Controls.Add(this.treeView1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.statusStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "Nimride";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.tabControl2.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.OpenFileDialog openDialog;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem findToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem buildToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem syntaxCheckToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveAsToolStripMenuItem;
        private System.Windows.Forms.SaveFileDialog saveDialog;
        private System.Windows.Forms.ToolStripMenuItem debugCurrentFileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem runCurrentFileToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem closeToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem closeAllToolStripMenuItem;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.TabControl tabControl2;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.ListBox buildOutput;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.CheckBox messageMask;
        private System.Windows.Forms.CheckBox hintMask;
        private System.Windows.Forms.CheckBox warningMask;
        private System.Windows.Forms.CheckBox errorMask;
    }
}

