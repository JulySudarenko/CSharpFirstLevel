using System;

namespace BelieveOrNotBelieve
{
    [Serializable]
    public class Question
    {
        string _text;
        bool _trueFalse;

        public string Text
        {
            get => _text;
            set => _text = value;
        }

        public bool TrueFalse
        {
            get => _trueFalse;
            set => _trueFalse = value;
        }

        public Question()
        {
        }
        public Question(string text, bool trueFalse)
        {
            _text = text;
            _trueFalse = trueFalse;
        }        

    }
}
