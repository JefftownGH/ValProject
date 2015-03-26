using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace ValProject.Tests
{
    /// <summary>
    /// Тест класса Параметров Вала.
    /// </summary>
    [TestFixture]
    public class TestValParameters
    {
        ///// <summary>
        ///// Тестирование валидного, минимального и максимального значений параметра числа зубьев класса ValParameters.
        ///// </summary>
        //[TestCase(5, 5)]
        //[TestCase(4, 5)]
        //[TestCase(17, 15)]
        //public void NumTeethTest(double newValue, double expectedValue)
        //{
        //    Val _vp = new Val(new ValParameters(), new InventorApi());
        //    _vp.ValParameters.GetParameter(ParameterType.NumTeeth).Value = newValue;

        //    Assert.AreEqual(expectedValue, _vp.ValParameters.GetParameter(ParameterType.NumTeeth).Value);
        //}
        
        /// <summary>
        /// Тестирование валидного, минимального и максимального значений параметров радиусов ступеней класса ValParameters.
        /// </summary>
        [TestCase(50, 50, ParameterType.RadiusFirstLevel)]//1
        [TestCase(-1, 10, ParameterType.RadiusFirstLevel)]
        [TestCase(126, 100, ParameterType.RadiusFirstLevel)]
        [TestCase(50, 50, ParameterType.RadiusSecondLevel)]//2
        [TestCase(5, 11, ParameterType.RadiusSecondLevel)]
        [TestCase(126, 100, ParameterType.RadiusSecondLevel)]
        [TestCase(50, 50, ParameterType.RadiusThirdLevel)]//3
        [TestCase(-1, 13, ParameterType.RadiusThirdLevel)]
        [TestCase(126, 100, ParameterType.RadiusThirdLevel)]
        [TestCase(12, 12, ParameterType.RadiusFourthLevel)]//4
        [TestCase(-1, 10, ParameterType.RadiusFourthLevel)]
        [TestCase(126, 15, ParameterType.RadiusFourthLevel)]
        [TestCase(7, 7, ParameterType.RadiusFifthLevel)]//5
        [TestCase(-1, 5, ParameterType.RadiusFifthLevel)]
        [TestCase(126, 11, ParameterType.RadiusFifthLevel)]
        [TestCase(7, 7, ParameterType.RadiusSixthLevel)]//6
        [TestCase(-1, 5, ParameterType.RadiusSixthLevel)]
        [TestCase(126, 8, ParameterType.RadiusSixthLevel)]
        [TestCase(2, 2, ParameterType.RadiusSeventhLevel)]//7
        [TestCase(-1, 1, ParameterType.RadiusSeventhLevel)]
        [TestCase(8, 6, ParameterType.RadiusSeventhLevel)]

        /// <summary>
        /// Тестирование валидного, минимального и максимального значений параметров длинн ступеней класса ValParameters.
        /// </summary>
        [TestCase(50, 50, ParameterType.LengthFirstLevel)]//1
        [TestCase(-1, 10, ParameterType.LengthFirstLevel)]
        [TestCase(126, 100, ParameterType.LengthFirstLevel)]
        [TestCase(50, 50, ParameterType.LengthSecondLevel)]//2
        [TestCase(-1, 7, ParameterType.LengthSecondLevel)]
        [TestCase(126, 100, ParameterType.LengthSecondLevel)]
        [TestCase(50, 50, ParameterType.LengthThirdLevel)]//3
        [TestCase(-1, 17, ParameterType.LengthThirdLevel)]
        [TestCase(126, 100, ParameterType.LengthThirdLevel)]
        [TestCase(50, 50, ParameterType.LengthFourthLevel)]//4
        [TestCase(-1, 7, ParameterType.LengthFourthLevel)]
        [TestCase(126, 100, ParameterType.LengthFourthLevel)]
        [TestCase(50, 50, ParameterType.LengthFifthLevel)]//5
        [TestCase(-1, 10, ParameterType.LengthFifthLevel)]
        [TestCase(126, 100, ParameterType.LengthFifthLevel)]
        [TestCase(50, 50, ParameterType.LengthSixthLevel)]//6
        [TestCase(-1, 10, ParameterType.LengthSixthLevel)]
        [TestCase(126, 100, ParameterType.LengthSixthLevel)]
        [TestCase(50, 50, ParameterType.LengthSeventhLevel)]//7
        [TestCase(-1, 14, ParameterType.LengthSeventhLevel)]
        [TestCase(126, 100, ParameterType.LengthSeventhLevel)]
        /// <summary>
        /// Тестирование валидного, минимального и максимального значений параметров числа зубьев класса ValParameters.
        /// </summary>
        [TestCase(5, 5, ParameterType.NumTeeth)]
        [TestCase(4, 5, ParameterType.NumTeeth)]
        [TestCase(17, 15, ParameterType.NumTeeth)]
        public void ValParameterTest(double newValue, double expectedValue, ParameterType parameterType)
        {
            Val _vp = new Val(new ValParameters(), new InventorApi());
            _vp.ValParameters.GetParameter(parameterType).Value = newValue;

            Assert.AreEqual(expectedValue, _vp.ValParameters.GetParameter(parameterType).Value);
        }
        


        /// <summary>
        /// Тестирование валидации параметров радиусов с минимальной границей.
        /// </summary>
        [TestCase(15, ParameterType.RadiusSecondLevel, ParameterType.RadiusFirstLevel)]
        [TestCase(15, ParameterType.RadiusThirdLevel, ParameterType.RadiusSecondLevel)]
       
        public void ValidateRadiusTestMin(double newValue, ParameterType parameterType1, ParameterType parameterType2 )
        {
            //double newValue = 15;
            Val _vp = new Val(new ValParameters(), new InventorApi());
            _vp.ValParameters.GetParameter(parameterType1).MinValue = newValue;
            
            Assert.AreEqual(_vp.ValParameters.GetParameter(parameterType1).MinValue,
                _vp.ValParameters.GetParameter(parameterType2).Value + 1);
        }

        /// <summary>
        /// Тестирование валидации параметров радиусов с максимальной границей.
        /// </summary>
        [TestCase(15, ParameterType.RadiusFourthLevel, ParameterType.RadiusThirdLevel)]
        [TestCase(15, ParameterType.RadiusFifthLevel, ParameterType.RadiusFourthLevel)]
        [TestCase(15, ParameterType.RadiusSixthLevel, ParameterType.RadiusFifthLevel)]
        [TestCase(15, ParameterType.RadiusSeventhLevel, ParameterType.RadiusSixthLevel)]
        public void ValidateRadiusTestMax(double newValue, ParameterType parameterType1, ParameterType parameterType2)
        {
            Val _vp = new Val(new ValParameters(), new InventorApi());
            _vp.ValParameters.GetParameter(parameterType1).MaxValue = newValue;

            Assert.AreEqual(_vp.ValParameters.GetParameter(parameterType1).MaxValue,
                _vp.ValParameters.GetParameter(parameterType2).Value - 1);
        }        
    }
}
