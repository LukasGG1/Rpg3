using System;
using System.Collections.Generic;
using System.Text;
using Raylib_cs;
using MathLibrary;

namespace RPG
{
    class Map1 : Actor
    {
        private Sprite _sprite;
        public Map1(float x, float y, char icon = ' ', ConsoleColor color = ConsoleColor.White)
           : base(x, y, icon, color)
        {
            _sprite = new Sprite("Images/Map.png");
        }

        /// <param name="x">Position on the x axis</param>
        /// <param name="y">Position on the y axis</param>
        /// <param name="rayColor">The color of the symbol that will appear when drawn to raylib</param>
        /// <param name="icon">The symbol that will appear when drawn</param>
        /// <param name="color">The color of the symbol that will appear when drawn to the console</param>
        public Map1(float x, float y, Color rayColor, char icon = ' ', ConsoleColor color = ConsoleColor.White)
            : base(x, y, rayColor, icon, color)
        {
            _sprite = new Sprite("Images/Map.png");
        }

        public override void Update(float deltaTime)
        {

            base.Update(deltaTime);
        }

        public override void Draw()
        {
            _sprite.Draw(_globalTransform);
            base.Draw();
        }
    }
}
