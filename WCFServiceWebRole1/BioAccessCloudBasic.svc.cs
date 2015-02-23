using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using WCFServiceWebRole1.Data;

namespace WCFServiceWebRole1
{
    public class BioAccessCloudBasic : IBioAccessCloudBasic
    {
        #region Login
        //Login
        public DataStructures.LoginResponse Login(string userName, string password)
        {
            try
            {
                var response = new DataStructures.LoginResponse { RequestCompleted = DateTime.Now };

                var ctx = new BioAccessCloudEntities();
                var loginEntity = (from p in ctx.Customers select p).Where(i => i.UserName == userName).ToList();

                if (loginEntity.Count() != 0)
                {
                    if (password == loginEntity[0].Password)
                    {
                        response.CustomerId = loginEntity[0].Customer_ID;
                        response.ErrorMessage = "";
                        response.LoginSuccessful = true;
                        response.SessionId = OperationContext.Current.SessionId;
                    }
                    else
                    {
                        response.ErrorMessage = "Password incorrect";
                        response.LoginSuccessful = false;
                    }
                }
                else
                {
                    response.ErrorMessage = "Username not found";
                    response.LoginSuccessful = false;
                }

                return response;
            }
            catch (Exception ex)
            {
                var response = new DataStructures.LoginResponse
                {
                    RequestCompleted = DateTime.Now,
                    ErrorMessage = ex.Message,
                    LoginSuccessful = false
                };
                return response;
            }
        }

        #endregion

        #region Sites
        //Sites
        public List<DataStructures.SiteBac> GetSitesPerCustomer(int customerId)
        {
            var ctx = new BioAccessCloudEntities();
            var sites = (from p in ctx.Sites select p).Where(i => i.Customer_ID == customerId).ToList();

            return sites.Select(site => new DataStructures.SiteBac
            {
                SiteId = site.Site_ID,
                SiteName = site.SiteName,
                Latitude = site.Latitude,
                Longitude = site.Longitude
            }).ToList();
        }

        public string CreateUpdateSites(ref IEnumerable<DataStructures.SiteBac> sites)
        {
            var ctx = new BioAccessCloudEntities();
            foreach (var site in sites)
            {
                //Determine add or edit
                if (ctx.Sites.Any(x => x.BioAccess_ID == site.BioAccessId))
                {
                    //Already exists and needs to be updated
                    var localSite = ctx.Sites.First(x => x.BioAccess_ID == site.BioAccessId);
                    localSite.SiteName = site.SiteName;
                    localSite.Latitude = site.Latitude;
                    localSite.Longitude = site.Longitude;
                    localSite.Customer_ID = site.CustomerId;
                    localSite.BioAccess_ID = site.BioAccessId;
                    ctx.SaveChanges();
                    site.SiteId = localSite.Site_ID;
                }
                else
                {
                    //Does not exist and new site needs to be created
                    var localSite = new Site
                    {
                        SiteName = site.SiteName,
                        Customer_ID = site.CustomerId,
                        Latitude = site.Latitude,
                        Longitude = site.Longitude,
                        BioAccess_ID = site.BioAccessId
                    };
                    ctx.Sites.Add(localSite);
                    ctx.SaveChanges();
                    site.SiteId = localSite.Site_ID;
                }
            }
            
            return "";
        }

        #endregion

        #region Employees
        //Employees
        public List<DataStructures.EmployeeBac> GetEmployeesPerSite(int siteId)
        {
            try
            {
                var ctx = new BioAccessCloudEntities();
                var employees =
                    (from p in ctx.Employees select p).Where(x => x.EmployeeGroups.Any(i => i.Group.Site_ID == siteId)).ToList();

                var employeelist = EmployeeBacs(employees);
                return employeelist;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private static List<DataStructures.EmployeeBac> EmployeeBacs(IEnumerable<Employee> employees)
        {
            var employeelist = employees.Select(employee => new DataStructures.EmployeeBac
            {
                Active = employee.Active,
                CustomerId = employee.Customer_ID,
                EmployeeId = employee.Employee_ID,
                Name = employee.Name,
                Surname = employee.Surname,
                BioAccessId = employee.BioAccess_ID,
                RsaId = employee.RSA_ID,
                Templates = TemplateBacs(employee.Templates)
            }).ToList();
            return employeelist;
        }

        public List<DataStructures.EmployeeBac> GetEmployeesPerCustomer(int customerId)
        {
            var ctx = new BioAccessCloudEntities();
            var employees =
                (from p in ctx.Employees select p).Where(x => x.Customer_ID == customerId).ToList();

            return EmployeeBacs(employees);
        }

        public List<DataStructures.EmployeeBac> GetEmployeesPerGroup(int groupId)
        {
            var ctx = new BioAccessCloudEntities();
            var employees =
                (from p in ctx.Employees select p).Where(x => x.EmployeeGroups.Any(c => c.Group_ID == groupId)).ToList();

            return EmployeeBacs(employees);
        }

        public string CreateUpdateEmployees(ref IEnumerable<DataStructures.EmployeeBac> employees)
        {
            var ctx = new BioAccessCloudEntities();
            foreach (var employee in employees)
            {
                //Determine add or edit
                if (ctx.Employees.Any(x => x.BioAccess_ID == employee.BioAccessId))
                {
                    //Already exists and needs to be updated
                    var localEmployee = ctx.Employees.First(x => x.BioAccess_ID == employee.BioAccessId);
                    localEmployee.Name = employee.Name;
                    localEmployee.Surname = employee.Surname;
                    localEmployee.Active = employee.Active;
                    localEmployee.Customer_ID = employee.CustomerId;
                    localEmployee.RSA_ID = employee.RsaId;
                    localEmployee.BioAccess_ID = employee.BioAccessId;
                    ctx.SaveChanges();
                    employee.EmployeeId = localEmployee.Employee_ID;
                }
                else
                {
                    //Does not exist and new site needs to be created
                    var localEmployee = new Employee
                    {
                        Name = employee.Name,
                        Surname = employee.Surname,
                        Active = employee.Active,
                        Customer_ID = employee.CustomerId,
                        RSA_ID = employee.RsaId,
                        BioAccess_ID = employee.BioAccessId
                    };
                    ctx.Employees.Add(localEmployee);
                    ctx.SaveChanges();
                    employee.EmployeeId = localEmployee.Employee_ID;
                }
            }
            return "";
        }

        #endregion

        #region Templates

        private static List<DataStructures.TemplateBac> TemplateBacs(IEnumerable<Template> templates)
        {
            var templatelist =
                templates.Select(
                    template =>
                        template.FingerNumber != null
                            ? (template.BioAccess_ID != null
                                ? new DataStructures.TemplateBac
                                {
                                    BioAccessId = (Guid) template.BioAccess_ID,
                                    EmployeeId = template.Employee_ID,
                                    FingerNumber = (short) template.FingerNumber,
                                    Template = template.Template1,
                                    TemplateId = template.Template_ID,
                                    TemplateType = template.TemplateType.Description
                                }
                                : null)
                            : null).ToList();
            return templatelist;
        }

        public string CreateUpdateTemplates(IEnumerable<DataStructures.TemplateBac> templates)
        {
            var ctx = new BioAccessCloudEntities();
            foreach (var template in templates)
            {
                //Get template Type
                var template1 = template;
                var templateType = ctx.TemplateTypes.Where(x => x.Description == template1.TemplateType).ToList()[0].TemplateType_ID;

                //Determine add or edit
                if (ctx.Templates.Any(x => x.BioAccess_ID == template.BioAccessId))
                {
                    //Already exists and needs to be updated
                    var localTemplate =
                        ctx.Templates.First(
                            x => x.BioAccess_ID == template.BioAccessId);
                    localTemplate.FingerNumber = template.FingerNumber;
                    localTemplate.Template1 = template.Template;
                    localTemplate.TemplateType_ID = templateType;
                    localTemplate.Employee_ID = template.EmployeeId;
                    localTemplate.BioAccess_ID = template.BioAccessId;

                    ctx.SaveChanges();
                }
                else
                {
                    //Does not exist and new site needs to be created
                    var localTemplate = new Template
                    {
                        FingerNumber = template.FingerNumber,
                        Template1 = template.Template,
                        TemplateType_ID = templateType,
                        Employee_ID = template.EmployeeId,
                        BioAccess_ID = template.BioAccessId
                    };
                    ctx.Templates.Add(localTemplate);
                }
            }
            //Commit after all transactions have been completed
            ctx.SaveChanges();
            return "";
        }

        public List<DataStructures.TemplateTypeBac> GetTemplateTypes()
        {
            var ctx = new BioAccessCloudEntities();
            var templateTypes = (from p in ctx.TemplateTypes select p).ToList();

            var output = templateTypes.Select(templateType => new DataStructures.TemplateTypeBac
            {
                TemplateTypeId = templateType.TemplateType_ID,
                Description = templateType.Description
            }).ToList();

            return output;
        }

        #endregion

        #region Groups

        //Groups
        public string CreateUpdateGroups(ref IEnumerable<DataStructures.GroupBac> groups)
        {
            var ctx = new BioAccessCloudEntities();
            foreach (var group in groups)
            {
                //Determine add or edit
                if (ctx.Groups.Any(x => x.BioAccess_ID == group.BioAccessId))
                {
                    //Already exists and needs to be updated
                    var localGroup = ctx.Groups.First(x => x.BioAccess_ID == group.BioAccessId);
                    localGroup.Name = group.GroupName;
                    localGroup.Site_ID = group.SiteId;
                    localGroup.Customer_ID = group.CustomerId;
                    localGroup.BioAccess_ID = group.BioAccessId;
                    ctx.SaveChanges();
                    group.GroupId = localGroup.Group_ID;
                }
                else
                {
                    //Does not exist and new site needs to be created
                    var localGroup = new Group
                    {
                        Name = group.GroupName,
                        Site_ID = group.SiteId,
                        Customer_ID = group.CustomerId,
                        BioAccess_ID = group.BioAccessId
                    };
                    ctx.Groups.Add(localGroup);
                    ctx.SaveChanges();
                    group.GroupId = localGroup.Group_ID;
                }
            }

            
            return "";
        }

        public string CreateUpdateGroupRelations(IEnumerable<DataStructures.EmployeeGroupBac> employeeGroups, int customerId)
        {
            var ctx = new BioAccessCloudEntities();
            
            //DELETE Groups for Customer ID
            var deleteItems =
                ctx.EmployeeGroups.Where(x => x.Group.BioAccess_ID != null && x.Group.Customer_ID == customerId);
            foreach (var employeeGroup in deleteItems)
            {
                ctx.EmployeeGroups.Remove(employeeGroup);
            }
            ctx.SaveChanges();

            foreach (var employeeGroup in employeeGroups)
            {
                var localGroup = new EmployeeGroup
                {
                    Employee_ID = employeeGroup.EmployeeId,
                    Group_ID = employeeGroup.GroupId
                };
                ctx.EmployeeGroups.Add(localGroup);
            }
            //Commit after all transactions have been completed
            ctx.SaveChanges();
            return "";
        }

        #endregion

        #region Transactions

        public List<DataStructures.AttendanceTransactionBac> GetTransactions(int customerId, DateTime? startDate, DateTime? endDate, bool? downloaded)
        {
            var ctx = new BioAccessCloudEntities();
            var transactions =
                (from p in ctx.AttendanceTransactions select p).Where(x => x.Employee.Customer_ID == customerId);

            if (startDate != null)
                transactions = transactions.Where(x => x.TransactionDate >= startDate);
            if (endDate != null)
                transactions = transactions.Where(x => x.TransactionDate <= endDate);
            if (downloaded != null)
                transactions = transactions.Where(x => x.Downloaded == downloaded);

            var lstTransactions = transactions.ToList();
            var transactionList = lstTransactions.Select(transaction => new DataStructures.AttendanceTransactionBac
            {
                AttendanceTransactionId = transaction.AttendanceTransaction_ID,
                Downloaded = transaction.Downloaded,
                Emei = transaction.EMEI,
                Employee = EmployeeBacs(new List<Employee>() {transaction.Employee})[0],
                EmployeeId = transaction.Employee_ID,
                InOut = transaction.InOut,
                Latitude = transaction.Latitude,
                Longitude = transaction.Longitude,
                TransactionDateTime = transaction.TransactionDate
            }).ToList();

            return transactionList;
        }

        public string InsertNewTransactions(IEnumerable<DataStructures.AttendanceTransactionBac> transactions)
        {
            var ctx = new BioAccessCloudEntities();
            var lstTransactions = transactions.Select(transaction => new AttendanceTransaction
            {
                Downloaded = false,
                EMEI = transaction.Emei,
                Employee_ID = transaction.EmployeeId,
                InOut = transaction.InOut,
                Latitude = transaction.Latitude,
                Longitude = transaction.Longitude,
                TransactionDate = transaction.TransactionDateTime
            }).ToList();
            ctx.AttendanceTransactions.AddRange(lstTransactions);
            ctx.SaveChanges();
            return "";
        }

        #endregion

    }
}
