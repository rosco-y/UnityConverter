using System;
using System.Windows.Forms;

namespace UnityConverter
{
    public partial class frmMain : Form
    {
        float? _conversionFactor = null;
        float? _input = null;
        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
        }

        private void cmbInputUnits_SelectedIndexChanged(object sender, EventArgs e)
        {
            string sUnits = cmbInputUnits.Items[cmbInputUnits.SelectedIndex].ToString();

            switch (sUnits)
            {
                case "INCHES":
                    _conversionFactor = cConversionFactors.MetersToInches;
                    break;

                case "FEET":
                    _conversionFactor = cConversionFactors.MetersToFeet;
                    break;

                case "MILES":
                    _conversionFactor = cConversionFactors.MilesToMeters;
                    break;

                default:
                    _conversionFactor = null;
                    break;
            }
            SetResult();
        }

        private void txtFrom_TextChanged(object sender, EventArgs e)
        {
            float result;
            if (float.TryParse(txtFrom.Text.ToString(), out result))
                _input = result;
            else
                _input = null;

            SetResult();
        }

        void SetResult()
        {
            if (_input != null && _conversionFactor != null)
                txtUnityUnits.Text = (_input * _conversionFactor).ToString();
            else
                txtUnityUnits.Text = "";
        }

        private void cmdClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
