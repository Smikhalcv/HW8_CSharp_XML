using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Linq;

namespace JsonXmlCollection
{
    class Exercise4
    {
        private NotebookEx4 _user;

        public void CrateXML()
        {
            _user = UserCreate();

            XElement person = new XElement("Person");
            XElement address = new XElement("Address");
            XElement street = new XElement("Street", _user.Street);
            XElement houseNumber = new XElement("HouseNumber", _user.NumberHouse);
            XElement flatNumber = new XElement("FlatNumber", _user.NumberApartment);
            XElement phones = new XElement("Phones");
            XElement mobilePhone = new XElement("MobilePhone", _user.NumberPhone);
            XElement flatPhone = new XElement("FlatMobile", _user.NumberHomePhone);
            XAttribute userName = new XAttribute("name", _user.Name);

            address.Add(street, houseNumber, flatNumber);
            phones.Add(mobilePhone, flatPhone);
            person.Add(address, phones, userName);

            RecordFileXml(person);
            Console.WriteLine(person);
        }

        private NotebookEx4 UserCreate()
        {
            Console.WriteLine("Создание пользователя!");
            Console.WriteLine("Укажите ФИО пользователя");
            string userName = Console.ReadLine();
            Console.WriteLine("Укажите адрес пользователя");
            Console.WriteLine("Улица - ");
            string street = Console.ReadLine();
            Console.WriteLine("Новер дома - ");
            string houseNumber = Console.ReadLine();
            int houseNumberInt;
            while (true)
            {
                try
                {
                    houseNumberInt = Convert.ToInt32(houseNumber);
                    break;
                }
                catch (Exception)
                {
                    Console.WriteLine("Укачижите целое число");
                    throw;
                }
            }
            Console.WriteLine("Номер квартиры - ");
            string flatNumber = Console.ReadLine();
            int flatNumberInt;
            while (true)
            {
                try
                {
                    flatNumberInt = Convert.ToInt32(flatNumber);
                    break;
                }
                catch (Exception)
                {
                    Console.WriteLine("Укачижите целое число");
                    throw;
                }
            }
            Console.WriteLine("Укажите телефоны пользователя");
            Console.WriteLine("Мобильный - ");
            string mobilePhone = Console.ReadLine();
            Console.WriteLine("Домашний - ");
            string flatPhone = Console.ReadLine();
            NotebookEx4 user = new NotebookEx4(userName, street, houseNumberInt, flatNumberInt, mobilePhone, flatPhone);
            return user;
        }

        private void RecordFileXml(XElement xmlData)
        {
            string path;
            Console.WriteLine("Укажите путь к файлу");
            path = Console.ReadLine();
            if (!path.EndsWith(".xml"))
            {
                path += ".xml";
            }
            xmlData.Save(path);
            Console.WriteLine("Файл сохранён!");
        }
    }
}
