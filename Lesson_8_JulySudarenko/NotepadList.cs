using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.IO;
using System.Xml.Serialization;

namespace Lesson_8_JulySudarenko
{
    public class NotepadList
    {
        string _fileName;
        List<NotepadClass> list;

        public string FileName
        {
            set => _fileName = value;
        }

        public NotepadList(string fileName)
        {
            _fileName = fileName;
            list = new List<NotepadClass>();
        }

        public void Add(string text, DateTime dateNote)
        {
            list.Add(new NotepadClass(text, dateNote));
        }

        public void Remove(int index)
        {
            if (list != null && index < list.Count && index >= 0) list.RemoveAt(index);
        }

        public NotepadClass this[int index]
        {
            get => list[index];
        }

        public int Count
        {
            get => list.Count;
        }

        public void Save()
        {
            try
            {
                XmlSerializer xmlFormat = new XmlSerializer(typeof(List<NotepadClass>));
                Stream fStream = new FileStream(_fileName, FileMode.Create, FileAccess.Write);
                xmlFormat.Serialize(fStream, list);
                fStream.Close();

            }
            catch (ArgumentException e)
            {
                MessageBox.Show(e.ToString());
            }
            catch (NotSupportedException e)
            {
                MessageBox.Show(e.ToString());
            }
            catch (FileNotFoundException e)
            {
                MessageBox.Show(e.ToString());
            }
            catch (IOException e)
            {
                MessageBox.Show(e.ToString());
            }
            catch (UnauthorizedAccessException e)
            {
                MessageBox.Show(e.ToString());
            }

        }

        public void Load()
        {
            try
            {
                XmlSerializer xmlFormat = new XmlSerializer(typeof(List<NotepadClass>));
                Stream fStream = new FileStream(_fileName, FileMode.Open, FileAccess.Read);
                list = (List<NotepadClass>)xmlFormat.Deserialize(fStream);
                fStream.Close();
            }
            catch (ArgumentException e)
            {
                MessageBox.Show(e.ToString());
            }
            catch (NotSupportedException e)
            {
                MessageBox.Show(e.ToString());
            }
            catch (FileNotFoundException e)
            {
                MessageBox.Show(e.ToString());
            }
            catch (IOException e)
            {
                MessageBox.Show(e.ToString());
            }
            catch (UnauthorizedAccessException e)
            {
                MessageBox.Show(e.ToString());
            }
            catch (InvalidOperationException e)
            {
                MessageBox.Show(e.ToString());
            }
        }
    }
}
