using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.IO;
using System.Xml.Serialization;

namespace BelieveOrNotBelieve
{
    class TrueFalse
    {
        string _fileName;
        List<Question> list;
        
        public string FileName
        {
            set => _fileName = value;
        }
        
        public TrueFalse(string fileName)
        {
            _fileName = fileName;
            list = new List<Question>();
        }
        
        public void Add(string text, bool trueFalse)
        {
            list.Add(new Question(text, trueFalse));
        }
        
        public void Remove(int index)
        {
            if (list != null && index < list.Count && index >= 0) list.RemoveAt(index);
        }

        public Question this[int index]
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
                XmlSerializer xmlFormat = new XmlSerializer(typeof(List<Question>));
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
                XmlSerializer xmlFormat = new XmlSerializer(typeof(List<Question>));
                Stream fStream = new FileStream(_fileName, FileMode.Open, FileAccess.Read);
                list = (List<Question>)xmlFormat.Deserialize(fStream);
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

