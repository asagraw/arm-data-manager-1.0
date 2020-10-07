using ARMDataManager.Library.DataAccess;
using ARMDataManager.Library.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using Microsoft.AspNet.Identity;

namespace ARMDataManager.Controllers
{
    [Authorize]
    public class UserController : ApiController
    {

        public UserModel GetById()
        {
            string id = RequestContext.Principal.Identity.GetUserId();
            UserData data = new UserData();
            return data.GetUserById(id).First();
        }
    }
}
