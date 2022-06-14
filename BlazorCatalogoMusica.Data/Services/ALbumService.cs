using BlazorCatalogoMusica.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlazorCatalogoMusica.Data.Services
{
    class ALbumService : IAlbumService
    {
        private readonly AlbulMusicCatalogoContext _context;

        public ALbumService(AlbulMusicCatalogoContext context)
        {
            _context = context;
        }

        public Task<bool> DeleteAlbum(Album album)
        {
            throw new NotImplementedException();
        }

        public Task<Album> GetAlbumDetails(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Album>> GetAlbums()
        {
            throw new NotImplementedException();
        }

        public Task<bool> InsertAlbum(Album album)
        {
            throw new NotImplementedException();
        }

        public Task<bool> UpdateAlbum(Album album)
        {
            throw new NotImplementedException();
        }
    }
}
