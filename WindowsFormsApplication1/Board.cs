using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;
using log4net;

namespace WindowsFormsApplication1
{
    public class Board 
    {
        private static readonly ILog log = LogManager.GetLogger(typeof(Board));


        public int movesMade = 0;
        public int Owins = 0;
        public int Xwins = 0;

        private Holder[,] holders= new Holder[3,3];
        
        public const int X=0;
        public const int O=1;
        public const int B=2;

        public int playersTurn = X;

        public int getPlayerForTurn()
        {
            return playersTurn;
        }

        public int getOwins()
        {
            return Owins;
        }
        public int getXwins()
        {
            return Xwins;
        }
        public void initBoard()
        {
            for (int x = 0; x < 3; x++)
            {
                for (int y = 0; y < 3; y++)
                {
                    
                    holders[x,y]= new Holder();
                    holders[x, y].setValue(B);
                    holders[x, y].setLocation(new Point(x, y));

                }
            }
        }


        public void detectHit(Point loc)
        {
            //check if the board is clicked
            log.Debug("check if the board is clicked");
            if(loc.Y <= 500)
            {
                int x = 0;
                int y = 0;

                if(loc.X<167)
                {
                    x = 0;
                }
                else if(loc.X > 167 && loc.X < 334)
                {
                    x = 1;
                }
                else if (loc.X > 334)
                {
                    x = 2;
                }


                if (loc.Y < 167)
                {
                    y = 0;
                }
                else if (loc.Y > 167 && loc.Y < 334)
                {
                    y= 1;
                }
                else if (loc.Y > 334 && loc.Y<500)
                {
                    y = 2;
                }

                if(holders[x,y].getValue()==B && !isBoardFull())
                {
                    log.Debug("check player turn");

                    //it's X's turn
                    if (movesMade % 2 == 0 && holders[x, y].getValue() == B)
                    {
                        GFX.drawX(new Point(x, y));
                        holders[x, y].setValue(X);
                        
                        if (detectRow())
                        {

                            if (GameForm.aiGame == true)
                            {
                                MessageBox.Show("you have won, " + OnePlayerForm.getPlayerXValue());
                                
                            }
                            else if (GameForm.aiGame == false)
                            {
                                MessageBox.Show("you have won, " + TwoPlayersForm.getPlayerXValue());
                                
                            }
                           
                            Xwins++;
                            reset();
                            GFX.setUpCanvas();
                            

                        }
                       
                        if (GameForm.getAIgame() && !detectRow() && !isBoardFull())
                        {

                            Holder aiMove = ComputerLogic.determineAndPlaceMark(holders);
                            GFX.drawO(aiMove.getLocation());

                            holders[aiMove.getLocation().X, aiMove.getLocation().Y].setValue(O);

                            
                            if (detectRow())
                            {
                                MessageBox.Show("Compuetr has won");
                                Owins++;
                                reset();
                                GFX.setUpCanvas();
                                
                            }
                            
                            movesMade++;
                            playersTurn = X;
                            
                        }
                        
                        playersTurn = O;
                        
                    }

                    else
                    {

                        GFX.drawO(new Point(x, y));
                        holders[x, y].setValue(O);
                        if (detectRow())
                        {
                            MessageBox.Show("you have won, " + TwoPlayersForm.getPlayerOValue());
                            Owins++;
                            reset();
                            GFX.setUpCanvas();
                        }
                        playersTurn = X;
                    }

                    movesMade++;
                    
                }
                if (isBoardFull())
                {
                    MessageBox.Show("It is tie, Play again");
                    reset();
                    GFX.setUpCanvas();

                }
            }
           
        }

        public bool detectRow()
        {
            log.Debug("check whether there is complete row or column");
            bool isWon = false;

            //detect vertical
            for (int x = 0; x < 3; x++ )
            {
                
                if (holders[x, 0].getValue() == X && holders[x, 1].getValue() == X && holders[x, 2].getValue() == X)
                {
                    GFX.CutVertical(new Point(x, 0));
                    return true;
                }

                if (holders[x, 0].getValue() == O && holders[x, 1].getValue() == O && holders[x, 2].getValue() == O)
                {
                    GFX.CutVertical(new Point(x, 0));
                    return true;
                }

                //detect diagonal
                switch (x)
                {
                    case 0:
                        if (holders[x, 0].getValue() == X && holders[x + 1, 1].getValue() == X && holders[x + 2, 2].getValue() == X)
                        {
                            GFX.CutDiagonal(x);
                            return true;
                        }
                        if (holders[x, 0].getValue() == O && holders[x + 1, 1].getValue() == O && holders[x + 2, 2].getValue() == O)
                        {
                            GFX.CutDiagonal(x);
                            return true;
                        }

                        break;

                    case 2:
                        if (holders[x, 0].getValue() == X && holders[x - 1, 1].getValue() == X && holders[x - 2, 2].getValue() == X)
                        {
                            GFX.CutDiagonal(x);
                            return true;
                        }
                        if (holders[x, 0].getValue() == O && holders[x - 1, 1].getValue() == O && holders[x - 2, 2].getValue() == O)
                        {
                            GFX.CutDiagonal(x);
                            return true;
                        }
                        break;
                }
            }

            //horizontal
            for (int y = 0; y< 3;y++ )
            {
                if (holders[0,y].getValue() == X && holders[1,y].getValue() == X && holders[2,y].getValue() == X)
                {
                    GFX.CutHorizontal(new Point(0,y));
                    return true;
                }
                if (holders[0,y].getValue() == O && holders[1,y].getValue() == O && holders[2,y].getValue() == O)
                {
                    GFX.CutHorizontal(new Point(0, y));
                    return true;
                }
            }
           
             return isWon;
        }

        //resatrt
        public void reset()
        {
            
            holders = new Holder[3, 3];
            initBoard();
        }

        public bool isBoardFull()
        {
            log.Debug("check whether board is full or not");
            bool full = true;
            foreach(Holder h in holders)
            {
                if(h.getValue()==Board.B)
                {
                    full = false;
                }
            }
            return full;
        }
    }

    
}
     
 