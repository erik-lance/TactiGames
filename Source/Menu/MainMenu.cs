using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TactiGames.Source.UI;

namespace TactiGames.Source.Menu
{
    public class MainMenu
    {
        private SpriteBatch _spriteBatch;

        private Button _checkersButton;
        private Button _quitButton;

        public MainMenu(SpriteBatch spriteBatch)
        {
            _spriteBatch = spriteBatch;

            // Load Buttons
            _checkersButton = new Button(new Rectangle(100, 100, 200, 100), null, null, Color.White, "Checkers", LaunchGame);
            _quitButton = new Button(new Rectangle(100, 250, 200, 100), null, null, Color.White, "Quit", QuitGame);
        }

        public void Update(GameTime gameTime)
        {

        }

        public void Draw(GameTime gameTime)
        {
            // Draws the menu UI

        }

        // Button Actions
        private void LaunchGame()
        {

        }

        private void QuitGame()
        {
            
        }
    }
}
