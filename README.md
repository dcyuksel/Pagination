# Pagination
Pagination in C#
Pagination is essential in almost all applications that display data.

Imagine you have a table with thousands of rows and only a list in the UI to show them.

Querying all rows every time someone loads the page not only consumes memory and increases the size of the HTTP call, but it also drastically decreases performance.

Instead of querying all the data, pagination can be used. With the page number and page size, data can be loaded to the UI in smaller chunks. With some ordering and filtering, it is even possible to query only the relevant data.
