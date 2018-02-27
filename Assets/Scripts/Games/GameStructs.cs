namespace CrossRhythm.GameStructs
{
    public struct SongData
    {
        public string Name;
        public float BPM;
        public float Time;

        public SongData(string name, float bpm, float time)
        {
            Name = name;
            BPM = bpm;
            Time = time;
        }
    }
}