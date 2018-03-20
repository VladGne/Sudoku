using System;
using System.Drawing;
using System.Windows.Forms;
using System.IO;
using System.ComponentModel;
using System.Text;
using System.Linq;

namespace Sudoku
{
    public partial class Form1 : Form
    {
        object[,] DefaultGrid = {{7,9,2,3,5,1,8,4,6},
                                 {4,6,8,9,2,7,5,1,3},
                                 {1,3,5,6,8,4,7,9,2},
                                 {6,2,1,5,7,9,4,3,8},
                                 {5,8,3,2,4,6,1,7,9},
                                 {9,7,4,8,1,3,2,6,5},
                                 {8,1,6,4,9,2,3,5,7},
                                 {3,5,7,1,6,8,9,2,4},
                                 {2,4,9,7,3,5,6,8,1}
                                 };
        bool timerOn;
        int Difficult = 5;
        int timeLeft;
        int currentTime; string path = "Records.txt";
        string min = " min ", sec = " sec", stater = "Status - Error", statdone = "Status - Done", statprog = "Status - In progress", NG = "New Game", TL = "Time Left - ", TU = "Time's up!", fin = "You didn't finished in time!", sor = "Sorry!";
        public Form1()
        {
            InitializeComponent();

            for (int i = 0; i < 9; i++)
                GameGrid.Rows.Add();
            GameGrid.Rows[2].DividerHeight = 1; GameGrid.Rows[5].DividerHeight = 1;
            ColorGrid();

            RecordsGrid.Columns[2].ValueType = typeof(Int32);
            RecordsGrid.Columns[1].ValueType = typeof(DateTime);

            DifficultSwitcher.SelectedIndex = 0; LanguagesSwitcher.SelectedIndex = 0;
        }

        private void ColorGrid()
        {
            for (int i=3; i<6; i++)
            {
                for (int k=0; k<3; k++)
                {
                    GameGrid[i, k].Style.BackColor = Color.LightGray;
                    GameGrid[k, i].Style.BackColor = Color.LightGray;
                }

                for (int k = 6; k < 9; k++)
                {
                    GameGrid[i, k].Style.BackColor = Color.LightGray;
                    GameGrid[k, i].Style.BackColor = Color.LightGray;
                }
            }
      
        }

        private void FillGrid()
        {
            //HideCells(Difficult);   
            ShowCells(Difficult);
        }

        private void ShowCells(int difficult)
        {
            Random number = new Random();           
            int CellsCount = (9 - difficult); // Кол-во Непустых ячеек в строке
            
            int[] cin = {0, 3, 6, 9 }, rin = {0, 3, 6, 9 };
            
            for (int j = 0; j < 3; j++)
            {
                for (int k =0; k<3; k++)
                {
                    int[] rcells = new int[CellsCount]; int[] ccells = new int[CellsCount];
                    for (int i = 0; i < CellsCount; i++)
                    {
                        bool contains;
                        int next1, next;
                        do
                        {
                            next1 = number.Next(rin[j], rin[j+1]); next = number.Next(cin[k], cin[k+1]);
                            contains = false;
                            for (int index = 0; index < i; index++)
                            {
                                int n = rcells[index];
                                int m = ccells[index];
                                if (n == next1 && m == next)
                                {
                                    contains = true;
                                    break;
                                }
                            }
                        } while (contains);
                        rcells[i] = next1;
                        ccells[i] = next;
                    }

                    for (int i=0; i< CellsCount; i++)
                    {
                        GameGrid[ccells[i], rcells[i]].Value = DefaultGrid[ccells[i], rcells[i]];
                    }
                }             
            }
        }

        private void HideCells(int difficult)
        {
            Random number = new Random();                    
            for (int c = 0; c < 9; c++)
            {
                int CellsCount = number.Next(difficult - 1, difficult); // Кол-во Пустых ячеек в строке
                int[] cells = new int[CellsCount];

                for (int j = 0; j < CellsCount; j++)
                {
                    bool contains;
                    int next;
                    do
                    {
                        next = number.Next(9);
                        contains = false;
                        for (int index = 0; index < j; index++)
                        {
                            int n = cells[index];
                            if (n == next)
                            {
                                contains = true;
                                break;
                            }
                        }
                    } while (contains);
                    cells[j] = next;
                }
                                
                for (int r = 0; r < 9; r++)
                {
                    if (cells.Contains(r) == true)    
                    GameGrid[c, r].Value = ' ';
                }
            }
        }

        private void CheckBTN_Click(object sender, EventArgs e)
        {
            bool error = false;
            for (int i = 0; i < 9; i++)
            {
                for (int k = 0; k < 9; k++)
                {
                    if (GameGrid[i, k].Value != DefaultGrid[i, k])
                        error = true;
                }
            }
            if (error)
                StatusLbl.Text = stater;
            else
            {
                StatusLbl.Text = statdone;
                SaveResultBTN.Enabled = true;
                timer1.Stop();
            }
        }

        private void SaveResultBTN_Click(object sender, EventArgs e)
        {
            String StrToFile = Environment.NewLine + PlayerNameBox.Text + '|' + DateTime.Today.ToString("d") + '|' + currentTime + '|' + DifficultSwitcher.Text; 

            if (!File.Exists(path))          
                File.WriteAllText(path, StrToFile);                                 
            else                          
                File.AppendAllText(path, StrToFile, Encoding.UTF8);           
        }

        private void StartBTN_Click(object sender, EventArgs e)
        {

            for(int i =0; i<9; i++)
            {
                for (int j = 0; j < 9; j++)
                    GameGrid[i, j].Value = null;
            }

            SaveResultBTN.Enabled = false;
            timerOn = true;
            currentTime = 0;
            timeLeft = Convert.ToInt32(TimerNUD.Value*60);
            NewGameLbl.Text = NG + Environment.NewLine + 0 + sec;
            if (TimerCB.Checked)
                TimerLbl.Text = TL + timeLeft / 60 + min + timeLeft % 60 + sec;
            else
                TimerLbl.Text = TL + @"∞";
            StatusLbl.Text = statprog;
            timer1.Start();         
            FillGrid();
        }

        private void ExitBTN_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void PlayerNameBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '|') // Запрет на символ '|' в нике
                e.Handled = true;          
        }

        private void NewGameBTN_Click(object sender, EventArgs e)
        {
            AboutPanel.Visible = false;
            RecordsPanel.Visible = false;
            SettingsPanel.Visible = false;                     
        }

        private void SettingsBTN_Click(object sender, EventArgs e)
        {
            AboutPanel.Visible = false;
            RecordsPanel.Visible = false;
            SettingsPanel.Visible = true;                      
        }

        private void RecordsBTN_Click(object sender, EventArgs e)
        {
            if (!File.Exists(path))
                File.Create(path);
            AboutPanel.Visible = false;
            SettingsPanel.Visible = true;
            RecordsPanel.Visible = true;        
        }

        private void AboutBTN_Click(object sender, EventArgs e)
        {
            SettingsPanel.Visible = true;
            RecordsPanel.Visible = true;
            AboutPanel.Visible = true;
        }

        private void FillRecordGrid()
        {
            string FileName = @"Records.txt";
            int RowsCount = 0, StrCount = 0;
            RecordsGrid.Rows.Add();
            try
            {
                using (StreamReader sr = new StreamReader(FileName))
                {
                    String line;
                    while ((line = sr.ReadLine()) != null)
                    {
                        string[] cell = line.Split(new[] { '|' }, StringSplitOptions.RemoveEmptyEntries);
                        if (cell.Length > 1)
                        {
                            if (RowsCount < StrCount)
                            {
                                RowsCount++;
                                RecordsGrid.Rows.Add();

                                for (int k = 0; k < 4; k++)
                                {
                                    if (k == 2)
                                        RecordsGrid[k, RowsCount].Value = Convert.ToInt32(cell[k]);
                                    else if (k == 1)
                                        RecordsGrid[k, RowsCount].Value = Convert.ToDateTime(cell[k]);
                                    else
                                        RecordsGrid[k, RowsCount].Value = cell[k];
                                }
                            }
                            else
                            {
                                for (int k = 0; k < 4; k++)
                                {
                                    if (k == 2)
                                        RecordsGrid[k, RowsCount].Value = Convert.ToInt32(cell[k]);
                                    else if (k == 1)
                                        RecordsGrid[k, RowsCount].Value = Convert.ToDateTime(cell[k]);
                                    else
                                        RecordsGrid[k, RowsCount].Value = cell[k];
                                }
                            }
                            StrCount++;
                        }
                    }
                }

                string easy = "Easy", medium = "Medium", Impossible = "Unreal", легкий = "Легкий", нормальный = "Нормальный", сложный = "Сложный", сложность;
                for (int i = 0; i < RecordsGrid.RowCount; i++)
                {
                    сложность = Convert.ToString(RecordsGrid[3, i].Value);

                    if (LanguagesSwitcher.SelectedIndex == 0)
                    {
                        if (сложность == легкий)
                            RecordsGrid[3, i].Value = easy;

                        if (сложность == нормальный)
                            RecordsGrid[3, i].Value = medium;

                        if (сложность == сложный)
                            RecordsGrid[3, i].Value = Impossible;
                    }

                    if (LanguagesSwitcher.SelectedIndex == 1)
                    {
                        if (сложность == easy)
                            RecordsGrid[3, i].Value = легкий;

                        if (сложность == medium)
                            RecordsGrid[3, i].Value = нормальный;

                        if (сложность == Impossible)
                            RecordsGrid[3, i].Value = сложный;
                    }
                }
            }
            catch { }
            
        }
       
        private void timer1_Tick(object sender, EventArgs e)
        {
            currentTime++;
            NewGameLbl.Text = NG + Environment.NewLine + currentTime / 60 + min + currentTime % 60 + sec;

            if (TimerCB.Checked && timerOn == true)
            {
                if (timeLeft > 0)
                {
                    timeLeft--;
                    TimerLbl.Text = TL + timeLeft / 60 + min + timeLeft % 60 + sec;
                }
                else
                {
                    timerOn = false;
                    TimerLbl.Text = TU;
                    MessageBox.Show(fin, sor);
                }
            }  
        }

        private void TimerCB_CheckedChanged(object sender, EventArgs e)
        {
            if (TimerCB.Checked)
                TimerNUD.Enabled = true;
            else
                TimerNUD.Enabled = false;
        }

        private void StatusLbl_DoubleClick(object sender, EventArgs e)
        {
            for (int i = 0; i < 9; i++)
            {
                for (int k = 0; k < 9; k++)
                {
                    GameGrid[i, k].Value = DefaultGrid[i, k];
                }
            }
        }

        private void LanguagesSwitcher_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (LanguagesSwitcher.SelectedIndex == 1)
            {
                AboutBox.Text = @"Законы игры судоку

 В судоку играют на квадратном поле 9 на 9 клеток. 
 Само поле поделено на районы (квадраты 3 на 3) 
 В начале игры известны некоторое число цифр в определенных клетках.
 Цель судоку заполнить все пустые клетки с помощью цифр 1-9 (по одной цифре на клетку), по следующим правилам:
 - цифра может появиться только один раз в каждой строчке;
 - цифра может появиться только один раз в каждом столбике;
 - цифра может появиться только один раз в каждом районе.
 Проще говоря, одна и та же цифра может появиться только один раз в каждой строчке, столбике и районе
 Вот и всё. Теперь ты готов разгадывать головоломки судоку.
 Удачи!

 v.1.0 Гнеушев В. А. ИВТ - 463 ";

                min = " мин "; sec = " сек"; stater = "Статус - Ошибка"; statdone = "Статус - Готово"; statprog = "Статус - В процессе"; NG = "Новая Игра"; TL = "Таймер - "; TU = "Время вышло!"; fin = "Вы не уложились во время!"; sor = "Извините!";

                AboutLbl.Text = "Справка"; AboutBTN.Text = "Справка";

                RecordsBTN.Text = "Рекорды"; RecordsLbl.Text = "Pекорды";
                RecordsGrid.Columns[0].HeaderCell.Value = "Игрок";
                RecordsGrid.Columns[1].HeaderCell.Value = "Дата";
                RecordsGrid.Columns[2].HeaderCell.Value = "Время";
                RecordsGrid.Columns[3].HeaderCell.Value = "Сложность";

                SettingsBTN.Text = "Настройки"; SettingsLbl.Text = "Настройки";
                LanguageLbl.Text = "Язык"; DifficultLbl.Text = "Уровень сложности";
                TimerCB.Text = "Включить таймер"; MinLbl.Text = "мин";
                PlayerNameLbl.Text = "Имя игрока";
                DifficultSwitcher.Items[0] = "Легкий";
                DifficultSwitcher.Items[1] = "Нормальный";
                DifficultSwitcher.Items[2] = "Сложный";

                NewGameBTN.Text = "Новая игра"; NewGameLbl.Text = "Новая игра";
                TimerLbl.Text = "Таймер";  StatusLbl.Text = "Статус";
                CheckBTN.Text = "Проверить"; SaveResultBTN.Text = "Сохранить результат";
                MainMenuLbl.Text = "Главное меню"; ExitBTN.Text = "Выход"; StartBTN.Text = "Старт";
            }

            else
            {
                AboutBox.Text = @"Sudoku rules

 Sudoku is played over a 9x9 grid, divided to 3x3 sub grids called <<regions>>.
 Sudoku begins with some of the grid cells already filled with numbers.
 The object of Sudoku is to fill the other empty cells with numbers between 1 and 9 (1 number only in each cell) according the following guidelines:
 - number can appear only once on each row;
 - number can appear only once on each column;
 - number can appear only once on each region.
 A summary of these guidelines would be, that a number should appear
 only once on each row, column and a region.
 That's it. You are now ready to solve Sudoku puzzles.
 Goodluck!

 v.1.0 by Gneushev V. A. IVT - 463";

                min = " min "; sec = " sec"; stater = "Status - Error"; statdone = "Status - Done"; statprog = "Status - In progress"; NG = "New Game"; TL = "Time Left - "; TU = "Time's up!"; fin = "You didn't finished in time!"; sor = "Sorry!";

                AboutLbl.Text = "About"; AboutBTN.Text = "About";

                RecordsBTN.Text = "Record"; RecordsLbl.Text = "Record";
                RecordsGrid.Columns[0].HeaderCell.Value = "Player";
                RecordsGrid.Columns[1].HeaderCell.Value = "Date";
                RecordsGrid.Columns[2].HeaderCell.Value = "Time";
                RecordsGrid.Columns[3].HeaderCell.Value = "Difficulty";

                SettingsBTN.Text = "Settings"; SettingsLbl.Text = "Settings";
                LanguageLbl.Text = "Language"; DifficultLbl.Text = "Difficulty";
                TimerCB.Text = "Enable timer"; MinLbl.Text = "min";
                PlayerNameLbl.Text = "Player Name";
                DifficultSwitcher.Items[0] = "Easy";
                DifficultSwitcher.Items[1] = "Medium";
                DifficultSwitcher.Items[2] = "Unreal";

                NewGameBTN.Text = "New game"; NewGameLbl.Text = "New game";
                TimerLbl.Text = "Timer"; StatusLbl.Text = "Status";
                CheckBTN.Text = "Check"; SaveResultBTN.Text = "Save result";
                MainMenuLbl.Text = "Main menu"; ExitBTN.Text = "Exit"; StartBTN.Text = "Start";
            }
        }

        private void DifficultSwitcher_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (DifficultSwitcher.SelectedIndex == 0)
                Difficult = 5;
            if (DifficultSwitcher.SelectedIndex == 1)
                Difficult = 6;
            if (DifficultSwitcher.SelectedIndex == 2)
                Difficult = 7;
        }

        private void RecordsPanel_VisibleChanged(object sender, EventArgs e)
        {
            if (RecordsPanel.Visible == true)
            {
                FillRecordGrid();
                RecordsGrid.Sort(RecordsGrid.Columns[2], ListSortDirection.Ascending);

                for (int i = 0; i < RecordsGrid.RowCount; i++)
                    RecordsGrid.Rows[i].HeaderCell.Value = "" + (i + 1);
            }
            else
            {
                int RC = RecordsGrid.RowCount;
                for (int i = RC - 1; i >= 0; i--)
                    RecordsGrid.Rows.Remove(RecordsGrid.Rows[i]);
            }
        }
                  
        private void GameGrid_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            e.Control.KeyPress -= new KeyPressEventHandler(Column1_KeyPress);            
            TextBox tb = e.Control as TextBox;
            tb.MaxLength = 1;
            if (tb != null)
               tb.KeyPress += new KeyPressEventHandler(Column1_KeyPress);
        }

        private void Column1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar)
                && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
