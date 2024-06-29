using Microsoft.AspNetCore.Mvc;
using BLL_Tanach;
using Enteties_Dto_Tanach;

namespace WebApp_Tanach.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TanachController : ControllerBase
    {
        [HttpGet]
        [Route("GetLoction/{word}")]
        public List<int> SearchWord(string word)
        {
              ClassBll classBll = new ClassBll();
              return classBll.SearchWord(word);
        }


        [HttpGet]
        [Route("GetExcatLoction/{word}")]
        public List<Location> wordLocationSearch(string word)
        {
            ClassBll classBll = new ClassBll();
            return classBll.wordLocationSearch(word);
        }


        [HttpGet]
        [Route("GetInitials/{word}")]
        public List<string> SearchInitials(string word)
        {
            ClassBll classBll = new ClassBll();
            return classBll.SearchInitials(word);
        }
    }
}
