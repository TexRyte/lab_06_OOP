using System;

// Ex 1
Console.WriteLine("Exercise #1");

List<int> nums =  new List<int>();
Random rand = new Random(); 

Console.WriteLine("Введiть кiлькiсть випадкових чисел: ");
int N = int.Parse(Console.ReadLine());

for  (int i = 0; i < N; i++)
{
    nums.Add(rand.Next(10, 90));
}

for (int i =0; i < nums.Count; i++)
{
    Console.WriteLine(nums[i]);
}

// Ex 2
Console.WriteLine("Exercise #2");

Console.WriteLine("Введiть кiлькiсть випадкових чисел: ");
N = int.Parse(Console.ReadLine());

nums.Clear();

for (int i = 0; i < N; i++)
{
    nums.Add(rand.Next(10, 99));
}

Console.WriteLine("Введiть число: ");
int x = int.Parse(Console.ReadLine());

for (int i = nums.Count - 1; i >= 0; i--)
{
    if (Convert.ToString(nums[i])[0] == Convert.ToString(nums[i])[1])
    {
        nums.Insert(i, x);
    }
}

for (int i = 0; i < nums.Count; i++)
{
    Console.WriteLine(nums[i]);
}
// Ex 3
Console.WriteLine("Exercise #3");

Console.WriteLine("Введiть кiлькiсть випадкових чисел: ");
N = int.Parse(Console.ReadLine());

nums.Clear();

for (int i = 0; i < N; i++)
{
    nums.Add(rand.Next(-5, 5));
}

List<int> positive = new List<int>();
List<int> negative = new List<int>();
List<int> neutral = new List<int>();

for (int i = 0; i < nums.Count; i++)
{
    if (nums[i] > 0)
    {
        positive.Add(nums[i]);
    }
    else if (nums[i] < 0)
    {
        negative.Add(nums[i]);
    }
    else
    {
        neutral.Add(nums[i]);
    }
}

for (int i = 0; i < nums.Count; i++)
{
    Console.WriteLine(nums[i]);
}

Console.WriteLine("Додатнi:");
for (int i = 0; i < positive.Count; i++)
{
    Console.WriteLine(positive[i]);
}
Console.WriteLine("Вiд'ємнi:");
for (int i = 0; i < negative.Count; i++)
{
    Console.WriteLine(negative[i]);
}
Console.WriteLine("Нейтральнi:");
for (int i = 0; i < neutral.Count; i++)
{
    Console.WriteLine(neutral[i]);
}
