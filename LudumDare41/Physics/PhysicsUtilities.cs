using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FarseerPhysics.Dynamics;
using Microsoft.Xna.Framework;

namespace LudumDare41.Physics
{
	public static class PhysicsUtilities
	{
		private static World world;

		public static void Initialize(World w)
		{
			world = w;
		}

		public static RaycastResults Raycast(Vector2 start, Vector2 direction, float range)
		{
			return Raycast(start, start + direction * range);
		}

		public static RaycastResults Raycast(Vector2 start, Vector2 end)
		{
			return null;
		}
	}
}
