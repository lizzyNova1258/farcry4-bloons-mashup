using System;
using System.Collections.Generic;
using System.Linq;

namespace FarCry4BloonsMashup
{
    public class DefenseMode
    {
        public int Cash { get; set; } = 500;
        public int OutpostHealth { get; set; } = 100;
        public int WaveIndex { get; set; } = 0;
        public bool IsActive { get; set; }
        public List<Tower> PlacedTowers { get; set; } = new();
        public List<Enemy> ActiveEnemies { get; set; } = new();

        public void StartSiege()
        {
            if (IsActive) return;
            IsActive = true;
            WaveIndex = 1;
            Cash += 100;
            OutpostHealth = 100;
        }

        public void PlaceTower(string towerId, float x, float y, float z)
        {
            var tower = CreateTower(towerId);
            if (tower != null && Cash >= tower.Cost)
            {
                Cash -= tower.Cost;
                tower.Position = new Vector3(x, y, z);
                PlacedTowers.Add(tower);
            }
        }

        public void UpgradeTower(Tower tower)
        {
            if (tower.Level < 3)
            {
                int upgradeCost = tower.Level == 1 ? 100 : 200;
                if (Cash >= upgradeCost)
                {
                    Cash -= upgradeCost;
                    tower.Level++;
                    tower.ApplyUpgrade();
                }
            }
        }

        private Tower CreateTower(string towerId)
        {
            return towerId switch
            {
                "dart_monkey" => new Tower { TowerId = towerId, Name = "Dart Monkey", Cost = 120, Damage = 9, Range = 22, FireRate = 1.2f },
                "tack_shooter" => new Tower { TowerId = towerId, Name = "Tack Shooter", Cost = 170, Damage = 6, Range = 18, FireRate = 0.8f },
                "sniper_monkey" => new Tower { TowerId = towerId, Name = "Sniper Monkey", Cost = 220, Damage = 25, Range = 36, FireRate = 0.9f },
                "bomb_shooter" => new Tower { TowerId = towerId, Name = "Bomb Shooter", Cost = 260, Damage = 18, Range = 20, FireRate = 1.0f },
                _ => null
            };
        }
    }

    public class Tower
    {
        public string TowerId { get; set; }
        public string Name { get; set; }
        public int Cost { get; set; }
        public float Damage { get; set; }
        public float Range { get; set; }
        public float FireRate { get; set; }
        public int Level { get; set; } = 1;
        public Vector3 Position { get; set; }
        public float FireTimer { get; set; }

        public void ApplyUpgrade()
        {
            Damage *= 1.5f;
            Range *= 1.1f;
        }
    }

    public class Enemy
    {
        public string Type { get; set; }
        public float Health { get; set; }
        public float MaxHealth { get; set; }
        public float Speed { get; set; }
        public float Reward { get; set; }
        public Vector3 Position { get; set; }
    }

    public class Vector3
    {
        public float X { get; set; }
        public float Y { get; set; }
        public float Z { get; set; }
    }
}
