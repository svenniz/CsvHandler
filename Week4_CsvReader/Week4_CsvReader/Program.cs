// See https://aka.ms/new-console-template for more information
using Week4_CsvReader.Services;
using Week4_CsvReader.Services.Interfaces;
Console.WriteLine("Hello, World!");
var filepath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "SampleData\\country_full.csv");
var fileEurope = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "SampleData\\country_europe.csv");
var fileAfrica = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "SampleData\\country_africa.csv");

ICsvFileReader fileReader = new CsvFileReader();
ICsvPrinter printer = new CsvPrinter();
ICsvSorter sorter = new CsvSorter();
ICsvExporter exporter = new CsvExporter();

//4 
var records = fileReader.ReadCsv(filepath);
var filteredRegionAfricaRecords = fileReader.ReadFilteredCsv(filepath, "region", "Africa");
var filteredRegionEuropeRecords = fileReader.ReadFilteredCsv(filepath, "region", "Europe");
printer.PrintCsv(records);
exporter.ExportToCsv(filteredRegionAfricaRecords, fileAfrica);
exporter.ExportToCsv(filteredRegionEuropeRecords, fileEurope);