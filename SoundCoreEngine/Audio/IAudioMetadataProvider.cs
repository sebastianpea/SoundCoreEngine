using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoundCoreEngine.Audio
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
    //translate to English
    public interface IAudioMetadataProvider
    {
        // Tries to read the BPM embedded in the file tags (ID3v2, Vorbis, etc.).
        // Returns null if the file does not contain the data or the tag is unreadable.
        int? ReadBpm(string filePath);
        int ReadDurationSeconds(string filePath);

        string? ReadTitle(string filePath);

        string? ReadArtist(string filePath);
    }
}
