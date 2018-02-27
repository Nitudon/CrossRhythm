using UdonLib.Commons;
using System;
using UniRx;
using UniRx.Triggers;
using CrossRhythm.GameParameters;
using CrossRhythm.GameStructs;

public class SoundTimer : UdonBehaviour {

    private IObservable<Timing> _timer;
    public IObservable<Timing> Timer;

	public void SetMusicStream(AudioPlayer player)
    {
        _timer = MusicTimeObservable(player);
    }

    private IObservable<Timing> MusicTimeObservable(AudioPlayer player)
    {
        return this.UpdateAsObservable()
            .TakeWhile(_ => player.IsGameEnd == false)
            .Select(_ => player.Source.time)
            .DistinctUntilChanged()
            .Select(x => SongTiming(player.Song, x));
            
    }

    private Timing SongTiming(SongData song, float time)
    {
        return new Timing();
    }

}
