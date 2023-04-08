Console.Clear();
//Console.SetCursorPosition(10, 4);
//Console.WriteLine("+");


int xa = 1, ya = 1, xb = 1, yb = 30, xc = 50, yc = 30;

Console.SetCursorPosition(xa, ya);
Console.WriteLine("+");

Console.SetCursorPosition(xb, yb);
Console.WriteLine("+");

int x = xa, y = xb;

int count = 0;
int what = new Random().Next(0, 3);//0,1,2
while(count < 10)
   if (what == 0)
{
//это скоуп ифа
    x = (x + xa) / 2;
    y = (y + ya) / 2;
}
if (what == 2)
{
//это скоуп ифа. 
    x = (x+xc)/2;
    y = (y+yc)/2;
}
Console.SetCursorPosition (x,y);
Console.WriteLine("+");
count +=1;