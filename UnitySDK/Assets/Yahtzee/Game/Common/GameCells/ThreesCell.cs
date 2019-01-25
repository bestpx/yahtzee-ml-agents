namespace Yahtzee.Game.Common.GameCells
{
    public class ThreesCell : GameCell
    {
        public override int EvaluateScore(Hand hand, Gameboard gameboard, bool includeSectionBonus)
        {
            return EvaluateNumberCategoryCell(gameboard, hand, 3, includeSectionBonus);
        }

        public override int MeanExpectation(Gameboard gameboard)
        {
            return 9;
        }

        public override int MaximumPossible(Gameboard gameboard)
        {
            int maxPossible = 15;
            if (gameboard.ShouldHaveYahtzeeBonus())
            {
                maxPossible += gameboard.YahtzeeBonus;
            }
            return maxPossible;
        }
    }
}