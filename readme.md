# GlobalX Coding Assessment

## Introduction
This is my submission for the 'GlobalX Coding Assessment' offered to shortlisted job candidates as of June 2021. The basic objective is to create a .NET Core application that takes a list of names inside a text file and sorts them according to last name (A-Z)

Assessment instructions were sent as a PDF. I converted it to a [markdown file](./instructions.md) for public viewing.

## Running

To run the script, navigate to the 'NameSorter' folder and execute:  
`dotnet run ./unsorted-names-list.txt`

You can also optionally specify an output path but the default will be 'sorted-names-list.txt'

For the unit tests, I chose to use [NUnit](https://docs.microsoft.com/en-us/dotnet/core/testing/unit-testing-with-nunit). To run them, navigate to the project root and execute `dotnet test`

## Disclaimer

This project is licensed under [CC BY-NC-SA 4.0](https://creativecommons.org/licenses/by-nc-sa/4.0/). In other words, you may do whatever you want with it as long as:

* Attribution is given.
* The use is strictly non-commercial.
* Any derived works are shared under the same license.


![CC BY-NC-SA 4.0](https://i.creativecommons.org/l/by-nc-sa/4.0/88x31.png)
