using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Otiport.API.Contract.Request.ProfileItems;
using Otiport.API.Contract.Response.ProfileItems;

namespace Otiport.API.Services
{
    public interface IProfileItemService
    {
        Task<GetProfileItemsResponse> GetProfileItemsAsync(GetProfileItemsRequest request);
        Task<AddProfileItemResponse> AddProfileItemAsync(AddProfileItemRequest request);
        Task<DeleteProfileItemResponse> DeleteProfileItemAsync(DeleteProfileItemRequest request);
        Task<UpdateProfileItemResponse> UpdateProfileItemAsync(UpdateProfileItemRequest request);
    }
}
