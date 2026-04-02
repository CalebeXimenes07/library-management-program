# BibliotecaPoo

Sistema de biblioteca orientado a objetos em C#. Gerencia clientes, exemplares, bibliotecários, obras literárias, fornecedoras e unidades. Desenvolvido com foco em encapsulamento, herança e boas práticas de POO.

---

## Estrutura do Projeto

```
BibliotecaPoo/
├── Entities/
│   ├── Bibliotecario.cs
│   ├── Cliente.cs
│   ├── Exemplar.cs
│   ├── ObraLiteraria.cs
│   ├── FornecedorEditora.cs
│   ├── UnidadeBiblioteca.cs
│   ├── Genero.cs
│   ├── GeneroFiccao.cs
│   └── GeneroNaoFiccao.cs
└── Program.cs
```

---

## Entidades

| Classe | Responsabilidade |
|---|---|
| `Bibliotecario` | Funcionário que realiza empréstimos e solicita compras |
| `Cliente` | Usuário que toma exemplares emprestados |
| `Exemplar` | Cópia física de uma obra literária |
| `ObraLiteraria` | Livro com autor, título e ano de publicação |
| `FornecedorEditora` | Editora fornecedora de livros |
| `UnidadeBiblioteca` | Unidade física que possui bibliotecários |
| `Genero` | Classe base para gêneros literários |
| `GeneroFiccao` | Subclasse de Genero com estilo narrativo e público-alvo |
| `GeneroNaoFiccao` | Subclasse de Genero com área de estudo e nível de ensino |

---

## Funcionalidades

- Cadastro de clientes, bibliotecários e obras
- Empréstimo de exemplares por bibliotecários
- Supervisão entre bibliotecários
- Solicitação de compra de livros a fornecedoras
- Listagem de bibliotecários por unidade
- Classificação de obras por gênero (ficção / não ficção)

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
- **Herança** — `GeneroFiccao` e `GeneroNaoFiccao` herdam de `Genero`
- **Abstração** — cada classe representa uma entidade do domínio real
- **Construtores** — objetos só podem ser criados com dados válidos

