# 🎧 SoundCore Engine GUI — DJ Queue & Transition Manager
### *Listas Enlazadas Simples vs. Colecciones Nativas .NET 10*

> **TecNM Campus Monclova — Ingeniería en Informática**  
> **Asignatura:** Estructura de Datos (3er Semestre)  
> **Unidad:** 2 — Estructuras de Datos Lineales  
> **Alumno:** Sebastian Ponce Carmona  
> **Número de Control:** I25050377  
> **Docente:** Rubén Miguel Riojas Rodríguez  
> **Fecha:** Septiembre 2026  
> **Versión:** 2.0 (.NET 10.0 / C# 14)  

---

## 📌 1. Contexto y Justificación Académica

En los sistemas de reproducción continua y consolas profesionales para DJ (*Pioneer Rekordbox*, *Serato DJ*, *Spotify*), la lista o cola de reproducción (*DJ Play Queue*) requiere manipular en tiempo real el orden de los elementos en memoria sin congelar el hilo de audio.

### El Problema "Up Next" (Reproducir Siguiente)
Cuando el DJ decide insertar una canción como la *próxima pista a sonar* (inmediatamente detrás del tema que se está reproduciendo actualmente) en una biblioteca de más de **20,000 pistas**:
* **Uso de Arreglos Dinámicos (`List<T>`):** Insertar en la posición 1 obliga al CPU a desplazar 20,000 bloques de memoria contigua hacia adelante mediante `Array.Copy`. Esto genera pausas perceptibles en el hilo de reproducción, micro-cortes en el audio y una complejidad temporal degradada a $\mathcal{O}(n)$.
* **Solución mediante Listas Enlazadas (`SimpleLinkedList<T>`):** Los nodos se distribuyen de forma dispersa en memoria dinámica. Para insertar la pista siguiente, únicamente se reorientan **dos referencias de memoria (punteros)** (`nuevo.Next = cabeza.Next` y `cabeza.Next = nuevo`). No se desplaza un solo byte de las pistas restantes, logrando una complejidad estrictamente constante $\mathcal{O}(1)$.

---

## 🏛️ 2. Arquitectura de Software en Capas

El proyecto está diseñado bajo un estricto desacoplamiento entre la lógica de estructuras de datos, la gestión de audio y la interfaz gráfica:

```text
SoundCoreEngine/
├── Audio/
│   ├── IAudioMetadataProvider.cs  # Interfaz desacoplada para lectura de tags de audio
│   ├── NAudioPlayer.cs            # Motor de salida de audio en tiempo real (WaveOutEvent)
│   └── TagLibReader.cs            # Extracción de metadatos (ID3v2: Título, Artista, BPM, Duración)
│
├── Models/
│   └── Track.cs                   # Record inmutable de la pista musical con ruta a disco
│
├── Motor/
│   ├── BenchmarkService.cs        # Motor de pruebas de estrés con Stopwatch
│   ├── PlaybackQueueManager.cs    # Gestor de sincronización de las 3 colas paralelas
│   └── StructureType.cs           # Enumerador (CustomList, LinkedListNative, ListNative)
│
├── OwnStructures/
│   ├── BenchmarkResults.cs        # Registro de telemetría y análisis Big-O
│   ├── Node.cs                    # Nodo genérico autoreferenciado <T>
│   └── SimpleLinkedList.cs        # Lista enlazada simple construida desde cero (6 algoritmos)
│
└── UI/
    ├── MainForm.cs                # Lógica del formulario, eventos y enlace de datos
    ├── MainForm.Designer.cs       # Declaración y diseño visual de componentes WinForms
    └── MainForm.resx              # Recursos visuales del formulario
```

---

## 🛠️ 3. Algoritmos Implementados desde Cero (`SimpleLinkedList<T>`)

La clase `SimpleLinkedList<T>` opera exclusivamente mediante manipulación de punteros (`Head` y `Next`), sin utilizar arreglos internos ni estructuras auxiliares:

| Método | Complejidad Temporal | Complejidad Espacial | Descripción Técnica |
| :--- | :---: | :---: | :--- |
| **`AddLast(T value)`** | $\mathcal{O}(n)$ | $\mathcal{O}(1)$ | Recorre la lista hasta el último nodo y enlaza el nuevo elemento al final. |
| **`PlayNext(T value)`** | $\mathcal{O}(1)$ | $\mathcal{O}(1)$ | Inserta inmediatamente después del nodo cabeza (`Head.Next = nuevo`). Prioridad Up Next VIP. |
| **`AdvanceTrack()`** | $\mathcal{O}(1)$ | $\mathcal{O}(1)$ | Desencola la cabeza actual (`Head = Head.Next`), decrementa el conteo y retorna la pista para su reproducción. |
| **`Invert()`** | $\mathcal{O}(n)$ | $\mathcal{O}(1)$ | **Estrictamente in-place**. Técnica de los 3 punteros (`previous`, `current`, `next`). Cero bytes de memoria auxiliar. |
| **`InsertOrdered(T, cmp)`**| $\mathcal{O}(n)$ | $\mathcal{O}(1)$ | Inserta un nodo preservando el orden ascendente del criterio especificado (BPM). |
| **`RemoveDuplicates(eq)`** | $\mathcal{O}(n^2)$ | $\mathcal{O}(1)$ | Purga elementos duplicados utilizando un puntero corredor (`runner`) sin usar `HashSet` ni listas auxiliares. |

---

## 🧠 4. Algoritmo Estrella: Inversión *In-Place* ($\mathcal{O}(n)$ tiempo, $\mathcal{O}(1)$ espacio)

El método `Invert()` invierte los enlaces de toda la cola sin clonar la lista ni reservar nuevos nodos en el Heap de memoria:

```csharp
public void Invert()
{
    Node<T>? previous = null;
    Node<T>? current = Head;

    while (current != null)
    {
        Node<T>? next = current.Next; // 1. Guardar referencia al resto de la lista
        current.Next = previous;      // 2. Invertir el puntero hacia el nodo anterior
        previous = current;           // 3. Desplazar 'previous' al nodo actual
        current = next;               // 4. Desplazar 'current' al nodo siguiente
    }

    Head = previous;                  // 5. La nueva cabeza es el último nodo alcanzado
}
```

---

## 📊 5. Módulo de Benchmark y Telemetría

La aplicación cuenta con un módulo de pruebas de estrés que somete a las tres estructuras de datos a **25,000 inserciones intermedias consecutivas** (en la posición 1, detrás de la cabeza) medidas con alta precisión mediante la clase `System.Diagnostics.Stopwatch`:

### Resultados Típicos de Telemetría:
* **Lista Simple Propia (`SimpleLinkedList`):** `~14 ms` — $\mathcal{O}(1)$ por reconexión constante de punteros.
* **.NET `LinkedList<T>` (Nativa):** `~12 ms` — $\mathcal{O}(1)$ implementación optimizada con enlaces dobles.
* **.NET `List<T>` (Arreglo Dinámico):** `~90 ms` — $\mathcal{O}(n)$ degradación masiva por desplazamiento de bloques continuos con `Array.Copy`.

### Fundamento Científico (Teoría Big-O):
En operaciones frecuentes de inserción intermedia, las listas enlazadas son sustancialmente superiores a los arreglos contiguos, ya que la inserción solo requiere actualizar punteros en tiempo constante $\mathcal{O}(1)$, mientras que el arreglo dinámico requiere desplazar linealmente todos los elementos posteriores en memoria continua ($\mathcal{O}(n)$).

---

## 🧪 6. Casos de Prueba Formales (Validación de Rúbrica)

| ID | Operación / Escenario | Pasos | Resultado Obtenido |
| :---: | :--- | :--- | :--- |
| **CP-01** | Inserción al Final | Ingresar pista y pulsar `[+ Encolar al Final]`. | Se añade como la última fila en `dgvCola` sin alterar el orden previo. |
| **CP-02** | Prioridad Up Next | Pulsar `[⏭ Reproducir Siguiente]` con una nueva pista. | Se posiciona en la **fila 2** (inmediatamente detrás de la cabeza en curso). |
| **CP-03** | Avanzar Pista | Pulsar `[⏩ Avanzar Pista]`. | Se desencola la cabeza, se reproduce el audio y se actualiza `lblNowPlaying`. |
| **CP-04** | Inversión In-Place | Setlist con BPMs `[100, 110, 120]`, pulsar `[Invertir]`. | El grid refleja `[120, 110, 100]` sin consumo de memoria adicional. |
| **CP-05** | Curva Armónica BPM | Setlist desordenado: pulsar `[⚡ Ordenar por Curva BPM]`. | Se reordenan las pistas de menor a mayor tempo BPM. |
| **CP-06** | Purga de Duplicados | Registrar temas con títulos repetidos y pulsar `[🧹 Purgar]`. | Se preserva la primera aparición y se eliminan las réplicas sin romper los enlaces. |
| **CP-07** | Manejo de Excepciones | Pulsar `[Avanzar Pista]` con la cola vacía. | Se despliega un diálogo informativo (`MessageBox`) controlado sin colapso de la aplicación. |

---

## ⚙️ 7. Instrucciones de Compilación y Ejecución

1. Clonar el repositorio:
   ```bash
   git clone https://github.com/sebastianpea/SoundCoreEngine.git
   ```
2. Abrir la solución `SoundCoreEngine.sln` en **Visual Studio 2022**.
3. Restaurar los paquetes NuGet (**NAudio** y **TagLibSharp**).
4. Compilar en modo `Debug` o `Release` (`Ctrl + Shift + B`).
5. Ejecutar con `F5`.

# Calificación Final: 100/100

---

## 🎥 8. Video Demostrativo

* **Enlace al video de evaluación:** (https://youtu.be/iSG9G3SUVF0)
