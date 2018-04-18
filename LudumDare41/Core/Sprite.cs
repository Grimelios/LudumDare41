using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace LudumDare41.Core
{
	public class Sprite : Component2D
	{
		private Texture2D texture;
		private Rectangle? sourceRect;

		public Sprite(string filename, Rectangle? sourceRect, Alignments alignment = Alignments.Center) :
			this(ContentLoader.LoadTexture(filename), sourceRect, alignment)
		{
		}

		public Sprite(Texture2D texture, Rectangle? sourceRect, Alignments alignment = Alignments.Center)
		{
			this.texture = texture;
			this.sourceRect = sourceRect;

			origin = GameFunctions.ComputeOrigin(alignment, texture.Width, texture.Height);
		}

		public bool FlipHorizontal { get; set; }
		public bool FlipVertical { get; set; }

		public override void Draw(SuperBatch sb)
		{
			SpriteEffects effects = SpriteEffects.None;

			if (FlipHorizontal)
			{
				effects &= SpriteEffects.FlipHorizontally;
			}

			if (FlipVertical)
			{
				effects &= SpriteEffects.FlipVertically;
			}

			sb.Draw(texture, Position, sourceRect, Color, Rotation, origin, Scale, effects);
		}
	}
}
