﻿using System;
using System.Collections.Generic;
using System.Text;
using CodeNameLogic.GameModels;

namespace CodeNameLogic.BoardModels
{
    public class Board
    {
        const uint MAX_ROWS    = 10;
        const uint MAX_COLUMNS = 10;
        
        public GameCard[,] GameCards { get; private set; }

        public BoardDescriptor BoardCardsDescriptor { get; private set; }

        public GameTheme BoardTheme { get; set; }

        public Board(BoardDescriptor boardDescriptor)
        {
            int rows    = boardDescriptor.CardRoles.GetLength(0);
            int columns = boardDescriptor.CardRoles.GetLength(1);

            if (rows >= MAX_ROWS || columns >= MAX_COLUMNS)
            {
                throw new ArgumentOutOfRangeException("Rows or Columns limit exceeded");
            }
            else if (rows <= 0 || columns <= 0)
            {
                throw new ArgumentOutOfRangeException("Rows or Columns must be a postive integer");
            }

            BoardCardsDescriptor = boardDescriptor;
            GameCards = new GameCard[rows, columns];
            BoardTheme = new GameTheme();
        }
    }
}
