// See https://aka.ms/new-console-template for more information
using Business.Concrete;
using Entities.Concrete;

Console.WriteLine("Hello, World!");

static void SelamVer()
{
    Console.WriteLine("Merhaba");
}

SelamVer();

//Bu List gibi kendi koleksiyonunu oluştur. MyList
List<string> sehirler = new List<string> { "Ankara", "İzmir", "Tekirdağ" };
sehirler.Add("İstanbul");

foreach(var sehir in sehirler)
{
    Console.WriteLine(sehir);
}

Person person = new Person();
PttManager pttManager = new PttManager(new ForeignerManager());
pttManager.GiveMask(person);
//Mac'te terminal otomatik kapanıyor kapanmaması için
while (true) ;