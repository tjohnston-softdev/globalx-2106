# Changelog

**./NameSorter/Tasks/DisplaySortedLines.cs**
* New file - Used to display output lines to console.

---

**./NameSorter/Program.cs**
* On successful completion, 'DisplaySortedLines.Display' is called.
* Split to new function 'CallInputRead'
	* 'inputLines' variable.
	* ReadInputFile.GetLines
	* ParseNames.IterateLines
* 'peopleEntries' is now assigned using 'CallInputRead'
