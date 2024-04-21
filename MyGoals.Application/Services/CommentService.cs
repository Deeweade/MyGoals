using MyGoals.Services.Interfaces;
using MyGoals.Domain.Repositories;
using MyGoals.Domain.Entities;

namespace MyGoals.Services.Services
{
    public class CommentService : ICommentService
    {
        private readonly ICommentRepository _commentRepository;

        public CommentService(ICommentRepository commentRepository)
        {
            _commentRepository = commentRepository;
        }

        public async Task<IEnumerable<Comment>> GetAllAsync()
        {
            return await _commentRepository.GetAllAsync();
        }

        public async Task<Comment> GetByIdAsync(int id)
        {
            return await _commentRepository.GetByIdAsync(id);
        }

        public async Task<Comment> CreateAsync(Comment comment)
        {
            return await _commentRepository.AddAsync(comment);
        }

        public async Task<Comment> UpdateAsync(Comment comment)
        {
            return await _commentRepository.UpdateAsync(comment);
        }

        public async Task DeleteAsync(int id)
        {
            await _commentRepository.DeleteAsync(id);
        }
    }
}

