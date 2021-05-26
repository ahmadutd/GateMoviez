using System;
using System.Collections.Generic;
using System.Text;

namespace GateMoviez.Data.Interface
{
    public interface IUnitOfWork : IDisposable
    {
         IArtistRepository ArtistRepo { get; }
         IArtistTypeRepository ArtistTypeRepo { get; }
         IArtistArtistTypesRepository ArtistArtistTypeRepo { get; }
        ICommentRepository CommentRepo { get; }
         IVideoRepository VideoRepo { get; }
        ITagRepository TagRepo { get; }
        IVideoTagsRepository VideoTagsRepo { get; }

         int Commit();
         void RollBack();
    }
}
