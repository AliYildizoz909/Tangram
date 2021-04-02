﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tangram.Shapes.Triangles.Big.Big1
{
    public class Small1Triangle45 : Shape
    {
        public Small1Triangle45()
        {
            BackColor = Color.Yellow;
            Name = Constants.Small1Triangle45;
            Type = ShapeTypes.SmallTriangle1;
            Size = new Size(Constants.Coefficient * 2, Constants.Coefficient * 2);
        }
        protected override void OnPaint(PaintEventArgs e)
        {
            using (var grp = new GraphicsPath())
            {
                grp.AddPolygon(ShapeManager.GetTrianglePoints45(Size.Height));
                this.Region = new Region(grp);
            }
            base.OnPaint(e);
        }

        protected override void OnClick(EventArgs e)
        {
            ShapeManager.SetNextShape(this, new Small1Triangle90());
            base.OnClick(e);
        }


    }
}
