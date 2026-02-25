// Include the namespaces (code libraries) you need below.
using System;
using System.Numerics;

// The namespace your code is in.
namespace MohawkGame2D
{
    /// <summary>
    ///     Your game code goes inside this class!
    /// </summary>
    public class Game
    {
        // Place your variables here:


        /// <summary>
        ///     Setup runs once before the game loop begins.
        /// </summary>
        public void Setup()
        {
            // Window Setup
            Window.SetTitle("Polar Bear");
            Window.SetSize(800, 600);
            Window.ClearBackground(Color.Blue);
        }

        /// <summary>
        ///     Update runs every frame.
        /// </summary>
        public void Update()
        {
            // Reset background
            Window.ClearBackground(Color.Cyan);

            if (Input.IsMouseButtonDown(MouseInput.Left))
            {
                Window.ClearBackground(Color.Black);

                for (int i = 0; i < 10; i++)
                {
                    Draw.FillColor = Color.White;
                    Draw.Circle(10 + i * 15, 50, 5);
                    Draw.Circle(30 + i * 25, 30, 5);
                    Draw.Circle(50 + i * 30, 12, 5);
                    Draw.Circle(70 + i * 55, 72, 5);
                    Draw.Circle(80 + i * 65, 80, 5);
                    Draw.Circle(85 + i * 70, 85, 5);
                    Draw.Circle(95 + i * 75, 90, 5);
                    Draw.Circle(100 + i * 80, 100, 5);
                    Draw.Circle(105 + i * 85, 105, 5);
                }

            }

            // Mountain
            for (int i = 0; i < 2; i++)
            {
                Draw.FillColor = Color.Gray;
                Draw.Capsule(100 + i * 600, 100, 100 + i * 600, 500, 50);
                Draw.FillColor = Color.White;
                Draw.Circle(100 + i * 600, 100, 50);
            }

            // Ground
            Draw.FillColor = Color.Blue;
            Draw.Rectangle(0, 450, 800, 150);

            DrawBear();
        }

        void DrawBear()
        {
            // Bear
            Draw.FillColor = Color.White;
            // Head
            Draw.Circle(400, 225, 65);

            // Body
            Draw.Circle(400, 350, 100);

            //Arms
            Draw.Circle(365, 425, 30);
            Draw.Circle(440, 425, 30);
            Draw.Circle(365, 299, 30);
            Draw.Circle(440, 299, 30);

            //Eyes
            Draw.FillColor = Color.Black;
            Draw.Circle(375, 200, 5);
            Draw.Circle(425, 200, 5);

            //Paws
            DrawPaw(350, 314);
            DrawPaw(425, 314);
            DrawPaw(350, 430);
            DrawPaw(425, 430);
        }

        void DrawPaw(float x, float y)
        {
            Draw.FillColor = Color.Black;
            Draw.Circle(x, y, 7);
            Draw.Circle(x + 14, y, 7);
            Draw.Circle(x + 28, y, 7);
        }
    }
}



