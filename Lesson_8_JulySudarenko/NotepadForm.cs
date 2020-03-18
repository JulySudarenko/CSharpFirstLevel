using System;
using System.Windows.Forms;

namespace Lesson_8_JulySudarenko
{
    /// <summary>
    /// 4. *Используя полученные знания и класс TrueFalse в качестве шаблона, 
    /// разработать собственную утилиту хранения данных 
    /// (Например: Дни рождения, Траты, Напоминалка, Английские слова и другие).
    /// </summary>

    public partial class NotepadForm : Form
    {
        
        NotepadList database;
        public NotepadForm()
        {
            InitializeComponent();
        }

        private void exitMenu_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void counterUpDown_ValueChanged(object sender, EventArgs e)
        {
            noteTextBox.Text = database[(int)counterUpDown.Value - 1].Text;
            dateTimeNote.Value = database[(int)counterUpDown.Value - 1].DateNote;
        }

        private void newMenu_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                database = new NotepadList(sfd.FileName);
                database.Save();
            }
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            if (database == null)
            {
                MessageBox.Show("Откройте сохраненный файл или создайте новый", "Сообщение");
                return;
            }

            database.Add(noteTextBox.Text, dateTimeNote.Value);
            counterUpDown.Maximum = database.Count;
            counterUpDown.Value = database.Count;
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            if (counterUpDown.Maximum == 1 || database == null)
                return;

            database.Remove((int)counterUpDown.Value);
            counterUpDown.Maximum--;

            if (counterUpDown.Value > 1)
                counterUpDown.Value = counterUpDown.Maximum;
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
                database = new NotepadList(ofd.FileName);
                database.Load();

                counterUpDown.Maximum = database.Count;
                counterUpDown.Value = 1;
            }
        }
    }
}
