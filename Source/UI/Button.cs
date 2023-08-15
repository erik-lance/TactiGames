using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TactiGames.Source.UI
{
    public class Button
    {
        public Rectangle Bounds { get; private set; }
        public string Text { get; private set; }

        public Button(Rectangle bounds, string text)
        {
            Bounds = bounds;
            Text = text;
        }

        public bool IsClicked(Point clickPosition)
        {
            return Bounds.Contains(clickPosition);
        }
    }
}
