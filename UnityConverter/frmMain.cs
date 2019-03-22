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

        private void cmdCopyUnityValue_Click(object sender, EventArgs e)
        {
            if (txtUnityUnits.Text.Length > 0)
                System.Windows.Forms.Clipboard.SetText(txtUnityUnits.Text);
        }

        private void cmdCopyListTotal_Click(object sender, EventArgs e)
        {
            if (txtTotal.Text.Length > 0)
                System.Windows.Forms.Clipboard.SetText(txtTotal.Text);
        }

        private void cmdClearAdditionList_Click(object sender, EventArgs e)
        {
            lstSummation.Items.Clear();
            getSummationTotal();
        }
    }
}
