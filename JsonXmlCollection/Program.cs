using System;

namespace JsonXmlCollection
{
    class Program
    {
        private static Exercise1 _numberList = new Exercise1();
        private static Exercise2 _phoneNote = new Exercise2();
        private static Exercise3 _set = new Exercise3();
        static void Main(string[] args)
        {
            /*            _numberList.FillingList();
                        _numberList.PrintList();
                        _numberList.DeleteRangeValue();
                        _numberList.PrintList();
                        _phoneNote.PhoneNoteManager();*/
            _set.EnterNumber();
        }


    }
}
