using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LudumDare41.Core;
using Microsoft.Xna.Framework;

namespace LudumDare41
{
	public static class GameFunctions
	{
		public static Vector2 ComputeOrigin(Alignments alignments, int width, int height)
		{
			bool left = (alignments & Alignments.Left) > 0;
			bool right = (alignments & Alignments.Right) > 0;
			bool top = (alignments & Alignments.Top) > 0;
			bool bottom = (alignments & Alignments.Bottom) > 0;

			int x = left ? 0 : (right ? width : width / 2);
			int y = top ? 0 : (bottom ? height : height / 2);

			return new Vector2(x, y);
		}

		public static int EnumCount<T>()
		{
			return Enum.GetValues(typeof(T)).Length;
		}
	}
}
