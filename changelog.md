# Changelog

**./Tasks/ReadInputFile.cs**
* New file - Functions to read input text file.
	* Currently only validates size.
	* Max size is 1MB
	* Different error messages for 'Too large' and 'Empty'

---

**./Program.cs**
* Calls input file size validation.
* Console displays size validation result instead of path arguments.
