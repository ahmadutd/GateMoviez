using GateMoviez.Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace GateMoviez.Application.Interfaces
{
    public interface ICommentService
    {
        IEnumerable<Comment> GetComments();
    }
}
