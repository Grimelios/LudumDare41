using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace LudumDare41
{
	public class SuperBatch
	{
		private Camera camera;
		private SpriteBatch sb;

		public SuperBatch(Camera camera, SpriteBatch sb)
		{
			this.camera = camera;
			this.sb = sb;
		}

		public void Begin()
		{
			sb.Begin();
		}

		public void End()
		{
			sb.End();
		}

		public void Draw(Texture2D texture, Vector2 position, Rectangle? sourceRect, Color color, float rotation, Vector2 origin,
			Vector2 scale, SpriteEffects effects)          
		{
			sb.Draw(texture, position, sourceRect, color, rotation, origin, scale, effects, 0);
		}

		public void DrawString(SpriteFont font, string value, Vector2 position, Color color, float rotation, Vector2 origin,
			Vector2 scale)
		{
			sb.DrawString(font, value, position, color, rotation, origin, scale, SpriteEffects.None, 0);
		}
	}
}
