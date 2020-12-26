1. If you want changed browser for test you need to choose .runsettings file in VS test menu.
2. You can use console comand to start file .runsettings 
For example: dotnet test -s Name_Of_RunSettingsFile
3. If you want choose paramiters from console. You need use PowerShell and send peremiters in it.
For exemple: dotnet test -- 'TestRunParameters.Parameter(name=\\\"browser\\\", value=\\\"Firefox\\\")'