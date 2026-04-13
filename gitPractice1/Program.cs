using gitPractice1;

var wp = new Waypoint("Nether Hub", "My home base", new Position(x:34, y: 100, z: 45));

var mgr = new WayPointManager();


mgr.Add(wp);

Console.WriteLine(wp.Name);
Console.WriteLine(wp.Description);
Console.WriteLine(wp.Position.X);
Console.WriteLine(wp.Position.Y);
Console.WriteLine(wp.Position.Z);

Console.WriteLine(mgr.Waypoints.Count);

