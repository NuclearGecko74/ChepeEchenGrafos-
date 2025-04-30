# Aplicacion de Grafos

Este programa implementa una estructura de grafos utilizando una lista de adyacencia. El usuario puede crear un grafo dirigido o no dirigido, añadir o eliminar vertices/aristas, imprimir el grafo y realizar busquedas BFS y DFS. Todo esto se controla mediante un menu interactivo en consola.

---

## Archivos

### `Program.cs`
Contiene el metodo `Main`, que crea una instancia del menu e inicia el programa:

```csharp
Menu menu = new Menu();
menu.Show();
```

---

### `Graphs.cs`
Ubicado en el namespace `DataStructures`, define la estructura del grafo y sus operaciones principales.

- **Atributos**:
  - `adjacencyList`: Lista de listas que representa la lista de adyacencia.
  - `vertices`: Numero de vertices.
  - `isDirected`: Define si el grafo es dirigido.

- **Metodos principales**:
  - `AddVertex()`: Agrega un solo vertice.
  - `AddVertices(int num)`: Agrega multiples vÃ©rtices.
  - `AddEdge(int origin, int destination)`: Agrega una arista entre dos vertices.
  - `RemoveVertex(int vertex)`: Elimina un vertice del grafo.
  - `RemoveEdge(int origin, int destination)`: Elimina una arista del grafo.
  - `Show()`: Muestra la lista de adyacencia.
  - `BFS(int start)`: Busqueda en anchura desde un vertice.
  - `DFS(int start)`: Busqueda en profundidad desde un vertice.

Tambien incluye validaciones internas como `ContainsVertex()` y `ContainsEdge()` para asegurar operaciones seguras.

---

### `Menu.cs`
Ubicado en el namespace `Graph`. Se encarga de mostrar el menÃº al usuario y manejar sus interacciones.

- Al iniciar, el programa:
  - Pide el numero inicial de vertices.
  - Pregunta si el grafo sera¡ dirigido o no.
  - Crea una instancia de la clase `Graphs`.

- Opciones disponibles:
  1. Agregar un vertice  
  2. Agregar multiples vertices  
  3. Eliminar un vertice  
  4. Agregar una arista  
  5. Eliminar una arista  
  6. Mostrar el grafo  
  7. Busqueda en anchura (BFS)  
  8. Busqueda en profundidad (DFS)  
  9. Mostrar numero de vertices  
  10. Salir del programa  

---

## Ejemplo de uso

```plaintext
Aplicacion De Grafos
====================
Â¿Cuantos vertices tiene su grafo?
5
Â¿Su grafo tiene direccion? 1. Si 2. No
2

1. Agregar un vertice
2. Agregar vertices
3. Eliminar un vertice
4. Agregar una arista
5. Eliminar una arista
6. Imprimir el grafo
7. BFS
8. DFS
9. Numero de vertices
10. Salir Del Programa
```

---