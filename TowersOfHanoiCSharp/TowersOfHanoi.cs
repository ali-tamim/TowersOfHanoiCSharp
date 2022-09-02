
namespace TowersOfHanoiCSharp
{
    static class TowersOfHanoi
    {
        public static void MoveDisk(int n, char fromPeg, char toPeg, char auxPeg)
        {
            // if 1 desk, make the move and return
            if (n == 1)
            {
                Console.WriteLine($"Move desk 1 fron peg {fromPeg} to peg {toPeg}");
                return;
            }

            // move top n-1 desks from A To B usin C as auxitiary
            MoveDisk(n-1, fromPeg, auxPeg, toPeg);
            Console.WriteLine($"Move desk {n} fron peg {fromPeg} to peg {toPeg}");

            // move top n-1 desks from B To C usin A as auxitiary
            MoveDisk(n - 1, auxPeg, toPeg, fromPeg);
        }
    }
}
