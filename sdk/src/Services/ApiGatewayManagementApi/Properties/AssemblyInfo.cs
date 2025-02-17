using System;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;

// General Information about an assembly is controlled through the following 
// set of attributes. Change these attribute values to modify the information
// associated with an assembly.
[assembly: AssemblyTitle("AWSSDK.ApiGatewayManagementApi")]
#if BCL35
[assembly: AssemblyDescription("The Amazon Web Services SDK for .NET (3.5) - AmazonApiGatewayManagementApi. This is the initial SDK release for the Amazon API Gateway Management API, which allows you to directly manage runtime aspects of your APIs. This release makes it easy to send data directly to clients connected to your WebSocket-based APIs.")]
#elif BCL45
[assembly: AssemblyDescription("The Amazon Web Services SDK for .NET (4.5) - AmazonApiGatewayManagementApi. This is the initial SDK release for the Amazon API Gateway Management API, which allows you to directly manage runtime aspects of your APIs. This release makes it easy to send data directly to clients connected to your WebSocket-based APIs.")]
#elif PCL
[assembly: AssemblyDescription("The Amazon Web Services SDK for .NET (PCL) -  AmazonApiGatewayManagementApi. This is the initial SDK release for the Amazon API Gateway Management API, which allows you to directly manage runtime aspects of your APIs. This release makes it easy to send data directly to clients connected to your WebSocket-based APIs.")]
#elif UNITY
[assembly: AssemblyDescription("The Amazon Web Services SDK for .NET (Unity) - AmazonApiGatewayManagementApi. This is the initial SDK release for the Amazon API Gateway Management API, which allows you to directly manage runtime aspects of your APIs. This release makes it easy to send data directly to clients connected to your WebSocket-based APIs.")]
#elif NETSTANDARD13
[assembly: AssemblyDescription("The Amazon Web Services SDK for .NET (NetStandard 1.3)- AmazonApiGatewayManagementApi. This is the initial SDK release for the Amazon API Gateway Management API, which allows you to directly manage runtime aspects of your APIs. This release makes it easy to send data directly to clients connected to your WebSocket-based APIs.")]
#elif NETSTANDARD20
[assembly: AssemblyDescription("The Amazon Web Services SDK for .NET (NetStandard 2.0)- AmazonApiGatewayManagementApi. This is the initial SDK release for the Amazon API Gateway Management API, which allows you to directly manage runtime aspects of your APIs. This release makes it easy to send data directly to clients connected to your WebSocket-based APIs.")]
#else
#error Unknown platform constant - unable to set correct AssemblyDescription
#endif

[assembly: AssemblyConfiguration("")]
[assembly: AssemblyProduct("Amazon Web Services SDK for .NET")]
[assembly: AssemblyCompany("Amazon.com, Inc")]
[assembly: AssemblyCopyright("Copyright 2009-2019 Amazon.com, Inc. or its affiliates. All Rights Reserved.")]
[assembly: AssemblyTrademark("")]
[assembly: AssemblyCulture("")]

// Setting ComVisible to false makes the types in this assembly not visible 
// to COM components.  If you need to access a type in this assembly from 
// COM, set the ComVisible attribute to true on that type.
[assembly: ComVisible(false)]

// Version information for an assembly consists of the following four values:
//
//      Major Version
//      Minor Version 
//      Build Number
//      Revision
//
// You can specify all the values or you can default the Build and Revision Numbers 
// by using the '*' as shown below:
// [assembly: AssemblyVersion("1.0.*")]
[assembly: AssemblyVersion("3.3")]
[assembly: AssemblyFileVersion("3.3.100.65")]

#if WINDOWS_PHONE || UNITY
[assembly: System.CLSCompliant(false)]
# else
[assembly: System.CLSCompliant(true)]
#endif

#if BCL
[assembly: System.Security.AllowPartiallyTrustedCallers]
#endif