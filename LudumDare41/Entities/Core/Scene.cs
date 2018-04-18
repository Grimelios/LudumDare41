using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LudumDare41.Interfaces;
using LudumDare41.Json;

namespace LudumDare41.Entities.Core
{
	public class Scene : IDynamic, IRenderable
	{
		private SceneLayer[] layers;

		public Scene()
		{
			layers = JsonUtilities.Deserialize<SceneLayer[]>("Layers.json");
		}

		public void Add(Entity entity, int layer = 0)
		{
			layers[layer].Add(entity);
			entity.Scene = this;
		}

		public void Add(Entity[] entities, int layer = 0)
		{
			layers[layer].Add(entities);

			foreach (Entity entity in entities)
			{
				entity.Scene = this;
			}
		}

		public void Add(List<Entity> entities, int layer = 0)
		{
			layers[layer].Add(entities);
			entities.ForEach(e => e.Scene = this);
		}

		public void Remove(Entity entity, int layer = 0)
		{
			layers[layer].Remove(entity);
		}

		public void Remove(Entity[] entities, int layer = 0)
		{
			layers[layer].Remove(entities);
		}

		public void Remove(List<Entity> entities, int layer = 0)
		{
			layers[layer].Remove(entities);
		}

		public void Update(float dt)
		{
			foreach (SceneLayer layer in layers)
			{
				layer.Update(dt);
			}
		}

		public void Draw(SuperBatch sb)
		{
			foreach (SceneLayer layer in layers)
			{
				layer.Draw(sb);
			}
		}
	}
}
