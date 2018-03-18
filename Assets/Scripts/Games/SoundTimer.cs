using UdonLib.Commons;
using System;
using UniRx;
using UniRx.Triggers;
using CrossRhythm.GameParameters;

public class SoundTimer : UdonBehaviour {

    private IObservable<Unit> _timer;
    public IObservable<Unit> Timer => _timer;

    public IObservable<Timing> MusicTimeObservable => _timer.Select(_ => Music.Just);
    public IObservable<double> GameTimeObservable => _timer.Select(_ => Music.TimeSecFromJust);

    private float _gameSpeed = 1.0f;

    private SongData _cachedSong;
    private float _beatTime;

	public void SetMusicStream(AudioPlayer player)
    {
        SetGameTimer(player);
    }

    private void SetGameTimer(AudioPlayer player)
    {
        _timer = this.UpdateAsObservable()
            .TakeWhile(_ => player.IsGameEnd == false)
            .Publish()
            .RefCount();
    }

}
