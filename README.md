<h1>Projeto Agendamento</h1>

<div align="center">
  <a href="#-como-rodar-o-projeto">Como Rodar o Projeto</a> | <a href="#-o-projeto">O Projeto</a> | <a href="#-tecnologias">Tecnologias</a>
</div>
<br>

# ⚙️ Como rodar o projeto?

- Certifique-se de que possui Visual Studio Community e SQL Server Management Studio instalados e configurando em sua máquina
  
- Abra o Visual Studio e selecione a opção Clonar um Repositório
  
- Insira o seguinte link em Local do repositório: https://github.com/pedrogchagas/Projeto-Agendamento.git
  
- Dentro do Projeto na pasta app.setting.json:
  
![image](https://github.com/pedrogchagas/Projeto-Agendamento/assets/81334548/12ccf0c5-28db-4cb0-af23-84ede7d05d92)

- O "Server=(local)\\SQLEXPRESS" especifica o nome do servidor e da instância do SQL Server que está sendo usado no meu caso o servidor é local e a instância é SQLEXPRESS
  
- Verifique no seu SSMS o servidor e a instância e altere devidamente 
  
- Depois dessa mudança salve e dê um build no projeto
  
- Abra a opção Ferramentas -> Gerenciador de Pacotes do NuGet -> Console do Gerenciador de Pacotes
  
- Com o console aberto digite: Update-Database

- Verifique se no seu SSMS se o banco foi criado com sucesso

- Se tudo estiver conforme foi dito, compile o projeto

- Aproveite!


# 👷🏻 O Projeto

# 🚀 Tecnologias
Estas são as tecnologias utilizadas no desenvolvimento do projeto:
- C# / Visual Studio Community
- ASP.NET Core
- ASP.NET Identity
- SQL Server
- HTML
- CSS
- JavaScript
- Bootstrap

________________________________________________________________________________________________________________________________________________________________________________
<div align="center">
  <p>Desenvolvido com 💙 Pedro Henrique Gomes Chagas</p> <br>
  <p>☎️ Entre em contato!<p> <br>
  <a display="flex" text-align="center" href="https://www.linkedin.com/in/pedrogchagas/" target="_blank"><img src="https://img.shields.io/badge/-LinkedIn-%230077B5?style=for-the-badge&logo=linkedin&logoColor=white" target="_blank"></a> 
</div>
