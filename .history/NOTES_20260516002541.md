# CSE 325 - Week 1 Notes

## Part 1 - ASP.NET Core Web API

Additional pizza record added successfully using a POST request:

```http
HTTP/1.1 201 Created

{
  "id": 3,
  "name": "Hawaii",
  "isGlutenFree": false
}
```

The API was tested successfully using:
- GET
- POST
- PUT
- DELETE

---

## Part 2 - Sales Summary Function

```csharp
void GenerateSalesSummary(IEnumerable<string> salesFiles, double totalSales, string outputDirectory)
{
    StringBuilder report = new StringBuilder();

    report.AppendLine("Sales Summary");
    report.AppendLine("----------------------------");
    report.AppendLine($"Total Sales: {totalSales:C}");
    report.AppendLine();
    report.AppendLine("Details:");

    foreach (var file in salesFiles)
    {
        string salesJson = File.ReadAllText(file);

        SalesData? data = JsonConvert.DeserializeObject<SalesData?>(salesJson);

        double fileTotal = data?.Total ?? 0;

        report.AppendLine($"{Path.GetFileName(file)}: {fileTotal:C}");
    }

    File.WriteAllText(
        Path.Combine(outputDirectory, "sales-summary.txt"),
        report.ToString()
    );

    Console.WriteLine("Sales summary report created!");
}
```