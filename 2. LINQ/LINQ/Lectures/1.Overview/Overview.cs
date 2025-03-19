using System.Text;

namespace LINQ._1.Overview;

public class Overview {
    public static void MainOverview() {
        // LINQ: Language Independent Query
        // LINQ promise with 40 "query operators" that manipulate data regardless of data store

        // LINQ's four types
        // L2Object, L2XML, L2ADO (ADO is a technology to connect C# with some database(s))
        // L2SQL (Query data on SQL server) -use ORM- -DIED-


        // <<<< WHY LINQ ? >>>>
        // How can you map a database to your code? 
        // Map it yourself ... varchar <==> string, relations, layers ...
        // Or Use ORM(Object-relational mapping) Tools (e.g. 40 LINQ TOOLS) .


        // <<<< WHAT WE USE NOW TO CONNECT BETWEEN DATABASES AND C# CODE ? >>>>
        // from .NetFramework 3.5 SP1(service pack 1.0) we use "Entity Framework" (ORM) L2EF
        // now we use EFCore version (to be explained later)


        // We use L2Object in the following examples ...
        List<int> list = new List<int>();
        // list.FirstOrDefault()
    }
}