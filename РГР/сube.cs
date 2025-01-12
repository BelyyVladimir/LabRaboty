using System;
class Cube
{
    static void Main()
    {
        string size_step = Console.ReadLine();
        string[] s_s = size_step.Split(' ');
        int size = int.Parse(s_s[0]);
        int step = int.Parse(s_s[1]);

        string coordinates = Console.ReadLine();
        string[] coord = coordinates.Split(' ');
        int xc = int.Parse(coord[0]);
        int yc = int.Parse(coord[1]);
        int zc = int.Parse(coord[2]);

        for (int i = 0; i < step; i++)
        {
            string line = Console.ReadLine();
            string[] words = line.Split(' ');
            string axis = words[0];
            int num_axis = int.Parse(words[1]);
            int RI_LE = int.Parse(words[2]);

            if (RI_LE == 1)
            {
                switch (axis)
                {
                    case "X":
                        if (num_axis == xc)
                        {
                            int px = yc;
                            yc = zc;
                            zc = size + 1 - px;
                        }
                        break;
                    case "Y":
                        if (num_axis == yc)
                        {
                            int py = xc;
                            xc = zc;
                            zc = size + 1 - py;
                        }
                        break;
                    case "Z":
                        if (num_axis == zc)
                        {
                            int pz = xc;
                            xc = yc;
                            yc = size + 1 - pz;

                        }
                        break;

                }

            }
            else
            {
                switch (axis)
                {
                    case "X":
                        if (num_axis == xc)
                        {
                            int px = zc;
                            zc = yc;
                            yc = size + 1 - px;
                        }
                        break;
                    case "Y":
                        if (num_axis == yc)
                        {
                            int py = zc;
                            zc = xc;
                            xc = size + 1 - py;
                        }
                        break;
                    case "Z":
                        if (num_axis == zc)
                        {
                            int pz = yc;
                            yc = xc;
                            xc = size + 1 - pz;

                        }
                        break;
                }
            }
        }
        Console.WriteLine($"{xc} {yc} {zc}");
    }
}
