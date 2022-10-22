# CostAccountingAPI
Cost accounting REST API

Deployed project: https://costaccountingapi.herokuapp.com/

## Installing .NET6.0

**Windows**

Download from the link:  https://dotnet.microsoft.com/en-us/download/dotnet

**Linux**

Add the Microsoft package signing key to the list of validated keys and add the repository:

 ```wget https://packages.microsoft.com/config/ubuntu/21.04/packages-microsoft-prod.deb -O packages-microsoft-prod.deb``` 
  
  ```sudo dpkg -i packages-microsoft-prod.deb```
  
  ```rm packages-microsoft-prod.deb```
  
Install the SDK for .NET:

  ```sudo apt-get update```
  
  ```sudo apt-get install -y apt-transport-https```
  
  ```sudo apt-get update```
  
  ```sudo apt-get install -y dotnet-sdk-6.0```
  
Install the .NET runtime:
  
  ```sudo apt-get install -y dotnet-runtime-6.0```

## Project launch

Clone the repository:

 ```git clone https://github.com/juliion/CostAccountingAPI.git```

Go to the working directory of the cloned project "CostAccountingAPI"

   ```cd CostAccountingAPI/CostAccountingAPI```

Run the project:

 ```dotnet run```

## Launch Docker

Go to the directory with the Dockerfile "CostAccountingAPI":

 ```cd CostAccountingAPI/CostAccountingAPI```

Build the image from the Dockerfile:

 ```docker build -t <image name> .```
 
Run docker:

 ```docker run --rm -it -d -p <your port>:80 <image name>```
 
or

 ```docker-compose build```
 and
 ```docker-compose up```
 
## Functionality

### 1. Сreate user
**POST** https://costaccountingapi.herokuapp.com/Costs/CreateUser
```
{
  "id": "number", 
  "name": "string"
}
```

Response
```
{
  "id": "number"
}
```

### 2. Сreate category
**POST** https://costaccountingapi.herokuapp.com/Costs/CreateCategory
```
{
  "id": "number", 
  "name": "string"
}
```

Response
```
{
  "id": "number"
}
```

### 3. Сreate record
**POST** https://costaccountingapi.herokuapp.com/Costs/CreateRecord
```
{
  "id": "number",
  "userId": "number",
  "categoryId": "number",
  "date": "2022-10-22T12:28:22.578Z",
  "costs": "number"
}
```

Response
```
{
  "id": "number"
}
```

### 4. Get a list of categories
**GET** https://costaccountingapi.herokuapp.com/Costs/GetCategories

Response
```
[{
  "id": "number",
  "name": "string"
}]
```

### 5. Get list of records by user
**GET** https://costaccountingapi.herokuapp.com/Costs/GetRecordsByUser?userId=1

Response
```
[{
  "id": "number",
  "userId": "number",
  "categoryId": "number",
  "date": "2022-10-22T12:28:22.578Z",
  "costs": "number"
}]
```

### 6. Get list of records by user and category
**GET** https://costaccountingapi.herokuapp.com/Costs/GetRecordsByUserAndCategory?userId=2&categoryId=2

Response
```
[{
  id": "number",
  "userId": "number",
  "categoryId": "number",
  "date": "2022-10-22T12:28:22.578Z",
  "costs": "number"
}]
```
