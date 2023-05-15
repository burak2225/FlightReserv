// See https://aka.ms/new-console-template for more information
using FlyTicketProject;

Airplane airp1 = new Airplane("Boeing","737-900","3/3/2023", "130");
Airplane airp2 = new Airplane("Boeing", "736-900", "3/3/2023", "120");
Airplane airp3 = new Airplane("Boeing", "735-900", "3/3/2023", "110");
Airplane airp4 = new Airplane("Airbus", "321-200", "3/3/2023", "150");
Airplane airp5 = new Airplane("Airbus", "320-200", "3/3/2023", "140");

Console.WriteLine("Merhaba, Rezervasyon işlemi için ülke giriniz... ");
string ulk = Console.ReadLine();
Console.WriteLine("Gitmek istediğiniz şehri giriniz... ");
string shr = Console.ReadLine();
Console.WriteLine("İstanbul üzerinden bir havalimanı seçiniz(sayı ile)\n1-Sabiha Gökçen Havalimanı\n2-Atatürk Havalimanı");
string hvl = Console.ReadLine(); 
Location lctn = new Location(ulk, shr, hvl);


Console.WriteLine("15.06.2023 tarihli 13.15 uçuşu bulunmaktadır, rezervasyon yapmak istiyor musunuz?(evet/hayır) ");
string cvp = Console.ReadLine();
if (cvp == "evet")
{
    if (hvl == "1")
    {
        Console.WriteLine("İsminizi giriniz");
        string ism = Console.ReadLine();
        Console.WriteLine("Cinsiyetiniz (E-0 / K-1) ");
        string cinsyt = Console.ReadLine();
        bool cins = true;
        if (cinsyt == "0")
        {
            cinsyt = "true";
            cins = Convert.ToBoolean(cinsyt);

        }

        else if (cinsyt == "1")
        {
            cinsyt = "false";
            cins = Convert.ToBoolean(cinsyt);
        }
        Console.WriteLine("Yaşınızı giriniz ");
        int ys = Convert.ToInt32(Console.ReadLine());
        bool ysli = true;
        if (ys > 64)
        { ysli = true; }
        else { ysli = false; }
        Console.WriteLine("Herhangi bir engeliniz bulunuyor mu? (Evet-1 / Hayır-0)");
        string engll = Console.ReadLine();
        bool engl = true;
        if (engll == "1")
        {
            engll = "true";
            engl = Convert.ToBoolean(engll);
        }
        else if (engll == "false")
        {
            engll = "false";
            engl = Convert.ToBoolean(engll);
        }

        Customer mstr = new Customer(ism, cins, ys, ysli, engl);

        Reservation bilet = new Reservation(airp5, lctn, mstr, "15.06.2023", "17");
        Console.WriteLine("15.06.2023 saat 13.15 zamanlı uçuşunuz " + ism + " adına oluşturulmuştur. Koltuk numaranız-17, İyi günler dileriz. ");
    }
    else
    {
        Console.WriteLine("İsminizi giriniz");
        string ism = Console.ReadLine();
        Console.WriteLine("Cinsiyetiniz (E-0 / K-1) ");
        string cinsyt = Console.ReadLine();
        bool cins = true;
        if (cinsyt =="0")
        { cinsyt = "true";
         cins = Convert.ToBoolean(cinsyt);
            
        }
        
        else if (cinsyt=="1") 
        {
            cinsyt = "false";
            cins = Convert.ToBoolean(cinsyt);
        }
        Console.WriteLine("Yaşınızı giriniz ");
        int ys = Convert.ToInt32(Console.ReadLine());
        bool ysli = true;
        if (ys > 64)
        { ysli = true; }
        else {ysli = false; }
        Console.WriteLine("Herhangi bir engeliniz bulunuyor mu? (Evet-1 / Hayır-0)");
        string engll = Console.ReadLine();
        bool engl = true;
        if (engll == "1")
        {
            engll = "true";
            engl = Convert.ToBoolean(engll);
        }
        else if (engll == "false")
        {
            engll    = "false";
            engl = Convert.ToBoolean(engll);
        }

        Customer mstr = new Customer(ism, cins, ys, ysli, engl);

        Reservation bilet = new Reservation(airp5, lctn, mstr, "15.06.2023", "17");
        Console.WriteLine("15.06.2023 saat 13.15 zamanlı uçuşunuz " + ism + " adına oluşturulmuştur. Koltuk numaranız-17, İyi günler dileriz. ");
    }
}
else
{
    Console.WriteLine("Malesef henüz uygun uçuş bulunmuyor.");
}