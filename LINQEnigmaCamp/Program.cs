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

//class Program
//{
//    static void Main()
//    {
//        int[] fibb = { 0, 1, 1, 2, 3, 5 };
//        int fibbCount = fibb.Count();
//        Console.WriteLine($"Fibb Count : {fibbCount}");

//        IEnumerable<int> distinctFibb = fibb.Distinct(); // SELECT DISTINCT Fields....
//        foreach(var num in distinctFibb)
//        {
//            Console.WriteLine($"{num}");
//        }
//    }
//}

//class Pogram
//{
//    static void Main()
//    {
//        int[] fibb = { 0, 1, 1, 2, 3, 5 };
//        // buat query nya tapi blm di execute oleh compiler
//        IEnumerable<int> nums = fibb.Where(w => w > 2);
//        fibb[0] = 99; // assign value

//        foreach (var num in nums) // query LINQ di execute { 99, 1, 1, 2, 3, 5 }
//        {
//            Console.WriteLine($"{num}");
//        }
//    }
//}

//class Pogram
//{
//    static void Main()
//    {
//        int[] fibb = { 0, 1, 1, 2, 3, 5 };
//        // buat query nya kemudian di execute oleh compiler
//        IEnumerable<int> nums = fibb.Where(w => w > 2).ToArray();
//        fibb[0] = 99; // assign value

//        foreach (var num in nums) // query LINQ yang sudah di execute { 3, 5 }
//        {
//            Console.WriteLine($"{num}");
//        }
//    }
//}

//class Program
//{
//    static void Main()
//    {
//        // Collection string countries
//        List<string> countries = new List<string>();
//        countries.Add("India"); // assign value
//        countries.Add("USA");
//        countries.Add("Australia");
//        countries.Add("Russia");

//        // select from collection string countries
//        IEnumerable<string> result = countries.Select(x => x);
//        foreach(var country in result) // loop
//        {
//            Console.WriteLine($"{country}"); // display
//        }
//    }
//}

//class Program
//{
//    static void Main()
//    {
//        // Collection string countries
//        List<string> countries = new List<string>();
//        countries.Add("India"); // assign value
//        countries.Add("USA");
//        countries.Add("Australia");
//        countries.Add("Russia");

//        // select * from table where field like '%s%' collection string countries
//        // == != > >= <= < Logical operator bisa di taruh di clausa WHERE
//        IEnumerable<string> result = countries.Where(w => w.Contains("n")).Select(x => x);
//        foreach (var country in result) // loop
//        {
//            Console.WriteLine($"{country}"); // display
//        }
//    }
//}

//// Aggregate pada LINQ Sum, Max, Count, Min, Avg
//class Program
//{
//    static void Main()
//    {
//        int[] nums = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };

//        int total = 0;
//        for (int i = 0; i < nums.Length; i++)
//        {
//            total = total + nums[i]; // Sum menggunakan loop
//        }

//        int min = nums.Sum(); // Sum menggunakan LINQ
//        Console.WriteLine($"{min}");
//    }
//}

//class Program
//{
//    static void Main()
//    {
//        int[] nums = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };

//        int total = 0;
//        for (int i = 0; i < nums.Length; i++)
//        {
//            total = total + nums[i]; // Sum menggunakan loop
//        }

//        double result = total / nums.Length; // average menggunakan loop

//        double min = nums.Average(); // Sum menggunakan LINQ
//        Console.WriteLine($"{min}");
//    }
//}

// Sorting, Bubble Sort, InsertionSort, Quicksort, MergeSort
//class Program
//{
//    static void Main()
//    {
//        int[] nums = { 4, 3, 5, 1, 7, 2, 1, 6, 8, 9 };
//        var sortedNums = nums.OrderBy(x => x); // Ascending
//        foreach(int sortedNum in sortedNums)
//        {
//            Console.WriteLine(sortedNum);
//        }

//        List<Student> students = new List<Student>()
//        {
//            new Student(){ Name="Hanapi", Gender="Male", Subjects = new List<string>{ "C# Fundamental", "Calculus" } },
//            new Student(){ Name="Aldy", Gender="Male", Subjects = new List<string>{ "Assembly Fundamental", "Algebra" } },
//            new Student(){ Name="Rahmi", Gender="Female", Subjects = new List<string>{ "LISP Fundamental", "Algebra" } },
//            new Student(){ Name="Adib", Gender="Male", Subjects = new List<string>{ "Pascal Fundamental", "Mathematics" } },
//        };
//        Console.WriteLine("Before Order Sort");
//        foreach (var student in students)
//        {
//            Console.WriteLine($"{student.Name}");
//        }

//        var studentOrder = students.OrderBy(w => w.Name);
//        Console.WriteLine("After Order Sort");
//        foreach (var student in studentOrder)
//        {
//            Console.WriteLine($"{student.Name}");
//        }
//    }
//}

//class Student
//{
//    public string Name { get; set; }
//    public string Gender { get; set; }
//    public List<string> Subjects { get; set; }
//}

//class Program
//{
//    static void Main()
//    {
//        int[] nums = { 4, 3, 5, 1, 7, 2, 1, 6, 8, 9 };
//        var sortedNums = nums.OrderByDescending(x => x);
//        foreach (int sortedNum in sortedNums)
//        {
//            Console.WriteLine(sortedNum);
//        }

//        List<Student> students = new List<Student>()
//        {
//            new Student(){ Name="Hanapi", Gender="Male", Subjects = new List<string>{ "C# Fundamental", "Calculus" } },
//            new Student(){ Name="Aldy", Gender="Male", Subjects = new List<string>{ "Assembly Fundamental", "Algebra" } },
//            new Student(){ Name="Rahmi", Gender="Female", Subjects = new List<string>{ "LISP Fundamental", "Algebra" } },
//            new Student(){ Name="Adib", Gender="Male", Subjects = new List<string>{ "Pascal Fundamental", "Mathematics" } },
//        };
//        Console.WriteLine("Before Order Sort");
//        foreach (var student in students)
//        {
//            Console.WriteLine($"{student.Name}");
//        }

//        var studentOrder = students.OrderByDescending(w => w.Name);
//        Console.WriteLine("After Order Sort");
//        foreach (var student in studentOrder)
//        {
//            Console.WriteLine($"{student.Name}");
//        }
//    }
//}

//class Student
//{
//    public string Name { get; set; }
//    public string Gender { get; set; }
//    public List<string> Subjects { get; set; }
//}


//class Program
//{
//    static void Main()
//    {
//        List<Student> students = new List<Student>()
//        {
//            new Student(){ StudentId = 1, Name="Hanafi", Gender="Male",
//                Subjects = new List<string>{ "Web Design", "Matematika Terapan" } },
//            new Student(){ StudentId = 1, Name="Ahmad", Gender="Male",
//                Subjects = new List<string>{ "Web Design", "Matematika Terapan" } },
//            new Student(){ StudentId = 4, Name="Alvin", Gender="Male",
//                Subjects = new List<string>{ "Web Design", "Matematika Terapan" } },
//            new Student(){ StudentId = 1, Name="Kiki", Gender="Male",
//                Subjects = new List<string>{ "Web Design", "Matematika Terapan" } },
//            new Student(){ StudentId = 2, Name="Rafif", Gender="Male",
//                Subjects = new List<string>{ "Web Design", "Matematika Terapan" } },
//            new Student(){ StudentId = 6, Name="Adib", Gender="Male",
//                Subjects = new List<string>{ "REST Api", "Matematika" } },
//        };

//        // Sorting berdasarkan studentid, dilanjut sort oleh ThenBy dimana diurutkan secara ASC sesuai dgn StudentId
//        // select * from student order by studentid, name ASC
//        var studentSorted = students.OrderBy(x => x.StudentId).ThenBy(x => x.Name);
//        foreach(var student in studentSorted)
//        {
//            Console.WriteLine($"{student.StudentId} - {student.Name}");
//        }
//    }
//}
//class Student
//{
//    public int StudentId { get; set; }
//    public string Name { get; set; }
//    public string Gender { get; set; }
//    public List<string> Subjects { get; set; }
//}

//class Program
//{
//    static void Main(string[] args)
//    {
//        List<Student> Objstudent = new List<Student>()
//            {
//                new Student() { RoleId=1, Name = "Hanapi", Gender = "Male",
//                    Subjects = new List<string> { "Mathematics","Physics" } },
//                new Student() { RoleId=2, Name = "Kiki", Gender = "Female",
//                    Subjects = new List<string> { "Entomology", "Botany" } },
//                new Student() { RoleId=3, Name = "Ahmad", Gender = "Male",
//                    Subjects = new List<string> { "Computers","Operating System", "Java" } },
//                new Student() { RoleId=4, Name = "Fitraldy", Gender = "Male",
//                    Subjects = new List<string> { "English", "Social Studies", "Chemistry" } },
//                new Student() { RoleId=5, Name = "Rafif", Gender = "Male",
//                    Subjects = new List<string> { "Accounting", "Charted" } }
//            };

//        // Sorting berdasarkan roleid, dilanjut sort oleh ThenBy dimana diurutkan secara DESC sesuai dgn StudentId
//        // SELECT * FROM student order by name, roleid DESC
//        var studentname = Objstudent.OrderBy(x => x.Name).ThenByDescending(x => x.RoleId);
//        foreach (var student in studentname)
//        {
//            Console.WriteLine("Name={0} StudentId={1}", student.Name, student.RoleId);
//        }
//        Console.ReadLine();
//    }
//}
//class Student
//{
//    public int RoleId { get; set; }
//    public string Name { get; set; }
//    public string Gender { get; set; }
//    public List<string> Subjects { get; set; }
//}

// Partition Query, Skip, Take dan TakeWhile
//class Program
//{
//    static void Main()
//    {
//        string[] countries = { "India", "USA", "France", "NKRI", "Australia", "Argentina" };

//        // SELECT TOP 3 * FROM Countries
//        IEnumerable<string> result = countries.Take(3);
//        foreach (var country in result)
//        {
//            Console.WriteLine(country);
//        }
//    }
//}

//class Program
//{
//    static void Main()
//    {
//        string[] countries = { "India", "USA", "France", "NKRI", "Australia", "Argentina" };

//        // SELECT TOP 3 * FROM Countries
//        IEnumerable<string> result = (from x in countries select x).Take(5);
//        foreach (var country in result)
//        {
//            Console.WriteLine(country);
//        }
//    }
//}

//class Program
//{
//    static void Main()
//    {
//        string[] countries = { "India", "USA", "France", "NKRI", "Australia", "Argentina" };

//        // SELECT TOP 3 * FROM Countries
//        IEnumerable<string> result = (from x in countries select x).TakeWhile(x => x.StartsWith("I"));
//        foreach (var country in result)
//        {
//            Console.WriteLine(country);
//        }
//    }
//}

//class Program
//{
//    static void Main()
//    {
//        string[] countries = { "India", "USA", "France", "NKRI", "Australia", "Argentina" };

//        // SELECT * FROM (
//        // SELECT ROW_NUMBER() OVER(ORDER BY Country) as RowNum FROM Countries)
//        // AS Tbl WHERE Country < RowNum
//        IEnumerable<string> result = countries.Skip(3);
//        foreach(var country in result)
//        {
//            Console.WriteLine(country);
//        }
//    }
//}


//class Program
//{
//    static void Main()
//    {
//        string[] fruits = {"apple", "banana", "mango", "orange", "grape", "tomato" };

//        // Mengambil semua element pada string[] sampai ketemu kondisi true
//        IEnumerable<string> result = fruits.TakeWhile(fruit => String.Compare("grape", fruit, true) != 0);

//        foreach(string fruit in result)
//        {
//            Console.WriteLine(fruit);
//        }
//    }
//}

//class Program
//{
//    static void Main()
//    {
//        string[] countries = {  "USA", "Undia", "France", "UKRI", "Australia", "Argentina" };

//        // SELECT TOP 3 * FROM Countries
//        // TakeWhile StartWith akan mengambil value string yg sesuai dgn kriteria tp jika dia false lngs
//        // exit takewhile
//        IEnumerable<string> result = countries.TakeWhile(x => x.StartsWith("U", StringComparison.Ordinal));
//        foreach (var country in result)
//        {
//            Console.WriteLine(country);
//        }
//    }
//}

//class Program
//{
//    static void Main()
//    {
//        string[] countries = { "USA", "India", "France", "NKRI", "Australia", "Argentina",
//        "England", "Qatar", "UEA", "Japan", "Korea"};

//        // SELECT * FROM Countries 
//        // ORDER BY [Fields]
//        // OFFSET 3 ROWS // SKIP
//        // FETCH NEXT 5 ROWS ONLY // TAKE
//        IEnumerable<string> result = (from x in countries select x).Skip(3).Take(5).OrderBy(x => x);
//        foreach(var country in result)
//        {
//            Console.WriteLine(country);
//        }
//    }
//}

//class Program
//{
//    static void Main()
//    {
//        string[] countries = { "USA", "India", "France", "NKRI", "Australia", "Argentina",
//        "England", "Qatar", "UEA", "Japan", "Korea"};

//        // SELECT * FROM Countries 
//        // WHERE Fields Like '%a%'
//        // ORDER BY [Fields] DESC
//        // OFFSET 3 ROWS // SKIP
//        // FETCH NEXT 5 ROWS ONLY // TAKE
//        IEnumerable<string> result = (from x in countries select x)
//                                .Skip(3)
//                                .Take(5)
//                                .Where(x => x.Contains("a"))
//                                .OrderByDescending(x => x);
//        foreach (var country in result)
//        {
//            Console.WriteLine(country);
//        }
//    }
//}


// Conversion LINQ
//class Program
//{
//    static void Main()
//    {
//        string[] countries = { "USA", "India", "France", "NKRI", "Australia", "Argentina",
//            "England", "Qatar", "UEA", "Japan", "Korea"};

//        //List<string> result = countries.ToList(); // mengkonversi array string menjadi collection string
//        List<string> result = (from x in countries select x).ToList();
//        foreach (var country in result)
//        {
//            Console.WriteLine(country);
//        }
//    }
//}

//class Program
//{
//    static void Main()
//    {
//        List<string> countries = new List<string>();
//        countries.Add("Japan");
//        countries.Add("USA");
//        countries.Add("UK");
//        countries.Add("Argentina");
//        countries.Add("Chile");
//        countries.Add("Mexico");

//        // mengubah LIST Collection menjadi ARRAY
//        string[] result = (from x in countries select x).ToArray();
//        foreach (var country in result)
//        {
//            Console.WriteLine(country);
//        }
//    }
//}

//class Program
//{
//    static void Main()
//    {
//        List<Employee> employees = new List<Employee>()
//        {
//            new Employee(){ Name="Anton", Department="IT", Country="USA" },
//            new Employee(){ Name="Andik", Department="IT", Country="USA" },
//            new Employee(){ Name="Madara", Department="Sales", Country="USA" },
//            new Employee(){ Name="Naruto", Department="Sales", Country="USA" },
//            new Employee(){ Name="Hanapi", Department="Marketing", Country="USA" },
//            new Employee(){ Name="Aizen", Department="HR", Country="USA" },
//            new Employee(){ Name="Byakuya", Department="HR", Country="USA" },
//        };

//        var empLookup = employees.ToLookup(x => x.Department);
//        Console.WriteLine("Group Employee By Department");
//        Console.WriteLine("-----------------------------");
//        foreach(var dept in empLookup)
//        {
//            Console.WriteLine(dept.Key);
//            foreach(var emp in empLookup[dept.Key])
//            {
//                Console.WriteLine($"{emp.Name} - {emp.Department} - {emp.Country}");
//            }
//        }
//    }
//}

//class Employee
//{
//    public string Name { get; set; }
//    public string Department { get; set; }
//    public string Country { get; set; }
//}

// Element LINQ
//class Program
//{
//    static void Main()
//    {
//        int[] objs = { 1, 2, 3, 4, 5, 6, 7, 8 };
//        // untuk mengambil element pertama pada list, array atau collection lainnya
//        int result = (from x in objs select x).First();
//        Console.Write($"{result}");
//    }
//}

//class Program
//{
//    static void Main()
//    {
//        int[] objs = { 1, 2, 3, 4, 5, 6, 7, 8 };
//        // untuk mengambil element pertama pada list, array atau collection lainnya
//        int result = (from x in objs select x).FirstOrDefault(w => w == 4);
//        Console.Write($"{result}");
//    }
//}

//class Program
//{
//    static void Main()
//    {
//        int[] objs = { 1, 1, 2, 2, 3, 4, 5, 6, 7, 8 };
//        // mengambil 1 row pada sequence meskipun return nya lebih dr 1 sequence
//        int result = (from x in objs select x).FirstOrDefault(w => w == 1);
//        // mengambil 1 row HANYA pada 1 sequence, ketika return nya multi sequence dia akan error
//        int resultSingle = (from x in objs select x).Single(w => w == 1);
//        //int resultSingleOrDefault = (from x in objs select x).SingleOrDefault(w => w == 7);
//        Console.Write($"{result}");
//    }
//}

//class Program
//{
//    static void Main()
//    {
//        int[] objs = { 1, 1, 2, 2, 3, 4, 5, 6, 7, 8 };
//        // Mengembalikan last sequence, akan terjadi error jika sequence adalah NULL
//        int result = (from x in objs select x).Last();
//        // Mengembalikan last sequence, akan return default value (0) jika sequence adalah NULL
//        int resultLoD = (from x in objs select x).LastOrDefault();

//        Console.Write($"{result}");
//    }
//}

//class Program
//{
//    static void Main()
//    {
//        int[] objA = { 1, 1, 2, 2, 3, 4, 5, 6, 7, 8 };
//        int[] objB = { };

//        var resultA = objA.DefaultIfEmpty();
//        var resultB = objB.DefaultIfEmpty();

//        Console.WriteLine("List dengan Nilai");
//        foreach(var result in resultA)
//        {
//            Console.WriteLine($"{result}");
//        }

//        Console.WriteLine("List tanpa Nilai");
//        foreach (var result in resultB)
//        {
//            Console.WriteLine($"{result}");
//        }
//    }
//}

// Group By
//class Program
//{
//    static void Main()
//    {
//        List<Student> students = new List<Student>()
//        {
//            new Student(){ Name="Hanapi", Gender="Male", City ="Garut"},
//            new Student(){ Name="Byakuya", Gender="Male", City ="Garut"},
//            new Student(){ Name="Naruto", Gender="Male", City ="Konoha"},
//            new Student(){ Name="Sakura", Gender="Female", City ="Konoha"},
//            new Student(){ Name="Hinata", Gender="Female", City ="Konoha"},
//            new Student(){ Name="Ino", Gender="Female", City ="Konoha"},
//            new Student(){ Name="Adib", Gender="Male", City ="Suna"},
//            new Student(){ Name="Syaiful", Gender="Male", City ="Bekasi"},
//        };

//        // SELECT * FROM Student Group By Gender
//        var studentGroup = from student in students
//                           group student by student.Gender;

//        foreach(var studentItem in studentGroup)
//        {
//            Console.WriteLine(studentItem.Key);
//            foreach(var stud in studentItem)
//            {
//                Console.WriteLine($"{stud.Name} - {stud.Gender} - {stud.City}");
//            }
//        }
//    }
//}

//class Student
//{
//    public string Name { get; set; }
//    public string Gender { get; set; }
//    public string City { get; set; }
//}

// LOAD XML ke LINQ
//using System.Xml.Linq;

//class Program
//{
//    static void Main()
//    {
//        var xml = @"
//                    <ingredients>
//                        <ingredient name='Milk' quantity='200' price='2500' />
//                        <ingredient name='Sugar' quantity='200' price='2500' />
//                        <ingredient name='Bread' quantity='200' price='2500' />
//                        <ingredient name='Salt' quantity='200' price='2500' />
//                    </ingredients>
//                    ";

//        XElement xElement = XElement.Parse(xml);

//        XElement Milk = xElement.Descendants("ingredient")
//            .First(x => x.Attribute("name").Value == "Milk");

//        XAttribute namaAttribut = Milk.FirstAttribute;
//        XAttribute priceAttribut = Milk.Attribute("price");
//        string priceMilk = priceAttribut.Value;
//        XAttribute qty = Milk.Attributes().Skip(1).First();

//        Console.Write(qty);
//    }
//}


//class Program
//{
//    static void Main()
//    {
//        Ingredient[] ingredients =
//        {
//         new Ingredient{Name = "Sugar", Calories=500},
//         new Ingredient{Name = "Egg", Calories=100},
//         new Ingredient{Name = "Milk", Calories=150},
//         new Ingredient{Name = "Flour", Calories=50},
//         new Ingredient{Name = "Butter", Calories=200}
//        };

//        // SELECT Name FROM Ingredient WHERE Calorie > 150 ORDER BY Name ASC
//        IEnumerable<string> ingredient = ingredients.Where(x => x.Calories >= 150) // Dimana calorie > 150
//                                         .OrderBy(x => x.Name) // Order By Name
//                                         .Select(x => x.Name); //Hanya mengambil field Name

//        foreach (var ingredientName in ingredient)
//        {
//            Console.WriteLine(ingredientName);
//        }
//    }

//    class Ingredient
//    {
//        public string Name { get; set; }
//        public int Calories { get; set; }
//    }
//}


//class Program
//{
//    static void Main()
//    {
//        Ingredient[] ingredients =
//        {
//             new Ingredient{Name = "Sugar", Calories=500},
//             new Ingredient{Name = "Egg", Calories=100},
//             new Ingredient{Name = "Milk", Calories=150},
//             new Ingredient{Name = "Flour", Calories=50},
//             new Ingredient{Name = "Butter", Calories=200}
//        };

//        // SELECT OriginalIngredient =i, IsDairy (CASE WHEN Name=Milk dst), IsHighCalori = Calorie >=150
//        // INTO Temp FROM Ingredient WHERE IsDairy AND IsHighCalorie
//        IEnumerable<Ingredient> hiCalorie =
//        from i in ingredients // FROM Ingredient
//        select new // SELECT OriginalIngredient, IsDairy, IsHighCalorie
//        {
//             OriginalIngredient = i, // ALIAS Field untuk TEMP
//             IsDairy = i.Name == "Milk" || i.Name == "Butter",
//             IsHighCalorie = i.Calories >= 150
//        }
//        into temp // INTO Temp
//        where temp.IsDairy && temp.IsHighCalorie // WHERE
//        select temp.OriginalIngredient; // SELECT

//        foreach (var ingredient in hiCalorie)
//        {
//            Console.WriteLine(ingredient.Name);
//        }
//    }

//    class Ingredient
//    {
//        public string Name { get; set; }
//        public int Calories { get; set; }
//    }
//}


// JOIN / INNER JOIN
//class Program
//{
//    static void Main()
//    {
//        Recipe[] recipes =
//             {
//                 new Recipe {Id = 1, Name = "Mashed Potato"},
//                 new Recipe {Id = 2, Name = "Crispy Duck"},
//                 new Recipe {Id = 3, Name = "Sachertorte"}
//            };

//        Review[] reviews =
//             {
//                 new Review {RecipeId = 1, ReviewText = "Tasty!"},
//                 new Review {RecipeId = 1, ReviewText = "Not nice :("},
//                 new Review {RecipeId = 1, ReviewText = "Pretty good"},
//                 new Review {RecipeId = 2, ReviewText = "Too hard"},
//                 new Review {RecipeId = 2, ReviewText = "Loved it"}
//             };
//        // JOIN atau INNER JOIN
//        // SELECT RecipeName, RecipeReview FROM Recipe
//        // JOIN Review ON Recipe.Id = Review.RecipeId
//        var query = from recipe in recipes
//                    join review in reviews on recipe.Id equals/* = */ review.RecipeId
//                    select new // SELECT Fields
//                    {
//                        RecipeName = recipe.Name,
//                        RecipeReview = review.ReviewText
//                    };

//        foreach (var item in query)
//        {
//            Console.WriteLine("{0} - '{1}'", item.RecipeName, item.RecipeReview);
//        }
//    }
//}

//class Recipe
//{
//    public int Id { get; set; }
//    public string Name { get; set; }
//}
//class Review
//{
//    public int RecipeId { get; set; }
//    public string ReviewText { get; set; }
//}

// LEFT JOIN
//class Program
//{
//    static void Main()
//    {
//        Recipe[] recipes =
//             {
//                 new Recipe {Id = 1, Name = "Mashed Potato"},
//                 new Recipe {Id = 2, Name = "Crispy Duck"},
//                 new Recipe {Id = 3, Name = "Sachertorte"}
//            };

//        Review[] reviews =
//             {
//                 new Review {RecipeId = 1, ReviewText = "Tasty!"},
//                 new Review {RecipeId = 1, ReviewText = "Not nice :("},
//                 new Review {RecipeId = 1, ReviewText = "Pretty good"},
//                 new Review {RecipeId = 2, ReviewText = "Too hard"},
//                 new Review {RecipeId = 2, ReviewText = "Loved it"}
//             };

//        var query = from recipe in recipes
//                    join review in reviews
//                    on recipe.Id equals review.RecipeId into ReviewGroup
//                    from rg in ReviewGroup.DefaultIfEmpty()
//                    select new
//                    {
//                        RecipeName = recipe.Name,
//                        RecipeReview = rg == null ? "No Review" : rg.ReviewText
//                    };

//        foreach (var item in query)
//        {
//            Console.WriteLine("{0} - '{1}'", item.RecipeName, item.RecipeReview);
//        }
//    }
//}

//class Recipe
//{
//    public int Id { get; set; }
//    public string Name { get; set; }
//}
//class Review
//{
//    public int RecipeId { get; set; }
//    public string ReviewText { get; set; }
//}

// LEFT JOIN
//class Program
//{
//    static void Main()
//    {
//        Recipe[] recipes =
//             {
//                 new Recipe {Id = 1, Name = "Mashed Potato"},
//                 new Recipe {Id = 2, Name = "Crispy Duck"},
//                 new Recipe {Id = 3, Name = "Sachertorte"}
//            };

//        Review[] reviews =
//             {
//                 new Review {RecipeId = 1, ReviewText = "Tasty!"},
//                 new Review {RecipeId = 1, ReviewText = "Not nice :("},
//                 new Review {RecipeId = 1, ReviewText = "Pretty good"},
//                 new Review {RecipeId = 2, ReviewText = "Too hard"},
//                 new Review {RecipeId = 2, ReviewText = "Loved it"}
//             };

//        var query = from recipe in recipes
//                    join review in reviews
//                    on recipe.Id equals review.RecipeId into ReviewGroup
//                    from rg in ReviewGroup.DefaultIfEmpty()
//                    select new
//                    {
//                        RecipeName = recipe.Name,
//                        RecipeReview = rg == null ? "No Review" : rg.ReviewText // itenary
//                    };

//        foreach (var item in query)
//        {
//            Console.WriteLine("{0} - '{1}'", item.RecipeName, item.RecipeReview);
//        }
//    }
//}

//class Recipe
//{
//    public int Id { get; set; }
//    public string Name { get; set; }
//}
//class Review
//{
//    public int RecipeId { get; set; }
//    public string ReviewText { get; set; }
//}


//// CROSS JOIN
//class Program
//{
//    static void Main()
//    {
//        Recipe[] recipes =
//             {
//                 new Recipe {Id = 1, Name = "Mashed Potato"},
//                 new Recipe {Id = 2, Name = "Crispy Duck"},
//                 new Recipe {Id = 3, Name = "Sachertorte"}
//            };

//        Review[] reviews =
//             {
//                 new Review {RecipeId = 1, ReviewText = "Tasty!"},
//                 new Review {RecipeId = 1, ReviewText = "Not nice :("},
//                 new Review {RecipeId = 1, ReviewText = "Pretty good"},
//                 new Review {RecipeId = 2, ReviewText = "Too hard"},
//                 new Review {RecipeId = 2, ReviewText = "Loved it"}
//             };

//        // SELECT RecipeName, ReviewText FROM Recipes CROSS JOIN (Reviews)
//        // SELECT RecipeName, ReviewText FROM Recipes, Reviews
//        var query = from recipe in recipes
//                    from review in reviews
//                    select new
//                    {
//                        RecipeName = recipe.Name,
//                        RecipeReview = review.ReviewText 
//                    };

//        foreach (var item in query)
//        {
//            Console.WriteLine("{0} - '{1}'", item.RecipeName, item.RecipeReview);
//        }
//    }
//}

//class Recipe
//{
//    public int Id { get; set; }
//    public string Name { get; set; }
//}
//class Review
//{
//    public int RecipeId { get; set; }
//    public string ReviewText { get; set; }
//}

// RIGHT JOIN
//class Program
//{
//    static void Main()
//    {
//        Recipe[] recipes =
//             {
//                 new Recipe {Id = 1, Name = "Mashed Potato"},
//                 new Recipe {Id = 2, Name = "Crispy Duck"},
//                 new Recipe {Id = 3, Name = "Sachertorte"}
//            };

//        Review[] reviews =
//             {
//                 new Review {RecipeId = 1, ReviewText = "Tasty!"},
//                 new Review {RecipeId = 1, ReviewText = "Not nice :("},
//                 new Review {RecipeId = 1, ReviewText = "Pretty good"},
//                 new Review {RecipeId = 2, ReviewText = "Too hard"},
//                 new Review {RecipeId = 2, ReviewText = "Loved it"}
//             };

//        // SELECT RecipeName, ReviewText FROM Review
//        // RIGHT JOIN Recipe ON Review.RecipeId = Recipe.Id
//        // RIGHT JOIN tinggal di switch dataset nya dr LEFT JOIN
//        var query = from review in reviews
//                    join recipe in recipes
//                    on review.RecipeId equals recipe.Id into ReviewGroup
//                    from rg in ReviewGroup.DefaultIfEmpty()
//                    select new
//                    {
//                        RecipeName = rg == null ? "No Recipe" : rg.Name,
//                        RecipeReview = review.ReviewText
//                    };

//        foreach (var item in query)
//        {
//            Console.WriteLine("{0} - '{1}'", item.RecipeName, item.RecipeReview);
//        }
//    }
//}

//class Recipe
//{
//    public int Id { get; set; }
//    public string Name { get; set; }
//}
//class Review
//{
//    public int RecipeId { get; set; }
//    public string ReviewText { get; set; }
//}

//// UNION
//class Program
//{
//    static void Main()
//    {
//        var people1 = new[]
//        {
//            new {Id = 1112, Name = "Hanapi", City = "Garut"},
//            new {Id = 1113, Name = "Anton", City = "Bekasi"},
//            new {Id = 1114, Name = "Andik", City = "Klaten"},
//            new {Id = 1115, Name = "Jimmy", City = "Jakarta"}
//        };

//        var people2 = new[]
//       {
//            new {Id = 1112, Name = "Hanapi", City = "Garut"},
//            new {Id = 1113, Name = "Anton", City = "Bekasi"},
//            new {Id = 1114, Name = "Andik", City = "Klaten"},
//            new {Id = 1115, Name = "Jimmy", City = "Jakarta"},
//            new {Id = 1116, Name = "Adib", City = "Medan"},
//            new {Id = 1117, Name = "Rafif", City = "Papua"},
//            new {Id = 1118, Name = "Alvin", City = "Kalimantan"}
//        };
//        // SELECT * FROM TABLE_A
//        // UNION
//        // SELECT * FROM TABLE_A
//        // UNION secara performance itu JELEK/BURUK. JANGAN DI PAKAI KECUALI TERPAKSA
//        var peoples = people1.Union(people2);

//        foreach(var people in peoples)
//        {
//            Console.WriteLine($"{people.Name} - {people.City}");
//        }
//    }
//}

// INTERSECT
class Program
{
    static void Main()
    {
        var people1 = new[]
        {
            new {Id = 1112, Name = "Hanapi", City = "Garut"},
            new {Id = 1113, Name = "Anton", City = "Bekasi"},
            new {Id = 1114, Name = "Andik", City = "Klaten"},
            new {Id = 1115, Name = "Jimmy", City = "Jakarta"}
        };

        var people2 = new[]
       {
            new {Id = 1112, Name = "Hanapi", City = "Garut"},
            new {Id = 1113, Name = "Anton", City = "Bekasi"},
            new {Id = 1114, Name = "Andik", City = "Klaten"},
            new {Id = 1115, Name = "Jimmy", City = "Jakarta"},
            new {Id = 1116, Name = "Adib", City = "Medan"},
            new {Id = 1117, Name = "Rafif", City = "Papua"},
            new {Id = 1118, Name = "Alvin", City = "Kalimantan"}
        };

        // SELECT * FROM TABLE_A
        // INTERSECT
        // SELECT * FROM TABLE_A
        // INTERSECT secara performance itu JELEK/BURUK. JANGAN DI PAKAI KECUALI TERPAKSA
        var peoples = people1.Intersect(people2);

        foreach (var people in peoples)
        {
            Console.WriteLine($"{people.Name} - {people.City}");
        }
    }
}