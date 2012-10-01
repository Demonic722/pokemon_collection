namespace Conquest_Tool
{
    partial class ConquestTool
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ConquestTool));
            this.HexListBox = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CodeBox = new System.Windows.Forms.TextBox();
            this.Open = new System.Windows.Forms.Button();
            this.FilePath = new System.Windows.Forms.TextBox();
            this.Compile = new System.Windows.Forms.Button();
            this.cpyHexList = new System.Windows.Forms.Button();
            this.cpyARDSCode = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // HexListBox
            // 
            this.HexListBox.BackColor = System.Drawing.SystemColors.Window;
            this.HexListBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.HexListBox.Font = new System.Drawing.Font("Courier New", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HexListBox.Location = new System.Drawing.Point(3, 56);
            this.HexListBox.Multiline = true;
            this.HexListBox.Name = "HexListBox";
            this.HexListBox.ReadOnly = true;
            this.HexListBox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.HexListBox.Size = new System.Drawing.Size(538, 161);
            this.HexListBox.TabIndex = 0;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(544, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(92, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // CodeBox
            // 
            this.CodeBox.BackColor = System.Drawing.SystemColors.Window;
            this.CodeBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.CodeBox.Font = new System.Drawing.Font("Courier New", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CodeBox.Location = new System.Drawing.Point(3, 223);
            this.CodeBox.Multiline = true;
            this.CodeBox.Name = "CodeBox";
            this.CodeBox.ReadOnly = true;
            this.CodeBox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.CodeBox.Size = new System.Drawing.Size(538, 161);
            this.CodeBox.TabIndex = 2;
            // 
            // Open
            // 
            this.Open.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Open.Location = new System.Drawing.Point(466, 28);
            this.Open.Name = "Open";
            this.Open.Size = new System.Drawing.Size(75, 23);
            this.Open.TabIndex = 3;
            this.Open.Text = "Open";
            this.Open.UseVisualStyleBackColor = true;
            this.Open.Click += new System.EventHandler(this.Open_Click);
            // 
            // FilePath
            // 
            this.FilePath.BackColor = System.Drawing.SystemColors.Window;
            this.FilePath.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.FilePath.Location = new System.Drawing.Point(3, 30);
            this.FilePath.Name = "FilePath";
            this.FilePath.ReadOnly = true;
            this.FilePath.Size = new System.Drawing.Size(457, 20);
            this.FilePath.TabIndex = 4;
            // 
            // Compile
            // 
            this.Compile.Location = new System.Drawing.Point(3, 390);
            this.Compile.Name = "Compile";
            this.Compile.Size = new System.Drawing.Size(175, 33);
            this.Compile.TabIndex = 5;
            this.Compile.Text = "Compile";
            this.Compile.UseVisualStyleBackColor = true;
            this.Compile.Click += new System.EventHandler(this.Compile_Click);
            // 
            // cpyHexList
            // 
            this.cpyHexList.Location = new System.Drawing.Point(185, 390);
            this.cpyHexList.Name = "cpyHexList";
            this.cpyHexList.Size = new System.Drawing.Size(175, 33);
            this.cpyHexList.TabIndex = 6;
            this.cpyHexList.Text = "Copy Hex List";
            this.cpyHexList.UseVisualStyleBackColor = true;
            this.cpyHexList.Click += new System.EventHandler(this.cpyHexList_Click);
            // 
            // cpyARDSCode
            // 
            this.cpyARDSCode.Location = new System.Drawing.Point(366, 390);
            this.cpyARDSCode.Name = "cpyARDSCode";
            this.cpyARDSCode.Size = new System.Drawing.Size(175, 33);
            this.cpyARDSCode.TabIndex = 7;
            this.cpyARDSCode.Text = "Copy ARDS Code";
            this.cpyARDSCode.UseVisualStyleBackColor = true;
            this.cpyARDSCode.Click += new System.EventHandler(this.cpyARDSCode_Click);
            // 
            // ConquestTool
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(544, 425);
            this.Controls.Add(this.cpyARDSCode);
            this.Controls.Add(this.cpyHexList);
            this.Controls.Add(this.Compile);
            this.Controls.Add(this.FilePath);
            this.Controls.Add(this.Open);
            this.Controls.Add(this.CodeBox);
            this.Controls.Add(this.HexListBox);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "ConquestTool";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Conquest Tool";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox HexListBox;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.TextBox CodeBox;
        private System.Windows.Forms.Button Open;
        private System.Windows.Forms.TextBox FilePath;
        private System.Windows.Forms.Button Compile;
        private System.Windows.Forms.Button cpyHexList;
        private System.Windows.Forms.Button cpyARDSCode;
    }
}

