using gitPractice1;

var wp = new Waypoint("House", "My home base", new Position(0, 0, 0));
var wp2 = new Waypoint("Mine", "My diamond mine", new Position(100, 400, -34));

var myManager = new WaypointManager();
myManager.Add(wp);
myManager.Add(wp2);

var fileService = new WaypointFileService(@"C:\Users\Tony\RiderProjects\gitPractice1\Waypoints.json", myManager);
fileService.Save();



