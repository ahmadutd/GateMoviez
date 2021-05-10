using GateMoviez.Data.Interface;
using GateMoviez.Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace GateMoviez.Data.Repositories
{
    public class CommentRepository:Repository<Comment>,ICommentRepository
    {
        public CommentRepository(GateMoviezDbContext context):base(context)
        {

        }
    }
}
