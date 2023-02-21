using HRM.ApllicationCore.Model.Request;
using HRM.ApllicationCore.Model.Response;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRM.ApllicationCore.Service
{
    public interface IEmployeeRoleServiceAsync
    {
        Task<int> AddEmployeeRoleAsync(EmployeeRoleRequestModel model);
        Task<int> UpdateEmployeeRoleAsync(EmployeeRoleRequestModel model);
        Task<int> DeleteEmployeeRoleAsync(int id);
        Task<EmployeeRoleResponseModel> GetEmployeeRoleByIdAsync(int id);
        Task<IEnumerable<EmployeeRoleResponseModel>> GetAllEmployeeRolesAsync();

    }
}
