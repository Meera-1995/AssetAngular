using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using AssetAngular.Models;
namespace AssetAngular.Controllers
{
    public class loginController : ApiController
    {
        assetDBEntities db = new assetDBEntities();
       public List<logintbl> Get(string user,string pass)
        {
            List<logintbl> loglist = db.logintbls.Where(x => x.uname == user && x.pass == pass).ToList();
            return loglist;
        }

    }
}
