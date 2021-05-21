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