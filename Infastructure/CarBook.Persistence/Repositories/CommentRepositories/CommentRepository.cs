using CarBook.Application.Features.RepositoryPattern;
using CarBook.Domain.Entitites;
using CarBook.Persistence.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBook.Persistence.Repositories.CommentRepositories
{
    public class CommentRepository : IGenericRepository<Comment>
    {
        private readonly CarBookContext _context;

        public CommentRepository(CarBookContext context)
        {
            _context = context;
        }

        public void Create(Comment entity)
        {
           
            _context.Comments.Add(entity);
            _context.SaveChanges();
        }

        public List<Comment> GetAll()
        {
            return _context.Comments.Select(x=> new Comment
            {
                CommentID = x.CommentID,
                Name = x.Name,
                CreatedDate = x.CreatedDate,
                Description = x.Description,
                ProfilePictureUrl = x.ProfilePictureUrl,
                BlogID = x.BlogID,
              
            }).ToList();
        }

        public Comment GetById(int id)
        {
            return _context.Comments.Find(id);
        }

        public void Remove(int id)
        {
            var value = _context.Comments.Find(id);
            _context.Comments.Remove(value);
            _context.SaveChanges();
        }

      
        public void Update(Comment entity)
        {
           _context.Update(entity);
            _context.SaveChanges();
        }
    }
}
