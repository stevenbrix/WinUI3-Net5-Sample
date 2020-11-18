# WinUI3 .NET5 Sample

This repository contains a sample WinUI3 app that builds using .NET5. With a simple change of one project property in the .csproj,
the application can either be launched in a UWP or Win32 context.

In the WinUI3-NET5-Sample.csproj, is the following:

```xml
    <!-- Set this to 'false' if you want your app to launch as a Win32 application -->
    <WindowsAppContainer>true</WindowsAppContainer>
```

You can use this property to toggle between the application running as a packaged UWP application,
or a packaged Win32 application.

| WindowsAppContainer| App type |
|        :-:         |    :-:   |
|  `true`            | UWP      |
|  `false`           | Win32    |
|   Not defined      | Win32    |

## Known Issues

- When you switch the value of `WindowsAppContainer` you need to do a full rebuild.
   - Otherwise you may see a `System.Runtime.InteropServices.COMException`
- You must F5 the packaging project for either Win32 or UWP apps to work properly