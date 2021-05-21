# entity-framework-core
Curso EF Core desenvolvedor.io


### Definindo cli global

dotnet tool install --global dotnet-ef --version 3.1.5

### Criar solution

dotnet new sln -n Curso

### Criar projeto

dotnet new console -n CursoEFCore -o Curso -f netcorapp3.1

### Adicionar projeto na solution

dotnet sln Curso.sln add .\Curso\CursoEFCore.csproj

### Instalar pacote Microsoft.EntityFrameworkCore.SqlServer

dotnet add .\Curso\CursoEFCore.csproj package Microsoft.EntityFrameworkCore.SqlServer --version 3.1.5

### Pacotes para migration

dotnet add .\Curso\CursoEFCore.csproj package Microsoft.EntityFrameworkCore.Design --version 3.1.5
dotnet add .\Curso\CursoEFCore.csproj package Microsoft.EntityFrameworkCore.Tools --version 3.1.5

### Gerar script sql de um migration

-p - Nome doprojeto
-o - Diretório de saída

 dotnet ef migrations script -p .\Curso\CursoEFCore.csproj -o .\Curso\PrimeiraMigracaoSQL.SQL

 ### Aplicando a migração
-v - Verbose exibe detalhes da execução


 dotnet ef database update -p .\Curso\CursoEFCore.csproj -v


 ### Scripts idempotentes

 É uma funcionalidade do EF que aplica validações do que já foi criado no banco e aplicar somente o que está faltando dessa forma é possível executar este script várias vezes sem nenhum problema diferente de executar o .sql diretamente que emitiria o erro dizendo que já foi criado as tabelas por exemplo.

-i - Idempotente

dotnet ef migrations script -p .\Curso\CursoEFCore.csproj -o .\Curso\Idempotente.SQL -i       

### Remover uma migração

dotnet ef migrations remove -p .\Curso\CursoEFCore.csproj


### Checar se existe migração pendente

using var db = new Data.ApplicationContext();
var existe = db.Database.GetPendingMigrations().Any();
if (existe) //Faz alguma coisa

### Rodar o projeto

dotnet run

### Pacote de logging

dotnet add package Microsoft.Extensions.Logging.Console -v 3.1.5