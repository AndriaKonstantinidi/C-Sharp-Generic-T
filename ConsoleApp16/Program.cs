//class Program
//{
//    static void Main(string[] args)
//    {
//        myclass<int> myInts = new myclass<int>();
//        myclass<int> myInts2 = new myclass<int>();
//        myInts.Set(1);
//        myInts2.Set(3);
//        Console.WriteLine(FindMax<int>(myInts.GetT(), myInts2.GetT()));

//        myclass<string> myString = new myclass<string>();
//        myclass<string> myString2 = new myclass<string>();

//        myString.Set("asajkdahdfa");
//        myString2.Set("hqhiaufqhfuqui");

//        Console.WriteLine(FindMax<string>(myString.GetT(), myString2.GetT()));
//    }


//    public static T FindMax<T>(T a, T b) where T : IComparable<T>
//    {
//        if (a.CompareTo(b) > 0)
//        {
//            return a;
//        }
//        else if(b.CompareTo(a) > 0)
//        {
//            return b;
//        }
//        else
//        {
//            Console.WriteLine("tolia");
//            return a;
//        }
//    }


//    public static void DisplayInfo<T>(T item, T item2, T item3) where T : IDisplayable
//    {
//        List<T> ts = new List<T>();
//        ts.Add(item);
//        item.DisPlay();
//    }


//    public interface IDisplayable
//    {
//        void DisPlay()
//        {
//            Console.WriteLine("Display");
//        }
//    }
//}



////Generics
//// T
//// Type-Safe

//public class myclass<T>
//{
//    private T Content;

//    public void Set(T item)
//    {
//        Content = item;
//    }

//    public T GetT()
//    {
//        return Content;
//    }
//}



