using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework.Graphics;

namespace LudumDare41.Core
{
	public class Sprite : Component2D
	{
		private Texture2D texture;

		public Sprite(string filename, Alignments alignment = Alignments.Center) :
			this(ContentLoader.LoadTexture(filename), alignment)
		{
		}

		public Sprite(Texture2D texture, Alignments alignment = Alignments.Center)
		{
			this.texture = texture;

			origin = GameFunctions.ComputeOrigin(alignment, texture.Width, texture.Height);
		}

		public override void Draw(SpriteBatch sb)
		{
		}
	}
}
