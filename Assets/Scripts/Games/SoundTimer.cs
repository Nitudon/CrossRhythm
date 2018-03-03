using UdonLib.Commons;
using System;
using UniRx;
using UniRx.Triggers;
using CrossRhythm.GameParameters;

public class SoundTimer : UdonBehaviour {

    private IObservable<Timing> _timer;
    public IObservable<Timing> Timer => _timer;

    private Timing _timing;
    private SongData _cachedSong;
    private float _beatTime;

	public void SetMusicStream(AudioPlayer player)
    {
        _timer = MusicTimeObservable(player);
    }

    private IObservable<Timing> MusicTimeObservable(AudioPlayer player)
    {
        return this.UpdateAsObservable()
            .TakeWhile(_ => player.IsGameEnd == false)
            .Select(_ => Music.Just);
    }

}
