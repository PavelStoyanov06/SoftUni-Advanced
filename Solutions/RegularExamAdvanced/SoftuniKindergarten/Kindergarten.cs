using System;
using System.Collections.Generic;
using System.Linq;

namespace SoftUniKindergarten
{
    public class Kindergarten
    {
        private string name;
        private int capacity;
        private List<Child> registry;

        public Kindergarten(string name, int capacity)
        {
            this.name = name;
            this.capacity = capacity;
            registry = new List<Child>();
        }

        public string Name { get { return name; } set { name = value; } }
        public int Capacity { get { return capacity;} set { capacity = value; } }
        public List<Child> Registry { get { return registry; } set { registry = value;} }

        public bool AddChild(Child child)
        {
            if(registry.Count < capacity)
            {
                registry.Add(child);
                return true;
            }
            return false;

        }

        public bool RemoveChild(string childFullName)
        {
            if(registry.Any(x => $"{x.FirstName} {x.LastName}" == childFullName))
            {
                registry.Remove(registry.First(x => $"{x.FirstName} {x.LastName}" == childFullName));
                
                return true;
            }

            return false;
        }

        public int ChildrenCount { get { return registry.Count; } }

        public Child GetChild(string childFullName)
        {
            if(registry.Any(x => $"{x.FirstName} {x.LastName}" == childFullName))
            {
                return registry.First(x => $"{x.FirstName} {x.LastName}" == childFullName);
            }

            return null;
        }

        public string RegistryReport()
        {
            registry = registry
                .OrderBy(x => x.FirstName)
                .OrderBy(x => x.LastName)
                .OrderByDescending(x => x.Age)
                .ToList();
            
            string result = $"Registered children in {name}:{Environment.NewLine}{String.Join(Environment.NewLine, registry)}";

            return result;
        }
    }
}
