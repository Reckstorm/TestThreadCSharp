//new Thread(() =>
//{
//    while (true)
//    {
//        File.WriteAllText(@"C:\Users\Admin\Desktop\1.txt", $"{DateTime.Now.ToLocalTime()}\n");
//        Console.WriteLine($"{DateTime.Now.ToLocalTime()}");
//        Thread.Sleep(60000);
//    }
//}).Start();
//Console.Read();

using System.Runtime.CompilerServices;

List<string> list = new List<string>();
int sum = 0;

Thread readTh = new Thread(() =>
{
    list.AddRange(File.ReadAllLines(@"C:\Users\Admin\Desktop\1.txt"));
});


Thread sumTh = new Thread(() =>
{
    list.ForEach(x => sum += int.Parse(x));
    Console.WriteLine(sum);
});


readTh.Start();
readTh.Join();
sumTh.Start();

