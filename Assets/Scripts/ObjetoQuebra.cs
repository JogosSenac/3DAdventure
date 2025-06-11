using UnityEngine;

public class ObjetoQuebra : MonoBehaviour
{
    [SerializeField] private int vidaObj;
    [SerializeField] private GameObject efeitoQuebra;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    public void Quebrar(int dano)
    {
        vidaObj -= dano;
        if (vidaObj <= 0)
        {
            Instantiate(efeitoQuebra, transform.position, Quaternion.identity);
            Destroy(gameObject);
        }
    }
}
