# Manufacturing items

This project provides a comprehensive solution for managing manufacturing items, including functionality for retrieving items, filtering by district or status, and performing CRUD operations (Create, Read, Update, Delete). It is designed to streamline the management process of manufacturing inventory by allowing users to easily access and manipulate item data.

## Clone Repository
git clone https://github.com/Manish1920/ManageManufacturingItem.git

### For access UI
https://localhost:7181/ManufacturingItem

### For access swagger UI
https://localhost:7181/swagger/index.html


## Database Configuration
Use the following format for your connection string in the appsettings.json file:
```
"ConnectionStrings": {
  "ManufacturingDB": "Server=YOUR_SERVER_NAME;Database=ManufacturingDB;User Id=YOUR_USERNAME;Password=YOUR_PASSWORD;TrustServerCertificate=True;"
}
```
Replace Server name, User name and User Id as pe your server configuration.








## Feature
```
Retrieve All Manufacturing Items: Fetch a list of all manufacturing items in the system.

Filter by District: Retrieve manufacturing items based on a specific district.

Filter by Status: Get manufacturing items that match a specific status.

CRUD Operations:

Create: Insert new manufacturing items into the system.

Read: View details of a specific item or a list of items.

Update: Edit the details of existing manufacturing items.

Delete: Remove manufacturing items from the system.
````
---




## API Reference

#### Get all Products

```http
  GET /api/Manufacturingitem/all
```

| Parameter | Type     | Description                              |
| :-------- | :------- | :--------------------------------------- |
| `api_key` | `string` | **Required**. Your API key to access the endpoint. |

#### Get Items by District

```http
  GET /api/Manufacturingitem/district/{districtName}
```

| Parameter     | Type     | Description                                               |
| :------------ | :------- | :-------------------------------------------------------- |
| `districtName`| `string` | **Required**. The name of the district to filter items by. |

#### Get Items by Status

```http
  GET /api/Manufacturingitem/status/{status}
```

| Parameter | Type     | Description                                               |
| :-------- | :------- | :-------------------------------------------------------- |
| `status`  | `string` | **Required**. The status to filter items by (e.g., "Active"). |

#### Add Manufacturing Product

```http
  POST /api/Manufacturingitem
```

| Parameter  | Type     | Description                              |
| :--------- | :------- | :--------------------------------------- |
| `name`     | `string` | **Required**. The name of the manufacturing product. |
| `district` | `string` | **Required**. The district the product belongs to. |
| `status`   | `string` | **Required**. The current status of the product (e.g., "Active"). |

**Request Body**:
```json
{
  "name": "Copper",
  "district": "Ahmedabad",
  "status": "Active"
}
```

#### Update Manufacturing Product

```http
  PUT /api/Manufacturingitem/{id}
```

| Parameter | Type     | Description                              |
| :-------- | :------- | :--------------------------------------- |
| `id`      | `string` | **Required**. The ID of the product to update. |
| `name`    | `string` | **Required**. The updated name of the product. |
| `district`| `string` | **Required**. The updated district of the product. |
| `status`  | `string` | **Required**. The updated status of the product. |

**Request Body**:
```json
{
  "name": "Iron",
  "district": "Mumbai",
  "status": "Active"
}
```

#### Delete Manufacturing Product

```http
  DELETE /api/Manufacturingitem/{id}
```

| Parameter | Type     | Description                              |
| :-------- | :------- | :--------------------------------------- |
| `id`      | `string` | **Required**. The ID of the product to delete. |

---

## Support

For support, email manishbharambe2000@gmail.com

