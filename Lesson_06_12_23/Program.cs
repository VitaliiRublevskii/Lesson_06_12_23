


using Lesson_06_12_23;

Figur fig1 = new Figur();


// квадрат
Square square1 = new Square("square1", 4, 30);
Square square2 = new Square("square2", 4, 20);
Square square3 = new Square("square3", 4, 15);
square1.PrintFigur();
square2.PrintFigur();
square3.PrintFigur();
Console.WriteLine();

Triangle triangle1 = new Triangle("triangle1", 3, 10, 10, 12);
Triangle triangle2 = new Triangle("triangle2", 3, 12, 12, 18);
Triangle triangle3 = new Triangle("triangle3", 3, 8, 8, 10);
triangle1.PrintFigur();
triangle2.PrintFigur();
triangle3.PrintFigur();
Console.WriteLine();

Сircle circle1 = new Сircle("circle1", 5);
Сircle circle2 = new Сircle("circle2", 15);
Сircle circle3 = new Сircle("circle3", 7);
circle1.PrintFigur();
circle2.PrintFigur();
circle3.PrintFigur();





Figures[] figures1 = new Figures[9];
figures1.AddFigurs(circle1);
figures1.PrintFigurS();






//  2) Добавить метод сравнения двух фигур ( координата + размер )
//  3) Дать пользователю возможность создать множество разных фигур (это отдельный класс )
//  4) Добавить CRUD архтектуру для работы с массивом фигур
//  Для удобства расширить базовый тип свойством id (целочисленное значени - показывает независимый номер обьекта в момент его добавлния )
// https://www.freecodecamp.org/news/crud-operations-explained/

