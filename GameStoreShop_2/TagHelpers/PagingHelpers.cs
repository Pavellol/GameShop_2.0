using GameStoreShop_2.Models;
using Microsoft.AspNetCore.Html;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Text;

namespace GameStoreShop_2.TagHelpers
{
    public static class PagingHelpers
    {
        public static HtmlString PageLinks(this IHtmlHelper html,
        PageInfo pagingInfo, Func<int, string> pageUrl)
        {
            StringBuilder result = new StringBuilder();
            for (int i = 1; i <= pagingInfo.TotalPages; i++)
            {
                TagBuilder tag = new TagBuilder("a");
                tag.MergeAttribute("href", pageUrl(i));
                tag.InnerHtml.Append(i.ToString());
                if (i == pagingInfo.CurrentPage)
                {
                    tag.AddCssClass("btn btn-primary selected");
                }
                else
                {
                    tag.AddCssClass("btn btn-default");
                }
                result.Append(tag);
            }
            return new HtmlString(result.ToString());
        }
    }
}
