using FastColoredTextBoxNS;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace Nimride
{




    public delegate void ModifiedDelegate(object sender,EventArgs args);

    public class NimEditor:FastColoredTextBox
    {

        public string FileName = "";
        private bool modified=false;
        public int NonameIndex = -1;    //used when generatinmg a default NONAMExx name for this drawing


        static TextStyle numberStyle = new TextStyle(Brushes.Green, null, FontStyle.Regular);
        static TextStyle keywordsStyle = new TextStyle(Brushes.Blue, null, FontStyle.Bold);
        static TextStyle commentStyle = new TextStyle(Brushes.Gray, null, FontStyle.Bold);
        static TextStyle docCommentStyle = new TextStyle(Brushes.Gray, Brushes.LightGray, FontStyle.Bold);
        static TextStyle delimiterStyle = new TextStyle(Brushes.Red, null, FontStyle.Regular);

        static Regex regexKeyword;

        private static string keywords = @"addr and as asm atomic
bind block break
case cast const continue converter
discard distinct div do
elif else end enum except export
finally for from
generic
if import in include interface is isnot iterator
lambda let
macro method mixin mod
nil not notin
object of or out
proc ptr
raise ref return
shl shr static
template try tuple type
using
var
when while with without
xor
yield";


        public bool Modified
        {
            get
            {
                return modified;
            }
            set
            {
                if (modified != value)
                {
                    modified = value;
                    OnModifiedChanged();
                }
            }
        }


        public event ModifiedDelegate ModifiedChanged;

        public virtual void OnModifiedChanged() {
            if(ModifiedChanged!=null)
                ModifiedChanged(this, EventArgs.Empty);
        }

        public NimEditor(string fileName)
        {
            this.FileName = fileName ?? "";
            
            this.TextChanged += SyntaxEdit_TextChanged;
            this.TabLength = 2;
            this.AcceptsTab = true;
        }

        

        static NimEditor()
        {
            string[] kwdSplit = keywords.Split(new char[] { '\n', '\r', ' ' }, StringSplitOptions.RemoveEmptyEntries);
            string kwdJoin = string.Join("|", kwdSplit);
            regexKeyword = new Regex(@"\b(" + kwdJoin + ")");
        }

        void SyntaxEdit_TextChanged(object sender, TextChangedEventArgs e)
        {

            Modified = true;

            e.ChangedRange.ClearStyle(numberStyle,keywordsStyle,docCommentStyle,commentStyle,delimiterStyle);

            e.ChangedRange.SetStyle(docCommentStyle, @"##.*$", RegexOptions.Multiline);
            e.ChangedRange.SetStyle(commentStyle, @"#.*$", RegexOptions.Multiline);

            e.ChangedRange.SetStyle(numberStyle, @"[0-9]+");
            e.ChangedRange.SetStyle(keywordsStyle,regexKeyword);
            e.ChangedRange.SetStyle(delimiterStyle, @"[\[\]\(\)\{\}=]");
        }

        public string DisplayName
        {
            get
            {

                if (string.IsNullOrEmpty(FileName))
                    return "";
                else
                    return Path.GetFileName(FileName);
            }
        }


        
        


    }
}
