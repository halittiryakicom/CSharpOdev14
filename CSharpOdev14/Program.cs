
using CSharpOdev14;

//new anahtar kelimesi, bir sınıfın yapıcı metodunu (constructor) çağırarak bellekte yeni bir nesne oluşturur ve bu nesneye bir referans döner. Bu referans, nesneye ulaşmak için kullanılır.

// Default Constructor ile kitap nesnesi oluşturma
Kutuphane book1 = new Kutuphane();
book1.BookName = "Aylin";
book1.AuthorName = "Ayşe";
book1.AuthorSurname = "Kulin";
book1.PageNumber = 398;
book1.InformationPrint();


// Alternatif Constructor ile kitap nesnesi oluşturma
Kutuphane book2 = new Kutuphane("Aylin", "Ayşe", "Kulin", 398, "Remzi Kitabevi");
book2.InformationPrint();