using Delegate;

Predicate<Tuple<int, int, int>> predicate = Class.isTriangle;
Tuple<int, int, int> x = new Tuple<int, int, int>(3, 4, 5);

// Console.WriteLine(Class.isTriangle(x));

MyEvent myEvent = new MyEvent();
//myEvent.LeetsGoo();

MyEvent myEvent1 = new MyEvent();
