﻿// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version: 16.0.0.0
//  
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------
namespace ServiceClientGenerator.Generators.ProjectFiles
{
    using System.Linq;
    using System.Text;
    using System.Collections.Generic;
    using ServiceClientGenerator;
    using System;
    
    /// <summary>
    /// Class to produce the template output
    /// </summary>
    
    #line 1 "C:\codebase\v3\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\ProjectFiles\WinPhone81ProjectFile.tt"
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.TextTemplating", "16.0.0.0")]
    public partial class WinPhone81ProjectFile : WinPhone81ProjectFileBase
    {
#line hidden
        /// <summary>
        /// Create the template output
        /// </summary>
        public virtual string TransformText()
        {
            this.Write(@"<?xml version=""1.0"" encoding=""utf-8""?>
<Project ToolsVersion=""12.0"" DefaultTargets=""Build"" xmlns=""http://schemas.microsoft.com/developer/msbuild/2003"">
  <Import Project=""$(MSBuildExtensionsPath)\$(MSBuildToolsVersion)\Microsoft.Common.props"" Condition=""Exists('$(MSBuildExtensionsPath)\$(MSBuildToolsVersion)\Microsoft.Common.props')"" />
  <PropertyGroup>
    <MinimumVisualStudioVersion>12.0</MinimumVisualStudioVersion>
    <Configuration Condition="" '$(Configuration)' == '' "">Debug</Configuration>
    <Platform Condition="" '$(Platform)' == '' "">AnyCPU</Platform>
    <ProjectGuid>");
            
            #line 14 "C:\codebase\v3\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\ProjectFiles\WinPhone81ProjectFile.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(this.Project.ProjectGuid));
            
            #line default
            #line hidden
            this.Write("</ProjectGuid>\r\n    <OutputType>Library</OutputType>\r\n    <AppDesignerFolder>Prop" +
                    "erties</AppDesignerFolder>\r\n    <RootNamespace>");
            
            #line 17 "C:\codebase\v3\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\ProjectFiles\WinPhone81ProjectFile.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(this.Project.RootNamespace));
            
            #line default
            #line hidden
            this.Write("</RootNamespace>\r\n    <AssemblyName>");
            
            #line 18 "C:\codebase\v3\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\ProjectFiles\WinPhone81ProjectFile.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(this.Project.AssemblyName));
            
            #line default
            #line hidden
            this.Write(@"</AssemblyName>
    <DefaultLanguage>en-US</DefaultLanguage>
    <FileAlignment>512</FileAlignment>
    <ProjectTypeGuids>{76F1466A-8B6D-4E39-A767-685A06062A39};{FAE04EC0-301F-11D3-BF4B-00C04F79EFBC}</ProjectTypeGuids>
    <SolutionDir Condition=""$(SolutionDir) == '' Or $(SolutionDir) == '*Undefined*'"">.\</SolutionDir>
    <RestorePackages>true</RestorePackages>
    <BaseIntermediateOutputPath>obj\");
            
            #line 24 "C:\codebase\v3\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\ProjectFiles\WinPhone81ProjectFile.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(this.Project.BinSubfolder));
            
            #line default
            #line hidden
            this.Write("</BaseIntermediateOutputPath>\r\n\t<TargetPlatformIdentifier>WindowsPhoneApp</Target" +
                    "PlatformIdentifier>\r\n    <TargetPlatformVersion>8.1</TargetPlatformVersion>\r\n  <" +
                    "/PropertyGroup>\r\n\r\n  <PropertyGroup>\r\n    <CodeAnalysisRuleSet>");
            
            #line 30 "C:\codebase\v3\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\ProjectFiles\WinPhone81ProjectFile.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(this.Project.FxcopAnalyzerRuleSetDirectory));
            
            #line default
            #line hidden
            this.Write(@"</CodeAnalysisRuleSet>
  </PropertyGroup>

  <PropertyGroup Condition="" '$(Configuration)|$(Platform)' == 'Debug|AnyCPU' "">
    <DebugSymbols>true</DebugSymbols>
    <DebugType>full</DebugType>
    <Optimize>false</Optimize>
    <OutputPath>bin\Debug\");
            
            #line 37 "C:\codebase\v3\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\ProjectFiles\WinPhone81ProjectFile.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(this.Project.BinSubfolder));
            
            #line default
            #line hidden
            this.Write("</OutputPath>\r\n    <DefineConstants>DEBUG;TRACE;");
            
            #line 38 "C:\codebase\v3\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\ProjectFiles\WinPhone81ProjectFile.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(string.Join(";", this.Project.DefineConstants)));
            
            #line default
            #line hidden
            this.Write("</DefineConstants>\r\n    <ErrorReport>prompt</ErrorReport>\r\n    <WarningLevel>4</W" +
                    "arningLevel>\r\n");
            
            #line 41 "C:\codebase\v3\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\ProjectFiles\WinPhone81ProjectFile.tt"

    if(this.Project.SupressWarnings != null)
    {

            
            #line default
            #line hidden
            this.Write("\t<NoWarn>");
            
            #line 45 "C:\codebase\v3\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\ProjectFiles\WinPhone81ProjectFile.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(this.Project.SupressWarnings));
            
            #line default
            #line hidden
            this.Write("</NoWarn>\r\n");
            
            #line 46 "C:\codebase\v3\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\ProjectFiles\WinPhone81ProjectFile.tt"

    }

            
            #line default
            #line hidden
            this.Write("    <DocumentationFile>bin\\Debug\\");
            
            #line 49 "C:\codebase\v3\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\ProjectFiles\WinPhone81ProjectFile.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(this.Project.BinSubfolder));
            
            #line default
            #line hidden
            this.Write("\\");
            
            #line 49 "C:\codebase\v3\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\ProjectFiles\WinPhone81ProjectFile.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(this.Project.AssemblyName));
            
            #line default
            #line hidden
            this.Write(".XML</DocumentationFile>\r\n  </PropertyGroup>\r\n  <PropertyGroup Condition=\" \'$(Con" +
                    "figuration)|$(Platform)\' == \'Release|AnyCPU\' \">\r\n    <DebugType>pdbonly</DebugTy" +
                    "pe>\r\n    <Optimize>true</Optimize>\r\n    <OutputPath>bin\\Release\\");
            
            #line 54 "C:\codebase\v3\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\ProjectFiles\WinPhone81ProjectFile.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(this.Project.BinSubfolder));
            
            #line default
            #line hidden
            this.Write("</OutputPath>\r\n    <DefineConstants>TRACE;");
            
            #line 55 "C:\codebase\v3\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\ProjectFiles\WinPhone81ProjectFile.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(string.Join(";", this.Project.DefineConstants)));
            
            #line default
            #line hidden
            this.Write("</DefineConstants>\r\n    <ErrorReport>prompt</ErrorReport>\r\n    <WarningLevel>4</W" +
                    "arningLevel>\r\n");
            
            #line 58 "C:\codebase\v3\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\ProjectFiles\WinPhone81ProjectFile.tt"

    if(this.Project.SupressWarnings != null)
    {

            
            #line default
            #line hidden
            this.Write("\t<NoWarn>");
            
            #line 62 "C:\codebase\v3\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\ProjectFiles\WinPhone81ProjectFile.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(this.Project.SupressWarnings));
            
            #line default
            #line hidden
            this.Write("</NoWarn>\r\n");
            
            #line 63 "C:\codebase\v3\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\ProjectFiles\WinPhone81ProjectFile.tt"

    }

            
            #line default
            #line hidden
            this.Write("    <DocumentationFile>bin\\Release\\");
            
            #line 66 "C:\codebase\v3\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\ProjectFiles\WinPhone81ProjectFile.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(this.Project.BinSubfolder));
            
            #line default
            #line hidden
            this.Write("\\");
            
            #line 66 "C:\codebase\v3\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\ProjectFiles\WinPhone81ProjectFile.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(this.Project.AssemblyName));
            
            #line default
            #line hidden
            this.Write(@".XML</DocumentationFile>
  </PropertyGroup>
  <PropertyGroup>
    <CheckForOverflowUnderflow>True</CheckForOverflowUnderflow>
    <SignAssembly>true</SignAssembly>
  </PropertyGroup>
  <Choose>
    <When Condition="" '$(AWSKeyFile)' == '' "">
      <PropertyGroup>
");
            
            #line 75 "C:\codebase\v3\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\ProjectFiles\WinPhone81ProjectFile.tt"

    if(this.Project.KeyFilePath != null)
    {

            
            #line default
            #line hidden
            this.Write("\t\t<AssemblyOriginatorKeyFile>");
            
            #line 79 "C:\codebase\v3\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\ProjectFiles\WinPhone81ProjectFile.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(this.Project.KeyFilePath));
            
            #line default
            #line hidden
            this.Write("</AssemblyOriginatorKeyFile>\r\n");
            
            #line 80 "C:\codebase\v3\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\ProjectFiles\WinPhone81ProjectFile.tt"

    }
	else
    {

            
            #line default
            #line hidden
            this.Write("        <AssemblyOriginatorKeyFile>..\\..\\..\\awssdk.dll.snk</AssemblyOriginatorKey" +
                    "File>\r\n");
            
            #line 86 "C:\codebase\v3\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\ProjectFiles\WinPhone81ProjectFile.tt"

    }

            
            #line default
            #line hidden
            this.Write("      </PropertyGroup>\r\n    </When>\r\n    <Otherwise>\r\n      <PropertyGroup>\r\n    " +
                    "    <AssemblyOriginatorKeyFile>$(AWSKeyFile)</AssemblyOriginatorKeyFile>\r\n      " +
                    "</PropertyGroup>\r\n    </Otherwise>\r\n  </Choose>\r\n  <ItemGroup>\r\n");
            
            #line 98 "C:\codebase\v3\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\ProjectFiles\WinPhone81ProjectFile.tt"

    foreach(string subDirectory in this.Project.SourceDirectories)
    {

            
            #line default
            #line hidden
            this.Write("    <Compile Include=\"");
            
            #line 102 "C:\codebase\v3\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\ProjectFiles\WinPhone81ProjectFile.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(subDirectory));
            
            #line default
            #line hidden
            this.Write("\\*.cs\">\r\n      <SubType>Code</SubType>\r\n    </Compile>\r\n");
            
            #line 105 "C:\codebase\v3\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\ProjectFiles\WinPhone81ProjectFile.tt"

    }

            
            #line default
            #line hidden
            this.Write("  </ItemGroup>\r\n  <ItemGroup>\r\n");
            
            #line 110 "C:\codebase\v3\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\ProjectFiles\WinPhone81ProjectFile.tt"

    if(this.Project.IndividualFileIncludes != null)
    {
        foreach(string file in this.Project.IndividualFileIncludes)
        {
            if(file.EndsWith(".cs"))
            {

            
            #line default
            #line hidden
            this.Write("    <Compile Include=\"");
            
            #line 118 "C:\codebase\v3\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\ProjectFiles\WinPhone81ProjectFile.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(file));
            
            #line default
            #line hidden
            this.Write("\">\r\n      <SubType>Code</SubType>\r\n    </Compile>\r\n");
            
            #line 121 "C:\codebase\v3\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\ProjectFiles\WinPhone81ProjectFile.tt"

            }
            else
            {

            
            #line default
            #line hidden
            this.Write("    <EmbeddedResource Include=\"");
            
            #line 126 "C:\codebase\v3\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\ProjectFiles\WinPhone81ProjectFile.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(file));
            
            #line default
            #line hidden
            this.Write("\">\r\n      <SubType>Designer</SubType>\r\n    </EmbeddedResource>\r\n");
            
            #line 129 "C:\codebase\v3\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\ProjectFiles\WinPhone81ProjectFile.tt"

            }
        }
    }

            
            #line default
            #line hidden
            this.Write("  </ItemGroup>\r\n");
            
            #line 135 "C:\codebase\v3\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\ProjectFiles\WinPhone81ProjectFile.tt"

    if(this.Project.ProjectReferences != null)
    {
        foreach(var projectReferences in this.Project.ProjectReferences)
        {

            
            #line default
            #line hidden
            this.Write("  <ItemGroup>\r\n    <ProjectReference Include=\"");
            
            #line 142 "C:\codebase\v3\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\ProjectFiles\WinPhone81ProjectFile.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(projectReferences.IncludePath));
            
            #line default
            #line hidden
            this.Write("\">\r\n        <Project>");
            
            #line 143 "C:\codebase\v3\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\ProjectFiles\WinPhone81ProjectFile.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(projectReferences.ProjectGuid));
            
            #line default
            #line hidden
            this.Write("</Project>\r\n        <Name>");
            
            #line 144 "C:\codebase\v3\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\ProjectFiles\WinPhone81ProjectFile.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(projectReferences.Name));
            
            #line default
            #line hidden
            this.Write("</Name>\r\n    </ProjectReference>\r\n  </ItemGroup>\r\n");
            
            #line 147 "C:\codebase\v3\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\ProjectFiles\WinPhone81ProjectFile.tt"

        }
    }

            
            #line default
            #line hidden
            this.Write("\r\n");
            
            #line 152 "C:\codebase\v3\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\ProjectFiles\WinPhone81ProjectFile.tt"

    if(this.Project.PackageReferences != null)
    {

            
            #line default
            #line hidden
            this.Write("  <ItemGroup>\r\n");
            
            #line 157 "C:\codebase\v3\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\ProjectFiles\WinPhone81ProjectFile.tt"

        foreach(var package in this.Project.PackageReferences)
        {

            
            #line default
            #line hidden
            this.Write("    <PackageReference Include=\"");
            
            #line 161 "C:\codebase\v3\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\ProjectFiles\WinPhone81ProjectFile.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(package.Include));
            
            #line default
            #line hidden
            this.Write("\" Version=\"");
            
            #line 161 "C:\codebase\v3\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\ProjectFiles\WinPhone81ProjectFile.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(package.Version));
            
            #line default
            #line hidden
            this.Write("\">\r\n");
            
            #line 162 "C:\codebase\v3\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\ProjectFiles\WinPhone81ProjectFile.tt"

			if(package.PrivateAssets != "" && package.PrivateAssets != "none")
			{

            
            #line default
            #line hidden
            this.Write("\t\t<PrivateAssets>");
            
            #line 166 "C:\codebase\v3\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\ProjectFiles\WinPhone81ProjectFile.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(package.PrivateAssets));
            
            #line default
            #line hidden
            this.Write("</PrivateAssets>\r\n");
            
            #line 167 "C:\codebase\v3\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\ProjectFiles\WinPhone81ProjectFile.tt"
 
				if(package.IncludeAssets != "")
				{

            
            #line default
            #line hidden
            this.Write("\t\t<IncludeAssets>");
            
            #line 171 "C:\codebase\v3\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\ProjectFiles\WinPhone81ProjectFile.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(package.IncludeAssets));
            
            #line default
            #line hidden
            this.Write("</IncludeAssets>\r\n");
            
            #line 172 "C:\codebase\v3\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\ProjectFiles\WinPhone81ProjectFile.tt"

				}

            
            #line default
            #line hidden
            this.Write("\t</PackageReference>\r\n");
            
            #line 176 "C:\codebase\v3\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\ProjectFiles\WinPhone81ProjectFile.tt"

			}
			else
			{

            
            #line default
            #line hidden
            this.Write("\t\t\t\r\n\t</PackageReference>\t\r\n");
            
            #line 182 "C:\codebase\v3\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\ProjectFiles\WinPhone81ProjectFile.tt"

			}
        }

            
            #line default
            #line hidden
            this.Write("  </ItemGroup>\r\n");
            
            #line 187 "C:\codebase\v3\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\ProjectFiles\WinPhone81ProjectFile.tt"

	}

            
            #line default
            #line hidden
            this.Write(@"
  <ItemGroup>
    <Compile Include=""Properties\AssemblyInfo.cs"" />
    <None Include=""packages.config"" />
  </ItemGroup>
  <ItemGroup>
    <Service Include=""{508349B6-6B84-4DF5-91F0-309BEEBAD82D}"" />
  </ItemGroup>
  <ItemGroup>
    <Reference Include=""System"" />
    <Reference Include=""System.Core"" />
    <Reference Include=""System.Xml.Linq"" />
    <Reference Include=""System.Xml"" />
    <Reference Include=""PCLCrypto"">
      <HintPath>");
            
            #line 204 "C:\codebase\v3\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\ProjectFiles\WinPhone81ProjectFile.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(this.Project.NugetPackagesLocation));
            
            #line default
            #line hidden
            this.Write("PCLCrypto.1.0.2.15130\\lib\\portable-net40+sl50+win+wpa81+wp80+MonoAndroid10+xamari" +
                    "nios10+MonoTouch10\\PCLCrypto.dll</HintPath>\r\n    </Reference>\r\n    <Reference In" +
                    "clude=\"PCLStorage\">\r\n      <HintPath>");
            
            #line 207 "C:\codebase\v3\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\ProjectFiles\WinPhone81ProjectFile.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(this.Project.NugetPackagesLocation));
            
            #line default
            #line hidden
            this.Write("PCLStorage.1.0.2\\lib\\portable-net45+wp8+wpa81+win8+monoandroid+monotouch+Xamarin." +
                    "iOS+Xamarin.Mac\\PCLStorage.dll</HintPath>\r\n    </Reference>\r\n    <Reference Incl" +
                    "ude=\"PCLStorage.Abstractions\">\r\n      <HintPath>");
            
            #line 210 "C:\codebase\v3\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\ProjectFiles\WinPhone81ProjectFile.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(this.Project.NugetPackagesLocation));
            
            #line default
            #line hidden
            this.Write("PCLStorage.1.0.2\\lib\\portable-net45+wp8+wpa81+win8+monoandroid+monotouch+Xamarin." +
                    "iOS+Xamarin.Mac\\PCLStorage.Abstractions.dll</HintPath>\r\n    </Reference>    \r\n  " +
                    "</ItemGroup>\r\n  <Import Project=\"$(MSBuildExtensionsPath)\\Microsoft\\WindowsXaml\\" +
                    "v$(VisualStudioVersion)\\Microsoft.Windows.UI.Xaml.CSharp.targets\" />\r\n  <Import " +
                    "Condition=\"Exists(\'$(MSBuildExtensionsPath)\\Microsoft\\VisualStudio\\TextTemplatin" +
                    "g\\v10.0\\Microsoft.TextTemplating.targets\')\" Project=\"$(MSBuildExtensionsPath)\\Mi" +
                    "crosoft\\VisualStudio\\TextTemplating\\v10.0\\Microsoft.TextTemplating.targets\" />\r\n" +
                    "  <Import Project=\"$(SolutionDir)\\.nuget\\NuGet.targets\" Condition=\"Exists(\'$(Sol" +
                    "utionDir)\\.nuget\\NuGet.targets\')\" />\r\n  <Target Name=\"EnsureNuGetPackageBuildImp" +
                    "orts\" BeforeTargets=\"PrepareForBuild\">\r\n    <PropertyGroup>\r\n      <ErrorText>Th" +
                    "is project references NuGet package(s) that are missing on this computer. Enable" +
                    " NuGet Package Restore to download them.  For more information, see http://go.mi" +
                    "crosoft.com/fwlink/?LinkID=322105. The missing file is {0}.</ErrorText>\r\n    </P" +
                    "ropertyGroup>\r\n    <Error Condition=\"!Exists(\'$(SolutionDir)\\.nuget\\NuGet.target" +
                    "s\')\" Text=\"$([System.String]::Format(\'$(ErrorText)\', \'$(SolutionDir)\\.nuget\\NuGe" +
                    "t.targets\'))\" />\r\n  </Target>\r\n  <!-- To modify your build process, add your tas" +
                    "k inside one of the targets below and uncomment it. \r\n       Other similar exten" +
                    "sion points exist, see Microsoft.Common.targets.\r\n  <Target Name=\"BeforeBuild\">\r" +
                    "\n  </Target>\r\n  <Target Name=\"AfterBuild\">\r\n  </Target>\r\n  -->\r\n</Project>\r\n\r\n");
            return this.GenerationEnvironment.ToString();
        }
        
        #line 231 "C:\codebase\v3\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\ProjectFiles\WinPhone81ProjectFile.tt"

	public Project Project { get; set; }

        
        #line default
        #line hidden
    }
    
    #line default
    #line hidden
    #region Base class
    /// <summary>
    /// Base class for this transformation
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.TextTemplating", "16.0.0.0")]
    public class WinPhone81ProjectFileBase
    {
        #region Fields
        private global::System.Text.StringBuilder generationEnvironmentField;
        private global::System.CodeDom.Compiler.CompilerErrorCollection errorsField;
        private global::System.Collections.Generic.List<int> indentLengthsField;
        private string currentIndentField = "";
        private bool endsWithNewline;
        private global::System.Collections.Generic.IDictionary<string, object> sessionField;
        #endregion
        #region Properties
        /// <summary>
        /// The string builder that generation-time code is using to assemble generated output
        /// </summary>
        protected System.Text.StringBuilder GenerationEnvironment
        {
            get
            {
                if ((this.generationEnvironmentField == null))
                {
                    this.generationEnvironmentField = new global::System.Text.StringBuilder();
                }
                return this.generationEnvironmentField;
            }
            set
            {
                this.generationEnvironmentField = value;
            }
        }
        /// <summary>
        /// The error collection for the generation process
        /// </summary>
        public System.CodeDom.Compiler.CompilerErrorCollection Errors
        {
            get
            {
                if ((this.errorsField == null))
                {
                    this.errorsField = new global::System.CodeDom.Compiler.CompilerErrorCollection();
                }
                return this.errorsField;
            }
        }
        /// <summary>
        /// A list of the lengths of each indent that was added with PushIndent
        /// </summary>
        private System.Collections.Generic.List<int> indentLengths
        {
            get
            {
                if ((this.indentLengthsField == null))
                {
                    this.indentLengthsField = new global::System.Collections.Generic.List<int>();
                }
                return this.indentLengthsField;
            }
        }
        /// <summary>
        /// Gets the current indent we use when adding lines to the output
        /// </summary>
        public string CurrentIndent
        {
            get
            {
                return this.currentIndentField;
            }
        }
        /// <summary>
        /// Current transformation session
        /// </summary>
        public virtual global::System.Collections.Generic.IDictionary<string, object> Session
        {
            get
            {
                return this.sessionField;
            }
            set
            {
                this.sessionField = value;
            }
        }
        #endregion
        #region Transform-time helpers
        /// <summary>
        /// Write text directly into the generated output
        /// </summary>
        public void Write(string textToAppend)
        {
            if (string.IsNullOrEmpty(textToAppend))
            {
                return;
            }
            // If we're starting off, or if the previous text ended with a newline,
            // we have to append the current indent first.
            if (((this.GenerationEnvironment.Length == 0) 
                        || this.endsWithNewline))
            {
                this.GenerationEnvironment.Append(this.currentIndentField);
                this.endsWithNewline = false;
            }
            // Check if the current text ends with a newline
            if (textToAppend.EndsWith(global::System.Environment.NewLine, global::System.StringComparison.CurrentCulture))
            {
                this.endsWithNewline = true;
            }
            // This is an optimization. If the current indent is "", then we don't have to do any
            // of the more complex stuff further down.
            if ((this.currentIndentField.Length == 0))
            {
                this.GenerationEnvironment.Append(textToAppend);
                return;
            }
            // Everywhere there is a newline in the text, add an indent after it
            textToAppend = textToAppend.Replace(global::System.Environment.NewLine, (global::System.Environment.NewLine + this.currentIndentField));
            // If the text ends with a newline, then we should strip off the indent added at the very end
            // because the appropriate indent will be added when the next time Write() is called
            if (this.endsWithNewline)
            {
                this.GenerationEnvironment.Append(textToAppend, 0, (textToAppend.Length - this.currentIndentField.Length));
            }
            else
            {
                this.GenerationEnvironment.Append(textToAppend);
            }
        }
        /// <summary>
        /// Write text directly into the generated output
        /// </summary>
        public void WriteLine(string textToAppend)
        {
            this.Write(textToAppend);
            this.GenerationEnvironment.AppendLine();
            this.endsWithNewline = true;
        }
        /// <summary>
        /// Write formatted text directly into the generated output
        /// </summary>
        public void Write(string format, params object[] args)
        {
            this.Write(string.Format(global::System.Globalization.CultureInfo.CurrentCulture, format, args));
        }
        /// <summary>
        /// Write formatted text directly into the generated output
        /// </summary>
        public void WriteLine(string format, params object[] args)
        {
            this.WriteLine(string.Format(global::System.Globalization.CultureInfo.CurrentCulture, format, args));
        }
        /// <summary>
        /// Raise an error
        /// </summary>
        public void Error(string message)
        {
            System.CodeDom.Compiler.CompilerError error = new global::System.CodeDom.Compiler.CompilerError();
            error.ErrorText = message;
            this.Errors.Add(error);
        }
        /// <summary>
        /// Raise a warning
        /// </summary>
        public void Warning(string message)
        {
            System.CodeDom.Compiler.CompilerError error = new global::System.CodeDom.Compiler.CompilerError();
            error.ErrorText = message;
            error.IsWarning = true;
            this.Errors.Add(error);
        }
        /// <summary>
        /// Increase the indent
        /// </summary>
        public void PushIndent(string indent)
        {
            if ((indent == null))
            {
                throw new global::System.ArgumentNullException("indent");
            }
            this.currentIndentField = (this.currentIndentField + indent);
            this.indentLengths.Add(indent.Length);
        }
        /// <summary>
        /// Remove the last indent that was added with PushIndent
        /// </summary>
        public string PopIndent()
        {
            string returnValue = "";
            if ((this.indentLengths.Count > 0))
            {
                int indentLength = this.indentLengths[(this.indentLengths.Count - 1)];
                this.indentLengths.RemoveAt((this.indentLengths.Count - 1));
                if ((indentLength > 0))
                {
                    returnValue = this.currentIndentField.Substring((this.currentIndentField.Length - indentLength));
                    this.currentIndentField = this.currentIndentField.Remove((this.currentIndentField.Length - indentLength));
                }
            }
            return returnValue;
        }
        /// <summary>
        /// Remove any indentation
        /// </summary>
        public void ClearIndent()
        {
            this.indentLengths.Clear();
            this.currentIndentField = "";
        }
        #endregion
        #region ToString Helpers
        /// <summary>
        /// Utility class to produce culture-oriented representation of an object as a string.
        /// </summary>
        public class ToStringInstanceHelper
        {
            private System.IFormatProvider formatProviderField  = global::System.Globalization.CultureInfo.InvariantCulture;
            /// <summary>
            /// Gets or sets format provider to be used by ToStringWithCulture method.
            /// </summary>
            public System.IFormatProvider FormatProvider
            {
                get
                {
                    return this.formatProviderField ;
                }
                set
                {
                    if ((value != null))
                    {
                        this.formatProviderField  = value;
                    }
                }
            }
            /// <summary>
            /// This is called from the compile/run appdomain to convert objects within an expression block to a string
            /// </summary>
            public string ToStringWithCulture(object objectToConvert)
            {
                if ((objectToConvert == null))
                {
                    throw new global::System.ArgumentNullException("objectToConvert");
                }
                System.Type t = objectToConvert.GetType();
                System.Reflection.MethodInfo method = t.GetMethod("ToString", new System.Type[] {
                            typeof(System.IFormatProvider)});
                if ((method == null))
                {
                    return objectToConvert.ToString();
                }
                else
                {
                    return ((string)(method.Invoke(objectToConvert, new object[] {
                                this.formatProviderField })));
                }
            }
        }
        private ToStringInstanceHelper toStringHelperField = new ToStringInstanceHelper();
        /// <summary>
        /// Helper to produce culture-oriented representation of an object as a string
        /// </summary>
        public ToStringInstanceHelper ToStringHelper
        {
            get
            {
                return this.toStringHelperField;
            }
        }
        #endregion
    }
    #endregion
}
