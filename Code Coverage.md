## Code Coverage ##
> dotnet test --collect:"XPlat Code Coverage"

// not required: 
> dotnet test /p:CollectCoverage=true

> dotnet tool install -g dotnet-reportgenerator-globaltool

> reportgenerator -reports:"/Users/rodrigo.sedano/Desktop/Repos/WorkshopUnitTests/UnitTests/TestResults/27cbded9-a0a7-4335-8507-862fab888d55/coverage.cobertura.xml" -targetdir:"coveragereport" -reporttypes:Html

reporttypes: SonarQube