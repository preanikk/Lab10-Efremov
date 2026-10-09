// using System.Diagnostics.CodeAnalysis;

// string subject =  "Программирование";

// foreach (char letter in subject)
// {
//     Console.WriteLine(letter);
// }
// Console.WriteLine(subject.Length);

// int[] grades = { 4, 5, 3, 5, 4 };
// int sum = 0;
// foreach (int grade in grades)
// {
//     Console.WriteLine(grade);
//     sum++;
// }
// Console.WriteLine(sum / grades.Length);


// string[] students = { "Аня", "Ярослав", "Вика" };
// int count = 0;
// foreach (string student in students)
// {
//     Console.WriteLine(student);
//     count++;
// }
// Console.WriteLine(count);


int[] points = { 10, 20, 15 };

for (int i = 0; i < points.Length; i++)
{
    Console.WriteLine(points[i] + 5);
}


// string[] students = { "Аня", "Борис", "Вика" };
// int number = 1;

// foreach (string student in students)
// {
//     Console.WriteLine($"{number}. {student}");
//     number++;
// }

// // Задача А
// int[] numbers = { 3, 5, 4, 2, 7 };
// int sum = 0;
// foreach (int number in numbers)
// {
//     Console.WriteLine(number);
//     sum += number;
// }
// Console.WriteLine(sum);


// using System.Diagnostics.CodeAnalysis;

// string[] days = { "Понедельник", "Вторник", "Среда", "Четверг", "Пятница", "Суббота", "Воскресенье" };
// foreach(string day in days)
// {
//     Console.WriteLine($"{day} !");
// }


// Console.Write("Введите свою фамилию: ");
// string surname = Console.ReadLine()!.Trim();
// if (string.IsNullOrEmpty(surname)) {
//     Console.WriteLine("Фамилия не введена. Завершение работы.");
//     return;
// }
// Random rnd = new(surname.GetHashCode() + DateTime.Now.DayOfYear);
// var assigned = Enumerable.Range(1, 10)
//     .OrderBy(_ => rnd.Next())
//     .Take(2)
//     .OrderBy(x => x)
//     .ToList();
// Console.WriteLine($"Задачи: №{assigned[0]} и №{assigned[1]}");  

// // Вариант 4
// int[] prices = { 890, 430, 280, 1120, 812 };
// int sum = 0;
// int count = 0;
// foreach (int price in prices)
// {
//     sum += price;
//     if (price >= 500)
//         count++;
// }
// Console.WriteLine(sum);
// Console.WriteLine(count);


// // Вариант 8
// string word = "pomidor";

// for (int i = word.Length - 1; i >= 0; i--)
// {
//     Console.WriteLine(word[i]);
// }