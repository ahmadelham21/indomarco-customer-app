# Indomarco Customer Application

A simple .NET application for managing customer data using layered architecture with Entity Framework Core and PostgreSQL.

## Tech Stack

**Server:** .Net Core, Entity Framework, PostgreSQL

## Environment Variables

To run this project, you will need to add the following environment variables to your .env file

`DB_CONNECTION_STRING` your postgreSQL connection

## API Reference

#### Create Customer

```http
  POST /api/v1/Customer/CreateCustomer
```

- ##### Request

```json
{
  "customerCode": "00005",
  "customerName": "AHMAD ILHAM",
  "customerAddress": "Jl. Mangga Dua Raya",
  "createdBy": 1
}
```

- ##### Response

```json
{
  "message": "Successfully Create Customer",
  "statusCode": 200,
  "transactionId": "ada55d75-9f59-4fd9-8d8c-82136badfc78"
}
```

#### Get All Customer

```http
  GET /api/v1/Customer/GetAllCustomer
```

- ##### Response

```json
{
  "data": [
    {
      "customerId": 1,
      "customerCode": "000001",
      "customerName": "User Pertama",
      "customerAddress": "Jl. Mangga Dua Raya",
      "createdBy": 1,
      "createdAt": "2025-07-31T17:18:39.047448Z",
      "modifiedBy": null,
      "modifiedAt": null
    },
    {
      "customerId": 2,
      "customerCode": "00002",
      "customerName": "Ilham",
      "customerAddress": "Jl. Mangga Dua Raya",
      "createdBy": 10,
      "createdAt": "2025-07-31T17:45:11.386859Z",
      "modifiedBy": null,
      "modifiedAt": null
    },
    {
      "customerId": 3,
      "customerCode": "00005",
      "customerName": "AHMAD ILHAM",
      "customerAddress": "Jl. Mangga Dua Raya",
      "createdBy": 1,
      "createdAt": "2025-08-01T06:30:43.755695Z",
      "modifiedBy": null,
      "modifiedAt": null
    }
  ],
  "message": "Successfully Get Data",
  "statusCode": 200,
  "transactionId": "018ffd74-bc7f-4568-a245-daa4739a6749"
}
```

#### Get Customer By ID

```http
  GET /api/v1/Customer/GetCustomerById/${id}
```

| Parameter | Type     | Description                       |
| :-------- | :------- | :-------------------------------- |
| `id`      | `string` | **Required**. Id of item to fetch |

- ##### Response

```json
{
  "data": {
    "customerId": 1,
    "customerCode": "000001",
    "customerName": "User Pertama",
    "customerAddress": "Jl. Mangga Dua Raya",
    "createdBy": 1,
    "createdAt": "2025-07-31T17:18:39.047448Z",
    "modifiedBy": null,
    "modifiedAt": null
  },
  "message": "Successfully Get Data",
  "statusCode": 200,
  "transactionId": "2e42e325-082c-48ed-9b0b-9b208ba25352"
}
```

#### Update Customer

```http
  PUT /api/v1/Customer/UpdateCustomer
```

- ##### Request

```json
{
  "customerID": 1,
  "customerCode": "021838",
  "customerName": "Johnny Deep",
  "customerAddress": "Jl. Merdeka",
  "modifiedBy": 1
}
```

- ##### Response

```json
{
  "message": "Successfully Update Customer",
  "statusCode": 200,
  "transactionId": "99d839fd-6d31-41be-85f3-46bc72fe0e55"
}
```

#### Delete Customer

```http
  DELETE /api/v1/Customer/DeleteCustomerById/${id}
```

| Parameter | Type     | Description                       |
| :-------- | :------- | :-------------------------------- |
| `id`      | `string` | **Required**. Id of item to fetch |

- ##### Response

```json
{
  "message": "Successfully Delete Customer",
  "statusCode": 200,
  "transactionId": "f45abe77-af65-414f-a4f6-a1c9f4aec300"
}
```

## Authors

- [@ahmadelham21](https://www.github.com/ahmadelham21)
