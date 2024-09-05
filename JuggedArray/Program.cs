int[][] ja = new int[3][];

// initialization 
ja[0] = new int[3];
ja[1] = new int[2];
ja[2] = new int[2];

for (int i = 0; i < ja[0].Length;i++)
    ja[0][i] = i + 1;

for (int i = 0; i < ja[1].Length; i++)
    ja[1][i] = i + 3;

for (int i = 0; i < ja[2].Length; i++)
    ja[2][i] = i + 5;

// Accessing and print 

for(int i = 0;i < ja.Length; i++)
{
    for(int j = 0; j < ja[i].Length;j++)
        Console.Write(ja[i][j]+" ");
    Console.Write("\n");
}
