using AutoMapper;
using HotelListing5._0.Data;
using HotelListing5._0.Models;

namespace HotelListing5._0.Configurations
{
    public class MapperInitilizer : Profile
    {

        public MapperInitilizer() { 
        
            CreateMap<Country, CountryDTO>().ReverseMap();
            CreateMap<Country, CreateCountryDTO>().ReverseMap();
            CreateMap<Hotel, HotelDTO>().ReverseMap();
            CreateMap<Hotel, CreateHotelDTO>().ReverseMap();
        }
    }
}
