using Pagination.Models;

namespace Lookig4Home.WebAdmin.Models
{

    public class SearchModel : PageRequestModel
    {
        public string SearchText { get; set; }
    }
}