using System;

class Program
{
    static void Main()
    {
        while (true)
        {
            Console.Clear();
            Console.WriteLine("=== MAIN MENU ===");
            Console.WriteLine("1. Student Helper");
            Console.WriteLine("2. Salary Calculator");
            Console.WriteLine("3. Password Tools");
            Console.WriteLine("4. Exit");

            int choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    StudentHelper();
                    break;
                case 2:
                    SalaryCalculator();
                    break;
                case 3:
                    PasswordTools();
                    break;
                case 4:
                    return;
                default:
                    Console.WriteLine("Noto‘g‘ri tanlov!");
                    Console.ReadKey();
                    break;
            }
        }
    }

    // ================= STUDENT HELPER =================
    static void StudentHelper()
    {
        Console.Clear();
        Console.WriteLine("=== Student Helper ===");
        Console.WriteLine("1. O'rtacha baho");
        Console.WriteLine("2. Eng yuqori baho");
        Console.WriteLine("3. Daraja aniqlash");
        Console.WriteLine("4. Exit");

        int choice = int.Parse(Console.ReadLine());

        switch (choice)
        {
            case 1:
                int[] grades = new int[5];
                int sum = 0;

                for (int i = 0; i < 5; i++)
                {
                    Console.Write("Baho kiriting: ");
                    grades[i] = int.Parse(Console.ReadLine());
                    sum += grades[i];
                }

                double average = (double)sum / 5;
                Console.WriteLine("O'rtacha: " + average);
                Console.ReadKey();
                break;

            case 2:
                int[] arr = new int[5];
                int max = int.MinValue;

                for (int i = 0; i < 5; i++)
                {
                    Console.Write("Baho kiriting: ");
                    arr[i] = int.Parse(Console.ReadLine());

                    if (arr[i] > max)
                        max = arr[i];
                }

                Console.WriteLine("Eng yuqori baho: " + max);
                Console.ReadKey();
                break;

            case 3:
                Console.Write("Baho kiriting: ");
                int grade = int.Parse(Console.ReadLine());

                if (grade >= 90) Console.WriteLine("A");
                else if (grade >= 80) Console.WriteLine("B");
                else if (grade >= 70) Console.WriteLine("C");
                else if (grade >= 60) Console.WriteLine("D");
                else Console.WriteLine("F");

                Console.ReadKey();
                break;
        }
    }

    // ================= SALARY CALCULATOR =================
    static void SalaryCalculator()
    {
        Console.Clear();
        Console.WriteLine("=== Salary Calculator ===");
        Console.WriteLine("1. Oylik maosh");
        Console.WriteLine("2. Soliq");
        Console.WriteLine("3. Yillik daromad");
        Console.WriteLine("4. Exit");

        int choice = int.Parse(Console.ReadLine());

        switch (choice)
        {
            case 1:
                Console.Write("Soatlik haq: ");
                double rate = double.Parse(Console.ReadLine());

                Console.Write("Ish soati: ");
                double hours = double.Parse(Console.ReadLine());

                double salary = rate * hours;
                Console.WriteLine("Maosh: " + salary);
                Console.ReadKey();
                break;

            case 2:
                Console.Write("Maosh kiriting: ");
                double s = double.Parse(Console.ReadLine());

                double taxRate = s > 5000000 ? 0.12 : 0.08;
                double tax = Math.Round(s * taxRate);

                Console.WriteLine("Soliq: " + tax);
                Console.ReadKey();
                break;

            case 3:
                Console.Write("Oylik daromad: ");
                double monthly = double.Parse(Console.ReadLine());

                Console.WriteLine("Yillik: " + (monthly * 12));
                Console.ReadKey();
                break;
        }
    }

    // ================= PASSWORD TOOLS =================
    static void PasswordTools()
    {
        Console.Clear();
        Console.WriteLine("=== Password Tools ===");
        Console.WriteLine("1. Uzunlik");
        Console.WriteLine("2. Kuchliligi");
        Console.WriteLine("3. Maskalash");
        Console.WriteLine("4. Exit");

        int choice = int.Parse(Console.ReadLine());

        switch (choice)
        {
            case 1:
                Console.Write("Parol: ");
                string text = Console.ReadLine();
                Console.WriteLine("Uzunligi: " + text.Length);
                Console.ReadKey();
                break;

            case 2:
                Console.Write("Parol: ");
                string pass = Console.ReadLine();

                bool hasUpper = false;
                bool hasDigit = false;

                foreach (char c in pass)
                {
                    if (char.IsUpper(c)) hasUpper = true;
                    if (char.IsDigit(c)) hasDigit = true;
                }

                if (pass.Length >= 8 && hasUpper && hasDigit)
                    Console.WriteLine("Strong");
                else
                    Console.WriteLine("Weak");

                Console.ReadKey();
                break;

            case 3:
                Console.Write("Parol: ");
                string p = Console.ReadLine();

                for (int i = 0; i < p.Length; i++)
                    Console.Write("*");

                Console.WriteLine();
                Console.ReadKey();
                break;
        }
    }
}