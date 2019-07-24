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
    
    #line 1 "C:\codebase\v3\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\ProjectFiles\VS2017ProjectFile.tt"
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.TextTemplating", "16.0.0.0")]
    public partial class VS2017ProjectFile : VS2017ProjectFileBase
    {
#line hidden
        /// <summary>
        /// Create the template output
        /// </summary>
        public virtual string TransformText()
        {
            this.Write("<Project Sdk=\"Microsoft.NET.Sdk\">\r\n  <PropertyGroup>\r\n");
            
            #line 9 "C:\codebase\v3\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\ProjectFiles\VS2017ProjectFile.tt"

    if (this.Project.TargetFrameworks.Count() == 1)
    {

            
            #line default
            #line hidden
            this.Write("    <TargetFramework>");
            
            #line 13 "C:\codebase\v3\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\ProjectFiles\VS2017ProjectFile.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(this.Project.TargetFrameworks.Single()));
            
            #line default
            #line hidden
            this.Write("</TargetFramework>\r\n");
            
            #line 14 "C:\codebase\v3\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\ProjectFiles\VS2017ProjectFile.tt"

    }
    else
    {

            
            #line default
            #line hidden
            this.Write("    <TargetFrameworks>");
            
            #line 19 "C:\codebase\v3\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\ProjectFiles\VS2017ProjectFile.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(string.Join(";", this.Project.TargetFrameworks)));
            
            #line default
            #line hidden
            this.Write("</TargetFrameworks>\r\n");
            
            #line 20 "C:\codebase\v3\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\ProjectFiles\VS2017ProjectFile.tt"

    }

            
            #line default
            #line hidden
            this.Write("    <DefineConstants>$(DefineConstants);");
            
            #line 23 "C:\codebase\v3\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\ProjectFiles\VS2017ProjectFile.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(string.Join(";", this.Project.DefineConstants)));
            
            #line default
            #line hidden
            this.Write("</DefineConstants>\r\n");
            
            #line 24 "C:\codebase\v3\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\ProjectFiles\VS2017ProjectFile.tt"

    if (this.Project.TargetFrameworks.Contains("netstandard1.3"))
    {

            
            #line default
            #line hidden
            this.Write("    <DefineConstants Condition=\"\'$(TargetFramework)\' == \'netstandard1.3\'\">$(Defin" +
                    "eConstants);NETSTANDARD13;ADD_SUPPORT_ICLONEABLE;ADD_SUPPORT_IORDERED_DICTIONARY" +
                    "</DefineConstants>\r\n");
            
            #line 29 "C:\codebase\v3\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\ProjectFiles\VS2017ProjectFile.tt"

    }
    if (this.Project.TargetFrameworks.Contains("netstandard2.0"))
    {

            
            #line default
            #line hidden
            this.Write("    <DefineConstants Condition=\"\'$(TargetFramework)\' == \'netstandard2.0\'\">$(Defin" +
                    "eConstants);NETSTANDARD20</DefineConstants>\r\n");
            
            #line 35 "C:\codebase\v3\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\ProjectFiles\VS2017ProjectFile.tt"

    }

            
            #line default
            #line hidden
            this.Write("    <DebugType>portable</DebugType>\r\n    <GenerateDocumentationFile>true</Generat" +
                    "eDocumentationFile>\r\n    <AssemblyName>");
            
            #line 40 "C:\codebase\v3\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\ProjectFiles\VS2017ProjectFile.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(this.Project.AssemblyName));
            
            #line default
            #line hidden
            this.Write("</AssemblyName>\r\n    <PackageId>");
            
            #line 41 "C:\codebase\v3\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\ProjectFiles\VS2017ProjectFile.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(this.Project.AssemblyName));
            
            #line default
            #line hidden
            this.Write(@"</PackageId>

    <GenerateAssemblyTitleAttribute>false</GenerateAssemblyTitleAttribute>
    <GenerateAssemblyConfigurationAttribute>false</GenerateAssemblyConfigurationAttribute>
    <GenerateAssemblyProductAttribute>false</GenerateAssemblyProductAttribute>
    <GenerateAssemblyCompanyAttribute>false</GenerateAssemblyCompanyAttribute>
    <GenerateAssemblyCopyrightAttribute>false</GenerateAssemblyCopyrightAttribute>
    <GenerateAssemblyVersionAttribute>false</GenerateAssemblyVersionAttribute>
    <GenerateAssemblyFileVersionAttribute>false</GenerateAssemblyFileVersionAttribute>
    <GenerateAssemblyDescriptionAttribute>false</GenerateAssemblyDescriptionAttribute>

");
            
            #line 52 "C:\codebase\v3\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\ProjectFiles\VS2017ProjectFile.tt"

    if(!string.IsNullOrEmpty(this.Project.FrameworkPathOverride))
    {

            
            #line default
            #line hidden
            this.Write("    <!-- workaround per https://github.com/Microsoft/msbuild/issues/1333 -->\r\n   " +
                    " <FrameworkPathOverride>");
            
            #line 57 "C:\codebase\v3\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\ProjectFiles\VS2017ProjectFile.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(this.Project.FrameworkPathOverride));
            
            #line default
            #line hidden
            this.Write("</FrameworkPathOverride>\r\n");
            
            #line 58 "C:\codebase\v3\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\ProjectFiles\VS2017ProjectFile.tt"

    }
    
    if(!string.IsNullOrEmpty(this.Project.SupressWarnings))
    {

            
            #line default
            #line hidden
            this.Write("    <NoWarn>");
            
            #line 64 "C:\codebase\v3\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\ProjectFiles\VS2017ProjectFile.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(this.Project.SupressWarnings));
            
            #line default
            #line hidden
            this.Write("</NoWarn>\r\n");
            
            #line 65 "C:\codebase\v3\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\ProjectFiles\VS2017ProjectFile.tt"

    }

    if(!string.IsNullOrEmpty(this.Project.OutputPathOverride))
    {

            
            #line default
            #line hidden
            this.Write("    <AppendTargetFrameworkToOutputPath>false</AppendTargetFrameworkToOutputPath>\r" +
                    "\n    <OutputPath>");
            
            #line 72 "C:\codebase\v3\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\ProjectFiles\VS2017ProjectFile.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(this.Project.OutputPathOverride));
            
            #line default
            #line hidden
            this.Write("</OutputPath>\r\n");
            
            #line 73 "C:\codebase\v3\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\ProjectFiles\VS2017ProjectFile.tt"

    }

    if (this.Project.TargetFrameworks.Contains("netstandard1.3"))
    {

            
            #line default
            #line hidden
            this.Write("    <NetStandardImplicitPackageVersion  Condition=\"\'$(TargetFramework)\' == \'netst" +
                    "andard1.3\'\">1.6.0</NetStandardImplicitPackageVersion>\r\n");
            
            #line 80 "C:\codebase\v3\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\ProjectFiles\VS2017ProjectFile.tt"

    }    

            
            #line default
            #line hidden
            this.Write("  </PropertyGroup>\r\n\r\n  <PropertyGroup Condition=\" \'$(RuleSetFileForBuild)\' == \'f" +
                    "alse\' \">\r\n\t<CodeAnalysisRuleSet>");
            
            #line 86 "C:\codebase\v3\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\ProjectFiles\VS2017ProjectFile.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(this.Project.FxcopAnalyzerRuleSetFilePath));
            
            #line default
            #line hidden
            this.Write("</CodeAnalysisRuleSet>\r\n  </PropertyGroup>\r\n  <PropertyGroup Condition=\" \'$(RuleS" +
                    "etFileForBuild)\' == \'true\' \">\r\n\t<CodeAnalysisRuleSet>");
            
            #line 89 "C:\codebase\v3\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\ProjectFiles\VS2017ProjectFile.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(this.Project.FxcopAnalyzerRuleSetFilePathForBuild));
            
            #line default
            #line hidden
            this.Write("</CodeAnalysisRuleSet>\r\n  </PropertyGroup>\r\n\r\n");
            
            #line 92 "C:\codebase\v3\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\ProjectFiles\VS2017ProjectFile.tt"

    if (this.Project.SignBinaries)
    {

            
            #line default
            #line hidden
            this.Write(@"  <Choose>
    <When Condition="" '$(AWSKeyFile)' == '' "">
      <PropertyGroup>
        <AssemblyOriginatorKeyFile>..\..\..\awssdk.dll.snk</AssemblyOriginatorKeyFile>
      </PropertyGroup>
    </When>
    <Otherwise>
      <PropertyGroup>
        <AssemblyOriginatorKeyFile>$(AWSKeyFile)</AssemblyOriginatorKeyFile>
      </PropertyGroup>
    </Otherwise>
  </Choose>

");
            
            #line 109 "C:\codebase\v3\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\ProjectFiles\VS2017ProjectFile.tt"

    }
    if(this.Project.CustomRoslynAnalyzersDllDirectory != null)
    {

            
            #line default
            #line hidden
            this.Write("  <ItemGroup>\r\n    <Analyzer Include= \"");
            
            #line 115 "C:\codebase\v3\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\ProjectFiles\VS2017ProjectFile.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(this.Project.CustomRoslynAnalyzersDllDirectory));
            
            #line default
            #line hidden
            this.Write("\" />\r\n  </ItemGroup>\r\n");
            
            #line 117 "C:\codebase\v3\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\ProjectFiles\VS2017ProjectFile.tt"

    }
    if(this.Project.IndividualFileIncludes != null)
    {

            
            #line default
            #line hidden
            this.Write("  <ItemGroup>\r\n");
            
            #line 123 "C:\codebase\v3\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\ProjectFiles\VS2017ProjectFile.tt"

        foreach(var compileIncludeEntry in this.Project.IndividualFileIncludes)
        {

            
            #line default
            #line hidden
            this.Write("    <Compile Include=\"");
            
            #line 127 "C:\codebase\v3\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\ProjectFiles\VS2017ProjectFile.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(compileIncludeEntry));
            
            #line default
            #line hidden
            this.Write("\"/>\r\n");
            
            #line 128 "C:\codebase\v3\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\ProjectFiles\VS2017ProjectFile.tt"

		}

            
            #line default
            #line hidden
            this.Write("  </ItemGroup>\r\n");
            
            #line 132 "C:\codebase\v3\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\ProjectFiles\VS2017ProjectFile.tt"

    }

    if(this.Project.CompileRemoveList != null)
    {

            
            #line default
            #line hidden
            this.Write("  <ItemGroup>\r\n");
            
            #line 139 "C:\codebase\v3\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\ProjectFiles\VS2017ProjectFile.tt"

        foreach(var compileRemoveEntry in this.Project.CompileRemoveList)
        {
		  if(compileRemoveEntry == "bin"||compileRemoveEntry == "obj")
		  {

            
            #line default
            #line hidden
            this.Write("    <Compile Remove=\"**/");
            
            #line 145 "C:\codebase\v3\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\ProjectFiles\VS2017ProjectFile.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(compileRemoveEntry));
            
            #line default
            #line hidden
            this.Write("/**\"/>\r\n\t<None Remove=\"**/");
            
            #line 146 "C:\codebase\v3\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\ProjectFiles\VS2017ProjectFile.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(compileRemoveEntry));
            
            #line default
            #line hidden
            this.Write("/**\" />\r\n");
            
            #line 147 "C:\codebase\v3\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\ProjectFiles\VS2017ProjectFile.tt"

			continue;
		  }

            
            #line default
            #line hidden
            this.Write("    <Compile Remove=\"**/");
            
            #line 151 "C:\codebase\v3\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\ProjectFiles\VS2017ProjectFile.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(compileRemoveEntry));
            
            #line default
            #line hidden
            this.Write("/**\"/>\r\n");
            
            #line 152 "C:\codebase\v3\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\ProjectFiles\VS2017ProjectFile.tt"

        }

            
            #line default
            #line hidden
            this.Write("  </ItemGroup>\r\n\r\n");
            
            #line 157 "C:\codebase\v3\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\ProjectFiles\VS2017ProjectFile.tt"

    }

            
            #line default
            #line hidden
            
            #line 160 "C:\codebase\v3\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\ProjectFiles\VS2017ProjectFile.tt"

    if(this.Project.ProjectReferences != null)
    {

            
            #line default
            #line hidden
            this.Write("  <ItemGroup>\r\n");
            
            #line 165 "C:\codebase\v3\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\ProjectFiles\VS2017ProjectFile.tt"

        foreach(var projectReference in this.Project.ProjectReferences)
        {

            
            #line default
            #line hidden
            this.Write("    <ProjectReference Include=\"");
            
            #line 169 "C:\codebase\v3\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\ProjectFiles\VS2017ProjectFile.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(projectReference.IncludePath));
            
            #line default
            #line hidden
            this.Write("\"/>\r\n");
            
            #line 170 "C:\codebase\v3\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\ProjectFiles\VS2017ProjectFile.tt"

        }

            
            #line default
            #line hidden
            this.Write("  </ItemGroup>\r\n\r\n");
            
            #line 175 "C:\codebase\v3\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\ProjectFiles\VS2017ProjectFile.tt"

    }

            
            #line default
            #line hidden
            
            #line 178 "C:\codebase\v3\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\ProjectFiles\VS2017ProjectFile.tt"

    if(this.Project.PackageReferences != null)
    {

            
            #line default
            #line hidden
            this.Write("  <ItemGroup>\r\n");
            
            #line 183 "C:\codebase\v3\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\ProjectFiles\VS2017ProjectFile.tt"

        foreach(var package in this.Project.PackageReferences)
        {
          if(package.HasPrivateAssets)
          {

            
            #line default
            #line hidden
            this.Write("    <PackageReference Include=\"");
            
            #line 189 "C:\codebase\v3\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\ProjectFiles\VS2017ProjectFile.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(package.Include));
            
            #line default
            #line hidden
            this.Write("\" Version=\"");
            
            #line 189 "C:\codebase\v3\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\ProjectFiles\VS2017ProjectFile.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(package.Version));
            
            #line default
            #line hidden
            this.Write("\">\r\n      <PrivateAssets>");
            
            #line 190 "C:\codebase\v3\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\ProjectFiles\VS2017ProjectFile.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(package.PrivateAssets));
            
            #line default
            #line hidden
            this.Write("</PrivateAssets>\r\n    </PackageReference>\r\n");
            
            #line 192 "C:\codebase\v3\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\ProjectFiles\VS2017ProjectFile.tt"

          }
          else
          {

            
            #line default
            #line hidden
            this.Write("\t  <PackageReference Include=\"");
            
            #line 197 "C:\codebase\v3\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\ProjectFiles\VS2017ProjectFile.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(package.Include));
            
            #line default
            #line hidden
            this.Write("\" Version=\"");
            
            #line 197 "C:\codebase\v3\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\ProjectFiles\VS2017ProjectFile.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(package.Version));
            
            #line default
            #line hidden
            this.Write("\"/>\r\n");
            
            #line 198 "C:\codebase\v3\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\ProjectFiles\VS2017ProjectFile.tt"

			    }
        }

            
            #line default
            #line hidden
            this.Write("  </ItemGroup>\r\n\r\n");
            
            #line 204 "C:\codebase\v3\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\ProjectFiles\VS2017ProjectFile.tt"

    }
    if(this.Project.ReferenceDependencies != null)
    {

            
            #line default
            #line hidden
            this.Write("  <ItemGroup>\r\n");
            
            #line 210 "C:\codebase\v3\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\ProjectFiles\VS2017ProjectFile.tt"

        foreach(var reference in this.Project.ReferenceDependencies)
        {
            if (string.IsNullOrEmpty(reference.HintPath))
            {

            
            #line default
            #line hidden
            this.Write("    <Reference Include=\"");
            
            #line 216 "C:\codebase\v3\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\ProjectFiles\VS2017ProjectFile.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(reference.Name));
            
            #line default
            #line hidden
            this.Write("\"/>\r\n");
            
            #line 217 "C:\codebase\v3\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\ProjectFiles\VS2017ProjectFile.tt"

            }
            else
            {

            
            #line default
            #line hidden
            this.Write("    <Reference Include=\"");
            
            #line 222 "C:\codebase\v3\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\ProjectFiles\VS2017ProjectFile.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(reference.Name));
            
            #line default
            #line hidden
            this.Write("\">\r\n        <HintPath>");
            
            #line 223 "C:\codebase\v3\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\ProjectFiles\VS2017ProjectFile.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(reference.HintPath));
            
            #line default
            #line hidden
            this.Write("</HintPath>\r\n    </Reference>\r\n");
            
            #line 225 "C:\codebase\v3\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\ProjectFiles\VS2017ProjectFile.tt"

            }
        }

            
            #line default
            #line hidden
            this.Write("  </ItemGroup>\r\n\r\n");
            
            #line 231 "C:\codebase\v3\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\ProjectFiles\VS2017ProjectFile.tt"

    }
    if(this.Project.EmbeddedResources != null)
    {

            
            #line default
            #line hidden
            this.Write("  <ItemGroup>\r\n");
            
            #line 237 "C:\codebase\v3\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\ProjectFiles\VS2017ProjectFile.tt"

        foreach(var resource in this.Project.EmbeddedResources)
        {

            
            #line default
            #line hidden
            this.Write("    <EmbeddedResource Include=\"");
            
            #line 241 "C:\codebase\v3\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\ProjectFiles\VS2017ProjectFile.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(resource));
            
            #line default
            #line hidden
            this.Write("\"/>\r\n");
            
            #line 242 "C:\codebase\v3\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\ProjectFiles\VS2017ProjectFile.tt"

        }

            
            #line default
            #line hidden
            this.Write("  </ItemGroup>\r\n");
            
            #line 246 "C:\codebase\v3\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\ProjectFiles\VS2017ProjectFile.tt"

    }

    if(this.Project.Services != null)
    {

            
            #line default
            #line hidden
            this.Write("  <ItemGroup>\r\n");
            
            #line 253 "C:\codebase\v3\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\ProjectFiles\VS2017ProjectFile.tt"

        foreach(var service in this.Project.Services)
        {

            
            #line default
            #line hidden
            this.Write("    <Service Include=\"");
            
            #line 257 "C:\codebase\v3\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\ProjectFiles\VS2017ProjectFile.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(service));
            
            #line default
            #line hidden
            this.Write("\"/>\r\n");
            
            #line 258 "C:\codebase\v3\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\ProjectFiles\VS2017ProjectFile.tt"

        }

            
            #line default
            #line hidden
            this.Write("  </ItemGroup>\r\n");
            
            #line 262 "C:\codebase\v3\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\ProjectFiles\VS2017ProjectFile.tt"

    }

            
            #line default
            #line hidden
            this.Write("</Project>\r\n\r\n");
            return this.GenerationEnvironment.ToString();
        }
        
        #line 267 "C:\codebase\v3\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\ProjectFiles\VS2017ProjectFile.tt"

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
    public class VS2017ProjectFileBase
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
