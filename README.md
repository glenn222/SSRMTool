SYDE 322 - Software Design Project
Spreading Scanning Resistance Microscopy (SSRM) Tool

Group Members:
- Oberon Dixon-Luinenburg
- Tuba Opel
- Glendon Ngo

The SSRM Tool was developed in the C# .NET framework. SSRMTool.sln contains the entire solution with 3 projects. The solution is divided into 3 separate projects containing the implementations for the user interface, data processing, and data storage layers respectively.

Projects:

SSRMToolUI - User Interface using Windows Forms

SSRMTool - Data Processing Layer

SSRMToolDB - Data Storage Layer

Setup Instructions:
1) Install the Redis 3.2.1 database server for Windows from this link:

https://github.com/MSOpenTech/redis/releases/.../win-3.2.100/Redis-x64-3.2.100.msi

2) Install the Gwyddion Application. More information can be found here:

http://gwyddion.net/download.php

If you are using a windows machine, Gwyddion 2.47 is preferred, the link to the installer is below:

https://sourceforge.net/projects/gwyddion/files/gwyddion/2.47/Gwyddion-2.47.win32.exe/download

3) Build the project in Visual Studio.

Build the solution after opening the SSRMTool.sln file.

Executables are located in the Debug/Release folder of the SSRMToolUI folder.
