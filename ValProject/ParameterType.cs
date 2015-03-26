using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ValProject
{
    /// <summary>
    /// Тип параметра.
    /// </summary>
    public enum ParameterType
    {
        /// <summary>
        /// Длина первой ступени.
        /// </summary>
        LengthFirstLevel,

        /// <summary>
        /// Длина второй ступени.
        /// </summary>
        LengthSecondLevel,

        /// <summary>
        /// Длина третьей ступени.
        /// </summary>
        LengthThirdLevel,

        /// <summary>
        /// Длина четвертой ступени.
        /// </summary>
        LengthFourthLevel,

        /// <summary>
        /// Длина пятой ступени.
        /// </summary>
        LengthFifthLevel,

        /// <summary>
        /// Длина шестой ступени.
        /// </summary>
        LengthSixthLevel,

        /// <summary>
        /// Длина седьмой ступени.
        /// </summary>
        LengthSeventhLevel,

        /// <summary>
        /// Число зубьев.
        /// </summary>
        NumTeeth,

        /// <summary>
        /// Радиус первой ступени.
        /// </summary>
        RadiusFirstLevel,

        /// <summary>
        /// Радиус второй ступени.
        /// </summary>
        RadiusSecondLevel,

        /// <summary>
        /// Радиус третьей ступени.
        /// </summary>
        RadiusThirdLevel,

        /// <summary>
        /// Радиус четвертой ступени.
        /// </summary>
        RadiusFourthLevel,

        /// <summary>
        /// Радиус  пятой ступени.
        /// </summary>
        RadiusFifthLevel,

        /// <summary>
        /// Радиус  шестой ступени.
        /// </summary>
        RadiusSixthLevel,

        /// <summary>
        /// Радиус  седьмой ступени.
        /// </summary>
        RadiusSeventhLevel,

        //new
        /// <summary>
        /// Номер ступени на которой будет строиться шестерня
        /// </summary>
        NumTeethLevelSetted,

    }
}
