using CrossRhythm.GameEnums;
using UdonLib.Commons;

public class SoundNote : UdonBehaviour {

    private NotePlace _place;
    public NotePlace Place => _place;

    private float _timing;
    public float Timing => _timing;

    private SoundNoteImage _noteImage;

    public SoundNote(SoundNoteImage noteImage, float timing)
    {
        _noteImage = noteImage;
        _timing = timing;
        SetOnDestroy(OnDestroy);
    }

    public void SetPosition()
    {

    }

    private void OnDestroy()
    {

    }
}
