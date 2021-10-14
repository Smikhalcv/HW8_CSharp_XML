using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace JsonXmlCollection
{
    class Exercise2
    {
        private Dictionary<string, string> _phoneNote = new Dictionary<string, string>();

        private string Capitalize(string rawString)
        {
            string result = "";
            string[] arrayRawString = rawString.ToLower().Split();
            for (int i = 0; i < arrayRawString.Length; i++)
            {
                result += arrayRawString[i][0].ToString().ToUpper() + arrayRawString[i].Substring(1) + " ";
            }
            return result.Trim();
        }

        private string[]? EnterPhoneName()
        {
            string patternPhoneNumber1 = @"[+][0-9]{3}[(][0-9]{2}[)][-][0-9]{3}[-][0-9]{2}[-][0-9]{2}";
            string patternPhoneNumber2 = @"[0-9]{3}[-][0-9]{2}[-][0-9]{2}";
            string patternPhoneNumber3 = @"[+][0-9]*";
            string patternPhoneNumber4 = @"[0-9]*";
            string[] _phoneName = new string[2];
            Console.WriteLine("Укажите номер телефона в формате +111(11)-111-11-11, 111-11-11, +1111111 или 1111111");
            string _phone = Console.ReadLine();
            if (_phone == "")
            {
                return null;
            }
            if (Regex.IsMatch(_phone, patternPhoneNumber1) ||
                Regex.IsMatch(_phone, patternPhoneNumber2) ||
                Regex.IsMatch(_phone, patternPhoneNumber3) ||
                Regex.IsMatch(_phone, patternPhoneNumber4))
            {
                _phoneName[0] = _phone;
            }
            else
            {
                Console.WriteLine("Неверный формат!");
                return null;
            }
            Console.WriteLine("Укажите имя контакта -");
            _phoneName[1] = Capitalize(Console.ReadLine());

            return _phoneName;
        }

        public void AddContact()
        {
            bool flag = true;
            while (flag)
            {
                string[]? newContact = EnterPhoneName();
                if (newContact != null)
                {
                    _phoneNote.Add(newContact[0], newContact[1]);
                }
                else
                {
                    flag = false;
                }
            }
            Console.WriteLine("Ввод закончен!");
        }

        public void ReadPhoneNote()
        {
            foreach (KeyValuePair<string, string> phoneNote in _phoneNote)
            {
                Console.WriteLine($"{phoneNote.Key} - {phoneNote.Value}");
            }
        }
    }
}
