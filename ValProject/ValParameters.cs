using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ValProject
{
    /// <summary>
    /// Параметры вала.
    /// </summary>
    public class ValParameters
    {
        /// <summary>
        /// Ассоциативный массив, отображающий тип параметра на значение параметра.
        /// </summary>
        private readonly Dictionary<ParameterType, Parameter> _parameters = new Dictionary<ParameterType,Parameter>();

        private bool _validationStarted;

        /// <summary>
        /// Конструктор.
        /// </summary>
        public ValParameters()
        { 
            _parameters[ParameterType.LengthFirstLevel] = new Parameter(10, 10, 100);//1..100
            _parameters[ParameterType.LengthSecondLevel] = new Parameter(7, 7, 100);
            _parameters[ParameterType.LengthThirdLevel] = new Parameter(17, 17, 100);
            _parameters[ParameterType.LengthFourthLevel] = new Parameter(7, 7, 100);
            _parameters[ParameterType.LengthFifthLevel] = new Parameter(10, 10, 100);
            _parameters[ParameterType.LengthSixthLevel] = new Parameter(10, 10, 100);//
            _parameters[ParameterType.LengthSeventhLevel] = new Parameter(14, 14, 100);//

            _parameters[ParameterType.RadiusFirstLevel] = new Parameter(10, 10, 100);//100
            _parameters[ParameterType.RadiusSecondLevel] = new Parameter(12, 11, 100);//100
            _parameters[ParameterType.RadiusThirdLevel] = new Parameter(16, 13, 100);//100
            _parameters[ParameterType.RadiusFourthLevel] = new Parameter(12, 10, 15);
            _parameters[ParameterType.RadiusFifthLevel] = new Parameter(9, 5, 11);
            _parameters[ParameterType.RadiusSixthLevel] = new Parameter(7, 5, 8);//
            _parameters[ParameterType.RadiusSeventhLevel] = new Parameter(5, 1, 6);//

            _parameters[ParameterType.NumTeeth] = new Parameter(10, 5, 15);
            
            _parameters[ParameterType.NumTeethLevelSetted] = new Parameter(3,1,7);

            // Для каждого параметра.
            foreach (Parameter p in _parameters.Values)
            {
                // Подключаем обработчик OnParameterChanged к событию ParameterChanged. 
                p.ParameterChanged += OnParameterChanged; 
            }
        }

        /// <summary>
        /// Получить значение параметра по типу параметра.
        /// </summary>
        /// <param name="type">Тип параметра.</param>
        /// <returns>Значение параметра.</returns>
        public Parameter GetParameter(ParameterType type)
        {
            return _parameters[type];
        }
 
        /// <summary>
        /// Валидация параметров. Привидение параметра к допустимому значению.
        /// </summary>
        private void Validate()
        {
            if (_validationStarted)
                return;
            _validationStarted = true;
            

           // if (_parameters[ParameterType.RadiusSecondLevel].MinValue <= _parameters[ParameterType.RadiusFirstLevel].Value)
                _parameters[ParameterType.RadiusSecondLevel].MinValue = _parameters[ParameterType.RadiusFirstLevel].Value + 1;

          //  if (_parameters[ParameterType.RadiusThirdLevel].MinValue <= _parameters[ParameterType.RadiusSecondLevel].Value)
                _parameters[ParameterType.RadiusThirdLevel].MinValue = _parameters[ParameterType.RadiusSecondLevel].Value + 1;

          //  if (_parameters[ParameterType.RadiusFourthLevel].MaxValue >= _parameters[ParameterType.RadiusThirdLevel].Value)
                _parameters[ParameterType.RadiusFourthLevel].MaxValue = _parameters[ParameterType.RadiusThirdLevel].Value - 1;

          //  if (_parameters[ParameterType.RadiusFifthLevel].MaxValue >= _parameters[ParameterType.RadiusFourthLevel].Value)
                _parameters[ParameterType.RadiusFifthLevel].MaxValue = _parameters[ParameterType.RadiusFourthLevel].Value - 1;

                //  if (_parameters[ParameterType.RadiusFifthLevel].MaxValue >= _parameters[ParameterType.RadiusFourthLevel].Value)
                _parameters[ParameterType.RadiusSixthLevel].MaxValue = _parameters[ParameterType.RadiusFifthLevel].Value - 1;

                //  if (_parameters[ParameterType.RadiusFifthLevel].MaxValue >= _parameters[ParameterType.RadiusFourthLevel].Value)
                _parameters[ParameterType.RadiusSeventhLevel].MaxValue = _parameters[ParameterType.RadiusSixthLevel].Value - 1;

               // _parameters[ParameterType.RadiusFourthLevel].MinValue = 7;
              //  _parameters[ParameterType.RadiusFifthLevel].MinValue = 5;
              //  _parameters[ParameterType.RadiusSixthLevel].MinValue = 3;
               // _parameters[ParameterType.RadiusSeventhLevel].MinValue = 1;

                _validationStarted = false;
        }

        /// <summary>
        /// Обработчик события ParameterChanged параметра.
        /// </summary>
        private void OnParameterChanged(object o, EventArgs e) 
        {
            Validate();
        }
    }
}
