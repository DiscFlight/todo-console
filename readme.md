# **Todo Console**
### - Built with .NET 7


## Get Started
1. Clone the repository
2. Build the project with your prefered method
3. (Optional) Add '{Project_Directory}\bin\Debug\net7.0' to you PATH or equivilent in other environments than Windows.
4. Open a terminal at the path above (or any directory if the PATH has been added) and start using the Todo Console application


## Syntax
The default syntax is the following:

```console
todo {command} {argument}
```


## Commands
#### `list`
This shows you all your Todo items in a table. 

Default command (this will run if you just enter `todo`)


Shortcuts: `l`

Arguments: none

#### Example result:
```console
┌────┬────────┬──────┐
│ Id │ Todo   │ Done │
├────┼────────┼──────┤
│ 1  │  Test  │ No   │
│ 2  │  Test2 │ No   │
│ 3  │  Test3 │ Yes  │
└────┴────────┴──────┘
```

#### `show`
This shows you the Todo item that you specified.


Shortcuts: `show`

Arguments: `id` - Id of the Todo item.


#### Example result:
```console
Id: 1  Name:  Test     Done: Yes
```

#### `add`
Adds a new Todo item to your list.


Shortcuts: `a`

Arguments: `description` - Description of the action needed to mark this as Done. Quotation marks is not needed for longer descriptions.


#### Example result:
```console
Test has been added to your list of todos.
```

#### `done`
Marks a Todo item as Done.


Shortcuts: `d`

Arguments: `id` - Id of the Todo item.


#### Example result:
```console
Test is done, good job!
```

#### `remove`
Removes a Todo item from your list.


Shortcuts: `r`

Arguments: `id` - Id of the Todo item.


#### Example result:
```console
Test has been removed.
```

## Dependencies
- Newtonsoft.Json
- Spectre Console
