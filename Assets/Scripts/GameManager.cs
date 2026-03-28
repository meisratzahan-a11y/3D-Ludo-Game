using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;

    public enum GameState { Waiting, Playing, GameOver }
    public GameState CurrentState;

    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }

    private void Start()
    {
        CurrentState = GameState.Waiting;
        InitializeGame();
    }

    private void InitializeGame()
    {
        // Initialize players, board setup, etc.
        Debug.Log("Game Initialized. Waiting for players...");
    }

    public void StartGame()
    {
        CurrentState = GameState.Playing;
        Debug.Log("Game Started. Players can begin their turns.");
    }

    public void EndGame()
    {
        CurrentState = GameState.GameOver;
        Debug.Log("Game Over! Display results.");
    }

    public void PlayerTurn(int playerId)
    {
        if (CurrentState == GameState.Playing)
        {
            // Logic for player's turn
            Debug.Log($"Player {playerId}'s turn.");
            // e.g. Move players, roll dice, etc.
        }
        else
        {
            Debug.Log("Game is not currently in play.");
        }
    }
}