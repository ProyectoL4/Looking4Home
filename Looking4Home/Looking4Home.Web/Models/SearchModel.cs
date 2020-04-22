using Pagination.Models;

namespace Lookig4Home.Web.Models
{

    public class SearchModel : PageRequestModel
    {
        public string SearchText { get; set; }
    }
}