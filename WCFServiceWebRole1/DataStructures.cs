using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace WCFServiceWebRole1
{
    public static class DataStructures
    {
        // Use a data contract as illustrated in the sample below to add composite types to service operations.
        [DataContract]
        public class LoginResponse
        {
            [DataMember]
            public bool LoginSuccessful { get; set; }
            [DataMember]
            public int CustomerId { get; set; }
            [DataMember]
            public string ErrorMessage { get; set; }
            [DataMember]
            public DateTime RequestCompleted { get; set; }
            [DataMember]
            public string SessionId { get; set; }

        }

        [DataContract]
        public class SiteBac
        {
            [DataMember]
            public int SiteId { get; set; }
            [DataMember]
            public string SiteName { get; set; }
            [DataMember]
            public string Latitude { get; set; }
            [DataMember]
            public string Longitude { get; set; }
            [DataMember]
            public int CustomerId { get; set; }
            [DataMember]
            public Guid? BioAccessId { get; set; }

        }

        [DataContract]
        public class GroupBac
        {
            [DataMember]
            public int GroupId { get; set; }
            [DataMember]
            public string GroupName { get; set; }
            [DataMember]
            public int SiteId { get; set; }
            [DataMember]
            public int CustomerId { get; set; }
            [DataMember]
            public Guid? BioAccessId { get; set; }
        }

        [DataContract]
        public class TemplateBac
        {
             [DataMember]
            public int TemplateId { get; set; }
            [DataMember]
            public  short? FingerNumber { get; set; }
            [DataMember]
            public byte[] Template { get; set; }
            [DataMember]
            public string Base64Template { get; set; }
            [DataMember]
            public int TemplateSize { get; set; }
            [DataMember]
            public string TemplateType { get; set; }
            [DataMember]
            public int EmployeeId { get; set; }
            [DataMember]
            public Guid? BioAccessId { get; set; }
            [DataMember]
            public bool? TerminalFp { get; set; }
        }

        [DataContract]
        public class EmployeeGroupBac
        {
            [DataMember]
            public int EmployeeGroupId { get; set; }
            [DataMember]
            public int GroupId { get; set; }
            [DataMember]
            public int EmployeeId { get; set; }
        }

        [DataContract]
        public class EmployeeBac
        {
            [DataMember]
            public int EmployeeId { get; set; }
            [DataMember]
            public string EmployeeNo { get; set; }
            [DataMember]
            public string Name { get; set; }
            [DataMember]
            public string Surname { get; set; }
            [DataMember]
            public bool Active { get; set; }
            [DataMember]
            public int CustomerId { get; set; }
            [DataMember]
            public string RsaId { get; set; }
            [DataMember]
            public Guid? BioAccessId { get; set; }

            [DataMember]
            public List<TemplateBac> Templates { get; set; } 
        }

        [DataContract]
        public class TemplateTypeBac
        {
            [DataMember]
            public int TemplateTypeId { get; set; }
            [DataMember]
            public string Description { get; set; }
        }

        [DataContract]
        public class AttendanceTransactionBac
        {
            [DataMember]
            public int AttendanceTransactionId { get; set; }
            [DataMember]
            public DateTime TransactionDateTime { get; set; }
            [DataMember]
            public double Latitude { get; set; }
            [DataMember]
            public double Longitude { get; set; }
            [DataMember]
            public EmployeeBac Employee { get; set; }
            [DataMember]
            public int EmployeeId { get; set; }
            [DataMember]
            public string Emei { get; set; }
            [DataMember]
            public short InOut { get; set; }
            [DataMember]
            public bool Downloaded { get; set; }
        }

        [DataContract]
        public class AttendanceTransactionInBac
        {            
            [DataMember]
            public string TransactionDateTime { get; set; }
            [DataMember]
            public double Latitude { get; set; }
            [DataMember]
            public double Longitude { get; set; }
            [DataMember]
            public int EmployeeId { get; set; }
            [DataMember]
            public string EmployeeNo { get; set; }
            [DataMember]
            public string Emei { get; set; }
            [DataMember]
            public short InOut { get; set; }
            [DataMember]
            public bool Downloaded { get; set; }
        }
    }
}