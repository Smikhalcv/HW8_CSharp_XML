using System;

namespace JsonXmlCollection
{
    class Program
    {
        private static Exercise1 numberList = new Exercise1();
        private static Exercise2 PhoneNote = new Exercise2();
        static void Main(string[] args)
        {
            /*numberList.FillingList();
            numberList.PrintList();
            numberList.DeleteRangeValue();
            numberList.PrintList();*/
            PhoneNote.AddContact();
            PhoneNote.ReadPhoneNote();
        }


    }
}
