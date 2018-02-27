using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using CrossRhythm.GameStructs;

public class AudioPlayer : MonoBehaviour {

    [SerializeField]
    private AudioSource _source;

    public AudioSource Source => _source;

    private SongData _song;
    public SongData Song => _song;

    private bool _isGameEnd = false;
    public bool IsGameEnd => _isGameEnd;
}
