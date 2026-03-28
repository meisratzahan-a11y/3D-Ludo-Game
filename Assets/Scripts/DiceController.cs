using UnityEngine;

public class DiceController : MonoBehaviour
{
    private int lastRoll = 0;
    private Animator animator;

    void Start()
    {
        animator = GetComponent<Animator>();
    }

    public void RollDice()
    {
        lastRoll = Random.Range(1, 7);
        AnimateDice(lastRoll);
        Debug.Log("Dice Rolled: " + lastRoll);
    }

    private void AnimateDice(int roll)
    {
        // Implement the animation triggering logic here
        // This is a placeholder for the actual animation implementation
        animator.SetTrigger("Roll");
    }
}