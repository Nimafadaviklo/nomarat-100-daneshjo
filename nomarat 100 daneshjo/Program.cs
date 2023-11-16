// See https://aka.ms/new-console-template for more information
using System.Data.Common;
using System.Threading.Channels;
نیما فدوی پروژه ۷
List<student> students = new List<student>();

StreamReader reader = new StreamReader(@"C:\\Users\\persian\\Desktop\stuuuuuuu.txt");



while (!reader.EndOfStream)
{
    string line = reader.ReadLine();
    student daneshjo = new student();
    daneshjo.firstname = line.Split(',')[0];


    daneshjo.mathnomre = Convert.ToDouble(line.Split(',')[1]);
    daneshjo.pishrafte1 = Convert.ToDouble(line.Split(',')[2]);
    daneshjo.pishrafte2 = Convert.ToDouble(line.Split(',')[3]);
    daneshjo.tafsir = Convert.ToDouble(line.Split(',')[4]);
    daneshjo.kargah = Convert.ToDouble(line.Split(',')[5]);
    daneshjo.sistemamel = Convert.ToDouble(line.Split(',')[6]);
    daneshjo.algoritm = Convert.ToDouble(line.Split(',')[7]);
    daneshjo.varzesh = Convert.ToDouble(line.Split(',')[8]);
    daneshjo.zaban = Convert.ToDouble(line.Split(',')[9]);
    daneshjo.sheygrayi = Convert.ToDouble(line.Split(',')[10]);

    students.Add(daneshjo);
}
bool exit = false;
do
{
    Console.WriteLine("inter number1 for moshakhasat");
    Console.WriteLine("inter number2 for moadel hame");
    Console.WriteLine("inter number3 for moadelekhtesasi");
    Console.WriteLine("inter number4 for moadel omomi");
    Console.WriteLine("inter number5 for moadel mokamel");
    Console.WriteLine("inter number6 for greadbandi");
    Console.WriteLine("inter number7 for adad aval");
    Console.WriteLine("inter number 8 for exit");
    int n = Convert.ToInt32(Console.ReadLine());
    if (n == 1)
    {
        foreach (var daneshjo in students)
        {
            Console.WriteLine("moshakhasat:");
            Console.WriteLine(daneshjo.firstname);
            Console.WriteLine(":");
            Console.WriteLine("moadel hame:");
            Console.WriteLine((Math.Round(daneshjo.moadelhame(), 2)));
            Console.WriteLine("moadel dros takhasosi:");
            Console.WriteLine(daneshjo.moadeltakhasosi());
            Console.WriteLine("moadl dros mokamel:");
            Console.WriteLine(daneshjo.moadelmokamel());
            Console.WriteLine("moadel dros omomi:");
            Console.WriteLine(daneshjo.moadelomomi());
            Console.WriteLine("--------------------------------------------------------");
        }

    }
    else if (n == 2)
    {
        foreach (var daneshjo in students)
        {
            Console.WriteLine(daneshjo.firstname);
            Console.WriteLine("=");
            Console.WriteLine((Math.Round(daneshjo.moadelhame(), 2)));

            Console.WriteLine("----------------------------------------");


        }
    }
    else if (n == 3)
    {
        foreach (var daneshjo in students)
        {
            Console.WriteLine(daneshjo.firstname);
            Console.WriteLine("moadeltakhasosi:");
            Console.WriteLine("=");
            Console.WriteLine((Math.Round(daneshjo.moadeltakhasosi(), 2)));

            Console.WriteLine("----------------------------------");
        }
    }
    else if (n == 4)
    {
        foreach (var daneshjo in students)
        {
            Console.WriteLine(daneshjo.firstname);
            Console.WriteLine("moadel mokamel");
            Console.WriteLine("=");
            Console.WriteLine((Math.Round(daneshjo.moadelmokamel(), 2)));

            Console.WriteLine("-------------------------------------------");

        }
    }
    else if (n == 5)
    {
        foreach (var daneshjo in students)
        {
            Console.WriteLine(daneshjo.firstname);
            Console.WriteLine("moadel omomi");
            Console.WriteLine("=");
            Console.WriteLine((Math.Round(daneshjo.moadelomomi(), 2)));

            Console.WriteLine("-----------------------------------");

        }
    }
    else if (n == 6)
    {
        foreach (var daneshjo in students)
        {
            Console.WriteLine("gread bandi");
            Console.WriteLine("=");
            // Console.WriteLine((daneshjo.GREAD((Math.Round(daneshjo.moadelhame(),  2)))));
            Console.WriteLine("-------------------------------------");

        }
    }
    else if (n == 7)
    {
        foreach (var daneshjo in students)
        {
            daneshjo.adadaval(Convert.ToInt32(daneshjo.pishrafte1));
            daneshjo.adadaval(Convert.ToInt32(daneshjo.varzesh));
            daneshjo.adadaval(Convert.ToInt32(daneshjo.zaban));
            daneshjo.adadaval(Convert.ToInt32(daneshjo.tafsir));
            daneshjo.adadaval(Convert.ToInt32(daneshjo.algoritm));
            daneshjo.adadaval(Convert.ToInt32(daneshjo.sistemamel));
            daneshjo.adadaval(Convert.ToInt32(daneshjo.pishrafte2));
            daneshjo.adadaval(Convert.ToInt32(daneshjo.kargah));
            daneshjo.adadaval(Convert.ToInt32(daneshjo.sheygrayi));
            daneshjo.adadaval(Convert.ToInt32(daneshjo.mathnomre));

        }

    }
    else if (n == 8)
    {
        exit = true;
    }



} while (!exit);




class student
{
    public string firstname { get; set; }

    public double mathnomre { get; set; }
    public double pishrafte1 { get; set; }
    public double pishrafte2 { get; set; }
    public double tafsir { get; set; }
    public double kargah { get; set; }
    public double sistemamel { get; set; }
    public double algoritm { get; set; }
    public double varzesh { get; set; }
    public double zaban { get; set; }
    public double sheygrayi { get; set; }

    public double moadelhame()
    {
        return ((mathnomre * 2 + varzesh + kargah + pishrafte1 * 3 + sheygrayi * 3 + pishrafte2 * 3 + sistemamel * 3 + zaban * 2 + tafsir + algoritm * 3) / 22);

    }
    public double moadeltakhasosi()
    {
        return ((sheygrayi * 3 + pishrafte2 * 3 + algoritm * 3 + pishrafte1 * 3 + sistemamel * 3) / 15);

    }
    public double moadelomomi()
    {
        return ((varzesh + zaban * 2 + tafsir + mathnomre * 2 + kargah) / 7);

    }
    public double moadelmokamel()
    {
        return ((algoritm * 3 + sistemamel * 3) / 6);
    }

    public static string GREAD(double X)

    {
        switch (X)

        {


            case double M when (X <= 20 && X > 17):

                return "A";
                break;

            case double M when (X < 17 && X >= 15):

                return "B";

                break;
            case double M when (X < 15 && X >= 13):

                return "C";
                break;

            case double M when (X < 13 && X >= 10):

                return "D";
                break;
            case double M when (X < 10 && X >= 7):

                return "E";
                break;

            case double M when (X < 7 && X >= 3):

                return "F";
                break;


        }
        return "";
    }
    public void adadaval(int nomre)
    {
        int adad = 0;

        for (int i = 1; i < nomre; i++)
        {

            if (nomre % i == 0)
            {
                adad++;
            }

        }
        if (adad < 2 && nomre > 1)
            Console.WriteLine(nomre);
    }




}

