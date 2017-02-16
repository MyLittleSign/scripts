using UnityEngine;
using System.Collections;
using System;

public class LetterButton : MonoBehaviour
{
	/* Cada botão que leva a uma cena de aprendizado de letras tem uma tag contendo a letra dele.
	 * Exemplo de tag: "g"	 * 
	 * O atual script será anexado a um botão, e através de sua tag, reconhecerá a letra com a qual deve trabalhar.
	 * Após reconhecer a letra, obterá todas as informações necessárias ao botão:
	 *   - Disponível ou não ao usuário.
	 * Após descobrir se está disponível ou não, este script altera a imagem do botão para a disponibilidade ficar
	 * aparente.
	 */

	private string letter;

	// s_enabled contém a string necessária para acesso através do PlayerPrefs
	// enabled informará se a letra atual está disponível para aprendizado ou não
	private string s_enabled;
	private int enabled;

	private void Awake ()
	{
		letter = gameObject.tag;

		s_enabled = String.Concat ("enabled_", letter);

		if (!PlayerPrefs.HasKey (s_enabled))
		{
			PlayerPrefs.SetInt (s_enabled, 0);
		}
		else
		{
			enabled = PlayerPrefs.GetInt (s_enabled);
		}
	}
}
