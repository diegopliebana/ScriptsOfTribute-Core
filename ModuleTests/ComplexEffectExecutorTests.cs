﻿using TalesOfTribute;
using TalesOfTribute.Board.Cards;
using TalesOfTribute.Serializers;

namespace ModuleTests;

public class ComplexEffectExecutorTests
{
    [Fact]
    void AcquiringContractActionShouldReturnItToTavern()
    {
        var hand = new List<UniqueCard>
        {
            GlobalCardDatabase.Instance.GetCard(CardId.HLAALU_KINSMAN)
        };

        var currentPlayer = new SerializedPlayer(PlayerEnum.PLAYER1, hand, new List<UniqueCard>(),
            new List<UniqueCard>(), new List<UniqueCard>(), new List<SerializedAgent>(), 0, 0, 100, 0);
        var enemyPlayer = new SerializedPlayer(PlayerEnum.PLAYER2, new List<UniqueCard>(), new List<UniqueCard>(),
            new List<UniqueCard>(), new List<UniqueCard>(), new List<SerializedAgent>(), 0, 0, 0, 0);

        var tavernAvailableCards = new List<UniqueCard>
        {
            GlobalCardDatabase.Instance.GetCard(CardId.KWAMA_EGG_MINE),
        };
        var tavernCards = new List<UniqueCard>
        {
            GlobalCardDatabase.Instance.GetCard(CardId.GOLD),
        };

        var board = new SerializedBoard(currentPlayer, enemyPlayer, new PatronStates(new List<Patron>()),
            tavernAvailableCards, tavernCards, 123);

        var (newState, _) = board.ApplyState(Move.PlayCard(hand[0]));
        (newState, _) = newState.ApplyState(Move.MakeChoice(new List<UniqueCard> { tavernAvailableCards[0] }));
        Assert.Contains(CardId.KWAMA_EGG_MINE, newState.TavernCards.Select(c => c.CommonId));
    }
}