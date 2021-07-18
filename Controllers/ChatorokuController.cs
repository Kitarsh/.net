using System.Collections.Generic;
using System.Threading.Tasks;
using kitarsh.net.Models.Chatoroku;
using Microsoft.AspNetCore.Mvc;

namespace kitarsh.net.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ChatorokuController : ControllerBase
    {
        [HttpGet]
        public Article[] Get()
        {
            var result = new List<Article> { };
            for (int i = 0; i < 20; i++)
            {
                var newArticle = Article.Default();
                newArticle.idArticle = i;
                result.Add(newArticle);
            }
            return result.ToArray();
        }

        [HttpGet("GetArticle/{id}")]
        public Article[] GetArticle(int id)
        {
            return new[] { Article.Default() };
        }
    }
}