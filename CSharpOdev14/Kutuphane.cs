using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpOdev14
{
    //C# dilinde bir class (sınıf), bir nesnenin yapısını tanımlayan bir şablondur. Sınıflar, nesne yönelimli programlamanın (OOP) temel taşlarından biridir ve veri ile bu veriler üzerinde işlem yapacak metotların bir arada tutulmasını sağlar.
    internal class Kutuphane
    {

        private string _bookName;
        private string _authorName;
        private string _authorSurname;
        private int _pageNumber;
        private string _publishingHouse;
        public DateTime _registirationDate;

        // Default Constructor
        //Constructors (Yapıcılar): Bir sınıftan yeni bir nesne oluştururken kullanılan özel metotlardır. Nesnenin başlangıç durumunu ayarlar.
        public Kutuphane()
        {
            _registirationDate = DateTime.Now;
            Console.WriteLine("Kitap nesnesi oluşturuldu.");
        }

        // Alternatif Constructor
        public Kutuphane(string bookName, string authorName, string authorSurname, int pageNumber, string publishingHouse)
        {
            _bookName = bookName;
            _authorName = authorName;
            _authorName = authorSurname;
            _pageNumber = pageNumber;
            _publishingHouse = publishingHouse;
            _registirationDate = DateTime.Now;
            Console.WriteLine("Kitap nesnesi oluşturuldu.");
        }

        // Kitap bilgilerini yazdırmak için bir metot
        public void InformationPrint()
        {
            Console.WriteLine($"Kitap Adı: {_bookName}, Yazar Adı: {_authorName}, Yazar Sayadı: {_authorSurname}, Sayfa Sayısı: {_pageNumber}, Yayınevi: {_publishingHouse}, Kayıt Tarihi: {_registirationDate}");
        }


        //Property (Özellikler) : Alanlara erişim sağlamak için kullanılır.Özellikler, genellikle veriyi güvenli bir şekilde almak ve ayarlamak için kullanılır.
        public string BookName
        {
            get { return _bookName; }
            set { _bookName = value; }
        }

        public string AuthorName
        {
            get { return _authorName; }
            set { _authorName = value; }
        }

        public string AuthorSurname
        {
            get { return _authorSurname; }
            set { _authorSurname = value; }
        }

        public int PageNumber
        {
            get { return _pageNumber; }
            set { _pageNumber = value; }
        }

        public string PublishingHouse
        {
            get { return _publishingHouse; }
            set { _publishingHouse = value; }
        }

        
    }
}
