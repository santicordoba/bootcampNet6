//PILAS

var miPila = new Stack<int>();

miPila.Push(3);
miPila.Push(6);
miPila.Push(9);
miPila.Push(12);

Console.WriteLine(miPila.Pop());

//COLA

var cola = new Queue<int>();

cola.Enqueue(5);
cola.Enqueue(7);
cola.Enqueue(8);
cola.Enqueue(9);

Console.WriteLine(cola.Dequeue());