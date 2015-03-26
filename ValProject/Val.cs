using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Inventor;

namespace ValProject
{
    /// <summary>
    /// Деталь вала.
    /// </summary>
    public class Val
    {
        /// <summary>
        /// Апи инвентора.
        /// </summary>
        private InventorApi _inventorApi;

        /// <summary>
        /// Текущая точка.
        /// </summary>
        private Point2d _curPoint;

        //доп. задание
        /// <summary>
        /// Переменные, отвечающие за положение зубьев на вале.
        /// </summary>
        private double _numTeethLevelL;
        private double _numTeethLevelR;
        private double _numTeethLevelQ;
        private double _distance;
        /// <summary>
        /// Параметры вала.
        /// </summary>
        public ValParameters ValParameters { get; private set; }

        /// <summary>
        /// Конструктор.
        /// </summary>
        /// <param name="valParameters">Параметры вала.</param>
        /// <param name="inventorApi">Апишка инвентора.</param>
        public Val(ValParameters valParameters, InventorApi inventorApi)
        {
            _inventorApi = inventorApi;
            ValParameters = valParameters;
        }

        /// <summary>
        /// Метод создания модели.
        /// </summary>
        public void Build()
        {
            _inventorApi.CreateNewDocument();

            _curPoint = _inventorApi.TransientGeometry.CreatePoint2d(0, 0); //Текущая точка по центру.

            BuildStem1();
            BuildStem2();
            BuildStem3();
            BuildStem4();
            BuildStem5();
            BuildStem6();
            BuildStem7();
            BuildTeeth();
            
        }
        /// <summary>
        /// Построение зубьев вала.
        /// </summary>
        private void BuildTeeth()
        {
            if (ValParameters.GetParameter(ParameterType.NumTeethLevelSetted).Value == 1)
            {
                _numTeethLevelL = ValParameters.GetParameter(ParameterType.LengthFirstLevel).Value - ValParameters.GetParameter(ParameterType.LengthFirstLevel).Value;

                _numTeethLevelR = ValParameters.GetParameter(ParameterType.RadiusFirstLevel).Value +
                    ValParameters.GetParameter(ParameterType.RadiusFirstLevel).Value / 10;

                _numTeethLevelQ = ValParameters.GetParameter(ParameterType.RadiusFirstLevel).Value;

                _distance = ValParameters.GetParameter(ParameterType.LengthFirstLevel).Value;
            }
            //
            if (ValParameters.GetParameter(ParameterType.NumTeethLevelSetted).Value == 2)
            {
                _numTeethLevelL = ValParameters.GetParameter(ParameterType.LengthFirstLevel).Value;

                _numTeethLevelR = ValParameters.GetParameter(ParameterType.RadiusSecondLevel).Value +
                    ValParameters.GetParameter(ParameterType.RadiusSecondLevel).Value / 10;

                _numTeethLevelQ = ValParameters.GetParameter(ParameterType.RadiusSecondLevel).Value;

                _distance = ValParameters.GetParameter(ParameterType.LengthSecondLevel).Value;
            }
            //
            if (ValParameters.GetParameter(ParameterType.NumTeethLevelSetted).Value == 3)
            {
                _numTeethLevelL = ValParameters.GetParameter(ParameterType.LengthFirstLevel).Value +
                    ValParameters.GetParameter(ParameterType.LengthSecondLevel).Value;

                _numTeethLevelR = ValParameters.GetParameter(ParameterType.RadiusThirdLevel).Value +
                ValParameters.GetParameter(ParameterType.RadiusThirdLevel).Value / 10;

                _numTeethLevelQ = ValParameters.GetParameter(ParameterType.RadiusThirdLevel).Value;

                _distance = ValParameters.GetParameter(ParameterType.LengthThirdLevel).Value;
            }
            //
            if (ValParameters.GetParameter(ParameterType.NumTeethLevelSetted).Value == 4)
            {
                _numTeethLevelL = 
                    ValParameters.GetParameter(ParameterType.LengthFirstLevel).Value + ValParameters.GetParameter(ParameterType.LengthSecondLevel).Value +
                    ValParameters.GetParameter(ParameterType.LengthThirdLevel).Value;

                _numTeethLevelR = ValParameters.GetParameter(ParameterType.RadiusFourthLevel).Value +
                ValParameters.GetParameter(ParameterType.RadiusFourthLevel).Value / 10;

                _numTeethLevelQ = ValParameters.GetParameter(ParameterType.RadiusFourthLevel).Value;

                _distance = ValParameters.GetParameter(ParameterType.LengthFourthLevel).Value;
            }
            //
            if (ValParameters.GetParameter(ParameterType.NumTeethLevelSetted).Value == 5)
            {
                _numTeethLevelL = 
                    ValParameters.GetParameter(ParameterType.LengthFirstLevel).Value + ValParameters.GetParameter(ParameterType.LengthSecondLevel).Value +
                    ValParameters.GetParameter(ParameterType.LengthThirdLevel).Value + ValParameters.GetParameter(ParameterType.LengthFourthLevel).Value;

                _numTeethLevelR = ValParameters.GetParameter(ParameterType.RadiusFifthLevel).Value +
                ValParameters.GetParameter(ParameterType.RadiusFifthLevel).Value / 10;

                _numTeethLevelQ = ValParameters.GetParameter(ParameterType.RadiusFifthLevel).Value;

                _distance = ValParameters.GetParameter(ParameterType.LengthFifthLevel).Value;
            }
            //
            if (ValParameters.GetParameter(ParameterType.NumTeethLevelSetted).Value == 6)
            {
                _numTeethLevelL = 
                    ValParameters.GetParameter(ParameterType.LengthFirstLevel).Value + ValParameters.GetParameter(ParameterType.LengthSecondLevel).Value +
                    ValParameters.GetParameter(ParameterType.LengthThirdLevel).Value + ValParameters.GetParameter(ParameterType.LengthFourthLevel).Value +
                    ValParameters.GetParameter(ParameterType.LengthFifthLevel).Value;

                _numTeethLevelR = ValParameters.GetParameter(ParameterType.RadiusSixthLevel).Value +
                ValParameters.GetParameter(ParameterType.RadiusSixthLevel).Value / 10;

                _numTeethLevelQ = ValParameters.GetParameter(ParameterType.RadiusSixthLevel).Value;

                _distance = ValParameters.GetParameter(ParameterType.LengthSixthLevel).Value;
            }
            //
            if (ValParameters.GetParameter(ParameterType.NumTeethLevelSetted).Value == 7)
            {
                _numTeethLevelL = ValParameters.GetParameter(ParameterType.LengthFirstLevel).Value +
                    ValParameters.GetParameter(ParameterType.LengthSecondLevel).Value +
                    ValParameters.GetParameter(ParameterType.LengthThirdLevel).Value +
                    ValParameters.GetParameter(ParameterType.LengthFourthLevel).Value +
                    ValParameters.GetParameter(ParameterType.LengthFifthLevel).Value +
                    ValParameters.GetParameter(ParameterType.LengthSixthLevel).Value;

                _numTeethLevelR = ValParameters.GetParameter(ParameterType.RadiusSeventhLevel).Value +
                ValParameters.GetParameter(ParameterType.RadiusSeventhLevel).Value / 10;

                _numTeethLevelQ = ValParameters.GetParameter(ParameterType.RadiusSeventhLevel).Value;

                _distance = ValParameters.GetParameter(ParameterType.LengthSeventhLevel).Value;
            }

            PlanarSketch StemSketchQ = _inventorApi.MakeNewSketch(3, _numTeethLevelL);// второй параметр отодвигает по Z координате на заданную длину.
            Point2d pointQ = _inventorApi.TransientGeometry.CreatePoint2d(_numTeethLevelR, 0);
            Point2d CenterPointQ = _inventorApi.TransientGeometry.CreatePoint2d(_numTeethLevelQ, 0);
            _inventorApi.DrawPolygon(pointQ, StemSketchQ, CenterPointQ);
           //DrawPolygon(pointQ, StemSketchQ, CenterPointQ);

            ExtrudeDefinition extrudeDefQ =
               _inventorApi.PartDefinition.
               Features.
               ExtrudeFeatures.
               CreateExtrudeDefinition(StemSketchQ.Profiles.AddForSolid(), PartFeatureOperationEnum.kCutOperation);
               extrudeDefQ.SetDistanceExtent(
                _distance, // insteadof _distance = ValParameters.GetParameter(ParameterType.LengthFirstLevel).Value;
                PartFeatureExtentDirectionEnum.kPositiveExtentDirection);
               ExtrudeFeature extrudeQ = _inventorApi.PartDefinition.Features.ExtrudeFeatures.Add(extrudeDefQ);



            //Базовые оси
            //для создания массива.
            WorkAxis XAxis = _inventorApi.PartDefinition.WorkAxes[1];
            WorkAxis YAxis = _inventorApi.PartDefinition.WorkAxes[2];
            WorkAxis ZAxis = _inventorApi.PartDefinition.WorkAxes[3];

            //Create an object collection
            ObjectCollection objectCollection = _inventorApi.CreateObjectCollection();
            objectCollection.Add(extrudeQ);
                _inventorApi.PartDefinition.Features.CircularPatternFeatures.Add(
                    objectCollection,
                    ZAxis,
                    true,
                   // (int)(ValParameters.GetParameter(ParameterType.RadiusThirdLevel).Value/1.5),
                    (int)(ValParameters.GetParameter(ParameterType.NumTeeth).Value),
                    "360 deg",
                    true,
                    PatternComputeTypeEnum.kAdjustToModelCompute);
        }

        /// <summary>
        /// Ступень 7
        /// </summary>
        private void BuildStem7()//////////////////
        {
            PlanarSketch StemSketch7 = _inventorApi.MakeNewSketch(3,
                ValParameters.GetParameter(ParameterType.LengthFirstLevel).Value +
                ValParameters.GetParameter(ParameterType.LengthSecondLevel).Value +
                ValParameters.GetParameter(ParameterType.LengthThirdLevel).Value +
                ValParameters.GetParameter(ParameterType.LengthFourthLevel).Value +
                ValParameters.GetParameter(ParameterType.LengthFifthLevel).Value +
                ValParameters.GetParameter(ParameterType.LengthSixthLevel).Value);// второй параметр отодвигает по Z координате на заданную длину.
            // transientGeometry = invApp.TransientGeometry;
            // Point2d point2 = transientGeometry.CreatePoint2d(0, 0);   //построен эскиз 
            _inventorApi.DrawCircle(ValParameters.GetParameter(ParameterType.RadiusSeventhLevel).Value, StemSketch7, _curPoint);

            ExtrudeDefinition extrudeDef7 =
                _inventorApi.PartDefinition.
                Features.
                ExtrudeFeatures.
                CreateExtrudeDefinition(StemSketch7.Profiles.AddForSolid(), PartFeatureOperationEnum.kJoinOperation);
            extrudeDef7.SetDistanceExtent(ValParameters.GetParameter(ParameterType.LengthSeventhLevel).Value, PartFeatureExtentDirectionEnum.kPositiveExtentDirection);
            ExtrudeFeature extrude7 = _inventorApi.PartDefinition.Features.ExtrudeFeatures.Add(extrudeDef7);
        }

        /// <summary>
        /// Ступень 6 
        /// </summary>
        private void BuildStem6()///////////////////
        {
            PlanarSketch StemSketch6 = _inventorApi.MakeNewSketch(3,
                ValParameters.GetParameter(ParameterType.LengthFirstLevel).Value +
                ValParameters.GetParameter(ParameterType.LengthSecondLevel).Value +
                ValParameters.GetParameter(ParameterType.LengthThirdLevel).Value +
                ValParameters.GetParameter(ParameterType.LengthFourthLevel).Value +
                ValParameters.GetParameter(ParameterType.LengthFifthLevel).Value);// второй параметр отодвигает по Z координате на заданную длину.
            // transientGeometry = invApp.TransientGeometry;
            // Point2d point2 = transientGeometry.CreatePoint2d(0, 0);   //построен эскиз 
            _inventorApi.DrawCircle(ValParameters.GetParameter(ParameterType.RadiusSixthLevel).Value, StemSketch6, _curPoint);
            //111111111111
            ExtrudeDefinition extrudeDef6 =
                _inventorApi.PartDefinition.
                Features.
                ExtrudeFeatures.
                CreateExtrudeDefinition(StemSketch6.Profiles.AddForSolid(), PartFeatureOperationEnum.kJoinOperation);
            extrudeDef6.SetDistanceExtent(ValParameters.GetParameter(ParameterType.LengthSixthLevel).Value, PartFeatureExtentDirectionEnum.kPositiveExtentDirection);
            ExtrudeFeature extrude6 = _inventorApi.PartDefinition.Features.ExtrudeFeatures.Add(extrudeDef6);
        }

        /// <summary>
        /// Ступень 5
        /// </summary>
        private void BuildStem5()
        {
            PlanarSketch StemSketch5 = _inventorApi.MakeNewSketch(3, 
                ValParameters.GetParameter(ParameterType.LengthFirstLevel).Value +
                ValParameters.GetParameter(ParameterType.LengthSecondLevel).Value +
                ValParameters.GetParameter(ParameterType.LengthThirdLevel).Value +
                ValParameters.GetParameter(ParameterType.LengthFourthLevel).Value);// второй параметр отодвигает по Z координате на заданную длину.
            // transientGeometry = invApp.TransientGeometry;
            // Point2d point2 = transientGeometry.CreatePoint2d(0, 0);   //построен эскиз 
            _inventorApi.DrawCircle(ValParameters.GetParameter(ParameterType.RadiusFifthLevel).Value, StemSketch5, _curPoint);

            ExtrudeDefinition extrudeDef5 =
                _inventorApi.PartDefinition.
                Features.
                ExtrudeFeatures.
                CreateExtrudeDefinition(StemSketch5.Profiles.AddForSolid(), PartFeatureOperationEnum.kJoinOperation);
            extrudeDef5.SetDistanceExtent(ValParameters.GetParameter(ParameterType.LengthFifthLevel).Value, PartFeatureExtentDirectionEnum.kPositiveExtentDirection);
            ExtrudeFeature extrude5 = _inventorApi.PartDefinition.Features.ExtrudeFeatures.Add(extrudeDef5);
        }

        /// <summary>
        /// Ступень 4
        /// </summary>
        private void BuildStem4()
        {
            PlanarSketch StemSketch4 = _inventorApi.MakeNewSketch(3,
                ValParameters.GetParameter(ParameterType.LengthFirstLevel).Value +
                ValParameters.GetParameter(ParameterType.LengthSecondLevel).Value +
                ValParameters.GetParameter(ParameterType.LengthThirdLevel).Value);// второй параметр отодвигает по Z координате на заданную длину.
            // transientGeometry = invApp.TransientGeometry;
            // Point2d point2 = transientGeometry.CreatePoint2d(0, 0);   //построен эскиз 
            _inventorApi.DrawCircle(ValParameters.GetParameter(ParameterType.RadiusFourthLevel).Value, StemSketch4, _curPoint);

            ExtrudeDefinition extrudeDef4 =
                _inventorApi.PartDefinition.
                Features.
                ExtrudeFeatures.
                CreateExtrudeDefinition(StemSketch4.Profiles.AddForSolid(), PartFeatureOperationEnum.kJoinOperation);
            extrudeDef4.SetDistanceExtent(ValParameters.GetParameter(ParameterType.LengthFourthLevel).Value, PartFeatureExtentDirectionEnum.kPositiveExtentDirection);
            ExtrudeFeature extrude4 = _inventorApi.PartDefinition.Features.ExtrudeFeatures.Add(extrudeDef4);
        }

        /// <summary>
        /// Ступень 3
        /// </summary>
        private void BuildStem3()
        {
            PlanarSketch StemSketch3 = _inventorApi.MakeNewSketch(3,
                ValParameters.GetParameter(ParameterType.LengthFirstLevel).Value +
                ValParameters.GetParameter(ParameterType.LengthSecondLevel).Value);// второй параметр отодвигает по Z координате на заданную длину.

            _inventorApi.DrawCircle(ValParameters.GetParameter(ParameterType.RadiusThirdLevel).Value, StemSketch3, _curPoint);
           // StemSketch3.Profiles.AddForSolid();

            ExtrudeDefinition extrudeDef3 =
                _inventorApi.PartDefinition.
                Features.
                ExtrudeFeatures.
                CreateExtrudeDefinition(StemSketch3.Profiles.AddForSolid(), PartFeatureOperationEnum.kJoinOperation);
            extrudeDef3.SetDistanceExtent(ValParameters.GetParameter(ParameterType.LengthThirdLevel).Value, PartFeatureExtentDirectionEnum.kPositiveExtentDirection);
            ExtrudeFeature extrude3 = _inventorApi.PartDefinition.Features.ExtrudeFeatures.Add(extrudeDef3);
        }

        /// <summary>
        /// Ступень 2
        /// </summary>
        private void BuildStem2()
        {
            PlanarSketch StemSketch2 = _inventorApi.MakeNewSketch(3, 
                ValParameters.GetParameter(ParameterType.LengthFirstLevel).Value);// второй параметр отодвигает по Z координате на заданную длину.
            _inventorApi.DrawCircle(ValParameters.GetParameter(ParameterType.RadiusSecondLevel).Value, StemSketch2, _curPoint);

            ExtrudeDefinition extrudeDef2 =
                _inventorApi.PartDefinition.
                Features.
                ExtrudeFeatures.
                CreateExtrudeDefinition(StemSketch2.Profiles.AddForSolid(), PartFeatureOperationEnum.kJoinOperation);
            extrudeDef2.SetDistanceExtent(ValParameters.GetParameter(ParameterType.LengthSecondLevel).Value, PartFeatureExtentDirectionEnum.kPositiveExtentDirection);
            ExtrudeFeature extrude2 = _inventorApi.PartDefinition.Features.ExtrudeFeatures.Add(extrudeDef2);
        }

        /// <summary>
        /// Ступень 1
        /// </summary>
        private void BuildStem1()
        {
            PlanarSketch StemSketch = _inventorApi.MakeNewSketch(3, 0); //[1 - ZY; 2 - ZX; 3 - XY]

            Point2d point = _inventorApi.TransientGeometry.CreatePoint2d(0, 0);   //построен эскиз 
            _inventorApi.DrawCircle(ValParameters.GetParameter(ParameterType.RadiusFirstLevel).Value, StemSketch, point);

            ExtrudeDefinition extrudeDef =
                _inventorApi.PartDefinition.
                Features.
                ExtrudeFeatures.
                CreateExtrudeDefinition(StemSketch.Profiles.AddForSolid(), PartFeatureOperationEnum.kJoinOperation);
            extrudeDef.SetDistanceExtent(ValParameters.GetParameter(ParameterType.LengthFirstLevel).Value,
                PartFeatureExtentDirectionEnum.kPositiveExtentDirection);
            ExtrudeFeature extrude = _inventorApi.PartDefinition.Features.ExtrudeFeatures.Add(extrudeDef);

        }
    }
}
