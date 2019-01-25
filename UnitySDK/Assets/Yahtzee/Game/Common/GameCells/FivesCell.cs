namespace Yahtzee.Game.Common.GameCells
{
    public class FivesCell : GameCell
    {
        public override int EvaluateScore(Hand hand, Gameboard gameboard, bool includeSectionBonus = false)
        {
            return EvaluateNumberCategoryCell(gameboard, hand, 5, includeSectionBonus);
        }

        public override int MeanExpectation(Gameboard gameboard)
        {
            return 15;
        }

        public override int MaximumPossible(Gameboard gameboard)
        {
            int maxPossible = 25;
            if (gameboard.ShouldHaveYahtzeeBonus())
            {
                maxPossible += gameboard.YahtzeeBonus;
            }
            return maxPossible;
        }
    }
}