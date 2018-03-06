using CrossRhythm.GameEnums;
using UdonLib.Commons;

public class SoundNote : UdonBehaviour {

    private NotePlace _place;
    public NotePlace Place => _place;

    private Timing _timing;
    public Timing Timing => _timing;

    private SoundNoteImage _noteImage;

    public static SoundNote Create(SoundNoteImage noteImage, Timing timing)
    {
        SoundNote note = new SoundNote(noteImage, timing);
        return note;
    }

    public SoundNote(SoundNoteImage noteImage, Timing timing)
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
