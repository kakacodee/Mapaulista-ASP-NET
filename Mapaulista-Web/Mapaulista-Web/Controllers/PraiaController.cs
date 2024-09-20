using Mapaulista_Web.Models;
using Microsoft.AspNetCore.Mvc;

namespace Mapaulista_Web.Controllers
{
    public class PraiaController : Controller
    {
        public IActionResult Santos()
        {
            var santos = new Municipio
            {
                nome = "Santos",
                descrição = "Santos, uma cidade costeira no estado de São Paulo, no sul do Brasil, é uma importante extensão do porto marítimo " +
                "que vai do continente à ilha de São Vicente. O centro urbano da ilha faz fronteira com a Baía de Santos, conhecida pela sua extensa praia e pelo jardim adjacente de 5,3 km de comprimento." +
                " O Museu do Café, que ocupa uma bolsa de" +
                " mercadorias de 1922 preservada na zona histórica, explora o papel fundamental da área para o comércio de café do Brasil.",
                região = "Sul",
                imagem1 = "~/ img/Santos1.jpg",
                imagem2 = "~/img/Santos2.png",
                avaliação = "4.0/5"

            };


            return View(santos);
        }
        public IActionResult São_Sebastião()
        {
            var São_Sebastião = new Municipio
            {
                nome = "São Sebastião",
                descrição = "Descrição",
                região = "Norte",
                avaliação = "4.0/5"
            };


            return View(São_Sebastião);
        }
    }
}