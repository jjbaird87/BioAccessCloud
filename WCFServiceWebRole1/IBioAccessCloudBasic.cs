using System;
using System.Collections.Generic;
using System.ServiceModel;

namespace WCFServiceWebRole1
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract]
    public interface IBioAccessCloudBasic
    {
        [OperationContract]
        DataStructures.LoginResponse Login(string userName, string password);

        [OperationContract]
        List<DataStructures.TemplateTypeBac> GetTemplateTypes();

        [OperationContract]
        List<DataStructures.SiteBac> GetSitesPerCustomer(int customerId);

        [OperationContract]
        List<DataStructures.EmployeeBac> GetEmployeesPerSite(int siteId, bool? terminalTemplates, string templateType);

        [OperationContract]
        List<DataStructures.EmployeeBac> GetEmployeesPerCustomer(int customerId, int? employeeId);

        [OperationContract]
        string CreateUpdateSites(ref IEnumerable<DataStructures.SiteBac> sites, int customerId);

        [OperationContract]
        string CreateUpdateGroups(ref IEnumerable<DataStructures.GroupBac> groups, int customerId);

        [OperationContract]
        string CreateUpdateGroupRelations(IEnumerable<DataStructures.EmployeeGroupBac> employeeGroups, int customerId);

        [OperationContract]
        string CreateUpdateTemplates(IEnumerable<DataStructures.TemplateBac> templates, int customerId);

        [OperationContract]
        string CreateUpdateEmployees(ref IEnumerable<DataStructures.EmployeeBac> employees, int customerId);

        [OperationContract]
        List<DataStructures.EmployeeBac> GetEmployeesPerGroup(int groupId);

        [OperationContract]
        List<DataStructures.AttendanceTransactionBac> GetTransactions(int customerId, DateTime? startDate,
            DateTime? endDate, bool? downloaded);

        [OperationContract]
        string InsertNewTransactions(IEnumerable<DataStructures.AttendanceTransactionInBac> transactions);

        [OperationContract]
        string InsertNewTransaction(int employeeId, string transactionDate, short inOut, double latitude,
            double longitude, String emei);

        [OperationContract]
        string UpdateDownloadedTxPerCustomer(int customerId);
    }


  

    
}
