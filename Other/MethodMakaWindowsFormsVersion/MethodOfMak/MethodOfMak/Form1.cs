using System.Drawing;
using System.Windows.Forms;

namespace MethodOfMak
{
    public partial class Form1 : Form
    {
        private Label[,] startB = new Label[4,4];
        private Label[,] B = new Label[4, 4];  
        private Label[] tempR = new Label[4];
        private Label[] tempL = new Label[4];
        private string[] copyTempL = new string[4];
        private Label candidate;

        public Form1()
        {
            InitializeComponent();
            InitializeTable();
            SelectMinimumElements();
        }

        private void button1_Click(object sender, System.EventArgs e)
        {
            Start();
        }

        private void Start()
        {
            if (IsProblemSolved() == false)
            {
                TransferColumnWithGreatestNumberSelectedElementsToA();          
                WriteSelectedElementsFromAToTempR();
                WriteMinimumElementsFromBToTempL();
                StoreTempLValues();
                SubtructTempRFromTempL();
                FindCandidate();
                if (GetNumberElementsInColumnWithCandidate() == 0)
                {
                    AddNumberToA(FindMinimumNumberLeftOfTable());               
                    DeselectOldCandidate();
                    SelectNewCandidate();
                    RemoveElementsFromA();
                }
                else
                {
                    TransferColumnWithCandidateToA();
                }
            }
            else
            {
                CalculateResult();
            }
            Reset();
        }

        private void SelectMinimumElements()
        {
            int number;
            for (int i = 0; i < B.GetLength(0); i++)
            {
                number = int.Parse(B[0, i].Text);           
                for (int j = 0; j < B.GetLength(1); j++)
                {
                    if (number > int.Parse(B[j, i].Text))
                    {
                        number = int.Parse(B[j, i].Text);
                    }
                }
                for (int k = 0; k < B.GetLength(0); k++)
                {
                    if (int.Parse(B[k, i].Text) == number)
                    {
                        B[k, i].BackColor = Color.DarkGray;
                    }
                }
            }
        }

        private void TransferColumnWithGreatestNumberSelectedElementsToA()
        {
            int[] numberSelectedElements = new int[4];
            //Считаем, сколько выделенных элементов в каждом столбце
            for (int i = 0; i < B.GetLength(0); i++)
            {
                for (int j = 0; j < B.GetLength(1); j++)
                {
                    if (B[i, j].BackColor == Color.DarkGray)
                    {
                        numberSelectedElements[i] += 1;
                    }
                }
            }       
            //Запоминаем номер столбца с наибольшим количеством выделенных элементов
            int max = numberSelectedElements[0];
            int numberColumn = 0;
            for (int i = 0; i < numberSelectedElements.Length; i++)
            {
                if (max < numberSelectedElements[i])
                {
                    max = numberSelectedElements[i];
                    numberColumn = i;
                }
            }       
            //Меняем цвета в столбце
            for (int i = 0; i < B.GetLength(0); i++)
            {
                if (numberSelectedElements[numberColumn] != 1)
                {
                    if (B[numberColumn, i].BackColor == Color.DarkGray)
                    {
                        B[numberColumn, i].BackColor = Color.Brown;
                    }
                    else
                    {
                        B[numberColumn, i].BackColor = Color.Pink;
                    }
                }
            }
        }

        private bool IsProblemSolved()
        {
            int numberSelectedElements = 0;
            for (int i = 0; i < B.GetLength(0); i++)
            {
                for (int j = 0; j < B.GetLength(1); j++)
                {
                    if (B[i, j].BackColor == Color.DarkGray ||
                        B[i, j].BackColor == Color.Brown)
                    {
                        numberSelectedElements++;
                    }
                }
                if (numberSelectedElements >= 2)
                {
                    return false;
                }
                else
                {
                    numberSelectedElements = 0;
                }
            }
            return true;
        }

        private void WriteSelectedElementsFromAToTempR()
        {
            int[] numberSelectedElementsInColumn = new int[4];

            //Считаем количество выделенных элементов в каждом столбце матрицы А
            for (int i = 0; i < B.GetLength(0); i++)
            {
                for (int j = 0; j < B.GetLength(1); j++)
                {
                    if (B[i, j].BackColor == Color.Brown)
                    {
                        numberSelectedElementsInColumn[i] += 1;
                    }
                }
            }
            //Ищем наибольшее количество выделенных элементов
            int max = numberSelectedElementsInColumn[0];
            int numberColumn = 0;
            for (int i = 0; i < numberSelectedElementsInColumn.Length; i++)
            {
                if (max < numberSelectedElementsInColumn[i])
                {
                    max = numberSelectedElementsInColumn[i];
                    numberColumn = i;
                }
            }
            for (int i = 0; i < B.GetLength(0); i++)
            {
                if (B[numberColumn, i].BackColor == Color.Brown)
                {
                    tempR[i].Text = B[numberColumn, i].Text;
                }
                else
                {
                    tempR[i].Text = "-";
                }
            }
        }

        private void WriteMinimumElementsFromBToTempL()
        {
            int min = -1;
            for (int i = 0; i < B.GetLength(0); i++)
            {
                //Надо ли рассчитывать число слева от таблицы?
                if (tempR[i].Text != "-")
                {
                    for (int j = 0; j < B.GetLength(1); j++)
                    {
                        //Элемент входит в матрицу B?
                        if (B[j, i].BackColor == Color.White || B[j, i].BackColor == Color.DarkGray)
                        {
                            if (min == -1)
                            {
                                min = int.Parse(B[j, i].Text);
                            }
                            if (min > int.Parse(B[j, i].Text))
                            {
                                min = int.Parse(B[j, i].Text);
                            }
                            tempL[i].Text = min.ToString();
                        }
                    }
                    min = -1;
                }
                else if (tempR[i].Text == "-")
                {
                    tempL[i].Text = "-";
                }
            }
        }

        private void StoreTempLValues()
        {
            for (int i = 0; i < tempL.Length; i++)
            {
                copyTempL[i] = tempL[i].Text;
            }
        }

        private void SubtructTempRFromTempL()
        {
            for (int i = 0; i < tempR.Length; i++)
            {
                if (tempR[i].Text != "-")
                {
                    int tR = int.Parse(tempR[i].Text);
                    int tL = int.Parse(tempL[i].Text);
                    tempL[i].Text = (tL - tR).ToString();
                }
            }
        }

        private void FindCandidate()
        {
            int numberLine = 0;
            for (int i = 0; i < tempL.Length; i++)
            {
                if (tempL[i].Text == FindMinimumNumberLeftOfTable().ToString())
                {
                    numberLine = i;
                    break;
                }
            }
            for (int i = 0; i < B.GetLength(0); i++)
            {
                if (B[i, numberLine].BackColor == Color.DarkGray || B[i, numberLine].BackColor == Color.White)
                {
                    int tmp = int.Parse(B[i, numberLine].Text);
                    if (tmp == FindMinimumNumberCopyLeftOfTable())
                    {
                        candidate = B[i, numberLine];
                        break;
                    }
                }
            }
        }

        private int GetNumberElementsInColumnWithCandidate()
        {
            int numberColumn = 0;
            //Ищем номер столбца, где находится кандидат на выделение
            for (int i = 0; i < B.GetLength(0); i++)
            {
                for (int j = 0; j < B.GetLength(1); j++)
                {
                    if (B[j, i].Name == candidate.Name)
                    {
                        numberColumn = j;
                    }
                }
            }
            int numberElements = 0;
            //Считаем сколько выделенных элементов находится в одном столбце с кандидатом
            for (int i = 0; i < B.GetLength(0); i++)
            {
                if (B[numberColumn, i].BackColor == Color.DarkGray)
                {
                    numberElements++;
                }
            }       
            return numberElements;
        }

        private void AddNumberToA(int number)
        {
            for (int i = 0; i < B.GetLength(0); i++)
            {
                for (int j = 0; j < B.GetLength(1); j++)
                {
                    if (B[j, i].BackColor == Color.Pink || B[j, i].BackColor == Color.Brown)
                    {
                        int temp = int.Parse(B[j, i].Text);
                        temp += number;
                        B[j, i].Text = temp.ToString();
                    }
                }
            }
        }

        private void DeselectOldCandidate()
        {
            int numberLine = 0;
            //Ищем нашего кандидата для выделения
            //Старый кандидат находится в той же строке, что и новый
            for (int i = 0; i < B.GetLength(0); i++)
            {
                for (int j = 0; j < B.GetLength(1); j++)
                {
                    if (candidate.Name == B[j, i].Name)
                    {
                        numberLine = i;
                    }
                }
            }
            //Проходим по найденной строке в поиске старого кандидата
            //Убираем выделение
            for (int i = 0; i < B.GetLength(0); i++)
            {
                if (B[i, numberLine].BackColor == Color.Brown)//CHANGED PLACE i numberLine
                {
                    B[i, numberLine].BackColor = Color.Pink;
                    break;
                }
            }
        }

        private void SelectNewCandidate()
        {
            candidate.BackColor = Color.DarkGray;
        }

        private void RemoveElementsFromA()
        {
            for (int i = 0; i < B.GetLength(0); i++)
            {
                for (int j = 0; j < B.GetLength(1); j++)
                {
                    if (B[i, j].BackColor == Color.Pink)
                    {
                        B[i, j].BackColor = Color.White;
                    }
                    if (B[i, j].BackColor == Color.Brown)
                    {
                        B[i, j].BackColor = Color.DarkGray;
                    }
                }
            }
        }

        private void Reset()
        {
            for (int i = 0; i < copyTempL.Length; i++)
            {
                copyTempL[i] = "";
            }

            for (int i = 0; i < tempR.Length; i++)
            {
                tempR[i].Text = "-";
            }
            for (int i = 0; i < tempL.Length; i++)
            {
                tempL[i].Text = "-";
            }
            candidate = null;
        }

        private void TransferColumnWithCandidateToA()
        {
            //Находим столбец с кандидатом 
            int numberColumn = 0;
            for (int i = 0; i < B.GetLength(0); i++)
            {
                for (int j = 0; j < B.GetLength(1); j++)
                {
                    if (B[j, i].Name == candidate.Name)
                    {
                        numberColumn = j;
                    }
                }
            }

            //Изменяем цвета у найденного столбца
            for (int i = 0; i < B.GetLength(0); i++)
            {
                if (B[numberColumn, i].BackColor == Color.DarkGray)
                {
                    B[numberColumn, i].BackColor = Color.Brown;
                }
                else if (B[numberColumn, i].BackColor == Color.White)
                {
                    B[numberColumn, i].BackColor = Color.Pink;
                }
            }

        }

        private int FindMinimumNumberLeftOfTable()
        {
            int min = 0;
            for (int i = 0; i < tempL.Length; i++)
            {
                if (tempL[i].Text != "-")
                {
                    min = int.Parse(tempL[i].Text);
                }
            }

            for (int i = 0; i < tempL.Length; i++)
            {
                if (tempL[i].Text != "-")
                {
                    int tmp = int.Parse(tempL[i].Text);
                    if (min > tmp)
                    {
                        min = tmp;
                    }
                }
            }       
            return min;
        }

        private int FindMinimumNumberCopyLeftOfTable()
        {
            int min = 0;
            for (int i = 0; i < copyTempL.Length; i++)
            {
                if (copyTempL[i] != "-")
                {
                    min = int.Parse(copyTempL[i]);
                }
            }

            for (int i = 0; i < copyTempL.Length; i++)
            {
                if (copyTempL[i] != "-")
                {
                    int tmp = int.Parse(copyTempL[i]);
                    if (min > tmp)
                    {
                        min = tmp;
                    }
                }
            }
            return min;
        }

        private void CalculateResult()
        {
            int result = 0;        
            for (int i = 0; i < B.GetLength(0); i++)
            {
                for (int j = 0; j < B.GetLength(1); j++)
                {
                    if(B[j,i].BackColor == Color.DarkGray)
                    {
                        result += int.Parse(startB[j, i].Text);
                    }
                }
            }
            Result.Text = result.ToString();
        }


        private void InitializeTable()
        {
            B[0, 0] = Element00B;
            B[0, 1] = Element01B;
            B[0, 2] = Element02B;
            B[0, 3] = Element03B;
            B[1, 0] = Element10B;
            B[1, 1] = Element11B;
            B[1, 2] = Element12B;
            B[1, 3] = Element13B;
            B[2, 0] = Element20B;
            B[2, 1] = Element21B;
            B[2, 2] = Element22B;
            B[2, 3] = Element23B;
            B[3, 0] = Element30B;
            B[3, 1] = Element31B;
            B[3, 2] = Element32B;
            B[3, 3] = Element33B;
            startB[0, 0] = Element00A;
            startB[0, 1] = Element01A;
            startB[0, 2] = Element02A;
            startB[0, 3] = Element03A;
            startB[1, 0] = Element10A;
            startB[1, 1] = Element11A;
            startB[1, 2] = Element12A;
            startB[1, 3] = Element13A;
            startB[2, 0] = Element20A;
            startB[2, 1] = Element21A;
            startB[2, 2] = Element22A;
            startB[2, 3] = Element23A;
            startB[3, 0] = Element30A;
            startB[3, 1] = Element31A;
            startB[3, 2] = Element32A;
            startB[3, 3] = Element33A;
            for (int i = 0; i < tempL.Length; i++)
            {
                tempL[0] = Temp0L;
                tempL[1] = Temp1L;
                tempL[2] = Temp2L;
                tempL[3] = Temp3L;
            }
            for (int i = 0; i < tempR.Length; i++)
            {
                tempR[0] = Temp0R;
                tempR[1] = Temp1R;
                tempR[2] = Temp2R;
                tempR[3] = Temp3R;
            }
        }
    }
}
