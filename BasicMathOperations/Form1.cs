﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BasicMathOperations
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {

            double number1, number2, sum;
            /* Version 1 (Runtime Error)
           number1 = Convert.ToDouble(txtNumber1.Text);
           number2 = Convert.ToDouble(txtNumber2.Text);
           sum = number1 + number2;
           lblResult.Text = Convert.ToString(sum);
           lblResultType.Text = "Summe";
           */

            /* Version 2 (Wert wird 0 gesetzt)
            double.TryParse(txtNumber1.Text, out number1);
            double.TryParse(txtNumber2.Text, out number2);
            sum = number1 + number2;
            lblResult.Text = Convert.ToString(sum);
            lblResultType.Text = "Summe";
            */

            try
            {
                number1 = Convert.ToDouble(txtNumber1.Text);
                number2 = Convert.ToDouble(txtNumber2.Text);
                sum = number1 + number2;
                lblResult.Text = Convert.ToString(sum);
                lblResultType.Text = "Summe";
            }
            catch (Exception ex)
            {
                lblResultType.Text = "Fehler";
                lblResult.Text = "Kein numerischer Wert";

                MessageBox.Show(ex.Message, "Eingabefehler", MessageBoxButtons.OK, MessageBoxIcon.Error);

                txtNumber1.Focus();
                txtNumber1.SelectAll();
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtNumber1.Text = "0";
            txtNumber2.Text = "0";
            lblResultType.Text = "Ergebnis";
            lblResult.Text = "";
            txtNumber1.Focus();
            txtNumber1.SelectAll();
        }

        private void btnSubtract_Click(object sender, EventArgs e)
        {
            double number1, number2, difference;
            try
            {
                number1 = Convert.ToDouble(txtNumber1.Text);
                number2 = Convert.ToDouble(txtNumber2.Text);
                difference = number1 - number2;
                lblResult.Text = Convert.ToString(difference);
                lblResultType.Text = "Differenz";
            }
            catch (Exception ex)
            {
                lblResultType.Text = "Fehler";
                lblResult.Text = "Kein numerischer Wert";

                MessageBox.Show(ex.Message, "Eingabefehler", MessageBoxButtons.OK, MessageBoxIcon.Error);

                txtNumber1.Focus();
                txtNumber1.SelectAll();
            }
        }

        private void btnMultiplication_Click(object sender, EventArgs e)
        {
            double number1, number2, product;
            try
            {
                number1 = Convert.ToDouble(txtNumber1.Text);
                number2 = Convert.ToDouble(txtNumber2.Text);
                product = number1 * number2;
                lblResult.Text = Convert.ToString(product);
                lblResultType.Text = "Produkt";
            }
            catch (Exception ex)
            {
                lblResultType.Text = "Fehler";
                lblResult.Text = "Kein numerischer Wert";

                MessageBox.Show(ex.Message, "Eingabefehler", MessageBoxButtons.OK, MessageBoxIcon.Error);

                txtNumber1.Focus();
                txtNumber1.SelectAll();
            }
        }

        private void btnDivision_Click(object sender, EventArgs e)
        {
            double number1, number2 = 0, quotient;
            try
            {
                number1 = Convert.ToDouble(txtNumber1.Text);
                number2 = Convert.ToDouble(txtNumber2.Text);
                quotient = number1 / number2;
                lblResult.Text = Convert.ToString(quotient);
                lblResultType.Text = "Quotient";
            }
            catch (Exception ex)
            {
                lblResultType.Text = "Fehler";
                lblResult.Text = "Kein numerischer Wert!";
                MessageBox.Show(ex.Message, "Eingabefehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtNumber1.Focus();
                txtNumber1.SelectAll();
            }

        }

        private void btnPower_Click(object sender, EventArgs e)
        {
            double number1, number2, result;
            try
            {
                number1 = Convert.ToDouble(txtNumber1.Text);
                number2 = Convert.ToDouble(txtNumber2.Text);
                result = Math.Pow(number1, number2);
                lblResult.Text = Convert.ToString(result);
                lblResultType.Text = "Ergebnis";
            }
            catch (Exception ex)
            {
                lblResultType.Text = "Fehler";
                lblResult.Text = "Kein numerischer Wert!";
                MessageBox.Show(ex.Message, "Eingabefehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtNumber1.Focus();
                txtNumber1.SelectAll();
            }
        }

        private void btnRoot_Click(object sender, EventArgs e)
        {
            double number1, number2, result;
            try
            {
                number1 = Convert.ToDouble(txtNumber1.Text);
                number2 = Convert.ToDouble(txtNumber2.Text);
                result = Math.Pow(number1, 1 / number2);
                lblResult.Text = Convert.ToString(result);
                lblResultType.Text = "Ergebnis";
            }
            catch (Exception ex)
            {
                lblResultType.Text = "Fehler";
                lblResult.Text = "Kein numerischer Wert!";
                MessageBox.Show(ex.Message, "Eingabefehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtNumber1.Focus();
                txtNumber1.SelectAll();
            }
        }

        private void btnLN_Click(object sender, EventArgs e)
        {
            double number1, result;
            try
            {
                number1 = Convert.ToDouble(txtNumber1.Text);
                result = Math.Log(number1);
                lblResult.Text = Convert.ToString(result);
                lblResultType.Text = "Ergebnis";
            }
            catch (Exception ex)
            {
                lblResultType.Text = "Fehler";
                lblResult.Text = "Kein numerischer Wert!";
                MessageBox.Show(ex.Message, "Eingabefehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtNumber1.Focus();
                txtNumber1.SelectAll();
            }
        }

        private void btnLG_Click(object sender, EventArgs e)
        {

            double number1, result;
            try
            {
                number1 = Convert.ToDouble(txtNumber1.Text);
                result = Math.Log10(number1);
                lblResult.Text = Convert.ToString(result);
                lblResultType.Text = "Ergebnis";
            }
            catch (Exception ex)
            {
                lblResultType.Text = "Fehler";
                lblResult.Text = "Kein numerischer Wert!";
                MessageBox.Show(ex.Message, "Eingabefehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtNumber1.Focus();
                txtNumber1.SelectAll();
            }
        }
    }
}
