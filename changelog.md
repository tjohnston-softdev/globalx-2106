# Changelog

**./Tasks/ReadInputFile.cs**
* Imported 'System.Text'
* Wrote new function 'GetLines'
	* Reads input file as an array of lines.
	* Uses a try-catch structure, but no custom error messages for now.
* Changes to 'ValidateSize'
	* Commented out system exceptions.
	* With generic exceptions, a new error is thrown using the caught message.
	* No more warnings on compile.
* Wrote new function 'DemoLines'
	* Displays first and last lines from input file.
	* Used for debugging.

---

**./Program.cs**
* Declared new variable 'inputLines'
	* Array of input file lines.
* Added calls to 'ReadInputFile'
	* GetLines
	* DemoLines
