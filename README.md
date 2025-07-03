# FinancialAdminSystem

Sistema de administração financeira criado em **.NET 7** com **WPF** para interface de usuário e **MySQL** como banco de dados, utilizando o **Entity Framework Core**. O projeto segue o padrão MVVM e está dividido em quatro projetos principais.

## Tecnologias
- .NET 7
- WPF (Windows Presentation Foundation)
- MySQL
- Entity Framework Core (Pomelo)

## Estrutura de Projetos
```
FinancialAdminSystem.sln
├── Domain         # Entidades e regras de negócio
├── Infrastructure # Contexto EF Core, configurações e services
├── UI             # Aplicação WPF usando MVVM
└── Reports        # Geração de gráficos e relatórios
```

## Instalação
1. Instale o SDK do .NET 7 e o servidor MySQL.
2. Atualize a string de conexão em `Infrastructure/appsettings.json` conforme suas credenciais.

### Migrations e Banco de Dados
Para criar o banco de dados e aplicar a migration inicial:
```bash
dotnet tool install --global dotnet-ef --version 7.0.0
export PATH="$PATH:$HOME/.dotnet/tools"
dotnet ef migrations add InitialCreate --project Infrastructure/Infrastructure.csproj --startup-project Infrastructure/Infrastructure.csproj
dotnet ef database update --project Infrastructure/Infrastructure.csproj --startup-project Infrastructure/Infrastructure.csproj
```

## Executando
No replit ou localmente, utilize o arquivo `.replit` que já define o comando de execução:
```bash
dotnet run --project UI/UI.csproj
```

## Como Contribuir
1. Crie um fork do projeto.
2. Crie uma branch com sua feature.
3. Envie um pull request descrevendo suas alterações.

## Licença
Distribuído sob a licença MIT. Veja o arquivo [LICENSE](LICENSE) para mais detalhes.
