# FinancialAdminSystem

Sistema de administração financeira com **.NET 7**, **WPF** e **MySQL** utilizando Entity Framework Core.

## Projetos
- **Domain**: entidades de domínio
- **Infrastructure**: contexto do EF Core e serviços
- **UI**: aplicação WPF
- **Reports**: geração de relatórios

## Configuração
1. Instale .NET 7 e MySQL.
2. Ajuste `Infrastructure/appsettings.json` com sua conexão.
3. Para criar o banco:
   ```bash
   dotnet tool install --global dotnet-ef --version 7.0.0
   export PATH="$PATH:/root/.dotnet/tools"
   dotnet ef migrations add InitialCreate --project Infrastructure/Infrastructure.csproj --startup-project Infrastructure/Infrastructure.csproj
   dotnet ef database update --project Infrastructure/Infrastructure.csproj --startup-project Infrastructure/Infrastructure.csproj
   ```

## Execução
```
dotnet run --project UI/UI.csproj
```

## Estrutura
```
Domain/
Infrastructure/
UI/
Reports/
```

## Licença
MIT
