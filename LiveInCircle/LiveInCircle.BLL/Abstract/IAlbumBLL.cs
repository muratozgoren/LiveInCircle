using LiveInCircle.Model.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace LiveInCircle.BLL.Abstract
{
    public interface IAlbumBLL : IBaseBLL<Album>
    {
        ICollection<Album> GetLatestAlbum();
        ICollection<Album> GetDisCountAlbum();
        public Album GetCartItem(int entityID);
    }
}
