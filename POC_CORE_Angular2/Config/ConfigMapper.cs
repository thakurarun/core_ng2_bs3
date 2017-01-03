using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using MovieLibrary.Models;
using POC_CORE_Angular2.WebModel.DTO;
namespace POC_CORE_Angular2.Config
{
    public static class ConfigMapper
    {
        public static void Initialize()
        {
            Mapper.Initialize(cfg =>
            {
                // cfg.CreateMap<Source, Dest>();
                cfg.CreateMap<Movie, MovieDTO>()
                .ForMember(movieDTO => movieDTO.torrentDTOs, movie => movie.MapFrom(src => src.torrents));
                cfg.CreateMap<Torrent, TorrentDTO>();
            });
        }
    }
}
