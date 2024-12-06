# Microsserviço de Gerenciamento de Produtos

## Visão Geral
Este microsserviço é responsável pelo gerenciamento de produtos em um sistema de e-commerce. Ele permite a criação, consulta e atualização de informações relacionadas aos produtos, como nome, descrição, valor, quantidade em estoque e imagem. O serviço foi desenvolvido utilizando **ASP.NET Core** e **Entity Framework Core**, e expõe uma API RESTful para interação com o sistema.

## Função do Microsserviço
O **Microsserviço de Gerenciamento de Produtos** armazena e fornece dados de produtos, permitindo que o sistema de e-commerce gerencie seus itens de forma eficiente. Ele oferece funcionalidades essenciais como a criação de novos produtos, a consulta de produtos existentes e a atualização da quantidade disponível em estoque. Esse microsserviço é essencial para garantir que as informações dos produtos sejam acessíveis e mantidas atualizadas, facilitando o processo de vendas e a gestão de estoque.

### Principais Funcionalidades
- **Criação de Produtos**: Permite o cadastro de novos produtos no sistema com informações detalhadas, como nome, descrição, valor, imagem e quantidade em estoque.
- **Consulta de Produtos**: Oferece a capacidade de consultar informações de um produto com base no seu **id**.
- **Atualização de Quantidade**: Permite a atualização da quantidade de um produto no estoque.
- **Armazenamento Seguro de Dados**: Garante a integridade e a segurança das informações dos produtos, como preço e quantidade.

## Usuários
Este microsserviço destina-se aos seguintes tipos de usuários:

- **Administradores**: Responsáveis por cadastrar, atualizar e gerenciar os produtos no sistema.
- **Sistemas de E-commerce**: Sistemas que consomem a API para acessar os dados dos produtos e realizar operações, como adicionar itens ao carrinho de compras ou exibir produtos disponíveis.

## Requisitos Funcionais
- *Cadastro de Produtos*: Permite o cadastro de novos produtos com informações como nome, descrição, valor, imagem e quantidade.
- *Consulta de Produtos: Permite a consulta de informações de um produto específico usando o **id*.
- *Atualização de Quantidade de Produtos*: Permite a atualização da quantidade de produtos em estoque.
- *Armazenamento Seguro de Dados*: Garante que os dados sensíveis dos produtos, como valor e quantidade, sejam manipulados de forma segura.

## Endpoints da API

### 1. *Criar Produto*
- *Método*: POST
- *URL*: /api/produto
- *Descrição*: Cria um novo produto no sistema.
- *Corpo da Requisição*:
```json
{
    "nome": "Produto Exemplo",
    "descricao": "Descrição do produto",
    "imagem": "url_da_imagem.jpg",
    "valor": 99.99,
    "quantidade": 50
}
