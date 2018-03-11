using System;
using UnityEngine;
using UdonLib.Commons;
using UniRx;

[RequireComponent(typeof(SoundNote))]
public class SoundNoteMover : UdonBehaviour,IDisposable {

    [SerializeField]
    private SoundNote _note;

    private IDisposable _disposable;

	public void Initialize()
    {

    }

    public void Dispose()
    {

    }

    private void NoteMove()
    {

    }

}
