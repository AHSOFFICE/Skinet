using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using API.Errors;
using Infrastructure.Data;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    public class BuggyController : BaseApiController
    {
        public StoreContext _context { get; }
        public BuggyController(StoreContext context)
        {
            _context = context;
        }

<<<<<<< HEAD
=======
       
    
    [HttpGet("testauth")]
    //[Authorize]
    public ActionResult<string>GetSecretText()
    {
        return "secret stuff";
    }







     [HttpGet("notfound")]
       
    public ActionResult GetNotFoundRequest()
    {
    var thing= _context.product.Find(42);
    
    if(thing==null)
    {
>>>>>>> 647186f6de55babfb6ca38d31d673b920360f367


        [HttpGet("testauth")]
        //[Authorize]
        public ActionResult<string> GetSecretText()
        {
            return "secret stuff";
        }







        [HttpGet("notfound")]

        public ActionResult GetNotFoundRequest()
        {
            var thing = _context.product.Find(42);

            if (thing == null)
            {


                return NotFound(new ApiResponse(404));

            }

            return Ok();

        }


        [HttpGet("servererror")]
        public ActionResult GetServerError()
        {

            var thing = _context.product.Find(42);
            var thingtoReturn = thing.ToString();
            return Ok();

        }

        [HttpGet("badrequest")]
        public ActionResult Getbadrequest()
        {

            return BadRequest(new ApiResponse(400));

        }



        [HttpGet("badrequest/{id}")]
        public ActionResult GetNotFoundRequest(int id)
        {

            return BadRequest();

        }




    }
}