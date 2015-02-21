using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UT_WCFTestDate
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod()
        {
            DateTime datetime = DateTime.Now;
            TimeZone timezone = TimeZone.CurrentTimeZone;
            TimeSpan offset = timezone.GetUtcOffset(datetime);
            String timezone_str = TimeZone.CurrentTimeZone.ToString();

            WCFTestDateJaponSrv.CompositeType resultJapon;
            WCFTestDateJaponSrv.WCFTestDateClient clienteJapon = new WCFTestDateJaponSrv.WCFTestDateClient();
            resultJapon = clienteJapon.Test(datetime, offset, timezone_str);
            clienteJapon.Close();

        }

        [TestMethod]
        public void TestCheckDateTime_Offset()
        {
            DateTime datetimeConOffset = DateTime.Now;
            WCFTestDateJaponSrv.WCFTestDateClient clienteJapon = new WCFTestDateJaponSrv.WCFTestDateClient();
            DateTime result = clienteJapon.checkDateTime(datetimeConOffset);
            clienteJapon.Close();
        }

        [TestMethod]
        public void TestCheckDateTime_UTC()
        {
            DateTime datetimeUTC = DateTime.SpecifyKind(DateTime.Now, DateTimeKind.Utc)
            WCFTestDateJaponSrv.WCFTestDateClient clienteJapon = new WCFTestDateJaponSrv.WCFTestDateClient();
            DateTime result = clienteJapon.checkDateTime(datetimeUTC);
            clienteJapon.Close();
        }

        [TestMethod]
        public void TestCheckDateTimeUTC_Offset()
        {
            DateTime datetimeConOffset = DateTime.Now;
            WCFTestDateJaponSrv.WCFTestDateClient clienteJapon = new WCFTestDateJaponSrv.WCFTestDateClient();
            DateTime result = clienteJapon.checkDateTimeForceUTC(datetimeConOffset);
            clienteJapon.Close();
        }

        [TestMethod]
        public void TestCheckDateTimeUTC_UTC()
        {
            DateTime datetimeUTC = DateTime.SpecifyKind(DateTime.Now, DateTimeKind.Utc)
            WCFTestDateJaponSrv.WCFTestDateClient clienteJapon = new WCFTestDateJaponSrv.WCFTestDateClient();
            DateTime result = clienteJapon.checkDateTimeForceUTC(datetimeUTC);
            clienteJapon.Close();
        }
    }
}
