# PlaywrightWithSpecFlowDemo

## HTML report
To generate HTML-report, based on the latest test run:
```
livingdoc feature-folder .\PlaywrightWithSpecFlowDemo -t .\PlaywrightWithSpecFlowDemo\bin\Debug\net6.0\TestExecution.json
```

## Test execution

To run separate test cases by tag
```
dotnet test --filter Category=TAGNAME
```

To run tests in debug mode
```
$env:PWDEBUG=1
dotnet test
```

###### Headed mode
Playwright runs browsers in headless mode by default. To change this behavior, use headless: false as a launch option. You can also use the slowMo option to slow down execution and follow along while debugging.
```
// Chromium, Firefox, or Webkit
await using var browser = await playwright.Chromium.LaunchAsync(new()
{
    Headless = false,
    SlowMo = 100
});
```
