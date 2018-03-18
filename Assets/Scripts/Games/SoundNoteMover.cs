using System;
using System.Collections.Generic;
using UdonLib.Commons;
using System.Linq;
using UniRx;
using Zenject;
using CrossRhythm.GameParameters;

public class SoundNoteMover : UdonBehaviour,IDisposable {

    [Inject]
    private SoundTimer _timer;

    private float _moveInterval = 2f;

    private List<SoundNote> _currentNotes;

    private IDisposable _disposable;

	public void Initialize()
    {
        _currentNotes = new List<SoundNote>();

        _disposable = _timer.GameTimeObservable
            .Where(_ => _currentNotes.Count > 0)
            .Subscribe(time => _currentNotes.ForEach(note => NoteMove(note,time)))
            .AddTo(this);
    }

    public void AddNote(SoundNote note)
    {
        _currentNotes.Add(note);
    }

    public void Dispose()
    {
        _disposable.Dispose();
    }

    private void NoteMove(SoundNote note, double time)
    {
        if (note.IsDestroyed)
        {
            return;
        }

        var noteTime = note.Timing.ToSeconds();
        var currentTime = Music.AudioTimeSec;

        note.SetLocalPosition(GameParameters.NOTE_PLACES[(int)note.Place] * (noteTime - currentTime) * _moveInterval);
    }

}
