using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Fader : MonoBehaviour
{
    [SerializeField]
    private Image faderImg;
    [SerializeField]
    private Animator animator;

    public void LoadScene(int sceneIndex)
    {
        print(animator);
        animator.SetBool("Fade", true);
        StartCoroutine("Fading", sceneIndex);
    }

    private IEnumerator Fading(int index)
    {
        yield return new WaitForSeconds(2);
        SceneManager.LoadScene(index);
    }
}
