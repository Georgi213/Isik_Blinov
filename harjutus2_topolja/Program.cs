using harjutus2_topolja;
using System.Text;

List<Isik> inimesed = new List<Isik>();
List<Isik> inimesed2 = new List<Isik>();
String line;

Tootaja tootaja = new Tootaja("TTHK", "õpetaja", "Andrei", 1991, Isik.sugu.Mees, 500, 1100, 20);
tootaja.print_Info();
Opilane opilane = new Opilane("Pae gumnasiuum", "11a", "õpilane", "Aleksei", 2004, Isik.sugu.Mees, 0, 0, 0);
opilane.print_Info();
Kutsekooliopilane kutsekooliopilane = new Kutsekooliopilane(60,"Tallinn", 450, 3, 4.5, "THK", "tarkvara arendaja", "Tarpv20", "Georgi", 2003, Isik.sugu.Mees, 0, 0, 0);
kutsekooliopilane.print_Info();

inimesed.Add(tootaja);
inimesed.Add(opilane);
inimesed.Add(kutsekooliopilane);

StreamWriter tofile = new StreamWriter(@"..\..\..\info.txt", false);
foreach (Isik item in inimesed)
{
    Console.WriteLine(item.nimi);
    tofile.WriteLine(item.nimi+", "+ item.vanus+", "+ item.Sugu+", ");
}
tofile.Close();

List<Isik> loetudFailist = new List<Isik>();
StreamReader reader1 = new StreamReader(@"..\..\..\info.txt");
List<string> lines = new List<string>();
int n = reader1.ReadToEnd().Split(new char[] { '\n' }).Length;
Console.WriteLine("-----"+ n+"-----");

var file = File.ReadAllText(@"..\..\..\info.txt").Split(", ");
foreach (var item in file)
{
    Console.Write(item + ", ");
}