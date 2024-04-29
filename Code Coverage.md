## Code Coverage ##
> dotnet test --collect:"XPlat Code Coverage"

// not required: 
> dotnet test /p:CollectCoverage=true

> dotnet tool install -g dotnet-reportgenerator-globaltool

> reportgenerator -reports:"/Users/rodrigo.sedano/Desktop/Repos/WorkshopUnitTests/UnitTests/TestResults/aeb663f1-7405-4750-84bc-4c8c0f7af263/coverage.cobertura.xml" -targetdir:"coveragereport" -reporttypes:Html

reporttypes: SonarQube

