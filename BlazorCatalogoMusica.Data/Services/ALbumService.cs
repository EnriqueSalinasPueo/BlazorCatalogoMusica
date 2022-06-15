using BlazorCatalogoMusica.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlazorCatalogoMusica.Data.Services
{
    public class ALbumService : IAlbumService
    {
        private readonly AlbulMusicCatalogoContext _context;

        public ALbumService(AlbulMusicCatalogoContext context)
        {
            _context = context;
        }

        public async Task<bool> DeleteAlbum(Album album)
        {
            _context.Remove(album);

            return await _context.SaveChangesAsync() > 0;
        }

        public async Task<Album> GetAlbumDetails(int id)
        {
            return await _context.Albums
                  .Where(s => s.Id == id)
                  .Include(s => s.Songs)
                  .FirstOrDefaultAsync();
        }

        public async Task<IEnumerable<Album>> GetAlbums()
        {
            return await _context.Albums.ToListAsync();
        }

        public async Task<bool> InsertAlbum(Album album)
        {
            _context.Add(album);
            return await _context.SaveChangesAsync() > 0;
        }

        public async Task<bool> UpdateAlbum(Album album)
        {
            _context.Update(album);

            return await _context.SaveChangesAsync() > 0;
        }
    }
}
