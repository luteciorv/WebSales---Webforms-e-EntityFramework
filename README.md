# WebSales - Webforms e EntityFramework
Um site de gerenciamento de Departamentos, vendedores e registros de vendas utilizando o Webforms e o EntityFramework

### Artifícios em Destaque
> * Desenvolvido em Webforms com C#
> * Comunicação com o banco de dados local através do EntityFramework
> * Código organizado em funções (Padrão MVC) e de fácil entendimento
> * CRUD de Departamentos
> * CRUD de Vendedores
> * Consultar os registros de vendas por data
> * Fácil navegação pelas páginas (Veja a URL, ela contém muitas informações úteis)

### Explicação do sistema
> * O projeto consiste em um sisteminha de vendas onlne onde você gerencia os departamentos e os vendedores, claro, existem também os registros de vendas
> dos mesmos, não não foi criado nenhuma tela/lógica para adicionar los aos vendedores. Apenas via código ou banco de dados é possível fazer isso, bem como
> atualizar ou apagar. Em outras palavras, não foi desenvolvido o CRUD para os registros de vendas.

> * É possível adicionar um Departamento utilizando um nome como identificador (O número Id será criado automaticamente assim que um objeto novo, tanto
> departamento quanto vendedores, forem criados), não pode ser existente claro, caso contrário será exibido uma mensagem dizendo isso.
> * Também é possível ver os detalhes desse departamento, isto é, seu Id, Nome, Vendedores associados a ele e etc.
> * O mesmo se aplica aos vendedores, com a diferença de que ao criar um vendedor, este deverá ser associado a um departamento existe.

### Teste por sí só
> * O programa armazena os dados no banco de dados SQLServer Local. Então qualquer coisa certifique-se de que a conection string de fato está certa. Ao abrir
> o programa você será direcionado para a tela inicial dele. Nela será notado explicitamente um menu superior (Nav Bar) contendo acesso as demais telas.
> Acesse elas, adicione um departamento, edite, exclua,, realize o mesmo para os vendedores, veja os registros de vendas (Procure por volta de 2018), etc. 
> 

### Telas
> * Tela Inicial
![](Images/MainScreen.PNG?raw=true)

> * Departamentos
![](Images/Departments.PNG?raw=true)

> * Vendedores
![](Images/Sellers.PNG?raw=true)

> * Registros de Vendas
![](Images/SalesRecords.PNG?raw=true)
