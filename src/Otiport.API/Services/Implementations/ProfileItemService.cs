using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using Microsoft.Extensions.Logging;
using Otiport.API.Contract.Request.ProfileItems;
using Otiport.API.Contract.Response.ProfileItems;
using Otiport.API.Data.Entities.ProfileItem;
using Otiport.API.Mappers;
using Otiport.API.Repositories;

namespace Otiport.API.Services.Implementations
{
    public class ProfileItemService : IProfileItemService
    {
        private readonly ILogger<ProfileItemService> _logger;
        private readonly IProfileItemRepository _profileItemRepository;
        private readonly IProfileItemMapper _profileItemMapper;

        public ProfileItemService(ILogger<ProfileItemService> logger,
            IProfileItemRepository profileItemRepository,
            IProfileItemMapper profileItemMapper)
        {
            _logger = logger;
            _profileItemRepository = profileItemRepository;
            _profileItemMapper = profileItemMapper;
        }

        public async Task<AddProfileItemResponse> AddProfileItemAsync(AddProfileItemRequest request)
        {
            var response = new AddProfileItemResponse();
            ProfileItemEntity entity = _profileItemMapper.ToEntity(request);
            bool status = await _profileItemRepository.AddProfileItemAsync(entity);
            if (status)
            {
                response.StatusCode = (int)HttpStatusCode.Created;
            }
            else
            {
                response.StatusCode = (int)HttpStatusCode.BadRequest;
                _logger.LogWarning(""); //TODO - LOGGING
            }
            return response;
        }

        public async Task<DeleteProfileItemResponse> DeleteProfileItemAsync(DeleteProfileItemRequest request)
        {
            var response = new DeleteProfileItemResponse();
            ProfileItemEntity entity = await _profileItemRepository.GetProfileItemById(request.ProfileItemId);

            if (entity == null)
            {
                response.StatusCode = (int)HttpStatusCode.NotFound;
                return response;
            }

            bool status = await _profileItemRepository.DeleteProfileItemAsync(entity);
            if (status)
            {
                response.StatusCode = (int)HttpStatusCode.OK;
            }
            else
            {
                response.StatusCode = (int)HttpStatusCode.BadRequest;
                _logger.LogWarning(""); //TODO - LOGGING
            }

            return response;
        }

        public async Task<GetProfileItemsResponse> GetProfileItemsAsync(GetProfileItemsRequest request)
        {
            var response = new GetProfileItemsResponse();
            var list = await _profileItemRepository.GetProfileItemsAsync();
            response.ProfileItems = list.Select(x => _profileItemMapper.ToModel(x)).ToList();
            return response;
        }

        public async Task<UpdateProfileItemResponse> UpdateProfileItemAsync(UpdateProfileItemRequest request)
        {
            var response = new UpdateProfileItemResponse();
            ProfileItemEntity entity = await _profileItemRepository.GetProfileItemById(request.Id);
            if (entity == null)
            {
                response.StatusCode = (int)HttpStatusCode.NotFound;
                return response;
            }
            entity.Description = request.Description;
            entity.Title = request.Title;
            var result = await _profileItemRepository.UpdateProfileItemsAsync(entity);

            if (result)
            {
                response.StatusCode = (int)HttpStatusCode.OK;
            }
            else
            {
                response.StatusCode = (int)HttpStatusCode.InternalServerError;
                _logger.LogError("An error occurred");
            }

            return response;
        }
    }
}
