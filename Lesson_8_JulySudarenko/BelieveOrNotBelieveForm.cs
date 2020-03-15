using System;
using BelieveOrNotBelieve;
using System.Windows.Forms;

namespace Lesson_8_JulySudarenko
{
    /// <summary>
    /// 3. а) Создать приложение, показанное на уроке, 
    /// добавив в него защиту от возможных ошибок
    /// (не создана база данных, 
    /// обращение к несуществующему вопросу, 
    /// открытие слишком большого файла и т.д.).
    /// б) Изменить интерфейс программы, 
    /// увеличив шрифт, поменяв цвет элементов и 
    /// добавив другие «косметические» улучшения на свое усмотрение.
    /// в) Добавить в приложение меню «О программе» с информацией о программе
    /// (автор, версия, авторские права и др.).
    /// г)* Добавить пункт меню Save As, 
    /// в котором можно выбрать имя для сохранения базы данных
    /// (элемент SaveFileDialog).
    /// </summary>


    public partial class BelieveOrNotBelieveForm : Form
    {
        TrueFalse database;
        public BelieveOrNotBelieveForm()
        {
            InitializeComponent();
        }

        private void newMenu_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                database = new TrueFalse(sfd.FileName);
                database.Save();
                
                //Вызывает ошибку. Я изначально установила минимум 1.
                //numUpDown.Minimum = 1;
                //numUpDown.Maximum = 1;
                //numUpDown.Value = 1;
            }
        }

        private void numUpDown_ValueChanged(object sender, EventArgs e)
        {
            questionTextBox.Text = database[(int)numUpDown.Value - 1].Text;
            trueTextBox.Checked = database[(int)numUpDown.Value - 1].TrueFalse;
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            if (database == null)
            {
                MessageBox.Show("Откройте сохраненный файл или создайте новый", "Сообщение");
                return;
            }
            
            //не знаю почему в методичке решили записать число в текст.
            //database.Add((database.Count + 1).ToString(), true); 
            
            database.Add(questionTextBox.Text, trueTextBox.Checked);
            numUpDown.Maximum = database.Count;
            numUpDown.Value = database.Count;
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            if (numUpDown.Maximum == 1 || database == null)
                return;
            
            database.Remove((int)numUpDown.Value);
            numUpDown.Maximum--;
            
            if (numUpDown.Value > 1)
                numUpDown.Value = numUpDown.Maximum;
        }

        private void saveMenu_Click(object sender, EventArgs e)
        {
            if (database != null)
                database.Save();
            
            else 
                MessageBox.Show("База данных не создана");
        }

        private void saveAsMenu_Click(object sender, EventArgs e)
        {
            if (database != null)
            {
                SaveFileDialog sfdSaveAs = new SaveFileDialog();

                if (sfdSaveAs.ShowDialog() == DialogResult.OK)
                {
                    database.FileName = sfdSaveAs.FileName;
                    database.Save();
                }
            }

            else MessageBox.Show("Нет данных для сохранения.");
        }

        private void openMenu_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                database = new TrueFalse(ofd.FileName);
                database.Load();
                
                //numUpDown.Minimum = 1;
                numUpDown.Maximum = database.Count;
                numUpDown.Value = 1;
            }
        }

        //Не пойму зачем нужна эта кнопка?
        //Все это выполняется при прокрутке счетчика на 1.
        private void saveButton_Click(object sender, EventArgs e)
        {
            if (database == null)
            {
                MessageBox.Show("Создайте новую базу данных", "Сообщение");
                return;
            }
            database[(int)numUpDown.Value - 1].Text = questionTextBox.Text;
            database[(int)numUpDown.Value - 1].TrueFalse = trueTextBox.Checked;
        }

        private void exitMenu_Click_1(object sender, EventArgs e)
        {
            Close();
        }

        private void progInfoMenu_Click(object sender, EventArgs e)
        {
            Form aboutProgram = new AboutProgram();
            aboutProgram.Show();
        }
    }
}
