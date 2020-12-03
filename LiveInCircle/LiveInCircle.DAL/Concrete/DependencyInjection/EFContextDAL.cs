using LiveInCircle.DAL.Abstract;
using LiveInCircle.DAL.Concrete.Repository;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;

namespace LiveInCircle.DAL.Concrete.DependencyInjection
{
    public static class EFContextDAL
    {
        public static  void AddScopeDAL(this IServiceCollection services)
        {
            services.AddScoped<IAlbumDAL, AlbumRepository>();
            services.AddScoped<IArtistDAL, ArtistRepository>();
            services.AddScoped<IGenreDAL, GenreRepository>();
            services.AddScoped<IOrderDAL, OrderRepository>();
            services.AddScoped<IUserDAL, UserRepository>();
        }
    }
}
