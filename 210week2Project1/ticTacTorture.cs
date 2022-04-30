using System;
using System.Collections.Generic;
//I'm coding this probably the day it's due, mainly due to overload of HW - Jacob Causey
namespace ticTacTorture 
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> spaces =GetSpaces();
            string playerStatus = 'x';

            while(!GameContinue(spaces))
            {
                DisplayBoard(spaces);
                
                int choice = GetMoveChoice(playerStatus);
                PlaceChoice(spaces,choice,playerStatus);
            }

            DisplayBoard(spaces);
            Console.WriteLine("GG,no re!");
        }

            static List<string> GetSpaces()
            {
                List<string> spaces = new List<string>();
                for (int i = 1; i <=9;i++)
                {
                    spaces.Add(i.ToString());
                }
                return spaces;
            }
            static void DisplayBoard(List<string> spaces)
            {
                Console.WriteLine("     |     |      ");
                Console.WriteLine($"  {spaces[0]}  |  {spaces[1]}  |  {spaces[2]}  |");
                Console.WriteLine("_____|_____|_____");
                Console.WriteLine($"  {spaces[3]}  |  {spaces[4]}  |  {spaces[5]}  |");
                Console.WriteLine("_____|_____|_____");
                Console.WriteLine($"  {spaces[6]}  |  {spaces[7]}  |  {spaces[8]}  |");
                Console.WriteLine("     |     |      ");
            }

    }
}