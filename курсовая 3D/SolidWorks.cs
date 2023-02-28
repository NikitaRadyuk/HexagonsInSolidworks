using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using SolidWorks.Interop.sldworks;
using SolidWorks.Interop.swconst;
using SolidWorks.Interop.swcommands;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace CW
{
    public class SolidWorks
    {
        private SldWorks sldWorks = null;
        private ModelDoc2 modelDoc2;

        public SolidWorks()
        {
            CreatePart();
        }

        public void DrawHexagon(float x, float y, float z, float a, float r)
        {

            float h =(float)( Math.Sqrt(r * r - a * a / 4) + a * Math.Sqrt(3) / 2 - r);

            modelDoc2.Extension.SelectByID2("Front Plane", "PLANE", 0, 0, 0, false, 0, null, 0);
            modelDoc2.SketchManager.InsertSketch(true);

            for (int i = 0; i < 6; i++)
            {

                float x1 = (float)(x + a * Math.Cos(i * Math.PI / 3 + Math.PI / 6));
                float y1 = (float)(y + a * Math.Sin(i * Math.PI / 3 + Math.PI / 6));

                float x2 = (float)(x + h * Math.Cos(i * Math.PI / 3));
                float y2 = (float)(y + h * Math.Sin(i * Math.PI / 3));

                float x3 = (float)(x + a * Math.Cos(i * Math.PI / 3 - Math.PI / 6));
                float y3 = (float)(y + a * Math.Sin(i * Math.PI / 3 - Math.PI / 6));

                modelDoc2.SketchManager.Create3PointArc(x1, y1, z, x3, y3, z, x2, y2, z);
            }
            modelDoc2.SketchManager.InsertSketch(true);
        }

        /*public void DrawHexagon(float x, float y, float z, float a, float r)
        {

            float height = a * (float)Math.Sqrt(3) / 2;
            float b = (float)a / 2;
            float rvp = height;
            float rop = a;


            modelDoc2.SketchManager.InsertSketch(true);
            modelDoc2.SketchManager.CreateArc(x, y + rvp + height, z, x - b, y + rvp, z, x + b, y + rvp, z, 1);  //arc12 
            modelDoc2.ClearSelection();

            modelDoc2.SketchManager.CreateArc(x + height * (float)Math.Sqrt(3), y + height, z, x + b, y + rvp, z, x + rop, y, z, 1); //arc23
            modelDoc2.ClearSelection();

            modelDoc2.SketchManager.CreateArc(x + height * (float)Math.Sqrt(3), y - height, z, x + rop, y, z, x + b, y - rvp, z, 1); //arc34
            modelDoc2.ClearSelection();

            modelDoc2.SketchManager.CreateArc(x, y - rvp - height, z, x + b, y - rvp, z, x - b, y - rvp, z, 1);  //arc45
            modelDoc2.ClearSelection();

            modelDoc2.SketchManager.CreateArc(x - height * (float)Math.Sqrt(3), y - rvp, z, x - b, y - rvp, z, x - rop, y, z, 1);  //arc56
            modelDoc2.ClearSelection();

            modelDoc2.SketchManager.CreateArc(x - height * (float)Math.Sqrt(3), y + rvp, z, x - rop, y, z, x - b, y + rvp, z, 1);  //arc61
            modelDoc2.ClearSelection();

        }*/





        public void DrawPrism(float width, float height, float thickness)
        {
            width /= 2;
            height /= 2; 

            modelDoc2.SketchManager.InsertSketch(true);
            modelDoc2.Extension.SelectByID2("Front Plane", "PLANE", 0, 0, 0, false, 0, null, 0);
            modelDoc2.ClearSelection();
            modelDoc2.SketchManager.CreateLine(-width, height, 0, width, height, 0);
            modelDoc2.SketchManager.CreateLine(width, height, 0, width, -height, 0);
            modelDoc2.SketchManager.CreateLine(width, -height, 0, -width, -height, 0);
            modelDoc2.SketchManager.CreateLine(-width, -height, 0, -width, height, 0);
            modelDoc2.ClearSelection();
            modelDoc2.SketchManager.InsertSketch(true);
            modelDoc2.FeatureManager.FeatureExtrusion2(true, false, true, 0, 0, thickness, 0.01, false, false, false, false, 0, 0, false, false, false, false, true, true, true, 0, 0, false);
        }

        public void Cut(float depth, int num)
        {
            modelDoc2.Extension.SelectByID2("Эскиз" + num, "SKETCH", 0, 0, 0, false, 0, null, 0);
            modelDoc2.FeatureManager.FeatureCut3(true, false, false, 0, 0, depth, 0.01, false, false, false, false, 0, 0, false, false, false, false, false, true, true, true, true, false, 0, 0, false);
            modelDoc2.ClearSelection();
          
        }

        private void CreatePart()
        {
            try
            {
                sldWorks = (SldWorks)Marshal.GetActiveObject("SldWorks.Application");

                if (sldWorks.ActiveDoc == null)
                {
                    modelDoc2 = (ModelDoc2)sldWorks.INewPart();
                    modelDoc2.SetUnits((short)swLengthUnit_e.swMM, (short)swFractionDisplay_e.swDECIMAL, 0, 0, false);
                }

                modelDoc2 = sldWorks.IActiveDoc2;

            }
            catch
            {
                MessageBox.Show("Couldn't open file.");
            }
        }
    }
}
