using System.IO;
using System.Linq;
using System.Globalization;

namespace practicetc
{

    class Program
    {
        static void Main(string[] args)
        {
            //task1

            //    string speedlimit,carspeed;
            //    Console.WriteLine("Enter a speedlimit");
            //    speedlimit = Console.ReadLine();

            //    Console.WriteLine("Enter a car speed");
            //    carspeed = Console.ReadLine();

            //    if ((int.TryParse(speedlimit, out int limit)&&int.TryParse(carspeed, out int speed)))
            //    {
            //        // Check if the number is within the valid range
            //        if (speed<=limit)
            //        {
            //            Console.WriteLine("Okay");
            //        }
            //        else
            //        {
            //            int dem=(speed-limit)/5;
            //            if (dem > 12)
            //            {
            //                Console.WriteLine("licence suspended");
            //            }
            //        }
            //    }
            //    else
            //    {
            //        // Handle invalid input (not a number)
            //        Console.WriteLine("Invalid");
            //    }
            //}

            //foreach practice

            //var number = new int[] { 1, 3, 4, 5, 6, 7, };
            //foreach (int i in number)
            //{
            //    Console.WriteLine(i);
            //}


            //var random=new Random();
            //const int passwordlength = 10;
            //var buffer = new char[passwordlength];
            //for(var i = 0; i < passwordlength; i++)
            //{
            //    buffer[i] = (char)('a' + random.Next(0, 26));

            //}
            //var password=new string(buffer);
            //Console.WriteLine(password);

            //var count = 0;
            //for (int i = 1; i <= 100; i++) { 
            // if(i%3==0)
            //        count++;
            //}
            //Console.WriteLine($"There are {count} numbers which are divisible by 3 between 1 and 100");

            //int sum = 0;

            //while (true)
            //{

            //    Console.Write("Enter a number or type 'ok' to exit: ");
            //    string input = Console.ReadLine();

            //    // Check if the user wants to exit
            //    if (input?.ToLower() == "ok")
            //    {
            //        input = string.Format(',', input);
            //        break;
            //    }

            //PRACTICE

            //    // Try to parse the input into an integer
            //    if (int.TryParse(input, out int number))
            //    {
            //        sum += number; // Add the number to the sum
            //    }
            //    else
            //    {
            //        Console.WriteLine("Invalid input. Please enter a number or 'ok' to exit.");
            //    }
            //}

            //// Display the total sum
            //Console.WriteLine($"The sum of all entered numbers is: {sum}");


            //PRACRTICE

            // Ask the user to enter a series of numbers separated by commas
            //    Console.Write("Enter a series of numbers separated by commas: ");
            //    string input = Console.ReadLine();

            //    try
            //    {
            //        // Split the input into an array of strings
            //        string[] numbers = input.Split(',');

            //        // Convert the array of strings into an array of integers
            //        int[] intNumbers = Array.ConvertAll(numbers, int.Parse);

            //        // Find the maximum number
            //        int max = intNumbers[0];
            //        foreach (int number in intNumbers)
            //        {
            //            if (number > max)
            //            {
            //                max = number;
            //            }
            //        }

            //        // Display the maximum number
            //        Console.WriteLine($"The maximum number is: {max}");
            //    }
            //    catch
            //    {
            //        Console.WriteLine("Invalid input. Please enter a series of numbers separated by commas.");
            //    }

            //LIST EXERCISE>>>><<<<
            //task1

            //    List<string> names = new List<string>();

            //    // Continuously ask the user to enter names
            //    while (true)
            //    {
            //        Console.Write("Enter a name (or press Enter to finish): ");
            //        string name = Console.ReadLine();

            //        // Check if the user pressed Enter without entering a name
            //        if (string.IsNullOrEmpty(name))
            //        {
            //            break;
            //        }

            //        // Add the name to the list
            //        names.Add(name);
            //    }

            //    // Display the appropriate message based on the number of names
            //    if (names.Count == 0)
            //    {
            //        // Do nothing if no one likes the post
            //    }
            //    else if (names.Count == 1)
            //    {
            //        Console.WriteLine($"{names[0]} likes your post.");
            //    }
            //    else if (names.Count == 2)
            //    {
            //        Console.WriteLine($"{names[0]} and {names[1]} like your post.");
            //    }
            //    else
            //    {
            //        int othersCount = names.Count - 2;
            //        Console.WriteLine($"{names[0]}, {names[1]} and {othersCount} others like your post.");
            //    }

            //TASK2>>>>>>>>>>>>>>>>>>>>>

            //Console.Write("Enter your name ");
            //string name=Console.ReadLine();
            //char[] nameArray = name.ToCharArray();
            //Array.Reverse(nameArray);
            //string reversedArray = new string(nameArray);
            //Console.WriteLine($"Reversed array is {reversedArray}");

            //TASK3>>>>>>>>>>>>>>>>>>>>>>

            //List<int> numbers = new List<int>();

            //Console.WriteLine("Enter 5 unique numbers:");

            //while (numbers.Count < 5)
            //{
            //    Console.Write($"Enter number {numbers.Count + 1}: ");
            //    string input = Console.ReadLine();

            //    if (int.TryParse(input, out int number))
            //    {
            //        if (numbers.Contains(number))
            //        {
            //            Console.WriteLine("Error: This number has already been entered. Please enter a unique number.");
            //        }
            //        else
            //        {
            //            numbers.Add(number);
            //        }
            //    }
            //    else
            //    {
            //        Console.WriteLine("Error: Please enter a valid integer.");
            //    }
            //}

            //// Sort the numbers
            //numbers.Sort();

            //// Display the sorted numbers
            //Console.WriteLine("Sorted numbers: " + string.Join(", ", numbers));

            //TASK>>>>>>>>>>>>>>>>>>>>>>>.

            //HashSet<int> uniqueNumbers = new HashSet<int>();

            //Console.WriteLine("Enter numbers (type 'Quit' to exit):");

            //while (true)
            //{
            //    Console.Write("Enter a number or 'Quit': ");
            //    string input = Console.ReadLine();

            //    // Check if the user wants to quit
            //    if (input?.ToLower() == "quit")
            //    {
            //        break;
            //    }

            //    // Try to parse the input as a number
            //    if (int.TryParse(input, out int number))
            //    {
            //        uniqueNumbers.Add(number); // Add to the set (duplicates are ignored automatically)
            //    }
            //    else
            //    {
            //        Console.WriteLine("Invalid input. Please enter a valid number or 'Quit'.");
            //    }
            //}

            //// Display the unique numbers
            //Console.WriteLine("Unique numbers entered: " + string.Join(", ", uniqueNumbers));
            //

            //TASK5>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>.

            //while (true)
            //{
            //    // Prompt the user to enter a list of numbers
            //    Console.Write("Enter a list of at least 5 comma-separated numbers: ");
            //    string input = Console.ReadLine();

            //    // Split the input into an array and try to parse it as integers
            //    string[] parts = input.Split(',');
            //    List<int> numbers = new List<int>();

            //    foreach (string part in parts)
            //    {
            //        if (int.TryParse(part.Trim(), out int number))
            //        {
            //            numbers.Add(number);
            //        }
            //    }

            //    // Validate the list
            //    if (numbers.Count < 5)
            //    {
            //        Console.WriteLine("Invalid List. Please enter at least 5 numbers.");
            //    }
            //    else
            //    {
            //        // Sort the numbers and get the three smallest
            //        var smallestNumbers = numbers.OrderBy(n => n).Take(3);

            //        // Display the result
            //        Console.WriteLine("The three smallest numbers are: " + string.Join(", ", smallestNumbers));
            //        break;
            //    }
            //}

            //var fullName = "Muhammad Awais ";
            //Console.WriteLine("Trim '{0}'",fullName.Trim());
            //Console.WriteLine("To uppercase: '{0}'",fullName.ToUpper());

            //var index=fullName.IndexOf(' ');
            //var firstName=fullName.Substring(0,index);
            //var lastName=fullName.Substring(index+1);
            //Console.WriteLine("First name "+firstName);
            //Console.WriteLine("Last name "+lastName);

            //var sentence = "This is going to be really really really really really long summary";
            //var summary = stringutility.Summarizetext(sentence, 25);
            //Console.WriteLine(summary);

            //Console.Write("Enter a series of numbers separated by a hyphen: ");
            //string input = Console.ReadLine();

            //// Split the input into an array of strings
            //string[] parts = input.Split('-');

            //// Try to parse the strings into integers
            //int[] numbers;
            //try
            //{
            //    numbers = parts.Select(int.Parse).ToArray();
            //}
            //catch
            //{
            //    Console.WriteLine("Invalid input. Please enter valid integers separated by hyphens.");
            //    return;
            //}

            //// Check if the numbers are consecutive
            //bool isConsecutive = true;
            //for (int i = 1; i < numbers.Length; i++)
            //{
            //    if (Math.Abs(numbers[i] - numbers[i - 1]) != 1)
            //    {
            //        isConsecutive = false;
            //        break;
            //    }
            //}

            //// Display the result
            //if (isConsecutive)
            //{
            //    Console.WriteLine("Consecutive");
            //}
            //else
            //{
            //    Console.WriteLine("Not Consecutive");
            //}


            //task2>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>

            //    while (true) {
            //    Console.Write("Enter a few numbers separated by a hyphen (or press Enter to exit): ");
            //    string input = Console.ReadLine();

            //    // Exit if the input is empty
            //    if (string.IsNullOrWhiteSpace(input))
            //    {
            //        break;
            //    }

            //    // Split the input and parse the numbers
            //    string[] parts = input.Split('-');
            //    List<int> numbers = new List<int>();

            //    try
            //    {
            //        numbers = parts.Select(int.Parse).ToList();
            //    }
            //    catch
            //    {
            //        Console.WriteLine("Invalid input. Please enter valid numbers separated by hyphens.");
            //        continue;
            //    }

            //    // Check for duplicates
            //    bool hasDuplicates = numbers.GroupBy(n => n).Any(g => g.Count() > 1);

            //    // Display the result
            //    if (hasDuplicates)
            //    {
            //        Console.WriteLine("Duplicate");
            //    }
            //    else
            //    {
            //        Console.WriteLine("No Duplicates");
            //    }

            //}

            //TASK3>>>>>>>>>>>>>>>>>>>>>>>>>>>><<<<<<<<<<<<<<<<<<
            //Console.Write("Enter a time in 24-hour format (e.g., 19:00): ");
            //string input = Console.ReadLine();

            //// Check if the input is empty
            //if (string.IsNullOrWhiteSpace(input))
            //{
            //    Console.WriteLine("Invalid Time");
            //    return;
            //}

            //// Validate the input format
            //if (TimeSpan.TryParse(input, out TimeSpan time))
            //{
            //    // Check if the time is within the valid range
            //    if (time >= TimeSpan.Zero && time <= TimeSpan.FromHours(23) + TimeSpan.FromMinutes(59))
            //    {
            //        Console.WriteLine("Ok");
            //    }
            //    else
            //    {
            //        Console.WriteLine("Invalid Time");
            //    }
            //}
            //else
            //{
            //    Console.WriteLine("Invalid Time");
            //}

            //TASK4>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>


            // Ask the user to enter words

            //Console.Write("Enter a few words separated by a space: ");
            //string input = Console.ReadLine();

            //// Check if the input is empty
            //if (string.IsNullOrWhiteSpace(input))
            //{
            //    Console.WriteLine("Invalid input. Please enter at least one word.");
            //    return;
            //}

            //// Split the input into words and convert to PascalCase
            //string pascalCase = string.Join("", input
            //    .ToLowerInvariant()
            //    .Split(' ', StringSplitOptions.RemoveEmptyEntries)
            //    .Select(word => CultureInfo.CurrentCulture.TextInfo.ToTitleCase(word)));

            //// Display the PascalCase variable name
            //Console.WriteLine("PascalCase Variable Name: " + pascalCase);

            //TASK5<<<<<<<<<<<<<>>>>>>>>>>>>>>>>>

            // Ask the user to enter a word
            //Console.Write("Enter an English word: ");
            //string input = Console.ReadLine();

            //// Check if the input is empty
            //if (string.IsNullOrWhiteSpace(input))
            //{
            //    Console.WriteLine("Invalid input. Please enter a valid word.");
            //    return;
            //}

            //// Define vowels
            //char[] vowels = { 'a', 'e', 'i', 'o', 'u' };

            //// Count vowels in the input
            //int vowelCount = 0;
            //foreach (char c in input.ToLower())
            //{
            //    if (Array.Exists(vowels, vowel => vowel == c))
            //    {
            //        vowelCount++;
            //    }
            //}
            //// Display the result
            //Console.WriteLine($"The number of vowels in '{input}' is: {vowelCount}");

            //filing exercise
            string filePath = @"C:\Users\Awais\Desktop\file.txt";
            var name = "C# Fundamentals";

            // Check if the file exists
            if (!File.Exists(filePath))
            {
                Console.WriteLine("File not found. Please provide a valid file path.");
                return;
            }

            try
            {
                // Read all text from the file
                string content = File.ReadAllText(filePath);

                // Split the text into words
                string[] words = content.Split(
                    new[] { ' ', '\n', '\r', '\t' },
                    StringSplitOptions.RemoveEmptyEntries);

                int wordCount = words.Length;
                string longestWord = words.OrderByDescending(w => w.Length).FirstOrDefault();

                // Count the words and display the result
                Console.WriteLine($"The number of words in the file is: {wordCount}");
                Console.WriteLine($"The longest word in file is:{longestWord}");
                Console.WriteLine($"The longest word in file is:{longestWord}");
                Console.WriteLine($"I have completed the Course: {name}");
                Console.WriteLine($"I have completed the Course: {name}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred: {ex.Message}");
            }
            
        }
    }
}

