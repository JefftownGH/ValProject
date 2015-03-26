using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Inventor;
using System.Runtime.InteropServices;

namespace ValProject
{
    /// <summary>
    /// Иницилиазириует Инвентор.
    /// </summary>
    public class InventorApi
    {
        private PartDocument _partDoc;

        /// <summary>
        /// Ссылка на приложение Инвентора.
        /// </summary>
        private Application _invApp {get; set; }

        /// <summary>
        /// Описание документа.
        /// </summary>
        public PartComponentDefinition PartDefinition { get; private set; }

        /// <summary>
        /// Геометрия приложения.
        /// </summary>
        public TransientGeometry TransientGeometry { get; private set; }

        /// <summary>
        /// Создание объекта коллекции
        /// </summary>
        /// <returns></returns>
        public ObjectCollection CreateObjectCollection()
        {
            return _invApp.TransientObjects.CreateObjectCollection();
        }
        /// <summary>
        /// Создание нового документа.
        /// </summary>
        public void CreateNewDocument()
        {
            _invApp = null;
            try
            {
                _invApp = (Application)Marshal.GetActiveObject("Inventor.Application");
            }
            catch (Exception)
            {
                try
                {
                    //Если не получилось перехватить приложение - выкинется ексепшн на то,
                    //что такого активного приложения нет. Попробуем создать приложение вручную.
                    Type invAppType = Type.GetTypeFromProgID("Inventor.Application");

                    _invApp = (Application)Activator.CreateInstance(invAppType);
                    _invApp.Visible = true;                                      
                }
                catch (Exception)
                {
                    //MessageBox.Show(ex2.ToString());
                    System.Windows.Forms.MessageBox.Show(@"Не получилось запустить инвентор.");
                }
            }

            _partDoc = (PartDocument)_invApp.Documents.Add //В открытом приложении создаем документ
                (DocumentTypeEnum.kPartDocumentObject,
                    _invApp.FileManager.GetTemplateFile
                        (DocumentTypeEnum.kPartDocumentObject,
                            SystemOfMeasureEnum.kMetricSystemOfMeasure));

            PartDefinition = _partDoc.ComponentDefinition; //Описание документа
          //  AssemblyDocument assDoc = (AssemblyDocument)_invApp.ActiveDocument;
            //_assemblyDef = assDoc.ComponentDefinition;
            TransientGeometry = _invApp.TransientGeometry; //инициализация метода геометрии
        }

        //Для построения от рабочих плоскостей.
        public PlanarSketch MakeNewSketch(int n, double Offset)
        {
            
            Inventor.WorkPlane MainPlane = PartDefinition.WorkPlanes[n];       //[1 - ZY; 2 - ZX; 3 - XY]
            Inventor.WorkPlane OffsetPlane = PartDefinition.WorkPlanes.AddByPlaneAndOffset(MainPlane, Offset, false);
            Inventor.PlanarSketch sketch = PartDefinition.Sketches.Add(OffsetPlane, false);
            return sketch;
        }

        //Для построения на поверхности детали.
        public PlanarSketch MakeNewSketch(Object Face, double Offset)
        {
            Inventor.WorkPlane OffsetPlane = PartDefinition.WorkPlanes.AddByPlaneAndOffset(Face, Offset, false);
            Inventor.PlanarSketch sketch = PartDefinition.Sketches.Add(OffsetPlane, false);
            //Face Face1 = partDef.SurfaceBodies[1].Faces[3];
            return sketch;
        }
       /// <summary>
       /// Нарисовать многоугольник.
       /// </summary>
       /// <param name="CircumferencePoint"></param>
       /// <param name="sketch"></param>
       /// <param name="CenterPoint"></param>
        public void DrawPolygon(Point2d CircumferencePoint, PlanarSketch sketch, Point2d CenterPoint)
        {
            sketch.SketchLines.AddAsPolygon(6, CenterPoint, CircumferencePoint, false);
            //SketchCircle Circle = sketch.SketchCircles.AddByCenterRadius(CenterPoint, Diameter / 20);
        }

       /// <summary>
        /// Отрисовка круга для звеньев.
       /// </summary>
       /// <param name="Diameter"></param>
       /// <param name="sketch"></param>
       /// <param name="CenterPoint"></param>
        public void DrawCircle(double Diameter, PlanarSketch sketch, Point2d CenterPoint)
        {
            sketch.SketchCircles.AddByCenterRadius(CenterPoint, Diameter);
            //SketchCircle Circle = sketch.SketchCircles.AddByCenterRadius(CenterPoint, Diameter / 20);
        }
    }
}
