using lesson_14;

Console.WriteLine("*****Fun with Object Init Syntax*****\n");
//создать обьеки Point, устанавливая каждое свойство вручную
Point firstPoint = new Point();
firstPoint.X = 10;
firstPoint.Y = 10;
firstPoint.DisplayStats();
//или создать обьект Point посредством специального конструктора
Point anotherPoint = new Point(20, 20);
anotherPoint.DisplayStats();
//или создать обьект Point используя синтаксис иницииализации обьектов
Point finalPoint = new Point {X = 30, Y = 30};
firstPoint.DisplayStats();
Console.ReadLine();

//создать обьект точкиб допускающий только чтение 
//полсе конструирования 
PointReadOnlyAfterCreation firstReadOnlyPoint = new PointReadOnlyAfterCreation(20, 20);
firstReadOnlyPoint.DisplayStats();

//или создать обьект точки с использованием синтксиса только для инициализации
PointReadOnlyAfterCreation secondReadOnlyPoint = new PointReadOnlyAfterCreation { X = 30, Y = 30 };
secondReadOnlyPoint.DisplayStats();

//Вызов более интересного спец конструктора 
//c помощью синтаксиса инициализации
Point goldPoint = new Point(PointColorEnum.Gold) { X = 90, Y = 90 };
goldPoint.DisplayStats();

//создать и инициализировать обьект Rectangle
Rectangle myRect = new Rectangle
{
    TopLeft = new Point { X = 10, Y = 10 },
    BottomRight = new Point { X = 200, Y = 200 }
};

//традиционный подход
Rectangle r = new Rectangle();
Point p1 = new Point();
p1.X = 10;
p1.Y = 10;
r.TopLeft = p1;
Point p2 = new Point();
p2.X = 200;
p2.Y = 200;
r.BottomRight = p2;