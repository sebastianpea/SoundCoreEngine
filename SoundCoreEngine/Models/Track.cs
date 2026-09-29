using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoundCoreEngine.Models
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
    public record Track(int Id, string Title, string Artist, int Bpm, int Seconds, string FilePath = "")
    {
        public override string ToString() =>
               $"[ID: {Id:D3}] {Title} - {Artist} | {Bpm} BPM ({Seconds}s)";
    }
}