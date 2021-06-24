using System.Threading.Tasks;
using Microsoft.AspNetCore.Authentication;

namespace TyeDemo.Web.Pages
{
    public class IndexModel : TyeDemoPageModel
    {
        public void OnGet()
        {
            
        }

        public async Task OnPostLoginAsync()
        {
            await HttpContext.ChallengeAsync("oidc");
        }
    }
}