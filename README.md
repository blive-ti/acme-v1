# [bLive](http://blive-ti.com.br/)
</br>

#### A aplicação

Novas tecnologias surgem a todo instante, porém nem sempre é possível atualizar sistemas existentes, os chamados "legado", para versões mais novas ou mesmo migrar para novas plataforma. Para resolver parte desse sistema a bLive está desenvolvendo uma solução para integrar dois sistemas que se utilizam de tecnologias diferentes para prover informações a seus clientes.
A aplicação Acme já teve seu desenvolvimento iniciado e você implementar as funcionalidades a seguir. 

##### Funcionalidades

###### 1. Atualização do cadastro de clientes

Alguns clientes existentes no banco de dados não estão com os dados de endereço completos. Use o sistema [ViaCep](https://viacep.com.br/) para obter o endereço de um cliente usando o CEP. Caso CEP termine com número ímpar, a consulta deve ser usando o formato XML, caso seja para, usando o formato JSON.  ```https://viacep.com.br/ws/{cep}/{formato}```
Abaixo estão dois exemplos de chamada:

```
https://viacep.com.br/ws/30380435/xml
https://viacep.com.br/ws/34001164/json
```

Após obter o endereço, atualize a tabela endereço do cliente.

O processo pode ser iniciado de 2 formas:
* Através de uma chamada ao endpoint ```/api/atualizar/{id_cliente}```
* Através de um serviço em background iniciado junto com a aplicação e de tempos em tempos verifica os clientes com endereço inválido e dispara o processo de atualização.

###### 2. Relatório de clientes com cadastro incompleto

A equipe de FrontEnd já está desenvolvendo a funcionalidade para exibir um relatório com a lista dos clientes que estão com os dados de endereço incompletos. Desenvolva o endpoint ```/api/correcao/``` que irá fornecer a lista dos clientes para o relatório. 

###### 3. [Bônus] Adicionar validação no cadastro de clientes

Para cadastrar novos clientes o endpoint ```/api/cliente``` deve ser usado. Abaixo está o exemplo de uma chamada para o cadastro de um cliente completo:
```
POST /api/cliente HTTP/1.1
Host: localhost:5001
Content-Type: application/json
cache-control: no-cache
Postman-Token: 816cc5b2-32d2-4eb4-8262-0cbf3bfa66d7

{
    "nome": "bLive",
    "cpf": "012.345.678-90",
    "endereco": {
        "cep": "30380-435",
        "logradouro": "Avenida Raja Gabaglia",
        "complemento": "6 Andar",
        "bairro": "Luxemburgo",
        "localidade": "Belo Horizonte",
        "uf": "MG",
        "ibge": "3106200"
    }
}
```

Porém, caso um cliente seja cadastrado com CPF em branco ou nulo, o sistema deve retornar um erro. Verifique os diferentes [códigos http](https://developer.mozilla.org/pt-BR/docs/Web/HTTP/Status) que podem ser retornados. _Não é necessário validar o formato do CPF_.

##### Testes

Usando xUnit (preferencialmente) ou NUnit escrever testes unitários para validar o processo de escolha do formato (Xml ou JSON) que será feito a consulta do CEP.

As chamadas para os endpoints ```api/correcao``` e (se for a escolha) ```api/atualizar/{id_cliente}``` deverão ser feitas usando Postman.

##### Informações adicionais

[BackgroundService](https://docs.microsoft.com/pt-br/dotnet/architecture/microservices/multi-container-microservice-net-applications/background-tasks-with-ihostedservice)
[Teste Web-Apps](https://docs.microsoft.com/pt-br/dotnet/architecture/microservices/multi-container-microservice-net-applications/test-aspnet-core-services-web-apps)
[Swagger](https://swagger.io/)

##### Ambiente
.NET Core 2.2 [download](https://dotnet.microsoft.com/download/thank-you/dotnet-sdk-2.2.402-windows-x64-installer)

Visual Studio 2019 Community [download](https://visualstudio.microsoft.com/pt-br/thank-you-downloading-visual-studio/?sku=Community&rel=16)

Ao realizar o debug escolher a opção Blive.Acme.App ao invés de IIS Express. No exemplo abaixo seria a opção MultiDebugSample.WebApp1.
![Hosting Options](https://i2.wp.com/www.dotnetcatch.com/wp-content/uploads/2018/10/image_thumb-5.png?resize=498%2C374&ssl=1)

https://localhost:5001/swagger/index.html'