# PlaywrightWithSpecFlowDemo

To generate HTML-report, based on the latest test run:
```
livingdoc feature-folder .\PlaywrightWithSpecFlowDemo -t .\PlaywrightWithSpecFlowDemo\bin\Debug\net6.0\TestExecution.json
```

To run separate test cases by tag
```
dotnet test --filter Category=TAGNAME
```

To run tests in debug mode
```
$env:PWDEBUG=1
dotnet test
```
