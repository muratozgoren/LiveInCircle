using LiveInCircle.BLL.Abstract;
using LiveInCircle.DAL.Abstract;
using LiveInCircle.Model.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LiveInCircle.BLL.Concrete
{
    class AlbumService : IAlbumBLL
    {
        IAlbumDAL albumDAL;
        public AlbumService(IAlbumDAL dal)
        {
            albumDAL = dal;
        }
        void CheckTitle(Album entity)
        {
            if (entity.Title.Length > 2)
            {
                throw new Exception("Albüm Adı 2 karakterden büyük olmalıdır.");
            }
        }
        #region Base Method
        public void Insert(Album entity)
        {
            CheckTitle(entity);
            albumDAL.Add(entity);
        }
        public void Update(Album entity)
        {
            CheckTitle(entity);
            albumDAL.Update(entity);
        }
        public void Delete(Album entity)
        {
            entity.IsActive = false;
            albumDAL.Update(entity);
        }

        public void DeleteByID(int entityID)
        {
            Album album = Get(entityID);
            album.IsActive = false;
            albumDAL.Update(album);
        }

        public Album Get(int entityID)
        {
            return albumDAL.Get(a => a.ID == entityID && a.Continued && a.IsActive, a => a.Artist, a => a.Gengre);
        }

        public ICollection<Album> GetAll()
        {
            return albumDAL.GetAll();
        }

        #endregion

        public ICollection<Album> GetLatestAlbum()
        {
            return albumDAL.GetAll(a => a.Continued && a.IsActive, a => a.Artist).OrderByDescending(a => a.CreatedDate).Take(10).ToList();
        }

        public ICollection<Album> GetDisCountAlbum()
        {
            return albumDAL.GetAll(a => a.Continued && a.IsActive && a.Discounted, a => a.Artist).OrderByDescending(a => a.CreatedDate).Take(18).ToList();
        }

        public Album GetCartItem(int entityID)
        {
            return albumDAL.Get(a => a.ID == entityID && a.Continued && a.IsActive);
        }

    }
}
