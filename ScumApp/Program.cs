using ScrumLib.model;

Console.WriteLine("Hello, World!");

Person p  = new Person("able", "Ab@ab.dk");

Console.WriteLine(p);

ProductOwner po = new ProductOwner("fds", "fd@g.dk", "Jizzy AS");
Console.WriteLine(po);

ScrumMember sm = new ScrumMember("hl", "global@gl.dk", "4324234");
Console.WriteLine(sm);

TeamMember tm = new TeamMember("læ", "læ@g.dk", "23242342342324", "developer");
Console.WriteLine(tm);