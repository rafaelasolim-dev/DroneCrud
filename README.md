# 🏥 AcademiaCrud

Sistema desenvolvido em **ASP.NET Core MVC** utilizando a linguagem **C#** e o padrão arquitetural **Model-View-Controller (MVC)**.

O projeto tem como objetivo demonstrar a implementação de um sistema CRUD (Create, Read, Update e Delete) para **cadastro e gerenciamento de drones**, utilizando boas práticas de desenvolvimento, persistência de dados com Entity Framework Core e interface responsiva com Bootstrap.

---

## 📋 Tecnologias Utilizadas

* C#
* .NET
* ASP.NET Core MVC
* SQL Server
* Entity Framework Core
* Bootstrap 5
* jQuery
* DataTables (Paginação, pesquisa e ordenação)

---

## 📦 Pacotes Utilizados

O projeto utiliza os seguintes pacotes do Entity Framework Core:

* Microsoft.EntityFrameworkCore
* Microsoft.EntityFrameworkCore.Tools
* Microsoft.EntityFrameworkCore.Design
* Microsoft.VisualStudio.Web.CodeGeneration.Design

---

## 🗄️ Banco de Dados

O banco de dados foi desenvolvido utilizando o **SQL Server**.

A criação da estrutura do banco foi realizada através da abordagem **Code First**, utilizando **Migrations** do Entity Framework Core.

A entidade principal do sistema é o **Drone**, contendo os seguintes campos:

* **Modelo**
* **Hélice**
* **Preço**
* **Data de Cadastro**

---

## 🚀 Funcionalidades

* Cadastro de drones
* Alteração de registros
* Exclusão de registros
* Consulta de drones cadastrados
* Paginação
* Pesquisa dinâmica
* Ordenação de colunas
* Interface responsiva
* Gerenciamento das informações de modelo, hélice, preço e data de cadastro

---

## 🎨 Interface

A interface foi desenvolvida utilizando:

* Bootstrap 5
* Razor Views
* jQuery
* DataTables

O DataTables é utilizado para facilitar a **pesquisa, paginação e ordenação** dos drones cadastrados.

---

# ▶️ Como Executar o Projeto

## Clone o repositório

```bash
git clone https://github.com/SEU-USUARIO/AcademiaCrud.git
```

## Abra a solução

Abra o projeto utilizando o **Visual Studio 2022**.

## Configure a conexão

Edite o arquivo:

```text
appsettings.json
```

Configure a string de conexão de acordo com o seu ambiente do **SQL Server**.

## Execute as Migrations

No Console do Gerenciador de Pacotes execute:

```powershell
Update-Database
```

Ou utilize o .NET CLI:

```bash
dotnet ef database update
```

## Execute o projeto

Pressione **F5** ou clique em **Iniciar** no Visual Studio.

---

# 📂 Estrutura do Projeto

```text
AcademiaCrud
│
├── Controllers
├── Models
├── Views
├── Data
├── Migrations
├── wwwroot
└── Program.cs
```

---

# 🚁 Cadastro de Drone

O sistema permite realizar o gerenciamento completo dos drones cadastrados.

Cada drone possui as seguintes informações:

| Campo                | Descrição                                     |
| -------------------- | --------------------------------------------- |
| **Modelo**           | Modelo ou identificação do drone              |
| **Hélice**           | Informações relacionadas à hélice do drone    |
| **Preço**            | Valor do drone                                |
| **Data de Cadastro** | Data em que o drone foi cadastrado no sistema |

O usuário pode **cadastrar, visualizar, editar e excluir** drones através da interface do sistema.

---

# 💻 Desenvolvido com

* ASP.NET Core MVC
* C#
* SQL Server
* Entity Framework Core
* Bootstrap 5
* jQuery
* DataTables

---

# 👨‍💻 Autores

### Desenvolvedor

**Rafaela Oliveira**

### Professor

**Wallace Oliveira dos Santos**
