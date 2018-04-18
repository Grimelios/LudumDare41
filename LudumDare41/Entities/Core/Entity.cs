using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LudumDare41.Interfaces;
using Microsoft.Xna.Framework;

namespace LudumDare41.Entities.Core
{
	public enum EntityTypes
	{
		Player,
		World
	}

	public abstract class Entity : IPositionable, IRotatable, IDynamic, IRenderable
	{
		protected Entity(EntityTypes entityType)
		{
			EntityType = entityType;
		}

		public Vector2 Position { get; set; }
		public Scene Scene { get; set; }

		public float Rotation { get; set; }

		public EntityTypes EntityType { get; }

		public virtual void Update(float dt)
		{
		}

		public virtual void Draw(SuperBatch sb)
		{
		}
	}
}
