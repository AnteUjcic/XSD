using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace ispi4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("upisite naslov: ");
            string naslov=Console.ReadLine();
            Console.WriteLine("upisite ID: ");
            string IDKnjige = Console.ReadLine();
            Console.WriteLine("upisite datum posudbe(DD/MM/YYYY): ");
            string datumPosudbe = Console.ReadLine();
           
            Console.WriteLine("upisite cjenu");
            string cjena = Console.ReadLine();
            XmlWriterSettings settings1 = new XmlWriterSettings();
            settings1.Indent = true;
            settings1.IndentChars = "\t";
            using (XmlWriter book = XmlWriter.Create("knjige.xsd", settings1))
            {
                book.WriteStartElement("Book");
                book.WriteElementString("Naslov", naslov);
                book.WriteElementString("ID", IDKnjige);
                book.WriteElementString("DatumPosudbe", datumPosudbe);

                book.WriteElementString("Cjena", cjena);
                book.WriteEndElement();
                book.Flush();
            }
            Console.WriteLine("Upisivanje za user");
            Console.WriteLine("upisite ID posuditelja: ");
            string IDusera = Console.ReadLine();
            Console.WriteLine("upisite prezime: ");
            string ime = Console.ReadLine();
            Console.WriteLine("upisite ime: ");
            string prezime = Console.ReadLine();
            Console.WriteLine("upisite broj telefona: ");
            string kontakt = Console.ReadLine();
            XmlWriterSettings settings = new XmlWriterSettings();
            settings.Indent = true;
            settings.IndentChars = "\t";
            using (XmlWriter user = XmlWriter.Create("user.xsd", settings))
            {
                user.WriteStartElement("User");
                user.WriteElementString("ID", IDusera);
                user.WriteElementString("Ime", ime);
                user.WriteElementString("prezime", prezime);
                user.WriteElementString("kontakt", kontakt);
                user.WriteEndElement();
                user.Flush();
            }

        }
    }
}

