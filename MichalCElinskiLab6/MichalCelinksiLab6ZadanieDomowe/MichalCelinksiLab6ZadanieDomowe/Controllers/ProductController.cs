using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MichalCelinksiLab6ZadanieDomowe.Models;
using MichalCelinksiLab6ZadanieDomowe.Services;

namespace MichalCelinksiLab6ZadanieDomowe.Controllers
{
    public class ProductController : Controller
    {
        [Route("api/[controller]")]
        [ApiController]
        public class ProductController : ControllerBase
        {
            private IProductService _productService;

            public PizzaController(IProductService productService)
            {
                _productService = productService;
            }

            /// <summary>
            /// Zwraca wszystkie produkty
            /// </summary>
            /// <returns></returns>
            [HttpGet]
            [Produces(typeof(List<Product>))]
            public IActionResult GetAllProducts()
            {
                var products = _productService.Get();
                return Ok(products);
            }

            /// <summary>
            /// Dodaje nowy product
            /// </summary>
            /// <param name="product"></param>
            /// <returns></returns>
            [HttpPost]
            [Produces(typeof(int))]
            public IActionResult Post([FromBody] Product product)
            {
                int id = _productService.Post(product);
                return Ok(id);
            }

            /// <summary>
            /// Edytuje istniejący produkt
            /// </summary>
            /// <param name="id"></param>
            /// <param name="product"></param>
            /// <returns></returns>
            [HttpPut]
            [Route("{id}")]
            public IActionResult Put([FromRoute] int id, [FromBody] Product product)
            {
                if (id != product.Id)
                {
                    return Conflict("Podane Id są różne");
                }
                else
                {
                    var isUpdateSuccessful = _productService.Put(id, product);

                    if (isUpdateSuccessful)
                        return NoContent();
                    else
                        return NotFound();
                }
            }

            /// <summary>
            /// Usuwa istniejący produkt
            /// </summary>
            /// <param name="id"></param>
            /// <returns></returns>
            [HttpDelete]
            [Route("{id}")]
            public IActionResult Delete([FromRoute] int id)
            {
                var result = _productService.Delete(id);

                if (result)
                    return NoContent();
                else
                    return NotFound();
            }
        }
    }
}
