using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace MB.Presentation.MVCCore.Administrator.Pages.ArticleCategoryManagement
{
    public class ListModel : PageModel
    {
        public List<ArticleViewModel> Articles { get; set; }
        private readonly IArticleApplication _articleApplication;

        public ListModel(IArticleApplication articleApplication)
        {
            _articleApplication = articleApplication;
        }

        public void OnGet()
        {
            Articles = _articleApplication.GetList();
        }

        public RedirectToPageResult OnPostRemove(long id)
        {
            _articleApplication.Remove(id);
            return RedirectToPage("./List");
        }

        public RedirectToPageResult OnPostActivate(long id)
        {
            _articleApplication.Activate(id);
            return RedirectToPage("./List");
        }
    }
}

