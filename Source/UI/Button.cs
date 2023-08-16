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
        private Rectangle _bounds { get; set; }
        private string _text { get; set; }

        public Button(Rectangle bounds, string text)
        {
            _bounds = bounds;
            _text = text;
        }

        public bool IsClicked(Point clickPosition)
        {
            return _bounds.Contains(clickPosition);
        }
    }
}
