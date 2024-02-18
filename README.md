# Getting started
Install the below extension for Visual Studio:
* VS 2022 extension for project templates https://marketplace.visualstudio.com/items?itemName=FireGiant.FireGiantHeatWaveDev17

And optionally see the tutorial for inspiration: https://www.firegiant.com/docs/wix/tutorial/sprint3/testing-in-the-sandbox/

# setup in existing addin project
1. Create a new project using the `Class Library (.NET Framework)` template
2. Give it a name e.g. `CustomActions`
3. Add the following Nuget packages to this project:
   - WixToolset.Dtf.CustomAction
   - WixToolset.Dtf.WindowsInstaller
3. Rename the `Class1.cs` to `RevitActions.cs`
4. 

1. Create new project using the 'MSI Package (Wix v4)' template
2. Give it a name e.g. 'AddinInstaller'
3. Rename `ExampleComponents.wxs` file to `AddinComponents.wxs`
4. 
