using CrossRhythm.GameParameters;
using System.Linq;

public class ScoreCalculator{

	public int Calculate(int maxCombo, int perfectNum, int greatNum, int goodNum)
    {
        var perfectRate = perfectNum * GameParameters.JUDGE_COEFFICIENT[CrossRhythm.GameEnums.JudgeGrade.PERFECT];
        var greatRate = greatNum * GameParameters.JUDGE_COEFFICIENT[CrossRhythm.GameEnums.JudgeGrade.GREAT];
        var goodRate = goodNum * GameParameters.JUDGE_COEFFICIENT[CrossRhythm.GameEnums.JudgeGrade.GOOD];;


        return (int)((GameParameters.MAX_SCORE / maxCombo) * (perfectRate + greatRate + goodRate));
    }
}
