### DB Migrations

dotnet ef migrations add IlkModel -p .\src\Infrastructure\ -s .\src\WebAPI\ -o Data/Migrations
dotnet ef migrations remove -p .\src\Infrastructure\ -s .\src\WebAPI\
dotnet ef database update -p .\src\Infrastructure\ -s .\src\WebAPI\
dotnet ef database drop -p .\src\Infrastructure\ -s .\src\WebAPI\

// revert applied migration
dotnet ef database update AddedXyzEntity -p .\src\Infrastructure\ -s .\src\WebAPI\  // DESIRED point



dotnet ef migrations add InitialFirst-p .\src\DataAccess\ -s .\src\WebAPI\ -o Data/Migrations