using System;

namespace CSharpFundamentals
{

    class Program
    {
        static void Main(string[] args)
        {
            var fullName = "Kenji Hirabayashi ";
            Console.WriteLine("Trim: '{0}'", fullName.Trim());
            Console.WriteLine("ToUpper: '{0}'", fullName.ToUpper());

            var index = fullName.IndexOf(' ');
            var firstName = fullName.Substring(0, index);
            var lastName = fullName.Substring(index + 1);
            Console.WriteLine("FirstName: " + firstName);
            Console.WriteLine("LastName: " + lastName);

            var names = fullName.Split(' ');
            Console.WriteLine("FirstName: " + names[0]);
            Console.WriteLine("LastName: " + names[1]);

            Console.WriteLine(fullName.Replace("Kenji", "Michael"));

            if (String.IsNullOrWhiteSpace(" "))
                Console.WriteLine("Invalid");

            var str = "25";
            var age = Convert.ToByte(str);
            Console.WriteLine(age);

            float price = 29.95f;
			Console.WriteLine(price.ToString("C"));
        }
    }
}