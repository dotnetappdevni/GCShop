
using GoCompareShop.Models;
using BookManager.Services.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using BookManager.Services.Interfaces;
using System.Text.Json;
using NLog;
using Microsoft.AspNetCore.Authorization;
using Newtonsoft.Json;
using static System.Runtime.InteropServices.JavaScript.JSType;
using JsonSerializer = System.Text.Json.JsonSerializer;
namespace GoCompareShop.API.Controllers
{
    [Route("api/[controller]")]
    [Authorize]
    [ApiController]
    public class CartController : ControllerBase
    {
        IGoCompareShopBasketInterface _iGoCompareShop;
        private static readonly Logger _logger = LogManager.GetCurrentClassLogger();

        public CartController(IGoCompareShopBasketInterface iGoCompareShop)
        {
            _iGoCompareShop = iGoCompareShop;
        }
        
       // [HttpGet("GetAll")]
       // public IActionResult GetAll()
       // {
       //     return Ok(_iGoCompareShop.GetAll());
            
       // }

       // [HttpGet("GetBookById")]
       // public IActionResult GetBookById(int id)
       // {
       //     return Ok(_iGoCompareShop.GetById(id));
       // }

       // [HttpPost("Checkout")]
       // public IActionResult Checkout(int customerId, int bookId,string barCode, int returnDateInterval)
       // {
            
       //     var checkoutProcess= _iGoCompareShop.CheckOut(customerId, bookId, barCode, returnDateInterval);
       //     if (checkoutProcess.Succeeded)
       //     {
       //         return Ok(JsonSerializer.Serialize(checkoutProcess.Messages));
       //     }
       //     else
       //     {
       //         return StatusCode(400, JsonSerializer.Serialize(checkoutProcess.Errors));
       //     }
       // }

       // [HttpPost("CheckIn")]
       // public IActionResult CheckIn(int customerId, int bookId, string barCode, DateTime returnDate)
       // {

       //     var checkInProcess = _iGoCompareShop.CheckIn(customerId, bookId, barCode, returnDate);
       //     if (checkInProcess.Succeeded)
       //     {
       //         return Ok(JsonSerializer.Serialize(checkInProcess.Messages));
       //     }
       //     else
       //     {
       //         string json = JsonConvert.SerializeObject(checkInProcess.Errors, Formatting.Indented);

       //         return StatusCode(400, json);
       //     }
       // }

       // [HttpPost("AddBook")]
       // public IActionResult AddBook(Book book)
       // {
       //     var bookToAdd = _iGoCompareShop.Add(book);
       //     if (bookToAdd.Succeeded)
       //     {
       //         return Ok();

       //     }
       //     else
       //     {
       //         return StatusCode(StatusCodes.Status400BadRequest, JsonSerializer.Serialize(bookToAdd.Errors));
       //     }            
       // }

       // [HttpPut("UpdateBook")]
       // public IActionResult UpdateBook(Book book)
       // {
       //     var bookToUpdate = _iGoCompareShop.UpdateBook(book);
       //     if (bookToUpdate.Succeeded)
       //     {
       //         return Ok(bookToUpdate.Data);
       //     }else
       //     {
       //         return StatusCode(StatusCodes.Status400BadRequest, JsonSerializer.Serialize(bookToUpdate.Errors));
       //     }
       // }

       //[HttpDelete("DeleteBook")]
       // public IActionResult Delete(int id)
       // {
       //     var bookTodelete = _iGoCompareShop.Delete(id);
       //     if (bookTodelete.Succeeded)
       //     {
       //         return Ok();
       //     }
       //     else
       //     {
       //         string json = JsonConvert.SerializeObject(bookTodelete.Errors, Formatting.Indented);

       //         return BadRequest(json);
       //     }

       // }
    }
}
