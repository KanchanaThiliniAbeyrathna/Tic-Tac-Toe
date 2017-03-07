using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using log4net;

namespace WindowsFormsApplication1
{
    public partial class GameForm : Form

    {
        private static readonly ILog log = LogManager.GetLogger(typeof(GameForm));

        public GFX engine;
        public Board theBoard;
        public static bool aiGame = false;

        public static bool getAIgame()
        {
            return aiGame;
        }
        public GameForm()
        {
            InitializeComponent();
        }

        private void panel1_paint(object sender, PaintEventArgs e)
        {
            Graphics toPass = panel1.CreateGraphics();
            engine = new GFX(toPass);

            theBoard = new Board();
            theBoard.initBoard();

            refreshLabel1();

        }

        private void panel1_Click(object sender, EventArgs e)
        {
            Point mouse = Cursor.Position;
            mouse = panel1.PointToClient(mouse);
            theBoard.detectHit(mouse);
            refreshLabel1();
        }

        private void rbutton_Click(object sender, EventArgs e)
        {
            theBoard.reset();
            GFX.setUpCanvas();
        }

        private void abutton_Click(object sender, EventArgs e)
        {
            StaticticsForm sf = new StaticticsForm();
            refreshtable(sf.getGridVeiw());
            sf.Show();
            this.Hide();
        }

        private void ebutton_Click(object sender, EventArgs e)
        {
            StaticticsForm sf = new StaticticsForm();
            refreshtable(sf.getGridVeiw());
            Application.Exit();
        }

        public void refreshLabel1()
        {
            string X = "";
            string O = "";
            if (GameForm.aiGame == true)
            {
                log.Debug("It is one player game");
                X = OnePlayerForm.getPlayerXValue();
                O = "Computer";
            }
            else if (GameForm.aiGame == false)
            {
                log.Debug("It is two player game");
                X = TwoPlayersForm.getPlayerXValue();
                O = TwoPlayersForm.getPlayerOValue();
            }
            

            String newText = "It is ";
            if(theBoard.getPlayerForTurn()==Board.X)
            {
                newText += X;
                log.Debug("It is player X turn");
            }
            else
            {
                newText += O;
                log.Debug("It is player O turn");
            }
            newText += "'s Turn\n";
            newText += X+" has won " + theBoard.getXwins() + " times.\n"+ O +" has Won " + theBoard.getOwins() + " times";
            label1.Text = newText;
        }

        public void refreshtable(DataGridView d)
        {
            string X = "";
            string O = "";
            Player playerX;
            Player playerO;
            if (GameForm.aiGame == true)
            {
                X = OnePlayerForm.getPlayerXValue();
                O = "Computer";

            }
            else if (GameForm.aiGame == false)
            {
                X = TwoPlayersForm.getPlayerXValue();
                O = TwoPlayersForm.getPlayerOValue();
            }

            DataSet ds = new DataSet();
            Database db;

            playerO = new Player(O);

            if (O != "Computer")
            {

                playerO.setWins(theBoard.getOwins());
                playerO.setLosses(theBoard.getXwins());
                playerO.setHighScore(theBoard.getOwins());
                db = new Database(playerO);
            }

            playerX = new Player(X);

            playerX.setWins(theBoard.getXwins());
            playerX.setLosses(theBoard.getOwins());
            playerX.setHighScore(theBoard.getXwins());
            db = new Database(playerX);

            db.fillTable(db.getConnection(), ds);

            d.DataSource = ds.Tables[0];
            d.Refresh();

        }    

        private void panel2_Paint(object sender, PaintEventArgs e)
        {
             
        }

        private void form_Load(object sender, EventArgs e)
        {
            if(MessageBox.Show("would u like to play against the computer? ","Tic Tac Toe", MessageBoxButtons.YesNo)==DialogResult.Yes)
            {
                aiGame = true;
            }
        }

        private void PlayerXlabel_Click(object sender, EventArgs e)
        {

        }

        private void newGameButton_Click(object sender, EventArgs e)
        {
            StaticticsForm sf = new StaticticsForm();
            refreshtable(sf.getGridVeiw());
            MainForm f = new MainForm();
            f.Show();
            this.Hide();
        }

    }
}
