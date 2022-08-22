using Application.Dto;
using Application.Dto.LogReading;
using Application.Queries.Log;
using Application.Searches.LogSearches;
using DataAccess;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Implementation.Queries.Log
{
    public class GetAllLog : IGetAllLog
    {
        private readonly Context context;

        public GetAllLog(Context context)
        {
            this.context = context;
        }

        public int Id_UseCase => 25;

        public string Name_UseCase => "Get's all the logs";

        public PaginationReturn<GetAllLogDto> Query(LogSearch search)
        {
            var putanja = Path.Combine("wwwroot", "Logs", "logs.txt");
            var Redovi = new List<GetAllLogDto>();
            using (StreamReader stream = File.OpenText(putanja))
            {
                string s;
                while ((s = stream.ReadLine()) != null)
                {
                    var splitovan = s.Split("__||__");
                    if (search.UseCaseIndentification != null && search.UseCaseIndentification != 0)
                    {
                        if (splitovan[3] == search.UseCaseIndentification.ToString())
                        {
                            Redovi.Add(new GetAllLogDto()
                            {
                                IdUsecase = splitovan[3],
                                NameUseCase = splitovan[2],
                                WhenDone = splitovan[0]
                            });
                        }
                    }
                    else
                    {
                        Redovi.Add(new GetAllLogDto()
                        {
                            IdUsecase = splitovan[3],
                            NameUseCase = splitovan[2],
                            WhenDone = splitovan[0]
                        });
                    }
                }
            }
            return new PaginationReturn<GetAllLogDto>()
            {
                CurrentPage = search.Page,
                PerPage = search.PerPage,
                TotalCount = Redovi.Count(),
                Data = Redovi.Skip((search.Page - 1) * search.PerPage).Take(search.PerPage).Select(x => new GetAllLogDto()
                {
                    IdUsecase = x.IdUsecase,
                    NameUseCase = x.NameUseCase,
                    WhenDone = x.WhenDone
                }).ToList()
            };
        }
    }
}
