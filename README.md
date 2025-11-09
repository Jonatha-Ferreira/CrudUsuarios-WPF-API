# 🧑‍💻 CRUD de Usuários | User Management System (WPF + ASP.NET Core API)

[![.NET](https://img.shields.io/badge/.NET-8.0-blueviolet?logo=dotnet)](https://dotnet.microsoft.com/)
[![WPF](https://img.shields.io/badge/WPF-Desktop%20App-lightgrey?logo=windows)](https://learn.microsoft.com/en-us/dotnet/desktop/wpf/)
[![License](https://img.shields.io/badge/license-MIT-green)](LICENSE)
[![GitHub Repo](https://img.shields.io/badge/github-repo-black?logo=github)](https://github.com/Jonatha-Ferreira)

---

## 🇧🇷 Descrição (Português)

Este projeto é um **CRUD completo de Usuários** desenvolvido em **C#**, utilizando:
- **ASP.NET Core Web API** para o backend (REST)
- **WPF (Windows Presentation Foundation)** para a interface gráfica desktop
- **Entity Framework Core (SQLite)** para persistência de dados

O objetivo é servir como **projeto de portfólio**, demonstrando boas práticas de arquitetura, versionamento e desenvolvimento full stack com .NET.

### 🎯 Objetivos
- Criar, listar, editar e excluir usuários.
- Aplicar o padrão **Clean Architecture** (Domain / Application / Infrastructure / API / UI).
- Utilizar **MVVM** no WPF.
- Demonstrar integração entre **API REST e aplicação desktop**.
- Seguir boas práticas de versionamento no GitHub.

---

## 🇺🇸 Description (English)

This project is a **complete User Management CRUD** built with **C#**, using:
- **ASP.NET Core Web API** for the backend (REST)
- **WPF (Windows Presentation Foundation)** for the desktop graphical interface
- **Entity Framework Core (SQLite)** for data persistence

The goal is to serve as a **portfolio project**, demonstrating solid architecture, clean code, version control, and full-stack development using the .NET ecosystem.

### 🎯 Goals
- Create, read, update, and delete users.
- Apply **Clean Architecture** principles (Domain / Application / Infrastructure / API / UI).
- Use **MVVM pattern** in WPF.
- Demonstrate integration between **REST API and desktop application**.
- Follow **Git best practices** and semantic commits.

---

## 🧩 Tecnologias / Technologies

| Camada | Tecnologia Principal |
|:--------|:--------------------|
| API Backend | ASP.NET Core 8.0 |
| Banco de Dados | SQLite + EF Core |
| Interface Desktop | WPF (MVVM) |
| ORM | Entity Framework Core |
| Documentação API | Swagger / Swashbuckle |
| Logs | Serilog |
| Mapper | AutoMapper |
| Validações | FluentValidation |

---

## 🏗️ Estrutura do Projeto / Project Structure
CrudUsuarios/
│
├── src/
│   ├── CrudUsuarios.Domain/           # Entidades e contratos
│   ├── CrudUsuarios.Application/      # DTOs e serviços de aplicação
│   ├── CrudUsuarios.Infrastructure/   # Contexto e persistência (EF Core)
│   ├── CrudUsuarios.API/              # API REST (Controllers, Endpoints)
│   └── CrudUsuarios.WPF/              # Interface Gráfica (MVVM)
│
└── tests/
    └── CrudUsuarios.Tests/            # Testes unitários

⚙️ Como Executar / How to Run
🔹 Pré-requisitos / Requirements

.NET SDK 8.0+

Visual Studio 2022 ou VS Code

(opcional) SQLite Viewer para inspecionar o banco de dados

🔹 Executar a API / Run the API
cd src/CrudUsuarios.API
dotnet run


A API será executada em:
➡️ https://localhost:5001/swagger

🔹 Executar o WPF / Run the WPF App
cd src/CrudUsuarios.WPF
dotnet run

🧠 Funcionalidades / Features

✅ Criar novo usuário
✅ Listar todos os usuários
✅ Editar informações
✅ Excluir usuários
✅ Interface moderna e responsiva (WPF + DataGrid)
✅ Comunicação com API REST em tempo real
✅ Banco de dados local SQLite

🧱 Arquitetura / Architecture
Domain        → Entidades e regras de negócio puras
Application   → Lógica de aplicação, DTOs e serviços
Infrastructure→ Persistência de dados e contexto do EF
API           → Exposição via endpoints REST
WPF (UI)      → Interface gráfica, padrão MVVM

🖼️ Capturas de Tela / Screenshots

(Adicione aqui prints reais da interface e do Swagger quando o projeto estiver rodando)

Interface Principal	API Swagger

	
🧾 Exemplos de Requisições / API Requests
➕ Criar Usuário / Create User
POST /api/v1/users
{
  "nome": "Jonatha Ferreira",
  "email": "jonatha@email.com",
  "telefone": "21999999999"
}

🔍 Listar Usuários / Get All Users
GET /api/v1/users

✏️ Atualizar Usuário / Update User
PUT /api/v1/users/{id}

❌ Excluir Usuário / Delete User
DELETE /api/v1/users/{id}

🧠 Boas Práticas Aplicadas / Best Practices

Clean Architecture e separação de camadas

Injeção de dependência (IoC)

MVVM para desacoplar UI e lógica

DTOs e AutoMapper para transferência de dados

Migrations controladas pelo EF Core

Versionamento semântico no Git

Commits padronizados (feat:, fix:, refactor:...)

README bilíngue (PT-BR e EN)

🧑‍💻 Autor / Author

Jonatha da Silva Ferreira
💼 GitHub

📧 jonatha@email.com

📍 Rio de Janeiro – RJ, Brasil

📜 Licença / License

Este projeto está sob a licença MIT.
This project is licensed under the MIT License.

✨ Desenvolvido como projeto de portfólio para demonstrar habilidades em C#, WPF e ASP.NET Core. ✨
