# Changelog

**./Common/Person.cs**
* New file - Contains Person class.
	* ID
	* Last name
	* Given name(s)
* Static constructors for different name structures
	* First only
	* First and Last
	* First, Middle, and Last

---

**./Tasks/ParseNames.cs**
* New file - Used to parse name lines.
* While a person can only have up to three given names, the class can support more.

---

**./Program.cs**
* Imported:
	* System.Collections.Generic
	* globalX.Common
* Removed 'ReadInputFile.DemoLines' call.
* Declared new variable 'peopleEntries'
	* Contains parsed name entries.
* Added call to 'ParseNames'
* On success, the number of parsed entries is displayed.
