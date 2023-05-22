namespace DrawTriangle;
public class Program
{
    static void Main(string[] args)
    {
        int edgeLenght;
        Back:
        System.Console.Write("Enter the side length of the triangle to be drawn : ");
        if(Int32.TryParse(Console.ReadLine(),out edgeLenght) &&  0<edgeLenght){
            DrawTriangle(edgeLenght+1);
        }else{
            System.Console.WriteLine("You entered an invalid measure. Please, enter a length greater than zero.");
        }
    }

    public static void DrawTriangle(int edgeLenght)
    {
        int spaceCount = 0;
        for(int i=0; i<edgeLenght; i++)
        {
            // First - Space 
            for (int j = 0; j < (edgeLenght - spaceCount); j++)
            {
                Space();
            }

            Star();

            // Middle - Space // Star
            for (int k = 0; k < (2 * spaceCount - 1); k++)
            {
                if (i != edgeLenght - 1 || k%2==0)
                {
                    Space();
                }
                else
                {
                    Star();
                }
            }
            spaceCount++;

            if (i != 0)
            {
                Star();
            }

            System.Console.WriteLine();
        }
    }

    private static void Space()
    {
        System.Console.Write(" ");
    }

    private static void Star()
    {
        System.Console.Write("*");
    }
}
