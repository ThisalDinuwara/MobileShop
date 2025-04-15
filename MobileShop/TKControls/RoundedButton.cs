using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

public class RoundedButton : Button
{
    public int CornerRadius { get; set; } = 40; // Adjust for more curve

    protected override void OnPaint(PaintEventArgs e)
    {
        base.OnPaint(e);
        Graphics graphics = e.Graphics;
        graphics.SmoothingMode = SmoothingMode.AntiAlias;

        // Create a rounded rectangle path
        GraphicsPath path = new GraphicsPath();
        int radius = CornerRadius * 2;

        path.AddArc(0, 0, radius, radius, 180, 90);
        path.AddArc(Width - radius, 0, radius, radius, 270, 90);
        path.AddArc(Width - radius, Height - radius, radius, radius, 0, 90);
        path.AddArc(0, Height - radius, radius, radius, 90, 90);
        path.CloseFigure();

        // Apply the rounded shape
        this.Region = new Region(path);

        // Fill the button background
        using (SolidBrush brush = new SolidBrush(this.BackColor))
        {
            graphics.FillPath(brush, path);
        }

        // Draw button border
        using (Pen pen = new Pen(Color.White, 3))
        {
            graphics.DrawPath(pen, path);
        }

        // Draw the text
        TextRenderer.DrawText(graphics, this.Text, this.Font, this.ClientRectangle, this.ForeColor,
            TextFormatFlags.HorizontalCenter | TextFormatFlags.VerticalCenter);
    }
}


namespace MobileShop.TKControls
{
    internal class RoundedButton
    {
    }
}
