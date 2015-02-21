using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using System.Web.Script.Serialization;

namespace WCFTestDate
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de clase "Service1" en el código, en svc y en el archivo de configuración.
    // NOTE: para iniciar el Cliente de prueba WCF para probar este servicio, seleccione Service1.svc o Service1.svc.cs en el Explorador de soluciones e inicie la depuración.
    public class WCFTestDate : IWCFTestDate
    {
        public DateTime checkDateTime(DateTime fechIn)
        {
            return fechIn;
        }

        public DateTime checkDateTimeForceUTC(DateTime fechIn)
        {
            return DateTime.SpecifyKind(fechIn, DateTimeKind.Utc);
        }

        public String checkDateTime_JSON (DateTime fechIn)
        {
            return new JavaScriptSerializer().Serialize(fechIn);
        }

        public String checkDateTimeForceUTC_JSON(DateTime fechIn)
        {
            return new JavaScriptSerializer().Serialize(DateTime.SpecifyKind(fechIn, DateTimeKind.Utc));
        }
        public CompositeType Test(DateTime datetime, TimeSpan offset, String timeZone)
        {
            CompositeTypeLite testCompositeTypeLite = new CompositeTypeLite();
            testCompositeTypeLite.horaCliente = datetime;
            testCompositeTypeLite.horaServidor = DateTime.Now;
            testCompositeTypeLite.horaUTC = DateTime.SpecifyKind(datetime, DateTimeKind.Utc);


            testCompositeTypeLite.offsetClienteEnCliente = offset;
            testCompositeTypeLite.offsetClienteRespectoClienteEnServidor = TimeZone.CurrentTimeZone.GetUtcOffset(testCompositeTypeLite.horaCliente);
            testCompositeTypeLite.offsetClienteRespectoServidorEnServidor = TimeZone.CurrentTimeZone.GetUtcOffset(testCompositeTypeLite.horaServidor);
            testCompositeTypeLite.offsetClienteRespectoUTCEnServidor = TimeZone.CurrentTimeZone.GetUtcOffset(testCompositeTypeLite.horaUTC);

            testCompositeTypeLite.timeZoneCliente = timeZone;
            testCompositeTypeLite.timeZoneServidor = new JavaScriptSerializer().Serialize(TimeZone.CurrentTimeZone);


            CompositeType testCompositeType = new CompositeType();
            testCompositeType.compositeTypeLite = testCompositeTypeLite;
            testCompositeType.compositeTypeLiteSerialized = new JavaScriptSerializer().Serialize(testCompositeType);
            return testCompositeType;
        }
    }
}
