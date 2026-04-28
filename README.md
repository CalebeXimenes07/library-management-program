# BibliotecaPoo
Sistema de biblioteca orientado a objetos em C#. Gerencia clientes, exemplares, bibliotecários, obras literárias, fornecedoras e unidades. Desenvolvido com foco em encapsulamento, herança, boas práticas de POO e padrão Repository.

---

## Estrutura do Projeto
```
BibliotecaPoo/
├── Entities/
│   ├── Aluno.cs
│   ├── Bibliotecario.cs
│   ├── Cliente.cs
│   ├── Emprestimo.cs
│   ├── Exemplar.cs
│   ├── FornecedorEditora.cs
│   ├── Genero.cs
│   ├── GeneroFiccao.cs
│   ├── GeneroNaoFiccao.cs
│   ├── ObraLiteraria.cs
│   ├── PedidoDeCompra.cs
│   ├── Pesquisador.cs
│   ├── Professor.cs
│   └── UnidadeBiblioteca.cs
├── Interfaces/
│   ├── IAluno.cs
│   └── IProfessor.cs
├── Repositories/
│   ├── BibliotecarioRepository.cs
│   ├── ClienteRepository.cs
│   ├── EmprestimoRepository.cs
│   ├── ExemplarRepository.cs
│   ├── ObraLiterariaRepository.cs
│   └── RepositoryInterfaces/
│       ├── IBibliotecarioRepository.cs
│       ├── IClienteRepository.cs
│       ├── IEmprestimoRepository.cs
│       ├── IExemplarRepository.cs
│       └── IObraLiterariaRepository.cs
└── Program.cs
```

---

## Entidades

| Classe | Responsabilidade |
|---|---|
| `Bibliotecario` | Funcionário que realiza empréstimos e solicita compras |
| `Cliente` | Classe base para usuários que tomam exemplares emprestados |
| `Aluno` | Subclasse de Cliente com matrícula |
| `Professor` | Subclasse de Cliente com área de atuação |
| `Pesquisador` | Subclasse de Cliente com área de pesquisa e matrícula |
| `Emprestimo` | Registro de um exemplar emprestado a um cliente por um bibliotecário |
| `Exemplar` | Cópia física de uma obra literária |
| `ObraLiteraria` | Livro com autor, título, ano de publicação e gênero |
| `PedidoDeCompra` | Solicitação de compra de obras a uma fornecedora |
| `FornecedorEditora` | Editora fornecedora de livros |
| `UnidadeBiblioteca` | Unidade física que possui bibliotecários |
| `Genero` | Classe base para gêneros literários |
| `GeneroFiccao` | Subclasse de Genero com estilo narrativo e público-alvo |
| `GeneroNaoFiccao` | Subclasse de Genero com área de estudo e nível de ensino |

---

## Repositórios

Cada entidade principal possui um repositório com interface, seguindo o padrão Repository:

| Repositório | Interface | Operações |
|---|---|---|
| `BibliotecarioRepository` | `IBibliotecarioRepository` | Adicionar, ObterTodos, Atualizar, Remover |
| `ClienteRepository` | `IClienteRepository` | Adicionar, ObterTodos, Atualizar, Remover |
| `EmprestimoRepository` | `IEmprestimoRepository` | Adicionar, ObterTodos, Atualizar, Remover |
| `ExemplarRepository` | `IExemplarRepository` | Adicionar, ObterTodos, Atualizar, Remover |
| `ObraLiterariaRepository` | `IObraLiterariaRepository` | Adicionar, ObterTodos, Atualizar, Remover |

A camada de repositório está preparada para substituição de persistência em memória por banco de dados sem impacto no restante do sistema.

---

## Funcionalidades

- Cadastro de clientes (alunos, professores e pesquisadores), bibliotecários e obras
- Empréstimo de exemplares por bibliotecários
- Devolução e renovação de empréstimos
- Supervisão entre bibliotecários
- Solicitação de compra de livros a fornecedoras
- Listagem de bibliotecários por unidade
- Classificação de obras por gênero (ficção / não ficção)
- CRUD completo para todas as entidades principais via repositórios

---

## Como executar

Pré-requisitos: [.NET SDK](https://dotnet.microsoft.com/download) instalado (versão 10.0 ou superior)

```bash
# Clone o repositório
git clone https://github.com/CalebeXimenes07/BibliotecaPoo.git

# Entre na pasta do projeto
cd BibliotecaPoo

# Execute o projeto
dotnet run
```

---

## Tecnologias

- Linguagem: C#
- Plataforma: .NET 10
- IDE: Visual Studio 2022

---

## Conceitos de POO aplicados

- **Encapsulamento** — atributos privados expostos via propriedades `{ get; private set; }`
- **Herança** — `GeneroFiccao` e `GeneroNaoFiccao` herdam de `Genero`; `Aluno`, `Professor` e `Pesquisador` herdam de `Cliente`
- **Abstração** — cada classe representa uma entidade do domínio real
- **Interfaces** — `IAluno`, `IProfessor` e interfaces de repositório garantem contratos bem definidos
- **Construtores** — objetos só podem ser criados com dados válidos
- **Padrão Repository** — camada de acesso a dados isolada e substituível, com interfaces para cada repositório