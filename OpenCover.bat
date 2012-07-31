tools\OpenCover.4.0.519\OpenCover.Console.exe -register:user -target:tools\NUnit.2.6.0.12054\lib\nunit-console.exe -targetargs:"/noshadow src\CiExample.Tests\bin\Debug\CiExample.Tests.dll" -filter:+[*]* -output:artifacts\opencover.xml
del TestResult.xml
tools\ReportGenerator.1.5.0.0\ReportGenerator.exe "artifacts\opencover.xml" "artifacts\reports\cobertura"