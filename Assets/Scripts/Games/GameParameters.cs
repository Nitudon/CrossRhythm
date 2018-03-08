namespace CrossRhythm.GameParameters
{
    using System.Collections.Generic;
    using GameEnums;

    public static class GameParameters
    {
        public readonly static float MINUTE_TIME = 60.0f;

        public readonly static int MAX_SCORE = 1000000;

        public static Dictionary<JudgeGrade, float> JUDGE_COEFFICIENT = new Dictionary<JudgeGrade, float>
        {
            {JudgeGrade.PERFECT, 1.0f },
            {JudgeGrade.GREAT, 0.7f },
            {JudgeGrade.GOOD, 0.35f },
            {JudgeGrade.MISS, 0f },
        };
    }
}