using DemoISPSessionCore.Models;

namespace DemoISPSessionCore.Pages
{
    public class IndexModel : BasePageModel
    {
        public void OnGet()
        {
            var ctr = (int)(Session["counter"] ?? 0);
            ctr++;
            Session["counter"] = ctr;
        }
    }
}
