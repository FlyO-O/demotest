using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace ConsoleApplication1
{
    public static class ListExtends
    {
        public static List<T> MyAdd<T>(this List<T> source, T item)
        {
            source.Add(item);
            return source;
        }
    }

    public class Test
    {
        public static void MethodA(Func<string, int> call)
        {
            Console.WriteLine(call.Invoke("hello"));
        }

        public static void MethodA(Func<string> call)
        {
            Console.WriteLine(call.Invoke());
        }

        public static void MethodA(Action<string> call)
        {
            call.Invoke("hello");
        }
    }

    //class Program
    //{
    //    static void Main(string[] args)
    //    {
    //        var no = new { Id = 0, Name = "hello", Address = "China" };
    //        var li = new[] { "abc", "efg", "kkkk" };
    //        Test.MethodA(a =>
    //        {
    //            return a.Length;
    //        });
    //        Test.MethodA(() => "world");
    //        Console.ReadLine();

    //    }
    //}

    //实例
    //// A traditional enumeration of some root vegetables.
    //public enum SomeRootVegetables
    //{
    //    HorseRadish,
    //    Radish,
    //    Turnip
    //}

    //// A bit field or flag enumeration of harvesting seasons.
    //[Flags]
    //public enum Seasons
    //{
    //    None = 0,
    //    Summer = 1,
    //    Autumn = 2,
    //    Winter = 4,
    //    Spring = 8,
    //    All = Summer | Autumn | Winter | Spring
    //}

    //public class Example
    //{
    //    public static void Main()
    //    {
    //        // Hash table of when vegetables are available.
    //        Dictionary<SomeRootVegetables, Seasons> AvailableIn = new Dictionary<SomeRootVegetables, Seasons>();

    //        AvailableIn[SomeRootVegetables.HorseRadish] = Seasons.All;
    //        AvailableIn[SomeRootVegetables.Radish] = Seasons.Spring;
    //        AvailableIn[SomeRootVegetables.Turnip] = Seasons.Spring |
    //             Seasons.Autumn;

    //        // Array of the seasons, using the enumeration.
    //        Seasons[] theSeasons = new Seasons[] { Seasons.Summer, Seasons.Autumn, 
    //        Seasons.Winter, Seasons.Spring };

    //        // Print information of what vegetables are available each season.
    //        foreach (Seasons season in theSeasons)
    //        {
    //            Console.Write(String.Format(
    //                "The following root vegetables are harvested in {0}:\n",
    //                season.ToString("G")));
    //            foreach (KeyValuePair<SomeRootVegetables, Seasons> item in AvailableIn)
    //            {
    //                // A bitwise comparison.
    //                if (((Seasons)item.Value & season) > 0)
    //                    Console.Write(String.Format("  {0:G}\n",
    //                         (SomeRootVegetables)item.Key));
    //            }
    //        }
    //    }
    //}


    //[assembly: CLSCompliant(true)]

    //public class Outer<T>
    //{
    //    T value;

    //    public Outer(T value)
    //    {
    //        this.value = value;
    //    }

    //    public class Inner1A : Outer<T>
    //    {
    //        public Inner1A(T value)
    //            : base(value)
    //        { }
    //    }

    //    public class Inner1B<U> : Outer<T>
    //    {
    //        U value2;

    //        public Inner1B(T value1, U value2)
    //            : base(value1)
    //        {
    //            this.value2 = value2;
    //        }
    //    }
    //}

    //public class Example
    //{
    //    public static void Main()
    //    {
    //        var inst1 = new Outer<String>("This");
    //        Console.WriteLine(inst1);

    //        var inst2 = new Outer<String>.Inner1A("Another");
    //        Console.WriteLine(inst2);

    //        var inst3 = new Outer<String>.Inner1B<int>("That", 2);
    //        Console.WriteLine(inst3);
    //    }
    //}

    //class MainClass
    //{
    //    static void Main()
    //    {
    //        MailToData MyData = new MailToData();

    //        Console.Write("Enter Your Name: ");
    //        MyData.Name = Console.ReadLine();
    //        Console.Write("Enter Your Address: ");
    //        MyData.Address = Console.ReadLine();
    //        Console.Write("Enter Your City, State, and ZIP Code separated by spaces: ");
    //        MyData.CityStateZip = Console.ReadLine();
    //        Console.WriteLine();

    //        if (MyData.Validated)
    //        {
    //            Console.WriteLine("Name: {0}", MyData.Name);
    //            Console.WriteLine("Address: {0}", MyData.Address);
    //            Console.WriteLine("City: {0}", MyData.City);
    //            Console.WriteLine("State: {0}", MyData.State);
    //            Console.WriteLine("Zip: {0}", MyData.Zip);

    //            Console.WriteLine("\nThe following address will be used:");
    //            Console.WriteLine(MyData.Address);
    //            Console.WriteLine(MyData.CityStateZip);
    //        }
    //    }
    //}

    //public class MailToData
    //{
    //    string name = "";
    //    string address = "";
    //    string citystatezip = "";
    //    string city = "";
    //    string state = "";
    //    string zip = "";
    //    bool parseSucceeded = false;

    //    public string Name
    //    {
    //        get { return name; }
    //        set
    //        {
    //            if (value.Length > 5)
    //            {
    //                name = value;
    //            }
    //            else
    //            {
    //                name = "aaaaa";
    //            }
    //        }
    //    }

    //    public string Address
    //    {
    //        get { return address; }
    //        set { address = value; }
    //    }

    //    public string CityStateZip
    //    {
    //        get
    //        {
    //            return String.Format("{0}, {1} {2}", city, state, zip);
    //        }
    //        set
    //        {
    //            citystatezip = value.Trim();
    //            ParseCityStateZip();
    //        }
    //    }

    //    public string City
    //    {
    //        get { return city; }
    //        set { city = value; }
    //    }

    //    public string State
    //    {
    //        get { return state; }
    //        set { state = value; }
    //    }

    //    public string Zip
    //    {
    //        get { return zip; }
    //        set { zip = value; }
    //    }

    //    public bool Validated
    //    {
    //        get { return parseSucceeded; }
    //    }

    //    private void ParseCityStateZip()
    //    {
    //        string msg = "";
    //        const string msgEnd = "\nYou must enter spaces between city, state, and zip code.\n";

    //        // Throw a FormatException if the user did not enter the necessary spaces
    //        // between elements. 
    //        try
    //        {
    //            // City may consist of multiple words, so we'll have to parse the 
    //            // string from right to left starting with the zip code.
    //            int zipIndex = citystatezip.LastIndexOf(" ");
    //            if (zipIndex == -1)
    //            {
    //                msg = "\nCannot identify a zip code." + msgEnd;
    //                throw new FormatException(msg);
    //            }
    //            zip = citystatezip.Substring(zipIndex + 1);

    //            int stateIndex = citystatezip.LastIndexOf(" ", zipIndex - 1);
    //            if (stateIndex == -1)
    //            {
    //                msg = "\nCannot identify a state." + msgEnd;
    //                throw new FormatException(msg);
    //            }
    //            state = citystatezip.Substring(stateIndex + 1, zipIndex - stateIndex - 1);
    //            state = state.ToUpper();

    //            city = citystatezip.Substring(0, stateIndex);
    //            if (city.Length == 0)
    //            {
    //                msg = "\nCannot identify a city." + msgEnd;
    //                throw new FormatException(msg);
    //            }
    //            parseSucceeded = true;
    //        }
    //        catch (FormatException ex)
    //        {
    //            Console.WriteLine(ex.Message);
    //        }
    //    }

    //    private string ReturnCityStateZip()
    //    {
    //        // Make state uppercase.
    //        state = state.ToUpper();

    //        // Put the value of city, state, and zip together in the proper manner.
    //        string MyCityStateZip = String.Concat(city, ", ", state, " ", zip);

    //        return MyCityStateZip;
    //    }
    //}
    public class Generic<T>
    {
        public T Field;
    }

    public class example
    {
        public static void Main()
        {
            Generic<string> g = new Generic<string>();
            g.Field = "A string";
            //...
            Console.WriteLine("Generic.Field           = \"{0}\"", g.Field);
            Console.WriteLine("Generic.Field.GetType() = {0}", g.Field.GetType().FullName);
        }
    }

}
