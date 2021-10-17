using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace JsonXmlCollection
{
    class Exercise2
    {
        private Dictionary<string, string> _phoneNote = new Dictionary<string, string>();

        /// <summary>
        /// Разбивает строку на массив строк и складывает заново, 
        /// заменяя на высокий регистр каждую первую букву элемента массива  
        /// </summary>
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

        /// <summary>
        /// Запрашивает номер телефона определённого образца,
        /// прив одя его к определённому виду
        /// </summary>
        /// <returns>строковое представление номера телефона</returns>
        private string? EnterPhone()
        {
            string patternPhoneNumber1 = @"[+][0-9]{3}[(][0-9]{2}[)][-]([0-9]{3}[-][0-9]{2}[-][0-9]{2})";
            string patternPhoneNumber2 = @"[0-9]{3}[-][0-9]{2}[-][0-9]{2}";
            string patternPhoneNumber3 = @"[+]([0-9]{3})([0-9]{2})([0-9]{2})";
            string patternPhoneNumber4 = @"([0-9]{3})([0-9]{2})([0-9]{2})";
            string _numberPhone = "";
            Console.WriteLine("Укажите номер телефона в формате +111(11)-111-11-11, 111-11-11, +1111111 или 1111111\n" +
                "или введите пустую строку чтоб закончить добавление контактов.");
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

        /// <summary>
        /// Создаёт и возвращает массив строк из номера телефона и имени контакта
        /// </summary>
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

        private void AddContact()
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

        private void ReadPhoneNote()
        {
            foreach (string key in _phoneNote.Keys)
            {
                PrintContect(key);
            }
        }

        private void SelectContact()
        {
            string? phone = EnterPhone();
            if (phone != null)
            {
                PrintContect(phone);
            }
            else
            {
                Console.WriteLine("Контакта с таким номером не зарегистрировано.");
            }
        }

        private void PrintContect(string numberPhone)
        {
            Console.WriteLine($"Номер телефона {numberPhone, 13}");
            Console.WriteLine($"Имя контакта {_phoneNote[numberPhone]}");
        }

        public void PhoneNoteManager()
        {
            Console.WriteLine("Добро пожаловать в телефонную книгу!");
            bool flag = true;
            while (flag)
            {
                Console.WriteLine($"Количество контактов - {_phoneNote.Count}");
                Console.WriteLine("Выберите действие-");
                Console.WriteLine("1 - просмотреть все контакты;\n" +
                    "2 - добавить контакт;\n" +
                    "3 - просмотреть выбранный контакт по номеру телефона;\n" +
                    "4 - выйти из телефонной книги.");
                string mode = Console.ReadLine();
                switch (mode)
                {
                    case "1":
                        ReadPhoneNote();
                        break;
                    case "2":
                        AddContact();
                        break;
                    case "3":
                        SelectContact();
                        break;
                    case "4":
                        flag = false;
                        break;
                }
            }
        }
    }
}
