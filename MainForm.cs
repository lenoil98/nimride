﻿using FastColoredTextBoxNS;
using Nimride.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Nimride
{
    public partial class MainForm : Form
    {

        int nonameCount = 1;


        List<BuildResultEntry> buildResult = new List<BuildResultEntry>();

        public MainForm()
        {
            InitializeComponent();

            tabControl1.TabPages.Clear();

            buildOutput.ItemHeight = (int)(Icons.Error.Height * 1.2);

            CreateDocument();
        }



        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CreateDocument();
        }


        private void UpdateTabText(TabPage tp)
        {
            if (tp == null)
                return;

            NimEditor ed = tp.Controls[0] as NimEditor;
            if (ed == null)
                return;

            string displayName = ed.DisplayName;

            if (string.IsNullOrEmpty(displayName))
            {
                if (ed.NonameIndex <= 0) //unique noname count index
                    ed.NonameIndex = nonameCount++;
                if (string.IsNullOrEmpty(displayName))
                    displayName = "NONAME" + (ed.NonameIndex).ToString(CultureInfo.InvariantCulture) + ".nim";
            }

            if (ed.Modified)
                tp.Text = displayName + "*";
            else
                tp.Text = displayName;
        }

        private NimEditor CreateDocument(string filename="",string displayName="")
        {

            NimEditor se = new NimEditor(filename);

            se.ModifiedChanged += se_ModifiedChanged;

           

            TabPage tp = new TabPage(displayName);
            se.Dock = DockStyle.Fill;
            tp.Controls.Add(se);
            tabControl1.TabPages.Add(tp);
            tabControl1.SelectedTab = tp;

            UpdateTabText(tp);

            return se;
        }

        void se_ModifiedChanged(object sender, EventArgs args)
        {
            TabPage tp=FindTabPage(sender as NimEditor);
            if(tp!=null)
                UpdateTabText(tp);
        }


        private bool OpenDocument(string filename)
        {

            //TODO: check if document is already open and switch to it!

            //ios this document already opened? if so, switch to it:
            NimEditor oldEditor = FindEditor(filename);
            if (oldEditor != null)
            {
                var tp = FindTabPage(oldEditor);
                if (tp != null)
                {
                    tabControl1.SelectedTab = tp;
                    return true;
                }
            }

            if (File.Exists(filename))
            {
                NimEditor se=CreateDocument(filename);
                se.OpenFile(filename, Encoding.UTF8);
                se.Modified = false;

                return true;
            }

            return false;
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {

            //try to use the directory of the current file
            openDialog.FileName = "";
            var ed = CurrentEditor;
            if (ed!=null && !string.IsNullOrWhiteSpace(ed.FileName))
            {
                openDialog.InitialDirectory = Path.GetDirectoryName(ed.FileName);
            }
            

            if (openDialog.ShowDialog()==DialogResult.OK)
            {
                foreach (string fn in openDialog.FileNames)
                {
                    OpenDocument(fn);
                }
            }
        }

        private void findToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var doc = CurrentEditor;
            if (doc == null) return;

            doc.ShowFindDialog();
        }

        NimEditor CurrentEditor
        {
            get
            {
                TabPage tp=tabControl1.SelectedTab;
                if (tp == null) return null;
                return tp.Controls[0] as NimEditor;
            }
        }


        List<NimEditor> AllEditors
        {
            get
            {
                List<NimEditor> res = new List<NimEditor>();
                foreach (TabPage tp in tabControl1.TabPages)
                {
                    NimEditor ed=tp.Controls[0] as NimEditor;

                    if (ed != null)
                        res.Add(ed);
                }

                return res;
            }
        }

        NimEditor FindEditor(string filename)
        {
            if (string.IsNullOrWhiteSpace(filename))
                return null;

            foreach(NimEditor ed in AllEditors) {
                if (ed.FileName == filename)
                    return ed;
            }

            return null;
        }

        TabPage FindTabPage(NimEditor ed)
        {
            foreach (TabPage tp in tabControl1.TabPages)
            {
                if (tp.Controls[0] as NimEditor == ed)
                    return tp;
            }

            return null;
        }


        bool GetCurrentFile(out string filename, bool showSaveMsg)
        {
            filename = null;

            NimEditor ed = CurrentEditor;
            if (ed == null)
                return false;
            if (!File.Exists(ed.FileName))
            {
                if(showSaveMsg) 
                    MessageBox.Show("The current file has to be saved first.");
                return false;
            }

            filename = ed.FileName;
            return true;
        }

        private void syntaxCheckToolStripMenuItem_Click(object sender, EventArgs e)
        {
            buildOutput.Items.Clear();

            string fn, output;
            if (!GetCurrentFile(out fn, true))
                return;

            systemExec("nimrod", false, out output, "c", "-c", fn);
        }


        bool BuildCurrentFile(out string exeresult)
        {
            buildResult.Clear();
            UpdateBuildResultList();

            exeresult = null;
            string output = null;

            string srcfile;
            if (!GetCurrentFile(out srcfile, true))
                return false;

            exeresult=Path.ChangeExtension(srcfile,".exe");

            bool res=systemExec("nimrod",false,out output, "c", "--out:"+exeresult,srcfile) == 0;


            if (output != null)
            {
                string[] lines = output.Split(new char[] { '\r', '\n' },StringSplitOptions.RemoveEmptyEntries);

                foreach (string lin in lines)
                {
                    buildResult.Add(new BuildResultEntry(lin));
                }
            }

            UpdateBuildResultList();


            return res;
        }

       
        string QuoteIfWhities(string str)
        {
            //Quotes a string if it contains whitespaces
            str = str.Trim();
            bool haswhite=false;
            foreach (char c in str)
            {
                if (char.IsWhiteSpace(c))
                {
                    haswhite = true;
                    break;
                }
            }

            if (haswhite)
                return "\"" + str + "\"";
            else
                return str;

        }

        private int systemExec(string exefile,bool shell, out string output,params string[] args)
        {

            output = null;

            List<string> quoteFixed=new List<string>();
            foreach (string str in args)
                quoteFixed.Add(QuoteIfWhities(str));
            string argJoin = string.Join(" ",quoteFixed);

            Process cmd = new Process();
            cmd.StartInfo.FileName = QuoteIfWhities(exefile);
            cmd.StartInfo.Arguments = argJoin;
            cmd.StartInfo.UseShellExecute = shell;
            cmd.StartInfo.CreateNoWindow = true;
            cmd.StartInfo.RedirectStandardOutput = !shell;
            //cmd.StartInfo.RedirectStandardError = !shell;

            cmd.Start();

            cmd.WaitForExit();

            if (!shell)
            {
                output = cmd.StandardOutput.ReadToEnd();
                //messageConsole.AppendText(cmd.StandardError.ReadToEnd());
            }

            return cmd.ExitCode;
        }

      


        /// <summary>
        /// Returns true if the file was saved or false if canceled by the user.
        /// </summary>
        bool SaveAs(NimEditor ed)
        {
            if (ed == null)
                return true;

            if (!string.IsNullOrWhiteSpace(ed.FileName))
            {
                string dir = Path.GetDirectoryName(ed.FileName);
                string fn = Path.GetFileName(ed.FileName);

                if (Directory.Exists(dir))
                    saveDialog.InitialDirectory = dir;
                saveDialog.FileName = Path.GetFileName(ed.FileName);
            }

            if (saveDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    ed.SaveToFile(saveDialog.FileName, Encoding.UTF8);
                    ed.FileName=saveDialog.FileName;
                    ed.Modified = true; //ste to true+false to force uodate of filename in tab even if modified was not changed
                    ed.Modified = false;
                    return true;
                }
                catch (Exception exc)
                {
                    MessageBox.Show(exc.Message);
                    throw;
                }
            }

            return false;
        }

        /// <summary>
        /// Returns true if the file was saved or false if canceled by the user (which can happen
        /// if this file falls back to "Save as")
        /// </summary>
        bool Save(NimEditor ed)
        {
            if (ed == null)
                return true;

            if (!File.Exists(ed.FileName))
            {
                return SaveAs(ed);
            }

            try
            {
                ed.SaveToFile(ed.FileName, Encoding.UTF8);
                ed.Modified = false;
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
                throw;
            }
                

            return true;
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var ed = CurrentEditor;
            if (ed != null)
            {
                Save(ed);
            }
        }

        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var ed=CurrentEditor;
            if (ed != null)
                SaveAs(ed);
        }

        private void debugCurrentFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string exefile;
            string output = null;

            if (Settings.Default.SaveFilesBeforeBuild)
            {
                if (!SaveAllFiles())
                    return;
            }


            if (BuildCurrentFile(out exefile))
            {
                systemExec(exefile,true,out output);
            }
        }



        bool CloseCurrentFile()
        {
            var ed = CurrentEditor;
            if (ed == null)
                return true; //done already

            TabPage tp = FindTabPage(ed);
            if (tp == null)
                return true;

            if (ed.Modified)
            {

                DialogResult dr = MessageBox.Show(tp.Text.Trim('*') + " is modified, save before closing?", "Save?", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
                if (dr == DialogResult.Cancel)
                    return false;
                else if (dr == DialogResult.Yes)
                {
                    bool cancel = !Save(ed);
                    if (cancel)
                        return false;
                }
            }

            tp.Dispose();
            return true;
            
        }

        bool CloseAllFiles()
        {
            while (tabControl1.TabPages.Count > 0)
            {
                if (!CloseCurrentFile())
                    return false;
            }

            return true;

        }


        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CloseCurrentFile();
        }

        private void closeAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CloseAllFiles();
        }

       

        private void buildOutput_DrawItem(object sender, DrawItemEventArgs e)
        {
            int idx = e.Index;
            if (idx >= 0)
            {
                BuildResultEntry bre = buildOutput.Items[idx] as BuildResultEntry;
                if (bre != null)
                {
                    bre.Draw(e);
                }
            }
        }


        void UpdateBuildResultList()
        {

            buildOutput.Items.Clear();

            BuildResultEntryType addMask = BuildResultEntryType.None;
            if (errorMask.Checked) addMask |= BuildResultEntryType.Error;
            if (hintMask.Checked) addMask |= BuildResultEntryType.Hint;
            if (warningMask.Checked) addMask |= BuildResultEntryType.Warning;
            if (messageMask.Checked) addMask |= BuildResultEntryType.Message;


            int errors = 0, hints = 0, warnings = 0, messages = 0;

            foreach (BuildResultEntry bre in buildResult)
            {
                
                if( (bre.Type & addMask)!=0)
                    buildOutput.Items.Add(bre);

                switch(bre.Type) {
                    case BuildResultEntryType.Error: errors++;break;
                    case BuildResultEntryType.Warning: warnings++; break;
                    case BuildResultEntryType.Hint: hints++; break;
                    default: messages++; break;
                }
            }

            errorMask.Text = errors.ToString(CultureInfo.InvariantCulture) + " Errors";
            warningMask.Text = warnings.ToString(CultureInfo.InvariantCulture) + " Warnings";
            hintMask.Text = hints.ToString(CultureInfo.InvariantCulture) + " Hints";
            messageMask.Text = messages.ToString(CultureInfo.InvariantCulture) + " Messages";
        }
        
        private void maskCheckedChanged(object sender, EventArgs e)
        {
            UpdateBuildResultList();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }



        bool SaveAllFiles()
        {

            foreach (NimEditor ed in AllEditors)
            {
                if (!Save(ed)) 
                    return false;
                
            }

            return true;
        }

        private void saveAllMenuItem_Click(object sender, EventArgs e)
        {
            SaveAllFiles();
        }
    }
}
