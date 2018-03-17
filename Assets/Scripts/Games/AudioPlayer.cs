using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using CrossRhythm.GameStructs;
using UdonLib.Commons;
using UniRx;
using Zenject;

[RequireComponent(typeof(AudioSource))]
[RequireComponent(typeof(Music))]
public class AudioPlayer : UdonBehaviour {

    [SerializeField]
    private AudioSource _source;
    public AudioSource Source => _source;

    [SerializeField]
    private SongData _song;
    public SongData Song => _song;

    [Inject]
    private SoundTimer _timer;

    private bool _isGameEnd = false;
    public bool IsGameEnd => _isGameEnd;

    protected override void Start()
    {
        Initialize();
        _source.clip = _song.Clip;
        _source.Play();
        _timer.SetMusicStream(this);
        _timer.Timer.Subscribe(x => Debug.Log(x));
    }

    private void Initialize()
    {
        if (_song == null)
        {
            Debug.LogError("SongData is Missing");
        }
        else
        {
            Music.CurrentSection.UnitPerBar = (int)_song.UnitPerBar;
            Music.CurrentSection.UnitPerBeat = (int)_song.UnitPerBeat;
            Music.CurrentSection.Tempo = _song.BPM;
        }
    }
}
