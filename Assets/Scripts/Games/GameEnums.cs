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
    /// タイミング判定
    /// </summary>
    public enum JudgeGrade
    {
        PERFECT,//ジャスト
        GREAT,
        GOOD,
        MISS,//0点
    }

}