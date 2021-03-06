﻿using System;
using System.Collections.Generic;

namespace Gomoku
{
    /// <summary>
    /// a player in game
    /// </summary>
    class Player
    {
        /// <summary>
        /// holds the latest location that the player marked on the gameboard
        /// </summary>
        public Tuple<int, int> LatestMarkLoc { get; set; }

        public Player()
        {
            LatestMarkLoc = new Tuple<int, int>(-1, -1);
        }

        public bool MarkOnGameBoard(Dictionary<int, int> gameBoard, int x, int y, int markSymbol)
        {
            if (x < 0 || y < 0)
            {
                return false;
            }
            if (gameBoard.ContainsKey(x * HyperParam.boardSide + y))
            {
                return false;
            }
            if (x * HyperParam.boardSide + y > HyperParam.boardSide * HyperParam.boardSide - 1)
            {
                return false;
            }
            gameBoard[x * HyperParam.boardSide + y] = markSymbol;
            LatestMarkLoc = new Tuple<int, int>(x, y);
            return true;
        }

        /// <summary>
        /// simple AI agent computes location for its next mark
        /// </summary>
        /// <param name="gameBoard">the diction represents the gameboard</param>
        /// <param name="opponentLatestMark">location of last opponent's mark</param>
        /// <param name="opponentMarkSymbol">opponent symbol (1 or 2) as the dictionary contains only 
        /// 0 (non-marked location), 1, or 2
        /// </param>
        /// <returns></returns>
        public Tuple<int, int> SimpleAIReasoning(Dictionary<int, int> gameBoard, Tuple<int, int> opponentLatestMark, int opponentMarkSymbol)
        {
            List<List> keep = new List(List<Tuple>);
            int max_count = 0;
            for(int i = 0; gameBoard.ContainsValue(1); i++)
                {
                    keep.Add(gameBoard.GetHashCode(i));
                }


            return null;
        }
    }
}