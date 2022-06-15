# sistema_de_tarefas.NET
 Gerenciado de Tarefas que permite adicionar as principais tarefas e informaçoes do usuário, permitindo a organização de tarefas em um sistema web, distribuindo-as como um checklist e armazenando-as de forma segura.
 
# Tecnologias Utilizadas
- Linguagem C# 
- Framework .NET 6
- ASP .NET Core 6 (Modelo MVC)
- Entity Framework
- Bando de Dados SQLite

# Objetivo do Sistema

O programa foi pensado para ser uma solução simples e prática de organizar as tarefas mais importantes do dia a dia. Assim como um facilitador para anotar as ideias que surgem instantaneamente e precisam ser anotadas de forma rápida. 
Vantagens da aplicação:
- Velocidade: O programa funciona rapidamente para atender o usuário que acaba de ter uma ideia ou inspiração; 
- Segurança: As ideias ou tarefas são guardadas no banco de dados de forma que todas as informações se mantêm seguras, diferentemente de anotar em um arquivo simples no computador local correndo o risco de perder.
- Organização: As tarefas são organizadas de uma maneira coesa, onde o usuário pode marcar as tarefas já concluídas.

# Tela de Registro
![2 0 - Tela Registro](https://user-images.githubusercontent.com/10932478/173901279-c34a1594-0fbb-4d88-acde-087f07a05680.PNG)

</br>Para entrar no sistema, o usuário precisa criar um conta. O processo é bastante simples, inserindo apenas um email e uma senha.

# Tela Inicial
![image](https://user-images.githubusercontent.com/10932478/173901440-12466727-408d-4cf8-b8d2-63d304e71879.png)

</br>Após fazer o login, o usuário se depara com essa tela, onde pode clicar no botão 'Criar Nova Tarefa' para começar a usar as funcionalidades do sistema.

# Tela de Cadastrar Tarefas
![image](https://user-images.githubusercontent.com/10932478/173901513-b09b75f1-faba-4e02-a1ab-092908c9c438.png)

</br> Depois de clicar em 'Criar Nova Tarefa' , o usuário se depara com a página de cadastro, onde basta digitar uma tarefa ou ideia e clica em 'Criar' para armazenar a informação

# Tarefas Cadastradas
![image](https://user-images.githubusercontent.com/10932478/173901534-62bcff95-5130-4c1b-838e-235620b1115c.png)

</br> Surge então na tela inicial as informações passadas ao banco de dados: o nome da tarefa, se ela está concluída ou não, a data de criação e  a data da última atualização.

![image](https://user-images.githubusercontent.com/10932478/173901675-059ea84c-62b6-4c27-b8be-8d60a639194f.png)

</br> O usuário pode então adicionar inúmeras tarefas.

# Detalhes

![image](https://user-images.githubusercontent.com/10932478/173901791-9477bb44-c420-4f2a-8a01-781e42627567.png)
</br> Clicando em 'Detalhes' o usuário tem acesso as principais informações daquela tarefa

# Editar 

![image](https://user-images.githubusercontent.com/10932478/173901848-ec5c7d59-0e08-4487-a992-a625a701b2fc.png)
</br> Clicando em 'Editar' o usuário pode modificar as informações daquela tarefa, podendo adicionar mais informações ou marcar como 'Concluída''.

# Excluir
![image](https://user-images.githubusercontent.com/10932478/173901929-3d0f0b2e-a78b-4eb7-a667-ce28ccbd2e03.png)
</br> E por fim, o usuário pode também clicar em 'Excluir' Removendo assim todas as informações daquele tarefa do banco de dados.
