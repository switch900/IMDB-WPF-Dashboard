﻿using ImdbServiceApp.DAL;

namespace ImdbServiceApp
{
    public class ImdbService : ImdbRepository, IImdbService { }
}
   //   public class ImdbService : IImdbService
    
 /*   {
        private DbContext Context { get; set; }


        public ImdbService(DbContext inContext)
        {
            Context = inContext;
        }

        public IEnumerable<Movies> GetAllMovies()
        {
            using (var ctx = new ImdbEntities())
            {
                var people = from item in ctx.Movies
                             select new Movies
                             {
                                 tconst = item.tconst,
                                 titleType = item.titleType,
                                 primaryTitle = item.primaryTitle,
                                 originalTitle = item.originalTitle,
                                 isAdult = item.isAdult,
                                 startYear = item.startYear,
                                 endYear = item.endYear,
                                 runtimeMinutes = item.runtimeMinutes,
                                 genres = item.genres
                             };

                return people.ToList();
            }
        }

        public int CountAllMoviesByPredicate(string predicate)
        {
            using (ImdbEntities ctx = new ImdbEntities())
            {           
               var _moviesCount = ctx.Movies
                       .SqlQuery("Select * from [IMDb].[movie].[titlebasics] where primaryTitle like '%" + predicate + "%' order by tconst").Count();
                return _moviesCount;
            }
        }

        public IEnumerable<Movies> GetAllMoviesPaged(string predicate, int pagesize, int startindex)
        {
            using (ImdbEntities ctx = new ImdbEntities())
            {
                var _movies = ctx.Movies
                       .SqlQuery("Select * from [IMDb].[movie].[titlebasics] where primaryTitle like '%" + predicate + "%' order by tconst offset " + startindex + " rows fetch next " + pagesize + " rows only ")
                       .ToList<Movies>();
                return _movies;
            }
        }

        public IEnumerable<Movies> GetAllMoviesByPredicate(string predicate)
        {
            using (ImdbEntities ctx = new ImdbEntities())
            {
                var _movies = ctx.Movies
                       .SqlQuery("Select * from [IMDb].[movie].[titlebasics] where primaryTitle like '%" + predicate + "%'")
                       .ToList<Movies>();
                return _movies;
            }
        }

        public async Task<IEnumerable<Movies>> GetAllMoviesByPredicateAsync(string predicate)
        {
            using (ImdbEntities ctx = new ImdbEntities())
            {
                var _movies = await ctx.Movies
                       .SqlQuery("Select * from [IMDb].[movie].[titlebasics] where primaryTitle like '%" + predicate + "%'")
                       .ToListAsync();
                return _movies;
            }
        }

        public async Task<int> GetAllMoviesByPredicateCountAsync(string predicate)
        {
            using (ImdbEntities ctx = new ImdbEntities())
            {
                var _movies = ctx.Movies
                       .SqlQuery("Select * from [IMDb].[movie].[titlebasics] where primaryTitle like '%" + predicate + "%'")
                       .CountAsync();
                return await _movies;
            }

        }

        public Movies GetAllMoviesById(string id)
        {
            ImdbEntities tstDb = new ImdbEntities();
            var lstUsr = from k in tstDb.Movies where k.tconst == id select k;
            Movies usr = new Movies();
            foreach (var item in lstUsr)
            {
                usr.tconst = item.tconst;
                usr.titleType = item.titleType;
                usr.primaryTitle = item.primaryTitle;
                usr.originalTitle = item.originalTitle;
                usr.isAdult = item.isAdult;
                usr.startYear = item.startYear;
                usr.endYear = item.endYear;
                usr.runtimeMinutes = item.runtimeMinutes;
                usr.genres = item.genres;
            }
            return usr;
        }

        public int DeleteMovieById(string Id)
        {
            ImdbEntities tstDb = new ImdbEntities();
            Movies usrdtl = new Movies
            {
                tconst = Id
            };
            tstDb.Entry(usrdtl).State = EntityState.Deleted;
            int Retval = tstDb.SaveChanges();
            return Retval;
        }

        public int AddMovie(Movies movie)
        {
            ImdbEntities tstDb = new ImdbEntities();
            Movies usrdtl;
            usrdtl = movie;
            tstDb.Entry(usrdtl).State = EntityState.Added;
            int Retval = tstDb.SaveChanges();
            return Retval;          
        }

        public int UpdateMovie(Movies movie)
        {
            ImdbEntities tstDb = new ImdbEntities();
            Movies usrdtl;
            usrdtl = movie;
            tstDb.Entry(usrdtl).State = EntityState.Modified;
            int Retval = tstDb.SaveChanges();
            return Retval;
        }
    }
}


*/