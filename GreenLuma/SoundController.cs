using System.IO;
using System.Media;


namespace GreenLuma
{
    public static class SoundController
    {
        private static readonly SoundPlayer soundPlayer = new SoundPlayer();


        public static void PlaySound(Stream soundStream)
        {
            soundPlayer.Stream = soundStream;
            soundPlayer.Play();
        }
    }
}
