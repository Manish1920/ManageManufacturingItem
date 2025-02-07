using Dapper;
using ManufacturingAPI.Interfaces;
using ManufacturingAPI.Modals.RequestModal;
using ManufacturingAPI.Modals.ResponseModal;
using System.Data;

namespace ManufacturingAPI.Repository
{
    public class ManufacturingItemRepository : IManufacturingItemRepository
    {
        private readonly IDataAccessRepository _dataAccess;
        public ManufacturingItemRepository(IDataAccessRepository dataAccess)
        {
            _dataAccess = dataAccess;
        }
        public async Task<List<ManufacturingItem>> GetAllManufacturingItemsAsync()
        {
            string query = "ManageManufacturingItem";
            var parameter = new DynamicParameters();
            parameter.Add("@operationType", "GET_ALL", DbType.String);
            var response = (List<ManufacturingItem>)await _dataAccess.GetAll<ManufacturingItem, dynamic>(query, parameter);
            return response;
        }
        public async Task<List<ManufacturingItem>> GetManufacturingItemsByDistrictAsync(string district)
        {
            string query = "ManageManufacturingItem";
            var parameter = new DynamicParameters();
            parameter.Add("@operationType", "GET_BY_DISTRICT", DbType.String);
            parameter.Add("@district", district, DbType.String);
            var response = (List<ManufacturingItem>)await _dataAccess.GetAll<ManufacturingItem, dynamic>(query, parameter);
            return response;
        }
        public async Task<List<ManufacturingItem>> GetManufacturingItemsByStatusAsync(string status)
        {
            string query = "ManageManufacturingItem";
            var parameter = new DynamicParameters();
            parameter.Add("@operationType", "GET_BY_STATUS", DbType.String);
            parameter.Add("@itemStatus", status, DbType.String);
            var response = (List<ManufacturingItem>)await _dataAccess.GetAll<ManufacturingItem, dynamic>(query, parameter);
            return response;
        }
        public async Task<int> InsertItemAsync(ManufacturingItemReq item)
        {
            string query = "ManageManufacturingItem";
            var parameter = new DynamicParameters();
            parameter.Add("@operationType", "INSERT", DbType.String);
            parameter.Add("@itemName", item.Name, DbType.String);
            parameter.Add("@district", item.District, DbType.String);
            parameter.Add("@itemStatus", item.Status, DbType.String);
            return await _dataAccess.Insert(query, parameter);
        }
        public async Task<int> UpdateItemAsync(UpdateManufacturingItem item)
        {
            string query = "ManageManufacturingItem";
            var parameter = new DynamicParameters();
            parameter.Add("@operationType", "UPDATE", DbType.String);
            parameter.Add("@itemId", item.Id, DbType.Int32);
            parameter.Add("@itemName", item.Name, DbType.String);
            parameter.Add("@district", item.District, DbType.String);
            parameter.Add("@itemStatus", item.Status, DbType.String);
            return await _dataAccess.Update(query, parameter);
        }
        public async Task<int> DeleteItemAsync(int itemId)
        {
            string query = "ManageManufacturingItem";
            var parameter = new DynamicParameters();
            parameter.Add("@operationType", "DELETE", DbType.String);
            parameter.Add("@itemId", itemId, DbType.String);
            var response = await _dataAccess.Delete(query, parameter);
            return response;
        }
        

    }
}
