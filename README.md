# Projeto Quadro Kanban em Blazor

Este é um projeto de um quadro de serviços no estilo Kanban, desenvolvido com Blazor. 
Ele permite a visualização e o gerenciamento de Ordens de Serviço (OS) através de colunas que 
representam diferentes status, com funcionalidade de arrastar e soltar (drag-and-drop).

## 🚀 Começando

Para obter uma cópia local e executá-la, siga estes passos.

### Pré-requisitos

Certifique-se de ter o SDK do .NET 8 (ou superior) instalado.

- [.NET 8 SDK](https://dotnet.microsoft.com/download/dotnet/8.0)

### Instalação

1.  Clone o repositório para a sua máquina local:
    ```sh
    git clone https://github.com/ramonsillva/data-car
    ```
2.  Navegue até o diretório do projeto:
    ```sh
    cd data-car
    ```

## ⚙️ Executando o Projeto

Siga os comandos abaixo para compilar e executar a aplicação.

1.  **Restaure os pacotes e dependências do projeto:**
    ```sh
    dotnet restore
    ```

2.  **Compile a aplicação:**
    ```sh
    dotnet build
    ```

3.  **Execute em modo de desenvolvimento com hot reload:**
    O *hot reload* permite que as alterações no código sejam aplicadas instantaneamente sem a necessidade de reiniciar a aplicação.
    ```sh
    dotnet watch run
    ```

Após executar o último comando, a aplicação estará disponível no endereço indicado no seu terminal (geralmente `http://localhost:5161` ou similar).

## 📌 Observações Importantes

-   **Dados Iniciais (Mock):** Os dados utilizados para popular o quadro são "mockados" (dados de exemplo) e estão definidos diretamente no arquivo `Components/Pages/Home.razor`.

-   **Persistência de Dados:** Para salvar os dados de forma permanente, será necessário integrar o projeto com uma solução de banco de dados, como SQL Server, SQLite, PostgreSQL, etc.

-   **Estrutura de CSS:** A estilização foi feita utilizando o isolamento de CSS do Blazor. Os estilos aplicados à página `Home` estão no arquivo `Home.razor.css` e não impactam outros componentes da aplicação, mantendo o código mais organizado e sem conflitos.
