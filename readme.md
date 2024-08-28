#### Comando usado para criar o projeto 
 **** .Net Core MVC com SQLite **** 
```
dotnet new mvc --no-https
```

#### Rodar o projeto
```
dotnet run
```
 ||
```
dotnet watch
```

#### Dependencias
* Site Oficial
```
https://www.nuget.org/
```

* SQLite - Microsoft.EntityFrameworkCore.Sqlite.Core 
```
dotnet add package Microsoft.EntityFrameworkCore.Sqlite.Core --version 9.0.0-preview.7.24405.3
```

* Design - Microsoft.EntityFrameworkCore.Design 
```
dotnet add package Microsoft.EntityFrameworkCore.Design --version 9.0.0-preview.7.24405.3
```
#### Comando migrations
dotnet ef migrations add CreateTodoTable
dotnet ef database update


#### Ref. 1:23
```
https://www.youtube.com/watch?v=aYgAb5O_QXg
```

* Bootstrap Icons
```
https://icons.getbootstrap.com/
```

* Bootstrap CDN
```
<link rel="stylesheet" href="https://cdn.jsdelivr.net/npm/bootstrap-icons@1.11.3/font/bootstrap-icons.min.css">
```

#### Soluções:
* instalar no terminal
```
dotnet tool install --global dotnet-ef
```

* path variavel
```
%USERPROFILE%\.dotnet\tools
```

* link da solução
```
https://pt.stackoverflow.com/questions/510984/n%C3%A3o-consigo-fazer-conex%C3%A3o-com-banco-de-dados-no-entity-framework
```
* error MSB1011
```
dotnet watch error MSB1011: Especifique o arquivo de solução ou de projeto a usar porque esta pasta contém mais de
```
* solução renomear o arquivo .generated.sln para o nomeProject.sln