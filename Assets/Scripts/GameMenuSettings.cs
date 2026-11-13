using UnityEngine;

public enum GameMode
{
    Infinite,
    OneMinute
}

[CreateAssetMenu(fileName = "GameMenuSettings", menuName = "Medieval UI/Game Menu Settings")]
public class GameMenuSettings : ScriptableObject
{
    [Header("Default Mode Settings")]
    [Tooltip("Default selected mode when the menu loads.")]
    public GameMode defaultGameMode = GameMode.Infinite;

    [Header("Timer Settings")]
    [Tooltip("Duration in seconds for the timed mode.")]
    public int defaultTimeLimit = 60;

    [Header("Score Settings")]
    [Tooltip("Starting score value.")]
    public int startingScore = 0;
}