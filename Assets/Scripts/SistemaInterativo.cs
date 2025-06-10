using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class SistemaInterativo : MonoBehaviour
{
    [SerializeField] private Sprite sTrancado;
    [SerializeField] private Sprite sAberto;
    [SerializeField] private Sprite sInteragir;
    [SerializeField] private Sprite sClose;
    [SerializeField] private Sprite sPlay;
    [SerializeField] private Sprite sLigar;
    [SerializeField] private Image spriteInterface;
    [SerializeField] private float tempoExibir;

    private void Start()
    {
        spriteInterface.enabled = false;
    }

    public void ExibirLigar()
    {
        StartCoroutine(ExibirSprite(sLigar));
    }
    public void ExibirPlay()
    {
        StartCoroutine(ExibirSprite(sPlay));
    }

    public void ExibirFechar()
    {
        StartCoroutine(ExibirSprite(sClose));
    }

    public void ExibirTrancado()
    {
        StartCoroutine(ExibirSprite(sTrancado));
    }

    public void ExibirDestrancado()
    {
        StartCoroutine(ExibirSprite(sAberto));
    }

    public void ExibirInteragir()
    {
        StartCoroutine(ExibirSprite(sInteragir));
    }

    IEnumerator ExibirSprite(Sprite s)
    {
        spriteInterface.enabled = true;
        spriteInterface.sprite = s;
        yield return new WaitForSeconds(tempoExibir);
        spriteInterface.enabled = false;
    }
}
