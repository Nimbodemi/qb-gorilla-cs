using System.Numerics;
using System.Reflection;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace gorilla
{
    public partial class Form1 : Form
    {

        private Random r = new Random();
        private Rectangle rRectangle;
        List<Rectangle> Buildings = new List<Rectangle>();
        List<Rectangle> Players = new List<Rectangle>();
        List<Rectangle> PlayerBases = new List<Rectangle>();
        int playerTurnCount = 2;

        public Form1()
        {
            InitializeComponent();
            this.Paint += Form1_Paint;
            this.ClientSize = new Size(1920, 1080);
            gameOver.Visible = false;
            CreateBuildings();
            CreateBuildings2();
            CreateBuildings3();
            Player1();
            Player2();
            Player1Base();
            Player2Base();
            ThrowObject();
            //playerCollision();
        }

        int totalwidth = 0;
        public void GenerateRRectangle()
        {
            int minHeight = 500;
            int maxHeight = 800;
            int width = 216;
            int rHeight = r.Next(minHeight, maxHeight + 1);

            int x = (0 + totalwidth);
            int y = (1080 - rHeight);

            Rectangle rRectangle = new Rectangle(x, y, width, rHeight);
            totalwidth = (totalwidth + 216);
            Buildings.Add(rRectangle);

        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Random rgb1 = new Random();
            Random rgb2 = new Random();
            Random rgb3 = new Random();
            foreach (Rectangle r in Buildings)
            {
                var solidBrush = new SolidBrush(Color.FromArgb(rgb1.Next(0, 255), rgb2.Next(0, 255), rgb3.Next(0, 255)));
                using SolidBrush brush = solidBrush;
                e.Graphics.FillRectangle(brush, r);
            }
            foreach (Rectangle r in Players)
            {
                var solidBrush = new SolidBrush(Color.Orange);
                using SolidBrush brush = solidBrush;
                e.Graphics.FillRectangle(brush, r);
            }
            foreach (Rectangle r in PlayerBases)
            {
                var solidBrush = new SolidBrush(Color.Navy);
                using SolidBrush brush = solidBrush;
                e.Graphics.FillRectangle(brush, r);
            }
        }

        protected override void OnClick(EventArgs e)
        {
            base.OnClick(e);
            GenerateRRectangle();
            this.Invalidate();
        }

        private void GameTimer_Tick(object sender, EventArgs e)
        {
            label2.Text = playerTurnCount.ToString();
        }

        private void CreateBuildings()
        {
            while (totalwidth < 216)
            {
                GenerateRRectangle();
            }
            totalwidth = 432;
        }

        private void CreateBuildings2()
        {
            while (totalwidth < 1512)
            {
                GenerateRRectangle();
            }
            totalwidth = 1727;
        }

        private void CreateBuildings3()
        {
            while (totalwidth < 1728)
            {
                GenerateRRectangle();
            }
        }

        public void Player1()
        {
            int playerHeight = 100;
            int playerWidth = 100;

            int x = 280;
            int y = 400;

            Rectangle Player1Rectangle = new Rectangle(x, y, playerWidth, playerHeight);
            Players.Add(Player1Rectangle);
        }

        public void Player2()
        {
            int playerHeight = 100;
            int playerWidth = 100;

            int x = 1580;
            int y = 400;

            Rectangle player2 = new Rectangle(x, y, playerWidth, playerHeight);
            Players.Add(player2);
        }

        public void Player1Base()
        {
            int baseHeight = 750;
            int baseWidth = 216;

            int x = 216;
            int y = 500;

            Rectangle player1base = new Rectangle(x, y, baseWidth, baseHeight);
            PlayerBases.Add(player1base);
        }

        public void Player2Base()
        {
            int baseHeight = 750;
            int baseWidth = 216;

            int x = 1512;
            int y = 500;

            Rectangle player2base = new Rectangle(x, y, baseWidth, baseHeight);
            PlayerBases.Add(player2base);
        }

        public void Throwing()
        {
            double g = 0;
            double h = pictureBox2.Top;
            double a = 5;
            double Uv = 20;
            double aRadian = a * Math.PI / 180.0;
            double Ux = pictureBox2.Left;
            double Uy = pictureBox2.Top;
            double Sy = h + Ux * Math.Tan(aRadian) - (g * Math.Pow(Ux, 2)) / (2 * Math.Pow(Uv, 2) * Math.Pow(Math.Cos(aRadian), 2));
            int Cy = Convert.ToInt32(Math.Round(Sy));
            int x = Convert.ToInt32(Ux.ToString());
            pictureBox2.Left = x++;
            pictureBox2.Top = Cy;
            label1.Text = (x.ToString() + ", " + Cy.ToString());
        }

        public async void ThrowObject()
        {
            double g = 9.8;
            double h = pictureBox2.Top;
            double a = 1;
            double Uv = 1;

            int totaldistance = 3200;
            int gravity = Convert.ToInt32(g);
            int height = Convert.ToInt32(h);
            int angle = Convert.ToInt32(a);
            int x_change = Convert.ToInt32(Uv);
            int total_x_change = 0;

            while (total_x_change < (totaldistance / 2))
            {
                pictureBox2.Left = pictureBox2.Left + x_change;
                pictureBox2.Top = pictureBox2.Top + (angle);
                total_x_change = total_x_change + x_change;
                await Task.Delay(10);
            }

            while (total_x_change > (totaldistance / 2) && (total_x_change < 1920) && (pictureBox2.Top > 1000))
            {
                pictureBox2.Left = pictureBox2.Left + x_change;
                pictureBox2.Top = pictureBox2.Top - (angle);
                await Task.Delay(10);
            }

            if (total_x_change > 1920)
            {
                playerTurnCount = playerTurnCount++;
            }
        }

        bool gameOn = true;
        public async void playerCollision()
        {
            while (gameOn == true)
            {
                if (player1.Bounds.IntersectsWith(pictureBox2.Bounds) || player2.Bounds.IntersectsWith(pictureBox2.Bounds))
                {
                    gameOver.Visible = true;
                    gameOn = false;
                }
            }
        }
    }
}