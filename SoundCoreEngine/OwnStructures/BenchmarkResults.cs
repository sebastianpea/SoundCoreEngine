using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoundCoreEngine.OwnStructures
{
    // ============================================================================
    // INSTITUTO TECNOLÓGICO DE MONCLOVA (TecNM)
    // ASIGNATURA: Estructura de Datos - Unidad 2
    // PROYECTO: SoundCore Engine GUI - DJ Queue & Transition Manager
    // AUTORES: Sebastian Ponce Carmona
    // I25050377
    // FECHA: 29/09/2026
    // VERSIÓN: 2.0 (.NET 10.0 / C# 14)
    // ============================================================================
    public record BenchmarkResults(
    int Insertions,
    long MillisecondsCustomList,
    long MillisecondsLinkedList,
    long MillisecondsList)
    {
        public string Conclusion =>
           $"En {Insertions:N0} inserciones intermedias, la Lista Enlazada Propia " +
        $"({MillisecondsCustomList} ms) y LinkedList<T> ({MillisecondsLinkedList} ms) " +
        $"superan a List<T> ({MillisecondsList} ms) porque reconectan referencias " +
        $"en O(1) en lugar de ejecutar Array.Copy en cada inserción.";
    }
}
