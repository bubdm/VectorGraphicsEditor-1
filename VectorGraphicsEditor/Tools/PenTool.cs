﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using VectorGraphicsEditor.Figures;

namespace VectorGraphicsEditor.Tools
{
    class PenTool : Tool
    {
        public override void MouseDown(Point mousePosition)
        {
            base.MouseDown(mousePosition);

            GlobalVars.figures.Add(new Pen(GlobalVars.pen.Clone()));
        }

        public override void MouseMove(Point mousePosition)
        {
            if (isDown)
                GlobalVars.figures.Last().points.Add(mousePosition);
        }
    }
}
