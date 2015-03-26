using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ValProject
{
    /// <summary>
    /// Контрол отображающий параметр  детали.
    /// </summary>
    public partial class ValParameterControl : UserControl
    {
        /// <summary>
        /// Параметр детали.(поле)
        /// </summary>
        private Parameter _parameter; 

        private bool _updateInfoStarted;

        /// <summary>
        /// Конструктор.
        /// </summary>
        public ValParameterControl()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Имя параметра
        /// </summary>
        public string ParameterName
        {
            get
            {
                return parameterNameLabel.Text;
            }

            set 
            {
                parameterNameLabel.Text = value;
            }
        }

        /// <summary>
        /// Описание параметра
        /// </summary>
        public string ParameterDescription
        {
            get
            {
                return parametrDescriptionLabel.Text;
            }

            set
            {
                parametrDescriptionLabel.Text = value;
            }
        }

        /// <summary>
        /// Установить параметр детали в ValControl.
        /// </summary>
        public void SetParameter(Parameter value)
        { 
            if (_parameter != null)
                _parameter.ParameterChanged -= OnParameterChanged;
            value.ParameterChanged += OnParameterChanged;
            _parameter = value;                                 //вызывается в UpdateInfo()

            UpdateInfo();
        }

        /// <summary>
        /// Обработчик событий при изменении параметра.
        /// </summary>
        private void OnParameterChanged(object o, EventArgs e)
        {
            UpdateInfo();
        }

        /// <summary>
        /// Обновить данные в соответсвии с параметром.
        /// </summary>
        private void UpdateInfo()
        {
            _updateInfoStarted = true;
            valueNumericUpDown.Minimum = Convert.ToDecimal(_parameter.MinValue);
            valueNumericUpDown.Maximum = Convert.ToDecimal(_parameter.MaxValue);
            valueNumericUpDown.Value = Convert.ToDecimal(_parameter.Value);

            minValueLabel.Text = valueNumericUpDown.Minimum.ToString();
            maxValueLabel.Text = valueNumericUpDown.Maximum.ToString();
            _updateInfoStarted = false;
        }

        /// <summary>
        /// Обработчик срабатывает при изменении параметра пользователем в форме.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void valueNumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            if (!_updateInfoStarted)
            {
                double value = Convert.ToDouble(valueNumericUpDown.Value);
                _parameter.Value = value;
            }
        }

    }
}
