using System;
using Microsoft.AspNetCore.Mvc;
using AttendanceMgmtFYP.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using System.Dynamic;
using System.Collections.Generic;
using Newtonsoft.Json;
using AttendanceMgmtFYP.Data;

namespace Nebula.Controllers.API
{
   
   [Route("api/[controller]")]
  [Authorize(AuthenticationSchemes = 
   JwtBearerDefaults.AuthenticationScheme)]
    public class LoginController : Controller
    {
        //public NebulaUser_Rep nebulaUser;
        private readonly IJWTAuth Auth;
        public LoginController(Context context,IJWTAuth Auth){
           //nebulaUser  = new NebulaUser_Rep(context);
           this.Auth = Auth;
            
        }


        [HttpGet("{id:int}")]
        public object Get(long id)
        {
            return null;
        }
   
        [HttpGet("{username}/{password}")]
        [AllowAnonymous]
        public Object Get(string username, string password)
        {
            //var user = nebulaUser.GetNebulaUser(username,password);
            //if (user==null) return NoContent(); /*Ok(new { message = "Username or wrong password"});*/
            //else {
            //  var serializedparent = JsonConvert.SerializeObject(user);
            //          LoginTokenModel model = JsonConvert.DeserializeObject<LoginTokenModel>(serializedparent);
            //          model.Token = Auth.GetToken(username,password);
            //          return model;
            //}
            return null;
        }
    }
}