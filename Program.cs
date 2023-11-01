


Console.WriteLine("chandomin donbale ro mikhi ?");
int an =Convert.ToInt32(Console.ReadLine());

int ShomareShekl = 1;
for(int x = 0; x < an; x++)
{
    int number= (ShomareShekl * (ShomareShekl + 1)) / 2;
    ShomareShekl = ShomareShekl + 1;
    
    Console.Write(number);
    Console.Write(",");
}












