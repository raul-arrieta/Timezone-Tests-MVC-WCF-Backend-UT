using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Script.Serialization;

namespace WebTestDateTime.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/

        public ActionResult Index()
        {
            return View();
        }

        public DateTime checkDateTime(String fechIn)
        {
            return new WCFTestDateJaponSrv.WCFTestDateClient().checkDateTime(new JavaScriptSerializer().Deserialize<DateTime>(fechIn));
        }

        public DateTime checkDateTime_ServerSide()
        {
            DateTime fech = DateTime.Now;
            return new WCFTestDateJaponSrv.WCFTestDateClient().checkDateTime(fech);
        }

        public DateTime checkDateTimeForceUTC(String fechIn)
        {
            return new WCFTestDateJaponSrv.WCFTestDateClient().checkDateTimeForceUTC(new JavaScriptSerializer().Deserialize<DateTime>(fechIn));
        }

        public DateTime checkDateTimeForceUTC_ServerSide(String fechIn)
        {
            DateTime fech = DateTime.Now;
            return new WCFTestDateJaponSrv.WCFTestDateClient().checkDateTimeForceUTC(fech);
        }













        public String checkDateTime_JSON(String fechIn)
        {
            return new WCFTestDateJaponSrv.WCFTestDateClient().checkDateTime_JSON(new JavaScriptSerializer().Deserialize<DateTime>(fechIn));
        }

        public String checkDateTime_ServerSide_JSON()
        {
            DateTime fech = DateTime.Now;
            return new WCFTestDateJaponSrv.WCFTestDateClient().checkDateTime_JSON(fech);
        }

        public String checkDateTimeForceUTC_JSON(String fechIn)
        {
            return new WCFTestDateJaponSrv.WCFTestDateClient().checkDateTimeForceUTC_JSON(new JavaScriptSerializer().Deserialize<DateTime>(fechIn));
        }

        public String checkDateTimeForceUTC_ServerSide_JSON(String fechIn)
        {
            DateTime fech = DateTime.Now;
            return new WCFTestDateJaponSrv.WCFTestDateClient().checkDateTimeForceUTC_JSON(fech);
        }



    }
}
