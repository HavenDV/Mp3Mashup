using System;
using System.Linq;
using Mp3Sum.Extensions;
using NAudio.Wave;
using NAudio.Wave.SampleProviders;

namespace Mp3Mashup.Utilities
{
    public static class Mp3Utilities
    {
        public static void CreateMashup(string to, params string[] files)
        {
            if (files.Length < 2)
            {
                throw new Exception("Not enough files selected!");
            }

            var internalFormat = WaveFormat.CreateIeeeFloatWaveFormat(16000, 1);
            var toFormat = WaveFormat.CreateIeeeFloatWaveFormat(44100, 1);
            var mixer = new MixingSampleProvider(internalFormat);

            var readers = files.Select(path => new Mp3FileReader(path)).ToList();
            var waveStreams = readers.Select(WaveFormatConversionStream.CreatePcmStream).ToList();
            var resampledEnumerable = waveStreams.Select(stream => new MediaFoundationResampler(stream, internalFormat)).ToList();
            foreach (var resampled in resampledEnumerable)
            {
                mixer.AddMixerInput(resampled);
            }

            var waveProvider = new SampleToWaveProvider(mixer);
            using (var resampler = new MediaFoundationResampler(waveProvider, toFormat))
            {
                MediaFoundationEncoder.EncodeToMp3(resampler, to);
            }

            resampledEnumerable.Dispose();
            waveStreams.Dispose();
            readers.Dispose();
        }
    }
}
