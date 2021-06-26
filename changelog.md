# Changelog

**./NameSorter/Tasks/WriteOutputFile.cs**
* New file - Used to write sorted names to output file.
* Separate functions for:
	* Writing the name lines.
	* Saving text lines to file.

---

**./NameSorter/Tasks/SortNames.cs**
* Removed 'DisplaySortResults' function.
	* Used as the basis for 'SaveResults' in 'WriteOutputFile.cs'

---

**./NameSorter/Program.cs**
* Declared variables:
	* outputLines
	* resultsSaved
* Added calls to 'WriteOutputFile'
	* PrepareLines
	* SaveResults
* Removed the 'SortNames.DisplaySortResults' call.
* On successful completion, a "Save" message will be shown.
