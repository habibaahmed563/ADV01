namespace ADV01
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //Generics :
            //C# Feature 2005 C# 2.0
            //Before 2005 Class Object

            #region Generic E01 : Swap
            //Swap

            //int A = 4, B = 5;

            //Console.WriteLine($"A : {A}");
            //Console.WriteLine($"B : {B}");

            //Console.WriteLine($"-----After Swap-----");

            //Helper.Swap(ref A, ref B);


            //Console.WriteLine($"A : {A}");
            //Console.WriteLine($"B : {B}");

            //double L = 1.5, K = 2.6;

            //Console.WriteLine($"L : {L}");
            //Console.WriteLine($"K : {K}");

            //Console.WriteLine($"-----After Swap-----");

            //Helper.Swap(ref L, ref K);

            //Point : X,Y

            //Point P01 = new Point(1, 1);
            //Point P02 = new Point(2, 2);

            //Console.WriteLine($"P01 : {P01}");
            //Console.WriteLine($"P02 : {P02}");

            //Console.WriteLine($"-----After Swap-----");

            //Helper.Swap(ref P01, ref P02);

            //Console.WriteLine($"P01 : {P01}");
            //Console.WriteLine($"P02 : {P02}");

            //------------------------------------------------//


            //int A = 4, B = 5;

            //Console.WriteLine($"A : {A}");
            //Console.WriteLine($"B : {B}");

            //Console.WriteLine($"-----After Swap-----");

            //Helper.Swap(ref A, ref B);


            //Console.WriteLine($"A : {A}");
            //Console.WriteLine($"B : {B}");

            //double L = 1.5, K = 2.6;

            //Console.WriteLine($"L : {L}");
            //Console.WriteLine($"K : {K}");

            //Console.WriteLine($"-----After Swap-----");

            //Helper.Swap(ref L, ref K);

            //Point : X,Y

            //Point P01 = new Point(1, 1);
            //Point P02 = new Point(2, 2);

            //Console.WriteLine($"P01 : {P01}");
            //Console.WriteLine($"P02 : {P02}");

            //Console.WriteLine($"-----After Swap-----");

            //Helper.Swap(ref P01, ref P02);

            //Console.WriteLine($"P01 : {P01}");
            //Console.WriteLine($"P02 : {P02}"); 
            #endregion

            #region Generic EX02 : Linear Search
            //Linear Search 

            // 4 7 8 9 10 1 2 3 5 12 -1 -13 11

            //Index 

            //int[] Numbers = { 8, 7, 6, 1, 2, 3, 4, 5, 6, 12, -1, 13, 9 };

            //int Index = Helper.LinearSearch(Numbers, 4);

            //Console.WriteLine($"Index : {Index}");

            //Employee E01 = new Employee() { Id = 1, Name = "Ahmed", Age = 31, Salary=12000 };
            //Employee E02 = new Employee() { Id = 2, Name = "Ali", Age = 34, Salary=11000 };
            //Employee E03 = new Employee() { Id = 3, Name = "Omar", Age = 32, Salary=13000 };
            //Employee E04 = new Employee() { Id = 4, Name = "Mona", Age = 39, Salary=19000 };

            //Employee[] employee = { E01, E02, E03, E04, };

            //Helper.LinearSearch(employee, E01); 
            #endregion

            #region Equality in class or struct

            //Equality in class or struct 
            //Equals
            //'Class' Has Equals Functions which inherited from object class --> Compare Reference
            //'Struct' Has Equals Functions which inherited from object class --> Compare Data
            //Note : Struct Don't have Implementation For the ==Operation


            //Employee E01 = new Employee() { Id = 1, Name = "Ahmed", Age = 31, Salary = 12000 };
            //Employee E02 = new Employee() { Id = 2, Name = "Ali", Age = 34, Salary = 11000 };

            //Console.WriteLine($"E01 : {E01.GetHashCode()}");
            //Console.WriteLine($"E02 : {E02.GetHashCode()}");

            //if (E01.Equals(E02))
            //    Console.WriteLine("E01 == E02!");
            //else
            //    Console.WriteLine("E01 != E02!");

            //if (E01.Equals(E02))
            //    Console.WriteLine("E01 == E02!");
            //else
            //  
            #endregion   Console.WriteLine("E01 != E02!");

            #region Generic Ex03 : Buble Sort
            // 2,3,9,8,7,6,5,4,1,12,-1,0

            //sorting : Bubble sort 

            //int[] numbers = {2,3,9,8,7,6,5,4,1,12,-1,0}

            //Helper.PrintArray(numbers);
            //Console.WriteLine();

            //Helper.Bubblesort(numbers);
            //Helper.PrintArray(numbers);

            //Point[] Points =
            //{
            //    new Point(6,6),
            //    new Point(2,2),
            //    new Point(4,4),
            //    new Point(3,3),
            //    new Point(1,1),
            //    new Point(5,5),
            //};

            //Helper.Bubblesort(Points);

            //Icompareable : CompareTo
            //int 
            //+ : Caller > parameter
            //+ : Caller > parameter
            //0 : Caller > parameter 
            #endregion

            #region is and as casting operator

            //Point[] Points =
            //{
            //    new Point(6,6),
            //    new Point(2,2),
            //    new Point(4,4),
            //    new Point(3,3),
            //    new Point(1,1),
            //    new Point(5,5),
            //};

            //Helper.PrintArray(Points);

            //Helper.Bubblesort(Points);

            //Helper.PrintArray(Points);

            //Point P01 = new Point(1, 1);
            //Point P02 = new Point(2, 2);

            //if (P01.CompareTo(P02) > 0)
            //    Console.WriteLine("P01 is greater than P02");
            //else
            //    Console.WriteLine("P01 is not greater than P02");
            #endregion

            #region non Generic IComparable vs Generic IComparable

            //Point[] Points =
            //{
            //    new Point(6,6),
            //    new Point(2,2),
            //    new Point(4,4),
            //    new Point(3,3),
            //    new Point(1,1),
            //    new Point(5,5),
            //};

            //Helper.PrintArray(Points);

            //Helper.Bubblesort(Points);

            //Helper.PrintArray(Points);

            //Employee E01 = new Employee() { Id = 1, Name = "Ahmed", Age = 31, Salary = 12000 };
            //Employee E02 = new Employee() { Id = 2, Name = "Ali", Age = 34, Salary = 11000 };
            //Employee E03 = new Employee() { Id = 3, Name = "Omar", Age = 32, Salary = 13000 };
            //Employee E04 = new Employee() { Id = 4, Name = "Mona", Age = 39, Salary = 19000 };

            //Employee[] employee = { E01, E02, E03, E04, }; 
            #endregion

            #region Built-in intergace Generic Iequatable
            //Employee E01 = new Employee() { Id = 1, Name = "Ahmed", Age = 31, Salary = 12000 };
            //Employee E02 = new Employee() { Id = 2, Name = "Ali", Age = 34, Salary = 11000 };
            //Employee E03 = new Employee() { Id = 3, Name = "Omar", Age = 32, Salary = 13000 };
            //Employee E04 = new Employee() { Id = 4, Name = "Mona", Age = 39, Salary = 19000 };

            ////Employee[] employee = { E01, E02, E03, E04, };

            ////int Index = Helper.LinearSearch(employee, E03);

            ////Console.WriteLine($"Index : {Index}");

            //if (E01.Equals(E02))
            //    Console.WriteLine("E01==E02");
            //else
            //    Console.WriteLine("E01!=E02");

            //Built-in Interface IEquality 
            #endregion

            #region Built-in Interface Generic IEqualityComparer
            //Built-in interface Generic IEqualityComparer

            //Employee E01 = new Employee() { Id = 1, Name = "Ahmed", Age = 31, Salary = 12000 };
            //Employee E02 = new Employee() { Id = 2, Name = "Ali", Age = 34, Salary = 11000 };
            //Employee E03 = new Employee() { Id = 3, Name = "Omar", Age = 32, Salary = 13000 };
            //Employee E04 = new Employee() { Id = 4, Name = "Mona", Age = 39, Salary = 19000 };

            //Employee[] employee = { E01, E02, E03, E04, };

            //int Index = Helper.LinearSearch(employee, E03);

            //Console.WriteLine($"Index : {Index}"); 
            #endregion

            #region IComparer with Bubble sort
            //Employee E01 = new Employee() { Id = 1, Name = "Ahmed", Age = 31, Salary = 12000 };
            //Employee E02 = new Employee() { Id = 2, Name = "Ali", Age = 34, Salary = 11000 };
            //Employee E03 = new Employee() { Id = 3, Name = "Omar", Age = 32, Salary = 13000 };
            //Employee E04 = new Employee() { Id = 4, Name = "Mona", Age = 39, Salary = 19000 };

            //Employee[] employee = { E01, E02, E03, E04, };

            //Helper.PrintArray(employees);

            //Helper.BubleSort(employees,new EmployeeComparerSalary()); //Sorting Based on salary
            //Helper.BubleSort(employees,new EmployeeComparerSalary()); //Sorting Based on Named Length

            //Console.WriteLine();

            //Helper.PrintArray(employee);

            //Array.sort() 
            #endregion


        }
    }
}
