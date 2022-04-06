using ConsoleApp1;

Plane planeBoeing7779 = new Plane("Boeing-777-9", 425, 0, 950, 6);
List<IMovable> movables = new List<IMovable>() { planeBoeing7779, new Car("SSC Tuatara", 2, 0, 443, 4) };
List<IFlyable> flyables = new List<IFlyable>() { planeBoeing7779 };

foreach (IFlyable flyable in flyables)
    flyable.TakeOff();

foreach (IMovable movable in movables)
    movable.MoveForward();

planeBoeing7779.Land();

foreach (IMovable movable in movables)
    movable.MoveBackward();