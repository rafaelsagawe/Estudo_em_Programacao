 ## Criação do projeto
 dotnet new mvc --auth Individual -o MeuToDoApp


 ## Iniciando o Projeto
 dotnet run

 ## Criação das models

 ## Adiconar o DBset em Data -> ApplicationDbContext.cs

 dotnet clean 
 dotnet build

 ## para geração dos codigos 
 dotnet add package microsoft.visualstudio.web.codegeneration.design

// não foi
dotnet-aspnet-codegenerator controller -name TodoController -dc ApplicationDbContext -m Todo --useDefaultLayout --useSqlite --referenceScriptLibraries