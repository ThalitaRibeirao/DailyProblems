﻿// https://www.beecrowd.com.br/judge/pt/runs/code/36928149
public class Problem1
{
	public void Solve()
	{
        int tempo = int.Parse(Console.ReadLine()!);
        int vel = int.Parse(Console.ReadLine()!);

        int dis = vel * tempo;
        double litros = Math.Round(dis / 12.0, 3);
        Console.WriteLine(litros.ToString("0.000"));
    }
}
