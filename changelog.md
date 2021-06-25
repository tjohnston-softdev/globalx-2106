# Changelog

**./Tasks/InputArgs.cs - readInputPath**
* Revised function to use a try-catch structure.
* Removed "ERROR" prefix from input path error message.
	* It will be added back later.

---

**./Tasks/ReadInputFile.cs - ValidateSize**
* Split the size validation IF structure to its own function 'CheckBytes'
	* This does not use a try-catch structure, but exceptions are thrown.
* The 'inpInfo' variable is declared as null.
* Revised function to use a try-catch structure.
	* This includes different exceptions as supported by documentation.
	* Most of them only use placeholders for now.

---

**./Program.cs**
* Variables are assigned and declared on separate lines.
* Revised to use try-catch structure.
	* All errors will eventually end up here.
	* Message will be displayed to console.
* If the script is successful, a corresponding message will be output to console.
