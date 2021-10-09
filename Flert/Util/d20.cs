using System;

/**
 * d20
 * For when you need to roll a dice
 */
public class d20
{
    private static Random rand = new Random();

    public static int Roll()
    {
        return rand.Next(1, 21);
    }
}