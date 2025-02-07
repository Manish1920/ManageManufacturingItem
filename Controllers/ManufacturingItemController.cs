using ManufacturingAPI.Helpers;
using ManufacturingAPI.Interfaces;
using ManufacturingAPI.Modals.RequestModal;
using ManufacturingAPI.Modals.ResponseModal;
using Microsoft.AspNetCore.Mvc;

namespace ManufacturingAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ManufacturingItemController : ControllerBase
    {
        private readonly IManufacturingItemRepository _manufacturingItemRepository;

        public ManufacturingItemController(IManufacturingItemRepository manufacturingItemRepository)
        {
            _manufacturingItemRepository = manufacturingItemRepository;
        }

        [HttpGet("all")]
        public async Task<ApiResponse<List<ManufacturingItem>>> GetAll()
        {
            var items = await _manufacturingItemRepository.GetAllManufacturingItemsAsync();
            return ApiResponseHelper.CreateResponse(
                items,
                items != null ? "Manufacturing items retrieved successfully" : "No manufacuring items found",
                items != null,
                items != null ? 200 : 404
            );
        }
        [HttpGet("district/{district}")]
        public async Task<ApiResponse<List<ManufacturingItem>>> GetByDistinct(string district)
        {
            var items = await _manufacturingItemRepository.GetManufacturingItemsByDistrictAsync(district);
            return ApiResponseHelper.CreateResponse(
                items,
                items != null ? "Manufacturing items retrieved by district successfully" : "No manufacuring items found",
                items != null,
                items != null ? 200 : 404
            );
        }
        [HttpGet("status/{status}")]
        public async Task<ApiResponse<List<ManufacturingItem>>> GetManufacturingItemsByStatusAsync(string status)
        {
            var items = await _manufacturingItemRepository.GetManufacturingItemsByStatusAsync(status);
            return ApiResponseHelper.CreateResponse(
                items,
                items != null ? "Manufacturing items retrieved by status successfully" : "No manufacuring items found",
                items != null,
                items != null ? 200 : 404
            );
        }

        [HttpPost]
        public async Task<ApiResponse<object>> InsertItem([FromBody] ManufacturingItemReq item)
        {
            int result = await _manufacturingItemRepository.InsertItemAsync(item);
            return ApiResponseHelper.CreateResponse<object>(
               null,
               result > 0 ? "Manufacturing item added successfully" : "Something went wrong",
               result > 0 ? true : false,
                result > 0 ? 201 : 400
           );
        }
        [HttpPut("{id}")]
        public async Task<ApiResponse<object>> UpdateItem(int id, [FromBody] UpdateManufacturingItem item)
        {
            item.Id = id;
            int result = await _manufacturingItemRepository.UpdateItemAsync(item);
            return ApiResponseHelper.CreateResponse<object>(
               null,
               result > 0 ? "Manufacturing item updated successfully" : "Something went wrong",
               result > 0 ? true : false,
                result > 0 ? 200 : 400
           );
        }
        [HttpDelete("{id}")]
        public async Task<ApiResponse<object>> DeleteItem(int id)
        {
            int result = await _manufacturingItemRepository.DeleteItemAsync(id);
            return ApiResponseHelper.CreateResponse<object>(
               null,
               result > 0 ? "Manufacturing item deleted successfully" : "Something went wrong",
               result > 0 ? true : false,
                result > 0 ? 200 : 400
           );
        }
    }
}
