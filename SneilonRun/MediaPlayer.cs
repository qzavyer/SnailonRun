using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using NAudio.Wave;

namespace SnailonRun
{
    internal interface IMediaPlayer
    {
        void Play();
        void Stop();
        void VolumeUp();
        void VolumeDown();
        void Next();
        void SetVolume(float value);
    }

    class MediaPlayer : IMediaPlayer
    {
        private IWavePlayer _player = new WaveOut();
        private AudioFileReader _provider;
        private readonly string[] _files;
        private readonly List<int> _indexes=new List<int>();
        private int _index;

        public MediaPlayer(string catalog)
        {
            _files = Directory.GetFiles(catalog, "*.mp3");
            for (var i = 0; i < _files.Count(); i++)
            {
                _indexes.Add(i);
            }
            if(_indexes.Count<2) return;
            ResortIndexes();
            SetProvider(_files[_indexes[_index]]);
            _player.PlaybackStopped += NextPlay;
        }

        /// <summary>
        /// Проиграть
        /// </summary>
        public void Play()
        {
            switch (_player.PlaybackState)
            {
                case PlaybackState.Paused:
                    _player.Play();
                    break;
                case PlaybackState.Playing:
                    _player.Pause();
                    break;
                case PlaybackState.Stopped:
                    SetProvider(_files[_indexes[_index]]);
                    _player.Play();
                    break;
            }
        }

        /// <summary>
        /// Остановить
        /// </summary>
        public void Stop()
        {
            _player.Stop();
            _provider.Dispose(); 
            _player.Dispose();
        }

        /// <summary>
        /// Увеличить громкость
        /// </summary>
        public void VolumeUp()
        {
            if(_provider.Volume>0.99)return;
            _provider.Volume = _provider.Volume + 0.05f;
            if (_provider.Volume > 1) _provider.Volume = 1;
        }

        /// <summary>
        /// Уменьшить громкость
        /// </summary>
        public void VolumeDown()
        {
            if(_provider.Volume<0.001) return;
            _provider.Volume = _provider.Volume - 0.05f;
            if (_provider.Volume < 0) _provider.Volume = 0;
        }

        /// <summary>
        /// Следующая композиция
        /// </summary>
        public void Next()
        {
            _index++;
            if (_index >= _indexes.Count)
                ResortIndexes();
            Play();
        }

        /// <summary>
        /// Установить громкость
        /// </summary>
        /// <param name="value">Значение громкости</param>
        public void SetVolume(float value)
        {
            _provider.Volume = value;
        }

        /// <summary>
        /// Перехватчик окончания текущей композиции
        /// </summary>
        private void NextPlay(object o, EventArgs e)
        {
            Next();
        }

        /// <summary>
        /// Установка текущего аудиофайла
        /// </summary>
        /// <param name="fileName">Имя файла</param>
        private void SetProvider(string fileName)
        {
            float volume;
            if (_provider != null)
            {
                volume = _provider.Volume;
                _provider.Dispose();
                _player.Dispose();
            }
            else
            {
                volume = 0.45f;
            }
            _provider = new AudioFileReader(fileName) {Volume = volume};
            _player = new WaveOut();
            _player.Init(_provider);
        }

        private void ResortIndexes()
        {
            if (_indexes.Count < 2) return;
            var rand = new Random();
            for (var i = _files.Count() - 1; i > 2; i--)
            {
                var index = rand.Next(i);
                var temp = _indexes[i];
                _indexes[i] = _indexes[index];
                _indexes[index] = temp;
            }
            _index = 0;
        }
    }
}
