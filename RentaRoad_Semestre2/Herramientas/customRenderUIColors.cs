using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace RentaRoad_Semestre3.Herramientas
{
    public class customRenderUIColors : ToolStripProfessionalRenderer
    {
        public customRenderUIColors() : base(new customColorsRender()) { }

    }
    public class customColorsRender : ProfessionalColorTable
    {
        public override Color ToolStripDropDownBackground 
        {
            get { return Color.FromArgb(56, 62, 70); }
        }
        public override Color MenuItemSelectedGradientBegin
        {
            get { return Color.DimGray; }
        }
        public override Color MenuItemSelectedGradientEnd
        {
            get { return Color.DimGray; }
        }
        public override Color MenuItemPressedGradientBegin
        {
            get { return Color.DimGray; }
        }
        public override Color MenuItemPressedGradientMiddle
        {
            get { return Color.DimGray; }
        }
        public override Color MenuItemPressedGradientEnd
        {
            get { return Color.DimGray; }
        }
    }
}
