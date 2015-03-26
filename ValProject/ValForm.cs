using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ValProject
{
    public partial class ValForm : Form
    {
        private Val _val;

        public ValForm()
        {
            InitializeComponent();
            _val = new Val(new ValParameters(), new InventorApi());

            firstLValParameterControl.SetParameter(
                _val.ValParameters.GetParameter(ParameterType.LengthFirstLevel));

            secondLvalParameterControl.SetParameter(
                _val.ValParameters.GetParameter(ParameterType.LengthSecondLevel));

            thirdLvalParameterControl.SetParameter(
                _val.ValParameters.GetParameter(ParameterType.LengthThirdLevel));

            fourthLValParameterControl.SetParameter(
                _val.ValParameters.GetParameter(ParameterType.LengthFourthLevel));

            fifthLValParameterControl.SetParameter(
                _val.ValParameters.GetParameter(ParameterType.LengthFifthLevel));

            sixthLValParameterControl.SetParameter(
                _val.ValParameters.GetParameter(ParameterType.LengthSixthLevel));//

            seventhLValParameterControl.SetParameter(
                _val.ValParameters.GetParameter(ParameterType.LengthSeventhLevel));//

            /////////////

            firstRValParameterControl.SetParameter(
                _val.ValParameters.GetParameter(ParameterType.RadiusFirstLevel));

            secondRValParameterControl.SetParameter(
                _val.ValParameters.GetParameter(ParameterType.RadiusSecondLevel));

            thirdRValParameterControl.SetParameter(
                _val.ValParameters.GetParameter(ParameterType.RadiusThirdLevel));

            fourthRValParameterControl.SetParameter(
                _val.ValParameters.GetParameter(ParameterType.RadiusFourthLevel));

            fifthRValParameterControl.SetParameter(
                _val.ValParameters.GetParameter(ParameterType.RadiusFifthLevel));

            sixthRValParameterControl.SetParameter(
                _val.ValParameters.GetParameter(ParameterType.RadiusSixthLevel));//

            seventhRValParameterControl.SetParameter(
                _val.ValParameters.GetParameter(ParameterType.RadiusSeventhLevel));//

            numTeethValParameterControl.SetParameter(
                _val.ValParameters.GetParameter(ParameterType.NumTeeth));
            ///
            numLevelValParameterControl.SetParameter(
                _val.ValParameters.GetParameter(ParameterType.NumTeethLevelSetted));
        }
    
        private void buildButton_Click(object sender, EventArgs e)
        {
             _val.Build();
        }

    }
}
