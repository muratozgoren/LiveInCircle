using LiveInCircle.BLL.Abstract;
using LiveInCircle.DAL.Concrete.DependencyInjection;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;

namespace LiveInCircle.BLL.Concrete.DependencyInjection
{
    public static class EFContextBLL
    {
        public static void AddScopeBLL(this IServiceCollection services)
        {
            services.AddScopeDAL();
            services.AddScoped<IAlbumBLL, AlbumService>();
            services.AddScoped<IArtistBLL, ArtistService>();
            services.AddScoped<IUserBLL, UserService>();
            services.AddScoped<IGenreBLL, GenreService>();
            services.AddScoped<IOrderBLL, OrderService>();
        }
    }
}
