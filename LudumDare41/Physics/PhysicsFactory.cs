using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FarseerPhysics.Dynamics;
using FarseerPhysics.Factories;
using LudumDare41.Entities.Core;
using Microsoft.Xna.Framework;

namespace LudumDare41.Physics
{
	public static class PhysicsFactory
	{
		private static World world;

		public static void Initialize(World w)
		{
			world = w;
		}

		public static Body CreateRectangle(float width, float height, Units units, BodyType bodyType, Entity entity)
		{
			return CreateRectangle(width, height, Vector2.Zero, units, bodyType, entity);
		}

		public static Body CreateRectangle(float width, float height, Vector2 position, Units units, BodyType bodyType, Entity entity)
		{
			if (units == Units.Pixels)
			{
				width = PhysicsConvert.ToMeters(width);
				height = PhysicsConvert.ToMeters(height);
				position = PhysicsConvert.ToMeters(position);
			}

			Body body = BodyFactory.CreateRectangle(world, width, height, 1, position);
			body.BodyType = bodyType;
			body.UserData = entity;

			return body;
		}
	}
}
