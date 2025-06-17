using TMPro;
using UnityEngine;

public class SistemaMonetario : MonoBehaviour
{
    [SerializeField] private int ouro = 0;
    [SerializeField] private TextMeshProUGUI textoOuro;

    void Start()
    {
        if (textoOuro == null)
        {
            textoOuro = GameObject.Find("TextoOuro").GetComponent<TextMeshProUGUI>();
        }

        AtualizarTextoOuro();
    }

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.CompareTag("Ouro"))
        {
            ouro++;
            AtualizarTextoOuro();
            Destroy(collision.gameObject);
        }
    }

    private void AtualizarTextoOuro()
    {
        if (textoOuro != null)
        {
            textoOuro.text = ouro.ToString();
        }
        else
        {
            Debug.LogWarning("TextoOuro não está definido!");
        }
    }

}
