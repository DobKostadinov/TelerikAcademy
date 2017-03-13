namespace Minesweeper
{
    using System;
    using System.Collections.Generic;

    public class MinesweeperMain
    {
        private static void Main()
        {
            const int maxPossiblePoints = 35;

            string command = string.Empty;
            char[,] board = CreatePlayingBoard();
            char[,] bombes = SettingBombes();
            int counter = 0;
            bool explosion = false;
            List<Player> champions = new List<Player>(6);
            int rowCheckedFromPlayer = 0;
            int colCheckedFromPlayer = 0;
            bool startingPointOfTheGame = true;
            bool endPointOfTheGame = false;

            do
            {
                if (startingPointOfTheGame)
                {
                    Console.WriteLine(
                        "Let's play “Minesweeper”. Find all fields without mines."
                        + " Command 'top' shows the rank, 'restart' starts new game, 'exit' exit the game!");

                    DrawThePlayingBoard(board);
                    startingPointOfTheGame = false;
                }

                Console.Write("Choose row and column in the following format( row, col ): ");

                command = Console.ReadLine().Trim();

                if (command.Length >= 3)
                {
                    if (int.TryParse(command[0].ToString(), out rowCheckedFromPlayer)
                        && int.TryParse(command[2].ToString(), out colCheckedFromPlayer)
                        && rowCheckedFromPlayer <= board.GetLength(0) && colCheckedFromPlayer <= board.GetLength(1))
                    {
                        command = "turn";
                    }
                }

                switch (command)
                {
                    case "top":
                        ShowRanking(champions);
                        break;
                    case "restart":
                        board = CreatePlayingBoard();
                        bombes = SettingBombes();
                        DrawThePlayingBoard(board);
                        explosion = false;
                        startingPointOfTheGame = false;
                        break;
                    case "exit":
                        Console.WriteLine("Bye!");
                        break;
                    case "turn":
                        if (bombes[rowCheckedFromPlayer, colCheckedFromPlayer] != '*')
                        {
                            if (bombes[rowCheckedFromPlayer, colCheckedFromPlayer] == '-')
                            {
                                CheckBoardAfterShoot(board, bombes, rowCheckedFromPlayer, colCheckedFromPlayer);
                                counter++;
                            }

                            if (maxPossiblePoints == counter)
                            {
                                endPointOfTheGame = true;
                            }
                            else
                            {
                                DrawThePlayingBoard(board);
                            }
                        }
                        else
                        {
                            explosion = true;
                        }

                        break;
                    default:
                        Console.WriteLine("\nError! Invalid command\n");
                        break;
                }

                if (explosion)
                {
                    DrawThePlayingBoard(bombes);
                    if (counter == 1)
                    {
                        Console.Write("\nOpss! You died with {0} point. " + "Choose your nickname: ", counter);
                    }
                    else
                    {
                        Console.Write("\nOpss! You died with {0} points. " + "Choose your nickname: ", counter);
                    }

                    string nickName = Console.ReadLine();

                    Player newPlayer = new Player(nickName, counter);

                    if (champions.Count < 5)
                    {
                        champions.Add(newPlayer);
                    }
                    else
                    {
                        for (int i = 0; i < champions.Count; i++)
                        {
                            if (champions[i].Points < newPlayer.Points)
                            {
                                champions.Insert(i, newPlayer);
                                champions.RemoveAt(champions.Count - 1);
                                break;
                            }
                        }
                    }

                    champions.Sort((Player playerAtFirstPosition, Player playerAtSecondPosition) => playerAtSecondPosition.Name.CompareTo(playerAtFirstPosition.Name));
                    champions.Sort((Player playerAtFirstPosition, Player playerAtSecondPosition) => playerAtSecondPosition.Points.CompareTo(playerAtFirstPosition.Points));
                    ShowRanking(champions);

                    board = CreatePlayingBoard();
                    bombes = SettingBombes();
                    counter = 0;
                    explosion = false;
                    startingPointOfTheGame = true;
                }

                if (endPointOfTheGame)
                {
                    Console.WriteLine("\nGood Well!! You successfully complete the game without stepping on mine.");
                    DrawThePlayingBoard(bombes);

                    Console.WriteLine("Choose your nickname: ");

                    string nickname = Console.ReadLine();
                    Player newPlayer = new Player(nickname, counter);
                    champions.Add(newPlayer);
                    ShowRanking(champions);

                    board = CreatePlayingBoard();
                    bombes = SettingBombes();
                    counter = 0;
                    endPointOfTheGame = false;
                    startingPointOfTheGame = true;
                }
            }
            while (command != "exit");

            Console.WriteLine("Thank you for playing our game!");
            Console.WriteLine("We look forward to seeing you soon. Goodbye");

            Console.Read();
        }

        private static void ShowRanking(List<Player> playerPoints)
        {
            Console.WriteLine("\nRanking:");
            if (playerPoints.Count > 0)
            {
                for (int i = 0; i < playerPoints.Count; i++)
                {
                    if (playerPoints[i].Points == 1)
                    {
                        Console.WriteLine("{0}. {1} --> {2} point", i + 1, playerPoints[i].Name, playerPoints[i].Points);
                    }
                    else
                    {
                        Console.WriteLine("{0}. {1} --> {2} points", i + 1, playerPoints[i].Name, playerPoints[i].Points);
                    }

                }

                Console.WriteLine();
            }
            else
            {
                Console.WriteLine("Empty ranking!\n");
            }
        }

        private static void CheckBoardAfterShoot(char[,] playingBoard, char[,] bombBoard, int row, int col)
        {
            char closeBombs = CheckForCloseBombs(bombBoard, row, col);
            bombBoard[row, col] = closeBombs;
            playingBoard[row, col] = closeBombs;
        }

        private static void DrawThePlayingBoard(char[,] board)
        {
            int rowBoardLenght = board.GetLength(0);
            int columnBoardLength = board.GetLength(1);

            Console.WriteLine("\n    0 1 2 3 4 5 6 7 8 9");
            Console.WriteLine("   ---------------------");

            for (int i = 0; i < rowBoardLenght; i++)
            {
                Console.Write("{0} | ", i);

                for (int j = 0; j < columnBoardLength; j++)
                {
                    Console.Write(string.Format("{0} ", board[i, j]));
                }

                Console.Write("|");
                Console.WriteLine();
            }

            Console.WriteLine("   ---------------------\n");
        }

        private static char[,] CreatePlayingBoard()
        {
            int boardRows = 5;
            int boardColumns = 10;
            char[,] board = new char[boardRows, boardColumns];
            for (int i = 0; i < boardRows; i++)
            {
                for (int j = 0; j < boardColumns; j++)
                {
                    board[i, j] = '?';
                }
            }

            return board;
        }

        private static char[,] SettingBombes()
        {
            int rowsBoardWithBombs = 5;
            int columnsBoardWithBombs = 10;
            char[,] boardWithBombs = new char[rowsBoardWithBombs, columnsBoardWithBombs];

            for (int i = 0; i < rowsBoardWithBombs; i++)
            {
                for (int j = 0; j < columnsBoardWithBombs; j++)
                {
                    boardWithBombs[i, j] = '-';
                }
            }

            List<int> bombCollection = new List<int>();

            while (bombCollection.Count < 15)
            {
                Random random = new Random();
                int randomBombPosition = random.Next(50);
                if (!bombCollection.Contains(randomBombPosition))
                {
                    bombCollection.Add(randomBombPosition);
                }
            }

            foreach (int bomb in bombCollection)
            {
                int column = bomb / columnsBoardWithBombs;
                int row = bomb % columnsBoardWithBombs;
                if (row == 0 && bomb != 0)
                {
                    column--;
                    row = columnsBoardWithBombs;
                }
                else
                {
                    row++;
                }

                boardWithBombs[column, row - 1] = '*';
            }

            return boardWithBombs;
        }

        private static void CalculatCloseBombs(char[,] field)
        {
            int columns = field.GetLength(0);
            int rows = field.GetLength(1);

            for (int i = 0; i < columns; i++)
            {
                for (int j = 0; j < rows; j++)
                {
                    if (field[i, j] != '*')
                    {
                        char closeBombs = CheckForCloseBombs(field, i, j);
                        field[i, j] = closeBombs;
                    }
                }
            }
        }

        private static char CheckForCloseBombs(char[,] bombBoard, int playerChoosenRow, int playerChoosenColumn)
        {
            int bombsAroundCheckedPosition = 0;
            int reds = bombBoard.GetLength(0);
            int kols = bombBoard.GetLength(1);

            if (playerChoosenRow - 1 >= 0)
            {
                if (bombBoard[playerChoosenRow - 1, playerChoosenColumn] == '*')
                {
                    bombsAroundCheckedPosition++;
                }
            }

            if (playerChoosenRow + 1 < reds)
            {
                if (bombBoard[playerChoosenRow + 1, playerChoosenColumn] == '*')
                {
                    bombsAroundCheckedPosition++;
                }
            }

            if (playerChoosenColumn - 1 >= 0)
            {
                if (bombBoard[playerChoosenRow, playerChoosenColumn - 1] == '*')
                {
                    bombsAroundCheckedPosition++;
                }
            }

            if (playerChoosenColumn + 1 < kols)
            {
                if (bombBoard[playerChoosenRow, playerChoosenColumn + 1] == '*')
                {
                    bombsAroundCheckedPosition++;
                }
            }

            if ((playerChoosenRow - 1 >= 0) && (playerChoosenColumn - 1 >= 0))
            {
                if (bombBoard[playerChoosenRow - 1, playerChoosenColumn - 1] == '*')
                {
                    bombsAroundCheckedPosition++;
                }
            }

            if ((playerChoosenRow - 1 >= 0) && (playerChoosenColumn + 1 < kols))
            {
                if (bombBoard[playerChoosenRow - 1, playerChoosenColumn + 1] == '*')
                {
                    bombsAroundCheckedPosition++;
                }
            }

            if ((playerChoosenRow + 1 < reds) && (playerChoosenColumn - 1 >= 0))
            {
                if (bombBoard[playerChoosenRow + 1, playerChoosenColumn - 1] == '*')
                {
                    bombsAroundCheckedPosition++;
                }
            }

            if ((playerChoosenRow + 1 < reds) && (playerChoosenColumn + 1 < kols))
            {
                if (bombBoard[playerChoosenRow + 1, playerChoosenColumn + 1] == '*')
                {
                    bombsAroundCheckedPosition++;
                }
            }

            return char.Parse(bombsAroundCheckedPosition.ToString());
        }
    }
}
