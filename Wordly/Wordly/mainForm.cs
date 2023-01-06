using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Wordly
{
    public partial class mainForm : Form
    {
        List<string> words = new List<string>();
        string letters = "ЙЦУКЕНГШЩЗХЪФЫВАПРОЛДЖЭЯЧСМИТЬБЮ";        
        int[] letterCountInRow = { 12, 11, 9 };
        bool[] letterEnabled = null;
        string[] matched = { "", "", "", "", "", "", "", "", "" };
        int letterCount = 5;

        public mainForm()
        {
            InitializeComponent();

            try
            {
                // чтение списка слов из встроенного файла ресуров
                var db = Properties.Resources.words;

                // разбиение списка слов в массив строк
                string[] dbLines = db.Split(new string[] { "\r\n" }, StringSplitOptions.None);

                // преобразование массива строк в список
                foreach (string line in dbLines)
                {
                    words.Add(line);
                }
            }
            finally
            {
                sbLabel.Text = "Загружен список из " + words.Count + " слов.";
            }
            
            letterEnabled = new bool[letters.Length];

            MatchButtonClick(btn5, new EventArgs());
            btnReset_Click(null, new EventArgs());
        }

        private bool IsLetterEnabled(char letter)
        {
            var aLetter = letter.ToString().ToUpper()[0];
            if (aLetter == 'Ё')
            {
                aLetter = 'Е';
            }

            var result = false;
            var index = 0;
            foreach(var ch in letters)
            {
                if (letterEnabled[index] && (aLetter == ch))
                {
                    result = true;
                    break;
                }
                index++;
            }

            return result;
        }

        private int IsMatched()
        {
            var result = 0;
            for (int i = 0; i < letterCount; i++)
            {
                if (matched[i] != "")
                {
                    result++;
                }
            }

            return result;
        }

        private int IsMatched(string value)
        {
            var result = 0;
            for (int i = 0; i < letterCount; i++)
            {
                if (matched[i] == value)
                {
                    result++;
                }
            }

            return result;
        }

        private void SetMatchedIndex(string value, int index)
        {
            matched[index] = value;
            UpdateMatchedButtons();
        }

        private void ResetMatchedValue()
        {
            for (int i = 0; i < letterCount; i++)
            {
                matched[i] = "";
            }

            UpdateMatchedButtons();
        }

        private void ResetMatchedValue(string value)
        {
            for (int i = 0; i < letterCount; i++)
            {
                if (matched[i] == value)
                {
                    matched[i] = "";
                }
            }
            
            UpdateMatchedButtons();
        }

        private List<int> GetMatched()
        {
            var matchedCount = IsMatched();
            if (matchedCount > 0)
            {
                var result = new List<int>();
                for (int i = 0; i < letterCount; i++)
                {
                    if (matched[i] != "")
                    {
                        result.Add(i);
                    }
                }

                return result;
            }

            return null;
        }

        private List<int> GetMatched(string value)
        {
            var matchedCount = IsMatched(value);
            if (matchedCount > 0)
            {
                var result = new List<int>();
                for (int i = 0; i < letterCount; i++)
                {
                    if (matched[i] == value)
                    {
                        result.Add(i);
                    }
                }

                return result;
            }

            return null;
        }

        private void UpdateMatchedButtons()
        {
            for (int i = 0; i < letterCount; i++)
            {
                var button = gbMatchedLetters.Controls["btn" + (i + 1).ToString()];
                if (button != null)
                {
                    (button as Button).Text = matched[i];
                    if (matched[i] == "")
                    {
                        (button as Button).BackColor = SystemColors.Control;
                    }
                    else
                    {
                        (button as Button).BackColor = Color.LightGreen;
                    }
                }
            }
        }

        private void RefillLettersList()
        {
            lbLetters.Items.Clear();
            for (int i = 0; i < letterEnabled.Length; i++)
            {                
                if ((letterEnabled[i]) && (IndexOfLetter(letters[i].ToString()) == -1))
                {
                    lbLetters.Items.Add(letters[i].ToString());
                }                                
            }
            lbLetters.SelectedIndex = -1;
        }

        private void RepaintButtons()
        {
            foreach (DataGridViewRow row in dgLetters.Rows)
            {
                foreach (DataGridViewCell cell in row.Cells)
                {
                    if (cell.Value != null)
                    {
                        var value = cell.Value.ToString();
                        var index = letters.IndexOf(value);
                        if (!letterEnabled[index])
                        {
                            cell.Style.BackColor = Color.Gray;
                        }
                        else                        
                        if(IndexOfLetter(value) != -1)
                        {
                            cell.Style.BackColor = Color.DarkOrange;
                        }
                        else                        
                        if (IsMatched(value) > 0)
                        {
                            cell.Style.BackColor = Color.LightGreen;
                        }                        
                        else
                        {
                            cell.Style.BackColor = Color.White;
                        }
                    }
                    else
                    {
                        cell.Style.BackColor = Color.DarkGray;
                    }
                }
            }
        }

        public void fillLettersGrid()
        {
            dgLetters.Rows.Clear();
            
            int lettersCount = letters.Length;
            int iTotalIndex = 0;
            for (int i = 0; i < 3; i++)
            {
                string[] rowLetters = new string[12];
                int iIndex = 0;
                for (int j = 0; j < 12; j++)
                {
                    if (iIndex <= letterCountInRow[i] - 1)
                    {
                        rowLetters[j] = letters[iTotalIndex].ToString();
                        iIndex++;
                        iTotalIndex++;
                    }
                }
                dgLetters.Rows.Add(rowLetters);
            }
                        
            var height = 0;
            foreach (DataGridViewRow row in dgLetters.Rows)
            {
                foreach(DataGridViewCell cell in row.Cells)
                {
                    if (cell.Value != null)
                    {
                        cell.Style.BackColor = Color.White;
                    }
                    else
                    {
                        cell.Style.BackColor = Color.DarkGray;
                    }
                }
                row.DefaultCellStyle.BackColor = Color.White;
                height += row.Height;
            }
            dgLetters.Height = height + 1;            
        }

        private void dgLetters_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var senderGrid = (DataGridView)sender;
            if (senderGrid.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
                var value = senderGrid.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString();
                var index = letters.IndexOf(value);
                var enabled = letterEnabled[index];

                // old state - enabled
                if (enabled)
                {                    
                    var foundIndex = IndexOfLetter(value);
                    if (foundIndex != -1)
                    {                        
                        dgFoundLetters.Rows.RemoveAt(foundIndex);
                    }

                    var matchedList = GetMatched(value);
                    if (matchedList != null)
                    {
                        ResetMatchedValue(value);
                    }

                    letterEnabled[index] = false;
                }
                else
                {
                    // old state - disabled
                    letterEnabled[index] = true;
                }

                RefillLettersList();
                RepaintButtons();
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (lbLetters.SelectedIndex != -1)
            {
                switch (letterCount)
                {
                    case 5:
                        dgFoundLetters.Rows.Add(lbLetters.Items[lbLetters.SelectedIndex].ToString(), false, false, false, false, false);
                        break;
                    case 6:
                        dgFoundLetters.Rows.Add(lbLetters.Items[lbLetters.SelectedIndex].ToString(), false, false, false, false, false, false);
                        break;
                    case 7:
                        dgFoundLetters.Rows.Add(lbLetters.Items[lbLetters.SelectedIndex].ToString(), false, false, false, false, false, false, false);
                        break;
                    case 8:
                        dgFoundLetters.Rows.Add(lbLetters.Items[lbLetters.SelectedIndex].ToString(), false, false, false, false, false, false, false, false);
                        break;
                    case 9:
                        dgFoundLetters.Rows.Add(lbLetters.Items[lbLetters.SelectedIndex].ToString(), false, false, false, false, false, false, false, false, false);
                        break;
                }
                
                RefillLettersList();
                RepaintButtons();
            }
        }

        private int GetSelectedRowIndex()
        {
            if (dgFoundLetters.CurrentCell != null)
            {
                return dgFoundLetters.CurrentCell.RowIndex;
            }
            else
            {
                return -1;
            }
        }

        private int IndexOfLetter(string aLetter)
        {
            if (dgFoundLetters.Rows.Count == 0)
            {
                return -1;
            }
            else
            {
                var index = 0;
                foreach (DataGridViewRow row in dgFoundLetters.Rows)
                {
                    if (row.Cells[0].Value.ToString() == aLetter)
                    {
                        return index;
                    }
                    index++;
                }
                return -1;
            }
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {            
            var index = GetSelectedRowIndex();
            if (index >= 0)
            {                
                dgFoundLetters.Rows.RemoveAt(index);
                dgFoundLetters.CurrentCell = null;                
                RefillLettersList();
                RepaintButtons();
            }
        }

        private void MenuHandler(object sender)
        {
            if (sender != null)
            {
                var item = sender as ToolStripMenuItem;
                var letterMenu = item.Text;
                var chars = letterMenu.Split(' ');
                var letter = "";
                var index = 0;
                foreach(var ch in chars)
                {
                    if ((ch != "*") && (index + 1 == (int)item.Tag))
                    {
                        letter = ch;
                        break;
                    }
                    index++;
                }

                switch (item.Tag)
                {
                    case 1:
                        btn1.Text = letter;
                        matched[0] = letter;
                        break;
                    case 2:
                        btn2.Text = letter;
                        matched[1] = letter;
                        break;
                    case 3:
                        btn3.Text = letter;
                        matched[2] = letter;
                        break;
                    case 4:
                        btn4.Text = letter;
                        matched[3] = letter;
                        break;
                    case 5:
                        btn5.Text = letter;
                        matched[4] = letter;
                        break;
                    case 6:
                        btn6.Text = letter;
                        matched[5] = letter;
                        break;
                    case 7:
                        btn7.Text = letter;
                        matched[6] = letter;
                        break;
                    case 8:
                        btn8.Text = letter;
                        matched[7] = letter;
                        break;
                    case 9:
                        btn9.Text = letter;
                        matched[8] = letter;
                        break;
                    default:
                        break;
                }

                // удаление буквы, находящейся на своем месте, из списка найденных букв 
                var foundIndex = IndexOfLetter(letter);
                if (foundIndex != -1)
                {
                    dgFoundLetters.Rows.RemoveAt(foundIndex);
                }

                // отключение столбца с номером буквы на своем месте в списке найденных букв
                foreach (DataGridViewRow row in dgFoundLetters.Rows)
                {                    
                    (row.Cells[(int)item.Tag] as DataGridViewCheckBoxCell).Value = (object)false;
                } 

                RefillLettersList();
                UpdateMatchedButtons();
                RepaintButtons();
            }
        }

        private string GetMenuItemText(string letter, int index)
        {            
            var result = "";
            if (matched[index] != "")
            {
                return "";
            }

            for (int i = 0; i < letterCount; i++)
            {
                if (i == index)
                {
                    result += letter + " ";
                }
                else
                {
                    if (matched[i] != "")
                    {
                        result += matched[i] + " ";
                    }
                    else
                    {
                        result += "* ";
                    }
                }
            }

            return result.Trim();
        }

        private void FillMenu(string letter)
        {
            cmsSelectLetter.Items.Clear();
            for (int i = 0; i < letterCount; i++)
            {
                var menuText = GetMenuItemText(letter, i);
                if (menuText != "")
                {
                    var menuItem = new ToolStripMenuItem(menuText, null, (sender, e) => MenuHandler(sender));
                    menuItem.Tag = i + 1;                    
                    cmsSelectLetter.Items.Add(menuItem);
                }
            }
            cmsSelectLetter.Items.Add("-");
            cmsSelectLetter.Items.Add("Отмена");
        }

        private void dgLetters_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                var senderGrid = (DataGridView)sender;
                if (senderGrid.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
                {
                    var value = senderGrid.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString();
                    var index = letters.IndexOf(value);
                    var enabled = letterEnabled[index];

                    if (enabled)
                    {
                        FillMenu(value);

                        Rectangle r = senderGrid.Rows[e.RowIndex].Cells[e.ColumnIndex].DataGridView.GetCellDisplayRectangle(e.ColumnIndex, e.RowIndex, false);

                        cmsSelectLetter.Show(dgLetters, new Point(r.X, r.Y + r.Height));
                    }
                }
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {            
            try
            {
                Cursor.Current = Cursors.WaitCursor;
                lbVariants.Items.Clear();
                foreach (var word in words)
                {
                    if (word.Length == letterCount)
                    {
                        var aMatched = GetMatched();
                        var matchResult = true;
                        if (aMatched != null)
                        {
                            // проверка на буквы на своих местах
                            matchResult = true;
                            foreach (var matchIndex in aMatched)
                            {
                                var aLetter = word[matchIndex].ToString().ToUpper();
                                if (aLetter == "Ё")
                                {
                                    aLetter = "Е";
                                }

                                matchResult = matchResult && (aLetter == matched[matchIndex]);
                                if (!matchResult)
                                {
                                    break;
                                }
                            }
                        }


                        // проверка на буквы не на своих местах
                        var letterResult = true;
                        foreach (DataGridViewRow row in dgFoundLetters.Rows)
                        {
                            var aLetter = row.Cells[0].Value.ToString();
                            var checkResult = false;
                            for (int i = 1; i <= letterCount; i++)
                            {                                
                                var wordLetter = word[i - 1].ToString().ToUpper();
                                if (wordLetter == "Ё")
                                {
                                    wordLetter = "Е";
                                }

                                var check = (bool)row.Cells[i].Value;
                                if (check)
                                {
                                    // буква может быть в отмеченных местах
                                    checkResult = checkResult || (aLetter == wordLetter);
                                }
                            }

                            for (int i = 1; i <= letterCount; i++)
                            {
                                var wordLetter = word[i - 1].ToString().ToUpper();
                                if (wordLetter == "Ё")
                                {
                                    wordLetter = "Е";
                                }

                                var check = (bool)row.Cells[i].Value;
                                if (!check)
                                {
                                    // буквы не может быть в неотмеченных местах
                                    checkResult = checkResult && (aLetter != wordLetter);
                                }

                                if (!checkResult)
                                {
                                    break;
                                }
                            }

                            if (!checkResult)
                            {
                                letterResult = false;
                                break;
                            }

                            letterResult = letterResult && checkResult;
                            if (!letterResult)
                            {
                                break;
                            }
                        }                           
                        
                        if (matchResult && letterResult)
                        {
                            // проверка на отсутствующие буквы
                            matchResult = true;
                            foreach (var ch in word)
                            {
                                matchResult = matchResult && IsLetterEnabled(ch);
                            }

                            if (matchResult)
                            {
                                // проверка на слова со всеми разными буквами
                                if (chkDifferent.Checked)
                                {
                                    if (IsHasDifferentLetters(word))
                                    {
                                        lbVariants.Items.Add(word);
                                    }
                                }
                                else
                                {
                                    lbVariants.Items.Add(word);
                                }
                            }
                        }
                    }
                }
            }
            finally
            {
                Cursor.Current = Cursors.Default;
            }

            gbVariants.Text = " Варианты (" + lbVariants.Items.Count + "): ";
        }

        private bool IsHasDifferentLetters(string word)
        {
            List<char> chars = new List<char>();
            foreach (char ch in word)
            {
                if (chars.IndexOf(ch) != -1)
                {
                    return false;
                }
                else
                {
                    chars.Add(ch);
                }
            }

            return true;
        }

        private void btnReset_Click(object sender, EventArgs e)
        {           
            this.Text = "Wordly - " + letterCount + " letters";

            for (int i = 0; i < letterEnabled.Length; i++)
            {
                letterEnabled[i] = true;
            }

            chkDifferent.Checked = false;
            dgFoundLetters.Rows.Clear();
            ResetMatchedValue();
            RefillLettersList();
            UpdateMatchedButtons();
            fillLettersGrid();

            lbVariants.Items.Clear();
            gbVariants.Text = " Варианты (0): ";
        }

        private void MatchButtonClick(object sender, EventArgs e)
        {
            if (sender is Button)
            {
                var senderButton = sender as Button;
                var buttonIndex = Convert.ToInt32(senderButton.Name[3].ToString());

                for (int i = 1; i <= 9; i++)
                {
                    var button = gbMatchedLetters.Controls["btn" + i.ToString()];
                    var label = gbMatchedLetters.Controls["l" + i.ToString()];
                    if ((button != null) && (label != null))
                    {                        
                        if (i <= buttonIndex)
                        {
                            (button as Button).BackColor = SystemColors.Control;
                            dgFoundLetters.Columns[i].Visible = true;
                            (label as Label).Enabled = true;
                        }
                        else
                        {                            
                            (button as Button).BackColor = SystemColors.ControlDark;
                            dgFoundLetters.Columns[i].Visible = false;
                            (label as Label).Enabled = false;
                        }
                    }
                }

                letterCount = buttonIndex;
                btnReset_Click(null, new EventArgs());
            }
        }
    }
}
