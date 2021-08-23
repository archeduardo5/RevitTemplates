<h3 align="center"><img src="https://i.imgur.com/wkZAO9B.png" width="500px"></h3>

Create your add-in for Revit on the .Net platform now.
==================================================
<p align="center">
  <a href="https://github.com/Nice3point/RevitTemplate/issues"><img src="https://img.shields.io/github/issues/Nice3point/RevitTemplate"></a>
  <a href="https://github.com/Nice3point/RevitTemplate/commits/main"><img src="https://img.shields.io/github/last-commit/Nice3point/RevitTemplate"></a>
</p>
This repository contains a project template for creating Revit Add-ins.

Template Features
------------
* Supported IDEs
  * JetBrains Rider
* Platforms
  * .Net Framework
  * .Net Core
* Revit Versions
  * 2019
  * 2020
  * 2021
  * 2022
* Package content
  * AddIn template
  * Installer template
  * Nuke builder template
  
Installation
------------

**Rider**:
1. Download the project
1. Click the New Solution button
1. Go to the More Templates section
1. Select template folder
1. Click Reload Button

Usage
------------

Not everything is automated now. Here are some things to do after creating a new project:

Switch the project manager from **Solution** to **File System**

AddIn: 
* Move the **.run** folder from the .csproj folder to the .sln folder.
* By default, **VendorId** and **AssemblyCompany** are set to **"CompanyName"**. To replace this field with your own value, press the key combination **Ctrl + Shift + R**

Installer:
* Rename the installer name in the **Installer.cs** file.
* Rename the output name in the **Installer.cs** file.

Builder: 
* Rename the solution name in the **parameters.json** file.
* Rename the project names in the **Build.Properties.cs** file.
* Move the **.nuke** folder from the .csproj folder to the .sln folder.
* If you are using CI, the project has a customized **azure-pipelines.yml** file and a **.github** folder. Move them to the root of the solution if needed.

The final step is to remove all builder configurations and Debug installer configuration in the **.sln** file.