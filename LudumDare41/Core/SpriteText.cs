using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace LudumDare41.Core
{
	public class SpriteText : Component2D
	{
		private SpriteFont font;
		private Alignments alignment;
		private string value;

		public SpriteText(string font, string value, Alignments alignment = Alignments.Left | Alignments.Top) :
			this(ContentLoader.LoadFont(font), value, alignment)
		{
		}

		public SpriteText(SpriteFont font, string value, Alignments alignment = Alignments.Left | Alignments.Top)
		{
			this.font = font;
			this.alignment = alignment;

			Value = value;
		}

		public string Value
		{
			get => value;
			set
			{
				this.value = value;

				if (value != null)
				{
					Vector2 dimensions = font.MeasureString(value);
					origin = GameFunctions.ComputeOrigin(alignment, (int)dimensions.X, (int)dimensions.Y);
				}
			}
		}

		public override void Draw(SuperBatch sb)
		{
			sb.DrawString(font, value, Position, Color, Rotation, origin, Scale);
		}
	}
}
