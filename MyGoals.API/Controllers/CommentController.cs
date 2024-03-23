using MyGoals.Services.Interfaces;
using MyGoals.Domain.Entities;
using Microsoft.AspNetCore.Mvc;

namespace MyGoals.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CommentController : ControllerBase
    {
        private readonly ICommentService _commentService;

        public CommentController(ICommentService commentService)
        {
            _commentService = commentService;
        }

        // GET: api/Comment
        [HttpGet("all")]
        public async Task<IActionResult> GetAll()
        {
            var comments = await _commentService.GetAllAsync();
            return Ok(comments);
        }

        // GET: api/Comment/5
        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            var comment = await _commentService.GetByIdAsync(id);
            if (comment == null)
            {
                return NotFound();
            }
            return Ok(comment);
        }

        // POST: api/Comment
        [HttpPost]
        public async Task<IActionResult> Post([FromBody] Comment comment)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            var createdComment = await _commentService.CreateAsync(comment);
            return CreatedAtAction(nameof(GetById), new { id = createdComment.Id }, createdComment);
        }

        // PUT: api/Comment/5
        [HttpPut("{id}")]
        public async Task<IActionResult> Put(int id, [FromBody] Comment comment)
        {
            if (id != comment.Id)
            {
                return BadRequest();
            }
            var updatedComment = await _commentService.UpdateAsync(comment);
            return Ok(updatedComment);
        }

        // DELETE: api/Comment/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            var comment = await _commentService.GetByIdAsync(id);
            if (comment == null)
            {
                return NotFound();
            }
            await _commentService.DeleteAsync(id);
            return NoContent();
        }
    }
}

