# Projeto do curso .NET 6: Relacionando Entidades da Alura

## Descrição

Este projeto demonstra a implementação de relacionamentos entre entidades utilizando o Entity Framework Core no .NET 6.  O projeto inclui as entidades `Filme`, `Cinema`, `Sessão` e `Endereço`, com seus respectivos relacionamentos:

* **1:1:** Entre `Cinema` e `Endereço` (um cinema possui um único endereço).
* **1:N:** Entre `Filme` e `Sessão` (um filme pode ter várias sessões), e entre `Cinema` e `Sessão` (um cinema pode ter várias sessões).
* **N:N:** Entre `Filme` e `Cinema` (um filme pode ser exibido em vários cinemas, e um cinema pode exibir vários filmes).

## Pré-requisitos

* .NET 8 SDK
* IDE de sua preferência (Visual Studio, Visual Studio Code, etc.)

## Instalação

1. Clone este repositório:
   ```bash
   git clone [URL do repositório]
2. Não esqueça de configurar as configurações do Banco de Dados, estou utilizando o PostgresSql