using POC_CORE_Angular2.WebModel.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace POC_CORE_Angular2.WebModel
{
    public class MovieSearchResult : ResultModel
    {
        public IEnumerable<MovieDTO> movies;
    }
}
