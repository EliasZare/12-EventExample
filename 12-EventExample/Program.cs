using Events;

Publisher publisher = new Publisher();

Subscriber subscriber = new Subscriber();

//publisher.MyEvent += subscriber.Add;

//publisher.RiseEvent(10, 11);

//Anonymous Method
publisher.MyAutoImplementedEvent += delegate (int a, int b)
{
    Console.WriteLine(a+b);
};

//Lambda 
publisher.MyAutoImplementedEvent += (int a, int b)=> Console.WriteLine(a + b);


publisher.RiseAutoImplementedEvent(10, 11);
publisher.RiseAutoImplementedEvent(4, 10);
publisher.RiseAutoImplementedEvent(10, 110);
