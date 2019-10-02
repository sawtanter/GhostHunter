using System;

namespace KillTheMonster
{
    public class Player
    {
        public double chance;
        public int[] bulletPos;
        public double reset;
        public double totalScore;
        public double totalWins;
        public double totalLoses;
        Random rnd = new Random();

        public Player()
        {
            chance = 2;
            bulletPos = new int[6];
            reset = 0;
            totalScore = 0;
            totalWins = 0;
            totalLoses = 0;
            
        }

        public String loadBullets(int pos)
        {
            bulletPos[pos] = 1;
            return "Bullet Loaded Successfully...";
        }

        public void spinChambers()
        {
            for (int i = 0; i < bulletPos.Length; i++)
            {
                Console.WriteLine("\n bulletPos[" + i + "] = " + bulletPos[i]);
                if (bulletPos[i] == 1)
                {
                    bulletPos[i] = 0;
                }
            }
            
            int l = rnd.Next(0, 6);
            bulletPos[l] = 1;
            Console.WriteLine("\n Spinned Bullet[" + l + "] = " + bulletPos[l]);
            // swap the bullet position from above random integer from 1 - 6.
        }

        //@returnParam - 	Case 1) You missed him.... _ more chance left..

        //      Case 2) Whoa!!... You killed the monster...

        //    Case 3) You are dead... Click playAgain or load bullet..
        public String fire()
        {
            //Random rnd2 = new Random();
            int l = rnd.Next(0, 6);
            Console.WriteLine("\n Fired bullet[" + l + "] = " + bulletPos[l]);
            if (bulletPos[l] == 1)
            {
                chance = 2;
                totalWins++;
                totalScore += 10;
                return "Whoa!!... You killed the monster...";
            }else
            {
                chance--;
                if (chance != 0)
                    return "You missed him...." + chance + " more chance left..";
                else
                {
                    totalLoses++;
                    totalScore -= 10;
                    return "You are dead... Click PlayAgain and Load Bullet..";
                }      
            }
        }
        //@returnParam - 	Game is reset now...Ready to kill the monster? Click Load bullets
        public String playAgain()
        {
            return "";

        }

        //@returnParam - Revolver is empty now, please load the bullet and try again.
        public void resetRevolver()
        {

        }
    }
}

