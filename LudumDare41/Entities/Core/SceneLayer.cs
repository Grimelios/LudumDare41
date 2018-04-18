using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LudumDare41.Interfaces;
using LudumDare41.Structures;

namespace LudumDare41.Entities.Core
{
	public class SceneLayer : IDynamic, IRenderable
	{
		private EntityTypes[] updateOrder;
		private EntityTypes[] drawOrder;

		private SafeList<Entity>[] entities;

		public SceneLayer(EntityTypes[] updateOrder, EntityTypes[] drawOrder)
		{
			this.updateOrder = updateOrder;
			this.drawOrder = drawOrder;
			
			entities = new SafeList<Entity>[GameFunctions.EnumCount<EntityTypes>()];

			for (int i = 0; i < entities.Length; i++)
			{
				entities[i] = new SafeList<Entity>();
			}
		}

		public IEnumerable<Entity> GetList(EntityTypes type)
		{
			return entities[(int)type].MainList;
		}

		public void Add(Entity entity)
		{
			entities[(int)entity.EntityType].Add(entity);
		}

		public void Add(Entity[] entities)
		{
			this.entities[(int)entities[0].EntityType].Add(entities);
		}

		public void Add(List<Entity> entities)
		{
			this.entities[(int)entities[0].EntityType].Add(entities);
		}

		public void Remove(Entity entity)
		{
			entities[(int)entity.EntityType].Remove(entity);
		}

		public void Remove(Entity[] entities)
		{
			this.entities[(int)entities[0].EntityType].Remove(entities);
		}

		public void Remove(List<Entity> entities)
		{
			this.entities[(int)entities[0].EntityType].Remove(entities);
		}

		public void Update(float dt)
		{
			foreach (EntityTypes type in updateOrder)
			{
				foreach (Entity entity in entities[(int)type].MainList)
				{
					entity.Update(dt);
				}
			}
		}

		public void Draw(SuperBatch sb)
		{
			foreach (EntityTypes type in drawOrder)
			{
				foreach (Entity entity in entities[(int)type].MainList)
				{
					entity.Draw(sb);
				}
			}
		}
	}
}
