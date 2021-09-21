(window.webpackJsonp=window.webpackJsonp||[]).push([[17],{87:function(e,n,t){"use strict";t.r(n),t.d(n,"frontMatter",(function(){return c})),t.d(n,"metadata",(function(){return o})),t.d(n,"toc",(function(){return l})),t.d(n,"default",(function(){return p}));var r=t(3),i=t(7),a=(t(0),t(103)),c={title:"Dependency Injection"},o={unversionedId:"dependency-injection",id:"dependency-injection",isDocsHomePage:!1,title:"Dependency Injection",description:"The Argent Pony Warcraft Client includes tools to make registering the various interfaces with the IServiceCollection in .NET Core applications a snap!",source:"@site/docs/dependency-injection.md",slug:"/dependency-injection",permalink:"/warcraft/docs/dependency-injection",editUrl:"https://github.com/blizzard-net/warcraft/edit/documentation/docs/dependency-injection.md",version:"current",sidebar:"docs",previous:{title:"Using the Library",permalink:"/warcraft/docs/usage"},next:{title:"Resources",permalink:"/warcraft/docs/resources"}},l=[{value:"Register services",id:"register-services",children:[]}],s={toc:l};function p(e){var n=e.components,t=Object(i.a)(e,["components"]);return Object(a.b)("wrapper",Object(r.a)({},s,t,{components:n,mdxType:"MDXLayout"}),Object(a.b)("p",null,"The Argent Pony Warcraft Client includes tools to make registering the various interfaces with the ",Object(a.b)("inlineCode",{parentName:"p"},"IServiceCollection")," in .NET Core applications a snap!\nMake sure you have installed the ",Object(a.b)("inlineCode",{parentName:"p"},"ArgentPoneyWarcraftClient.Extensions.DependencyInjection")," NuGet package as described in ",Object(a.b)("a",{parentName:"p",href:"./getting-started"},"Getting Started"),"."),Object(a.b)("h3",{id:"register-services"},"Register services"),Object(a.b)("p",null,"To start off, add the appropriate ",Object(a.b)("inlineCode",{parentName:"p"},"using")," statement to the file."),Object(a.b)("pre",null,Object(a.b)("code",{parentName:"pre",className:"language-cs"},"using ArgentPoneyWarcraftClient.Extensions.DependencyInjection;\n")),Object(a.b)("p",null,"Then use the ",Object(a.b)("inlineCode",{parentName:"p"},"AddWarcraftClients()")," method on the ",Object(a.b)("inlineCode",{parentName:"p"},"IServiceCollection")," instance. For example, in ASP.NET Core applications this would be in the ",Object(a.b)("inlineCode",{parentName:"p"},"ConfigureServices()")," method like so."),Object(a.b)("pre",null,Object(a.b)("code",{parentName:"pre",className:"language-cs"},'public class Startup\n{\n    public void ConfigureServices(IServiceCollection services)\n    {\n        string clientId = "MY-CLIENT-ID-GOES-HERE";\n        string clientSecret = "MY-CLIENT-SECRET-GOES-HERE";\n\n        services.AddWarcraftClients(clientId, clientSecret);\n    }\n}\n')),Object(a.b)("p",null,"Similar to directly instantiating the ",Object(a.b)("inlineCode",{parentName:"p"},"WarcraftClient"),", you also have the option to specify the locale and region you want to use."),Object(a.b)("pre",null,Object(a.b)("code",{parentName:"pre",className:"language-cs"},'public class Startup\n{\n    public void ConfigureServices(IServiceCollection services)\n    {\n        string clientId = "MY-CLIENT-ID-GOES-HERE";\n        string clientSecret = "MY-CLIENT-SECRET-GOES-HERE";\n\n        services.AddWarcraftClients(clientId, clientSecret, Region.Europe, Locale.en_GB);\n    }\n}\n')),Object(a.b)("p",null,"Once the services are registered with the container you can list them as dependencies for your controllers or services."),Object(a.b)("pre",null,Object(a.b)("code",{parentName:"pre",className:"language-cs"},'public class CharacterProfileController\n{\n    private readonly IWarcraftClient _warcraftClient;\n\n    public CharacterProfileController(IWarcraftClient warcraftClient)\n    {\n        _warcraftClient = warcraftClient;\n    }\n\n    public async Task<ActionResult> GetCharacterProfileSummary()\n    {\n        RequestResult<CharacterProfileSummary> result =\n            await _warcraftClient.GetCharacterProfileSummaryAsync("norgannon", "drinian", "profile-us");\n\n        return Ok(result);\n    }\n}\n')),Object(a.b)("p",null,"In addition to registering the ",Object(a.b)("inlineCode",{parentName:"p"},"IWarcraftClient"),", it registers all of the discrete interfaces as well, such as the ",Object(a.b)("inlineCode",{parentName:"p"},"IProfileApi")," or ",Object(a.b)("inlineCode",{parentName:"p"},"IAchievementApi"),". This allows your component to depend only on the specific APIs you need."),Object(a.b)("pre",null,Object(a.b)("code",{parentName:"pre",className:"language-cs"},'public class CharacterProfileController\n{\n    private readonly ICharacterProfileApi _characterProfileClient;\n\n    public CharacterProfileController(ICharacterProfileApi characterProfileClient)\n    {\n        _characterProfileClient = characterProfileClient;\n    }\n\n    public async Task<ActionResult> GetCharacterProfileSummary()\n    {\n        RequestResult<CharacterProfileSummary> result =\n            await _characterProfileClient.GetCharacterProfileSummaryAsync(\n                "norgannon", "drinian", "profile-us");\n\n        return Ok(result);\n    }\n}\n')))}p.isMDXComponent=!0}}]);