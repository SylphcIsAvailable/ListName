using System;
using System.Collections.Generic;

namespace GameObjectExample
{
    public class GameObject
    {
        public string Name { get; set; }
        public string TagClass { get; set; }
        public int Layer { get; set; } = 0;
        public bool IsActiveAndEnabled { get; set; } = true;
        public HideFlags HideFlags { get; set; } = HideFlags.None;
        public bool IsStatic { get; set; } = false;
    }

    [Flags]
    public enum HideFlags
    {
        None = 0,
        HideInHierarchy = 1 << 0,
    }

    class Program
    {
        static void Main(string[] args)
        {
            var myList = new List<GameObject>
            {
                new GameObject { Name = "Game", TagClass = "0", Layer = 2, HideFlags = HideFlags.HideInHierarchy },
                new GameObject { Name = "Player", TagClass = "1" },
                new GameObject { Name = "Enemy", TagClass = "2" },
                new GameObject { Name = "Walls", TagClass = "3" },
                new GameObject { Name = "Powerups", TagClass = "4" },
                new GameObject { Name = "Boss", TagClass = "5" },
                new GameObject { Name = "NPC", TagClass = "6" },
                new GameObject { Name = "Lives", TagClass = "7" },
                new GameObject { Name = "Weapon", TagClass = "8" },
                new GameObject { Name = "Money", TagClass = "9" }
            };

            foreach (var obj in myList)
            {
                Console.WriteLine($"Name: {obj.Name}, TagClass: {obj.TagClass}");
            }
        }
    }
}
