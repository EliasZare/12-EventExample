using Events;

Publisher publisher = new Publisher();

Subscriber subscriber = new Subscriber();

//publisher.MyEvent += subscriber.Add;

//publisher.RiseEvent(10, 11);

publisher.MyAutoImplementedEvent += subscriber.Add;
publisher.RiseAutoImplementedEvent(10, 11);
publisher.RiseAutoImplementedEvent(4, 10);
publisher.RiseAutoImplementedEvent(10, 110);
