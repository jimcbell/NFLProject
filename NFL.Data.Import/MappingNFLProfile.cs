using AutoMapper;
using NFL.SqlServer.DataContext.Entities;
using NFLDataImport.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace NFLDataImport;

public class MappingNFLProfile: Profile
{
    public MappingNFLProfile()
    {
        CreateMap<NflRecord, NflPlay>();
    }
}
