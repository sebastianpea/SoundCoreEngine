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
    public class TagLibReader : IAudioMetadataProvider
    {
        public int? ReadBpm(string filePath)
        {
            try
            {
                using var file = TagLib.File.Create(filePath);
                uint bpm = file.Tag.BeatsPerMinute;
                return bpm > 0 ? (int)bpm : null;
            }
            catch (Exception)
            {
                // Corrupt file, unsupported format, or no read permissions.
                return null;
            }
        }

        public int ReadDurationSeconds(string filePath)
        {
            try
            {
                using var file = TagLib.File.Create(filePath);
                return (int)file.Properties.Duration.TotalSeconds;
            }
            catch (Exception)
            {
                return 0;
            }
        }
        public string? ReadTitle(string filePath)
        {
            try
            {
                using var file = TagLib.File.Create(filePath);
                return string.IsNullOrWhiteSpace(file.Tag.Title) ? null : file.Tag.Title;
            }
            catch (Exception)
            {
                return null;
            }
        }
        public string? ReadArtist(string filePath)
        {
            try
            {
                using var file = TagLib.File.Create(filePath);
                return file.Tag.Performers.Length > 0 ? file.Tag.Performers[0] : null;
            }
            catch (Exception)
            {
                return null;
            }
        }

    }
}
