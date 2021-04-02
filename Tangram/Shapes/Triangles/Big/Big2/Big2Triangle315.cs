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
    public class Big2Triangle315 : Shape
    {
        public Big2Triangle315()
        {
            BackColor = Color.Blue;

            Name = Constants.Big2Triangle315;
            Type = ShapeTypes.BigTriangle2;
            Size = new Size(Constants.Sqrt2Lenght, Constants.Sqrt2Lenght);
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            using (var grp = new GraphicsPath())
            {
                grp.AddPolygon(new Point[]
                {
                    new Point(Constants.Sqrt2Lenght,0),
                    new Point(Constants.Sqrt2Lenght,Constants.Sqrt2Lenght),
                    new Point(Constants.Sqrt2Lenght/2,Constants.Sqrt2Lenght/2)

                });

                this.Region = new Region(grp);
            }
            base.OnPaint(e);
        }


        protected override void OnClick(EventArgs e)
        {
            ShapeManager.SetNextShape(this, Constants.Big2Triangle0);
            base.OnClick(e);
        }
    }
}
