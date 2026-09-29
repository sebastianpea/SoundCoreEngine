# 🎧 SoundCore Engine GUI — DJ Queue & Transition Manager
### *Listas Enlazadas Simples vs. Colecciones Nativas .NET 10*

> **TecNM Campus Monclova — Ingeniería en Informática**  
> **Asignatura:** Estructura de Datos (3er Semestre)  
> **Unidad:** 2 — Estructuras de Datos Lineales  
> **Alumno:** Sebastian Ponce Carmona  
> **Número de Control:** I25050377  
> **Docente:** [NOMBRE_DEL_PROFESOR]  
> **Fecha:** Septiembre 2026  

---

## 📌 1. Descripción del Proyecto
Implementación y confrontación empírica de una **Lista Enlazada Simple genérica construida desde cero** (`ListaSimpleEnlazada<T>`), frente a las colecciones nativas estándar de .NET 10 (`LinkedList<T>` y `List<T>`).

El sistema simula un controlador de DJ (*Up Next Queue*) donde la inserción inmediata de pistas detrás de la cabeza se realiza en tiempo constante $O(1)$ sin generar cuellos de botella por desplazamiento de memoria.

---

## ⚙️ 2. Requisitos Técnicos
* **Lenguaje:** C# 14 / .NET 10.0 (`net10.0-windows`)
* **Librerías:** BCL de .NET y NAudio (para salida y reproducción de audio en tiempo real)
* **Arquitectura:** Separación en capas (`Modelos`, `EstructurasPropias`, `Audio`, `UI`)

---

## 🛠️ 3. Algoritmos Implementados desde Cero
1. **`AgregarAlFinal(T valor)`:** Encolado al final de la sesión de DJ ($O(n)$).
2. **`ReproducirSiguiente(T valor)`:** Prioridad Up Next VIP tras la cabeza ($O(1)$).
3. **`AvanzarPista()`:** Desencola la pista sonando y actualiza la cabeza ($O(1)$).
4. **`Invertir()`:** Inversión de lista **estrictamente in-place** ($O(n)$ tiempo, $O(1)$ espacio) usando 3 referencias de memoria (`previo`, `actual`, `siguiente`).
5. **`InsertarOrdenado(T valor, comparador)`:** Ordenamiento armónico según curva de BPMs ($O(n)$).
6. **`DepurarDuplicados(sonIguales)`:** Purga de repetidos sin estructuras auxiliares usando puntero corredor ($O(n^2)$ tiempo, $O(1)$ memoria).

---

## 📊 4. Módulo de Benchmark y Telemetría
Evaluación con `Stopwatch` sometiendo las tres estructuras a 25,000 inserciones intermedias consecutivas:
* **Lista Enlazada Propia:** $O(1)$ — Reconexión de 2 referencias de memoria por inserción (~14 ms).
* **.NET LinkedList<T>:** $O(1)$ — Desempeño constante optimizado (~12 ms).
* **.NET List<T>:** $O(n)$ — Degradación de rendimiento severa debida al copiado masivo de memoria contigua (`Array.Copy`).

---

## 🎥 5. Video Demostrativo
* **Enlace al video:** [PEGA_AQUÍ_EL_LINK_DE_YOUTUBE_O_DRIVE]