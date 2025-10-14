# Advanced Migration Topics

// 1. WebPort
// specifying the WebPort in the manifest is no longer supported
// from commit message:
//- Removed the 'electronWebPort' handling
//  When ASP.Net is launched first, then the information which port it
//  should use would be coming too late; anyway, there's no need for
//  letting the port number round-trip all the way through the manifest
//  file, loaded by main.js and then sent to dotnet.
//

if the asp web port needs to be specified manually, this can be by setting it via MSBuild like this:

  <ItemGroup>
    <AssemblyMetadata Include="AspNetHttpPort" Value="4000" />
  </ItemGroup>


## Custom ElectronHostHook Configuration

### TypeScript and Node.js Updates

**Update package.json:**
```json
{
  "devDependencies": {
    "eslint": "^9.37.0",
    "@types/node": "^22.18",
    "typescript": "^5.9.3"
  },
  "dependencies": {
    "archiver-utils": "^2.1.0",
    "socket.io": "^4.8.1",
    "exceljs": "^1.10.0"
  }
}
```

**Update Project File:**
```xml
<PackageReference Include="Microsoft.TypeScript.MSBuild" Version="5.9.3" />

<PropertyGroup>
  <TypeScriptModuleKind>commonjs</TypeScriptModuleKind>
  <TypeScriptUseNodeJS>true</TypeScriptUseNodeJS>
  <TypeScriptTSConfig>ElectronHostHook/tsconfig.json</TypeScriptTSConfig>
</PropertyGroup>

<ItemGroup>
  <Compile Remove="publish\**" />
  <Content Remove="publish\**" />
  <EmbeddedResource Remove="publish\**" />
  <None Remove="publish\**" />
  <TypeScriptCompile Remove="**\node_modules\**" />
</ItemGroup>
```

### Integration Benefits

- **Modern TypeScript** - Latest language features and better type checking
- **Updated Node.js Types** - Compatibility with Node.js 22.x APIs
- **ESLint Integration** - Better code quality and consistency
- **MSBuild Compilation** - Integrated with Visual Studio build process
