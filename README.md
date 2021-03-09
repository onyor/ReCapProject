### DB Migrations

dotnet ef migrations add InitialFirst -p .\src\DataAccess -o Concrete/EntityFramework/Migrations
dotnet ef migrations add InitialFirst -p .\src\DataAccess\ -s .\src\WebAPI\ -o Concrete/EntityFramework/Migrations


dotnet ef migrations remove -p .\src\DataAccess
dotnet ef migrations remove -p .\src\DataAccess\ -s .\src\WebAPI\

dotnet ef database update -p .\src\DataAccess
dotnet ef database update -p .\src\DataAccess\ -s .\src\WebAPI\

dotnet ef database drop -p .\src\DataAccess  (Runned)
dotnet ef database drop -p .\src\DataAccess\ -s .\src\WebAPI\

// revert applied migration
dotnet ef database update AddedXyzEntity -p .\src\DataAccess\ -s .\src\WebAPI\  (DESIRED point)