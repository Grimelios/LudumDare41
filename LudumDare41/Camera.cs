using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LudumDare41.Interfaces;
using Microsoft.Xna.Framework;

namespace LudumDare41
{
	public enum CameraModes
	{
		Fixed,
		Follow
	}

	public class Camera : IPositionable, IRotatable, IDynamic
	{
		private Vector2 origin;

		public Camera()
		{
			Zoom = 1;
			Mode = CameraModes.Fixed;
		}

		public Vector2 Position { get; set; }
		public Matrix View { get; private set; }

		public float Rotation { get; set; }
		public float Zoom { get; set; }

		public CameraModes Mode { get; set; }

		public void Update(float dt)
		{
			switch (Mode)
			{
				case CameraModes.Fixed:
					break;

				case CameraModes.Follow:
					break;
			}

			View = Matrix.CreateTranslation(new Vector3(origin - Position, 0)) * Matrix.CreateRotationZ(Rotation);
		}
	}
}
