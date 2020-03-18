using System;

namespace Lesson_8_JulySudarenko
{
    [Serializable]
    public class NotepadClass
    {
        string _text;
        DateTime _dateNote;

        public string Text
        {
            get => _text;
            set => _text = value;
        }

        public DateTime DateNote
        {
            get => _dateNote;
            set => _dateNote = value;
        }

        public NotepadClass()
        {
        }

        public NotepadClass(string text, DateTime dateNote)
        {
            _text = text;
            _dateNote = dateNote;
        }
    }
}
