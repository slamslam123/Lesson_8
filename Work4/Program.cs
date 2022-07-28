using System;
using System.Xml.Linq;
namespace Work4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите ф.и.о: ");
            string fullName = Console.ReadLine();
            Console.WriteLine("Введите Улицу: ");
            string street = Console.ReadLine();
            Console.WriteLine("Введите Номер дома: ");
            string houseNumber = Console.ReadLine();
            Console.WriteLine("Введите Номер квартиры: ");
            string flatNumber = Console.ReadLine();
            Console.WriteLine("Введите Мобильный телефон: ");
            string mobilePhone = Console.ReadLine();
            Console.WriteLine("Введите Домашний телефон: ");
            string flatPhone = Console.ReadLine();
            XElement myPERSON = new XElement("Person");
            XElement myADDRESS = new XElement("Address");
            XElement myPHONES = new XElement("Phones");
            XElement myHOUSENUMBER = new XElement("HouseNumber");
            XElement myFLATNUMBER = new XElement("FlatNumber");
            XElement mySTREET = new XElement("Street");
            XElement myFLATPHONE = new XElement("FlatPhone");
            XElement myMOBILEHONE = new XElement("MobilePhone");
            XAttribute xFullName = new XAttribute("FullName", fullName);
            myPERSON.Add(myADDRESS, myPHONES, xFullName);
            myADDRESS.Add(mySTREET, myHOUSENUMBER, myFLATNUMBER);
            mySTREET.Add(street);
            myHOUSENUMBER.Add(houseNumber);
            myFLATNUMBER.Add(flatNumber);
            myPHONES.Add(myFLATPHONE, myMOBILEHONE);
            myFLATPHONE.Add(flatPhone);
            myMOBILEHONE.Add(mobilePhone);
            myPERSON.Save("data.xml");
        }
    }
}