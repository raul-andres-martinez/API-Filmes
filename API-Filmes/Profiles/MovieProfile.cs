using API_Filmes.Data.DTOs;
using API_Filmes.Models;
using AutoMapper;

namespace API_Filmes.Profiles
{
    public class MovieProfile : Profile
    {
        public MovieProfile() 
        {
            CreateMap<CreateMovieDto, Movie>();
        }
    }
}
