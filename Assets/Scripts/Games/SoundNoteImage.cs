using UnityEngine;
using CrossRhythm.GameEnums;

[CreateAssetMenu(menuName = "CrossRhythm/SoundNoteData")]
public class SoundNoteImage : ScriptableObject{

    private const string PATH_PREFIX = "NoteDatas/";

    private Texture2D _texture;

    public static SoundNoteImage Load(NoteType type)
    {
        var note = Resources.Load<SoundNoteImage>($"{PATH_PREFIX}note_{type}");
        if (note == null)
        {
            Debug.Log("ノーツ情報を読み込めませんでした");
        }

        return null;
    }

}
