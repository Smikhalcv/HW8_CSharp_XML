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

        private string? EnterPhone()
        {
            string patternPhoneNumber1 = @"[+][0-9]{3}[(][0-9]{2}[)][-]([0-9]{3}[-][0-9]{2}[-][0-9]{2})";
            string patternPhoneNumber2 = @"[0-9]{3}[-][0-9]{2}[-][0-9]{2}";
            string patternPhoneNumber3 = @"[+]([0-9]{3})([0-9]{2})([0-9]{2})";
            string patternPhoneNumber4 = @"([0-9]{3})([0-9]{2})([0-9]{2})";
            string _numberPhone = "";
            Console.WriteLine("Укажите номер телефона в формате +111(11)-111-11-11, 111-11-11, +1111111 или 1111111");
            string _phone = Console.ReadLine();
            if (_phone == "")
            {
                Console.WriteLine("Ввод закончен!");
                return null;
            }
            if (Regex.IsMatch(_phone, patternPhoneNumber1))
            {
                foreach (Match? match in Regex.Matches(_phone, patternPhoneNumber1))
                {
                    _numberPhone = match.Groups[1].Value;
                }
            }
            else if (Regex.IsMatch(_phone, patternPhoneNumber2))
            {
                _numberPhone = _phone;
            }
            else if (Regex.IsMatch(_phone, patternPhoneNumber3))
            {
                foreach (Match? match in Regex.Matches(_phone, patternPhoneNumber3))
                {
                    _numberPhone = match.Groups[1].Value + "-" + match.Groups[2].Value + "-" + match.Groups[3].Value;
                }
            }
            else if (Regex.IsMatch(_phone, patternPhoneNumber4))
            {
                foreach (Match? match in Regex.Matches(_phone, patternPhoneNumber4))
                {
                    _numberPhone = match.Groups[1].Value + "-" + match.Groups[2].Value + "-" + match.Groups[3].Value;
                }
            }
            else
            {
                Console.WriteLine("Неверный формат!");
                return null;
            }
            return _numberPhone;
        }

        private string[]? EnterContact()
        {
            string? _numberPhone = EnterPhone();
            string[] _arrayPhoneName = new string[2];
            if (_numberPhone != null)
            {
                _arrayPhoneName[0] = _numberPhone;
            }
            else
            {
                return null;
            }
            Console.WriteLine("Укажите имя контакта -");
            _arrayPhoneName[1] = Capitalize(Console.ReadLine());

            return _arrayPhoneName;
        }

        public void AddContact()
        {
            bool flag = true;
            while (flag)
            {
                string[]? newContact = EnterContact();
                if (newContact != null)
                {
                    _phoneNote.Add(newContact[0], newContact[1]);
                }
                else
                {
                    flag = false;
                }
            }
        }

        public void ReadPhoneNote()
        {
            foreach (KeyValuePair<string, string> phoneNote in _phoneNote)
            {
                Console.WriteLine($"{phoneNote.Key} - {phoneNote.Value}");
            }
        }

        public void SelectContact()
        {

        }
    }
}
