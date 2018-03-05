using UdonLib.Commons;
using CrossRhythm.GameEnums;
using Zenject;

public class SoundNoteCreator : UdonBehaviour {

    [Inject]
    private SoundTimer _soundTimer;

    protected override void Start()
    {
        base.Start();
        
    }

    private void Create()
    {

    }

}
