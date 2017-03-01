Synopsis

# PhotoAlbum
A console application that displays photo ids and titles in an remote photo album using JSON.

Installation

Select Clone or Download
Select Download Zip
extract files to a location on your computer and open within Visual Studio

Select to Build the solution from within Visual studio 2015 (VS 2013 has also been tested)
The solution should build and download necessary nuget libraries

Select to Run the Application and the console will open

From the photo album prompt you may enter an integer to retrieve various photo albums

hit return (without entering an integer) to retrieve all albums

type 'quit' to exit the app


Tests

The UnitTest File contains a ConsoleOutput class that the 5 test cases use to push values to the console and retrieve values from the console.
TestMethod1 and TestMethod5 retrieve data from album 1 and all albums respectively.
The output should be examined for each to ensure the test case has passed.

For TestMethod 2, TestMethod3 and TestMethod4 all push invalid data that should result in an error message.  
For TestMethods2, 3 and 4 if the proper error is not returned, the test case will fail.

Contributors

Brian Armstrong
armstb01

License

Free to use



