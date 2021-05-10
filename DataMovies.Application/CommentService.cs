using GateMoviez.Application.Interfaces;
using GateMoviez.Data.Interface;
using GateMoviez.Data.Repositories;
using GateMoviez.Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace GateMoviez.Application
{
    public class CommentService : ICommentService
    {
        private readonly ICommentRepository _commentrepo;
        public CommentService(ICommentRepository commentrepo)
        {
            _commentrepo = commentrepo;
        }
        public IEnumerable<Comment> GetComments()
        {
            return _commentrepo.GetAll();
        }
    }
}
