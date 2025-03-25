using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChepeEchenGrafos______
{
    class Graphs
    {
        private int vertices;
        private bool direction;
        private List<List<int>> adjacencyList;

        public Graphs(int vertices, bool direction)
        {
            adjacencyList = new List<List<int>>();

            this.vertices = vertices;
            this.direction = direction;

            for (int i = 0; i < vertices; i++)
            {
                AddVertex();
            }
        }

        public void AddVertex()
        {
            adjacencyList.Add(new List<int>());
            vertices++;
        }

        public void DeleteVertex(int vertex)
        {
            if (vertex > vertices) return;

            for (int i = 0; i < adjacencyList.Count; i++)
            {
                if (adjacencyList[i].Contains(vertex))
                {
                    adjacencyList[i].Remove(vertex);
                }
            }

            adjacencyList.RemoveAt(vertex);
            vertices--;
        }

        public void AddEdge(int origin, int destination)
        {
            if (origin > vertices || destination > vertices) return;

            adjacencyList[origin].Add(destination);

            if (!direction && origin != destination)
            {
                adjacencyList[destination].Add(origin);
            }
        }

        public void DeleteEdge(int origin, int destination)
        {
            if (origin > vertices || destination > vertices) return;

            adjacencyList[origin].Remove(destination);

            if (!direction)
            {
                adjacencyList[destination].Remove(origin);
            }
        }

        public void Show()
        {
            int vertex = 0;
            foreach (var list in adjacencyList)
            {
                Console.Write("Vertice " + (vertex++) + " = { ");
                foreach (var node in list)
                {
                    Console.Write(node + " ");
                }
                Console.WriteLine("}");
            }
        }

        public void BFS(int startingPoint)
        {
            List<int> visited = new List<int>(vertices);
            Queue<int> nodes = new Queue<int>(vertices);
            int vertex = startingPoint;

            nodes.Enqueue(startingPoint);
            visited.Add(startingPoint);

            Console.Write("Breadth-First Search: { " + startingPoint + " ");

            while (nodes.Any())
            {
                vertex = nodes.Dequeue();
                foreach (var node in adjacencyList[vertex])
                {
                    if (!visited.Contains(node))
                    {
                        nodes.Enqueue(node);
                        visited.Add(node);
                        Console.Write(node + " ");
                    }
                }
            }
            Console.Write("}");
            Console.WriteLine();
        }

        public void DFS(int startingPoint)
        {
            List<int> visited = new List<int>(vertices);
            Stack<int> nodes = new Stack<int>(vertices);
            int vertex = startingPoint;

            nodes.Push(startingPoint);
            visited.Add(startingPoint);

            Console.Write("Depth-First Search: { " + startingPoint + " ");

            while (nodes.Any())
            {
                vertex = nodes.Pop();

                if (!visited.Contains(vertex))
                {
                    Console.Write(vertex + " ");
                    visited.Add(vertex);
                }

                foreach (var node in adjacencyList[vertex])
                {
                    if (!visited.Contains(node))
                    {
                        nodes.Push(node);
                    }
                }
            }
            Console.Write("}");
            Console.WriteLine();
        }
    }
}
