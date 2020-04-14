using System;
using System.Linq;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public enum StateCalculator
        {
            state1,
            state2
        }
        public StateCalculator state = StateCalculator.state1;

        private float _bufer;
        private float _exp;
        private float _expNumber;

        private string _currentNumber;
        private string _stringProcent;


        private char _sign = '0';
        private char _oldSign = '0';

        private bool _secondClickOnSign = false;
        private bool _canClearMainFiled = false;

        private bool _isUsualOutput = true;
        private bool _calculationIsCompleted = false;

        private bool _wasEqual = false;
        private bool _wasSqrt = false;
        private bool _wasProcent = false;
        private bool _wasExp = false;

        private void buttonSign_Click(object sender, EventArgs e)
        {
            if ((sender as Button).Text == "^")
            {
                _wasExp = true;
            }

            try
            {
                _expNumber = float.Parse(mainField.Text);
            }
            catch
            {
                Console.WriteLine("Строка имела не верный формат.");
            }
            if (state == StateCalculator.state1)
            {
                try
                {
                    _bufer = float.Parse(mainField.Text);
                }
                catch
                {
                    Console.WriteLine("Строка имела неверный формат!");
                    return;
                }

                if (_wasSqrt)
                {
                    bufferField.Text += "√" + _currentNumber + (sender as Button).Text[0];
                    _wasSqrt = false;
                }
                else if (!_wasSqrt)
                {
                    bufferField.Text += mainField.Text + (sender as Button).Text[0];
                }

                mainField.Clear();
                _sign = GetSign(sender);
                _secondClickOnSign = true;
                state = StateCalculator.state2;
            }
            else if (state == StateCalculator.state2)
            {
                if (_secondClickOnSign)
                {
                    _sign = GetSign(sender);
                    ChangeSign(bufferField, bufferField.Text.Last());
                    _secondClickOnSign = false;
                }
                else
                {
                    _bufer = ChangeValueBuffer(_bufer, _sign);

                    mainField.Text = _bufer.ToString();
                    _canClearMainFiled = true;
                    _sign = GetSign(sender);

                    if (_wasProcent)
                    {
                        bufferField.Text += _stringProcent + (sender as Button).Text[0];
                        _wasProcent = false;
                        _stringProcent = "";
                        _isUsualOutput = false;
                    }


                    if (_wasSqrt)
                    {
                        bufferField.Text += "√" + _currentNumber + (sender as Button).Text[0];
                        _wasSqrt = false;
                        _isUsualOutput = false;
                    }


                    if (_isUsualOutput)
                    {
                        bufferField.Text += _currentNumber + (sender as Button).Text[0];
                    }
                    _isUsualOutput = true;
                    _calculationIsCompleted = true;
                }

                _secondClickOnSign = true;
            }
        }


        private void buttonInputDigits_Click(object sender, EventArgs e)
        {
            if((sender as Button).Text[0] == ',')
            {
                if(mainField.Text.Contains(',') || mainField.Text.Length == 0)
                {
                    return;
                }
            }
            if (_wasExp)
            {
                _exp = float.Parse((sender as Button).Text);
            }

            if (_wasEqual)
            {
                mainField.Clear();
                _wasEqual = false;
            }
            if (mainField.Text.Length > 8)
            {
                return;
            }
            if (_canClearMainFiled)
            {
                mainField.Clear();
                _canClearMainFiled = false;
            }
            _calculationIsCompleted = false;
            mainField.Text += (sender as Button).Text;

            _currentNumber = mainField.Text;
            _secondClickOnSign = false;
        }

        private float ChangeValueBuffer(float buffer, Char sign)
        {
            try
            {
                switch (sign)
                {
                    case '+':
                        if (_wasExp)
                        {
                            _oldSign = sign;
                            break;
                        }
                        buffer += float.Parse(mainField.Text);
                        break;
                    case '-':
                        if (_wasExp)
                        {
                            _oldSign = sign;
                            break;
                        }
                        buffer -= float.Parse(mainField.Text);
                        break;
                    case 'x':
                        if (_wasExp)
                        {
                            _oldSign = sign;
                            break;
                        }
                        buffer *= float.Parse(mainField.Text);
                        break;
                    case '/':
                        if (_wasExp)
                        {
                            _oldSign = sign;
                            break;
                        }
                        buffer /= float.Parse(mainField.Text);
                        break;
                    case '^':
                        _wasExp = false;
                        if (_oldSign == '0')
                        {
                            buffer = Exponent(_expNumber, _exp);
                        }
                        else if (buffer != 0)
                        {
                            switch (_oldSign)
                            {
                                case '+':
                                    buffer += Exponent(_expNumber, _exp);
                                    break;
                                case '-':
                                    buffer -= Exponent(_expNumber, _exp);
                                    break;
                                case '/':
                                    buffer /= Exponent(_expNumber, _exp);
                                    break;
                                case '*':
                                    buffer *= Exponent(_expNumber, _exp);
                                    break;
                                /*case 'P':
                                    mainField.Text = Math.PI.ToString();
                                    break;
                                case 'E':
                                    mainField.Text = Math.E.ToString();
                                    break;*/
                            }                        
                        }
                        break;
                }
            }
            catch
            {
                Console.WriteLine(mainField.Text);
            }
            return buffer;
        }

        

        private float Exponent(float number, float exp)
        {
            return (float)Math.Pow((float)number, (float)exp);
        }

        private void Restart()
        {
            bufferField.Clear();
            _secondClickOnSign = false;
            _canClearMainFiled = false;
            _currentNumber = null;
            state = StateCalculator.state1;
            _sign = '0';
            _oldSign = '0';
        }

        #region Взаимодействия со знаком
        private void ChangeSign(TextBox textBox, Char oldSign)
        {
            textBox.Text = textBox.Text.TrimEnd(oldSign);
            textBox.Text += _sign;
        }

        private Char GetSign(object sender)
        {
            return (sender as Button).Text[0];
        }
        #endregion


        #region Операции [=],[√],[C],[%],[E],[PI].
        private void Button_Sqrt(object sender, EventArgs e)
        {
            try
            {
                float tmp = float.Parse(mainField.Text);
                mainField.Text = Math.Sqrt((double)tmp).ToString();
                _wasSqrt = true;
            }
            catch
            {
                Console.WriteLine("Строка имела неверный формат!");
            }

        }

        private void button_Equal(object sender, EventArgs e)
        {
            if (_calculationIsCompleted)
            {
                _bufer = 0;
                _wasSqrt = false;
                _wasEqual = true;
                Restart();
            }
            else
            {
                _wasSqrt = false;
                _wasEqual = true;
                _bufer = ChangeValueBuffer(_bufer, _sign);
                mainField.Text = _bufer.ToString();
                Restart();
                _calculationIsCompleted = false;
            }
        }

        private void Button_Clear(object sender, EventArgs e)
        {
            _wasSqrt = false;
            mainField.Clear();
            _bufer = 0;
            Restart();
        }


        private void E(object sender, EventArgs e)
        {
            float tmp = (float)Math.Round(Math.E, 5);
            mainField.Text = tmp.ToString();
        }

        private void PI(object sender, EventArgs e)
        {
            float tmp = (float)Math.Round(Math.PI, 5);
            mainField.Text = tmp.ToString();
        }

        private void Button_Procent(object sender, EventArgs e)
        {
            try
            {
                float tmp = float.Parse(mainField.Text);

                float result = _bufer * (tmp / 100);

                mainField.Text = result.ToString();
                _canClearMainFiled = true;
                             _stringProcent = result.ToString();
                _wasProcent = true;
            }
            catch
            {
                Console.WriteLine("Строка имела неверный формат!");
            }
        }
        #endregion
    }
}
