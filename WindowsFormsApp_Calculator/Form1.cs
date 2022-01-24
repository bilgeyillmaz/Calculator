using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp_Calculator
{
  


    public partial class Form1 : Form
    {
        private char _operation;
        private bool _isWindowClear;
        private int _firstNumber;
        public Form1()
        {
            InitializeComponent();
        }

        private void number1_Click(object sender, EventArgs e)
        {
            if(_isWindowClear)
            {
                ekranLabel.Text = " ";
                _isWindowClear = false;
            }
            if(ekranLabel.Text == "0")
            {
                ekranLabel.Text = " ";
                ekranLabel.Text += "1";
            }
           
        }

        private void number2_Click(object sender, EventArgs e)
        {
            if (_isWindowClear)
            {
                ekranLabel.Text = " ";
                _isWindowClear = false;
            }
            if (ekranLabel.Text == "0")
            {
                ekranLabel.Text = " ";
                ekranLabel.Text += "2";
            }

        }

        private void number3_Click(object sender, EventArgs e)
        {
            if (_isWindowClear)
            {
                ekranLabel.Text = " ";
                _isWindowClear = false;
            }
            if (ekranLabel.Text == "0")
            {
                ekranLabel.Text = " ";
                ekranLabel.Text += "3";
            }
        }

        private void number4_Click(object sender, EventArgs e)
        {
            if (_isWindowClear)
            {
                ekranLabel.Text = " ";
                _isWindowClear = false;
            }
            if (ekranLabel.Text == "0")
            {
                ekranLabel.Text = " ";
                ekranLabel.Text += "4";
            }
        }

        private void number5_Click(object sender, EventArgs e)
        {
            if (_isWindowClear)
            {
                ekranLabel.Text = " ";
                _isWindowClear = false;
            }
            if (ekranLabel.Text == "0")
            {
                ekranLabel.Text = " ";
                ekranLabel.Text += "5";
            }
        }

        private void number6_Click(object sender, EventArgs e)
        {
            if (_isWindowClear)
            {
                ekranLabel.Text = " ";
                _isWindowClear = false;
            }
            if (ekranLabel.Text == "0")
            {
                ekranLabel.Text = " ";
                ekranLabel.Text += "6";
            }

        }

        private void number7_Click(object sender, EventArgs e)
        {
            if (_isWindowClear)
            {
                ekranLabel.Text = " ";
                _isWindowClear = false;
            }
            if (ekranLabel.Text == "0")
            {
                ekranLabel.Text = " ";
                ekranLabel.Text += "7";
            }
        }

        private void number8_Click(object sender, EventArgs e)
        {
            if (_isWindowClear)
            {
                ekranLabel.Text = " ";
                _isWindowClear = false;
            }
            if (ekranLabel.Text == "0")
            {
                ekranLabel.Text = " ";
                ekranLabel.Text += "8";
            }
        }

        private void number9_Click(object sender, EventArgs e)
        {
            if (_isWindowClear)
            {
                ekranLabel.Text = " ";
                _isWindowClear = false;
            }
            if (ekranLabel.Text == "0")
            {
                ekranLabel.Text = " ";
                ekranLabel.Text += "9";
            }
        }

        private void number0_Click(object sender, EventArgs e)
        {
            if (_isWindowClear)
            {
                ekranLabel.Text = " ";
                _isWindowClear = false;
            }
            if (ekranLabel.Text == "0")
            {
                ekranLabel.Text = " ";
                ekranLabel.Text += "0";
            }
        }

        private void buttonlus_Click(object sender, EventArgs e)
        {
            
            _operation = '+';
            _isWindowClear = true;
            _firstNumber = Convert.ToInt32(ekranLabel.Text);    


        }


        private void buttonequalto_Click(object sender, EventArgs e)
        {
            int _secondNumber = Convert.ToInt32(ekranLabel.Text);
            int _result;

            switch(_operation)
            {
                case '+':
                    _result = _firstNumber + _secondNumber;
                    break;
                case '-':
                    _result = _firstNumber - _secondNumber;
                    break;
                case 'x':
                    _result = _firstNumber * _secondNumber;
                    break;
                case '/':
                    _result = _firstNumber / _secondNumber;
                    break;
                default:
                    _result = 0;
                    break;

            }
            ekranLabel.Text = Convert.ToString(_result);

        }

        private void buttonminus_Click(object sender, EventArgs e)
        {
            _operation = '-';
            _isWindowClear = true;
            _firstNumber = Convert.ToInt32(ekranLabel.Text);
        }

        private void buttonmultiplication_Click(object sender, EventArgs e)
        {
            _operation = 'x';
            _isWindowClear = true;
            _firstNumber = Convert.ToInt32(ekranLabel.Text);
        }

        private void buttondivision_Click(object sender, EventArgs e)
        {
            _operation = '/';
            _isWindowClear = true;
            _firstNumber = Convert.ToInt32(ekranLabel.Text);
        }

        private void buttonclear_Click(object sender, EventArgs e)
        {
            ekranLabel.Text = "0";
        }
    }
}
