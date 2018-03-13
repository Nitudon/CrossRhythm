namespace CrossRhythm.GameParameters
{
    using System.Collections.Generic;
    using GameEnums;
    using UnityEngine;

    public static class GameParameters
    {
        public readonly static float MINUTE_TIME = 60.0f;

        public readonly static int MAX_SCORE = 1000000;

        public readonly static Dictionary<JudgeGrade, float> JUDGE_COEFFICIENT = new Dictionary<JudgeGrade, float>
        {
            {JudgeGrade.PERFECT, 1.0f },
            {JudgeGrade.GREAT, 0.7f },
            {JudgeGrade.GOOD, 0.35f },
            {JudgeGrade.MISS, 0f },
        };

        public readonly static Dictionary<NotePlace, Vector3> NOTE_PLACES = new Dictionary<NotePlace, Vector3>
        {
            {NotePlace.LOWER_LEFT, new Vector3(-880f, -545f, 0f) },
            {NotePlace.LOWER_RIGHT, new Vector3(880f, -545f, 0f) },
            {NotePlace.UPPER_LEFT, new Vector3(-880f, 545f, 0f) },
            {NotePlace.UPPER_RIGHT, new Vector3(880f, 545f, 0f) },
        };
    }
}