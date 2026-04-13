using gitPractice1;

var wp = new Waypoint("Nether Hub", "My home base", new Position(x:34, y: 100, z: 45));

var mgr = new WayPointManager();


mgr.Add(wp);

wp = new Waypoint("Home", "Nether base is my home", new Position(x: -120, y: 100, z: 340));
mgr.Add(wp);

var saver = new JSaver(mgr);

saver.Save();
Console.WriteLine("Hello World!");









