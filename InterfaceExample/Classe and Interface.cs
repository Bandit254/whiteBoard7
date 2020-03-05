using System;

namespace InterfaceExample
{
    public interface IStreamingDevice
    {
        public string deviceName { get; set; }
        public bool IsPlaying { get; set; }
        bool Play();
        void Pause();
        void Ffwd();
        void Rewind();
        bool stop();

    }

    public class DVDPlayer : IStreamingDevice
    {
        public string deviceName { get => "My DVD Player";
            set => deviceName = value;
        }
        public bool IsPlaying { get => IsPlaying; set => IsPlaying = value; }

        void IStreamingDevice.Ffwd()
        {
            throw new NotImplementedException();
        }

        void IStreamingDevice.Pause()
        {
            throw new NotImplementedException();
        }

        bool IStreamingDevice.Play()
        {
            throw new NotImplementedException();
        }

        void IStreamingDevice.Rewind()
        {
            throw new NotImplementedException();
        }

        bool IStreamingDevice.stop()
        {
            throw new NotImplementedException();
        }
    }
}
