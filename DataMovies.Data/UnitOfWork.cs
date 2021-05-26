using GateMoviez.Data.Interface;
using GateMoviez.Data.Repositories;
using System;
using System.Collections.Generic;
using System.Text;

namespace GateMoviez.Data
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly GateMoviezDbContext _context;
        public UnitOfWork(GateMoviezDbContext context)
        {
            _context = context;
        }


        private IArtistRepository MyArtistRepo;
        public IArtistRepository ArtistRepo
        {
            get
            {
                if (MyArtistRepo == null)
                    return new ArtistRepository(_context);
                return MyArtistRepo;
            }
        }
        private IArtistTypeRepository MyArtistTypeRepo;
        public IArtistTypeRepository ArtistTypeRepo
        {
            get
            {
                if (MyArtistTypeRepo == null)
                    return new ArtistTypeRepository(_context);
                return MyArtistTypeRepo;
            }
        }

        private ICommentRepository MyCommentRepo;
        public ICommentRepository CommentRepo
        {
            get
            {
                if (MyCommentRepo == null)
                    return new CommentRepository(_context);
                return MyCommentRepo;
            }
        }

        private IVideoRepository MyVideoRepo;
        public IVideoRepository VideoRepo
        {
            get
            {
                if (MyVideoRepo == null)
                    return new VideoRepository(_context);
                return MyVideoRepo;
            }
        }

        private IArtistArtistTypesRepository MyArtistArtistTypeRepo;
        public IArtistArtistTypesRepository ArtistArtistTypeRepo
        {
            get
            {
                if (MyArtistArtistTypeRepo == null)
                    return new ArtistArtistTypesRepository(_context);
                return MyArtistArtistTypeRepo;
            }
        }
        private ITagRepository _TagRepo;
        public ITagRepository TagRepo
        {
            get
            {
                if (_TagRepo == null)
                    return new TagRepository(_context);
                return _TagRepo;
            }
        }
        private IVideoTagsRepository _VideoTagsRepo;
        public IVideoTagsRepository VideoTagsRepo
        {
            get
            {
                if (_VideoTagsRepo == null)
                    return new VideoTagsRepository(_context);
                return _VideoTagsRepo;
            }
        }

       

        public void Dispose()
        {
            if (_context != null)
                _context.Dispose();
        }

        public int Commit()
        {
            return _context.SaveChanges();
        }

        public void RollBack()
        {
            
        }
    }
}
