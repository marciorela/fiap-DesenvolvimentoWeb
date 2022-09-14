using fiapweb2022.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fiapweb2022.ViewComponents
{
    public class NoticiasViewComponent : ViewComponent
    {
        public async Task<IViewComponentResult> InvokeAsync(int total, bool noticiasUrgentes)
        {
            string view = "noticias";
            
            if (total > 3 && noticiasUrgentes)
            {
                view = "noticiasurgentes";
            }

            var items = GetNoticias(total);

            return View(view, items);
        }

        private IEnumerable<Noticia> GetNoticias(int total)
        {
            // simulando acesso a api ou DB
            for (int i = 0; i < total; i++)
            {
                yield return new Noticia()
                {
                    Id = i,
                    Titulo = $"Notícia sobre {i}",
                    Link = "https://{i}.com.br"
                };
            }
        }
    }
}
