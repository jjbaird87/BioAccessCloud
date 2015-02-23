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
        List<DataStructures.EmployeeBac> GetEmployeesPerSite(int siteId);

        [OperationContract]
        List<DataStructures.EmployeeBac> GetEmployeesPerCustomer(int customerId);

        [OperationContract]
        string CreateUpdateSites(ref IEnumerable<DataStructures.SiteBac> sites);

        [OperationContract]
        string CreateUpdateGroups(ref IEnumerable<DataStructures.GroupBac> groups);

        [OperationContract]
        string CreateUpdateGroupRelations(IEnumerable<DataStructures.EmployeeGroupBac> employeeGroups, int customerId);

        [OperationContract]
        string CreateUpdateTemplates(IEnumerable<DataStructures.TemplateBac> templates);

        [OperationContract]
        string CreateUpdateEmployees(ref IEnumerable<DataStructures.EmployeeBac> employees);

        [OperationContract]
        List<DataStructures.EmployeeBac> GetEmployeesPerGroup(int groupId);

        [OperationContract]
        List<DataStructures.AttendanceTransactionBac> GetTransactions(int customerId, DateTime? startDate,
            DateTime? endDate, bool? downloaded);

        [OperationContract]
        string InsertNewTransactions(IEnumerable<DataStructures.AttendanceTransactionBac> transactions);

    }


  

    
}
