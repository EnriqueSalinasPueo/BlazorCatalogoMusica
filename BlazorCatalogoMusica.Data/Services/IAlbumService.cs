using BlazorCatalogoMusica.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BlazorCatalogoMusica.Data.Services
{
    interface IAlbumService
    {
        Task<IEnumerable<Album>> GetAlbums();
        Task<Album> GetAlbumDetails(int id);
        Task<bool> InsertAlbum(Album album);
        Task<bool> UpdateAlbum(Album album);
        Task<bool> DeleteAlbum(Album album);
    }
}
