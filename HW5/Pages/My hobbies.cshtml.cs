using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace HW5.Pages
{
    public class My_hobbiesModel : PageModel
    {
        [BindProperty]
        public List<hobby> hobbies { get; set; } 
            //= new List<hobby> { "woodworking", "stoneworking", "ironworking" };
        public Dictionary<string,string> portfolioPhoto { get; set; }

        public void OnGet()
        {hobbies = new List<hobby>();
            hobbies.Add(new hobby 
            {   id = 1, 
                Name = "woodworking", 
                Description = "I work with wood in winter",
                imgs = new List<string> { "/Imgs\\1606382834981.JPEG", "/Imgs\\1690892081233.JPEG", "/Imgs\\1690892075714.JPEG", "/Imgs\\1690892094548.JPEG" }
            });
            hobbies.Add(new hobby 
            {   id = 1,
                Name = "stoneworking",
                Description = "I work with stone in summer",
                imgs = new List<string> { "/Imgs\\1690892061959.JPEG", "/Imgs\\1690892067556.JPEG", "/Imgs\\1690892071808.JPEG", "/Imgs\\1690892099371.JPEG", "/Imgs\\1690892101549.JPEG", "/Imgs\\1690892106069.JPEG", "/Imgs\\1690892038723.JPEG" }
            });
            hobbies.Add(new hobby
            {
                id = 1,
                Name = "ironworking",
                Description = "I work with iron in warm weather",
                imgs = new List<string> { "/Imgs\\1690892089602.JPEG" }
            });
        }
    }
}
