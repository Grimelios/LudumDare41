using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LudumDare41.Interfaces;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace LudumDare41.Core
{
	[Flags]
	public enum Alignments
	{
		Center = 0,
		Left = 1,
		Right = 2,
		Top = 4,
		Bottom = 8
	}

	public abstract class Component2D : IPositionable, IRotatable, IScalable, IColorable, IDynamic, IRenderable
	{
		protected Vector2 origin;

		protected Component2D()
		{
			Color = Color.White;
			Scale = Vector2.One;
		}

		public Vector2 Position { get; set; }
		public Vector2 Scale { get; set; }
		public Color Color { get; set; }

		public float Rotation { get; set; }

		public virtual void Update(float dt)
		{
		}

		public abstract void Draw(SuperBatch sb);
	}
}
