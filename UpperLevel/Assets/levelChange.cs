using UnityEngine;

public class levelChange : MonoBehaviour
{
    public Animator animator;

    // Update is called once per frame
    void Update()
    {
        
    }

        public void FadeToLevel(int levelIndex)
    {
        animator.SetTrigger("fadeOut");
    }
}
