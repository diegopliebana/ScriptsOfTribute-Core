﻿namespace TalesOfTribute;

public interface IPlayer
{
    PlayerEnum ID { get; set; }
    int CoinsAmount { get; set; }
    int PrestigeAmount { get; set; }
    int PowerAmount { get; set; }
    public uint PatronCalls { get; set; }
    List<Card> Hand { get; set; }
    List<Card> DrawPile { get; set; }
    List<Card> Played { get; set; }
    List<Card> Agents { get; set; }
    List<Card> CooldownPile { get; set; }
    ExecutionChain? StartOfTurnEffectsChain { get; }
    ExecutionChain PlayCard(Card cardId, IPlayer other, ITavern tavern);
    void HandleAcquireDuringExecutionChain(Card card, IPlayer other, ITavern tavern);
    void HealAgent(Guid guid, int amount);
    void Refresh(Card cardId);
    void Draw();
    void EndTurn();
    ExecutionChain AcquireCard(Card card, IPlayer enemy, ITavern tavern, bool replacePendingExecutionChain = true);
    void Toss(Card cardId);
    void Discard(Card card);
    void KnockOut(Card cardId);
    void AddToCooldownPile(Card card);
    void Destroy(Card cardId);
    string ToString();
    List<Card> GetAllPlayersCards();
    void AddStartOfTurnEffects(ExecutionChain chain);
}