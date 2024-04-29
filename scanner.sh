rm -rf coverage
dotnet /Users/rodrigo.sedano/Desktop/SonarScanner/SonarScanner.MSBuild.dll begin /k:"rsedano_WorkshopUnitTests" /o:"rsedano" /d:sonar.login="c61f7eda888900ac689ffc04011dc5a1e163bbbd" /d:sonar.coverageReportPaths=SonarQube.xml
dotnet build --no-incremental
dotnet test --collect:"XPlat Code Coverage" --results-directory ./coverage 
reportgenerator -reports:"/Users/rodrigo.sedano/Desktop/Repos/WorkshopUnitTests/coverage/**/*.xml" -targetdir:"." -reporttypes:SonarQube
dotnet /Users/rodrigo.sedano/Desktop/SonarScanner/SonarScanner.MSBuild.dll end /d:sonar.login="c61f7eda888900ac689ffc04011dc5a1e163bbbd"