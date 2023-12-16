using AutoMapper;
using CsvHelper;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using NFL.SqlServer.DataContext;
using NFL.SqlServer.DataContext.Entities;
using NFLDataImport;
using NFLDataImport.Models;
using System;
using System.Globalization;


// Host the console app
//IServiceCollection services = new ServiceCollection();

IConfigurationBuilder builder = new ConfigurationBuilder().AddJsonFile("appsettings.json",false,true);

IConfigurationRoot configuration = builder.Build();
//IServiceProvider serviceProvider = services.BuildServiceProvider();

var mapperConfig = new MapperConfiguration(mc =>
{
    mc.AddProfile(new MappingNFLProfile());
});
IMapper mapper = mapperConfig.CreateMapper();

string nflImportFile = "cleaned-nfl-data.csv";
string path = Path.Combine(Environment.CurrentDirectory, @"ImportData\", nflImportFile);
List<NflRecord> records;
using (StreamReader reader = new(path))
{
    using (CsvReader csvReader = new(reader, CultureInfo.InvariantCulture))
    {
        records = csvReader.GetRecords<NflRecord>().ToList();
    }
}

List<NFLPlay> nflPlays = mapper.Map<List<NFLPlay>>(records);
string? connectionString = configuration.GetConnectionString("NFL");
if (string.IsNullOrEmpty(connectionString))
{
    throw new Exception("Connection string is null or empty.");
}
DbContextOptions options = new DbContextOptionsBuilder<NFLDataContext>()
    .UseSqlServer(connectionString)
    .Options;
NFLDataContext context = new();
context.AddRange(nflPlays);
context.SaveChanges();
Console.ReadLine();