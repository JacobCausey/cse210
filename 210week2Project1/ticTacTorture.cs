﻿using System;
using System.Collections.Generic;
//I'm coding this probably the day it's due, mainly due to overload of HW - Jacob Causey
namespace ticTacTorture 
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> spaces =GetSpaces();
            string playerStatus = "x";

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
            static bool IsItOver(List<string> spaces)
            {
                bool over = false;
                if(IsWinner(spaces, "x")|| IsWinner(spaces, "o") || IsTie(spaces))
                {
                    over = true;
                }

                return over;
            }

            static bool IsWinner(List<string> board, string playerStatus)
            {
                bool isWinner = false;

            if ((board[0] == playerStatus && board[1] == playerStatus && board[2] == playerStatus)
                || (board[3] == playerStatus && board[4] == playerStatus && board[5] == playerStatus)
                || (board[6] == playerStatus && board[7] == playerStatus && board[8] == playerStatus)
                || (board[0] == playerStatus && board[3] == playerStatus && board[6] == playerStatus)
                || (board[1] == playerStatus && board[4] == playerStatus && board[7] == playerStatus)
                || (board[2] == playerStatus && board[5] == playerStatus && board[8] == playerStatus)
                || (board[0] == playerStatus && board[4] == playerStatus && board[8] == playerStatus)
                || (board[2] == playerStatus && board[4] == playerStatus && board[6] == playerStatus)
                )
            {
                isWinner = true;
            }

            return isWinner; 
            }
            static bool IsTie(List<string> board)
            {
                bool foundSpaces = false;

                foreach (string value in spaces)
                {
                    if(char.IsDigit(value[0]))
                    {
                        foundSpaces = true;
                        break;
                    }
                }
                return !foundSpaces;
            }
            static string GetNextPlayer(string playerStatus)
            {
                string nextPlayer = "x";

                if (playerStatus == "x")
                {
                    nextPlayer = "o";
                } 
                return nextPlayer;
            }
            static int GetMoveChoice(string playerStatus)
            {
                Console.WriteLine($"{playerStatus} Where would you like to play? ");
                string move_choice = Console.ReadLine();

                int choice = int.Parse(move_choice);
                return choice;
            }
            static void PlaceChoice(List<string> spaces, int choice, string playerStatus)
            {
                int index = choice -1;

               spaces[index] = playerStatus;
            }
    }
}