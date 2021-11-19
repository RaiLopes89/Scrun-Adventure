using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class carregarPerguntas : MonoBehaviour

{
    List<Perguntas> perguntas = new List<Perguntas>();

    // Start is called before the first frame update
    void Start()
    {
        TextAsset pergunta = Resources.Load<TextAsset>("perguntas");

        string[] data = pergunta.text.Split(new char[] { '\n' });

        for (int i = 1; i < data.Length - 1; i++)
        {
            string[] row = data[i].Split(new char[] { ',' });
            if (row[1] != "")
            {
                Perguntas p = new Perguntas();

                int.TryParse(row[0], out p.id);
                p.planeta = row[1];
                p.pergunta = row[2];
                p.resposta_correta = row[3];
                p.resposta_incorreta1 = row[4];
                p.resposta_incorreta2 = row[5];
                p.resposta_incorreta3 = row[6];

                perguntas.Add(p);
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
