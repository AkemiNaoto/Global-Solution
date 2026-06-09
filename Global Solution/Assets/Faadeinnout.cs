using UnityEngine;
using TMPro;

public class Faadeinnout : MonoBehaviour
{
    private TextMeshPro tmp;
    public float velocidade = 1f;

    void Start()
    {
        tmp = GetComponent<TextMeshPro>();
    }

    void Update()
    {
        float alpha = 0.25f + Mathf.Sin(Time.time * velocidade) * 0.20f;

        Color cor = tmp.color;
        cor.a = alpha;
        tmp.color = cor;
    }
}