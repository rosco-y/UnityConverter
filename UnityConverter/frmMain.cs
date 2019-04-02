using System;
using System.Windows.Forms;

namespace UnityConverter
{
    public partial class frmMain : Form
    {
        float? _conversionFactor = null;
        float? _input = null;
        bool _fEnglishToUnity = true;
        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            rdioInches.Checked = true;
            _conversionFactor = cConversionFactors.MetersToInches;
            operation = eOperator.eNone;

        }

        //private void cmbInputUnits_SelectedIndexChanged(object sender, EventArgs e)
        //{
        //    string sUnits = cmbInputUnits.Items[cmbInputUnits.SelectedIndex].ToString();

        //    switch (sUnits)
        //    {
        //        case "INCHES":
        //            _conversionFactor = cConversionFactors.MetersToInches;
        //            break;

        //        case "FEET":
        //            _conversionFactor = cConversionFactors.MetersToFeet;
        //            break;

        //        case "MILES":
        //            _conversionFactor = cConversionFactors.MilesToMeters;
        //            break;

        //        default:
        //            _conversionFactor = null;
        //            break;
        //    }
        //    SetResult();
        //}

        private void txtFrom_TextChanged(object sender, EventArgs e)
        {
            float result;
            if (float.TryParse(txtFrom.Text.ToString(), out result))
            {
                _input = result;
            }
            else
            {
                _input = null;
            }

            SetResult();
        }

        void SetResult()
        {
            if (_input != null && _conversionFactor != null)
            {
                txtUnityUnits.Text = (_input * _conversionFactor).ToString();
            }
            else
            {
                txtUnityUnits.Text = "";
            }
        }



        private void rdioInches_CheckedChanged(object sender, EventArgs e)
        {
            setConversionFactor();
        }

        private void rdioFeet_CheckedChanged(object sender, EventArgs e)
        {
            setConversionFactor();
        }

        private void rdioMiles_CheckedChanged(object sender, EventArgs e)
        {
            setConversionFactor();
        }

        void setConversionFactor()
        {

            if (rdioInches.Checked)
            {
                _conversionFactor = cConversionFactors.MetersToInches;
            }
            else
            {
                if (rdioFeet.Checked)
                {
                    _conversionFactor = cConversionFactors.MetersToFeet;
                }
                else // rdioMiles must be checked
                {
                    _conversionFactor = cConversionFactors.MilesToMeters;
                }
            }
            if (!_fEnglishToUnity)
            {
                _conversionFactor = 1f / _conversionFactor;
            }

            SetResult();
        }

        private void chkFromEnglishtoUnity_CheckedChanged(object sender, EventArgs e)
        {
            _fEnglishToUnity = chkFromEnglishtoUnity.Checked;
            setConversionFactor();
        }

        private void cmdCopyValueToSummationList_Click(object sender, EventArgs e)
        {
            float value;
            if (float.TryParse(txtUnityUnits.Text, out value))
            {
                lstSummation.Items.Add(value);
            }
            getSummationTotal();
        }

        void getSummationTotal()
        {
            float sum = 0f;
            foreach (object item in lstSummation.Items)
            {
                sum += float.Parse(item.ToString());
            }
            txtTotal.Text = sum.ToString();
        }

        private void cmdRemoveSelectedItem_Click(object sender, EventArgs e)
        {
            if (lstSummation.Items.Count > 0)
            {
                // check if an item is selected
                if (lstSummation.SelectedIndex > -1)
                {
                    lstSummation.Items.RemoveAt(lstSummation.SelectedIndex);
                }
                getSummationTotal();
            }
        }

        #region CALCULATOR
        enum eOperator
        {
            eNone,
            eAddition,
            dSubtraction,
            eMultiplication,
            eDivision,
        };

        enum eStates
        {
            eNone,
            eOperater1,
            eOperater2,
            eEquals
        }
        eOperator operation;
        eStates state = eStates.eOperater1;
        float op1, op2, result = 0f;

        private void cmdCopyUnityValue_Click(object sender, EventArgs e)
        {
            if (txtUnityUnits.Text.Length > 0)
            {
                System.Windows.Forms.Clipboard.SetText(txtUnityUnits.Text);
            }
        }

        private void cmdCopyListTotal_Click(object sender, EventArgs e)
        {
            if (txtTotal.Text.Length > 0)
            {
                System.Windows.Forms.Clipboard.SetText(txtTotal.Text);
            }
        }

        private void cmdClearAdditionList_Click(object sender, EventArgs e)
        {
            lstSummation.Items.Clear();
            getSummationTotal();
        }

        private void btnNumber_Click(object sender, EventArgs e)
        {
            if (txtCalulatorResult.Text == "0")
            {
                txtCalulatorResult.Text = "";
            }

            txtCalulatorResult.Text += (sender as Button).Text;
        }

        private void cmdCopyValueToCalculator_Click(object sender, EventArgs e)
        {
            txtCalulatorResult.Text = txtUnityUnits.Text;
        }

        
        string sOperator()
        {
            string ret = "";
            switch (operation)
            {
                case eOperator.dSubtraction:
                    ret = "-";
                    break;
                case eOperator.eAddition:
                    ret = "+";
                    break;
                case eOperator.eDivision:
                    ret = "/";
                    break;
                case eOperator.eMultiplication:
                    ret = "*";
                    break;
                default:
                    break;
            }
            return ret;
        }
        bool SetOperator(eOperator e)
        {
            bool success = false;
            if (state == eStates.eOperater1)
            {
                success = float.TryParse(txtCalulatorResult.Text, out op1);
                if (success)
                {
                    operation = e;
                    lstCalulatorWorkPad.Items.Add(txtCalulatorResult.Text);
                    state = eStates.eOperater2;
                }
            }
            else
            {
                if (state == eStates.eOperater2)
                {
                    success = float.TryParse(txtCalulatorResult.Text, out op2);
                    if (success)
                    {
                        operation = e;
                        lstCalulatorWorkPad.Items.Add(txtCalulatorResult.Text);
                        state = eStates.eOperater2;
                    }
                }
            }
            if (success)
            {
                // INDICATE OPERATION IN WORKPAD.
                lstCalulatorWorkPad.Items.Add(sOperator());
            }
            return success;
        }

        private void cmdDivide_Click(object sender, EventArgs e)
        {
            if (SetOperator(eOperator.eDivision))
            {
                //lstCalulatorWorkPad.Items.Add(txtCalulatorResult.Text);
                txtCalulatorResult.Text = "";
            }
        }

        private void cmdMultiply_Click(object sender, EventArgs e)
        {
            if (SetOperator(eOperator.eMultiplication))
            {
                //lstCalulatorWorkPad.Items.Add(txtCalulatorResult.Text);
                txtCalulatorResult.Text = "";
            }
        }


        private void cmdSubtract_Click(object sender, EventArgs e)
        {
            if (SetOperator(eOperator.dSubtraction))
            {
                //lstCalulatorWorkPad.Items.Add(txtCalulatorResult.Text);
                txtCalulatorResult.Text = "";
            }
        }

        private void cmcClearCalculator_Click(object sender, EventArgs e)
        {
            lstCalulatorWorkPad.Items.Clear();
            txtCalulatorResult.Text = "";
            op1 = op2 = result = 0f;
        }

        private void cmdAddition_Click(object sender, EventArgs e)
        {

            if (SetOperator(eOperator.eAddition))
            {
                //lstCalulatorWorkPad.Items.Add(txtCalulatorResult.Text);
                txtCalulatorResult.Text = "";
            }
        }

        private void cmdEquals_Click(object sender, EventArgs e)
        {
            if (txtCalulatorResult.Text.Length > 0)
            {
                if (state == eStates.eOperater2)    
                {
                    if (float.TryParse(txtCalulatorResult.Text, out op2))
                    {
                        if (op1 != 0f && op2 != 0f)
                        {
                            switch (operation)
                            {
                                case eOperator.dSubtraction:
                                    result = op1 - op2;
                                    break;
                                case eOperator.eAddition:
                                    result = op1 + op2;
                                    break;
                                case eOperator.eDivision:
                                    if (op2 != 0)
                                    {
                                        result = op1 / op2;
                                    }
                                    else
                                    {
                                        txtCalulatorResult.Text = "DIV BY 0.";
                                    }
                                    break;
                                case eOperator.eMultiplication:
                                    result = op1 * op2;
                                    break;
                                default:
                                    break;
                            } // switch
                        }

                        if (result != 0)
                        {
                            txtCalulatorResult.Text = result.ToString();
                            
                            op1 = result; // for continued calculations
                            op2 = result = 0f;
                            state = eStates.eOperater2;

                            lstSummation.Items.Add(txtCalulatorResult.Text);
                            getSummationTotal();
                        }
                    } // valid op1 and op2
                }
            }
        }
        #endregion
    }
}

