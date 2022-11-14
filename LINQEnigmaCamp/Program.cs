//class Program
//{
//    static void Main()
//    {
//        var nums = new int[] { 3, 1, 3, 4, 2 };
//        var result = FindDuplicate.findDuplicate(nums);

//        Console.WriteLine($"Result : {result}");

//        var resultLINQ = FindDuplicate.findDuplicateLINQ(nums);
//        Console.WriteLine($"Result LINQ: {resultLINQ}");
//    }
//}

//class FindDuplicate
//{
//    public static int findDuplicate(int[] nums)
//    {
//        var nilai_1 = nums[0];
//        var nilai_2 = nums[0];

//        while (true)
//        {
//            nilai_1 = nums[nilai_1];
//            nilai_2 = nums[nums[nilai_2]];

//            if (nilai_1 == nilai_2)
//                break;
//        }

//        var ptr1 = nums[0];
//        var ptr2 = nilai_1;

//        while (ptr1 != ptr2)
//        {
//            ptr1 = nums[ptr1];
//            ptr2 = nums[ptr2];
//        }

//        return ptr1;
//    }

//    public static int findDuplicateLINQ(int[] nums)
//    {
//        var qryDuplicate = nums.GroupBy(x => x)
//            .Where(x => x.Count() > 1)
//            .Select(x => x)
//            .ToList();

//        var result = qryDuplicate.FirstOrDefault();
//        return result.ElementAt(0);
//    }

//    //<App> <---> LINQ <---> ADO .NET <---> Data Provider <---> DataSource/DB
//}

class Program
{
    static void Main()
    {
        int[] fibb = { 0, 1, 1, 2, 3, 5 };
        int fibbCount = fibb.Count();
        Console.WriteLine($"Fibb Count : {fibbCount}");

        IEnumerable<int> distinctFibb = fibb.Distinct(); // SELECT DISTINCT Fields....
        foreach(var num in distinctFibb)
        {
            Console.WriteLine($"{num}");
        }
    }
}