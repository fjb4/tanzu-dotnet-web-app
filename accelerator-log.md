# Accelerator Log

## Options
```json
{
  "database" : "postgresql",
  "projectName" : "tanzu-dotnet-web-app",
  "repositoryPrefix" : "dev.local",
  "welcomeMessage" : "Greetings from .NET Beyond + Tanzu Application Platform!"
}
```
## Log
```
┏ engine (Chain)
┃  Info Running Chain(Combo, UniquePath)
┃ ┏ engine.transformations[0] (Combo)
┃ ┃  Info Combo running as Chain(Merge(merge), UniquePath(UseLast))
┃ ┃ engine.transformations[0].merge (Chain)
┃ ┃  Info Running Chain(Merge, UniquePath)
┃ ┃ ┏ engine.transformations[0].merge.transformations[0] (Merge)
┃ ┃ ┃  Info Running Merge(Combo, Combo, Combo, Combo, Combo)
┃ ┃ ┃ ┏ engine.transformations[0].merge.transformations[0].sources[0] (Combo)
┃ ┃ ┃ ┃  Info Combo running as Chain(Include, Exclude)
┃ ┃ ┃ ┃ engine.transformations[0].merge.transformations[0].sources[0].<combo> (Chain)
┃ ┃ ┃ ┃  Info Running Chain(Include, Exclude)
┃ ┃ ┃ ┃ ┏ engine.transformations[0].merge.transformations[0].sources[0].<combo>.transformations[0] (Include)
┃ ┃ ┃ ┃ ┃  Info Will include [**/*]
┃ ┃ ┃ ┃ ┃ Debug .gitignore matched [**/*] -> included
┃ ┃ ┃ ┃ ┃ Debug README.md matched [**/*] -> included
┃ ┃ ┃ ┃ ┃ Debug Tiltfile matched [**/*] -> included
┃ ┃ ┃ ┃ ┃ Debug catalog/catalog-info.yaml matched [**/*] -> included
┃ ┃ ┃ ┃ ┃ Debug config/workload.yaml matched [**/*] -> included
┃ ┃ ┃ ┃ ┃ Debug project.toml matched [**/*] -> included
┃ ┃ ┃ ┃ ┃ Debug src/Controllers/HomeController.cs matched [**/*] -> included
┃ ┃ ┃ ┃ ┃ Debug src/DotnetWeb.csproj matched [**/*] -> included
┃ ┃ ┃ ┃ ┃ Debug src/Models/ErrorViewModel.cs matched [**/*] -> included
┃ ┃ ┃ ┃ ┃ Debug src/Program.cs matched [**/*] -> included
┃ ┃ ┃ ┃ ┃ Debug src/Properties/launchSettings.json matched [**/*] -> included
┃ ┃ ┃ ┃ ┃ Debug src/Views/Home/Index.cshtml matched [**/*] -> included
┃ ┃ ┃ ┃ ┃ Debug src/Views/Home/Privacy.cshtml matched [**/*] -> included
┃ ┃ ┃ ┃ ┃ Debug src/Views/Shared/Error.cshtml matched [**/*] -> included
┃ ┃ ┃ ┃ ┃ Debug src/Views/Shared/_Layout.cshtml matched [**/*] -> included
┃ ┃ ┃ ┃ ┃ Debug src/Views/Shared/_Layout.cshtml.css matched [**/*] -> included
┃ ┃ ┃ ┃ ┃ Debug src/Views/Shared/_ValidationScriptsPartial.cshtml matched [**/*] -> included
┃ ┃ ┃ ┃ ┃ Debug src/Views/_ViewImports.cshtml matched [**/*] -> included
┃ ┃ ┃ ┃ ┃ Debug src/Views/_ViewStart.cshtml matched [**/*] -> included
┃ ┃ ┃ ┃ ┃ Debug src/appsettings.Development.json matched [**/*] -> included
┃ ┃ ┃ ┃ ┃ Debug src/appsettings.json matched [**/*] -> included
┃ ┃ ┃ ┃ ┃ Debug src/wwwroot/css/site.css matched [**/*] -> included
┃ ┃ ┃ ┃ ┃ Debug src/wwwroot/favicon.ico matched [**/*] -> included
┃ ┃ ┃ ┃ ┃ Debug src/wwwroot/js/site.js matched [**/*] -> included
┃ ┃ ┃ ┃ ┃ Debug src/wwwroot/lib/bootstrap/LICENSE matched [**/*] -> included
┃ ┃ ┃ ┃ ┃ Debug src/wwwroot/lib/bootstrap/dist/css/bootstrap-grid.css matched [**/*] -> included
┃ ┃ ┃ ┃ ┃ Debug src/wwwroot/lib/bootstrap/dist/css/bootstrap-grid.css.map matched [**/*] -> included
┃ ┃ ┃ ┃ ┃ Debug src/wwwroot/lib/bootstrap/dist/css/bootstrap-grid.min.css matched [**/*] -> included
┃ ┃ ┃ ┃ ┃ Debug src/wwwroot/lib/bootstrap/dist/css/bootstrap-grid.min.css.map matched [**/*] -> included
┃ ┃ ┃ ┃ ┃ Debug src/wwwroot/lib/bootstrap/dist/css/bootstrap-grid.rtl.css matched [**/*] -> included
┃ ┃ ┃ ┃ ┃ Debug src/wwwroot/lib/bootstrap/dist/css/bootstrap-grid.rtl.css.map matched [**/*] -> included
┃ ┃ ┃ ┃ ┃ Debug src/wwwroot/lib/bootstrap/dist/css/bootstrap-grid.rtl.min.css matched [**/*] -> included
┃ ┃ ┃ ┃ ┃ Debug src/wwwroot/lib/bootstrap/dist/css/bootstrap-grid.rtl.min.css.map matched [**/*] -> included
┃ ┃ ┃ ┃ ┃ Debug src/wwwroot/lib/bootstrap/dist/css/bootstrap-reboot.css matched [**/*] -> included
┃ ┃ ┃ ┃ ┃ Debug src/wwwroot/lib/bootstrap/dist/css/bootstrap-reboot.css.map matched [**/*] -> included
┃ ┃ ┃ ┃ ┃ Debug src/wwwroot/lib/bootstrap/dist/css/bootstrap-reboot.min.css matched [**/*] -> included
┃ ┃ ┃ ┃ ┃ Debug src/wwwroot/lib/bootstrap/dist/css/bootstrap-reboot.min.css.map matched [**/*] -> included
┃ ┃ ┃ ┃ ┃ Debug src/wwwroot/lib/bootstrap/dist/css/bootstrap-reboot.rtl.css matched [**/*] -> included
┃ ┃ ┃ ┃ ┃ Debug src/wwwroot/lib/bootstrap/dist/css/bootstrap-reboot.rtl.css.map matched [**/*] -> included
┃ ┃ ┃ ┃ ┃ Debug src/wwwroot/lib/bootstrap/dist/css/bootstrap-reboot.rtl.min.css matched [**/*] -> included
┃ ┃ ┃ ┃ ┃ Debug src/wwwroot/lib/bootstrap/dist/css/bootstrap-reboot.rtl.min.css.map matched [**/*] -> included
┃ ┃ ┃ ┃ ┃ Debug src/wwwroot/lib/bootstrap/dist/css/bootstrap-utilities.css matched [**/*] -> included
┃ ┃ ┃ ┃ ┃ Debug src/wwwroot/lib/bootstrap/dist/css/bootstrap-utilities.css.map matched [**/*] -> included
┃ ┃ ┃ ┃ ┃ Debug src/wwwroot/lib/bootstrap/dist/css/bootstrap-utilities.min.css matched [**/*] -> included
┃ ┃ ┃ ┃ ┃ Debug src/wwwroot/lib/bootstrap/dist/css/bootstrap-utilities.min.css.map matched [**/*] -> included
┃ ┃ ┃ ┃ ┃ Debug src/wwwroot/lib/bootstrap/dist/css/bootstrap-utilities.rtl.css matched [**/*] -> included
┃ ┃ ┃ ┃ ┃ Debug src/wwwroot/lib/bootstrap/dist/css/bootstrap-utilities.rtl.css.map matched [**/*] -> included
┃ ┃ ┃ ┃ ┃ Debug src/wwwroot/lib/bootstrap/dist/css/bootstrap-utilities.rtl.min.css matched [**/*] -> included
┃ ┃ ┃ ┃ ┃ Debug src/wwwroot/lib/bootstrap/dist/css/bootstrap-utilities.rtl.min.css.map matched [**/*] -> included
┃ ┃ ┃ ┃ ┃ Debug src/wwwroot/lib/bootstrap/dist/css/bootstrap.css matched [**/*] -> included
┃ ┃ ┃ ┃ ┃ Debug src/wwwroot/lib/bootstrap/dist/css/bootstrap.css.map matched [**/*] -> included
┃ ┃ ┃ ┃ ┃ Debug src/wwwroot/lib/bootstrap/dist/css/bootstrap.min.css matched [**/*] -> included
┃ ┃ ┃ ┃ ┃ Debug src/wwwroot/lib/bootstrap/dist/css/bootstrap.min.css.map matched [**/*] -> included
┃ ┃ ┃ ┃ ┃ Debug src/wwwroot/lib/bootstrap/dist/css/bootstrap.rtl.css matched [**/*] -> included
┃ ┃ ┃ ┃ ┃ Debug src/wwwroot/lib/bootstrap/dist/css/bootstrap.rtl.css.map matched [**/*] -> included
┃ ┃ ┃ ┃ ┃ Debug src/wwwroot/lib/bootstrap/dist/css/bootstrap.rtl.min.css matched [**/*] -> included
┃ ┃ ┃ ┃ ┃ Debug src/wwwroot/lib/bootstrap/dist/css/bootstrap.rtl.min.css.map matched [**/*] -> included
┃ ┃ ┃ ┃ ┃ Debug src/wwwroot/lib/bootstrap/dist/js/bootstrap.bundle.js matched [**/*] -> included
┃ ┃ ┃ ┃ ┃ Debug src/wwwroot/lib/bootstrap/dist/js/bootstrap.bundle.js.map matched [**/*] -> included
┃ ┃ ┃ ┃ ┃ Debug src/wwwroot/lib/bootstrap/dist/js/bootstrap.bundle.min.js matched [**/*] -> included
┃ ┃ ┃ ┃ ┃ Debug src/wwwroot/lib/bootstrap/dist/js/bootstrap.bundle.min.js.map matched [**/*] -> included
┃ ┃ ┃ ┃ ┃ Debug src/wwwroot/lib/bootstrap/dist/js/bootstrap.esm.js matched [**/*] -> included
┃ ┃ ┃ ┃ ┃ Debug src/wwwroot/lib/bootstrap/dist/js/bootstrap.esm.js.map matched [**/*] -> included
┃ ┃ ┃ ┃ ┃ Debug src/wwwroot/lib/bootstrap/dist/js/bootstrap.esm.min.js matched [**/*] -> included
┃ ┃ ┃ ┃ ┃ Debug src/wwwroot/lib/bootstrap/dist/js/bootstrap.esm.min.js.map matched [**/*] -> included
┃ ┃ ┃ ┃ ┃ Debug src/wwwroot/lib/bootstrap/dist/js/bootstrap.js matched [**/*] -> included
┃ ┃ ┃ ┃ ┃ Debug src/wwwroot/lib/bootstrap/dist/js/bootstrap.js.map matched [**/*] -> included
┃ ┃ ┃ ┃ ┃ Debug src/wwwroot/lib/bootstrap/dist/js/bootstrap.min.js matched [**/*] -> included
┃ ┃ ┃ ┃ ┃ Debug src/wwwroot/lib/bootstrap/dist/js/bootstrap.min.js.map matched [**/*] -> included
┃ ┃ ┃ ┃ ┃ Debug src/wwwroot/lib/jquery/LICENSE.txt matched [**/*] -> included
┃ ┃ ┃ ┃ ┃ Debug src/wwwroot/lib/jquery/dist/jquery.js matched [**/*] -> included
┃ ┃ ┃ ┃ ┃ Debug src/wwwroot/lib/jquery/dist/jquery.min.js matched [**/*] -> included
┃ ┃ ┃ ┃ ┃ Debug src/wwwroot/lib/jquery/dist/jquery.min.map matched [**/*] -> included
┃ ┃ ┃ ┃ ┃ Debug src/wwwroot/lib/jquery-validation/LICENSE.md matched [**/*] -> included
┃ ┃ ┃ ┃ ┃ Debug src/wwwroot/lib/jquery-validation/dist/additional-methods.js matched [**/*] -> included
┃ ┃ ┃ ┃ ┃ Debug src/wwwroot/lib/jquery-validation/dist/additional-methods.min.js matched [**/*] -> included
┃ ┃ ┃ ┃ ┃ Debug src/wwwroot/lib/jquery-validation/dist/jquery.validate.js matched [**/*] -> included
┃ ┃ ┃ ┃ ┃ Debug src/wwwroot/lib/jquery-validation/dist/jquery.validate.min.js matched [**/*] -> included
┃ ┃ ┃ ┃ ┃ Debug src/wwwroot/lib/jquery-validation-unobtrusive/LICENSE.txt matched [**/*] -> included
┃ ┃ ┃ ┃ ┃ Debug src/wwwroot/lib/jquery-validation-unobtrusive/jquery.validate.unobtrusive.js matched [**/*] -> included
┃ ┃ ┃ ┃ ┗ Debug src/wwwroot/lib/jquery-validation-unobtrusive/jquery.validate.unobtrusive.min.js matched [**/*] -> included
┃ ┃ ┃ ┃ ┏ engine.transformations[0].merge.transformations[0].sources[0].<combo>.transformations[1] (Exclude)
┃ ┃ ┃ ┃ ┃  Info Will exclude [config/*.yaml, Tiltfile, README.md, catalog/*.yaml]
┃ ┃ ┃ ┃ ┃ Debug .gitignore didn't match [config/*.yaml, Tiltfile, README.md, catalog/*.yaml] -> included
┃ ┃ ┃ ┃ ┃ Debug README.md matched [config/*.yaml, Tiltfile, README.md, catalog/*.yaml] -> excluded
┃ ┃ ┃ ┃ ┃ Debug Tiltfile matched [config/*.yaml, Tiltfile, README.md, catalog/*.yaml] -> excluded
┃ ┃ ┃ ┃ ┃ Debug catalog/catalog-info.yaml matched [config/*.yaml, Tiltfile, README.md, catalog/*.yaml] -> excluded
┃ ┃ ┃ ┃ ┃ Debug config/workload.yaml matched [config/*.yaml, Tiltfile, README.md, catalog/*.yaml] -> excluded
┃ ┃ ┃ ┃ ┃ Debug project.toml didn't match [config/*.yaml, Tiltfile, README.md, catalog/*.yaml] -> included
┃ ┃ ┃ ┃ ┃ Debug src/Controllers/HomeController.cs didn't match [config/*.yaml, Tiltfile, README.md, catalog/*.yaml] -> included
┃ ┃ ┃ ┃ ┃ Debug src/DotnetWeb.csproj didn't match [config/*.yaml, Tiltfile, README.md, catalog/*.yaml] -> included
┃ ┃ ┃ ┃ ┃ Debug src/Models/ErrorViewModel.cs didn't match [config/*.yaml, Tiltfile, README.md, catalog/*.yaml] -> included
┃ ┃ ┃ ┃ ┃ Debug src/Program.cs didn't match [config/*.yaml, Tiltfile, README.md, catalog/*.yaml] -> included
┃ ┃ ┃ ┃ ┃ Debug src/Properties/launchSettings.json didn't match [config/*.yaml, Tiltfile, README.md, catalog/*.yaml] -> included
┃ ┃ ┃ ┃ ┃ Debug src/Views/Home/Index.cshtml didn't match [config/*.yaml, Tiltfile, README.md, catalog/*.yaml] -> included
┃ ┃ ┃ ┃ ┃ Debug src/Views/Home/Privacy.cshtml didn't match [config/*.yaml, Tiltfile, README.md, catalog/*.yaml] -> included
┃ ┃ ┃ ┃ ┃ Debug src/Views/Shared/Error.cshtml didn't match [config/*.yaml, Tiltfile, README.md, catalog/*.yaml] -> included
┃ ┃ ┃ ┃ ┃ Debug src/Views/Shared/_Layout.cshtml didn't match [config/*.yaml, Tiltfile, README.md, catalog/*.yaml] -> included
┃ ┃ ┃ ┃ ┃ Debug src/Views/Shared/_Layout.cshtml.css didn't match [config/*.yaml, Tiltfile, README.md, catalog/*.yaml] -> included
┃ ┃ ┃ ┃ ┃ Debug src/Views/Shared/_ValidationScriptsPartial.cshtml didn't match [config/*.yaml, Tiltfile, README.md, catalog/*.yaml] -> included
┃ ┃ ┃ ┃ ┃ Debug src/Views/_ViewImports.cshtml didn't match [config/*.yaml, Tiltfile, README.md, catalog/*.yaml] -> included
┃ ┃ ┃ ┃ ┃ Debug src/Views/_ViewStart.cshtml didn't match [config/*.yaml, Tiltfile, README.md, catalog/*.yaml] -> included
┃ ┃ ┃ ┃ ┃ Debug src/appsettings.Development.json didn't match [config/*.yaml, Tiltfile, README.md, catalog/*.yaml] -> included
┃ ┃ ┃ ┃ ┃ Debug src/appsettings.json didn't match [config/*.yaml, Tiltfile, README.md, catalog/*.yaml] -> included
┃ ┃ ┃ ┃ ┃ Debug src/wwwroot/css/site.css didn't match [config/*.yaml, Tiltfile, README.md, catalog/*.yaml] -> included
┃ ┃ ┃ ┃ ┃ Debug src/wwwroot/favicon.ico didn't match [config/*.yaml, Tiltfile, README.md, catalog/*.yaml] -> included
┃ ┃ ┃ ┃ ┃ Debug src/wwwroot/js/site.js didn't match [config/*.yaml, Tiltfile, README.md, catalog/*.yaml] -> included
┃ ┃ ┃ ┃ ┃ Debug src/wwwroot/lib/bootstrap/LICENSE didn't match [config/*.yaml, Tiltfile, README.md, catalog/*.yaml] -> included
┃ ┃ ┃ ┃ ┃ Debug src/wwwroot/lib/bootstrap/dist/css/bootstrap-grid.css didn't match [config/*.yaml, Tiltfile, README.md, catalog/*.yaml] -> included
┃ ┃ ┃ ┃ ┃ Debug src/wwwroot/lib/bootstrap/dist/css/bootstrap-grid.css.map didn't match [config/*.yaml, Tiltfile, README.md, catalog/*.yaml] -> included
┃ ┃ ┃ ┃ ┃ Debug src/wwwroot/lib/bootstrap/dist/css/bootstrap-grid.min.css didn't match [config/*.yaml, Tiltfile, README.md, catalog/*.yaml] -> included
┃ ┃ ┃ ┃ ┃ Debug src/wwwroot/lib/bootstrap/dist/css/bootstrap-grid.min.css.map didn't match [config/*.yaml, Tiltfile, README.md, catalog/*.yaml] -> included
┃ ┃ ┃ ┃ ┃ Debug src/wwwroot/lib/bootstrap/dist/css/bootstrap-grid.rtl.css didn't match [config/*.yaml, Tiltfile, README.md, catalog/*.yaml] -> included
┃ ┃ ┃ ┃ ┃ Debug src/wwwroot/lib/bootstrap/dist/css/bootstrap-grid.rtl.css.map didn't match [config/*.yaml, Tiltfile, README.md, catalog/*.yaml] -> included
┃ ┃ ┃ ┃ ┃ Debug src/wwwroot/lib/bootstrap/dist/css/bootstrap-grid.rtl.min.css didn't match [config/*.yaml, Tiltfile, README.md, catalog/*.yaml] -> included
┃ ┃ ┃ ┃ ┃ Debug src/wwwroot/lib/bootstrap/dist/css/bootstrap-grid.rtl.min.css.map didn't match [config/*.yaml, Tiltfile, README.md, catalog/*.yaml] -> included
┃ ┃ ┃ ┃ ┃ Debug src/wwwroot/lib/bootstrap/dist/css/bootstrap-reboot.css didn't match [config/*.yaml, Tiltfile, README.md, catalog/*.yaml] -> included
┃ ┃ ┃ ┃ ┃ Debug src/wwwroot/lib/bootstrap/dist/css/bootstrap-reboot.css.map didn't match [config/*.yaml, Tiltfile, README.md, catalog/*.yaml] -> included
┃ ┃ ┃ ┃ ┃ Debug src/wwwroot/lib/bootstrap/dist/css/bootstrap-reboot.min.css didn't match [config/*.yaml, Tiltfile, README.md, catalog/*.yaml] -> included
┃ ┃ ┃ ┃ ┃ Debug src/wwwroot/lib/bootstrap/dist/css/bootstrap-reboot.min.css.map didn't match [config/*.yaml, Tiltfile, README.md, catalog/*.yaml] -> included
┃ ┃ ┃ ┃ ┃ Debug src/wwwroot/lib/bootstrap/dist/css/bootstrap-reboot.rtl.css didn't match [config/*.yaml, Tiltfile, README.md, catalog/*.yaml] -> included
┃ ┃ ┃ ┃ ┃ Debug src/wwwroot/lib/bootstrap/dist/css/bootstrap-reboot.rtl.css.map didn't match [config/*.yaml, Tiltfile, README.md, catalog/*.yaml] -> included
┃ ┃ ┃ ┃ ┃ Debug src/wwwroot/lib/bootstrap/dist/css/bootstrap-reboot.rtl.min.css didn't match [config/*.yaml, Tiltfile, README.md, catalog/*.yaml] -> included
┃ ┃ ┃ ┃ ┃ Debug src/wwwroot/lib/bootstrap/dist/css/bootstrap-reboot.rtl.min.css.map didn't match [config/*.yaml, Tiltfile, README.md, catalog/*.yaml] -> included
┃ ┃ ┃ ┃ ┃ Debug src/wwwroot/lib/bootstrap/dist/css/bootstrap-utilities.css didn't match [config/*.yaml, Tiltfile, README.md, catalog/*.yaml] -> included
┃ ┃ ┃ ┃ ┃ Debug src/wwwroot/lib/bootstrap/dist/css/bootstrap-utilities.css.map didn't match [config/*.yaml, Tiltfile, README.md, catalog/*.yaml] -> included
┃ ┃ ┃ ┃ ┃ Debug src/wwwroot/lib/bootstrap/dist/css/bootstrap-utilities.min.css didn't match [config/*.yaml, Tiltfile, README.md, catalog/*.yaml] -> included
┃ ┃ ┃ ┃ ┃ Debug src/wwwroot/lib/bootstrap/dist/css/bootstrap-utilities.min.css.map didn't match [config/*.yaml, Tiltfile, README.md, catalog/*.yaml] -> included
┃ ┃ ┃ ┃ ┃ Debug src/wwwroot/lib/bootstrap/dist/css/bootstrap-utilities.rtl.css didn't match [config/*.yaml, Tiltfile, README.md, catalog/*.yaml] -> included
┃ ┃ ┃ ┃ ┃ Debug src/wwwroot/lib/bootstrap/dist/css/bootstrap-utilities.rtl.css.map didn't match [config/*.yaml, Tiltfile, README.md, catalog/*.yaml] -> included
┃ ┃ ┃ ┃ ┃ Debug src/wwwroot/lib/bootstrap/dist/css/bootstrap-utilities.rtl.min.css didn't match [config/*.yaml, Tiltfile, README.md, catalog/*.yaml] -> included
┃ ┃ ┃ ┃ ┃ Debug src/wwwroot/lib/bootstrap/dist/css/bootstrap-utilities.rtl.min.css.map didn't match [config/*.yaml, Tiltfile, README.md, catalog/*.yaml] -> included
┃ ┃ ┃ ┃ ┃ Debug src/wwwroot/lib/bootstrap/dist/css/bootstrap.css didn't match [config/*.yaml, Tiltfile, README.md, catalog/*.yaml] -> included
┃ ┃ ┃ ┃ ┃ Debug src/wwwroot/lib/bootstrap/dist/css/bootstrap.css.map didn't match [config/*.yaml, Tiltfile, README.md, catalog/*.yaml] -> included
┃ ┃ ┃ ┃ ┃ Debug src/wwwroot/lib/bootstrap/dist/css/bootstrap.min.css didn't match [config/*.yaml, Tiltfile, README.md, catalog/*.yaml] -> included
┃ ┃ ┃ ┃ ┃ Debug src/wwwroot/lib/bootstrap/dist/css/bootstrap.min.css.map didn't match [config/*.yaml, Tiltfile, README.md, catalog/*.yaml] -> included
┃ ┃ ┃ ┃ ┃ Debug src/wwwroot/lib/bootstrap/dist/css/bootstrap.rtl.css didn't match [config/*.yaml, Tiltfile, README.md, catalog/*.yaml] -> included
┃ ┃ ┃ ┃ ┃ Debug src/wwwroot/lib/bootstrap/dist/css/bootstrap.rtl.css.map didn't match [config/*.yaml, Tiltfile, README.md, catalog/*.yaml] -> included
┃ ┃ ┃ ┃ ┃ Debug src/wwwroot/lib/bootstrap/dist/css/bootstrap.rtl.min.css didn't match [config/*.yaml, Tiltfile, README.md, catalog/*.yaml] -> included
┃ ┃ ┃ ┃ ┃ Debug src/wwwroot/lib/bootstrap/dist/css/bootstrap.rtl.min.css.map didn't match [config/*.yaml, Tiltfile, README.md, catalog/*.yaml] -> included
┃ ┃ ┃ ┃ ┃ Debug src/wwwroot/lib/bootstrap/dist/js/bootstrap.bundle.js didn't match [config/*.yaml, Tiltfile, README.md, catalog/*.yaml] -> included
┃ ┃ ┃ ┃ ┃ Debug src/wwwroot/lib/bootstrap/dist/js/bootstrap.bundle.js.map didn't match [config/*.yaml, Tiltfile, README.md, catalog/*.yaml] -> included
┃ ┃ ┃ ┃ ┃ Debug src/wwwroot/lib/bootstrap/dist/js/bootstrap.bundle.min.js didn't match [config/*.yaml, Tiltfile, README.md, catalog/*.yaml] -> included
┃ ┃ ┃ ┃ ┃ Debug src/wwwroot/lib/bootstrap/dist/js/bootstrap.bundle.min.js.map didn't match [config/*.yaml, Tiltfile, README.md, catalog/*.yaml] -> included
┃ ┃ ┃ ┃ ┃ Debug src/wwwroot/lib/bootstrap/dist/js/bootstrap.esm.js didn't match [config/*.yaml, Tiltfile, README.md, catalog/*.yaml] -> included
┃ ┃ ┃ ┃ ┃ Debug src/wwwroot/lib/bootstrap/dist/js/bootstrap.esm.js.map didn't match [config/*.yaml, Tiltfile, README.md, catalog/*.yaml] -> included
┃ ┃ ┃ ┃ ┃ Debug src/wwwroot/lib/bootstrap/dist/js/bootstrap.esm.min.js didn't match [config/*.yaml, Tiltfile, README.md, catalog/*.yaml] -> included
┃ ┃ ┃ ┃ ┃ Debug src/wwwroot/lib/bootstrap/dist/js/bootstrap.esm.min.js.map didn't match [config/*.yaml, Tiltfile, README.md, catalog/*.yaml] -> included
┃ ┃ ┃ ┃ ┃ Debug src/wwwroot/lib/bootstrap/dist/js/bootstrap.js didn't match [config/*.yaml, Tiltfile, README.md, catalog/*.yaml] -> included
┃ ┃ ┃ ┃ ┃ Debug src/wwwroot/lib/bootstrap/dist/js/bootstrap.js.map didn't match [config/*.yaml, Tiltfile, README.md, catalog/*.yaml] -> included
┃ ┃ ┃ ┃ ┃ Debug src/wwwroot/lib/bootstrap/dist/js/bootstrap.min.js didn't match [config/*.yaml, Tiltfile, README.md, catalog/*.yaml] -> included
┃ ┃ ┃ ┃ ┃ Debug src/wwwroot/lib/bootstrap/dist/js/bootstrap.min.js.map didn't match [config/*.yaml, Tiltfile, README.md, catalog/*.yaml] -> included
┃ ┃ ┃ ┃ ┃ Debug src/wwwroot/lib/jquery/LICENSE.txt didn't match [config/*.yaml, Tiltfile, README.md, catalog/*.yaml] -> included
┃ ┃ ┃ ┃ ┃ Debug src/wwwroot/lib/jquery/dist/jquery.js didn't match [config/*.yaml, Tiltfile, README.md, catalog/*.yaml] -> included
┃ ┃ ┃ ┃ ┃ Debug src/wwwroot/lib/jquery/dist/jquery.min.js didn't match [config/*.yaml, Tiltfile, README.md, catalog/*.yaml] -> included
┃ ┃ ┃ ┃ ┃ Debug src/wwwroot/lib/jquery/dist/jquery.min.map didn't match [config/*.yaml, Tiltfile, README.md, catalog/*.yaml] -> included
┃ ┃ ┃ ┃ ┃ Debug src/wwwroot/lib/jquery-validation/LICENSE.md didn't match [config/*.yaml, Tiltfile, README.md, catalog/*.yaml] -> included
┃ ┃ ┃ ┃ ┃ Debug src/wwwroot/lib/jquery-validation/dist/additional-methods.js didn't match [config/*.yaml, Tiltfile, README.md, catalog/*.yaml] -> included
┃ ┃ ┃ ┃ ┃ Debug src/wwwroot/lib/jquery-validation/dist/additional-methods.min.js didn't match [config/*.yaml, Tiltfile, README.md, catalog/*.yaml] -> included
┃ ┃ ┃ ┃ ┃ Debug src/wwwroot/lib/jquery-validation/dist/jquery.validate.js didn't match [config/*.yaml, Tiltfile, README.md, catalog/*.yaml] -> included
┃ ┃ ┃ ┃ ┃ Debug src/wwwroot/lib/jquery-validation/dist/jquery.validate.min.js didn't match [config/*.yaml, Tiltfile, README.md, catalog/*.yaml] -> included
┃ ┃ ┃ ┃ ┃ Debug src/wwwroot/lib/jquery-validation-unobtrusive/LICENSE.txt didn't match [config/*.yaml, Tiltfile, README.md, catalog/*.yaml] -> included
┃ ┃ ┃ ┃ ┃ Debug src/wwwroot/lib/jquery-validation-unobtrusive/jquery.validate.unobtrusive.js didn't match [config/*.yaml, Tiltfile, README.md, catalog/*.yaml] -> included
┃ ┃ ┃ ┗ ┗ Debug src/wwwroot/lib/jquery-validation-unobtrusive/jquery.validate.unobtrusive.min.js didn't match [config/*.yaml, Tiltfile, README.md, catalog/*.yaml] -> included
┃ ┃ ┃ ┏ engine.transformations[0].merge.transformations[0].sources[1] (Combo)
┃ ┃ ┃ ┃  Info Combo running as Chain(Include, Chain(chain))
┃ ┃ ┃ ┃ engine.transformations[0].merge.transformations[0].sources[1].<combo> (Chain)
┃ ┃ ┃ ┃  Info Running Chain(Include, Chain)
┃ ┃ ┃ ┃ ┏ engine.transformations[0].merge.transformations[0].sources[1].<combo>.transformations[0] (Include)
┃ ┃ ┃ ┃ ┃  Info Will include [config/*.yaml, Tiltfile]
┃ ┃ ┃ ┃ ┃ Debug .gitignore didn't match [config/*.yaml, Tiltfile] -> excluded
┃ ┃ ┃ ┃ ┃ Debug README.md didn't match [config/*.yaml, Tiltfile] -> excluded
┃ ┃ ┃ ┃ ┃ Debug Tiltfile matched [config/*.yaml, Tiltfile] -> included
┃ ┃ ┃ ┃ ┃ Debug catalog/catalog-info.yaml didn't match [config/*.yaml, Tiltfile] -> excluded
┃ ┃ ┃ ┃ ┃ Debug config/workload.yaml matched [config/*.yaml, Tiltfile] -> included
┃ ┃ ┃ ┃ ┃ Debug project.toml didn't match [config/*.yaml, Tiltfile] -> excluded
┃ ┃ ┃ ┃ ┃ Debug src/Controllers/HomeController.cs didn't match [config/*.yaml, Tiltfile] -> excluded
┃ ┃ ┃ ┃ ┃ Debug src/DotnetWeb.csproj didn't match [config/*.yaml, Tiltfile] -> excluded
┃ ┃ ┃ ┃ ┃ Debug src/Models/ErrorViewModel.cs didn't match [config/*.yaml, Tiltfile] -> excluded
┃ ┃ ┃ ┃ ┃ Debug src/Program.cs didn't match [config/*.yaml, Tiltfile] -> excluded
┃ ┃ ┃ ┃ ┃ Debug src/Properties/launchSettings.json didn't match [config/*.yaml, Tiltfile] -> excluded
┃ ┃ ┃ ┃ ┃ Debug src/Views/Home/Index.cshtml didn't match [config/*.yaml, Tiltfile] -> excluded
┃ ┃ ┃ ┃ ┃ Debug src/Views/Home/Privacy.cshtml didn't match [config/*.yaml, Tiltfile] -> excluded
┃ ┃ ┃ ┃ ┃ Debug src/Views/Shared/Error.cshtml didn't match [config/*.yaml, Tiltfile] -> excluded
┃ ┃ ┃ ┃ ┃ Debug src/Views/Shared/_Layout.cshtml didn't match [config/*.yaml, Tiltfile] -> excluded
┃ ┃ ┃ ┃ ┃ Debug src/Views/Shared/_Layout.cshtml.css didn't match [config/*.yaml, Tiltfile] -> excluded
┃ ┃ ┃ ┃ ┃ Debug src/Views/Shared/_ValidationScriptsPartial.cshtml didn't match [config/*.yaml, Tiltfile] -> excluded
┃ ┃ ┃ ┃ ┃ Debug src/Views/_ViewImports.cshtml didn't match [config/*.yaml, Tiltfile] -> excluded
┃ ┃ ┃ ┃ ┃ Debug src/Views/_ViewStart.cshtml didn't match [config/*.yaml, Tiltfile] -> excluded
┃ ┃ ┃ ┃ ┃ Debug src/appsettings.Development.json didn't match [config/*.yaml, Tiltfile] -> excluded
┃ ┃ ┃ ┃ ┃ Debug src/appsettings.json didn't match [config/*.yaml, Tiltfile] -> excluded
┃ ┃ ┃ ┃ ┃ Debug src/wwwroot/css/site.css didn't match [config/*.yaml, Tiltfile] -> excluded
┃ ┃ ┃ ┃ ┃ Debug src/wwwroot/favicon.ico didn't match [config/*.yaml, Tiltfile] -> excluded
┃ ┃ ┃ ┃ ┃ Debug src/wwwroot/js/site.js didn't match [config/*.yaml, Tiltfile] -> excluded
┃ ┃ ┃ ┃ ┃ Debug src/wwwroot/lib/bootstrap/LICENSE didn't match [config/*.yaml, Tiltfile] -> excluded
┃ ┃ ┃ ┃ ┃ Debug src/wwwroot/lib/bootstrap/dist/css/bootstrap-grid.css didn't match [config/*.yaml, Tiltfile] -> excluded
┃ ┃ ┃ ┃ ┃ Debug src/wwwroot/lib/bootstrap/dist/css/bootstrap-grid.css.map didn't match [config/*.yaml, Tiltfile] -> excluded
┃ ┃ ┃ ┃ ┃ Debug src/wwwroot/lib/bootstrap/dist/css/bootstrap-grid.min.css didn't match [config/*.yaml, Tiltfile] -> excluded
┃ ┃ ┃ ┃ ┃ Debug src/wwwroot/lib/bootstrap/dist/css/bootstrap-grid.min.css.map didn't match [config/*.yaml, Tiltfile] -> excluded
┃ ┃ ┃ ┃ ┃ Debug src/wwwroot/lib/bootstrap/dist/css/bootstrap-grid.rtl.css didn't match [config/*.yaml, Tiltfile] -> excluded
┃ ┃ ┃ ┃ ┃ Debug src/wwwroot/lib/bootstrap/dist/css/bootstrap-grid.rtl.css.map didn't match [config/*.yaml, Tiltfile] -> excluded
┃ ┃ ┃ ┃ ┃ Debug src/wwwroot/lib/bootstrap/dist/css/bootstrap-grid.rtl.min.css didn't match [config/*.yaml, Tiltfile] -> excluded
┃ ┃ ┃ ┃ ┃ Debug src/wwwroot/lib/bootstrap/dist/css/bootstrap-grid.rtl.min.css.map didn't match [config/*.yaml, Tiltfile] -> excluded
┃ ┃ ┃ ┃ ┃ Debug src/wwwroot/lib/bootstrap/dist/css/bootstrap-reboot.css didn't match [config/*.yaml, Tiltfile] -> excluded
┃ ┃ ┃ ┃ ┃ Debug src/wwwroot/lib/bootstrap/dist/css/bootstrap-reboot.css.map didn't match [config/*.yaml, Tiltfile] -> excluded
┃ ┃ ┃ ┃ ┃ Debug src/wwwroot/lib/bootstrap/dist/css/bootstrap-reboot.min.css didn't match [config/*.yaml, Tiltfile] -> excluded
┃ ┃ ┃ ┃ ┃ Debug src/wwwroot/lib/bootstrap/dist/css/bootstrap-reboot.min.css.map didn't match [config/*.yaml, Tiltfile] -> excluded
┃ ┃ ┃ ┃ ┃ Debug src/wwwroot/lib/bootstrap/dist/css/bootstrap-reboot.rtl.css didn't match [config/*.yaml, Tiltfile] -> excluded
┃ ┃ ┃ ┃ ┃ Debug src/wwwroot/lib/bootstrap/dist/css/bootstrap-reboot.rtl.css.map didn't match [config/*.yaml, Tiltfile] -> excluded
┃ ┃ ┃ ┃ ┃ Debug src/wwwroot/lib/bootstrap/dist/css/bootstrap-reboot.rtl.min.css didn't match [config/*.yaml, Tiltfile] -> excluded
┃ ┃ ┃ ┃ ┃ Debug src/wwwroot/lib/bootstrap/dist/css/bootstrap-reboot.rtl.min.css.map didn't match [config/*.yaml, Tiltfile] -> excluded
┃ ┃ ┃ ┃ ┃ Debug src/wwwroot/lib/bootstrap/dist/css/bootstrap-utilities.css didn't match [config/*.yaml, Tiltfile] -> excluded
┃ ┃ ┃ ┃ ┃ Debug src/wwwroot/lib/bootstrap/dist/css/bootstrap-utilities.css.map didn't match [config/*.yaml, Tiltfile] -> excluded
┃ ┃ ┃ ┃ ┃ Debug src/wwwroot/lib/bootstrap/dist/css/bootstrap-utilities.min.css didn't match [config/*.yaml, Tiltfile] -> excluded
┃ ┃ ┃ ┃ ┃ Debug src/wwwroot/lib/bootstrap/dist/css/bootstrap-utilities.min.css.map didn't match [config/*.yaml, Tiltfile] -> excluded
┃ ┃ ┃ ┃ ┃ Debug src/wwwroot/lib/bootstrap/dist/css/bootstrap-utilities.rtl.css didn't match [config/*.yaml, Tiltfile] -> excluded
┃ ┃ ┃ ┃ ┃ Debug src/wwwroot/lib/bootstrap/dist/css/bootstrap-utilities.rtl.css.map didn't match [config/*.yaml, Tiltfile] -> excluded
┃ ┃ ┃ ┃ ┃ Debug src/wwwroot/lib/bootstrap/dist/css/bootstrap-utilities.rtl.min.css didn't match [config/*.yaml, Tiltfile] -> excluded
┃ ┃ ┃ ┃ ┃ Debug src/wwwroot/lib/bootstrap/dist/css/bootstrap-utilities.rtl.min.css.map didn't match [config/*.yaml, Tiltfile] -> excluded
┃ ┃ ┃ ┃ ┃ Debug src/wwwroot/lib/bootstrap/dist/css/bootstrap.css didn't match [config/*.yaml, Tiltfile] -> excluded
┃ ┃ ┃ ┃ ┃ Debug src/wwwroot/lib/bootstrap/dist/css/bootstrap.css.map didn't match [config/*.yaml, Tiltfile] -> excluded
┃ ┃ ┃ ┃ ┃ Debug src/wwwroot/lib/bootstrap/dist/css/bootstrap.min.css didn't match [config/*.yaml, Tiltfile] -> excluded
┃ ┃ ┃ ┃ ┃ Debug src/wwwroot/lib/bootstrap/dist/css/bootstrap.min.css.map didn't match [config/*.yaml, Tiltfile] -> excluded
┃ ┃ ┃ ┃ ┃ Debug src/wwwroot/lib/bootstrap/dist/css/bootstrap.rtl.css didn't match [config/*.yaml, Tiltfile] -> excluded
┃ ┃ ┃ ┃ ┃ Debug src/wwwroot/lib/bootstrap/dist/css/bootstrap.rtl.css.map didn't match [config/*.yaml, Tiltfile] -> excluded
┃ ┃ ┃ ┃ ┃ Debug src/wwwroot/lib/bootstrap/dist/css/bootstrap.rtl.min.css didn't match [config/*.yaml, Tiltfile] -> excluded
┃ ┃ ┃ ┃ ┃ Debug src/wwwroot/lib/bootstrap/dist/css/bootstrap.rtl.min.css.map didn't match [config/*.yaml, Tiltfile] -> excluded
┃ ┃ ┃ ┃ ┃ Debug src/wwwroot/lib/bootstrap/dist/js/bootstrap.bundle.js didn't match [config/*.yaml, Tiltfile] -> excluded
┃ ┃ ┃ ┃ ┃ Debug src/wwwroot/lib/bootstrap/dist/js/bootstrap.bundle.js.map didn't match [config/*.yaml, Tiltfile] -> excluded
┃ ┃ ┃ ┃ ┃ Debug src/wwwroot/lib/bootstrap/dist/js/bootstrap.bundle.min.js didn't match [config/*.yaml, Tiltfile] -> excluded
┃ ┃ ┃ ┃ ┃ Debug src/wwwroot/lib/bootstrap/dist/js/bootstrap.bundle.min.js.map didn't match [config/*.yaml, Tiltfile] -> excluded
┃ ┃ ┃ ┃ ┃ Debug src/wwwroot/lib/bootstrap/dist/js/bootstrap.esm.js didn't match [config/*.yaml, Tiltfile] -> excluded
┃ ┃ ┃ ┃ ┃ Debug src/wwwroot/lib/bootstrap/dist/js/bootstrap.esm.js.map didn't match [config/*.yaml, Tiltfile] -> excluded
┃ ┃ ┃ ┃ ┃ Debug src/wwwroot/lib/bootstrap/dist/js/bootstrap.esm.min.js didn't match [config/*.yaml, Tiltfile] -> excluded
┃ ┃ ┃ ┃ ┃ Debug src/wwwroot/lib/bootstrap/dist/js/bootstrap.esm.min.js.map didn't match [config/*.yaml, Tiltfile] -> excluded
┃ ┃ ┃ ┃ ┃ Debug src/wwwroot/lib/bootstrap/dist/js/bootstrap.js didn't match [config/*.yaml, Tiltfile] -> excluded
┃ ┃ ┃ ┃ ┃ Debug src/wwwroot/lib/bootstrap/dist/js/bootstrap.js.map didn't match [config/*.yaml, Tiltfile] -> excluded
┃ ┃ ┃ ┃ ┃ Debug src/wwwroot/lib/bootstrap/dist/js/bootstrap.min.js didn't match [config/*.yaml, Tiltfile] -> excluded
┃ ┃ ┃ ┃ ┃ Debug src/wwwroot/lib/bootstrap/dist/js/bootstrap.min.js.map didn't match [config/*.yaml, Tiltfile] -> excluded
┃ ┃ ┃ ┃ ┃ Debug src/wwwroot/lib/jquery/LICENSE.txt didn't match [config/*.yaml, Tiltfile] -> excluded
┃ ┃ ┃ ┃ ┃ Debug src/wwwroot/lib/jquery/dist/jquery.js didn't match [config/*.yaml, Tiltfile] -> excluded
┃ ┃ ┃ ┃ ┃ Debug src/wwwroot/lib/jquery/dist/jquery.min.js didn't match [config/*.yaml, Tiltfile] -> excluded
┃ ┃ ┃ ┃ ┃ Debug src/wwwroot/lib/jquery/dist/jquery.min.map didn't match [config/*.yaml, Tiltfile] -> excluded
┃ ┃ ┃ ┃ ┃ Debug src/wwwroot/lib/jquery-validation/LICENSE.md didn't match [config/*.yaml, Tiltfile] -> excluded
┃ ┃ ┃ ┃ ┃ Debug src/wwwroot/lib/jquery-validation/dist/additional-methods.js didn't match [config/*.yaml, Tiltfile] -> excluded
┃ ┃ ┃ ┃ ┃ Debug src/wwwroot/lib/jquery-validation/dist/additional-methods.min.js didn't match [config/*.yaml, Tiltfile] -> excluded
┃ ┃ ┃ ┃ ┃ Debug src/wwwroot/lib/jquery-validation/dist/jquery.validate.js didn't match [config/*.yaml, Tiltfile] -> excluded
┃ ┃ ┃ ┃ ┃ Debug src/wwwroot/lib/jquery-validation/dist/jquery.validate.min.js didn't match [config/*.yaml, Tiltfile] -> excluded
┃ ┃ ┃ ┃ ┃ Debug src/wwwroot/lib/jquery-validation-unobtrusive/LICENSE.txt didn't match [config/*.yaml, Tiltfile] -> excluded
┃ ┃ ┃ ┃ ┃ Debug src/wwwroot/lib/jquery-validation-unobtrusive/jquery.validate.unobtrusive.js didn't match [config/*.yaml, Tiltfile] -> excluded
┃ ┃ ┃ ┃ ┗ Debug src/wwwroot/lib/jquery-validation-unobtrusive/jquery.validate.unobtrusive.min.js didn't match [config/*.yaml, Tiltfile] -> excluded
┃ ┃ ┃ ┃ ┏ engine.transformations[0].merge.transformations[0].sources[1].<combo>.transformations[1] (Chain)
┃ ┃ ┃ ┃ ┃  Info Running Chain(ReplaceText, ReplaceText)
┃ ┃ ┃ ┃ ┃ ┏ engine.transformations[0].merge.transformations[0].sources[1].<combo>.transformations[1].transformations[0] (ReplaceText)
┃ ┃ ┃ ┃ ┃ ┗  Info Will replace [tanzu-dotnet-web-app->tanzu-dotnet-web-app]
┃ ┃ ┃ ┃ ┃ ┏ engine.transformations[0].merge.transformations[0].sources[1].<combo>.transformations[1].transformations[1] (ReplaceText)
┃ ┃ ┃ ┗ ┗ ┗  Info Will replace [your-registry.io/project->dev.local]
┃ ┃ ┃ ┏ engine.transformations[0].merge.transformations[0].sources[2] (Combo)
┃ ┃ ┃ ┃  Info Combo running as Chain(Include, Chain(chain))
┃ ┃ ┃ ┃ engine.transformations[0].merge.transformations[0].sources[2].<combo> (Chain)
┃ ┃ ┃ ┃  Info Running Chain(Include, Chain)
┃ ┃ ┃ ┃ ┏ engine.transformations[0].merge.transformations[0].sources[2].<combo>.transformations[0] (Include)
┃ ┃ ┃ ┃ ┃  Info Will include [README.md]
┃ ┃ ┃ ┃ ┃ Debug .gitignore didn't match [README.md] -> excluded
┃ ┃ ┃ ┃ ┃ Debug README.md matched [README.md] -> included
┃ ┃ ┃ ┃ ┃ Debug Tiltfile didn't match [README.md] -> excluded
┃ ┃ ┃ ┃ ┃ Debug catalog/catalog-info.yaml didn't match [README.md] -> excluded
┃ ┃ ┃ ┃ ┃ Debug config/workload.yaml didn't match [README.md] -> excluded
┃ ┃ ┃ ┃ ┃ Debug project.toml didn't match [README.md] -> excluded
┃ ┃ ┃ ┃ ┃ Debug src/Controllers/HomeController.cs didn't match [README.md] -> excluded
┃ ┃ ┃ ┃ ┃ Debug src/DotnetWeb.csproj didn't match [README.md] -> excluded
┃ ┃ ┃ ┃ ┃ Debug src/Models/ErrorViewModel.cs didn't match [README.md] -> excluded
┃ ┃ ┃ ┃ ┃ Debug src/Program.cs didn't match [README.md] -> excluded
┃ ┃ ┃ ┃ ┃ Debug src/Properties/launchSettings.json didn't match [README.md] -> excluded
┃ ┃ ┃ ┃ ┃ Debug src/Views/Home/Index.cshtml didn't match [README.md] -> excluded
┃ ┃ ┃ ┃ ┃ Debug src/Views/Home/Privacy.cshtml didn't match [README.md] -> excluded
┃ ┃ ┃ ┃ ┃ Debug src/Views/Shared/Error.cshtml didn't match [README.md] -> excluded
┃ ┃ ┃ ┃ ┃ Debug src/Views/Shared/_Layout.cshtml didn't match [README.md] -> excluded
┃ ┃ ┃ ┃ ┃ Debug src/Views/Shared/_Layout.cshtml.css didn't match [README.md] -> excluded
┃ ┃ ┃ ┃ ┃ Debug src/Views/Shared/_ValidationScriptsPartial.cshtml didn't match [README.md] -> excluded
┃ ┃ ┃ ┃ ┃ Debug src/Views/_ViewImports.cshtml didn't match [README.md] -> excluded
┃ ┃ ┃ ┃ ┃ Debug src/Views/_ViewStart.cshtml didn't match [README.md] -> excluded
┃ ┃ ┃ ┃ ┃ Debug src/appsettings.Development.json didn't match [README.md] -> excluded
┃ ┃ ┃ ┃ ┃ Debug src/appsettings.json didn't match [README.md] -> excluded
┃ ┃ ┃ ┃ ┃ Debug src/wwwroot/css/site.css didn't match [README.md] -> excluded
┃ ┃ ┃ ┃ ┃ Debug src/wwwroot/favicon.ico didn't match [README.md] -> excluded
┃ ┃ ┃ ┃ ┃ Debug src/wwwroot/js/site.js didn't match [README.md] -> excluded
┃ ┃ ┃ ┃ ┃ Debug src/wwwroot/lib/bootstrap/LICENSE didn't match [README.md] -> excluded
┃ ┃ ┃ ┃ ┃ Debug src/wwwroot/lib/bootstrap/dist/css/bootstrap-grid.css didn't match [README.md] -> excluded
┃ ┃ ┃ ┃ ┃ Debug src/wwwroot/lib/bootstrap/dist/css/bootstrap-grid.css.map didn't match [README.md] -> excluded
┃ ┃ ┃ ┃ ┃ Debug src/wwwroot/lib/bootstrap/dist/css/bootstrap-grid.min.css didn't match [README.md] -> excluded
┃ ┃ ┃ ┃ ┃ Debug src/wwwroot/lib/bootstrap/dist/css/bootstrap-grid.min.css.map didn't match [README.md] -> excluded
┃ ┃ ┃ ┃ ┃ Debug src/wwwroot/lib/bootstrap/dist/css/bootstrap-grid.rtl.css didn't match [README.md] -> excluded
┃ ┃ ┃ ┃ ┃ Debug src/wwwroot/lib/bootstrap/dist/css/bootstrap-grid.rtl.css.map didn't match [README.md] -> excluded
┃ ┃ ┃ ┃ ┃ Debug src/wwwroot/lib/bootstrap/dist/css/bootstrap-grid.rtl.min.css didn't match [README.md] -> excluded
┃ ┃ ┃ ┃ ┃ Debug src/wwwroot/lib/bootstrap/dist/css/bootstrap-grid.rtl.min.css.map didn't match [README.md] -> excluded
┃ ┃ ┃ ┃ ┃ Debug src/wwwroot/lib/bootstrap/dist/css/bootstrap-reboot.css didn't match [README.md] -> excluded
┃ ┃ ┃ ┃ ┃ Debug src/wwwroot/lib/bootstrap/dist/css/bootstrap-reboot.css.map didn't match [README.md] -> excluded
┃ ┃ ┃ ┃ ┃ Debug src/wwwroot/lib/bootstrap/dist/css/bootstrap-reboot.min.css didn't match [README.md] -> excluded
┃ ┃ ┃ ┃ ┃ Debug src/wwwroot/lib/bootstrap/dist/css/bootstrap-reboot.min.css.map didn't match [README.md] -> excluded
┃ ┃ ┃ ┃ ┃ Debug src/wwwroot/lib/bootstrap/dist/css/bootstrap-reboot.rtl.css didn't match [README.md] -> excluded
┃ ┃ ┃ ┃ ┃ Debug src/wwwroot/lib/bootstrap/dist/css/bootstrap-reboot.rtl.css.map didn't match [README.md] -> excluded
┃ ┃ ┃ ┃ ┃ Debug src/wwwroot/lib/bootstrap/dist/css/bootstrap-reboot.rtl.min.css didn't match [README.md] -> excluded
┃ ┃ ┃ ┃ ┃ Debug src/wwwroot/lib/bootstrap/dist/css/bootstrap-reboot.rtl.min.css.map didn't match [README.md] -> excluded
┃ ┃ ┃ ┃ ┃ Debug src/wwwroot/lib/bootstrap/dist/css/bootstrap-utilities.css didn't match [README.md] -> excluded
┃ ┃ ┃ ┃ ┃ Debug src/wwwroot/lib/bootstrap/dist/css/bootstrap-utilities.css.map didn't match [README.md] -> excluded
┃ ┃ ┃ ┃ ┃ Debug src/wwwroot/lib/bootstrap/dist/css/bootstrap-utilities.min.css didn't match [README.md] -> excluded
┃ ┃ ┃ ┃ ┃ Debug src/wwwroot/lib/bootstrap/dist/css/bootstrap-utilities.min.css.map didn't match [README.md] -> excluded
┃ ┃ ┃ ┃ ┃ Debug src/wwwroot/lib/bootstrap/dist/css/bootstrap-utilities.rtl.css didn't match [README.md] -> excluded
┃ ┃ ┃ ┃ ┃ Debug src/wwwroot/lib/bootstrap/dist/css/bootstrap-utilities.rtl.css.map didn't match [README.md] -> excluded
┃ ┃ ┃ ┃ ┃ Debug src/wwwroot/lib/bootstrap/dist/css/bootstrap-utilities.rtl.min.css didn't match [README.md] -> excluded
┃ ┃ ┃ ┃ ┃ Debug src/wwwroot/lib/bootstrap/dist/css/bootstrap-utilities.rtl.min.css.map didn't match [README.md] -> excluded
┃ ┃ ┃ ┃ ┃ Debug src/wwwroot/lib/bootstrap/dist/css/bootstrap.css didn't match [README.md] -> excluded
┃ ┃ ┃ ┃ ┃ Debug src/wwwroot/lib/bootstrap/dist/css/bootstrap.css.map didn't match [README.md] -> excluded
┃ ┃ ┃ ┃ ┃ Debug src/wwwroot/lib/bootstrap/dist/css/bootstrap.min.css didn't match [README.md] -> excluded
┃ ┃ ┃ ┃ ┃ Debug src/wwwroot/lib/bootstrap/dist/css/bootstrap.min.css.map didn't match [README.md] -> excluded
┃ ┃ ┃ ┃ ┃ Debug src/wwwroot/lib/bootstrap/dist/css/bootstrap.rtl.css didn't match [README.md] -> excluded
┃ ┃ ┃ ┃ ┃ Debug src/wwwroot/lib/bootstrap/dist/css/bootstrap.rtl.css.map didn't match [README.md] -> excluded
┃ ┃ ┃ ┃ ┃ Debug src/wwwroot/lib/bootstrap/dist/css/bootstrap.rtl.min.css didn't match [README.md] -> excluded
┃ ┃ ┃ ┃ ┃ Debug src/wwwroot/lib/bootstrap/dist/css/bootstrap.rtl.min.css.map didn't match [README.md] -> excluded
┃ ┃ ┃ ┃ ┃ Debug src/wwwroot/lib/bootstrap/dist/js/bootstrap.bundle.js didn't match [README.md] -> excluded
┃ ┃ ┃ ┃ ┃ Debug src/wwwroot/lib/bootstrap/dist/js/bootstrap.bundle.js.map didn't match [README.md] -> excluded
┃ ┃ ┃ ┃ ┃ Debug src/wwwroot/lib/bootstrap/dist/js/bootstrap.bundle.min.js didn't match [README.md] -> excluded
┃ ┃ ┃ ┃ ┃ Debug src/wwwroot/lib/bootstrap/dist/js/bootstrap.bundle.min.js.map didn't match [README.md] -> excluded
┃ ┃ ┃ ┃ ┃ Debug src/wwwroot/lib/bootstrap/dist/js/bootstrap.esm.js didn't match [README.md] -> excluded
┃ ┃ ┃ ┃ ┃ Debug src/wwwroot/lib/bootstrap/dist/js/bootstrap.esm.js.map didn't match [README.md] -> excluded
┃ ┃ ┃ ┃ ┃ Debug src/wwwroot/lib/bootstrap/dist/js/bootstrap.esm.min.js didn't match [README.md] -> excluded
┃ ┃ ┃ ┃ ┃ Debug src/wwwroot/lib/bootstrap/dist/js/bootstrap.esm.min.js.map didn't match [README.md] -> excluded
┃ ┃ ┃ ┃ ┃ Debug src/wwwroot/lib/bootstrap/dist/js/bootstrap.js didn't match [README.md] -> excluded
┃ ┃ ┃ ┃ ┃ Debug src/wwwroot/lib/bootstrap/dist/js/bootstrap.js.map didn't match [README.md] -> excluded
┃ ┃ ┃ ┃ ┃ Debug src/wwwroot/lib/bootstrap/dist/js/bootstrap.min.js didn't match [README.md] -> excluded
┃ ┃ ┃ ┃ ┃ Debug src/wwwroot/lib/bootstrap/dist/js/bootstrap.min.js.map didn't match [README.md] -> excluded
┃ ┃ ┃ ┃ ┃ Debug src/wwwroot/lib/jquery/LICENSE.txt didn't match [README.md] -> excluded
┃ ┃ ┃ ┃ ┃ Debug src/wwwroot/lib/jquery/dist/jquery.js didn't match [README.md] -> excluded
┃ ┃ ┃ ┃ ┃ Debug src/wwwroot/lib/jquery/dist/jquery.min.js didn't match [README.md] -> excluded
┃ ┃ ┃ ┃ ┃ Debug src/wwwroot/lib/jquery/dist/jquery.min.map didn't match [README.md] -> excluded
┃ ┃ ┃ ┃ ┃ Debug src/wwwroot/lib/jquery-validation/LICENSE.md didn't match [README.md] -> excluded
┃ ┃ ┃ ┃ ┃ Debug src/wwwroot/lib/jquery-validation/dist/additional-methods.js didn't match [README.md] -> excluded
┃ ┃ ┃ ┃ ┃ Debug src/wwwroot/lib/jquery-validation/dist/additional-methods.min.js didn't match [README.md] -> excluded
┃ ┃ ┃ ┃ ┃ Debug src/wwwroot/lib/jquery-validation/dist/jquery.validate.js didn't match [README.md] -> excluded
┃ ┃ ┃ ┃ ┃ Debug src/wwwroot/lib/jquery-validation/dist/jquery.validate.min.js didn't match [README.md] -> excluded
┃ ┃ ┃ ┃ ┃ Debug src/wwwroot/lib/jquery-validation-unobtrusive/LICENSE.txt didn't match [README.md] -> excluded
┃ ┃ ┃ ┃ ┃ Debug src/wwwroot/lib/jquery-validation-unobtrusive/jquery.validate.unobtrusive.js didn't match [README.md] -> excluded
┃ ┃ ┃ ┃ ┗ Debug src/wwwroot/lib/jquery-validation-unobtrusive/jquery.validate.unobtrusive.min.js didn't match [README.md] -> excluded
┃ ┃ ┃ ┃ ┏ engine.transformations[0].merge.transformations[0].sources[2].<combo>.transformations[1] (Chain)
┃ ┃ ┃ ┃ ┃  Info Running Chain(ReplaceText)
┃ ┃ ┃ ┃ ┃ ┏ engine.transformations[0].merge.transformations[0].sources[2].<combo>.transformations[1].transformations[0] (ReplaceText)
┃ ┃ ┃ ┗ ┗ ┗  Info Will replace [tanzu-dotnet-web-app->tanzu-dotnet-web-app]
┃ ┃ ┃ ┏ engine.transformations[0].merge.transformations[0].sources[3] (Combo)
┃ ┃ ┃ ┃  Info Combo running as Chain(Include, Chain(chain))
┃ ┃ ┃ ┃ engine.transformations[0].merge.transformations[0].sources[3].<combo> (Chain)
┃ ┃ ┃ ┃  Info Running Chain(Include, Chain)
┃ ┃ ┃ ┃ ┏ engine.transformations[0].merge.transformations[0].sources[3].<combo>.transformations[0] (Include)
┃ ┃ ┃ ┃ ┃  Info Will include [catalog/*.yaml]
┃ ┃ ┃ ┃ ┃ Debug .gitignore didn't match [catalog/*.yaml] -> excluded
┃ ┃ ┃ ┃ ┃ Debug README.md didn't match [catalog/*.yaml] -> excluded
┃ ┃ ┃ ┃ ┃ Debug Tiltfile didn't match [catalog/*.yaml] -> excluded
┃ ┃ ┃ ┃ ┃ Debug catalog/catalog-info.yaml matched [catalog/*.yaml] -> included
┃ ┃ ┃ ┃ ┃ Debug config/workload.yaml didn't match [catalog/*.yaml] -> excluded
┃ ┃ ┃ ┃ ┃ Debug project.toml didn't match [catalog/*.yaml] -> excluded
┃ ┃ ┃ ┃ ┃ Debug src/Controllers/HomeController.cs didn't match [catalog/*.yaml] -> excluded
┃ ┃ ┃ ┃ ┃ Debug src/DotnetWeb.csproj didn't match [catalog/*.yaml] -> excluded
┃ ┃ ┃ ┃ ┃ Debug src/Models/ErrorViewModel.cs didn't match [catalog/*.yaml] -> excluded
┃ ┃ ┃ ┃ ┃ Debug src/Program.cs didn't match [catalog/*.yaml] -> excluded
┃ ┃ ┃ ┃ ┃ Debug src/Properties/launchSettings.json didn't match [catalog/*.yaml] -> excluded
┃ ┃ ┃ ┃ ┃ Debug src/Views/Home/Index.cshtml didn't match [catalog/*.yaml] -> excluded
┃ ┃ ┃ ┃ ┃ Debug src/Views/Home/Privacy.cshtml didn't match [catalog/*.yaml] -> excluded
┃ ┃ ┃ ┃ ┃ Debug src/Views/Shared/Error.cshtml didn't match [catalog/*.yaml] -> excluded
┃ ┃ ┃ ┃ ┃ Debug src/Views/Shared/_Layout.cshtml didn't match [catalog/*.yaml] -> excluded
┃ ┃ ┃ ┃ ┃ Debug src/Views/Shared/_Layout.cshtml.css didn't match [catalog/*.yaml] -> excluded
┃ ┃ ┃ ┃ ┃ Debug src/Views/Shared/_ValidationScriptsPartial.cshtml didn't match [catalog/*.yaml] -> excluded
┃ ┃ ┃ ┃ ┃ Debug src/Views/_ViewImports.cshtml didn't match [catalog/*.yaml] -> excluded
┃ ┃ ┃ ┃ ┃ Debug src/Views/_ViewStart.cshtml didn't match [catalog/*.yaml] -> excluded
┃ ┃ ┃ ┃ ┃ Debug src/appsettings.Development.json didn't match [catalog/*.yaml] -> excluded
┃ ┃ ┃ ┃ ┃ Debug src/appsettings.json didn't match [catalog/*.yaml] -> excluded
┃ ┃ ┃ ┃ ┃ Debug src/wwwroot/css/site.css didn't match [catalog/*.yaml] -> excluded
┃ ┃ ┃ ┃ ┃ Debug src/wwwroot/favicon.ico didn't match [catalog/*.yaml] -> excluded
┃ ┃ ┃ ┃ ┃ Debug src/wwwroot/js/site.js didn't match [catalog/*.yaml] -> excluded
┃ ┃ ┃ ┃ ┃ Debug src/wwwroot/lib/bootstrap/LICENSE didn't match [catalog/*.yaml] -> excluded
┃ ┃ ┃ ┃ ┃ Debug src/wwwroot/lib/bootstrap/dist/css/bootstrap-grid.css didn't match [catalog/*.yaml] -> excluded
┃ ┃ ┃ ┃ ┃ Debug src/wwwroot/lib/bootstrap/dist/css/bootstrap-grid.css.map didn't match [catalog/*.yaml] -> excluded
┃ ┃ ┃ ┃ ┃ Debug src/wwwroot/lib/bootstrap/dist/css/bootstrap-grid.min.css didn't match [catalog/*.yaml] -> excluded
┃ ┃ ┃ ┃ ┃ Debug src/wwwroot/lib/bootstrap/dist/css/bootstrap-grid.min.css.map didn't match [catalog/*.yaml] -> excluded
┃ ┃ ┃ ┃ ┃ Debug src/wwwroot/lib/bootstrap/dist/css/bootstrap-grid.rtl.css didn't match [catalog/*.yaml] -> excluded
┃ ┃ ┃ ┃ ┃ Debug src/wwwroot/lib/bootstrap/dist/css/bootstrap-grid.rtl.css.map didn't match [catalog/*.yaml] -> excluded
┃ ┃ ┃ ┃ ┃ Debug src/wwwroot/lib/bootstrap/dist/css/bootstrap-grid.rtl.min.css didn't match [catalog/*.yaml] -> excluded
┃ ┃ ┃ ┃ ┃ Debug src/wwwroot/lib/bootstrap/dist/css/bootstrap-grid.rtl.min.css.map didn't match [catalog/*.yaml] -> excluded
┃ ┃ ┃ ┃ ┃ Debug src/wwwroot/lib/bootstrap/dist/css/bootstrap-reboot.css didn't match [catalog/*.yaml] -> excluded
┃ ┃ ┃ ┃ ┃ Debug src/wwwroot/lib/bootstrap/dist/css/bootstrap-reboot.css.map didn't match [catalog/*.yaml] -> excluded
┃ ┃ ┃ ┃ ┃ Debug src/wwwroot/lib/bootstrap/dist/css/bootstrap-reboot.min.css didn't match [catalog/*.yaml] -> excluded
┃ ┃ ┃ ┃ ┃ Debug src/wwwroot/lib/bootstrap/dist/css/bootstrap-reboot.min.css.map didn't match [catalog/*.yaml] -> excluded
┃ ┃ ┃ ┃ ┃ Debug src/wwwroot/lib/bootstrap/dist/css/bootstrap-reboot.rtl.css didn't match [catalog/*.yaml] -> excluded
┃ ┃ ┃ ┃ ┃ Debug src/wwwroot/lib/bootstrap/dist/css/bootstrap-reboot.rtl.css.map didn't match [catalog/*.yaml] -> excluded
┃ ┃ ┃ ┃ ┃ Debug src/wwwroot/lib/bootstrap/dist/css/bootstrap-reboot.rtl.min.css didn't match [catalog/*.yaml] -> excluded
┃ ┃ ┃ ┃ ┃ Debug src/wwwroot/lib/bootstrap/dist/css/bootstrap-reboot.rtl.min.css.map didn't match [catalog/*.yaml] -> excluded
┃ ┃ ┃ ┃ ┃ Debug src/wwwroot/lib/bootstrap/dist/css/bootstrap-utilities.css didn't match [catalog/*.yaml] -> excluded
┃ ┃ ┃ ┃ ┃ Debug src/wwwroot/lib/bootstrap/dist/css/bootstrap-utilities.css.map didn't match [catalog/*.yaml] -> excluded
┃ ┃ ┃ ┃ ┃ Debug src/wwwroot/lib/bootstrap/dist/css/bootstrap-utilities.min.css didn't match [catalog/*.yaml] -> excluded
┃ ┃ ┃ ┃ ┃ Debug src/wwwroot/lib/bootstrap/dist/css/bootstrap-utilities.min.css.map didn't match [catalog/*.yaml] -> excluded
┃ ┃ ┃ ┃ ┃ Debug src/wwwroot/lib/bootstrap/dist/css/bootstrap-utilities.rtl.css didn't match [catalog/*.yaml] -> excluded
┃ ┃ ┃ ┃ ┃ Debug src/wwwroot/lib/bootstrap/dist/css/bootstrap-utilities.rtl.css.map didn't match [catalog/*.yaml] -> excluded
┃ ┃ ┃ ┃ ┃ Debug src/wwwroot/lib/bootstrap/dist/css/bootstrap-utilities.rtl.min.css didn't match [catalog/*.yaml] -> excluded
┃ ┃ ┃ ┃ ┃ Debug src/wwwroot/lib/bootstrap/dist/css/bootstrap-utilities.rtl.min.css.map didn't match [catalog/*.yaml] -> excluded
┃ ┃ ┃ ┃ ┃ Debug src/wwwroot/lib/bootstrap/dist/css/bootstrap.css didn't match [catalog/*.yaml] -> excluded
┃ ┃ ┃ ┃ ┃ Debug src/wwwroot/lib/bootstrap/dist/css/bootstrap.css.map didn't match [catalog/*.yaml] -> excluded
┃ ┃ ┃ ┃ ┃ Debug src/wwwroot/lib/bootstrap/dist/css/bootstrap.min.css didn't match [catalog/*.yaml] -> excluded
┃ ┃ ┃ ┃ ┃ Debug src/wwwroot/lib/bootstrap/dist/css/bootstrap.min.css.map didn't match [catalog/*.yaml] -> excluded
┃ ┃ ┃ ┃ ┃ Debug src/wwwroot/lib/bootstrap/dist/css/bootstrap.rtl.css didn't match [catalog/*.yaml] -> excluded
┃ ┃ ┃ ┃ ┃ Debug src/wwwroot/lib/bootstrap/dist/css/bootstrap.rtl.css.map didn't match [catalog/*.yaml] -> excluded
┃ ┃ ┃ ┃ ┃ Debug src/wwwroot/lib/bootstrap/dist/css/bootstrap.rtl.min.css didn't match [catalog/*.yaml] -> excluded
┃ ┃ ┃ ┃ ┃ Debug src/wwwroot/lib/bootstrap/dist/css/bootstrap.rtl.min.css.map didn't match [catalog/*.yaml] -> excluded
┃ ┃ ┃ ┃ ┃ Debug src/wwwroot/lib/bootstrap/dist/js/bootstrap.bundle.js didn't match [catalog/*.yaml] -> excluded
┃ ┃ ┃ ┃ ┃ Debug src/wwwroot/lib/bootstrap/dist/js/bootstrap.bundle.js.map didn't match [catalog/*.yaml] -> excluded
┃ ┃ ┃ ┃ ┃ Debug src/wwwroot/lib/bootstrap/dist/js/bootstrap.bundle.min.js didn't match [catalog/*.yaml] -> excluded
┃ ┃ ┃ ┃ ┃ Debug src/wwwroot/lib/bootstrap/dist/js/bootstrap.bundle.min.js.map didn't match [catalog/*.yaml] -> excluded
┃ ┃ ┃ ┃ ┃ Debug src/wwwroot/lib/bootstrap/dist/js/bootstrap.esm.js didn't match [catalog/*.yaml] -> excluded
┃ ┃ ┃ ┃ ┃ Debug src/wwwroot/lib/bootstrap/dist/js/bootstrap.esm.js.map didn't match [catalog/*.yaml] -> excluded
┃ ┃ ┃ ┃ ┃ Debug src/wwwroot/lib/bootstrap/dist/js/bootstrap.esm.min.js didn't match [catalog/*.yaml] -> excluded
┃ ┃ ┃ ┃ ┃ Debug src/wwwroot/lib/bootstrap/dist/js/bootstrap.esm.min.js.map didn't match [catalog/*.yaml] -> excluded
┃ ┃ ┃ ┃ ┃ Debug src/wwwroot/lib/bootstrap/dist/js/bootstrap.js didn't match [catalog/*.yaml] -> excluded
┃ ┃ ┃ ┃ ┃ Debug src/wwwroot/lib/bootstrap/dist/js/bootstrap.js.map didn't match [catalog/*.yaml] -> excluded
┃ ┃ ┃ ┃ ┃ Debug src/wwwroot/lib/bootstrap/dist/js/bootstrap.min.js didn't match [catalog/*.yaml] -> excluded
┃ ┃ ┃ ┃ ┃ Debug src/wwwroot/lib/bootstrap/dist/js/bootstrap.min.js.map didn't match [catalog/*.yaml] -> excluded
┃ ┃ ┃ ┃ ┃ Debug src/wwwroot/lib/jquery/LICENSE.txt didn't match [catalog/*.yaml] -> excluded
┃ ┃ ┃ ┃ ┃ Debug src/wwwroot/lib/jquery/dist/jquery.js didn't match [catalog/*.yaml] -> excluded
┃ ┃ ┃ ┃ ┃ Debug src/wwwroot/lib/jquery/dist/jquery.min.js didn't match [catalog/*.yaml] -> excluded
┃ ┃ ┃ ┃ ┃ Debug src/wwwroot/lib/jquery/dist/jquery.min.map didn't match [catalog/*.yaml] -> excluded
┃ ┃ ┃ ┃ ┃ Debug src/wwwroot/lib/jquery-validation/LICENSE.md didn't match [catalog/*.yaml] -> excluded
┃ ┃ ┃ ┃ ┃ Debug src/wwwroot/lib/jquery-validation/dist/additional-methods.js didn't match [catalog/*.yaml] -> excluded
┃ ┃ ┃ ┃ ┃ Debug src/wwwroot/lib/jquery-validation/dist/additional-methods.min.js didn't match [catalog/*.yaml] -> excluded
┃ ┃ ┃ ┃ ┃ Debug src/wwwroot/lib/jquery-validation/dist/jquery.validate.js didn't match [catalog/*.yaml] -> excluded
┃ ┃ ┃ ┃ ┃ Debug src/wwwroot/lib/jquery-validation/dist/jquery.validate.min.js didn't match [catalog/*.yaml] -> excluded
┃ ┃ ┃ ┃ ┃ Debug src/wwwroot/lib/jquery-validation-unobtrusive/LICENSE.txt didn't match [catalog/*.yaml] -> excluded
┃ ┃ ┃ ┃ ┃ Debug src/wwwroot/lib/jquery-validation-unobtrusive/jquery.validate.unobtrusive.js didn't match [catalog/*.yaml] -> excluded
┃ ┃ ┃ ┃ ┗ Debug src/wwwroot/lib/jquery-validation-unobtrusive/jquery.validate.unobtrusive.min.js didn't match [catalog/*.yaml] -> excluded
┃ ┃ ┃ ┃ ┏ engine.transformations[0].merge.transformations[0].sources[3].<combo>.transformations[1] (Chain)
┃ ┃ ┃ ┃ ┃  Info Running Chain(ReplaceText, RewritePath)
┃ ┃ ┃ ┃ ┃ ┏ engine.transformations[0].merge.transformations[0].sources[3].<combo>.transformations[1].transformations[0] (ReplaceText)
┃ ┃ ┃ ┃ ┃ ┗  Info Will replace [tanzu-dotnet-web-app->tanzu-dotnet-web-app]
┃ ┃ ┃ ┃ ┃ ┏ engine.transformations[0].merge.transformations[0].sources[3].<combo>.transformations[1].transformations[1] (RewritePath)
┃ ┃ ┃ ┗ ┗ ┗ Debug Path 'catalog/catalog-info.yaml' matched '^(?<folder>.*/)?(?<filename>([^/]+?|)(?=(?<ext>\.[^/.]*)?)$)' with groups {ext=.yaml, folder=catalog/, filename=catalog-info.yaml, g0=catalog/catalog-info.yaml, g1=catalog/, g2=catalog-info.yaml, g3=catalog-info.yaml, g4=.yaml} and was rewritten to 'catalog-info.yaml'
┃ ┃ ┃ ┏ engine.transformations[0].merge.transformations[0].sources[4] (Combo)
┃ ┃ ┃ ┃  Info Combo running as Chain(Include, Chain(chain))
┃ ┃ ┃ ┃ engine.transformations[0].merge.transformations[0].sources[4].<combo> (Chain)
┃ ┃ ┃ ┃  Info Running Chain(Include, Chain)
┃ ┃ ┃ ┃ ┏ engine.transformations[0].merge.transformations[0].sources[4].<combo>.transformations[0] (Include)
┃ ┃ ┃ ┃ ┃  Info Will include [src/Views/Home/Index.cshtml]
┃ ┃ ┃ ┃ ┃ Debug .gitignore didn't match [src/Views/Home/Index.cshtml] -> excluded
┃ ┃ ┃ ┃ ┃ Debug README.md didn't match [src/Views/Home/Index.cshtml] -> excluded
┃ ┃ ┃ ┃ ┃ Debug Tiltfile didn't match [src/Views/Home/Index.cshtml] -> excluded
┃ ┃ ┃ ┃ ┃ Debug catalog/catalog-info.yaml didn't match [src/Views/Home/Index.cshtml] -> excluded
┃ ┃ ┃ ┃ ┃ Debug config/workload.yaml didn't match [src/Views/Home/Index.cshtml] -> excluded
┃ ┃ ┃ ┃ ┃ Debug project.toml didn't match [src/Views/Home/Index.cshtml] -> excluded
┃ ┃ ┃ ┃ ┃ Debug src/Controllers/HomeController.cs didn't match [src/Views/Home/Index.cshtml] -> excluded
┃ ┃ ┃ ┃ ┃ Debug src/DotnetWeb.csproj didn't match [src/Views/Home/Index.cshtml] -> excluded
┃ ┃ ┃ ┃ ┃ Debug src/Models/ErrorViewModel.cs didn't match [src/Views/Home/Index.cshtml] -> excluded
┃ ┃ ┃ ┃ ┃ Debug src/Program.cs didn't match [src/Views/Home/Index.cshtml] -> excluded
┃ ┃ ┃ ┃ ┃ Debug src/Properties/launchSettings.json didn't match [src/Views/Home/Index.cshtml] -> excluded
┃ ┃ ┃ ┃ ┃ Debug src/Views/Home/Index.cshtml matched [src/Views/Home/Index.cshtml] -> included
┃ ┃ ┃ ┃ ┃ Debug src/Views/Home/Privacy.cshtml didn't match [src/Views/Home/Index.cshtml] -> excluded
┃ ┃ ┃ ┃ ┃ Debug src/Views/Shared/Error.cshtml didn't match [src/Views/Home/Index.cshtml] -> excluded
┃ ┃ ┃ ┃ ┃ Debug src/Views/Shared/_Layout.cshtml didn't match [src/Views/Home/Index.cshtml] -> excluded
┃ ┃ ┃ ┃ ┃ Debug src/Views/Shared/_Layout.cshtml.css didn't match [src/Views/Home/Index.cshtml] -> excluded
┃ ┃ ┃ ┃ ┃ Debug src/Views/Shared/_ValidationScriptsPartial.cshtml didn't match [src/Views/Home/Index.cshtml] -> excluded
┃ ┃ ┃ ┃ ┃ Debug src/Views/_ViewImports.cshtml didn't match [src/Views/Home/Index.cshtml] -> excluded
┃ ┃ ┃ ┃ ┃ Debug src/Views/_ViewStart.cshtml didn't match [src/Views/Home/Index.cshtml] -> excluded
┃ ┃ ┃ ┃ ┃ Debug src/appsettings.Development.json didn't match [src/Views/Home/Index.cshtml] -> excluded
┃ ┃ ┃ ┃ ┃ Debug src/appsettings.json didn't match [src/Views/Home/Index.cshtml] -> excluded
┃ ┃ ┃ ┃ ┃ Debug src/wwwroot/css/site.css didn't match [src/Views/Home/Index.cshtml] -> excluded
┃ ┃ ┃ ┃ ┃ Debug src/wwwroot/favicon.ico didn't match [src/Views/Home/Index.cshtml] -> excluded
┃ ┃ ┃ ┃ ┃ Debug src/wwwroot/js/site.js didn't match [src/Views/Home/Index.cshtml] -> excluded
┃ ┃ ┃ ┃ ┃ Debug src/wwwroot/lib/bootstrap/LICENSE didn't match [src/Views/Home/Index.cshtml] -> excluded
┃ ┃ ┃ ┃ ┃ Debug src/wwwroot/lib/bootstrap/dist/css/bootstrap-grid.css didn't match [src/Views/Home/Index.cshtml] -> excluded
┃ ┃ ┃ ┃ ┃ Debug src/wwwroot/lib/bootstrap/dist/css/bootstrap-grid.css.map didn't match [src/Views/Home/Index.cshtml] -> excluded
┃ ┃ ┃ ┃ ┃ Debug src/wwwroot/lib/bootstrap/dist/css/bootstrap-grid.min.css didn't match [src/Views/Home/Index.cshtml] -> excluded
┃ ┃ ┃ ┃ ┃ Debug src/wwwroot/lib/bootstrap/dist/css/bootstrap-grid.min.css.map didn't match [src/Views/Home/Index.cshtml] -> excluded
┃ ┃ ┃ ┃ ┃ Debug src/wwwroot/lib/bootstrap/dist/css/bootstrap-grid.rtl.css didn't match [src/Views/Home/Index.cshtml] -> excluded
┃ ┃ ┃ ┃ ┃ Debug src/wwwroot/lib/bootstrap/dist/css/bootstrap-grid.rtl.css.map didn't match [src/Views/Home/Index.cshtml] -> excluded
┃ ┃ ┃ ┃ ┃ Debug src/wwwroot/lib/bootstrap/dist/css/bootstrap-grid.rtl.min.css didn't match [src/Views/Home/Index.cshtml] -> excluded
┃ ┃ ┃ ┃ ┃ Debug src/wwwroot/lib/bootstrap/dist/css/bootstrap-grid.rtl.min.css.map didn't match [src/Views/Home/Index.cshtml] -> excluded
┃ ┃ ┃ ┃ ┃ Debug src/wwwroot/lib/bootstrap/dist/css/bootstrap-reboot.css didn't match [src/Views/Home/Index.cshtml] -> excluded
┃ ┃ ┃ ┃ ┃ Debug src/wwwroot/lib/bootstrap/dist/css/bootstrap-reboot.css.map didn't match [src/Views/Home/Index.cshtml] -> excluded
┃ ┃ ┃ ┃ ┃ Debug src/wwwroot/lib/bootstrap/dist/css/bootstrap-reboot.min.css didn't match [src/Views/Home/Index.cshtml] -> excluded
┃ ┃ ┃ ┃ ┃ Debug src/wwwroot/lib/bootstrap/dist/css/bootstrap-reboot.min.css.map didn't match [src/Views/Home/Index.cshtml] -> excluded
┃ ┃ ┃ ┃ ┃ Debug src/wwwroot/lib/bootstrap/dist/css/bootstrap-reboot.rtl.css didn't match [src/Views/Home/Index.cshtml] -> excluded
┃ ┃ ┃ ┃ ┃ Debug src/wwwroot/lib/bootstrap/dist/css/bootstrap-reboot.rtl.css.map didn't match [src/Views/Home/Index.cshtml] -> excluded
┃ ┃ ┃ ┃ ┃ Debug src/wwwroot/lib/bootstrap/dist/css/bootstrap-reboot.rtl.min.css didn't match [src/Views/Home/Index.cshtml] -> excluded
┃ ┃ ┃ ┃ ┃ Debug src/wwwroot/lib/bootstrap/dist/css/bootstrap-reboot.rtl.min.css.map didn't match [src/Views/Home/Index.cshtml] -> excluded
┃ ┃ ┃ ┃ ┃ Debug src/wwwroot/lib/bootstrap/dist/css/bootstrap-utilities.css didn't match [src/Views/Home/Index.cshtml] -> excluded
┃ ┃ ┃ ┃ ┃ Debug src/wwwroot/lib/bootstrap/dist/css/bootstrap-utilities.css.map didn't match [src/Views/Home/Index.cshtml] -> excluded
┃ ┃ ┃ ┃ ┃ Debug src/wwwroot/lib/bootstrap/dist/css/bootstrap-utilities.min.css didn't match [src/Views/Home/Index.cshtml] -> excluded
┃ ┃ ┃ ┃ ┃ Debug src/wwwroot/lib/bootstrap/dist/css/bootstrap-utilities.min.css.map didn't match [src/Views/Home/Index.cshtml] -> excluded
┃ ┃ ┃ ┃ ┃ Debug src/wwwroot/lib/bootstrap/dist/css/bootstrap-utilities.rtl.css didn't match [src/Views/Home/Index.cshtml] -> excluded
┃ ┃ ┃ ┃ ┃ Debug src/wwwroot/lib/bootstrap/dist/css/bootstrap-utilities.rtl.css.map didn't match [src/Views/Home/Index.cshtml] -> excluded
┃ ┃ ┃ ┃ ┃ Debug src/wwwroot/lib/bootstrap/dist/css/bootstrap-utilities.rtl.min.css didn't match [src/Views/Home/Index.cshtml] -> excluded
┃ ┃ ┃ ┃ ┃ Debug src/wwwroot/lib/bootstrap/dist/css/bootstrap-utilities.rtl.min.css.map didn't match [src/Views/Home/Index.cshtml] -> excluded
┃ ┃ ┃ ┃ ┃ Debug src/wwwroot/lib/bootstrap/dist/css/bootstrap.css didn't match [src/Views/Home/Index.cshtml] -> excluded
┃ ┃ ┃ ┃ ┃ Debug src/wwwroot/lib/bootstrap/dist/css/bootstrap.css.map didn't match [src/Views/Home/Index.cshtml] -> excluded
┃ ┃ ┃ ┃ ┃ Debug src/wwwroot/lib/bootstrap/dist/css/bootstrap.min.css didn't match [src/Views/Home/Index.cshtml] -> excluded
┃ ┃ ┃ ┃ ┃ Debug src/wwwroot/lib/bootstrap/dist/css/bootstrap.min.css.map didn't match [src/Views/Home/Index.cshtml] -> excluded
┃ ┃ ┃ ┃ ┃ Debug src/wwwroot/lib/bootstrap/dist/css/bootstrap.rtl.css didn't match [src/Views/Home/Index.cshtml] -> excluded
┃ ┃ ┃ ┃ ┃ Debug src/wwwroot/lib/bootstrap/dist/css/bootstrap.rtl.css.map didn't match [src/Views/Home/Index.cshtml] -> excluded
┃ ┃ ┃ ┃ ┃ Debug src/wwwroot/lib/bootstrap/dist/css/bootstrap.rtl.min.css didn't match [src/Views/Home/Index.cshtml] -> excluded
┃ ┃ ┃ ┃ ┃ Debug src/wwwroot/lib/bootstrap/dist/css/bootstrap.rtl.min.css.map didn't match [src/Views/Home/Index.cshtml] -> excluded
┃ ┃ ┃ ┃ ┃ Debug src/wwwroot/lib/bootstrap/dist/js/bootstrap.bundle.js didn't match [src/Views/Home/Index.cshtml] -> excluded
┃ ┃ ┃ ┃ ┃ Debug src/wwwroot/lib/bootstrap/dist/js/bootstrap.bundle.js.map didn't match [src/Views/Home/Index.cshtml] -> excluded
┃ ┃ ┃ ┃ ┃ Debug src/wwwroot/lib/bootstrap/dist/js/bootstrap.bundle.min.js didn't match [src/Views/Home/Index.cshtml] -> excluded
┃ ┃ ┃ ┃ ┃ Debug src/wwwroot/lib/bootstrap/dist/js/bootstrap.bundle.min.js.map didn't match [src/Views/Home/Index.cshtml] -> excluded
┃ ┃ ┃ ┃ ┃ Debug src/wwwroot/lib/bootstrap/dist/js/bootstrap.esm.js didn't match [src/Views/Home/Index.cshtml] -> excluded
┃ ┃ ┃ ┃ ┃ Debug src/wwwroot/lib/bootstrap/dist/js/bootstrap.esm.js.map didn't match [src/Views/Home/Index.cshtml] -> excluded
┃ ┃ ┃ ┃ ┃ Debug src/wwwroot/lib/bootstrap/dist/js/bootstrap.esm.min.js didn't match [src/Views/Home/Index.cshtml] -> excluded
┃ ┃ ┃ ┃ ┃ Debug src/wwwroot/lib/bootstrap/dist/js/bootstrap.esm.min.js.map didn't match [src/Views/Home/Index.cshtml] -> excluded
┃ ┃ ┃ ┃ ┃ Debug src/wwwroot/lib/bootstrap/dist/js/bootstrap.js didn't match [src/Views/Home/Index.cshtml] -> excluded
┃ ┃ ┃ ┃ ┃ Debug src/wwwroot/lib/bootstrap/dist/js/bootstrap.js.map didn't match [src/Views/Home/Index.cshtml] -> excluded
┃ ┃ ┃ ┃ ┃ Debug src/wwwroot/lib/bootstrap/dist/js/bootstrap.min.js didn't match [src/Views/Home/Index.cshtml] -> excluded
┃ ┃ ┃ ┃ ┃ Debug src/wwwroot/lib/bootstrap/dist/js/bootstrap.min.js.map didn't match [src/Views/Home/Index.cshtml] -> excluded
┃ ┃ ┃ ┃ ┃ Debug src/wwwroot/lib/jquery/LICENSE.txt didn't match [src/Views/Home/Index.cshtml] -> excluded
┃ ┃ ┃ ┃ ┃ Debug src/wwwroot/lib/jquery/dist/jquery.js didn't match [src/Views/Home/Index.cshtml] -> excluded
┃ ┃ ┃ ┃ ┃ Debug src/wwwroot/lib/jquery/dist/jquery.min.js didn't match [src/Views/Home/Index.cshtml] -> excluded
┃ ┃ ┃ ┃ ┃ Debug src/wwwroot/lib/jquery/dist/jquery.min.map didn't match [src/Views/Home/Index.cshtml] -> excluded
┃ ┃ ┃ ┃ ┃ Debug src/wwwroot/lib/jquery-validation/LICENSE.md didn't match [src/Views/Home/Index.cshtml] -> excluded
┃ ┃ ┃ ┃ ┃ Debug src/wwwroot/lib/jquery-validation/dist/additional-methods.js didn't match [src/Views/Home/Index.cshtml] -> excluded
┃ ┃ ┃ ┃ ┃ Debug src/wwwroot/lib/jquery-validation/dist/additional-methods.min.js didn't match [src/Views/Home/Index.cshtml] -> excluded
┃ ┃ ┃ ┃ ┃ Debug src/wwwroot/lib/jquery-validation/dist/jquery.validate.js didn't match [src/Views/Home/Index.cshtml] -> excluded
┃ ┃ ┃ ┃ ┃ Debug src/wwwroot/lib/jquery-validation/dist/jquery.validate.min.js didn't match [src/Views/Home/Index.cshtml] -> excluded
┃ ┃ ┃ ┃ ┃ Debug src/wwwroot/lib/jquery-validation-unobtrusive/LICENSE.txt didn't match [src/Views/Home/Index.cshtml] -> excluded
┃ ┃ ┃ ┃ ┃ Debug src/wwwroot/lib/jquery-validation-unobtrusive/jquery.validate.unobtrusive.js didn't match [src/Views/Home/Index.cshtml] -> excluded
┃ ┃ ┃ ┃ ┗ Debug src/wwwroot/lib/jquery-validation-unobtrusive/jquery.validate.unobtrusive.min.js didn't match [src/Views/Home/Index.cshtml] -> excluded
┃ ┃ ┃ ┃ ┏ engine.transformations[0].merge.transformations[0].sources[4].<combo>.transformations[1] (Chain)
┃ ┃ ┃ ┃ ┃  Info Running Chain(ReplaceText)
┃ ┃ ┃ ┃ ┃ ┏ engine.transformations[0].merge.transformations[0].sources[4].<combo>.transformations[1].transformations[0] (ReplaceText)
┃ ┃ ┗ ┗ ┗ ┗  Info Will replace [Greetings from .NET + Tanzu!->Greetings from .NET ...(truncated)]
┃ ┃ ┏ engine.transformations[0].merge.transformations[1] (UniquePath)
┃ ┗ ┗ Debug Multiple representations for path 'src/Views/Home/Index.cshtml', will use the one appearing last 
┗ ╺ engine.transformations[1] (UniquePath)
```
