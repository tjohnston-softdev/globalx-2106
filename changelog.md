# Changelog

**./Common/ErrorMessages.cs**
* New file - Writes common error messages.
	* File-system related.
	* Input file size.

---

**./Tasks/ReadInputFile.cs**
* Imported 'globalX.Common'
* Removed the 'DemoLines' function.
* ValidateSize
	* Renamed 'inpPath' parameter to 'inpFilePath'
	* Split the 'FileInfo' call into its own function 'GetBytes'
		* Retrieves file size and not the full object.
		* Uses file-system error messages.
	* Removed commented out `catch` blocks.
		* These are now covered by 'GetBytes'
	* Removed 'inpInfo' variable.
	* Declared 'retrievedSize' variable.
	* Renamed 'otherErr' `catch` parameter to 'validErr'
	* Replaced 'inpInfo.Length' with 'retrievedSize'
* GetLines
	* Added 'linesErr' `catch` parameter.
	* Declared 'fileErrMsg' variable.
	* Renamed 'inpPath' parameter to 'inpFilePath'

---

**./Program.cs**
* Commented out calls to:
	* ParseNames
	* SortNames
* Added prefix to displayed error messages.
* Changed 'ReadInputFile.GetLines' call path to a non-existent file.
