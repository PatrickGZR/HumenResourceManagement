using HRM.ApllicationCore.Model.Request;
using HRM.ApllicationCore.Model.Response;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRM.ApllicationCore.Service
{
    public interface IUserRoleServiceAsync
    {
        Task<int> AddUserRoleAsync(UserRoleRequestModel model);
        Task<int> UpdateUserRoleAsync(UserRoleRequestModel model);
        Task<int> DeleteUserRoleAsync(int id);
        Task<UserRoleResponseModel> GetUserRoleByIdAsync(int id);
        Task<IEnumerable<UserRoleResponseModel>> GetAllUserRolesAsync();

    }
}

