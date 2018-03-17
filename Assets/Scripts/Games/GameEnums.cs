/// <summary>
/// ゲーム中で使う列挙型
/// </summary>
namespace CrossRhythm.GameEnums{

    /// <summary>
    /// ノーツのレーン位置
    /// </summary>
    public enum NotePlace
    {
        NONE,//不定

        UPPER_LEFT,//左上
        UPPER_RIGHT,//右上
        LOWER_LEFT,//左下
        LOWER_RIGHT,//右下
    }

    /// <summary>
    /// ノーツの種類
    /// </summary>
    public enum NoteType
    {
        NONE,//不定

        SINGLETAP,//単タップ
        MULTITAP,//複タップ
        SINGLESLUSH,//単スラッシュ
        MULTISLUSH,//複スラッシュ
        SINGLEHOLD,//単ロング
        MULTIHOLD,//複ロング
    }

    /// <summary>
    /// タイミング判定
    /// </summary>
    public enum JudgeGrade
    {
        PERFECT,//ジャスト
        GREAT,
        GOOD,
        MISS,//0点
    }

    /// <summary>
    /// 難易度
    /// </summary>
    public enum Difficulty
    {
        EASY,
        NORMAL,
        HARD,
        EXTREME,
    }

}