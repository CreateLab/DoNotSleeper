// See https://aka.ms/new-console-template for more information
using System;
using System.Drawing;
using System.Windows.Forms;
using System.Drawing;

Console.WriteLine("Awake your computer! Press any key to stop.");
var isWorking = true;
while (isWorking)
{
    var mousePosition = Cursor.Position;
    if (mousePosition.X == 0 || mousePosition.Y == 0)
    {
        Cursor.Position = new Point(500, 500);
    }

    else
    {
        Cursor.Position = new Point(mousePosition.X - 10, mousePosition.Y - 10);
    }
    
    for (var i = 0; i < 15 && isWorking; i++)
    {
        await Task.Delay(1000);
        if(Console.KeyAvailable)
        {
            isWorking = false;
        }
    }
   
}