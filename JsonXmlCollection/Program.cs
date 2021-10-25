using System;
using System.Xml.Linq;

namespace JsonXmlCollection
{
    class Program
    {
        private static Exercise1 _numberList = new Exercise1();
        private static Exercise2 _phoneNote = new Exercise2();
        private static Exercise3 _set = new Exercise3();
        private static Exercise4 _notebook = new Exercise4();
        static void Main(string[] args)
        {
            _numberList.ExecuterExercise1();
            Console.ReadKey();
            _phoneNote.PhoneNoteManager();
            Console.ReadKey();
            _set.EnterNumber();
            Console.ReadKey();
            _notebook.CrateXML();
        }


    }
}
