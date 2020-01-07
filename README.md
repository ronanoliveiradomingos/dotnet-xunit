dotnet new sln -o dotnet-xunit

dotnet new classlib -o PrimeService
ren .\PrimeService\Class1.cs PrimeService.cs

dotnet sln add ./PrimeService/PrimeService.csproj

dotnet new xunit -o PrimeService.Tests

dotnet add ./PrimeService.Tests/PrimeService.Tests.csproj reference ./PrimeService/PrimeService.csproj
dotnet sln add ./PrimeService.Tests/PrimeService.Tests.csproj

dotnet test