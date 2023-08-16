using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
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
        private Texture2D _texture { get; set; }
        private SpriteFont _font { get; set; }
        private string _text { get; set; }
        private Color _color { get; set; }
        private Action _onClick { get; set; }

        public Button(Rectangle bounds, Texture2D texture, SpriteFont font, Color color, string text, Action action)
        {
            _bounds = bounds;
            _texture = texture;
            _font = font;
            _color = color;
            _text = text;
            _onClick = action;
        }

        public void Update()
        {
            // Handle Button Logic
            if (_bounds.Contains(Mouse.GetState().Position) && Mouse.GetState().LeftButton == ButtonState.Pressed)
            {
                _onClick?.Invoke(); // Trigger Assigned Action
            }
        }

        public void Draw(SpriteBatch spriteBatch)
        {
            // Draw Background
            spriteBatch.Draw(_texture, _bounds, _color);

            // Draw Text
            Vector2 textPosition = new Vector2( _bounds.X + _bounds.Width / 2, 
                                                _bounds.Y + _bounds.Height / 2);
            Vector2 textSize = _font.MeasureString(_text);
            textPosition -= textSize / 2;

            spriteBatch.DrawString(_font, _text, textPosition, _color);
        }
    }
}
