using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "novoDialogo" , menuName = "Scriptable/Perfil", order = 0)]
public class Dialogo : ScriptableObject
{
    public PerfilPersonagem Personagem;
    public List<string> lista;
}
