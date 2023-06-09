using Newtonsoft.Json.Linq;
using ScriptsOfTribute.Board.Cards;
using ScriptsOfTribute.Serializers;
using ScriptsOfTribute;
using System;
using System.Collections.Generic;
using System.Text;

namespace Bots
{
    class ElasticMCTSDefaultHeuristic : IHeuristic
    {
        private int patronFavour = 50;
        private int patronNeutral = 10;
        private int patronUnfavour = -50;
        private int powerValue = 40;
        private int prestigeValue = 50;
        private int agentOnBoardValue = 30;
        private int hpValue = 3;
        private int opponentAgentsPenaltyValue = 40;
        private int cardValue = 10;
        private int potentialComboValue = 3;
        private int penaltyForHighTierInTavern = 2;
        private int heuristicMax = 40000; //160
        private int heuristicMin = -10000;//00


        public double Value(SeededGameState gameState)
        {
            int finalValue = 0;
            int enemyPatronFavour = 0;
            foreach (KeyValuePair<PatronId, PlayerEnum> entry in gameState.PatronStates.All)
            {
                if (entry.Key == PatronId.TREASURY)
                {
                    continue;
                }
                if (entry.Value == gameState.CurrentPlayer.PlayerID)
                {
                    finalValue += patronFavour;
                }
                else if (entry.Value == PlayerEnum.NO_PLAYER_SELECTED)
                {
                    finalValue += patronNeutral;
                }
                else
                {
                    finalValue += patronUnfavour;
                    enemyPatronFavour += 1;
                }
            }
            if (enemyPatronFavour >= 2)
            {
                finalValue -= 100;
            }

            finalValue += gameState.CurrentPlayer.Power * powerValue;
            finalValue += gameState.CurrentPlayer.Prestige * prestigeValue;
            //finalValue += gameState.CurrentPlayer.Coins * coinsValue;

            if (gameState.CurrentPlayer.Prestige < 30)
            {
                TierEnum tier = TierEnum.UNKNOWN;

                foreach (SerializedAgent agent in gameState.CurrentPlayer.Agents)
                {
                    tier = CardTierList.GetCardTier(agent.RepresentingCard.Name);
                    finalValue += agentOnBoardValue * (int)tier + agent.CurrentHp * hpValue;
                }

                foreach (SerializedAgent agent in gameState.EnemyPlayer.Agents)
                {
                    tier = CardTierList.GetCardTier(agent.RepresentingCard.Name);
                    finalValue -= agentOnBoardValue * (int)tier + agent.CurrentHp * hpValue + opponentAgentsPenaltyValue;
                }

                List<UniqueCard> allCards = gameState.CurrentPlayer.Hand.Concat(gameState.CurrentPlayer.Played.Concat(gameState.CurrentPlayer.CooldownPile.Concat(gameState.CurrentPlayer.DrawPile))).ToList();
                Dictionary<PatronId, int> potentialComboNumber = new Dictionary<PatronId, int>();
                List<UniqueCard> allCardsEnemy = gameState.EnemyPlayer.Hand.Concat(gameState.EnemyPlayer.DrawPile).Concat(gameState.CurrentPlayer.Played.Concat(gameState.CurrentPlayer.CooldownPile)).ToList();
                Dictionary<PatronId, int> potentialComboNumberEnemy = new Dictionary<PatronId, int>();

                foreach (UniqueCard card in allCards)
                {
                    tier = CardTierList.GetCardTier(card.Name);
                    finalValue += (int)tier * cardValue;
                    if (card.Deck != PatronId.TREASURY)
                    {
                        if (potentialComboNumber.ContainsKey(card.Deck))
                        {
                            potentialComboNumber[card.Deck] += 1;
                        }
                        else
                        {
                            potentialComboNumber[card.Deck] = 1;
                        }
                    }
                }

                foreach (UniqueCard card in allCardsEnemy)
                {
                    if (card.Deck != PatronId.TREASURY)
                    {
                        if (potentialComboNumberEnemy.ContainsKey(card.Deck))
                        {
                            potentialComboNumberEnemy[card.Deck] += 1;
                        }
                        else
                        {
                            potentialComboNumberEnemy[card.Deck] = 1;
                        }
                    }
                }

                foreach (KeyValuePair<PatronId, int> entry in potentialComboNumber)
                {
                    finalValue += (int)Math.Pow(entry.Value, potentialComboValue);
                }

                foreach (Card card in gameState.TavernAvailableCards)
                {
                    tier = CardTierList.GetCardTier(card.Name);
                    finalValue -= penaltyForHighTierInTavern * (int)tier;
                    /*
                    if (potentialComboNumberEnemy.ContainsKey(card.Deck) && (potentialComboNumberEnemy[card.Deck]>4) && (tier > TierEnum.B)){
                        finalValue -= enemyPotentialComboPenalty*(int)tier;
                    }
                    */
                }

            }

            //int finalValue = gameState.CurrentPlayer.Power + gameState.CurrentPlayer.Prestige;
            double normalizedValue = NormalizeHeuristic(finalValue);

            return normalizedValue;
        }


        private double NormalizeHeuristic(int value)
        {
            double normalizedValue = ((double)value - (double)heuristicMin) / ((double)heuristicMax - (double)heuristicMin);

            if (normalizedValue < 0)
            {
                return 0.0;
            }

            return normalizedValue;
        }

    }
}
