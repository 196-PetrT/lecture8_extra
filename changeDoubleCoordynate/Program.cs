// наша задача увеличить координаты ровно в два раза
// узнаем какие правила 


using System.Linq;

string text = "(1,2) (3,4) (5,6) (7,8)"
                .Replace("(", "")
                .Replace(")", "")
                ;
Console.WriteLine(text);

var data = text.Split(" ") // разделение по пробелу 
                .Select(item => item.Split(','))
                .Select(e => (x: int.Parse(e[0]), y: int.Parse(e[1]))) // сделаем выборку из текущего массива 
                // .Where(e => e.x % 2 == 0) // чтобы сделать проверку условия
                .Select(point => (point.x * 2, point.y * 2))
                .ToArray(); // превратить в явный массив

for (int i = 0; i < data.Length; i++)
{
    // Console.WriteLine(data[i].Item1*2);
    Console.Write(data[i]);
    
    Console.WriteLine();
}

