# AplicaciÃ³n de Grafos

Este programa implementa una estructura de grafos utilizando una lista de adyacencia. El usuario puede crear un grafo dirigido o no dirigido, aÃ±adir o eliminar vÃ©rtices/aristas, imprimir el grafo y realizar bÃºsquedas BFS y DFS. Todo esto se controla mediante un menÃº interactivo en consola.

---

## Archivos

### `Program.cs`
Contiene el mÃ©todo `Main`, que crea una instancia del menÃº e inicia el programa:

```csharp
Menu menu = new Menu();
menu.Show();
```

---

### `Graphs.cs`
Ubicado en el namespace `DataStructures`, define la estructura del grafo y sus operaciones principales.

- **Atributos**:
  - `adjacencyList`: Lista de listas que representa la lista de adyacencia.
  - `vertices`: NÃºmero de vÃ©rtices.
  - `isDirected`: Define si el grafo es dirigido.

- **MÃ©todos principales**:
  - `AddVertex()`: Agrega un solo vÃ©rtice.
  - `AddVertices(int num)`: Agrega mÃºltiples vÃ©rtices.
  - `AddEdge(int origin, int destination)`: Agrega una arista entre dos vÃ©rtices.
  - `RemoveVertex(int vertex)`: Elimina un vÃ©rtice del grafo.
  - `RemoveEdge(int origin, int destination)`: Elimina una arista del grafo.
  - `Show()`: Muestra la lista de adyacencia.
  - `BFS(int start)`: BÃºsqueda en anchura desde un vÃ©rtice.
  - `DFS(int start)`: BÃºsqueda en profundidad desde un vÃ©rtice.

TambiÃ©n incluye validaciones internas como `ContainsVertex()` y `ContainsEdge()` para asegurar operaciones seguras.

---

### `Menu.cs`
Ubicado en el namespace `Graph`. Se encarga de mostrar el menÃº al usuario y manejar sus interacciones.

- Al iniciar, el programa:
  - Pide el nÃºmero inicial de vÃ©rtices.
  - Pregunta si el grafo serÃ¡ dirigido o no.
  - Crea una instancia de la clase `Graphs`.

- Opciones disponibles:
  1. Agregar un vÃ©rtice  
  2. Agregar mÃºltiples vÃ©rtices  
  3. Eliminar un vÃ©rtice  
  4. Agregar una arista  
  5. Eliminar una arista  
  6. Mostrar el grafo  
  7. BÃºsqueda en anchura (BFS)  
  8. BÃºsqueda en profundidad (DFS)  
  9. Mostrar nÃºmero de vÃ©rtices  
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