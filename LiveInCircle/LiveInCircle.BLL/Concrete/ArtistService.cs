using LiveInCircle.BLL.Abstract;
using LiveInCircle.DAL.Abstract;
using LiveInCircle.Model.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace LiveInCircle.BLL.Concrete
{
    class ArtistService : IArtistBLL
    {
        IArtistDAL artistDAL;
        public ArtistService(IArtistDAL dal)
        {
            artistDAL = dal;
        }
        void Check(Artist artist)
        {
            if (string.IsNullOrEmpty(artist.FullName)||string.IsNullOrEmpty(artist.Bio))
            {
                throw new Exception("Artist adı ve açıklaması boş geçilemez");
            }
        }
        public void Insert(Artist entity)
        {
            Check(entity);
            artistDAL.Add(entity);
        }
        public void Update(Artist entity)
        {
            Check(entity);
            artistDAL.Update(entity);
        }
        public void Delete(Artist entity)
        {
            entity.IsActive = false;
            artistDAL.Update(entity);
        }

        public void DeleteByID(int entityID)
        {
            Artist artist = Get(entityID);
            artist.IsActive = false;
            artistDAL.Update(artist);
        }

        public Artist Get(int entityID)
        {
            return artistDAL.Get(a => a.ID == entityID);
        }

        public ICollection<Artist> GetAll()
        {
            return artistDAL.GetAll();
        }

        

       
    }
}
