using System;

namespace CSharp
{    
    class SomeType
    {
        private string anotherMessage = "I'll stick around";

        void PrintIn10Minutes(Func<string> message) {}

        void PrintIn10Minutes(string message)
        {
            PrintIn10Minutes(() => message);
        }

        void PrintDefaultMessageIn10Minutes()
        {
            PrintIn10Minutes(() => anotherMessage);
        }
    }

    class SomeTypeCompiled
    {
        void PrintIn10Minutes(Func<string> message) { }

        void PrintIn10Minutes(string message)
        {
            PrintIn10Minutes(new __PrintIn10MinutesClosure__(message).Invoke);
        }

        //...
    }

    public class __PrintIn10MinutesClosure__
    {
        private string _message;

        public __PrintIn10MinutesClosure__(string message)
        {
            _message = message;
        }

        public string Invoke()
        {
            return _message;
        }
    }
}
