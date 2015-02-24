// ============================= MainMenu.cs =================================
//  The games main menu; responsible for showing the intro screen, showing
//   the different menu options, and initiating different game features.
// ===========================================================================
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework;

namespace GunSmith
{
    public class MainMenu
    {
        // Handles image rendering
        public static SpriteBatch spriteBatch;

        // Renders the main menu of the game; displays menu choices in addition to
        // handling menu controls and transitions.
        public static void RenderMenu()
        {
            // Render a test graphic
            spriteBatch.Begin();
            spriteBatch.Draw(Game1.TitleGraphic, 
                new Vector2(Game1.currentWindowWidth / 2, Game1.currentWindowHeight / 15), 
                null, Color.White, 0, new Vector2(Game1.TitleGraphic.Width / 2, 0), 1, 
                SpriteEffects.None, 0);
            spriteBatch.End();
        }
    }
}
