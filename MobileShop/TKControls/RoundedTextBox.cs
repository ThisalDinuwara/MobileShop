using MobileShop.TKControls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

public class RoundedTextBox : TextBox
{
    private int borderRadius = 40; // Adjust the radius for curve intensity
    private Color borderColor = Color.Gray;
    private int borderSize = 2;

    public int BorderRadius
    {
        get { return borderRadius; }
        set { borderRadius = value; Invalidate(); }
    }

    public Color BorderColor
    {
        get { return borderColor; }
        set { borderColor = value; Invalidate(); }
    }

    public int BorderSize
    {
        get { return borderSize; }
        set { borderSize = value; Invalidate(); }
    }

    public RoundedTextBox()
    {
        this.SetStyle(ControlStyles.UserPaint, true);
    }

    protected override void OnPaint(PaintEventArgs e)
    {
        base.OnPaint(e);

        using (GraphicsPath path = new GraphicsPath())
        {
            path.AddArc(0, 0, borderRadius, borderRadius, 180, 90);
            path.AddArc(Width - borderRadius, 0, borderRadius, borderRadius, 270, 90);
            path.AddArc(Width - borderRadius, Height - borderRadius, borderRadius, borderRadius, 0, 90);
            path.AddArc(0, Height - borderRadius, borderRadius, borderRadius, 90, 90);
            path.CloseFigure();

            this.Region = new Region(path);

            using (Pen pen = new Pen(borderColor, borderSize))
            {
                e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
                e.Graphics.DrawPath(pen, path);
            }
        }
    }
}


namespace MobileShop.TKControls
{
    internal class RoundedTextBox
    {
    }
}
