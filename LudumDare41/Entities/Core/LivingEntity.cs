using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LudumDare41.Entities.Core
{
	public abstract class LivingEntity : Entity
	{
		public delegate void HealthHandler(int value, int previousValue);

		private int health;
		private int maxHealth;

		protected LivingEntity(EntityTypes entityType) : base(entityType)
		{
		}

		public event HealthHandler HealthChangeEvent;
		public event HealthHandler MaxHealthChangeEvent;

		public int Health
		{
			get => health;
			set
			{
				int previousHealth = health;

				health = value;

				if (health != previousHealth)
				{
					HealthChangeEvent?.Invoke(health, previousHealth);
				}
			}
		}

		public int MaxHealth
		{
			get => maxHealth;
			set
			{
				int previousMaxHealth = maxHealth;

				maxHealth = value;

				if (maxHealth != previousMaxHealth)
				{
					MaxHealthChangeEvent?.Invoke(maxHealth, previousMaxHealth);
				}
			}
		}
	}
}
