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
    using System.IO;
    using System.Collections.Generic;
    using System;
    
    /// <summary>
    /// Class to produce the template output
    /// </summary>
    
    #line 1 "C:\codebase\v3\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\ProjectFiles\UnitTestProjectFile.tt"
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.TextTemplating", "16.0.0.0")]
    public partial class UnitTestProjectFile : UnitTestProjectFileBase
    {
#line hidden
        /// <summary>
        /// Create the template output
        /// </summary>
        public virtual string TransformText()
        {
            this.Write(@"<?xml version=""1.0"" encoding=""utf-8""?>
<Project ToolsVersion=""12.0"" DefaultTargets=""Build"" xmlns=""http://schemas.microsoft.com/developer/msbuild/2003"">
  <PropertyGroup>
    <Configuration Condition="" '$(Configuration)' == '' "">Debug</Configuration>
    <Platform Condition="" '$(Platform)' == '' "">AnyCPU</Platform>
    <ProjectGuid>");
            
            #line 11 "C:\codebase\v3\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\ProjectFiles\UnitTestProjectFile.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(this.Session["ProjectGuid"]));
            
            #line default
            #line hidden
            this.Write("</ProjectGuid>\r\n    <OutputType>Library</OutputType>\r\n    <AppDesignerFolder>Prop" +
                    "erties</AppDesignerFolder>\r\n    <RootNamespace>");
            
            #line 14 "C:\codebase\v3\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\ProjectFiles\UnitTestProjectFile.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(this.Session["RootNamespace"]));
            
            #line default
            #line hidden
            this.Write("</RootNamespace>\r\n    <AssemblyName>");
            
            #line 15 "C:\codebase\v3\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\ProjectFiles\UnitTestProjectFile.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(this.Session["AssemblyName"]));
            
            #line default
            #line hidden
            this.Write(@"</AssemblyName>
    <TargetFrameworkVersion>v4.5</TargetFrameworkVersion>
    <FileAlignment>512</FileAlignment>
    <ProjectTypeGuids>{3AC096D0-A1C2-E12C-1390-A8335801FDAB};{FAE04EC0-301F-11D3-BF4B-00C04F79EFBC}</ProjectTypeGuids>
    <VisualStudioVersion Condition=""'$(VisualStudioVersion)' == ''"">10.0</VisualStudioVersion>
    <VSToolsPath Condition=""'$(VSToolsPath)' == ''"">$(MSBuildExtensionsPath32)\Microsoft\VisualStudio\v$(VisualStudioVersion)</VSToolsPath>
    <ReferencePath>$(ProgramFiles)\Common Files\microsoft shared\VSTT\$(VisualStudioVersion)\UITestExtensionPackages</ReferencePath>
    <IsCodedUITest>False</IsCodedUITest>
    <TestProjectType>UnitTest</TestProjectType>
    <TargetFrameworkProfile />
    <ReferenceServiceDLLs Condition=""'$(ReferenceServiceDLLs)'==''"">false</ReferenceServiceDLLs>
  </PropertyGroup>

  <PropertyGroup Condition="" '$(Configuration)|$(Platform)' == 'Debug|AnyCPU' "">
    <DebugSymbols>true</DebugSymbols>
    <DebugType>full</DebugType>
    <Optimize>false</Optimize>
    <OutputPath>");
            
            #line 32 "C:\codebase\v3\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\ProjectFiles\UnitTestProjectFile.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(this.Session["DebugOutputPath"]));
            
            #line default
            #line hidden
            this.Write("</OutputPath>\r\n    <DefineConstants>");
            
            #line 33 "C:\codebase\v3\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\ProjectFiles\UnitTestProjectFile.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(this.Session["DebugDefineConstants"]));
            
            #line default
            #line hidden
            this.Write(@"</DefineConstants>
    <ErrorReport>prompt</ErrorReport>
    <WarningLevel>4</WarningLevel>
    <Prefer32Bit>false</Prefer32Bit>
  </PropertyGroup>
  <PropertyGroup Condition="" '$(Configuration)|$(Platform)' == 'Release|AnyCPU' "">
    <DebugType>pdbonly</DebugType>
    <Optimize>true</Optimize>
    <OutputPath>");
            
            #line 41 "C:\codebase\v3\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\ProjectFiles\UnitTestProjectFile.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(this.Session["ReleaseOutputPath"]));
            
            #line default
            #line hidden
            this.Write("</OutputPath>\r\n    <DefineConstants>");
            
            #line 42 "C:\codebase\v3\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\ProjectFiles\UnitTestProjectFile.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(this.Session["ReleaseDefineConstants"]));
            
            #line default
            #line hidden
            this.Write(@"</DefineConstants>
    <ErrorReport>prompt</ErrorReport>
    <WarningLevel>4</WarningLevel>
    <Prefer32Bit>false</Prefer32Bit>
  </PropertyGroup>
  <ItemGroup>
    <Reference Include=""System"" />
    <Reference Include=""System.Configuration"" />
    <Reference Include=""System.XML"" />
    <Reference Include=""System.Xml.Linq"" />
");
            
            #line 52 "C:\codebase\v3\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\ProjectFiles\UnitTestProjectFile.tt"

	IList<string> references = this.Session["Reference"] as IList<string>;
	if (references != null)
	{
		foreach(var reference in references)
		{

            
            #line default
            #line hidden
            this.Write("    <Reference Include=\"");
            
            #line 59 "C:\codebase\v3\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\ProjectFiles\UnitTestProjectFile.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(reference));
            
            #line default
            #line hidden
            this.Write("\" />\r\n");
            
            #line 60 "C:\codebase\v3\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\ProjectFiles\UnitTestProjectFile.tt"

		}
	}

            
            #line default
            #line hidden
            this.Write(@"  </ItemGroup>
  <ItemGroup>
    <Reference Include=""Microsoft.VisualStudio.QualityTools.UnitTestFramework"" />
  </ItemGroup>
  <ItemGroup>
    <Compile Include=""Generated\Customizations\*\*.cs"" />
    <Compile Include=""Generated\Marshalling\*.cs"" />
    <Compile Include=""Custom\*\*\*.cs"" />
    <Compile Include=""Custom\*\*.cs"" />
    <Compile Include=""Custom\*.cs"" />
");
            
            #line 74 "C:\codebase\v3\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\ProjectFiles\UnitTestProjectFile.tt"
 
	IList<string> compileInclude =  this.Session["CompileInclude"] as IList<string>;
	if(compileInclude != null)
	{
		foreach(var entry in compileInclude)
		{

            
            #line default
            #line hidden
            this.Write("    <Compile Include=\"");
            
            #line 81 "C:\codebase\v3\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\ProjectFiles\UnitTestProjectFile.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(entry));
            
            #line default
            #line hidden
            this.Write("\" />\r\n");
            
            #line 82 "C:\codebase\v3\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\ProjectFiles\UnitTestProjectFile.tt"

		}
	}

            
            #line default
            #line hidden
            this.Write("  </ItemGroup>\r\n");
            
            #line 87 "C:\codebase\v3\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\ProjectFiles\UnitTestProjectFile.tt"

	IList<ProjectFileCreator.ProjectReference> commonReferences = this.Session["CommonReferences"] as IList<ProjectFileCreator.ProjectReference>;
	if (commonReferences != null)
	{

            
            #line default
            #line hidden
            this.Write("  <ItemGroup>\r\n");
            
            #line 93 "C:\codebase\v3\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\ProjectFiles\UnitTestProjectFile.tt"

		foreach(var reference in commonReferences)
		{

            
            #line default
            #line hidden
            this.Write("    <ProjectReference Include=\"");
            
            #line 97 "C:\codebase\v3\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\ProjectFiles\UnitTestProjectFile.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(reference.IncludePath));
            
            #line default
            #line hidden
            this.Write("\">\r\n      <Project>");
            
            #line 98 "C:\codebase\v3\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\ProjectFiles\UnitTestProjectFile.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(reference.ProjectGuid));
            
            #line default
            #line hidden
            this.Write("</Project>\r\n      <Name>");
            
            #line 99 "C:\codebase\v3\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\ProjectFiles\UnitTestProjectFile.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(reference.Name));
            
            #line default
            #line hidden
            this.Write("</Name>\r\n    </ProjectReference>\r\n");
            
            #line 101 "C:\codebase\v3\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\ProjectFiles\UnitTestProjectFile.tt"

		}

            
            #line default
            #line hidden
            this.Write("  </ItemGroup>\r\n");
            
            #line 105 "C:\codebase\v3\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\ProjectFiles\UnitTestProjectFile.tt"

	}
	
	IList<ProjectFileCreator.ProjectReference> serviceReferences = this.Session["ServiceProjectReferences"] as IList<ProjectFileCreator.ProjectReference>;
	if (serviceReferences != null)
	{

            
            #line default
            #line hidden
            this.Write("  <ItemGroup>\r\n");
            
            #line 113 "C:\codebase\v3\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\ProjectFiles\UnitTestProjectFile.tt"

		foreach(var reference in serviceReferences)
		{

            
            #line default
            #line hidden
            this.Write("    <ProjectReference Include=\"");
            
            #line 117 "C:\codebase\v3\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\ProjectFiles\UnitTestProjectFile.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(reference.IncludePath));
            
            #line default
            #line hidden
            this.Write("\">\r\n      <Project>");
            
            #line 118 "C:\codebase\v3\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\ProjectFiles\UnitTestProjectFile.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(reference.ProjectGuid));
            
            #line default
            #line hidden
            this.Write("</Project>\r\n      <Name>");
            
            #line 119 "C:\codebase\v3\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\ProjectFiles\UnitTestProjectFile.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(reference.Name));
            
            #line default
            #line hidden
            this.Write("</Name>\r\n    </ProjectReference>\r\n");
            
            #line 121 "C:\codebase\v3\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\ProjectFiles\UnitTestProjectFile.tt"

		}

            
            #line default
            #line hidden
            this.Write("  </ItemGroup>\r\n");
            
            #line 125 "C:\codebase\v3\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\ProjectFiles\UnitTestProjectFile.tt"

	}

            
            #line default
            #line hidden
            this.Write("  <ItemGroup>\r\n    <ProjectReference Include=\"..\\..\\..\\generator\\ServiceClientGen" +
                    "eratorLib\\ServiceClientGeneratorLib.csproj\">\r\n      <Project>{7BEE7C44-BE12-43CC" +
                    "-AFB9-B5852A1F43C8}</Project>\r\n      <Name>ServiceClientGeneratorLib</Name>\r\n   " +
                    " </ProjectReference>\r\n  </ItemGroup>\r\n  <ItemGroup>\r\n    <Service Include=\"{5083" +
                    "49B6-6B84-4DF5-91F0-309BEEBAD82D}\" />\r\n  </ItemGroup>\r\n  <ItemGroup>\r\n    <None " +
                    "Include=\"App.config\" />\r\n  </ItemGroup>\r\n  <Choose>\r\n    <When Condition=\"\'$(Vis" +
                    "ualStudioVersion)\' == \'10.0\' And \'$(IsCodedUITest)\' == \'True\'\">\r\n      <ItemGrou" +
                    "p>\r\n        <Reference Include=\"Microsoft.VisualStudio.QualityTools.CodedUITestF" +
                    "ramework, Version=10.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a, pr" +
                    "ocessorArchitecture=MSIL\">\r\n          <Private>False</Private>\r\n        </Refere" +
                    "nce>\r\n        <Reference Include=\"Microsoft.VisualStudio.TestTools.UITest.Common" +
                    ", Version=10.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a, processorA" +
                    "rchitecture=MSIL\">\r\n          <Private>False</Private>\r\n        </Reference>\r\n  " +
                    "      <Reference Include=\"Microsoft.VisualStudio.TestTools.UITest.Extension, Ver" +
                    "sion=10.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a, processorArchit" +
                    "ecture=MSIL\">\r\n          <Private>False</Private>\r\n        </Reference>\r\n       " +
                    " <Reference Include=\"Microsoft.VisualStudio.TestTools.UITesting, Version=10.0.0." +
                    "0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a, processorArchitecture=MSIL\"" +
                    ">\r\n          <Private>False</Private>\r\n        </Reference>\r\n      </ItemGroup>\r" +
                    "\n    </When>\r\n  </Choose>\r\n  <Import Project=\"$(VSToolsPath)\\TeamTest\\Microsoft." +
                    "TestTools.targets\" Condition=\"Exists(\'$(VSToolsPath)\\TeamTest\\Microsoft.TestTool" +
                    "s.targets\')\" />\r\n  <Import Project=\"$(MSBuildToolsPath)\\Microsoft.CSharp.targets" +
                    "\" />\r\n  <!-- To modify your build process, add your task inside one of the targe" +
                    "ts below and uncomment it. \r\n       Other similar extension points exist, see Mi" +
                    "crosoft.Common.targets.\r\n  <Target Name=\"BeforeBuild\">\r\n  </Target>\r\n  <Target N" +
                    "ame=\"AfterBuild\">\r\n  </Target>\r\n  -->\r\n</Project>");
            return this.GenerationEnvironment.ToString();
        }
    }
    
    #line default
    #line hidden
    #region Base class
    /// <summary>
    /// Base class for this transformation
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.TextTemplating", "16.0.0.0")]
    public class UnitTestProjectFileBase
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
