using ManufacturingAPI.Modals.RequestModal;
using ManufacturingAPI.Modals.ResponseModal;

namespace ManufacturingAPI.Interfaces
{
    public interface IManufacturingItemRepository
    {
        /// <summary>
        /// Get all manufacturing items
        /// </summary>
        /// <returns><see cref="List{ManufacturingItem}"/></returns>
        Task<List<ManufacturingItem>> GetAllManufacturingItemsAsync();
        /// <summary>
        /// Get manufacturing items by district
        /// </summary>
        /// <param name="district"></param>
        /// <returns><see cref="List{ManufacturingItem}"/></returns>
        Task<List<ManufacturingItem>> GetManufacturingItemsByDistrictAsync(string district);
        /// <summary>
        /// Get manufacturing items by status
        /// </summary>
        /// <param name="status"></param>
        /// <returns><see cref="List{ManufacturingItem}"/></returns>
        Task<List<ManufacturingItem>> GetManufacturingItemsByStatusAsync(string status);
        /// <summary>
        /// Insert manufacturing item
        /// </summary>
        /// <param name="item"></param>
        /// <returns><see cref="int"/></returns>
        Task<int> InsertItemAsync(ManufacturingItemReq item);
        /// <summary>
        /// Update manufacturing item
        /// </summary>
        /// <param name="item"></param>
        /// <returns><see cref="int"/></returns>
        Task<int> UpdateItemAsync(UpdateManufacturingItem item);
        /// <summary>
        /// Delete manufacturing item
        /// </summary>
        /// <param name="itemId"></param>
        /// <returns><see cref="int"/></returns>
        Task<int> DeleteItemAsync(int itemId);
    }
}
