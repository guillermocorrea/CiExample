tools\doxygen-1.8.1.2\doxygen.exe tools\doxygen-1.8.1.2\config

<Exec IgnoreExitCode="true" Command="&quot;$(ProgramFiles32)\Simian\bin\simian-2.2.24.exe&quot; -formatter=xml:$(MSBuildProjectDirectory)\..\Build\Artifacts\simian.xml -language=cs -excludes=$(MSBuildProjectDirectory)\..\Product\Production\**\*.Designer.cs $(MSBuildProjectDirectory)\Production\**\*.cs" >
    </Exec>

tools\simian-2.3.33\bin\simian-2.3.33.exe -formatter=xml:artifacts\simian.xml -language=cs -includes=**/*.cs -excludes=**/*Test.cs