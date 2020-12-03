using LiveInCircle.BLL.Abstract;
using LiveInCircle.DAL.Abstract;
using LiveInCircle.Model.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace LiveInCircle.BLL.Concrete
{
    class GenreService : IGenreBLL
    {
        IGenreDAL genreDAL;
        public GenreService(IGenreDAL dal)
        {
            genreDAL = dal;
        }
        void Check(Genre genre)
        {
            if (string.IsNullOrEmpty(genre.Name) || string.IsNullOrEmpty(genre.Description))
            {
                throw new Exception("Tür adı ve açıklaması boş geçilemez");
            }
        }
        public void Insert(Genre entity)
        {
            Check(entity);
            genreDAL.Add(entity);
        }
        public void Update(Genre entity)
        {
            Check(entity);
            genreDAL.Update(entity);
        }
        public void Delete(Genre entity)
        {
            entity.IsActive = false;
            genreDAL.Update(entity);
        }

        public void DeleteByID(int entityID)
        {
            Genre genre = Get(entityID);
            genre.IsActive = false;
            genreDAL.Update(genre);
        }

        public Genre Get(int entityID)
        {
            return genreDAL.Get(a => a.ID == entityID);
        }

        public ICollection<Genre> GetAll()
        {
            return genreDAL.GetAll();
        }
    }
}
