// Include code libraries you need below (use the namespace).
using System;
using System.Numerics;
using System.Runtime.Versioning;

// The namespace your code is in.
namespace Game10003
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
            Window.SetTitle("NagaMania");
            Window.SetSize(800, 600);

        }

        /// <summary>
        ///     Update runs every frame.
        /// </summary>

        /// <summary>
        ///  makes a player model for the rest of the code to interact with
        /// </summary>
        public void PlayerModel(float a , float b, float c, float d, float e, float f)
        {

            // STATIC VER- Draw.Triangle(100,50,100,150,200,100);
            Draw.Triangle(a, b, c, d, e, f);

        }
        public void Update()
        {
            Window.ClearBackground(color: Color.White); //CHANGE COLOUR LATER ON
            
            
            //set up player model (triange and rectoangle)
            // set up enemy model (circle that changes size with every itteration)
            // move player based on mouses y movement but oomit the x to keep it on a virtical axis only moving up and down
            // spawn enemys randomly
        }
    }
}
