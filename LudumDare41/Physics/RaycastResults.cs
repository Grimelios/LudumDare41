using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FarseerPhysics.Dynamics;
using LudumDare41.Entities.Core;
using Microsoft.Xna.Framework;

namespace LudumDare41.Physics
{
	public class RaycastResults
	{
		public RaycastResults(Vector2 position, Entity entity, Body body, object fixtureData)
		{
			Position = position;
			Entity = entity;
			Body = body;
			FixtureData = fixtureData;
		}

		public Vector2 Position { get; }
		public Entity Entity { get; }
		public Body Body { get; }
		
		public object FixtureData { get; }
	}
}
