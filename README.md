# Indomarco Customer Application

A simple .NET application for managing customer data using layered architecture with Entity Framework Core and PostgreSQL.



## Tech Stack



**Server:** .Net Core, Entity Framework, PostgreSQL





\## Environment Variables



To run this project, you will need to add the following environment variables to your .env file



`DB\_CONNECTION\_STRING` your postgreSQL connection





\## API Reference



\#### Create Customer



```http

&nbsp; POST /api/v1/Customer/CreateCustomer

```



\- ##### Request



```json

{

&nbsp; "customerCode": "00005",

&nbsp; "customerName": "AHMAD ILHAM",

&nbsp; "customerAddress": "Jl. Mangga Dua Raya",

&nbsp; "createdBy": 1

}

```

\- ##### Response



```json

{

&nbsp; "message": "Successfully Create Customer",

&nbsp; "statusCode": 200,

&nbsp; "transactionId": "ada55d75-9f59-4fd9-8d8c-82136badfc78"

}

```





\#### Get All Customer



```http

&nbsp; GET /api/v1/Customer/GetAllCustomer

```



\- ##### Response



```json

{

&nbsp; "data": \[

&nbsp;   {

&nbsp;     "customerId": 1,

&nbsp;     "customerCode": "000001",

&nbsp;     "customerName": "User Pertama",

&nbsp;     "customerAddress": "Jl. Mangga Dua Raya",

&nbsp;     "createdBy": 1,

&nbsp;     "createdAt": "2025-07-31T17:18:39.047448Z",

&nbsp;     "modifiedBy": null,

&nbsp;     "modifiedAt": null

&nbsp;   },

&nbsp;   {

&nbsp;     "customerId": 2,

&nbsp;     "customerCode": "00002",

&nbsp;     "customerName": "Ilham",

&nbsp;     "customerAddress": "Jl. Mangga Dua Raya",

&nbsp;     "createdBy": 10,

&nbsp;     "createdAt": "2025-07-31T17:45:11.386859Z",

&nbsp;     "modifiedBy": null,

&nbsp;     "modifiedAt": null

&nbsp;   },

&nbsp;   {

&nbsp;     "customerId": 3,

&nbsp;     "customerCode": "00005",

&nbsp;     "customerName": "AHMAD ILHAM",

&nbsp;     "customerAddress": "Jl. Mangga Dua Raya",

&nbsp;     "createdBy": 1,

&nbsp;     "createdAt": "2025-08-01T06:30:43.755695Z",

&nbsp;     "modifiedBy": null,

&nbsp;     "modifiedAt": null

&nbsp;   }

&nbsp; ],

&nbsp; "message": "Successfully Get Data",

&nbsp; "statusCode": 200,

&nbsp; "transactionId": "018ffd74-bc7f-4568-a245-daa4739a6749"

}

```





\#### Get Customer By ID



```http

&nbsp; GET /api/v1/Customer/GetCustomerById/${id}

```



| Parameter | Type     | Description                       |

| :-------- | :------- | :-------------------------------- |

| `id`      | `string` | \*\*Required\*\*. Id of item to fetch |



\- ##### Response



```json

{

&nbsp; "data": {

&nbsp;   "customerId": 1,

&nbsp;   "customerCode": "000001",

&nbsp;   "customerName": "User Pertama",

&nbsp;   "customerAddress": "Jl. Mangga Dua Raya",

&nbsp;   "createdBy": 1,

&nbsp;   "createdAt": "2025-07-31T17:18:39.047448Z",

&nbsp;   "modifiedBy": null,

&nbsp;   "modifiedAt": null

&nbsp; },

&nbsp; "message": "Successfully Get Data",

&nbsp; "statusCode": 200,

&nbsp; "transactionId": "2e42e325-082c-48ed-9b0b-9b208ba25352"

}

```





\#### Update Customer



```http

&nbsp; PUT /api/v1/Customer/UpdateCustomer

```



\- ##### Request



```json

{

&nbsp; "customerID": 1,

&nbsp; "customerCode": "021838",

&nbsp; "customerName": "Johnny Deep",

&nbsp; "customerAddress": "Jl. Merdeka",

&nbsp; "modifiedBy": 1

}

```

\- ##### Response



```json

{

&nbsp; "message": "Successfully Update Customer",

&nbsp; "statusCode": 200,

&nbsp; "transactionId": "99d839fd-6d31-41be-85f3-46bc72fe0e55"

}

```







\#### Delete Customer 



```http

&nbsp; DELETE /api/v1/Customer/DeleteCustomerById/${id}

```



| Parameter | Type     | Description                       |

| :-------- | :------- | :-------------------------------- |

| `id`      | `string` | \*\*Required\*\*. Id of item to fetch |



\- ##### Response



```json

{

&nbsp; "message": "Successfully Delete Customer",

&nbsp; "statusCode": 200,

&nbsp; "transactionId": "f45abe77-af65-414f-a4f6-a1c9f4aec300"

}

```





## Authors

* [@ahmadelham21](https://www.github.com/ahmadelham21)
