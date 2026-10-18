# TaskFlow – Gerenciador de Tarefas via Console

Aplicação console em **.NET 10** para gerenciar uma lista de tarefas (To-Do List), com testes unitários em **xUnit** e histórico de commits no padrão **Conventional Commits**.

## Pré-requisitos

- [.NET 10 SDK](https://dotnet.microsoft.com/download)
- Git

## Como compilar

Na pasta raiz do repositório:

```bash
dotnet build
```

## Como rodar a aplicação

```bash
dotnet run --project TaskFlow.Console
```

Menu disponível:

| Opção | Ação |
|-------|------|
| 1 | Adicionar tarefa |
| 2 | Listar tarefas |
| 3 | Concluir tarefa |
| 0 | Sair |

## Como executar os testes

```bash
dotnet test
```

## Estrutura do projeto

```
taskflow-console/
├── TaskFlow.slnx
├── TaskFlow.Console/        # Aplicação
│   ├── TaskItem.cs          # Entidade de domínio
│   ├── TaskManager.cs       # Gerenciamento das tarefas em memória
│   └── Program.cs           # Menu interativo
└── TaskFlow.Tests/          # Testes unitários (xUnit)
    └── TaskManagerTests.cs
```
