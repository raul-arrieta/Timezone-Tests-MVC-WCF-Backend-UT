using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace WCFTestDate
{
    [ServiceContract]
    public interface IWCFTestDate
    {

        [OperationContract]
        CompositeType Test(DateTime datetime, TimeSpan offset, String timezone);

        [OperationContract]
        DateTime checkDateTime(DateTime fechIn);

        [OperationContract]
        DateTime checkDateTimeForceUTC(DateTime fechIn);

        [OperationContract]
        String checkDateTime_JSON (DateTime fechIn);
        
        [OperationContract]
        String checkDateTimeForceUTC_JSON(DateTime fechIn);

    }


    [DataContract]
    public class CompositeType
    {
        [DataMember]
        public CompositeTypeLite compositeTypeLite { get; set; }

        [DataMember]
        public String compositeTypeLiteSerialized { get; set; }

    }

    [DataContract]
    public class CompositeTypeLite
    {
        [DataMember]
        public DateTime horaCliente { get; set; }

        [DataMember]
        public DateTime horaServidor { get; set; }

        [DataMember]
        public DateTime horaUTC { get; set; }

        [DataMember]
        public TimeSpan offsetClienteEnCliente { get; set; }

        [DataMember]
        public TimeSpan offsetClienteEnServidor { get; set; }

        [DataMember]
        public TimeSpan offsetServidor { get; set; }

        [DataMember]
        public TimeSpan offsetClienteRespectoClienteEnServidor { get; set; }

        [DataMember]
        public TimeSpan offsetClienteRespectoServidorEnServidor { get; set; }

        [DataMember]
        public TimeSpan offsetClienteRespectoUTCEnServidor { get; set; }

        [DataMember]
        public String timeZoneCliente { get; set; }

        [DataMember]
        public String timeZoneServidor { get; set; }
    }
}
