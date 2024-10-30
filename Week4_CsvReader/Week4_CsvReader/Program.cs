// See https://aka.ms/new-console-template for more information
using Week4_CsvReader.Services;
using Week4_CsvReader.Services.Interfaces;
Console.WriteLine("Hello, World!");
var filepath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "SampleData\\country_full.csv");
var fileOut = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "SampleData\\country_out.csv");
var fileAfrica = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "SampleData\\country_africa.csv");

ICsvFileReader fileReader = new CsvFileReader();
ICsvPrinter printer = new CsvPrinter();
ICsvSorter sorter = new CsvSorter();
ICsvExporter exporter = new CsvExporter();

//4 
var records = fileReader.ReadCsv(filepath);
var filteredRecords = fileReader.ReadFilteredCsv(filepath, "region", "Africa");
printer.PrintCsv(filteredRecords);
exporter.ExportToCsv(filteredRecords, fileAfrica);