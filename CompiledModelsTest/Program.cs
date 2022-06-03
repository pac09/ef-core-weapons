using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Running;
//using Models;
using CompiledModelTest;

[SimpleJob(invocationCount: 1000, targetCount: 100)]
public class Test
{
    [Benchmark]
    public void TimeToFirstQuery()
    {
        using var context = new BlogsContext();
        var results = context.Set<Blog0000>().ToList();
    }
}

public class Program
{
    public static void Main(string[] args) 
    {
        PrintResults();
        var summary = BenchmarkRunner.Run<Test>();
    }

    public static void PrintResults() 
    {
        using var context = new BlogsContext();
        var model = context.Model;

        Console.WriteLine("Model has:");
        Console.WriteLine($"    {model.GetEntityTypes().Count()} entity types");
        Console.WriteLine($"    {model.GetEntityTypes().SelectMany(e => e.GetProperties()).Count()} properties");
        Console.WriteLine($"    {model.GetEntityTypes().SelectMany(e => e.GetForeignKeyProperties()).Count()} relationships");
    }
}