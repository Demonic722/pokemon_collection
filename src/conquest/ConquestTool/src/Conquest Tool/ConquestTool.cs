using System;
using System.IO;
using System.Data;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Windows.Forms;
using System.ComponentModel;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace Conquest_Tool
{
    public partial class ConquestTool : Form
    {
        string data;
        OpenFileDialog FileOpen = new OpenFileDialog();

        public ConquestTool()
        {
            InitializeComponent();
        }

        private void Open_Click(object sender, EventArgs e)
        {
            FileOpen.Filter = "SHTML file (*.shtml)|*.shtml";

            if (FileOpen.ShowDialog() == DialogResult.OK && FileOpen.OpenFile() != null)
            {
                FilePath.Text = FileOpen.FileName;
                StreamReader FileRead = new StreamReader(FileOpen.FileName);
                data = FileRead.ReadToEnd();
            }
        }

        private void Compile_Click(object sender, EventArgs e)
        {
            int counter = 0;
            CodeBox.Text = !String.IsNullOrEmpty(CodeBox.Text) 
                           ? ":Wild Pokemon Modifier\r\n\r\n" 
                           : "";

            if (String.IsNullOrEmpty(FilePath.Text))
            {
                MessageBox.Show(this, "Please open an SHTML file.", "Error",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Match m = Regex.Match(data, "<td class=\"cen\"><a href=\"/spindex-bw/[0-9]{3}.shtml\">.*\\w</a>");

            while (m.Success)
            {
                string dNum = m.Value.Substring(37, 3);
                string name = m.Value.Replace("</a>", "");
                name = name.Substring(name.LastIndexOf('>') + 1);

                HexListBox.Text += String.Format("{0} - {1:X2} - {2}\r\n", dNum, counter, name);
                CodeBox.Text += String.Format(
                    "::{0}\r\n52045804 E2431001" +
                    "\r\n02045808 E3A060{1:X2}" + 
                    "\r\nD2000000 00000000\r\n\r\n", 
                    name, counter
                );

                counter++;
                m = m.NextMatch();
            }
        }

        private void cpyHexList_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(HexListBox.Text);
        }

        private void cpyARDSCode_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(CodeBox.Text);
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new About().Show();
        }
    }
}
