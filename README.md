

# GUI Web in ASP.NET Core using C# and Entity Framework
<div display="flex" align="center">
<img src="./assets/c-sharp-icon.png" width='200' alt='C# Icon image'>
<img src="./assets/asp-net.png" width='230' alt='ASP.NET Icon image'>
<img src="./assets/mysql.png" width='225' alt='C# Icon image'>
</div>

<p>Este projeto modelo foi realizado como trabalho de finalização do curso <a href="https://www.udemy.com/course/programacao-orientada-a-objetos-csharp/">C# - Programação Orientada a Objetos + Projetos</a>, tendo como instrutor o <strong>Prof.Dr. Nélio Alves</strong>.</p>

## Índice 📘
- <a href="#sobre-🔍">Sobre </a>
    - <a href="#funcionalidades-⚙️">Funcionalidades</a>
    - <a href="#tecnologias-utilizadas-🛠️">Tecnologias utilizadas</a>
    - <a href="#layout-🖥️">Layout</a>
- <a href="#como-rodar-o-projeto">Como rodar o projeto?</a>
    - <a href="#configuração-do-mysql-v80-🐬">Configuração do MySQL v8.0</a>
- <a href="#autor-🤓">Autor</a>
- <a href="#próximos-passos-🏃‍♂️">Próximos passos</a>

## Sobre 🔍
Esta aplicação tem como objetivo a criação de um sistema de vendas para lojas, utilizando o framework <a href="https://github.com/dotnet/aspnetcore#getting-started">ASP.NET Core 2.1</a> em linguagem <a href="https://learn.microsoft.com/pt-br/dotnet/csharp/">C#</a> e utilização de um simples Banco de Dados <a href="https://www.mysql.com/">MySQL v8.0</a> 🐬

### Funcionalidades ⚙️
- [x] CRUD de departamentos
- [x] CRUD de vendedores
- [x] Simple Search de vendas por período
- [x] Grouping Search de vendas por departamento e período

### Tecnologias utilizadas 🛠️
- <a href="https://github.com/dotnet/aspnetcore#getting-started">ASP.NET Core 2.1</a>
- <a href="https://learn.microsoft.com/pt-br/dotnet/csharp/">C# Language</a>
- <a href="https://www.mysql.com/">MySQL 8.0</a> 
- <a href="https://bootswatch.com/3/">Bootstrap v.3</a>
- <a href="https://learn.microsoft.com/en-us/aspnet/core/mvc/views/razor?view=aspnetcore-8.0">Razor Engine</a>

### Layout 🖥️
<div align="center" margin-top="150">
<img src="./assets/HomeIndex.png" width='700' alt='Home Index image'>
<img src="./assets/DepartmentIndex.png" width='700' alt='Department Index image'>
<img src="./assets/SellerIndex.png" width='700' alt='Seller Index image'>
<img src="./assets/SalesRecordIndex.png" width='700' alt='SalesRecord Index image'>
</div>

## Como rodar o projeto?


> <p align="center" style="font-size:18px;padding-top:20px"><span style="color:red">ATENÇÃO!</span> Para rodar esse projeto em sua máquina será necessário a configuração do <a href="https://www.mysql.com/">MySQL v8.0</a> 🐬 e o arquivo <span style="color:#f7c716">appsetting.json</span></p>
> <p align="center" style="font-size:15px;padding-bottom:20px"><a href="#configuração-do-mysql-v80-🐬">Clique aqui</a> para verificar a configuração.</p>

```bash
    # Clone este repositório
    $ git clone https://github.com/andyzaum/workshop-asp-net-core-mvc.git

    # Acesse a pasta do projeto no terminal
    $ cd ./SalesWebMvc

    # Instale as ferramentas do .NET na versão 2.1
    $ dotnet tool install --global dotnet-ef --version 2.1

    # Inicie a migração para um banco de dados
    $ dotnet ef database update

    # Execute a aplicação
    $ dotnet run

    # A aplicação será iniciada na porta 5001 por padrão, acesse pelo navegador http://localhost:5001 (Seu terminal informará caso seja utilizada outra porta).
```
> Note que o site informará que a conexão não é segura!
>
> Para acessar ele de forma segura é recomendado abrir o <a href="https://visualstudio.microsoft.com/pt-br/">Microsoft Visual Studio</a> e iniciar ele por lá. No qual utilizará do serviço <a href="https://learn.microsoft.com/pt-br/iis/extensions/introduction-to-iis-express/iis-express-overview">IIS Express</a> para gerar um servidor seguro.

## Configuração do MySQL v8.0 🐬

- <a href="#caso-não-tenha-mysql-👇">Caso NÃO tenha MySQL</a>
- <a href="#caso-já-tenha-mysql-👇">Caso tenha MySQL</a>

### Caso NÃO tenha MySQL 👇
1. Faça a instalação do MySQL no site oficial [hhttps://dev.mysql.com/downloads/mysql/](https://dev.mysql.com/downloads/mysql/)
2. Na instalação será iniciado um serviço de rede do servidor nomeado de 'MySQL80'. (Você poderá verificar ele indo em 'Serviços' da sua máquina)
3. Após tudo instalado abra o MySQL Workbench e conecte com o servidor criado
4. Para que o programa identifique seu servidor será necessário alterar o <a href="./SalesWebMvc/appsettings.json">appsettings.json</a> localizado em './SalesWebMvc/appsettings.json'.
5. Em <a href="./SalesWebMvc/appsettings.json">appsettings.json</a> altere o <strong style="color:#ab6f2e">//YourID//</strong> e <strong style="color:#ab6f2e">//YourPassword//</strong> para o user e senha informado na criação do servidor
```json
{
  "Logging": {
    "LogLevel": {
      "Default": "Warning"
    }
  },
  "AllowedHosts": "*",
  "ConnectionStrings": {
    "SalesWebMvcContext": "server=localhost;userid=//YourID//;password=//YourPassword//;database=saleswebmvcappdb"
  }
}
```

#### Exemplo:
```json
}
//...
"AllowedHosts": "*",
  "ConnectionStrings": {
    "SalesWebMvcContext": "server=localhost;userid=developer;password=123456789;database=saleswebmvcappdb"
  }
}
```
6. Após finalizado a alteração, basta salvar e retornar para os passos de "[Como rodar o Como rodar este projeto?](#como-rodar-este-projeto)"

### Caso já tenha MySQL 👇
1. Para que o programa identifique seu servidor será necessário alterar o <a href="./SalesWebMvc/appsettings.json">appsettings.json</a> localizado em './SalesWebMvc/appsettings.json'.
2. Em <a href="./SalesWebMvc/appsettings.json">appsettings.json</a> altere o <strong style="color:#ab6f2e">//YourID//</strong> e <strong style="color:#ab6f2e">//YourPassword//</strong> para o user e senha informado na criação do servidor
```json
{
  "Logging": {
    "LogLevel": {
      "Default": "Warning"
    }
  },
  "AllowedHosts": "*",
  "ConnectionStrings": {
    "SalesWebMvcContext": "server=localhost;userid=//YourID//;password=//YourPassword//;database=saleswebmvcappdb"
  }
}
```

#### Exemplo:
```json
}
//...
"AllowedHosts": "*",
  "ConnectionStrings": {
    "SalesWebMvcContext": "server=localhost;userid=developer;password=123456789;database=saleswebmvcappdb"
  }
}
```
6. Após finalizado a alteração, basta salvar e retornar para os passos de "[Como rodar o Como rodar este projeto?](#como-rodar-este-projeto)"

## Autor 🤓
<div align="center">
    <img src="./assets/ME.JPG" width='300' alt='Autor image'>
    <p>Anderson Schlösser</p>
</div>
<ul>
    <li>
        <a href="https://www.linkedin.com/in/profissionalschlosser/">LinkedIn</a>
    </li>
    <li>
        <a href="mailto:profissionalandersonms@gmail.com">Gmail</a>
    </li>
    <li>
        <a href="https://github.com/andyzaum">Github</a>
    </li>
</ul>

## Próximos passos 🏃‍♂️
- [ ] Criação da função de realizar vendas
- [ ] Criação de design amigável para o usuário
- [ ] Atualização para o uso do [.NET Core v6.0](https://learn.microsoft.com/pt-br/dotnet/core/introduction)
