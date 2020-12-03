using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LiveInCircle.BLL.Abstract;
using LiveInCircle.Model.Entities;
using LiveInCircle.Service.ASPWebAPI.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace LiveInCircle.Service.ASPWebAPI.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class AlbumController : ControllerBase
    {
        IAlbumBLL albumBLL;
        public AlbumController(IAlbumBLL bll)
        {
            albumBLL = bll;
        }

        List<AlbumDTO> AlbumDtoList(ICollection<Album> listAlbums)
        {
            List<AlbumDTO> albums = new List<AlbumDTO>();
            foreach (Album item in listAlbums)
            {
                albums.Add(new AlbumDTO()
                {
                    AlbumID = item.ID,
                    Title = item.Title,
                    AlbumArtUrl = item.AlbumArtUrl,
                    Price = item.Price,
                    ArtistName = item.Artist.FullName

                });
            }
            return albums;
        }
        public IActionResult GetLatestAlbums()
        {
            List<AlbumDTO> albums = AlbumDtoList(albumBLL.GetLatestAlbum());
            
            return Ok(albums);
        }

        public IActionResult GetDisCountAlbums()
        {
            List<AlbumDTO> albums = AlbumDtoList(albumBLL.GetDisCountAlbum());
            return Ok(albums);
        }
        [HttpGet("{id}")]
        public IActionResult GetAlbumById(int id)
        {
            Album album = albumBLL.Get(id);
            AlbumGenreDTO albumDTO = new AlbumGenreDTO();
            albumDTO.AlbumID = album.ID;
            albumDTO.Title = album.Title;
            albumDTO.ArtistName = album.Artist.FullName;
            albumDTO.AlbumArtUrl = album.AlbumArtUrl;
            albumDTO.GenreName = album.Gengre.Name;
            albumDTO.Price = album.Price;
            return Ok(albumDTO);
        }


        [HttpGet("{id}")]
        public IActionResult GetCartItemByID(int id)
        {
            Album album = albumBLL.GetCartItem(id);
            CartDTO cartDTO = new CartDTO();
            cartDTO.ID = album.ID;
            cartDTO.Name = album.Title;
            cartDTO.Price = album.Price;
            return Ok(cartDTO);
        }
    }
}
