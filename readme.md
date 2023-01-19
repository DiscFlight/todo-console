# **Todo Console**
### - Built with .NET 7

## Get Started
1. Clone the repository
2. Build the project with your prefered method
3. (Optional) Add '{Project_Directory}\bin\Debug\net7.0' to you PATH or equivilent in other environments than Windows.
4. Open a terminal at the path above (or any directory if the PATH has been added) and start using the Todo Console application

----------

## Syntax
The default syntax is the following:

```console
todo {command} {argument}
```

----------

## Commands
### list
This shows you all your Todo items in a table.
Default command (this will run if you just enter `todo`)

Shortcuts: `l`
Arguments: none

Example result:
```console
┌────┬────────┬──────┐
│ Id │ Todo   │ Done │
├────┼────────┼──────┤
│ 1  │  Test1 │ Yes  │
│ 2  │  Test2 │ No   │
│ 3  │  Test3 │ No   │
└────┴────────┴──────┘
```

### show
This shows you the Todo item that you specified.

Shortcuts: `s`
Arguments: `id` - The Id of the Todo item.

Example result:
```console
Id: 1  Name:  Test1     Done: Yes
```

### add
Adds a new Todo item to your list.

Shortcuts: `a`
Arguments: `description` - Description of the action needed to mark this as Done. Quotation marks is not needed for longer descriptions.

Example result:
```console
Test4 has been added to your list of todos.
```

----------

## Dependencies
- Newtonsoft.Json
- Spectre Console
