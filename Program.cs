static string PolygonSides1(int sideNum)                         // Declaring a method / function with a return type of string.
{
    if (sideNum > 3)                                                         // Boolean condition that is to be evaluated.
    {
        return "This shape is a polygon";                           // If condition is true, this statement is returned.
    }
    else
    {

        return "The shape is not a polygon";                     // Otherwise this statement is returned.
    }

}
string sideNum = (PolygonSides1(4));               // Usage: Notice that "SideNum" can be used again here because
Console.WriteLine(sideNum);                                      //first usage is not in scope. 