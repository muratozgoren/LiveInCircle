using LiveInCircle.Core.DataAccess.EntityFramework;
using LiveInCircle.DAL.Abstract;
using LiveInCircle.Model.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace LiveInCircle.DAL.Concrete.Repository
{
    class GenreRepository : EFRepositoryBase<Genre, LiveInCircleDbContext>,IGenreDAL
    {
    }
}
