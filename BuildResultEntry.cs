using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Nimride
{

    [Flags]
    public enum BuildResultEntryType
    {
        None=0,
        Message=1,
        Error=2,
        Warning=4,
        Hint=8
    }

    public class BuildResultEntry
    {

        public readonly string Text;
        public readonly BuildResultEntryType Type = BuildResultEntryType.Message;

       

        public BuildResultEntry(string txt)
        {
            this.Text = txt;

            if (Text.Contains("Hint:"))
                Type = BuildResultEntryType.Hint;
            else if (Text.Contains("Error:"))
                Type = BuildResultEntryType.Error;
            else if (Text.Contains("Warning:"))
                Type = BuildResultEntryType.Warning;
        }

        public override string ToString()
        {
            return Text;
        }


        internal void Draw(DrawItemEventArgs e)
        {
            e.DrawBackground();

            Rectangle bounds = e.Bounds;
            int textleft = (int)bounds.Left + Icons.Error.Width + 6;

            Image img=null;
            switch(Type) {
                case BuildResultEntryType.Error: img=Icons.Error;break;
                case BuildResultEntryType.Warning: img=Icons.Warning;break;
                case BuildResultEntryType.Hint: img=Icons.Hint;break;
            }
             
            if(img!=null)
                e.Graphics.DrawImage(img, (float)bounds.Left + 3, bounds.Top + bounds.Height / 2f - img.Height / 2f, img.Width, img.Height);


            Brush textbrush = (e.State & DrawItemState.Selected) != 0 ? SystemBrushes.HighlightText : SystemBrushes.WindowText;
            SizeF texsiz = e.Graphics.MeasureString(Text, e.Font);
            e.Graphics.DrawString(Text, e.Font, textbrush, (float)textleft, bounds.Top + bounds.Height / 2f - texsiz.Height / 2f);



            
        }
    }
}
