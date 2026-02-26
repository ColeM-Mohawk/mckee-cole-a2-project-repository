// Include the namespaces (code libraries) you need below.
using Raylib_cs;
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

        /// <summary>
        ///     Setup runs once before the game loop begins.
        /// </summary>
        public void Setup()
        {
            // Window Setup
            Window.SetTitle("Fly Simulator");
            Window.SetSize(800, 600);

        }

        /// <summary>
        ///     Update runs every frame.
        /// </summary>
        public void Update()
        {
            Window.ClearBackground(Color.OffWhite);


            // Head

            // Draw circle for head
            Draw.FillColor = new Color(255, 219, 172);
            Draw.LineColor = Color.Black;
            Draw.Circle(400, 150, 95);

            Draw.FillColor = Color.Blue;
            Draw.LineColor = Color.Black;
            Draw.Circle(360, 125, 25);

            Draw.FillColor = Color.Blue;
            Draw.LineColor = Color.Black;
            Draw.Circle(437, 125, 25);

            Draw.FillColor = Color.Black;
            Draw.LineColor = Color.Black;
            Draw.Circle(360, 125, 10);

            Draw.FillColor = Color.Black;
            Draw.LineColor = Color.Black;
            Draw.Circle(437, 125, 10);

            // Draw a fly at mouse position
            Draw.FillColor = Color.Black;
            Draw.LineColor = Color.LightGray;
            Draw.Ellipse(Input.GetMouseX(), Input.GetMouseY(), 30, 45);

            if (Input.IsMouseButtonDown(MouseInput.Right))
            {

                Draw.FillColor = Color.Red;
                Draw.LineColor = Color.Black;
                Draw.Circle(400, 150, 95);

                Draw.FillColor = Color.Blue;
                Draw.LineColor = Color.Black;
                Draw.Circle(360, 125, 25);

                Draw.FillColor = Color.Blue;
                Draw.LineColor = Color.Black;
                Draw.Circle(437, 125, 25);

                Draw.FillColor = new Color(437, 125, 25);
                Draw.LineColor = Color.Black;
                Draw.Circle(360, 125, 10);

                Draw.FillColor = new Color(437, 125, 25);
                Draw.LineColor = Color.Black;
                Draw.Circle(437, 125, 10);

                Draw.FillColor = Color.Black;
                Draw.LineColor = Color.LightGray;
                Draw.Ellipse(Input.GetMouseX(), Input.GetMouseY(), 30, 45);
            }

        }

        }

    }
