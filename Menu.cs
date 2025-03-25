using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ChepeEchenGrafos______
{
    class Menu
    {
        int option, direccion, vertex, vertices, origin, destination;
        Graphs graph;

        public Menu() { }

        public void Show()
        {
            Console.WriteLine("Aplicacion De Grafos");
            Console.WriteLine("====================");

            Console.WriteLine("¿Cuantos vertices tiene su grafo?");
            vertices = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("¿Su grafo tiene direccion? 1. Si 2. No");
            direccion = Convert.ToInt32(Console.ReadLine());

            if (direccion == 1)
            {
                graph = new Graphs(vertices, true);
            }

            else
            {
                graph = new Graphs(vertices, false);
            }

            while (true)
            {
                Operations(graph, ref option);
                if (option == 8) return;
            }
        }

        private void Operations(Graphs graph, ref int option)
        {
            Thread.Sleep(500);
            Console.WriteLine("1. Agregar un vertice");
            Console.WriteLine("2. Eliminar un vertice");
            Console.WriteLine("3. Agregar una arista");
            Console.WriteLine("4. Eliminar una arista");
            Console.WriteLine("5. Imprimir el grafo");
            Console.WriteLine("6. BFS");
            Console.WriteLine("7. DFS ");
            Console.WriteLine("8. Salir Del Programa");

            option = Convert.ToInt32(Console.ReadLine());

            switch (option)
            {
                case 1:
                    graph.AddVertex();
                    graph.Show();
                    break;
                case 2:
                    Console.Write("Introduzca el vertice que desea eliminar: ");
                    vertex = Convert.ToInt32(Console.ReadLine());

                    graph.DeleteVertex(vertex);
                    graph.Show();
                    break;
                case 3:
                    Console.Write("Introduzca el vertice de origen: ");
                    origin = Convert.ToInt32(Console.ReadLine());

                    Console.Write("Introduzca el vertice de destinacion: ");
                    destination = Convert.ToInt32(Console.ReadLine());

                    graph.AddEdge(origin, destination);
                    graph.Show();
                    break;
                case 4:
                    Console.Write("Introduzca el vertice de origen: ");
                    origin = Convert.ToInt32(Console.ReadLine());

                    Console.Write("Introduzca el vertice de destinacion: ");
                    destination = Convert.ToInt32(Console.ReadLine());

                    graph.DeleteEdge(origin, destination);
                    graph.Show();
                    break;
                case 5:
                    graph.Show();
                    break;
                case 6:
                    Console.Write("Introduzca el vertice donde desea empezar el recorrido: ");
                    vertex = Convert.ToInt32(Console.ReadLine());

                    graph.BFS(vertex);
                    break;
                case 7:
                    Console.Write("Introduzca el vertice donde desea empezar el recorrido: ");
                    vertex = Convert.ToInt32(Console.ReadLine());

                    graph.DFS(vertex);
                    break;
                case 8:
                    Console.WriteLine("Gracias Por Usar El Programa");
                    break;
                default:
                    Console.WriteLine("Introduzca una opcion valida");
                    break;
            }
        }
    }
}
