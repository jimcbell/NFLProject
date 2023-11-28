using CsvHelper;
using NFLDataImport.Models;
using System;
using System.Globalization;


string nflImportFile = "cleaned-nfl-data.csv";
string path = Path.Combine(Environment.CurrentDirectory, @"ImportData\", nflImportFile);
using (StreamReader reader = new(path))
using (CsvReader csvReader = new(reader, CultureInfo.InvariantCulture))
{
    var records = csvReader.GetRecords<NflRecord>().ToList();
}
Console.ReadLine();