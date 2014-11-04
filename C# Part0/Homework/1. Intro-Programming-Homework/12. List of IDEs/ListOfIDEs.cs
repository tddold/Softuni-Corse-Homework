﻿// Perform a research (e.g. in Google or Wikipedia) and provide a short list with popular development environments (IDEs) like Visual Studio. Write in a text file called “list-of-IDEs.txt” at least five IDEs along with 2-3 sentences about each of them. Use English.

using System;

class ListOfIDEs
{
    static void Main()
    {
        Console.SetWindowSize(100, 40);
        Console.SetBufferSize(100, 44);

        string visualStudio =
            @"Microsoft Visual Studio is an integrated development environment (IDE) from Microsoft. It is used to develop computer programs for Microsoft Windows, as well as web sites, web applications and web services. Visual Studio uses Microsoft software development platforms such as Windows API, Windows Forms, Windows Presentation Foundation, Windows Store and Microsoft Silverlight. It can produce both native code and managed code.
Visual Studio includes a code editor supporting IntelliSense as well as code refactoring. The integrated debugger works both as a source-level debugger and a machine-level debugger. Other built-in tools include a forms designer for building GUI applications, web designer, class designer, and database schema designer. It accepts plug-ins that enhance the functionality at almost every level—including adding support for source-control systems (like Subversion) and adding new toolsets like editors and visual designers for domain-specific languages or toolsets for other aspects of the software development lifecycle (like the Team Foundation Server client: Team Explorer).
Visual Studio supports different programming languages and allows the code editor and debugger to support (to varying degrees) nearly any programming language, provided a language-specific service exists. Built-in languages include C, C++ and C++/CLI (via Visual C++), VB.NET (via Visual Basic .NET), C# (via Visual C#), and F# (as of Visual Studio 2010. Support for other languages such as M, Python, and Ruby among others is available via language services installed separately. It also supports XML/XSLT, HTML/XHTML, JavaScript and CSS.";

        string eclips =
            @"In computer programming, Eclipse is an integrated development environment (IDE). It contains a base workspace and an extensible plug-in system for customizing the environment. Written mostly in Java, Eclipse can be used to develop applications. By means of various plug-ins, Eclipse may also be used to develop applications in other programming languages: C, C++, JavaScript, Perl, PHP, Python, Ruby (including Ruby on Rails framework), among others.";

        string netBeans =
            @"NetBeans is an integrated development environment (IDE) for developing primarily with Java, but also with other languages, in particular PHP, C/C++, and HTML5.[3] It is also an application platform framework for Java desktop applications and others.
The NetBeans IDE is written in Java and can run on Windows, OS X, Linux, Solaris and other platforms supporting a compatible JVM.
The NetBeans Platform allows applications to be developed from a set of modular software components called modules. Applications based on the NetBeans Platform (including the NetBeans IDE itself) can be extended by third party developers.";

        string webStorm =
            @"JetBrains WebStorm is a commercial IDE for JavaScript, CSS & HTML built on JetBrains' IntelliJ IDEA platform. WebStorm is a specialized version of PhpStorm, offering a subset of its features. WebStorm ships with pre-installed JavaScript plugins (such as for Node.js), which are available for PhpStorm as well at no cost.
WebStorm provides automatic code completion, on-the-fly code analysis, refactoring support and VCS integration. Supported languages are JavaScript, CoffeeScript, TypeScript and Dart.";

        PrintText("VS", visualStudio);
        PrintText("Eclips", eclips);
        PrintText("NetBeans", netBeans);
        PrintText("WebStorm", webStorm);
        Console.ReadKey();
    }

    static void PrintText(string title, string bodyText)
    {
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine(title + ": ");

        Console.ForegroundColor = ConsoleColor.White;
        Console.WriteLine(bodyText);
    }
}