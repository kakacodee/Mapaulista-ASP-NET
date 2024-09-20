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

        public IActionResult Caraguatatuba()
        {
            var caraguatatuba = new Municipio
            {
                nome = "Caraguatatuba",
                descrição = "Caraguatatuba, localizada no litoral norte do estado de São Paulo, Brasil, é uma cidade conhecida por suas belas praias e paisagens montanhosas. A cidade é cercada pela Mata Atlântica, oferecendo diversas trilhas e áreas naturais protegidas, como o Parque Estadual da Serra do Mar. Entre suas atrações, destaca-se a Praia de Martim de Sá, uma das mais populares, ideal para quem busca lazer e esportes aquáticos. Caraguatatuba também é famosa por seu mirante do Morro Santo Antônio, que proporciona vistas panorâmicas da cidade e do mar. Além disso, o centro histórico da cidade preserva construções coloniais, incluindo a Igreja Matriz de Santo Antônio, que reflete a herança cultural e religiosa local.",
                região = "Sul",
                imagem1 = "~/ img/Santos1.jpg",
                imagem2 = "~/img/Santos2.png",
                avaliação = "4.0/5"

            };


            return View(caraguatatuba);
        }

        public IActionResult Ilhabela()
        {
            var Ilhabela = new Municipio
            {
                nome = "Ilhabela",
                descrição = "Ilhabela, localizada no litoral norte de São Paulo, é um arquipélago famoso por suas praias paradisíacas e pela exuberante vegetação da Mata Atlântica. A cidade é um destino turístico popular, com praias como a Praia do Curral e a Praia de Castelhanos, além de inúmeras cachoeiras acessíveis por trilhas. Ilhabela também é conhecida por suas condições ideais para esportes náuticos, como vela e mergulho. O centro histórico, conhecido como \"Vila\", preserva construções coloniais e oferece uma atmosfera charmosa com bares, restaurantes e lojas de artesanato. Ilhabela é um refúgio para quem busca contato com a natureza e uma experiência única no litoral paulista.",
                região = "Norte",
                imagem1 = "~/ img/Ilhabela1.jpg",
                imagem2 = "~/img/Ilhabela2.png",
                avaliação = "4.5/5"

            };


            return View(Ilhabela);
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