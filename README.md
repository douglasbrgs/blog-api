# Blog API

Web API para gestão de um blog, desenvolvida como parte do curso "Fundamentos do ASP.NET 6" da plataforma de ensino [Balta.io](https://balta.io).

## Funcionalidades
- Login
- CRUD de Categorias
- CRUD de Posts

## Tecnologias Utilizadas
- .NET 6
- ASP.NET Web API
- Entity Framework Core
- SQL Server
- Azure

## Entity Framework

### Criar Migração
```
dotnet ef migration add [MIGRACAO]
```

### Aplicar Migração no Banco de Dados
```
dotnet ef database update
```

## Comandos do Azure

### Login CLI
```
az login
```

### Criar Resource Group
```
az group create --name [RESOURCE_GROUP] --location brazilsouth
az group list -o table
```

### Criar Storage Account
```
az storage account create --name [STORAGE_ACCOUNT] --resource-group [RESOURCE_GROUP] -l brazilsouth --sku Standard_LRS
az storage account show-connection-string --name [STORAGE_ACCOUNT] --resource-group [RESOURCE_GROUP]
```

### Criar App Service Plan
```
az appservice plan create --name [APP_SERVICE_PLAN] --resource-group [RESOURCE_GROUP] --sku F1 --is-linux
```

### Criar WebApp
```
az webapp create --name [WEBAPP] --plan [APP_SERVICE_PLAN] --resource-group [RESOURCE_GROUP] --runtime "DOTNETCORE:6.0"
az webapp browse -n [WEBAPP] --resource-group [RESOURCE_GROUP]
```

### Criar Credenciais de Publicação no Azure
```
az ad sp create-for-rbac --name "[CREDENCIAL]" --role contributor --scopes /subscriptions/[SUBSCRIPTION ID]/resourceGroups/[RESOURCE_GROUP] --sdk-auth
```

### Configurar IP SQL Server
```
az sql server firewall-rule list --server [SQL_SERVER] --resource-group [RESOURCE_GROUP] -o table
az sql server firewall-rule create --resource-group [RESOURCE_GROUP] --server [SQL_SERVER] --name ghactions --start-ip-address 1.2.3.4 --end-ip-address 5.6.7.8
```