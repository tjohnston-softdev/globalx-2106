# Changelog

**./Tasks/InputArg.cs**
* New file - Contains functions to read script arguments.
	* Input path (Required)
	* Output path (Optional)
* If the input path is missing, a custom error will be thrown.
* If the output path is missing, a default is used instead.

---

**./Program.cs**
* Imported 'globalX.Tasks'
* Renamed 'args' to 'scriptArgs'
* Calls 'InputArg' class to parse and display path arguments.
