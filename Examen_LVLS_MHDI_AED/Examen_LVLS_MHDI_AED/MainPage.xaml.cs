using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Examen_LVLS_MHDI_AED
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void DecimalToBinaryClicked(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(inputEntry.Text) && int.TryParse(inputEntry.Text, out int decimalNumber))
            {
                resultLabel.Text = Convert.ToString(decimalNumber, 2);
            }
            else
            {
                resultLabel.Text = "Entrada inválida";
            }
        }

        private void DecimalToHexClicked(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(inputEntry.Text) && int.TryParse(inputEntry.Text, out int decimalNumber))
            {
                resultLabel.Text = Convert.ToString(decimalNumber, 16).ToUpper();
            }
            else
            {
                resultLabel.Text = "Entrada inválida";
            }
        }

        private void DecimalToOctalClicked(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(inputEntry.Text) && int.TryParse(inputEntry.Text, out int decimalNumber))
            {
                resultLabel.Text = Convert.ToString(decimalNumber, 8);
            }
            else
            {
                resultLabel.Text = "Entrada inválida";
            }
        }

        private void BinaryToDecimalClicked(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(inputEntry.Text))
            {
                resultLabel.Text = Convert.ToInt32(inputEntry.Text, 2).ToString();
            }
            else
            {
                resultLabel.Text = "Entrada inválida";
            }
        }

        private void BinaryToHexClicked(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(inputEntry.Text))
            {
                resultLabel.Text = Convert.ToString(Convert.ToInt32(inputEntry.Text, 2), 16).ToUpper();
            }
            else
            {
                resultLabel.Text = "Entrada inválida";
            }
        }

        private void BinaryToOctalClicked(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(inputEntry.Text))
            {
                resultLabel.Text = Convert.ToString(Convert.ToInt32(inputEntry.Text, 2), 8);
            }
            else
            {
                resultLabel.Text = "Entrada inválida";
            }
        }

        private void HexToDecimalClicked(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(inputEntry.Text))
            {
                resultLabel.Text = Convert.ToInt32(inputEntry.Text, 16).ToString();
            }
            else
            {
                resultLabel.Text = "Entrada inválida";
            }
        }

        private void HexToBinaryClicked(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(inputEntry.Text))
            {
                resultLabel.Text = Convert.ToString(Convert.ToInt32(inputEntry.Text, 16), 2);
            }
            else
            {
                resultLabel.Text = "Entrada inválida";
            }
        }

        private void HexToOctalClicked(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(inputEntry.Text))
            {
                resultLabel.Text = Convert.ToString(Convert.ToInt32(inputEntry.Text, 16), 8);
            }
            else
            {
                resultLabel.Text = "Entrada inválida";
            }
        }

        private void OctalToDecimalClicked(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(inputEntry.Text))
            {
                resultLabel.Text = Convert.ToInt32(inputEntry.Text, 8).ToString();
            }
            else
            {
                resultLabel.Text = "Entrada inválida";
            }
        }

        private void OctalToBinaryClicked(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(inputEntry.Text))
            {
                resultLabel.Text = Convert.ToString(Convert.ToInt32(inputEntry.Text, 8), 2);
            }
            else
            {
                resultLabel.Text = "Entrada inválida";
            }
        }

        private void OctalToHexClicked(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(inputEntry.Text))
            {
                resultLabel.Text = Convert.ToString(Convert.ToInt32(inputEntry.Text, 8), 16).ToUpper();
            }
            else
            {
                resultLabel.Text = "Entrada inválida";
            }
        }


    }
}
