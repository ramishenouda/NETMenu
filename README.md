<h1 align="center">
  <a href="https://github.com/ramishenouda/NETMenu">
    NETMenu
  </a>
</h1>

<p align="center">
  <strong>Create a menu for your console projects.</strong><br>
</p>

## Getting Started

These instructions will get you a copy of the project up and running on your local machine for development and testing purposes.

### Prerequisites

- Visual Studio Code or any other code editor

```
https://code.visualstudio.com/
```

- .NET Core SDK

```
https://dotnet.microsoft.com/download
```

- Git

```
https://git-scm.com/
```

### Installing
#### The following instructions will setup the menu into your existing console project.

1. Download the NETMenu.dll file.

```
https://github.com/ramishenouda/NETMenu/raw/master/assets/NETMenu.dll
```

2. Move the NETMenu.dll to the root folder of your project (where Program.cs is), and Open your ```.csproj``` file.

3. Add the following code to the ```.csproj``` file in the ```<Project>``` tag.

```
<Project Sdk="Microsoft.NET.Sdk">
<ItemGroup>
  <Reference Include="NETMenu">
    <HintPath>NETMenu.dll</HintPath>
    <SpecificVersion>False</SpecificVersion> 
  </Reference>
</ItemGroup>
</Project>
```

4. Add using NETMenu; in your code. 

```
using NETMenu;
```

## Cloning

Run the following commands in your terminal. Then use your favo code editor to open the project.

```
https://github.com/ramishenouda/NETMenu.git
cd NETMenu
dotnet restore
```

## Guide
### Examples.
```
Menu HomeMenu = new Menu();

// HomeMenu.AddItems("Play", "Options", "Exit");
HomeMenu.AddItem("Play");
HomeMenu.AddItem("Options");
HomeMenu.AddItem("Exit");

// or call it whatever u want.
int choice = HomeMenu.Start();

if(choice == 0)
    Console.WriteLine("run the play function.");
else if(choice == 1)
    Console.WriteLine("run the options function.");
else // else if(choice == 2)
    Console.WriteLine("run the exit function.");
```

<img src="https://raw.githubusercontent.com/ramishenouda/NETMenu/master/assets/example1.PNG" />

```
Menu HomeMenu = new Menu();

// HomeMenu.AddItems("Play", "Options", "Exit Game");
HomeMenu.AddItem("Play");
HomeMenu.AddItem("Options");
HomeMenu.AddItem("Exit Game");

HomeMenu.SetSelectedTextColor(ConsoleColor.Yellow);
HomeMenu.SetSelectSymbol("=> ");
HomeMenu.SetVerticalPadding(2);
HomeMenu.SetHorizontalPadding(2);

// or call it whatever u want.
int choice = HomeMenu.Start();

if(choice == 0)
    Console.WriteLine("run the play function.");
else if(choice == 1)
    Console.WriteLine("run the options function.");
else // else if(choice == 2)
    Console.WriteLine("run the exit function.");
```

<img src="https://raw.githubusercontent.com/ramishenouda/NETMenu/master/assets/example2.PNG" />


### Documentation

```Start```: Starts the menu.

ReturnType: returns an integer when the user clicks on the Enter key. 0 for the first item, 1 for the second item, and n for the nth item.</br> </br>

```AddItem(string)```: Adds item to the menu list.

```AddItems(string[])```: Adds items to the menu list.

```SetHorizontalPadding(int)```: Adds Horizontal Padding, default is 0.

```SetVerticalPadding(int)```: Adds Vertical Padding. default is 1.

```SetSelectSymbolColor(ConsoleColor)```: Sets the menu symbol color. default is White.

```SetSelectedTextColor(ConsoleColor)```: Sets the selected text color. default is Red.

```SetSelectSymbol(string or char)```: Sets the menu select symbol. default is >.

```CenterText```: Centers the menu text.

```DisableSymbol```: Disables the select symbol.

```EnableCursor```: Enables the cursor.

## Built With

* [ASP.NET core](https://dotnet.microsoft.com/apps/aspnet).

## License

This project is licensed under the MIT License - see the [LICENSE](LICENSE) file for details
