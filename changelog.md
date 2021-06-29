# Changelog

**./NameSorter/Program.cs**
* Swapped variable order: 'outputFilePath' and 'sortOrderFlag'
	* 'sortOrderFlag' is now the second argument.
* After all arguments are read, they are displayed to console.

---

**./NameSorter/Tasks/InputArgs.cs**
* Swapped function order: 'ReadOutputPath' and 'ReadOrderFlag'
* Added comment to 'ReadOrderFlag'
* Changed argument array elements:
	* 'ReadOrderFlag' now reads index 1
	* 'ReadOutputPath' now reads index 2
* Removed `Console.WriteLine` from 'ReadOrderFlag'
