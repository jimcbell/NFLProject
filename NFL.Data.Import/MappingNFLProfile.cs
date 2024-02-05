using AutoMapper;
using Nfl.SqlServer.DataContext.Entities;
using NFLDataImport.Models;


namespace NFLDataImport;

public class MappingNFLProfile: Profile
{
    public MappingNFLProfile()
    {
        CreateMap<NflRecord, NflPlay>();
    }
}
