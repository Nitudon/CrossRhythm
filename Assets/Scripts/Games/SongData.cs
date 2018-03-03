using System;
using UnityEngine;

[Serializable]
public class SongData : ScriptableObject {

    [SerializeField]
    private Texture _jacket;

    [SerializeField]
    private AudioClip _clip;
    public AudioClip Clip => _clip;

    [SerializeField]
    private float _bpm;
    public float BPM => _bpm;

    [SerializeField]
    private float _time;
    public float Time => _time;

    [SerializeField]
    private uint _unitPerBeat = 4;
    public uint UnitPerBeat => _unitPerBeat;

    [SerializeField]
    private uint _unitPerBar = 16;
    public uint UnitPerBar => _unitPerBar;

}
