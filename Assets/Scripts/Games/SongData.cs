using System;
using UnityEngine;
using CrossRhythm.GameEnums;

[Serializable]
[CreateAssetMenu(menuName = "CrossRhythm/SongData")]
public class SongData : ScriptableObject {

    private const string PATH_PREFIX = "SongDatas/";

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

    [SerializeField]
    private int _maxNoteNum;
    public int MaxNoteNum => _maxNoteNum;

    public static SongData Load(string name)
    {
        var data = Resources.Load<SongData>($"{PATH_PREFIX}{name}/data_{name}");
        if (data == null)
        {
            Debug.LogError("楽曲情報を読み込めませんでした");
        }

        return data;
    }

}
