# Changelog

**Summary**
* Added script argument to sort output order.
	* Positive numbers in ASC (A-Z)
	* Non-Positive numbers in DESC (Z-A)
	* Optional (Default: Positive)

---

**./NameSorter/Program.cs**
* Declared 'sortOrderFlag' variable for corresponding argument.

---

**./NameSorter/Tasks/InputArgs.cs**
* Wrote new function 'ReadOrderFlag'
	* Parses sort order argument.

---

**./NameSorter/Tasks/SortNames.cs**
* Added 'sortOrdFlag' parameter.
	* Does not affect sort order as of yet.